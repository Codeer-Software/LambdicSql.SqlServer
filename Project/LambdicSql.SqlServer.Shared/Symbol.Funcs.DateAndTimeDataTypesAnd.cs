using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// CURRENT_TIMESTAMP function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/current-timestamp-transact-sql</para>
        /// </summary>
        /// <returns>current database system timestamp as a datetime value without the database time zone offset.</returns>
        [ClauseStyleConverter]
        public static DateTime Current_TimeStamp() { throw new InvalitContextException(nameof(Current_TimeStamp)); }

        /// <summary>
        /// DATEADD function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="number">added to datepart of date.</param>
        /// <param name="date">The date data.</param>
        /// <returns>number added to a specified datepart of that date.</returns>
        [FuncStyleConverter]
        public static DateTime DateAdd(DateAddElement datepart, int number, DateTime date) { throw new InvalitContextException(nameof(DateAdd)); }

        /// <summary>
        /// DATEADD function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/dateadd-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="number">added to datepart of date.</param>
        /// <param name="date">The date data.</param>
        /// <returns>number added to a specified datepart of that date.</returns>
        [FuncStyleConverter]
        public static DateTime DateAdd(DateAddElement datepart, int number, DateTimeOffset date) { throw new InvalitContextException(nameof(DateAdd)); }

        /// <summary>
        /// DATEDIFF function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="startdate">start date.</param>
        /// <param name="enddate">end date.</param>
        /// <returns>Returns the count (signed integer) of the specified datepart boundaries crossed between the specified startdate and enddate. </returns>
        [FuncStyleConverter]
        public static int DateDiff(DateDiffElement datepart, DateTime startdate, DateTime enddate) { throw new InvalitContextException(nameof(DateDiff)); }
        /// <summary>
        /// DATEDIFF function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="startdate">start date.</param>
        /// <param name="enddate">end date.</param>
        /// <returns>Returns the count (signed integer) of the specified datepart boundaries crossed between the specified startdate and enddate. </returns>
        [FuncStyleConverter]
        public static int DateDiff(DateDiffElement datepart, DateTime startdate, DateTimeOffset enddate) { throw new InvalitContextException(nameof(DateDiff)); }
        /// <summary>
        /// DATEDIFF function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="startdate">start date.</param>
        /// <param name="enddate">end date.</param>
        /// <returns>Returns the count (signed integer) of the specified datepart boundaries crossed between the specified startdate and enddate. </returns>
        [FuncStyleConverter]
        public static int DateDiff(DateDiffElement datepart, DateTimeOffset startdate, DateTime enddate) { throw new InvalitContextException(nameof(DateDiff)); }
        /// <summary>
        /// DATEDIFF function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="startdate">start date.</param>
        /// <param name="enddate">end date.</param>
        /// <returns>Returns the count (signed integer) of the specified datepart boundaries crossed between the specified startdate and enddate. </returns>
        [FuncStyleConverter]
        public static int DateDiff(DateDiffElement datepart, DateTimeOffset startdate, DateTimeOffset enddate) { throw new InvalitContextException(nameof(DateDiff)); }

        /// <summary>
        /// DATEDIFF_BIG function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-big-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="startdate">start date.</param>
        /// <param name="enddate">end date.</param>
        /// <returns>Returns count (signed bigint) of the specified datepart boundaries crossed between the specified startdate and enddate.</returns>
        [FuncStyleConverter]
        public static long DateDiff_Big(DateDiffElement datepart, DateTime startdate, DateTime enddate) { throw new InvalitContextException(nameof(DateDiff)); }
        /// <summary>
        /// DATEDIFF_BIG function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-big-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="startdate">start date.</param>
        /// <param name="enddate">end date.</param>
        /// <returns>Returns count (signed bigint) of the specified datepart boundaries crossed between the specified startdate and enddate.</returns>
        [FuncStyleConverter]
        public static long DateDiff_Big(DateDiffElement datepart, DateTime startdate, DateTimeOffset enddate) { throw new InvalitContextException(nameof(DateDiff)); }
        /// <summary>
        /// DATEDIFF_BIG function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-big-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="startdate">start date.</param>
        /// <param name="enddate">end date.</param>
        /// <returns>Returns count (signed bigint) of the specified datepart boundaries crossed between the specified startdate and enddate.</returns>
        [FuncStyleConverter]
        public static long DateDiff_Big(DateDiffElement datepart, DateTimeOffset startdate, DateTime enddate) { throw new InvalitContextException(nameof(DateDiff)); }
        /// <summary>
        /// DATEDIFF_BIG function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datediff-big-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="startdate">start date.</param>
        /// <param name="enddate">end date.</param>
        /// <returns>Returns count (signed bigint) of the specified datepart boundaries crossed between the specified startdate and enddate.</returns>
        [FuncStyleConverter]
        public static long DateDiff_Big(DateDiffElement datepart, DateTimeOffset startdate, DateTimeOffset enddate) { throw new InvalitContextException(nameof(DateDiff)); }

        /// <summary>
        /// DATEFROMPARTS functions.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datefromparts-transact-sql</para>
        /// </summary>
        /// <param name="year">specifying a year.</param>
        /// <param name="month">specifying a month from 1 to 12.</param>
        /// <param name="day">specifying a day.</param>
        /// <returns>Returns a date value for the specified year, month, and day.</returns>
        [FuncStyleConverter]
        public static DateTime DateFromParts(int year, int month, int day) { throw new InvalitContextException(nameof(DateFromParts)); }

        /// <summary>
        /// DATENAME functions.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datename-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="date">The date data.</param>
        /// <returns>Returns a character string that represents the specified datepart of the specified date</returns>
        [FuncStyleConverter]
        public static string DateName(DateNameElement datepart, DateTime date) { throw new InvalitContextException(nameof(DateName)); }
        /// <summary>
        /// DATENAME functions.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datename-transact-sql</para>
        /// </summary>
        /// <param name="datepart">Part type.</param>
        /// <param name="date">The date data.</param>
        /// <returns>Returns a character string that represents the specified datepart of the specified date</returns>
        [FuncStyleConverter]
        public static string DateName(DateNameElement datepart, DateTimeOffset date) { throw new InvalitContextException(nameof(DateName)); }

        /// <summary>
        /// DATEPART function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datepart-transact-sql</para>
        /// </summary>
        /// <param name="element">Part type.</param>
        /// <param name="src">The date data.</param>
        /// <returns>A part from the date data.</returns>
        [FuncStyleConverter]
        public static int DatePart(DatePartElement element, DateTime src) { throw new InvalitContextException(nameof(DatePart)); }
        /// <summary>
        /// DATEPART function.
        /// </summary>
        /// <param name="element">Part type.</param>
        /// <param name="src">The date data.</param>
        /// <returns>A part from the date data.</returns>
        [FuncStyleConverter]
        public static int DatePart(DatePartElement element, DateTimeOffset src) { throw new InvalitContextException(nameof(DatePart)); }

        /// <summary>
        /// DATETIME2FROMPARTS functions.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datetime2fromparts-transact-sql</para>
        /// </summary>
        /// <param name="year">specifying a year.</param>
        /// <param name="month">specifying a month from 1 to 12.</param>
        /// <param name="day">specifying a day.</param>
        /// <param name="hour">specifying a hours.</param>
        /// <param name="minute">specifying a minutes.</param>
        /// <param name="seconds">specifying a seconds.</param>
        /// <param name="fractions">specifying a fractions.</param>
        /// <param name="precision">specifying a precision of the datetime2 value to be returned.</param>
        /// <returns>Returns a date value for the specified year, month, and day.</returns>
        [MethodFormatConverter(Format = "DATETIME2FROMPARTS([0], [1], [2], [3], [4], [5], [6], [$7])")]
        public static DateTime DateTime2FromParts(int year, int month, int day, int hour, int minute, int seconds, int fractions, int precision) { throw new InvalitContextException(nameof(DateTime2FromParts)); }

        /// <summary>
        /// DATETIMEFROMPARTS functions.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datetimefromparts-transact-sql</para>
        /// </summary>
        /// <param name="year">specifying a year.</param>
        /// <param name="month">specifying a month from 1 to 12.</param>
        /// <param name="day">specifying a day.</param>
        /// <param name="hour">specifying a hours.</param>
        /// <param name="minute">specifying a minutes.</param>
        /// <param name="seconds">specifying a seconds.</param>
        /// <param name="milliseconds">specifying milliseconds.</param>
        /// <returns>Returns a date value for the specified year, month, and day.</returns>
        [FuncStyleConverter]
        public static DateTime DateTimeFromParts(int year, int month, int day, int hour, int minute, int seconds, int milliseconds) { throw new InvalitContextException(nameof(DateTimeFromParts)); }

        /// <summary>
        /// DATETIMEOFFSETFROMPARTS functions.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/datetimeoffsetfromparts-transact-sql</para>
        /// </summary>
        /// <param name="year">specifying a year.</param>
        /// <param name="month">specifying a month from 1 to 12.</param>
        /// <param name="day">specifying a day.</param>
        /// <param name="hour">specifying a hours.</param>
        /// <param name="minute">specifying a minutes.</param>
        /// <param name="seconds">specifying a seconds.</param>
        /// <param name="fractions">specifying a fractions.</param>
        /// <param name="hour_offset">specifying the hour portion of the time zone offset.</param>
        /// <param name="minute_offset">specifying the minute portion of the time zone offset.</param>
        /// <param name="precision">specifying a precision of the datetimeoffset value to be returned.</param>
        /// <returns>Returns a date value for the specified year, month, and day.</returns>
        [MethodFormatConverter(Format = "DATETIMEOFFSETFROMPARTS([0], [1], [2], [3], [4], [5], [6], [7], [8], [$9])")]
        public static DateTimeOffset DateTimeOffsetFromParts(int year, int month, int day, int hour, int minute, int seconds, int fractions, int hour_offset, int minute_offset, int precision) { throw new InvalitContextException(nameof(DateTimeOffsetFromParts)); }

        /// <summary>
        /// DAY function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/day-transact-sql</para>
        /// </summary>
        /// <param name="src">The date data.</param>
        /// <returns>an integer representing the day (day of the month) of the specified date.</returns>
        [FuncStyleConverter]
        public static int Day(DateTime src) { throw new InvalitContextException(nameof(Day)); }
        /// <summary>
        /// DAY function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/day-transact-sql</para>
        /// </summary>
        /// <param name="src">The date data.</param>
        /// <returns>an integer representing the day (day of the month) of the specified date.</returns>
        [FuncStyleConverter]
        public static int Day(DateTimeOffset src) { throw new InvalitContextException(nameof(Day)); }

        /// <summary>
        /// EOMONTH function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/eomonth-transact-sql</para>
        /// </summary>
        /// <param name="start_date">Date expression specifying the date for which to return the last day of the month.</param>
        /// <returns>the last day of the month that contains the specified date, with an optional offset.</returns>
        [FuncStyleConverter]
        public static DateTime EOMonth(DateTime start_date) { throw new InvalitContextException(nameof(EOMonth)); }
        /// <summary>
        /// EOMONTH function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/eomonth-transact-sql</para>
        /// </summary>
        /// <param name="start_date">Date expression specifying the date for which to return the last day of the month.</param>
        /// <param name="month_to_add">Optional integer expression specifying the number of months to add to start_date.</param>
        /// <returns>the last day of the month that contains the specified date, with an optional offset.</returns>
        [FuncStyleConverter]
        public static DateTime EOMonth(DateTime start_date, int month_to_add) { throw new InvalitContextException(nameof(EOMonth)); }
        /// <summary>
        /// EOMONTH function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/eomonth-transact-sql</para>
        /// </summary>
        /// <param name="start_date">Date expression specifying the date for which to return the last day of the month.</param>
        /// <returns>the last day of the month that contains the specified date, with an optional offset.</returns>
        [FuncStyleConverter]
        public static DateTime EOMonth(DateTimeOffset start_date) { throw new InvalitContextException(nameof(EOMonth)); }
        /// <summary>
        /// EOMONTH function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/eomonth-transact-sql</para>
        /// </summary>
        /// <param name="start_date">Date expression specifying the date for which to return the last day of the month.</param>
        /// <param name="month_to_add">Optional integer expression specifying the number of months to add to start_date.</param>
        /// <returns>the last day of the month that contains the specified date, with an optional offset.</returns>
        [FuncStyleConverter]
        public static DateTime EOMonth(DateTimeOffset start_date, int month_to_add) { throw new InvalitContextException(nameof(EOMonth)); }

        /// <summary>
        /// GETDATE function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/getdate-transact-sql
        /// </summary>
        /// <returns>the current database system timestamp as a datetime value without the database time zone offset. This value is derived from the operating system of the computer on which the instance of SQL Server is running.</returns>
        [FuncStyleConverter]
        public static DateTime GetDate() { throw new InvalitContextException(nameof(GetDate)); }
        /// <summary>
        /// GETUTCDATE function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/getutcdate-transact-sql
        /// </summary>
        /// <returns>the current database system timestamp as a datetime value. The database time zone offset is not included. This value represents the current UTC time (Coordinated Universal Time). This value is derived from the operating system of the computer on which the instance of SQL Server is running.</returns>
        [FuncStyleConverter]
        public static DateTime GetUtcDate() { throw new InvalitContextException(nameof(GetUtcDate)); }

        /// <summary>
        /// ISDATE function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/isdate-transact-sql
        /// </summary>
        /// <param name="expression">Is a character string or expression that can be converted to a character string. The expression must be less than 4,000 characters. Date and time data types, except datetime and smalldatetime, are not allowed as the argument for ISDATE.</param>
        /// <returns>1 if the expression is a valid date, time, or datetime value; otherwise, 0.</returns>
        [FuncStyleConverter]
        public static int IsDate(object expression) { throw new InvalitContextException(nameof(IsDate)); }

        /// <summary>
        /// MONTH function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/month-transact-sql</para>
        /// </summary>
        /// <param name="src">The date data.</param>
        /// <returns>an integer representing the month of the specified date.</returns>
        [FuncStyleConverter]
        public static int Month(DateTime src) { throw new InvalitContextException(nameof(Month)); }
        /// <summary>
        /// MONTH function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/month-transact-sql</para>
        /// </summary>
        /// <param name="src">The date data.</param>
        /// <returns>an integer representing the month of the specified date.</returns>
        [FuncStyleConverter]
        public static int Month(DateTimeOffset src) { throw new InvalitContextException(nameof(Month)); }

        /// <summary>
        /// SMALLDATETIMEFROMPARTS functions.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/smalldatetimefromparts-transact-sql</para>
        /// </summary>
        /// <param name="year">specifying a year.</param>
        /// <param name="month">specifying a month from 1 to 12.</param>
        /// <param name="day">specifying a day.</param>
        /// <param name="hour">specifying a hours.</param>
        /// <param name="minute">specifying a minutes.</param>
        /// <returns>a smalldatetime value for the specified date and time.</returns>
        [FuncStyleConverter]
        public static DateTime SmallDateTimeFromParts(int year, int month, int day, int hour, int minute) { throw new InvalitContextException(nameof(SmallDateTimeFromParts)); }

        /// <summary>
        /// SWITCHOFFSET function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/switchoffset-transact-sql</para>
        /// </summary>
        /// <param name="datetimeoffset">Is an expression that can be resolved to a datetimeoffset(n) value.</param>
        /// <param name="time_zone">Is a character string in the format [+|-]TZH:TZM or a signed integer (of minutes) that represents the time zone offset, and is assumed to be daylight-saving aware and adjusted.</param>
        /// <returns>a datetimeoffset value that is changed from the stored time zone offset to a specified new time zone offset.</returns>
        [FuncStyleConverter]
        public static DateTimeOffset SwitchOffset(DateTimeOffset datetimeoffset, string time_zone) { throw new InvalitContextException(nameof(SwitchOffset)); }

        /// <summary>
        /// SYSDATETIME function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sysdatetime-transact-sql
        /// </summary>
        /// <returns>datetime2(7) value that contains the date and time of the computer on which the instance of SQL Server is running.</returns>
        [FuncStyleConverter]
        public static DateTime SysDateTime() { throw new InvalitContextException(nameof(SysDateTime)); }

        /// <summary>
        /// SYSDATETIMEOFFSET function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sysdatetimeoffset-transact-sql
        /// </summary>
        /// <returns>datetimeoffset(7) value that contains the date and time of the computer on which the instance of SQL Server is running. The time zone offset is included. </returns>
        [FuncStyleConverter]
        public static DateTimeOffset SysDateTimeOffset() { throw new InvalitContextException(nameof(SysDateTimeOffset)); }

        /// <summary>
        /// SYSUTCDATETIME function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sysutcdatetime-transact-sql
        /// </summary>
        /// <returns> datetime2 value that contains the date and time of the computer on which the instance of SQL Server is running. The date and time is returned as UTC time (Coordinated Universal Time). The fractional second precision specification has a range from 1 to 7 digits. The default precision is 7 digits. </returns>
        [FuncStyleConverter]
        public static DateTime SysUtcDateTime() { throw new InvalitContextException(nameof(SysUtcDateTime)); }

        /// <summary>
        /// TIMEFROMPARTS functions.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/timefromparts-transact-sql</para>
        /// </summary>
        /// <param name="hour">specifying a hours.</param>
        /// <param name="minute">specifying a minutes.</param>
        /// <param name="seconds">specifying a seconds.</param>
        /// <param name="fractions">specifying a fractions.</param>
        /// <param name="precision">specifying a precision of the datetime2 value to be returned.</param>
        /// <returns>Returns a date value for the specified year, month, and day.</returns>
        [MethodFormatConverter(Format = "TIMEFROMPARTS([0], [1], [2], [3], [$4])")]
        public static TimeSpan TimeFromParts(int hour, int minute, int seconds, int fractions, int precision) { throw new InvalitContextException(nameof(TimeFromParts)); }

        /// <summary>
        /// TODATETIMEOFFSET function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/todatetimeoffset-transact-sql</para>
        /// </summary>
        /// <param name="expression">Is an expression that resolves to a datetime2 value. </param>
        /// <param name="time_zone">Is a character string in the format [+|-]TZH:TZM or a signed integer (of minutes) that represents the time zone offset, and is assumed to be daylight-saving aware and adjusted.</param>
        /// <returns>a datetimeoffset value that is translated from a datetime2 expression.</returns>
        [FuncStyleConverter]
        public static DateTimeOffset ToDateTimeOffset(DateTime expression, string time_zone) { throw new InvalitContextException(nameof(ToDateTimeOffset)); }

        /// <summary>
        /// YEAR function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/year-transact-sql</para>
        /// </summary>
        /// <param name="src">The date data.</param>
        /// <returns>an integer representing the year of the specified date.</returns>
        [FuncStyleConverter]
        public static int Year(DateTime src) { throw new InvalitContextException(nameof(Year)); }
        /// <summary>
        /// YEAR function.
        /// <para>https://docs.microsoft.com/en-us/sql/t-sql/functions/year-transact-sql</para>
        /// </summary>
        /// <param name="src">The date data.</param>
        /// <returns>an integer representing the year of the specified date.</returns>
        [FuncStyleConverter]
        public static int Year(DateTimeOffset src) { throw new InvalitContextException(nameof(Year)); }
    }
}
