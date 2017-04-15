using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SqlServer.Symbol;
using Test.Helper;
using LambdicSql.SqlServer;
using System;

namespace Test
{
    [TestClass]
    public class TestSymbolClausesControlOfFlow
    {
        public TestContext TestContext { get; set; }
        public IDbConnection _connection;

        [TestInitialize]
        public void TestInitialize()
        {
            _connection = TestEnvironment.CreateConnection(TestContext);
            _connection.Open();
        }

        [TestCleanup]
        public void TestCleanup() => _connection.Dispose();

        public class SelectData
        {
            public DateTime PaymentDate { get; set; }
            public decimal Money { get; set; }
            public string Name { get; set; }
        }

        [TestMethod]
        public void Test_If_Else()
        {
            var sql = Db<DB>.Sql(db =>
                If(Object_Id(db.tbl_remuneration) != null).
                    Select(new SelectData
                    {
                        PaymentDate = db.tbl_remuneration.payment_date,
                        Money = db.tbl_remuneration.money,
                    }).
                    From(db.tbl_remuneration).
                Else().
                    Select(new SelectData
                    {
                        Name = db.tbl_staff.name
                    }).
                    From(db.tbl_staff)
                );

            var datas = _connection.Query(sql).ToList();
            AssertEx.AreEqual(sql, _connection,
 @"IF (OBJECT_ID(@p_0)) IS NOT NULL
SELECT
	tbl_remuneration.payment_date AS PaymentDate,
	tbl_remuneration.money AS Money
FROM tbl_remuneration
ELSE
SELECT
	tbl_staff.name AS Name
FROM tbl_staff", "tbl_remuneration");
        }

        [TestMethod]
        public void Test_Begin_End()
        {
            var sql = Db<DB>.Sql(db =>
                Begin().
                    Select(Asterisk(db.tbl_staff)).
                    From(db.tbl_staff).
                End());
            var datas = _connection.Query(sql).ToList();
            AssertEx.AreEqual(sql, _connection,
@"BEGIN
SELECT *
FROM tbl_staff
END");
        }

        [TestMethod]
        public void Test_While()
        {
            var sql = Db<DB>.Sql(db =>
                While(Select(Avg(db.tbl_remuneration.money)).From(db.tbl_remuneration) < 2000).
                Begin().
                    Select(Asterisk(db.tbl_remuneration)).
                    From(db.tbl_remuneration).
                End());

            _connection.Query(sql).ToList();
            AssertEx.AreEqual(sql, _connection,
@"WHILE
	((SELECT
		AVG(tbl_remuneration.money)
	FROM tbl_remuneration))
	 <
	(@p_0)
BEGIN
SELECT *
FROM tbl_remuneration
END", (double)2000);
        }

        [TestMethod]
        public void Test_Break_Continue_Return()
        {
            var sql = Db<DB>.Sql(db =>
                While(Select(Avg(db.tbl_remuneration.money)).From(db.tbl_remuneration) < 2000).
                Begin().
                    Break().Semicolon().
                    Continue().Semicolon().
                    Return().Semicolon().
                End());

            _connection.Query<object>(sql).ToList();
            AssertEx.AreEqual(sql, _connection,
@"WHILE
	((SELECT
		AVG(tbl_remuneration.money)
	FROM tbl_remuneration))
	 <
	(@p_0)
BEGIN
BREAK
;
CONTINUE
;
RETURN
;
END", (double)2000);
        }

        [TestMethod]
        public void Test_GoTo()
        {
            var sql = Db<DB>.Sql(db =>
                Label("Branch_One").
                    Select("Jumping To Branch One.").
                    GoTo("Branch_Three").Semicolon().
                Label("Branch_Two").
                    Select("Jumping To Branch Two.").
                Label("Branch_Three").
                    Select("Jumping To Branch Three.")
            );

            _connection.Query(sql).ToList();
            AssertEx.AreEqual(sql, _connection,
@"Branch_One:
SELECT
	@p_0
GOTO Branch_Three
;
Branch_Two:
SELECT
	@p_1
Branch_Three:
SELECT
	@p_2", "Jumping To Branch One.", "Jumping To Branch Two.", "Jumping To Branch Three.");
        }

        [TestMethod]
        public void Test_Try_Catch_throw()
        {
            var sql = Db<DB>.Sql(db =>
                Begin().Try().
                    Throw(1, "a", 1).
                 End().Try().
                 Begin().Catch().
                 End().Catch()
            );

            _connection.Query<object>(sql).ToList();

            AssertEx.AreEqual(sql, _connection,
@"BEGIN
TRY
THROW @p_0, @p_1, @p_2
END
TRY
BEGIN
CATCH
END
CATCH", 1, "a", (byte)1);
        }

        [TestMethod]
        public void Test_WaitForDelay()
        {
            var sql = Db<DB>.Sql(db =>
                Begin().
                   WaitForDelay("00:00:01").
                End()
            );

            _connection.Query<object>(sql).ToList();
            AssertEx.AreEqual(sql, _connection,
@"BEGIN
WAITFOR DELAY @p_0
END", "00:00:01");
        }

        //I have succeeded in testing.
        //It is difficult to test every time.
        /*
        [TestMethod]
        public void Test_WaitForTime()
        {
            var sql = Db<DB>.Sql(db =>
                Begin().
                   WaitForTime("11:44").
                End()
            );

            _connection.Query<object>(sql).ToList();
            AssertEx.AreEqual(sql, _connection,
@"BEGIN
WAITFOR TIME @p_0
END", "11:44");
        }*/
    }
}
