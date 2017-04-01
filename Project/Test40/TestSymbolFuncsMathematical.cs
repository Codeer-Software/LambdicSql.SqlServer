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
    public class TestSymbolFuncsMathematical
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
        public void Test_Abs()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Abs(1)
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ABS(@p_0) AS Val1
FROM tbl_staff", (decimal)1);
        }

        [TestMethod]
        public void Test_Acos()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Acos(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ACOS(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Asin()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Asin(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ASIN(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Atan()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Atan(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ATAN(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Atn2()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Atn2(1, 1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ATN2(@p_0, @p_1) AS Val1
FROM tbl_staff", (double)1, (double)1);
        }

        [TestMethod]
        public void Test_Ceiling()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Ceiling(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CEILING(@p_0) AS Val1
FROM tbl_staff", (decimal)1);
        }

        [TestMethod]
        public void Test_Cos()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Cos(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COS(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Cot()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Cot(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COT(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Degrees()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Degrees(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DEGREES(@p_0) AS Val1
FROM tbl_staff", (decimal)1);
        }

        [TestMethod]
        public void Test_Exp()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Exp(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	EXP(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Floor()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Floor(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FLOOR(@p_0) AS Val1
FROM tbl_staff", (decimal)1);
        }

        [TestMethod]
        public void Test_Log()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Log(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	LOG(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Log10()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Log10(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	LOG10(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_PI()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = PI(),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	PI() AS Val1
FROM tbl_staff");
        }

        [TestMethod]
        public void Test_Power()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Power(1, 2),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	POWER(@p_0, @p_1) AS Val1
FROM tbl_staff", (double)1, 2);
        }

        [TestMethod]
        public void Test_Radians()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Radians(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	RADIANS(@p_0) AS Val1
FROM tbl_staff", (decimal)1);
        }

        [TestMethod]
        public void Test_Rand()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Rand(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	RAND(@p_0) AS Val1
FROM tbl_staff", 1);
        }

        [TestMethod]
        public void Test_Round()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Round((long)2, 3),
                    Val2 = Round(2, 3),
                    Val3 = Round((decimal)2, 3),
                    Val4 = Round((double)2, 3)
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ROUND(@p_0, @p_1) AS Val1,
	ROUND(@p_2, @p_3) AS Val2,
	ROUND(@p_4, @p_5) AS Val3,
	ROUND(@p_6, @p_7) AS Val4
FROM tbl_staff", (long)2, 3, 2, 3, (decimal)2, 3, (double)2, 3);
        }

        [TestMethod]
        public void Test_Sign()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Sign((long)1),
                    Val2 = Sign(1),
                    Val3 = Sign((decimal)1),
                    Val4 = Sign((double)1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SIGN(@p_0) AS Val1,
	SIGN(@p_1) AS Val2,
	SIGN(@p_2) AS Val3,
	SIGN(@p_3) AS Val4
FROM tbl_staff", (long)1, 1, (decimal)1, (double)1);
        }

        [TestMethod]
        public void Test_Sin()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Sin(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SIN(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Sqrt()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Sqrt(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SQRT(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Square()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Square(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SQUARE(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }

        [TestMethod]
        public void Test_Tan()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Tan(1),
                }).
                From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TAN(@p_0) AS Val1
FROM tbl_staff", (double)1);
        }
    }
}