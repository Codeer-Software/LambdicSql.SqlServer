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
    public class TestSymbolClausesSystemTables
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
        public void Test_trace_xe_action_map()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Sys.Trace_xe_action_map.Trace_column_id,
                    Sys.Trace_xe_action_map.Package_name,
                    Sys.Trace_xe_action_map.Xe_action_name,
                }).
                From(Sys.Trace_xe_action_map));

            sql.Gen(_connection);

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	sys.trace_xe_action_map.Trace_column_id AS Trace_column_id,
	sys.trace_xe_action_map.Package_name AS Package_name,
	sys.trace_xe_action_map.Xe_action_name AS Xe_action_name
FROM sys.trace_xe_action_map");
        }
    }
}
