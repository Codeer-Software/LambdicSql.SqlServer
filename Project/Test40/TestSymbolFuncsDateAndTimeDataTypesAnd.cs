using LambdicSql;
using LambdicSql.feat.Dapper;
using LambdicSql.SqlServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;
using Test.Helper;
using static LambdicSql.SqlServer.Symbol;

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
        public void Test_CurrentTimeStamp()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = Current_TimeStamp()
            }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	CURRENT_TIMESTAMP AS Val");
        }

        [TestMethod]
        public void Test_DateAdd()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = DateAdd(DateAddElement.Year, 1, Current_TimeStamp()),
                    Val2 = DateAdd(DateAddElement.Quarter, 2, Current_TimeStamp()),
                    Val3 = DateAdd(DateAddElement.Month, 3, Current_TimeStamp()),
                    Val4 = DateAdd(DateAddElement.Dayofyear, 4, Current_TimeStamp()),
                    Val5 = DateAdd(DateAddElement.Day, 5, Current_TimeStamp()),
                    Val6 = DateAdd(DateAddElement.Week, 6, Current_TimeStamp()),
                    Val7 = DateAdd(DateAddElement.Weekday, 7, Current_TimeStamp()),
                    Val8 = DateAdd(DateAddElement.Hour, 8, Current_TimeStamp()),
                    Val9 = DateAdd(DateAddElement.Minute, 9, Current_TimeStamp()),
                    Val10 = DateAdd(DateAddElement.Second, 10, Current_TimeStamp()),
                    Val11 = DateAdd(DateAddElement.Millisecond, -11, SysDateTime()),
                    Val12 = DateAdd(DateAddElement.Microsecond, 12, SysDateTime()),
                    Val13 = DateAdd(DateAddElement.Nanosecond, -13, SysDateTime())
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATEADD(YEAR, @p_0, CURRENT_TIMESTAMP) AS Val1,
	DATEADD(QUARTER, @p_1, CURRENT_TIMESTAMP) AS Val2,
	DATEADD(MONTH, @p_2, CURRENT_TIMESTAMP) AS Val3,
	DATEADD(DAYOFYEAR, @p_3, CURRENT_TIMESTAMP) AS Val4,
	DATEADD(DAY, @p_4, CURRENT_TIMESTAMP) AS Val5,
	DATEADD(WEEK, @p_5, CURRENT_TIMESTAMP) AS Val6,
	DATEADD(WEEKDAY, @p_6, CURRENT_TIMESTAMP) AS Val7,
	DATEADD(HOUR, @p_7, CURRENT_TIMESTAMP) AS Val8,
	DATEADD(MINUTE, @p_8, CURRENT_TIMESTAMP) AS Val9,
	DATEADD(SECOND, @p_9, CURRENT_TIMESTAMP) AS Val10,
	DATEADD(MILLISECOND, @p_10, SYSDATETIME()) AS Val11,
	DATEADD(MICROSECOND, @p_11, SYSDATETIME()) AS Val12,
	DATEADD(NANOSECOND, @p_12, SYSDATETIME()) AS Val13", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, 12, -13);
        }

        [TestMethod]
        public void Test_DateDiff()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = DateDiff(DateDiffElement.Year, Current_TimeStamp(), Current_TimeStamp()),
                    Val2 = DateDiff(DateDiffElement.Quarter, Current_TimeStamp(), Current_TimeStamp()),
                    Val3 = DateDiff(DateDiffElement.Month, Current_TimeStamp(), Current_TimeStamp()),
                    Val4 = DateDiff(DateDiffElement.Dayofyear, Current_TimeStamp(), SysDateTimeOffset()),
                    Val5 = DateDiff(DateDiffElement.Day, Current_TimeStamp(), SysDateTimeOffset()),
                    Val6 = DateDiff(DateDiffElement.Week, Current_TimeStamp(), SysDateTimeOffset()),
                    Val7 = DateDiff(DateDiffElement.Hour, SysDateTimeOffset(), Current_TimeStamp()),
                    Val8 = DateDiff(DateDiffElement.Minute, SysDateTimeOffset(), Current_TimeStamp()),
                    Val9 = DateDiff(DateDiffElement.Second, SysDateTimeOffset(), Current_TimeStamp()),
                    Val10 = DateDiff(DateDiffElement.Millisecond, SysDateTimeOffset(), SysDateTimeOffset()),
                    Val11 = DateDiff(DateDiffElement.Microsecond, SysDateTimeOffset(), SysDateTimeOffset()),
                    Val12 = DateDiff(DateDiffElement.Nanosecond, SysDateTimeOffset(), SysDateTimeOffset())
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATEDIFF(YEAR, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP) AS Val1,
	DATEDIFF(QUARTER, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP) AS Val2,
	DATEDIFF(MONTH, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP) AS Val3,
	DATEDIFF(DAYOFYEAR, CURRENT_TIMESTAMP, SYSDATETIMEOFFSET()) AS Val4,
	DATEDIFF(DAY, CURRENT_TIMESTAMP, SYSDATETIMEOFFSET()) AS Val5,
	DATEDIFF(WEEK, CURRENT_TIMESTAMP, SYSDATETIMEOFFSET()) AS Val6,
	DATEDIFF(HOUR, SYSDATETIMEOFFSET(), CURRENT_TIMESTAMP) AS Val7,
	DATEDIFF(MINUTE, SYSDATETIMEOFFSET(), CURRENT_TIMESTAMP) AS Val8,
	DATEDIFF(SECOND, SYSDATETIMEOFFSET(), CURRENT_TIMESTAMP) AS Val9,
	DATEDIFF(MILLISECOND, SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET()) AS Val10,
	DATEDIFF(MICROSECOND, SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET()) AS Val11,
	DATEDIFF(NANOSECOND, SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET()) AS Val12");
        }

        [TestMethod]
        public void Test_DateDiff_Big()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = DateDiff_Big(DateDiffElement.Year, Current_TimeStamp(), Current_TimeStamp()),
                    Val2 = DateDiff_Big(DateDiffElement.Quarter, Current_TimeStamp(), Current_TimeStamp()),
                    Val3 = DateDiff_Big(DateDiffElement.Month, Current_TimeStamp(), Current_TimeStamp()),
                    Val4 = DateDiff_Big(DateDiffElement.Dayofyear, Current_TimeStamp(), SysDateTimeOffset()),
                    Val5 = DateDiff_Big(DateDiffElement.Day, Current_TimeStamp(), SysDateTimeOffset()),
                    Val6 = DateDiff_Big(DateDiffElement.Week, Current_TimeStamp(), SysDateTimeOffset()),
                    Val7 = DateDiff_Big(DateDiffElement.Hour, SysDateTimeOffset(), Current_TimeStamp()),
                    Val8 = DateDiff_Big(DateDiffElement.Minute, SysDateTimeOffset(), Current_TimeStamp()),
                    Val9 = DateDiff_Big(DateDiffElement.Second, SysDateTimeOffset(), Current_TimeStamp()),
                    Val10 = DateDiff_Big(DateDiffElement.Millisecond, SysDateTimeOffset(), SysDateTimeOffset()),
                    Val11 = DateDiff_Big(DateDiffElement.Microsecond, SysDateTimeOffset(), SysDateTimeOffset()),
                    Val12 = DateDiff_Big(DateDiffElement.Nanosecond, SysDateTimeOffset(), SysDateTimeOffset())
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATEDIFF_BIG(YEAR, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP) AS Val1,
	DATEDIFF_BIG(QUARTER, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP) AS Val2,
	DATEDIFF_BIG(MONTH, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP) AS Val3,
	DATEDIFF_BIG(DAYOFYEAR, CURRENT_TIMESTAMP, SYSDATETIMEOFFSET()) AS Val4,
	DATEDIFF_BIG(DAY, CURRENT_TIMESTAMP, SYSDATETIMEOFFSET()) AS Val5,
	DATEDIFF_BIG(WEEK, CURRENT_TIMESTAMP, SYSDATETIMEOFFSET()) AS Val6,
	DATEDIFF_BIG(HOUR, SYSDATETIMEOFFSET(), CURRENT_TIMESTAMP) AS Val7,
	DATEDIFF_BIG(MINUTE, SYSDATETIMEOFFSET(), CURRENT_TIMESTAMP) AS Val8,
	DATEDIFF_BIG(SECOND, SYSDATETIMEOFFSET(), CURRENT_TIMESTAMP) AS Val9,
	DATEDIFF_BIG(MILLISECOND, SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET()) AS Val10,
	DATEDIFF_BIG(MICROSECOND, SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET()) AS Val11,
	DATEDIFF_BIG(NANOSECOND, SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET()) AS Val12");
        }

        [TestMethod]
        public void Test_DateFromParts()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = DateFromParts(2017, 4, 2)
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATEFROMPARTS(@p_0, @p_1, @p_2) AS Val1", 2017, 4, 2);
        }

        [TestMethod]
        public void Test_DateName()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = DateName(DateNameElement.Year, Current_TimeStamp()),
                    Val2 = DateName(DateNameElement.Quarter, SysDateTimeOffset()),
                    Val3 = DateName(DateNameElement.Month, Current_TimeStamp()),
                    Val4 = DateName(DateNameElement.Dayofyear, SysDateTimeOffset()),
                    Val5 = DateName(DateNameElement.Day, Current_TimeStamp()),
                    Val6 = DateName(DateNameElement.Week, SysDateTimeOffset()),
                    Val7 = DateName(DateNameElement.Weekday, Current_TimeStamp()),
                    Val8 = DateName(DateNameElement.Hour, SysDateTimeOffset()),
                    Val9 = DateName(DateNameElement.Minute, Current_TimeStamp()),
                    Val10 = DateName(DateNameElement.Second, SysDateTimeOffset()),
                    Val11 = DateName(DateNameElement.Millisecond, Current_TimeStamp()),
                    Val12 = DateName(DateNameElement.Microsecond, SysDateTimeOffset()),
                    Val13 = DateName(DateNameElement.Nanosecond, Current_TimeStamp()), 
                    Val14 = DateName(DateNameElement.TZOffset, SysDateTimeOffset()), 
                    Val15 = DateName(DateNameElement.ISO_WEEK, Current_TimeStamp())
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATENAME(YEAR, CURRENT_TIMESTAMP) AS Val1,
	DATENAME(QUARTER, SYSDATETIMEOFFSET()) AS Val2,
	DATENAME(MONTH, CURRENT_TIMESTAMP) AS Val3,
	DATENAME(DAYOFYEAR, SYSDATETIMEOFFSET()) AS Val4,
	DATENAME(DAY, CURRENT_TIMESTAMP) AS Val5,
	DATENAME(WEEK, SYSDATETIMEOFFSET()) AS Val6,
	DATENAME(WEEKDAY, CURRENT_TIMESTAMP) AS Val7,
	DATENAME(HOUR, SYSDATETIMEOFFSET()) AS Val8,
	DATENAME(MINUTE, CURRENT_TIMESTAMP) AS Val9,
	DATENAME(SECOND, SYSDATETIMEOFFSET()) AS Val10,
	DATENAME(MILLISECOND, CURRENT_TIMESTAMP) AS Val11,
	DATENAME(MICROSECOND, SYSDATETIMEOFFSET()) AS Val12,
	DATENAME(NANOSECOND, CURRENT_TIMESTAMP) AS Val13,
	DATENAME(TZOFFSET, SYSDATETIMEOFFSET()) AS Val14,
	DATENAME(ISO_WEEK, CURRENT_TIMESTAMP) AS Val15");
        }

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
                    Val11 = DatePart(DateTimeElement.Millisecond, SysDateTimeOffset()),
                    Val12 = DatePart(DateTimeElement.Microsecond, SysDateTimeOffset()),
                    Val13 = DatePart(DateTimeElement.Nanosecond, SysDateTimeOffset()),
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
	DATEPART(MILLISECOND, SYSDATETIMEOFFSET()) AS Val11,
	DATEPART(MICROSECOND, SYSDATETIMEOFFSET()) AS Val12,
	DATEPART(NANOSECOND, SYSDATETIMEOFFSET()) AS Val13,
	DATEPART(ISO_WEEK, CURRENT_TIMESTAMP) AS Val14");
        }

        [TestMethod]
        public void Test_DateTime2FromParts()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = DateTime2FromParts(2017, 4, 2, 14, 45, 1, 0, 0)
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATETIME2FROMPARTS(@p_0, @p_1, @p_2, @p_3, @p_4, @p_5, @p_6, 0) AS Val1", 2017, 4, 2, 14, 45, 1, 0);
        }

        [TestMethod]
        public void Test_DateTimeFromParts()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = DateTimeFromParts(2017, 4, 2, 14, 45, 1, 100)
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATETIMEFROMPARTS(@p_0, @p_1, @p_2, @p_3, @p_4, @p_5, @p_6) AS Val1", 2017, 4, 2, 14, 45, 1, 100);
        }

        [TestMethod]
        public void Test_DateTimeOffsetFromParts()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = DateTimeOffsetFromParts(2017, 4, 2, 14, 45, 1, 0, 9, 0, 0)
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DATETIMEOFFSETFROMPARTS(@p_0, @p_1, @p_2, @p_3, @p_4, @p_5, @p_6, @p_7, @p_8, 0) AS Val1", 2017, 4, 2, 14, 45, 1, 0, 9, 0);
        }

        [TestMethod]
        public void Test_Day()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Day(Current_TimeStamp()),
                    Val2 = Day(SysDateTimeOffset())
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	DAY(CURRENT_TIMESTAMP) AS Val1,
	DAY(SYSDATETIMEOFFSET()) AS Val2");
        }

        [TestMethod]
        public void Test_EOMonth()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new 
                {
                    Val1 = EOMonth(Current_TimeStamp()),
                    Val2 = EOMonth(Current_TimeStamp(), 1),
                    Val3 = EOMonth(SysDateTimeOffset()), 
                    Val4 = EOMonth(SysDateTimeOffset(), -1)
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	EOMONTH(CURRENT_TIMESTAMP) AS Val1,
	EOMONTH(CURRENT_TIMESTAMP, @p_0) AS Val2,
	EOMONTH(SYSDATETIMEOFFSET()) AS Val3,
	EOMONTH(SYSDATETIMEOFFSET(), @p_1) AS Val4", 1, -1);
        }

        [TestMethod]
        public void Test_GetDate()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = GetDate()
            }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	GETDATE() AS Val");
        }

        [TestMethod]
        public void Test_GetUtcDate()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = GetUtcDate()
            }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	GETUTCDATE() AS Val");
        }

        [TestMethod]
        public void Test_IsDate()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val1 = IsDate("2017-04-01"), 
                Val2 = IsDate(null), 
                Val3 = IsDate(20170401),
                Val4 = IsDate(Current_TimeStamp()), 
                Val5 = IsDate("2017-04-01 12:34:56.000")
            }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	ISDATE(@p_0) AS Val1,
	ISDATE(@p_1) AS Val2,
	ISDATE(@p_2) AS Val3,
	ISDATE(CURRENT_TIMESTAMP) AS Val4,
	ISDATE(@p_3) AS Val5", "2017-04-01", null, 20170401, "2017-04-01 12:34:56.000");
        }

        [TestMethod]
        public void Test_Month()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Month(Current_TimeStamp()),
                    Val2 = Month(SysDateTimeOffset())
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	MONTH(CURRENT_TIMESTAMP) AS Val1,
	MONTH(SYSDATETIMEOFFSET()) AS Val2");
        }

        [TestMethod]
        public void Test_SmallDateTimeFromParts()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = SmallDateTimeFromParts(2017, 4, 2, 14, 45)
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SMALLDATETIMEFROMPARTS(@p_0, @p_1, @p_2, @p_3, @p_4) AS Val1", 2017, 4, 2, 14, 45);
        }

        [TestMethod]
        public void Test_SwitchOffset()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = SwitchOffset(SysDateTimeOffset(), "-04:00")
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SWITCHOFFSET(SYSDATETIMEOFFSET(), @p_0) AS Val", "-04:00");
        }

        [TestMethod]
        public void Test_SysDateTime()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = SysDateTime()
            }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SYSDATETIME() AS Val");
        }

        [TestMethod]
        public void Test_SysDateTimeOffset()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = SysDateTimeOffset()
            }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SYSDATETIMEOFFSET() AS Val");
        }

        [TestMethod]
        public void Test_SysUtcDateTime()
        {
            var sql = Db<DB>.Sql(db =>
            Select(new
            {
                Val = SysUtcDateTime()
            }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	SYSUTCDATETIME() AS Val");
        }

        [TestMethod]
        public void Test_TimeFromParts()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = TimeFromParts(14, 45, 1, 0, 0)
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TIMEFROMPARTS(@p_0, @p_1, @p_2, @p_3, 0) AS Val1", 14, 45, 1, 0);
        }

        [TestMethod]
        public void Test_ToDateTimeOffset()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val = ToDateTimeOffset(Current_TimeStamp(), "-04:00")
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	TODATETIMEOFFSET(CURRENT_TIMESTAMP, @p_0) AS Val", "-04:00");
        }

        [TestMethod]
        public void Test_Year()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new
                {
                    Val1 = Year(Current_TimeStamp()),
                    Val2 = Year(SysDateTimeOffset())
                }));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	YEAR(CURRENT_TIMESTAMP) AS Val1,
	YEAR(SYSDATETIMEOFFSET()) AS Val2");
        }
    }
}