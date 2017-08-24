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
    public class TestSymbolClausesDMLBasicWhereGroupByHavingOrderBy
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
        public void Test_Where()
        {
            var sql = Db<DB>.Sql(db =>
               Select(Asterisk(db.tbl_remuneration)).
               From(db.tbl_remuneration).
               Where(db.tbl_remuneration.id == 1));

            var datas = _connection.Query(sql).ToList();

            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration
WHERE (tbl_remuneration.id) = (@p_0)",
1);
        }

        [Priority(1)]
        [TestMethod]
        public void Test_Where_Start()
        {
            var sql = Db<DB>.Sql(db =>
               Select(Asterisk(db.tbl_remuneration)).
               From(db.tbl_remuneration) +
               Where(db.tbl_remuneration.id == 1));

            var datas = _connection.Query(sql).ToList();

            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration
WHERE (tbl_remuneration.id) = (@p_0)",
1);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Where_Exp()
        {
            var exp = Db<DB>.Sql(db => db.tbl_remuneration.id == 1);

            var sql = Db<DB>.Sql(db =>
               Select(Asterisk(db.tbl_remuneration)).
               From(db.tbl_remuneration).
               Where(exp));

            var datas = _connection.Query(sql).ToList();

            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration
WHERE (tbl_remuneration.id) = (@p_0)",
1);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupBy()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration).
               GroupBy(db.tbl_remuneration.id, db.tbl_remuneration.staff_id));

            var datas = _connection.Query(sql).ToList();

            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY tbl_remuneration.id, tbl_remuneration.staff_id");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupBy_Element_Valnish_1()
        {
            var col = new Sql();
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration).
               GroupBy(col, db.tbl_remuneration.staff_id));

            var datas = _connection.Query(sql).ToList();

            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY tbl_remuneration.staff_id");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupBy_Element_Valnish_2()
        {
            var col = new Sql();
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration).
               GroupBy(db.tbl_remuneration.staff_id, col));

            var datas = _connection.Query(sql).ToList();

            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY tbl_remuneration.staff_id");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupBy_Element_Valnish_3()
        {
            var col1 = new Sql();
            var col2 = new Sql();
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration).
               GroupBy(col1, db.tbl_remuneration.staff_id, col2));

            var datas = _connection.Query(sql).ToList();

            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY tbl_remuneration.staff_id");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupBy_Start()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration) +
               GroupBy(db.tbl_remuneration.id, db.tbl_remuneration.staff_id));

            var datas = _connection.Query(sql).ToList();

            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY tbl_remuneration.id, tbl_remuneration.staff_id");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupByRollup()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration).
               GroupByRollup(db.tbl_remuneration.id, db.tbl_remuneration.staff_id));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY ROLLUP(tbl_remuneration.id, tbl_remuneration.staff_id)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupByRollup_Start()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration) +
               GroupByRollup(db.tbl_remuneration.id, db.tbl_remuneration.staff_id));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY ROLLUP(tbl_remuneration.id, tbl_remuneration.staff_id)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupByCube()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration).
               GroupByCube(db.tbl_remuneration.id, db.tbl_remuneration.staff_id));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY CUBE(tbl_remuneration.id, tbl_remuneration.staff_id)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupByCube_Start()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration) +
               GroupByCube(db.tbl_remuneration.id, db.tbl_remuneration.staff_id));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY CUBE(tbl_remuneration.id, tbl_remuneration.staff_id)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupByGroupingSets()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration).
               GroupByGroupingSets(db.tbl_remuneration.id, db.tbl_remuneration.staff_id));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY GROUPING SETS(tbl_remuneration.id, tbl_remuneration.staff_id)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_GroupByGroupingSets_Start()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Count = Count(db.tbl_remuneration.money)
               }).
               From(db.tbl_remuneration) +
               GroupByGroupingSets(db.tbl_remuneration.id, db.tbl_remuneration.staff_id));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(tbl_remuneration.money) AS Count
