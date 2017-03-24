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
    public class TestSymbolFuncsDateAndTimeDataTypesAnd
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
        public void Test_DatePart()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = DatePart(DateTimeElement.Year, Current_TimeStamp()),
                    Val2 = DatePart(DateTimeElement.Quarter, Current_TimeStamp()),
                    Val3 = DatePart(DateTimeElement.Month, Current_TimeStamp()),
                    Val4 = DatePart(DateTimeElement.Dayofyear, Current_TimeStamp()),
                    Val5 = DatePart(DateTimeElement.Day, Current_TimeStamp()),
                    Val6 = DatePart(DateTimeElement.Week, Current_TimeStamp()),
                    Val7 = DatePart(DateTimeElement.Weekday, Current_TimeStamp()),
                    Val8 = DatePart(DateTimeElement.Hour, Current_TimeStamp()),
                    Val9 = DatePart(DateTimeElement.Minute, Current_TimeStamp()),
                    Val10 = DatePart(DateTimeElement.Second, Current_TimeStamp()),
                    Val11 = DatePart(DateTimeElement.Millisecond, Current_TimeStamp()),
                    Val12 = DatePart(DateTimeElement.Microsecond, Current_TimeStamp()),
                    Val13 = DatePart(DateTimeElement.Nanosecond, Current_TimeStamp()),
                    Val14 = DatePart(DateTimeElement.ISO_WEEK, Current_TimeStamp())
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATEPART(YEAR, CURRENT_TIMESTAMP) AS Val1,
	DATEPART(QUARTER, CURRENT_TIMESTAMP) AS Val2,
	DATEPART(MONTH, CURRENT_TIMESTAMP) AS Val3,
	DATEPART(DAYOFYEAR, CURRENT_TIMESTAMP) AS Val4,
	DATEPART(DAY, CURRENT_TIMESTAMP) AS Val5,
	DATEPART(WEEK, CURRENT_TIMESTAMP) AS Val6,
	DATEPART(WEEKDAY, CURRENT_TIMESTAMP) AS Val7,
	DATEPART(HOUR, CURRENT_TIMESTAMP) AS Val8,
	DATEPART(MINUTE, CURRENT_TIMESTAMP) AS Val9,
	DATEPART(SECOND, CURRENT_TIMESTAMP) AS Val10,
	DATEPART(MILLISECOND, CURRENT_TIMESTAMP) AS Val11,
	DATEPART(MICROSECOND, CURRENT_TIMESTAMP) AS Val12,
	DATEPART(NANOSECOND, CURRENT_TIMESTAMP) AS Val13,
	DATEPART(ISO_WEEK, CURRENT_TIMESTAMP) AS Val14");
        }
    }
}