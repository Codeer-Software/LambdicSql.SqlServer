using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SqlServer.Symbol;
using Test.Helper;
using LambdicSql.SqlServer;

namespace Test
{
    [TestClass]
    public class TestSymbolFuncsAnalytic
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

        [TestMethod]
        [Priority(1)]
        public void Test_Cume_Dist()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Cume_Dist().
                            Over(OrderBy(Asc(db.tbl_remuneration.money)))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CUME_DIST()
	OVER(
		ORDER BY
			tbl_remuneration.money ASC) AS Val
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_First_Value()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = First_Value(db.tbl_remuneration.money).
                            Over(PartitionBy(db.tbl_remuneration.payment_date),
                                OrderBy(Asc(db.tbl_remuneration.money)),
                                Rows(1, 5))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FIRST_VALUE(tbl_remuneration.money)
	OVER(
		PARTITION BY
			tbl_remuneration.payment_date
		ORDER BY
			tbl_remuneration.money ASC
		ROWS BETWEEN 1 PRECEDING AND 5 FOLLOWING) AS Val
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Last_Value()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Last_Value(db.tbl_remuneration.money).
                            Over(PartitionBy(db.tbl_remuneration.payment_date),
                                OrderBy(Asc(db.tbl_remuneration.money)),
                                Rows(1, 5))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	LAST_VALUE(tbl_remuneration.money)
	OVER(
		PARTITION BY
			tbl_remuneration.payment_date
		ORDER BY
			tbl_remuneration.money ASC
		ROWS BETWEEN 1 PRECEDING AND 5 FOLLOWING) AS Val
FROM tbl_remuneration");
        }

        [Priority(1)]
        [TestMethod]
        public void Test_Lag_1()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Lag(3).
                            Over(OrderBy(Asc(db.tbl_remuneration.money)))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	LAG(@p_0)
	OVER(
		ORDER BY
			tbl_remuneration.money ASC) AS Val
FROM tbl_remuneration", 3);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Lag_2()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Lag(db.tbl_remuneration.money, 2).
                            Over(OrderBy(Asc(db.tbl_remuneration.money)))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	LAG(tbl_remuneration.money, @p_0)
	OVER(
		ORDER BY
			tbl_remuneration.money ASC) AS Val
FROM tbl_remuneration", (long)2);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Percent_Rank()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    ValDouble = Percent_Rank().
                            Over(OrderBy(Asc(db.tbl_remuneration.money)))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	PERCENT_RANK()
	OVER(
		ORDER BY
			tbl_remuneration.money ASC) AS ValDouble
FROM tbl_remuneration");
        }
    }
}