FROM tbl_remuneration
GROUP BY GROUPING SETS(tbl_remuneration.id, tbl_remuneration.staff_id)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Having()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Id = db.tbl_remuneration.staff_id
                }).
                From(db.tbl_remuneration).
                GroupBy(db.tbl_remuneration.staff_id).
                Having(100 < Sum(db.tbl_remuneration.money)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration
GROUP BY tbl_remuneration.staff_id
HAVING (@p_0) < (SUM(tbl_remuneration.money))",
(decimal)100);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Having_Start()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Id = db.tbl_remuneration.staff_id
                }).
                From(db.tbl_remuneration).
                GroupBy(db.tbl_remuneration.staff_id) +
                Having(100 < Sum(db.tbl_remuneration.money)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration
GROUP BY tbl_remuneration.staff_id
HAVING (@p_0) < (SUM(tbl_remuneration.money))",
(decimal)100);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_OrderBy()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Id = db.tbl_remuneration.staff_id
                }).
                From(db.tbl_remuneration).
                OrderBy(Asc(db.tbl_remuneration.money), Desc(db.tbl_remuneration.staff_id)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration
ORDER BY
	tbl_remuneration.money ASC,
	tbl_remuneration.staff_id DESC");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_OrderBy_Start()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Id = db.tbl_remuneration.staff_id
                }).
                From(db.tbl_remuneration) +
                OrderBy(Asc(db.tbl_remuneration.money), Desc(db.tbl_remuneration.staff_id)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration
ORDER BY
	tbl_remuneration.money ASC,
	tbl_remuneration.staff_id DESC");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_OrderBy_Element_Vanish_1()
        {
            var desc = new Sql<OrderByElement>();
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Id = db.tbl_remuneration.staff_id
                }).
                From(db.tbl_remuneration).
                OrderBy(Asc(db.tbl_remuneration.money), desc));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration
ORDER BY
	tbl_remuneration.money ASC");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_OrderBy_Element_Vanish_2()
        {
            var asc = new Sql<OrderByElement>();
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Id = db.tbl_remuneration.staff_id
                }).
                From(db.tbl_remuneration) +
                OrderBy(asc, Desc(db.tbl_remuneration.staff_id)));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration
ORDER BY
	tbl_remuneration.staff_id DESC");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_OrderBy_Element_Vanish_3()
        {
            var asc1 = new Sql<OrderByElement>();
            var asc2 = new Sql<OrderByElement>();
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Id = db.tbl_remuneration.staff_id
                }).
                From(db.tbl_remuneration) +
                OrderBy(asc1, Desc(db.tbl_remuneration.staff_id), asc2));

            sql.Gen(_connection);

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration
ORDER BY
	tbl_remuneration.staff_id DESC");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_OrderBy_Vanish()
        {
            var asc = new Sql<OrderByElement>();
            var desc = new Sql<OrderByElement>();
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Id = db.tbl_remuneration.staff_id
               }).
               From(db.tbl_remuneration).
               OrderBy(asc, desc));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_OrderBy_Vanish_Start()
        {
            var asc = new Sql<OrderByElement>();
            var desc = new Sql<OrderByElement>();
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   Id = db.tbl_remuneration.staff_id
               }).
               From(db.tbl_remuneration) +
               OrderBy(asc, desc));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Where_Vanish()
        {
            var empty = new Sql<bool>();

            var sql = Db<DB>.Sql(db =>
               Select(Asterisk(db.tbl_remuneration)).
               From(db.tbl_remuneration).
               Where(empty));

            var datas = _connection.Query(sql).ToList();

            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Having_Vanish()
        {
            var empty = new Sql<bool>();

            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Id = db.tbl_remuneration.staff_id
                }).
                From(db.tbl_remuneration).
                GroupBy(db.tbl_remuneration.staff_id).
                Having(empty));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.staff_id AS Id
FROM tbl_remuneration
GROUP BY tbl_remuneration.staff_id");
        }

        [TestMethod]
        public void Test()
        {
            int val = 0;
            var sql1 = Db<DB>.Sql(db =>
                Set(new Assign(val, Select(Count(Asterisk())).From(db.tbl_staff))));
            sql1.Gen(_connection);
            var sql2 = Db<DB>.Sql(db =>
                Select(new Assign(val, 0)));
            sql2.Gen(_connection);
        }
    }
}
