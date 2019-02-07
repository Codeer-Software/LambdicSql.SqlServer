using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SqlServer.Symbol;
using static Test.Helper.DBProviderInfo;
using Test.Helper;
using LambdicSql.SqlServer;

namespace Test
{
    [TestClass]
    public class TestSymbolClausesEtc
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
        public void Test_Asterisk_1()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk()).
                From(db.tbl_staff));

            var datas = _connection.Query<Staff>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Asterisk_2()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Asterisk_3()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk<Staff>()).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_staff");
        }
        
        [TestMethod]
        [Priority(1)]
        public void Test_Asc_Desc()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).
                From(db.tbl_staff).
                OrderBy(Asc(db.tbl_staff.id), Desc(db.tbl_staff.name)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff
ORDER BY
	tbl_staff.id ASC,
	tbl_staff.name DESC");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Top()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Top(1), Asterisk(db.tbl_staff)).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT TOP 1 tbl_staff.*
FROM tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_All()
        {
        var sql = Db<DB>.Sql(db =>
                Select(All(), Asterisk()).
                From(db.tbl_remuneration));

            var datas = _connection.Query<Remuneration>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT ALL *
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Distinct()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Distinct(), Asterisk()).
                From(db.tbl_remuneration));

            var datas = _connection.Query<Remuneration>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT DISTINCT *
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_N()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk()).
                From(db.tbl_staff).
                Where(db.tbl_staff.name == N("Emma") || db.tbl_staff.name == (string)(object)N('c')));

            System.Diagnostics.Debug.WriteLine(sql.Build(_connection.GetType()).Text);

            var datas = _connection.Query<Remuneration>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_staff
WHERE tbl_staff.name = N'Emma' OR tbl_staff.name = N'c'");
        }
    }
}
