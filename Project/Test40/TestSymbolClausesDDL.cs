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
    public class TestSymbolClausesDDL
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
        public void Test_CreateTable()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int()),
                     new Column(db.table1.val1, DataType.Int()),
                     new Column(db.table1.val2, DataType.Char(10))
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT,
	val1 INT,
	val2 CHAR(10))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Constraint()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int()),
                     Constraint("xxx").Check(db.table1.id < 100)
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT,
	CONSTRAINT xxx
		CHECK(id < 100))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_PrimaryKey_1()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), NotNull(), PrimaryKey())
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT NOT NULL PRIMARY KEY)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_PrimaryKey_2()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), NotNull()),
                     PrimaryKey(db.table1.id)
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT NOT NULL,
	PRIMARY KEY(id))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_PrimaryKey_3()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), NotNull()),
                     Constraint("xxx").PrimaryKey(db.table1.id)
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT NOT NULL,
	CONSTRAINT xxx
		PRIMARY KEY(id))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Check_1()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), Check(db.table1.id < 100))
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT CHECK(id < 100))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Check_2()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int()),
                     Check(db.table1.id < 100)
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT,
	CHECK(id < 100))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Check_3()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int()),
                     Constraint("xxx").Check(db.table1.id < 100)
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT,
	CONSTRAINT xxx
		CHECK(id < 100))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Unique_1()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), NotNull(), Unique())
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT NOT NULL UNIQUE)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Unique_2()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), NotNull()),
                     Constraint("xxx").Unique(db.table1.id)
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT NOT NULL,
	CONSTRAINT xxx
		UNIQUE(id))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Unique_3()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), NotNull()),
                     Unique(db.table1.id)
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT NOT NULL,
	UNIQUE(id))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_ForeignKey_References_1()
        {
            CleanUpCreateDropTestTable();

            var tbl1 = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), NotNull(), PrimaryKey())
                 ));
            _connection.Execute(tbl1);

            var sql = Db<DBForCreateTest>.Sql(db => CreateTable(db.table2,
                new Column(db.table2.table1Id, DataType.Int()),
                ForeignKey(db.table2.table1Id).References(db.table1, db.table1.id)
                ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table2(
	table1Id INT,
	FOREIGN KEY(table1Id)
		REFERENCES table1(id))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_ForeignKey_References_2()
        {
            CleanUpCreateDropTestTable();

            var tbl1 = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), NotNull(), PrimaryKey())
                 ));
            _connection.Execute(tbl1);

            var sql = Db<DBForCreateTest>.Sql(db => CreateTable(db.table2,
                new Column(db.table2.table1Id, DataType.Int()),
                Constraint("xxx").ForeignKey(db.table2.table1Id).References(db.table1, db.table1.id)
                ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table2(
	table1Id INT,
	CONSTRAINT xxx
		FOREIGN KEY(table1Id)
		REFERENCES table1(id))");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_NotNull()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), NotNull())
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT NOT NULL)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Default()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int(), Default(3))
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table1(
	id INT DEFAULT 3)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_DropTable()
        {
            CleanUpCreateDropTestTable();

            var create = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table1,
                     new Column(db.table1.id, DataType.Int())
                 ));
            _connection.Execute(create);

            var sql = Db<DBForCreateTest>.Sql(db => DropTable(db.table1));
            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"DROP TABLE table1");
        }

        [TestMethod]
        [Priority(2)]
        public void Test_CreateAndDropDataBase()
        {
            CleanUpCreateDropTestDB();

            var create = Db<DBForCreateTest>.Sql(db => CreateDataBase("CreateDropTestDB"));
            _connection.Execute(create);
            AssertEx.AreEqual(create, _connection,
@"CREATE DATABASE CreateDropTestDB");

            var drop = Db<DBForCreateTest>.Sql(db => DropDataBase("CreateDropTestDB"));
            _connection.Execute(drop);
            AssertEx.AreEqual(drop, _connection,
@"DROP DATABASE CreateDropTestDB");
        }

        void CleanUpCreateDropTestDB()
        {
            try
            {
                var sql = Db<DBForCreateTest>.Sql(db => DropDataBase("CreateDropTestDB"));
                _connection.Execute(sql);
            }
            catch { }
        }

        void CleanUpCreateDropTestTable()
        {
            try
            {
                var sql = Db<DBForCreateTest>.Sql(db => DropTable(db.table2));
                _connection.Execute(sql);
            }
            catch { }
            try
            {
                var sql = Db<DBForCreateTest>.Sql(db => DropTable(db.table1));
                _connection.Execute(sql);
            }
            catch { }
        }
    }
}
