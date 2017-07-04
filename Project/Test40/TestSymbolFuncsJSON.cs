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
    public class TestSymbolFuncsJSON
    {
        private const string jsonInfo = @"{  
                 ""info"":{
                            ""type"":1,  
                   ""address"":{
                                ""town"":""Bristol"",  
                     ""county"":""Avon"",  
                     ""country"":""England""
                   },  
                   ""tags"":[""Sport"", ""Water polo""]
                },  
                ""type"":""Basic""  
             }";

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
        public void Test_IsJson()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
               }).
               From(db.tbl_staff).
               Where(IsJson(db.tbl_staff.name) == 0));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id
FROM tbl_staff
WHERE (ISJSON(tbl_staff.name)) = (@p_0)", 0);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Json_Value()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
                   name = Json_Value(jsonInfo, @"$.info.address[0].town")

               }).
               From(db.tbl_staff));
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id,
	JSON_VALUE(@p_0, '$.info.address[0].town') AS name
FROM tbl_staff", jsonInfo);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Json_Query_1()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
                   name = Json_Query(jsonInfo)

               }).
               From(db.tbl_staff));
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id,
	JSON_QUERY(@p_0) AS name
FROM tbl_staff", jsonInfo);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Json_Query_2()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
                   name = Json_Query(jsonInfo, @"$.info.address[0].town")

               }).
               From(db.tbl_staff));
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id,
	JSON_QUERY(@p_0, '$.info.address[0].town') AS name
FROM tbl_staff", jsonInfo);
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Json_Modify()
        {
            var sql = Db<DB>.Sql(db =>
               Select(new
               {
                   id = db.tbl_staff.id,
                   name = Json_Modify(jsonInfo, @"$.info.address[0].town", "Bristol")

               }).
               From(db.tbl_staff));
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id AS id,
	JSON_MODIFY(@p_0, '$.info.address[0].town', @p_1) AS name
FROM tbl_staff", jsonInfo, "Bristol");
        }
    }
}