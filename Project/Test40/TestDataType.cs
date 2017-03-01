using System.Data;
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
    public class TestDataType
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
        public void Test_CreateTable_SqlServer()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table3, 
                    new Column(db.table3.obj1, DataType.Bit()),
                    new Column(db.table3.obj2, DataType.Int()),
                    new Column(db.table3.obj3, DataType.SmallInt()),
                    new Column(db.table3.obj4, DataType.TinyInt()),
                    new Column(db.table3.obj5, DataType.Bit()),
                    new Column(db.table3.obj6, DataType.Decimal()),
                    new Column(db.table3.obj7, DataType.Numeric()),
                    new Column(db.table3.obj8, DataType.Float()),
                    new Column(db.table3.obj9, DataType.Real()),
                    new Column(db.table3.obj10, DataType.Money()),
                    new Column(db.table3.obj11, DataType.SmallMoney()),
                    new Column(db.table3.obj12, DataType.Date()),
                    new Column(db.table3.obj13, DataType.Time()),
                    new Column(db.table3.obj14, DataType.DateTime()),
                    new Column(db.table3.obj15, DataType.DateTime2()),
                    new Column(db.table3.obj16, DataType.SmallDateTime()),
                    new Column(db.table3.obj17, DataType.DateTimeOffset()),
                    new Column(db.table3.obj18, DataType.Char(1)),
                    new Column(db.table3.obj19, DataType.VarChar(1)),
                    new Column(db.table3.obj20, DataType.Text()),
                    new Column(db.table3.obj21, DataType.NChar(1)),
                    new Column(db.table3.obj22, DataType.NVarChar(1)),
                    new Column(db.table3.obj23, DataType.NText()),
                    new Column(db.table3.obj24, DataType.Binary()),
                    new Column(db.table3.obj25, DataType.VarBinary()),
                    new Column(db.table3.obj26, DataType.Image())
                 ));

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table3(
	obj1 BIT,
	obj2 INT,
	obj3 SMALLINT,
	obj4 TINYINT,
	obj5 BIT,
	obj6 DECIMAL,
	obj7 NUMERIC,
	obj8 FLOAT,
	obj9 REAL,
	obj10 MONEY,
	obj11 SMALLMONEY,
	obj12 DATE,
	obj13 TIME,
	obj14 DATETIME,
	obj15 DATETIME2,
	obj16 SMALLDATETIME,
	obj17 DATETIMEOFFSET,
	obj18 CHAR(1),
	obj19 VARCHAR(1),
	obj20 TEXT,
	obj21 NCHAR(1),
	obj22 NVARCHAR(1),
	obj23 NTEXT,
	obj24 BINARY,
	obj25 VARBINARY,
	obj26 IMAGE)");
        }

        void CleanUpCreateDropTestTable()
        {
            try
            {
                var sql = Db<DBForCreateTest>.Sql(db => DropTable(db.table3));
                _connection.Execute(sql);
            }
            catch { }
        }
    }
}
