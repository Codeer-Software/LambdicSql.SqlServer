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
    public class TestSymbolClausesDMLBasicSetOperator
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

        [Priority(1)]
        [TestMethod]
        public void Test_Union()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff).
                Union().
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff
UNION
SELECT tbl_staff.*
FROM tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Union_Start()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff)
                + Union() +
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff
UNION
SELECT tbl_staff.*
FROM tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Union_All()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff).
                Union(All()).
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff
UNION ALL
SELECT tbl_staff.*
FROM tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Union_All_Start()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff)
                + Union(All()) +
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff
UNION ALL
SELECT tbl_staff.*
FROM tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Intersect()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff).
                Intersect().
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff
INTERSECT
SELECT tbl_staff.*
FROM tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Intersect_Start()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff)
                 + Intersect() +
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff
INTERSECT
SELECT tbl_staff.*
FROM tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Except()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff).
                Except().
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff).Where(db.tbl_staff.id == 1));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff
EXCEPT
SELECT tbl_staff.*
FROM tbl_staff
WHERE tbl_staff.id = @p_0",
1);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Except_Start()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff)
                 + Except() +
                Select(Asterisk(db.tbl_staff)).From(db.tbl_staff).Where(db.tbl_staff.id == 1));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT tbl_staff.*
FROM tbl_staff
EXCEPT
SELECT tbl_staff.*
FROM tbl_staff
WHERE tbl_staff.id = @p_0",
1);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Minus()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk()).From(db.tbl_staff).
                Minus().
                Select(Asterisk()).From(db.tbl_staff).Where(db.tbl_staff.id == 1));

            var datas = _connection.Query<Staff>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_staff
MINUS
SELECT *
FROM tbl_staff
WHERE tbl_staff.id = @p_0",
1);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Minus_Start()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk()).From(db.tbl_staff)
                + Minus() +
                Select(Asterisk()).From(db.tbl_staff).Where(db.tbl_staff.id == 1));

            var datas = _connection.Query<Staff>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_staff
MINUS
SELECT *
FROM tbl_staff
WHERE tbl_staff.id = @p_0",
1);
        }
    }
}
