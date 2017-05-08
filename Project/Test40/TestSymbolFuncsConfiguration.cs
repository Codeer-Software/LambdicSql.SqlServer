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
    public class TestSymbolFuncsConfiguration
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

        //@@@あー戻り値配列にたえれないー
        [TestMethod]
        [Priority(1)]
        public void Test_AtAtDbts()
        {
            var sql = Db<DB>.Sql(db =>
                Select(AtAtDbts()));

            var datas = _connection.Query<byte[]>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);

            AssertEx.AreEqual(sql, _connection,
@"SELECT
	@@DBTS");
        }
    }
}