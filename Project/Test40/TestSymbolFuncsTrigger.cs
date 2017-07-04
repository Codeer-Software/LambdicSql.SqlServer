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
    public class TestSymbolFuncsTrigger
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
        public void Test_Columns_Updated()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
               }).
               From(db.tbl_staff).
               Where(Columns_Updated() == null));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id
FROM tbl_staff
WHERE (COLUMNS_UPDATED()) IS NULL");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Eventdata()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
               }).
               From(db.tbl_staff).
               Where(Eventdata() == null));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id
FROM tbl_staff
WHERE (EVENTDATA()) IS NULL");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Trigger_Nestlevel()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
               }).
               From(db.tbl_staff).
               Where(Trigger_Nestlevel() == 0));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id
FROM tbl_staff
WHERE (TRIGGER_NESTLEVEL()) = (@p_0)", 0);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Trigger_Nestlevel_2()
        {
            var sql = Db<DB>.Sql(db => Select(Trigger_Nestlevel(Object_Id(db.tbl_staff))));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TRIGGER_NESTLEVEL(OBJECT_ID(@p_0))", "tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Trigger_Nestlevel_3()
        {
            var sql = Db<DB>.Sql(db => Select(Trigger_Nestlevel(Object_Id(db.tbl_staff), "AFTER", "DML")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TRIGGER_NESTLEVEL(OBJECT_ID(@p_0), 'AFTER', 'DML')", "tbl_staff");
        }
    }
}