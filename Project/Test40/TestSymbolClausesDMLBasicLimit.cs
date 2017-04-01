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
    public class TestSymbolClausesDMLBasicLimit
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
        public void Test_OffsetRows_FetchNext()
        {
            var sql = Db<DB>.Sql(db =>
                 Select(Asterisk(db.tbl_remuneration)).
                 From(db.tbl_remuneration).
                 OrderBy(Asc(db.tbl_remuneration.id)).
                 OffsetRows(1).
                 FetchNextRowsOnly(3)
                 );

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration
ORDER BY
	tbl_remuneration.id ASC
OFFSET @p_0 ROWS
FETCH NEXT @p_1 ROWS ONLY",
1, 3);
        }
        
        [TestMethod]
        public void Test_OffsetRows_FetchNext_Start()
        {
            var sql = Db<DB>.Sql(db =>
                 Select(Asterisk(db.tbl_remuneration)).
                 From(db.tbl_remuneration).
                 OrderBy(Asc(db.tbl_remuneration.id)) +
                 OffsetRows(1) +
                 FetchNextRowsOnly(3)
                 );

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration
ORDER BY
	tbl_remuneration.id ASC
OFFSET @p_0 ROWS
FETCH NEXT @p_1 ROWS ONLY",
1, 3);
        }
    }
}
