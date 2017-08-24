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
    public class TestSymbolClausesDMLBasicDataChange
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
        public void Test_Update_Set()
        {
            Test_InsertInto_Values();

            var sql = Db<DB>.Sql(db =>
                Update(db.tbl_data).
                Set(new Assign(db.tbl_data.val1, 100), new Assign(db.tbl_data.val2, "200")).
                Where(db.tbl_data.id == 1));

            Assert.AreEqual(1, _connection.Execute(sql));
            AssertEx.AreEqual(sql, _connection,
@"UPDATE tbl_data
SET
	val1 = @p_0,
	val2 = @p_1
WHERE (tbl_data.id) = (@p_2)",
100, "200", 1);
        }

        [Priority(1)]
        [TestMethod]
        public void Test_Update_Set_Start()
        {
            Test_InsertInto_Values();

            var sql = Db<DB>.Sql(db =>
                Update(db.tbl_data) +
                Set(new Assign(db.tbl_data.val1, 100), new Assign(db.tbl_data.val2, "200")).
                Where(db.tbl_data.id == 1));

            Assert.AreEqual(1, _connection.Execute(sql));
            AssertEx.AreEqual(sql, _connection,
@"UPDATE tbl_data
SET
	val1 = @p_0,
	val2 = @p_1
WHERE (tbl_data.id) = (@p_2)",
100, "200", 1);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Delete()
        {
            var sql = Db<DB>.Sql(db =>
                Delete().
                From(db.tbl_data).
                Where(db.tbl_data.id == 3));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"DELETE
FROM tbl_data
WHERE (tbl_data.id) = (@p_0)",
3);
        }

        [Priority(1)]
        [TestMethod]
        public void Test_Delete_All()
        {
            var sql = Db<DB>.Sql(db =>
                Delete().
                From(db.tbl_data));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"DELETE
FROM tbl_data");
        }

        [Priority(1)]
        [TestMethod]
        public void Test_InsertInto_Values()
        {
            Test_Delete_All();

            var sql = Db<DB>.Sql(db =>
                   InsertInto(db.tbl_data, db.tbl_data.id, db.tbl_data.val2).
                   Values(1, "val2"));

            Assert.AreEqual(1, _connection.Execute(sql));
            AssertEx.AreEqual(sql, _connection,
@"INSERT INTO tbl_data(id, val2)
	VALUES(@p_0, @p_1)",
1, "val2");
        }

        [Priority(1)]
        [TestMethod]
        public void Test_InsertInto_Values_Multi_1()
        {
            Test_Delete_All();

            var datas = new[] { new object[] { 1, "val2" }, new object[] { 2, "val3" } };

            var sql = Db<DB>.Sql(db =>
                   InsertInto(db.tbl_data, db.tbl_data.id, db.tbl_data.val2).
                   Values(datas));

            Assert.AreEqual(2, _connection.Execute(sql));
            AssertEx.AreEqual(sql, _connection,
@"INSERT INTO tbl_data(id, val2)
	VALUES
		(@p_0, @p_1), 
		(@p_2, @p_3)",
1, "val2", 2, "val3");
        }

        [Priority(1)]
        [TestMethod]
        public void Test_InsertInto_Values_Multi_2()
        {
            Test_Delete_All();

            var vals = new object[] { 2, "val3" };

            var sql = Db<DB>.Sql(db =>
                   InsertInto(db.tbl_data, db.tbl_data.id, db.tbl_data.val2).
                   Values(new[] { new object[] { 1, "val2" }, vals }));

            Assert.AreEqual(2, _connection.Execute(sql));
            AssertEx.AreEqual(sql, _connection,
@"INSERT INTO tbl_data(id, val2)
	VALUES
		(@p_0, @p_1), 
		(@p_2, @p_3)",
1, "val2", 2, "val3");
        }

        [Priority(1)]
        [TestMethod]
        public void Test_InsertInto_Values_Multi_3()
        {
            Test_Delete_All();

            var vals = new object[] { 2, "val3" };

            var sql = Db<DB>.Sql(db =>
                   InsertInto(db.tbl_data, db.tbl_data.id, db.tbl_data.val2) + 
                   Values(new[] { new object[] { 1, "val2" }, vals }));

            Assert.AreEqual(2, _connection.Execute(sql));
            AssertEx.AreEqual(sql, _connection,
@"INSERT INTO tbl_data(id, val2)
	VALUES
		(@p_0, @p_1), 
		(@p_2, @p_3)",
1, "val2", 2, "val3");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_InsertInto_Values_Start()
        {
            Test_Delete_All();

            var sql = Db<DB>.Sql(db =>
                   InsertInto(db.tbl_data, db.tbl_data.id, db.tbl_data.val2) +
                   Values(1, "val2"));

            Assert.AreEqual(1, _connection.Execute(sql));
            AssertEx.AreEqual(sql, _connection,
@"INSERT INTO tbl_data(id, val2)
	VALUES(@p_0, @p_1)",
1, "val2");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_InsertInto_Values_Select()
        {
            Test_InsertInto_Values();
            var sql = Db<DB>.Sql(db =>
                   InsertInto(db.tbl_data).
                   Select(new
                   {
                       id = db.tbl_data.id + 10,
                       val1 = db.tbl_data.val1,
                       val2 = db.tbl_data.val2
                   }).
                   From(db.tbl_data));

            Assert.AreEqual(1, _connection.Execute(sql));
            AssertEx.AreEqual(sql, _connection,
@"INSERT INTO tbl_data
SELECT
	(tbl_data.id) + (@p_0) AS id,
	tbl_data.val1 AS val1,
	tbl_data.val2 AS val2
FROM tbl_data", 10);
        }
    }
}
