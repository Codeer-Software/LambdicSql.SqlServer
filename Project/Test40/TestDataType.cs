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
        [Priority(1)]
        public void Test_CreateTable_SqlServer()
        {
            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                 CreateTable(db.table3, 
                    new Column(db.table3.obj1,  DataType.Bit()),
                    new Column(db.table3.obj2,  DataType.Date()),
                    new Column(db.table3.obj3,  DataType.DateTime()),
                    new Column(db.table3.obj4,  DataType.DateTime2()),
                    new Column(db.table3.obj5,  DataType.DateTime2(2)),
                    new Column(db.table3.obj6,  DataType.DateTimeOffset()),
                    new Column(db.table3.obj7,  DataType.DateTimeOffset(3)),
                    new Column(db.table3.obj8,  DataType.SmallDateTime()),
                    new Column(db.table3.obj9,  DataType.Time()),
                    new Column(db.table3.obj10, DataType.Time(4)),
                    new Column(db.table3.obj11, DataType.Decimal()),
                    new Column(db.table3.obj12, DataType.Decimal(5)),
                    new Column(db.table3.obj13, DataType.Decimal(6, 6)),
                    new Column(db.table3.obj14, DataType.Numeric()),
                    new Column(db.table3.obj15, DataType.Numeric(8)),
                    new Column(db.table3.obj16, DataType.Numeric(9, 6)),
                    new Column(db.table3.obj17, DataType.Float()),
                    new Column(db.table3.obj18, DataType.Float(5)),
                    new Column(db.table3.obj19, DataType.Real()),
                    new Column(db.table3.obj20, DataType.BigInt()),
                    new Column(db.table3.obj21, DataType.Int()),
                    new Column(db.table3.obj22, DataType.SmallInt()),
                    new Column(db.table3.obj23, DataType.TinyInt()),
                    new Column(db.table3.obj24, DataType.Money()),
                    new Column(db.table3.obj25, DataType.SmallMoney()),
                    new Column(db.table3.obj26, DataType.Binary()),
                    new Column(db.table3.obj27, DataType.Binary(8)),
                    new Column(db.table3.obj28, DataType.VarBinary()),
                    new Column(db.table3.obj29, DataType.VarBinary(6)),
                    new Column(db.table3.obj30, DataType.Char()),
                    new Column(db.table3.obj31, DataType.Char(4)),
                    new Column(db.table3.obj32, DataType.VarChar()),
                    new Column(db.table3.obj33, DataType.VarChar(7)),
                    new Column(db.table3.obj34, DataType.NChar()),
                    new Column(db.table3.obj35, DataType.NChar(9)),
                    new Column(db.table3.obj36, DataType.NVarChar()),
                    new Column(db.table3.obj37, DataType.NVarChar(3)),
                    new Column(db.table3.obj38, DataType.NText()),
                    new Column(db.table3.obj39, DataType.Text()),
                    new Column(db.table3.obj40, DataType.Image()))
                 );

            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"CREATE TABLE table3(
	obj1 BIT,
	obj2 DATE,
	obj3 DATETIME,
	obj4 DATETIME2,
	obj5 DATETIME2(2),
	obj6 DATETIMEOFFSET,
	obj7 DATETIMEOFFSET(3),
	obj8 SMALLDATETIME,
	obj9 TIME,
	obj10 TIME(4),
	obj11 DECIMAL,
	obj12 DECIMAL(5),
	obj13 DECIMAL(6, 6),
	obj14 NUMERIC,
	obj15 NUMERIC(8),
	obj16 NUMERIC(9, 6),
	obj17 FLOAT,
	obj18 FLOAT(5),
	obj19 REAL,
	obj20 BIGINT,
	obj21 INT,
	obj22 SMALLINT,
	obj23 TINYINT,
	obj24 MONEY,
	obj25 SMALLMONEY,
	obj26 BINARY,
	obj27 BINARY(8),
	obj28 VARBINARY,
	obj29 VARBINARY(6),
	obj30 CHAR,
	obj31 CHAR(4),
	obj32 VARCHAR,
	obj33 VARCHAR(7),
	obj34 NCHAR,
	obj35 NCHAR(9),
	obj36 NVARCHAR,
	obj37 NVARCHAR(3),
	obj38 NTEXT,
	obj39 TEXT,
	obj40 IMAGE)");
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
