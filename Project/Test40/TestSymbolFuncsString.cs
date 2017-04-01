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
    public class TestSymbolFuncsString
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
        public void Test_Concat()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Concat(db.tbl_staff.name, "a", "b")
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CONCAT(tbl_staff.name, @p_0, @p_1) AS Val
FROM tbl_staff", "a", "b");
        }


        [TestMethod]
        public void Test_Len()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Len(db.tbl_staff.name)
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	LEN(tbl_staff.name) AS Val
FROM tbl_staff");
        }

        [TestMethod]
        public void Test_Lower()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Lower(db.tbl_staff.name)
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	LOWER(tbl_staff.name) AS Val
FROM tbl_staff");
        }

        [TestMethod]
        public void Test_Upper()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Upper(db.tbl_staff.name)
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	UPPER(tbl_staff.name) AS Val
FROM tbl_staff");
        }

        [TestMethod]
        public void Test_Replace()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Replace(db.tbl_staff.name, "a", "b")
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	REPLACE(tbl_staff.name, @p_0, @p_1) AS Val
FROM tbl_staff",
"a", "b");
        }

        [TestMethod]
        public void Test_Substring()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Val = Substring(db.tbl_staff.name, 0, 1)
               }).
               From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SUBSTRING(tbl_staff.name, @p_0, @p_1) AS Val
FROM tbl_staff",
0, 1);
        }

        [TestMethod]
        public void Test_Space()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Space(5)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SPACE(@p_0) AS Val
FROM tbl_staff",
            5);
        }

        [TestMethod]
        public void Test_Str()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Str(123.45, 6, 1)
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	STR(@p_0, @p_1, @p_2) AS Val
FROM tbl_staff",
            123.45, 6, 1);
        }

        [TestMethod]
        public void Test_Ascii()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Ascii('A')
            }).From(db.tbl_staff));
            var data = _connection.Query(sql).ToList();
            Assert.IsTrue(data.Count > 0);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ASCII(@p_0) AS Val
FROM tbl_staff",
            'A');
        }
    }
}