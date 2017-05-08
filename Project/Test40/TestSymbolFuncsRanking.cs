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
    public class TestSymbolFuncsRanking
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
        public void Test_Dense_Rank()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Dense_Rank().
                            Over(OrderBy(Asc(db.tbl_remuneration.money)))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DENSE_RANK()
	OVER(
		ORDER BY
			tbl_remuneration.money ASC) AS Val
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Ntile()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Ntile(2).
                            Over(OrderBy(Asc(db.tbl_remuneration.money)))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	NTILE(@p_0)
	OVER(
		ORDER BY
			tbl_remuneration.money ASC) AS Val
FROM tbl_remuneration", 2);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Rank()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Rank().
                            Over(OrderBy(Asc(db.tbl_remuneration.money)))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	RANK()
	OVER(
		ORDER BY
			tbl_remuneration.money ASC) AS Val
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_RowNumber()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = Row_Number().
                            Over(OrderBy(Asc(db.tbl_remuneration.money)))
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ROW_NUMBER()
	OVER(
		ORDER BY
			tbl_remuneration.money ASC) AS Val
FROM tbl_remuneration");
        }
    }
}