using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SqlServer.Symbol;
using Test.Helper;
using LambdicSql.SqlServer;
using System;

namespace Test
{
    [TestClass]
    public class TestSymbolClausesControlOfFlow
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

        public class SelectData
        {
            public DateTime PaymentDate { get; set; }
            public decimal Money { get; set; }
            public string Name { get; set; }
        }

        [TestMethod]
        public void Test_If_Object_Id()
        {
            var sql = Db<DB>.Sql(db => 
                If(Object_Id(db.tbl_remuneration) == null).
                CreateTable(
                 db.tbl_remuneration,
                 new Column(db.tbl_remuneration.id, DataType.Int(), NotNull(), PrimaryKey()),
                 new Column(db.tbl_remuneration.staff_id, DataType.Int(), NotNull()),
                 new Column(db.tbl_remuneration.payment_date, DataType.VarChar(50), NotNull()),
                 new Column(db.tbl_remuneration.money, DataType.Decimal(), NotNull())
                 ));
            
            _connection.Execute(sql);
            AssertEx.AreEqual(sql, _connection,
@"IF (OBJECT_ID('tbl_remuneration')) IS NULL
CREATE TABLE tbl_remuneration(
	id INT NOT NULL PRIMARY KEY,
	staff_id INT NOT NULL,
	payment_date VARCHAR(50) NOT NULL,
	money DECIMAL NOT NULL)");
        }

        [TestMethod]
        public void Test_If_Else()
        {
            var sql = Db<DB>.Sql(db =>
                If(Object_Id(db.tbl_remuneration) != null).
                    Select(new SelectData
                    {
                        PaymentDate = db.tbl_remuneration.payment_date,
                        Money = db.tbl_remuneration.money,
                    }).
                    From(db.tbl_remuneration).
                Else().
                    Select(new SelectData
                    {
                        Name = db.tbl_staff.name
                    }).
                    From(db.tbl_staff)
                );

            var datas = _connection.Query(sql).ToList();
            AssertEx.AreEqual(sql, _connection,
 @"IF (OBJECT_ID('tbl_remuneration')) IS NOT NULL
SELECT
	tbl_remuneration.payment_date AS PaymentDate,
	tbl_remuneration.money AS Money
FROM tbl_remuneration
ELSE
SELECT
	tbl_staff.name AS Name
FROM tbl_staff");
        }
    }
}
