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
    public class TestSymbolFuncsAggregate
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
        public void Test_Sum()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new 
               {
                   Val1 = Sum(db.tbl_remuneration.money),
                   Val2 = Sum(All(), db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration).
                   Join(db.tbl_staff, db.tbl_remuneration.staff_id == db.tbl_staff.id).
               GroupBy(db.tbl_staff.id, db.tbl_staff.name));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	SUM(tbl_remuneration.money) AS Val1,
	SUM(ALL tbl_remuneration.money) AS Val2
FROM tbl_remuneration
	JOIN tbl_staff ON tbl_remuneration.staff_id = tbl_staff.id
GROUP BY tbl_staff.id, tbl_staff.name");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Count_1()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val1 = Count(db.tbl_remuneration.money),
                   Val2 = Count(Asterisk()),
                   Val3 = Count(Distinct(), db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration).
                   Join(db.tbl_staff, db.tbl_remuneration.staff_id == db.tbl_staff.id).
               GroupBy(db.tbl_staff.id, db.tbl_staff.name));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Val1,
	COUNT(*) AS Val2,
	COUNT(DISTINCT tbl_remuneration.money) AS Val3
FROM tbl_remuneration
	JOIN tbl_staff ON tbl_remuneration.staff_id = tbl_staff.id
GROUP BY tbl_staff.id, tbl_staff.name");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Avg_Min_Max()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val1 = (decimal)Avg(db.tbl_remuneration.money),
                   Val2 = Min(db.tbl_remuneration.money),
                   Val3 = Max(db.tbl_remuneration.money),
               }).
               From(db.tbl_remuneration).
                   Join(db.tbl_staff, db.tbl_remuneration.staff_id == db.tbl_staff.id).
               GroupBy(db.tbl_staff.id, db.tbl_staff.name));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	AVG(tbl_remuneration.money) AS Val1,
	MIN(tbl_remuneration.money) AS Val2,
	MAX(tbl_remuneration.money) AS Val3
FROM tbl_remuneration
	JOIN tbl_staff ON tbl_remuneration.staff_id = tbl_staff.id
GROUP BY tbl_staff.id, tbl_staff.name");
        }
    }
}