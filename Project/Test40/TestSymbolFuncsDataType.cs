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
    public class TestSymbolFuncsDataType
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
        public void Test_Datalength()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
               }).
               From(db.tbl_staff).
               Where(Datalength(db.tbl_staff.name) > 0));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id
FROM tbl_staff
WHERE (DATALENGTH(tbl_staff.name)) > (@p_0)", (long)0);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Ident_Current()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
               }).
               From(db.tbl_staff).
               Where(Ident_Current("db.tbl_staff") == null));
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id
FROM tbl_staff
WHERE (IDENT_CURRENT('db.tbl_staff')) IS NULL");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Ident_Incr()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
               }).
               From(db.tbl_staff).
               Where(Ident_Incr("db.tbl_staff") == null));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id
FROM tbl_staff
WHERE (IDENT_INCR('db.tbl_staff')) IS NULL");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Ident_Seed()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
               }).
               From(db.tbl_staff).
               Where(Ident_Seed("db.tbl_staff") == null));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id
FROM tbl_staff
WHERE (IDENT_SEED('db.tbl_staff')) IS NULL");
        }

        //TODO:Identity, Select @local_valiable Only when it is valid, can not write
        //[TestMethod]
        //[Priority(1)]
        //public void Test_Identity()
        //{
        //}

        [TestMethod]
        [Priority(1)]
        public void Test_Sql_Variant_Property()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
               }).
               From(db.tbl_staff).
               Where((int)Sql_Variant_Property(db.tbl_staff.id, "MaxLength") > 0));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id
FROM tbl_staff
WHERE (SQL_VARIANT_PROPERTY(tbl_staff.id, 'MaxLength')) > (@p_0)", 0);
        }

    }
}