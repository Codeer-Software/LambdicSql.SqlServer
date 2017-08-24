using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SqlServer.Symbol;
using static Test.Helper.DBProviderInfo;
using Test.Helper;

namespace Test
{
    [TestClass]
    public class TestSymbolClausesDMLBasicWithRecursive
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

        class SelectedData
        {
            public int id { get; set; }
        }
        
        [TestMethod]
        [Priority(1)]
        public void Test_Recursive_1()
        {
            var rec = Db<DB>.Sql(db => new { val = 0 });

            var select = Db<DB>.Sql(db =>
                Select(new object[] { 1 }).
                Union(All()).
                Select(new object[] { rec.Body.val + 1 }).
                From(rec).
                Where(rec.Body.val + 1 <= 5)
                );

            var sql = Db<DB>.Sql(db =>
                With(rec.ExpandArguments().As(select)).
                Select(rec.Body.val).
                From(rec)
                );

            sql.Gen(_connection);

            var datas = _connection.Query<SelectedData>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"WITH
	rec(val)
	AS
		(SELECT
			@p_0
		UNION ALL
		SELECT
			(rec.val) + (@p_1)
		FROM rec
		WHERE ((rec.val) + (@p_2)) <= (@p_3))
SELECT
	rec.val
FROM rec", 1, 1, 1, 5);
        }
    }
}
