using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// CUME_DIST function.
        /// </summary>
        /// <returns>Cumulative distribution of values in group.</returns>
        [FuncStyleConverter]
        public static double Cume_Dist() { throw new InvalitContextException(nameof(Cume_Dist)); }

        /// <summary>
        /// FIRST_VALUE function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>For each group, the value of the first row of the sorted record.</returns>
        [FuncStyleConverter]
        public static T First_Value<T>(T column) { throw new InvalitContextException(nameof(First_Value)); }

        /// <summary>
        /// LAST_VALUE function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>For each group, the value at the end of the sorted record.</returns>
        [FuncStyleConverter]
        public static T Last_Value<T>(T column) { throw new InvalitContextException(nameof(Last_Value)); }

        /// <summary>
        /// LAG function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Returns the value of the row at the specified offset above (before) the current row of the partition.</returns>
        [FuncStyleConverter]
        public static T Lag<T>(T column) { throw new InvalitContextException(nameof(Lag)); }

        /// <summary>
        /// LAG function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <param name="offset">An optional parameter that specifies the number of lines before the current line that returns a value.</param>
        /// <returns>Returns the value of the row at the specified offset above (before) the current row of the partition.</returns>
        [FuncStyleConverter]
        public static T Lag<T>(T column, long offset) { throw new InvalitContextException(nameof(Lag)); }

        //TODO test.
        /// <summary>
        /// LAG function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <param name="offset">An optional parameter that specifies the number of lines before the current line that returns a value.</param>
        /// <param name="default">The value returned if the value specified by offset is NULL.</param>
        /// <returns>Returns the value of the row at the specified offset above (before) the current row of the partition.</returns>
        [FuncStyleConverter]
        public static T Lag<T>(T column, long offset, T @default) { throw new InvalitContextException(nameof(Lag)); }

        /// <summary>
        /// PERCENT_RANK function.
        /// </summary>
        /// <returns>Ranked value.</returns>
        [FuncStyleConverter]
        public static double Percent_Rank() { throw new InvalitContextException(nameof(Percent_Rank)); }

        //----------------@@@------------------------
        /// <summary>
        /// LEAD
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/lead-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <param name="offset">An optional parameter that specifies the number of lines before the current line that returns a value.</param>
        /// <param name="default">The value returned if the value specified by offset is NULL.</param>
        /// <returns>offset row data.</returns>
        [FuncStyleConverter]
        public static T Lead<T>(T column, long offset, T @default) { throw new InvalitContextException(nameof(Lead)); }

        /// <summary>
        /// PERCENTILE_CONT
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/percentile-cont-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="numeric_literal">numeric_literal.</param>
        /// <returns>percentile count.</returns>
        [FuncStyleConverter]
        public static double Percentile_Count<T>(T numeric_literal) { throw new InvalitContextException(nameof(Percentile_Count)); }

        /// <summary>
        /// PERCENTILE_DISC
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/percentile-cont-transact-sql
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="numeric_literal">numeric_literal.</param>
        /// <returns>percentile disc.</returns>
        [FuncStyleConverter]
        public static double Percentile_Disc<T>(T numeric_literal) { throw new InvalitContextException(nameof(Percentile_Count)); }
    }
}
