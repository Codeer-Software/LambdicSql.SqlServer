using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SqlServer.Symbol;
using Test.Helper;

namespace Test
{
    [TestClass]
    public class TestSymbolFuncsMetadata
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
        public void Test_ObjectToParameter_1()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Id(db.tbl_staff)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	OBJECT_ID(@p_0)", "tbl_staff");
        }

        [TestMethod]
        public void Test_ObjectToParameter_2()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Id("tbl_staff")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	OBJECT_ID(@p_0)", "tbl_staff");
        }

        [TestMethod]
        public void Test_AtAtProcId()
        {
            var sql = Db<DB>.Sql(db => Select(AtAtProcId()));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	@@PROCID");
        }

        [TestMethod]
        public void Test_AppName()
        {
            var sql = Db<DB>.Sql(db => Select(App_Name()));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	APP_NAME()");
        }

        [TestMethod]
        public void Test_AssemblyProperty()
        {
            var sql = Db<DB>.Sql(db => Select(AssemblyProperty("HelloWorld", "PublicKey")));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);

            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ASSEMBLYPROPERTY(@p_0, @p_1)", "HelloWorld", "PublicKey");
        }

        [TestMethod]
        public void Test_Col_Length()
        {
            var sql = Db<DB>.Sql(db => Select(Col_Length(db.tbl_staff, db.tbl_staff.id)));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COL_LENGTH(@p_0, @p_1)", "tbl_staff", "id");
        }

        [TestMethod]
        public void Test_Col_Name()
        {
            var sql = Db<DB>.Sql(db => Select(Col_Name((int)Object_Id(db.tbl_staff), 1)));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            Assert.AreEqual(sql.Build(_connection.GetType()).Text,
 @"SELECT
	COL_NAME(OBJECT_ID(@p_0), @p_1)");
        }
    }
}