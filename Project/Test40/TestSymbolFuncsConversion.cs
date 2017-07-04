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
    public class TestSymbolFuncsConversion
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
        public void Test_Cast()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    id = Cast<int>(db.tbl_remuneration.money, DataType.Int())
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CAST(tbl_remuneration.money AS INT) AS id
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Convert()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    id = Convert<int>(DataType.Int(), db.tbl_remuneration.money)
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CONVERT(INT, tbl_remuneration.money) AS id
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Parse()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    id = Parse<DateTime>(db.tbl_remuneration.payment_date, DataType.DateTime2())
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	PARSE(tbl_remuneration.payment_date AS DATETIME2) AS id
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Parse_Using()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    id = Parse<DateTime>(db.tbl_remuneration.payment_date, DataType.DateTime2(), "en-US")
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	PARSE(tbl_remuneration.payment_date AS DATETIME2 USING @p_0) AS id
FROM tbl_remuneration", "en-US");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Try_Cast()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    id = Try_Cast<int>(db.tbl_remuneration.money, DataType.Int())
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TRY_CAST(tbl_remuneration.money AS INT) AS id
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Try_Convert()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    id = Try_Convert<int>(DataType.Int(), db.tbl_remuneration.money)
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TRY_CONVERT(INT, tbl_remuneration.money) AS id
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Try_Parse()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    id = Try_Parse<DateTime>(db.tbl_remuneration.payment_date, DataType.DateTime2())
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TRY_PARSE(tbl_remuneration.payment_date AS DATETIME2) AS id
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Try_Parse_Using()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    id = Try_Parse<DateTime>(db.tbl_remuneration.payment_date, DataType.DateTime2(), "en-US")
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TRY_PARSE(tbl_remuneration.payment_date AS DATETIME2 USING @p_0) AS id
FROM tbl_remuneration", "en-US");
        }
    }
}