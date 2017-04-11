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
    }
}