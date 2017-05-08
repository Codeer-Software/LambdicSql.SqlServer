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
    public class TestSymbolFuncsMetadata
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
        public void Test_ObjectToParameter_1()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Id(db.tbl_staff)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	OBJECT_ID(@p_0)", "tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_ObjectToParameter_2()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Id("tbl_staff")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	OBJECT_ID(@p_0)", "tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_AtAtProcId()
        {
            var sql = Db<DB>.Sql(db => Select(AtAtProcId()));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	@@PROCID");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_AppName()
        {
            var sql = Db<DB>.Sql(db => Select(App_Name()));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	APP_NAME()");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_AssemblyProperty()
        {
            var sql = Db<DB>.Sql(db => Select(AssemblyProperty("HelloWorld", "PublicKey")));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);

            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ASSEMBLYPROPERTY(@p_0, @p_1)", "HelloWorld", "PublicKey");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Col_Length()
        {
            var sql = Db<DB>.Sql(db => Select(Col_Length(db.tbl_staff, db.tbl_staff.id)));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COL_LENGTH(@p_0, @p_1)", "tbl_staff", "id");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Col_Name()
        {
            var sql = Db<DB>.Sql(db => Select(Col_Name(Object_Id(db.tbl_staff), 1)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            Assert.AreEqual(sql.Build(_connection.GetType()).Text,
 @"SELECT
	COL_NAME(OBJECT_ID(@p_0), @p_1)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_ColumnProperty()
        {
            var sql = Db<DB>.Sql(db => Select(ColumnProperty(Object_Id(db.tbl_staff), db.tbl_staff.id, "PRECISION")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);

            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COLUMNPROPERTY(OBJECT_ID(@p_0), @p_1, @p_2)", "tbl_staff", "id", "PRECISION");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_DataBase_Principal_Id_1()
        {
            var sql = Db<DB>.Sql(db => Select(DataBase_Principal_Id()));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATABASE_PRINCIPAL_ID()");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_DataBase_Principal_Id_2()
        {
            var sql = Db<DB>.Sql(db => Select(DataBase_Principal_Id("db_owner")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATABASE_PRINCIPAL_ID(@p_0)", "db_owner");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_DataBasePropertyEx()
        {
            var sql = Db<DB>.Sql(db => Select(DataBasePropertyEx("LambdicSqlTest", "IsAutoShrink")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATABASEPROPERTYEX(@p_0, @p_1)", "LambdicSqlTest", "IsAutoShrink");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Db_Id()
        {
            var sql = Db<DB>.Sql(db => Select(Db_Id("LambdicSqlTest")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DB_ID(@p_0)", "LambdicSqlTest");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Db_Name()
        {
            var sql = Db<DB>.Sql(db => Select(Db_Name(Db_Id("LambdicSqlTest"))));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DB_NAME(DB_ID(@p_0))", "LambdicSqlTest");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_File_Id()
        {
            var sql = Db<DB>.Sql(db => Select(File_Id("LambdicSqlTest")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FILE_ID(@p_0)", "LambdicSqlTest");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_File_Index()
        {
            var sql = Db<DB>.Sql(db => Select(File_Idex("LambdicSqlTest")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FILE_IDEX(@p_0)", "LambdicSqlTest");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_File_Name()
        {
            var sql = Db<DB>.Sql(db => Select(File_Name(File_Id("LambdicSqlTest"))));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FILE_NAME(FILE_ID(@p_0))", "LambdicSqlTest");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_FileGroup_Id()
        {
            var sql = Db<DB>.Sql(db => Select(FileGroup_Id("PRIMARY")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FILEGROUP_ID(@p_0)", "PRIMARY");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_FileGroup_Name()
        {
            var sql = Db<DB>.Sql(db => Select(FileGroup_Name(FileGroup_Id("PRIMARY"))));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FILEGROUP_NAME(FILEGROUP_ID(@p_0))", "PRIMARY");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_FileGroupProperty()
        {
            var sql = Db<DB>.Sql(db => Select(FileGroupProperty("PRIMARY", "IsReadOnly")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FILEGROUPPROPERTY(@p_0, @p_1)", "PRIMARY", "IsReadOnly");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_FileProperty()
        {
            var sql = Db<DB>.Sql(db => Select(FileProperty("LambdicSqlTest", "IsReadOnly")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FILEPROPERTY(@p_0, @p_1)", "LambdicSqlTest", "IsReadOnly");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_FullTextCatalogProperty()
        {
            var sql = Db<DB>.Sql(db => Select(FullTextCatalogProperty("LambdicSqlTest", "IsReadOnly")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FULLTEXTCATALOGPROPERTY(@p_0, @p_1)", "LambdicSqlTest", "IsReadOnly");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_FullTextServiceProperty()
        {
            var sql = Db<DB>.Sql(db => Select(FullTextServiceProperty("VerifySignature")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	FULLTEXTSERVICEPROPERTY(@p_0)", "VerifySignature");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Index_Col()
        {
            var sql = Db<DB>.Sql(db => Select(Index_Col(db.tbl_staff, 1, 1)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	INDEX_COL(@p_0, @p_1, @p_2)", "tbl_staff", 1, 1);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_IndexKey_Property()
        {
            var sql = Db<DB>.Sql(db => Select(IndexKey_Property(Object_Id(db.tbl_staff), 1, 1, "ColumnId")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	INDEXKEY_PROPERTY(OBJECT_ID(@p_0), @p_1, @p_2, @p_3)", "tbl_staff", 1, 1, "ColumnId");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_IndexProperty()
        {
            var sql = Db<DB>.Sql(db => Select(IndexProperty(Object_Id(db.tbl_staff), "id", "IsClustered")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	INDEXPROPERTY(OBJECT_ID(@p_0), @p_1, @p_2)", "tbl_staff", "id", "IsClustered");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Object_Id_1()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Id(db.tbl_staff)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	OBJECT_ID(@p_0)", "tbl_staff");
        }
        
        [TestMethod]
        [Priority(1)]
        public void Test_Object_Id_2()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Id(db.tbl_staff, "U")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	OBJECT_ID(@p_0, @p_1)", "tbl_staff", "U");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Object_Definition()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Definition(Object_Id(db.tbl_staff))));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	OBJECT_DEFINITION(OBJECT_ID(@p_0))", "tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Object_Name_1()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Name(Object_Id(db.tbl_staff))));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	OBJECT_NAME(OBJECT_ID(@p_0))", "tbl_staff");
        }
        
        [TestMethod]
        [Priority(1)]
        public void Test_Object_Name_2()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Name(Object_Id(db.tbl_staff), 1)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	OBJECT_NAME(OBJECT_ID(@p_0), @p_1)", "tbl_staff", 1);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Object_Schema_Name()
        {
            var sql = Db<DB>.Sql(db => Select(Object_Schema_Name(Object_Id(db.tbl_staff))));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	OBJECT_SCHEMA_NAME(OBJECT_ID(@p_0))", "tbl_staff");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_ObjectProperty()
        {
            var sql = Db<DB>.Sql(db => Select(ObjectProperty(Object_Id(db.tbl_staff), "CnstIsClustKey")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	OBJECTPROPERTY(OBJECT_ID(@p_0), @p_1)", "tbl_staff", "CnstIsClustKey");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_ObjectPropertyEx()
        {
            var sql = Db<DB>.Sql(db => Select(ObjectPropertyEx(Object_Id(db.tbl_staff), "CnstIsClustKey")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	OBJECTPROPERTYEX(OBJECT_ID(@p_0), @p_1)", "tbl_staff", "CnstIsClustKey");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Original_Db_Name()
        {
            var sql = Db<DB>.Sql(db => Select(Original_Db_Name()));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	ORIGINAL_DB_NAME()");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_ParseName()
        {
            var sql = Db<DB>.Sql(db => Select(ParseName(db.tbl_staff.id, 1)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	PARSENAME(@p_0, @p_1)", "tbl_staff.id",1);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Schema_Id()
        {
            var sql = Db<DBSchema>.Sql(db => Select(Schema_Id(db.dbo)));

            sql.Gen(_connection);

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	SCHEMA_ID(@p_0)", "dbo");
        }

        [Priority(1)]
        [TestMethod]
        public void Test_Schema_Name()
        {
            var sql = Db<DBSchema>.Sql(db => Select(Schema_Name(Schema_Id("dbo"))));

            sql.Gen(_connection);

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	SCHEMA_NAME(SCHEMA_ID(@p_0))", "dbo");
        }

        [Priority(1)]
        [TestMethod]
        public void Test_Scope_Identity()
        {
            var sql = Db<DB>.Sql(db => Select(Scope_Identity()));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	SCOPE_IDENTITY()");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_ServerProperty()
        {
            var sql = Db<DB>.Sql(db => Select(ServerProperty("BuildClrVersion")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	SERVERPROPERTY(@p_0)", "BuildClrVersion");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Stats_Date()
        {
            var sql = Db<DB>.Sql(db => Select(Stats_Date(0, 0)));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	STATS_DATE(@p_0, @p_1)", 0, 0);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Type_Id_Name()
        {
            var sql = Db<DB>.Sql(db => Select(Type_Name(Type_Id("int"))));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	TYPE_NAME(TYPE_ID(@p_0))", "int");
        }

        [TestMethod]
        [Priority(1)]
        public void Test_TypeProperty()
        {
            var sql = Db<DB>.Sql(db => Select(TypeProperty(Type_Id("int"), "OwnerId")));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT
	TYPEPROPERTY(TYPE_ID(@p_0), @p_1)", "int", "OwnerId");
        }
    }
}