using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        //--------------@@@--------------------
        /// <summary>
        /// CHECKSUM_AGG function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/checksum-agg-transact-sql
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the checksum of the values in a group.</returns>
        [FuncStyleConverter]
        public static int CheckSum_Agg(object expression) { throw new InvalitContextException(nameof(CheckSum_Agg)); }

        /// <summary>
        /// CHECKSUM_AGG function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/checksum-agg-transact-sql
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the checksum of the values in a group.</returns>
        [MethodFormatConverter(Format = "CHECKSUM_AGG(|[0] [1])")]
        public static int CheckSum_Agg(AggregatePredicateBase aggregatePredicate, object expression) { throw new InvalitContextException(nameof(CheckSum_Agg)); }

        /// <summary>
        /// COUNT_BIG function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/count-big-transact-sql
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Count.</returns>
        [FuncStyleConverter]
        public static int Count_Big(object expression) { throw new InvalitContextException(nameof(Count_Big)); }

        /// <summary>
        /// COUNT_BIG function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/count-big-transact-sql
        /// </summary>
        /// <param name="asterisk">*</param>
        /// <returns>Count.</returns>
        [FuncStyleConverter]
        public static int Count_Big(AsteriskBase asterisk) { throw new InvalitContextException(nameof(Count_Big)); }

        /// <summary>
        /// COUNT_BIG function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/count-big-transact-sql
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Count.</returns>
        [MethodFormatConverter(Format = "COUNT_BIG(|[0] [1])")]
        public static int Count_Big(AggregatePredicateBase aggregatePredicate, object expression) { throw new InvalitContextException(nameof(Count_Big)); }

        /// <summary>
        /// GROUPING function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/grouping-transact-sql
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Indicates whether a specified column expression in a GROUP BY list is aggregated or not.</returns>
        [FuncStyleConverter]
        public static short Grouping(object expression) { throw new InvalitContextException(nameof(Grouping)); }

        /// <summary>
        /// GROUPING_ID function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/grouping-id-transact-sql
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Level of grouping.</returns>
        [FuncStyleConverter]
        public static int Grouping_Id(object expression) { throw new InvalitContextException(nameof(Grouping_Id)); }

        /// <summary>
        /// STDEV function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/stdev-transact-sql
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the statistical standard deviation of all values in the specified expression.</returns>
        [FuncStyleConverter]
        public static double Stdev(object expression) { throw new InvalitContextException(nameof(Stdev)); }

        /// <summary>
        /// STDEV function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/stdev-transact-sql
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the statistical standard deviation of all values in the specified expression.</returns>
        [MethodFormatConverter(Format = "CHECKSUM_AGG(|[0] [1])")]
        public static double Stdev(AggregatePredicateBase aggregatePredicate, object expression) { throw new InvalitContextException(nameof(Stdev)); }

        /// <summary>
        /// STDEVP function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/stdevp-transact-sql
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the statistical standard deviation for the population for all values in the specified expression.</returns>
        [FuncStyleConverter]
        public static double StdevP(object expression) { throw new InvalitContextException(nameof(StdevP)); }

        /// <summary>
        /// STDEVP function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/stdevp-transact-sql
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the statistical standard deviation for the population for all values in the specified expression.</returns>
        [MethodFormatConverter(Format = "CHECKSUM_AGG(|[0] [1])")]
        public static double StdevP(AggregatePredicateBase aggregatePredicate, object expression) { throw new InvalitContextException(nameof(StdevP)); }

        /// <summary>
        /// VAR function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/var-transact-sql
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the statistical variance of all values in the specified expression. May be followed by the OVER clause.</returns>
        [FuncStyleConverter]
        public static double Var(object expression) { throw new InvalitContextException(nameof(Var)); }

        /// <summary>
        /// VAR function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/var-transact-sql
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the statistical variance of all values in the specified expression. May be followed by the OVER clause.</returns>
        [MethodFormatConverter(Format = "CHECKSUM_AGG(|[0] [1])")]
        public static double Var(AggregatePredicateBase aggregatePredicate, object expression) { throw new InvalitContextException(nameof(Var)); }

        /// <summary>
        /// VARP function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/varp-transact-sql
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the statistical variance for the population for all values in the specified expression.</returns>
        [FuncStyleConverter]
        public static double VarP(object expression) { throw new InvalitContextException(nameof(VarP)); }

        /// <summary>
        /// VARP function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/varp-transact-sql
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Returns the statistical variance for the population for all values in the specified expression.</returns>
        [MethodFormatConverter(Format = "CHECKSUM_AGG(|[0] [1])")]
        public static double VarP(AggregatePredicateBase aggregatePredicate, object expression) { throw new InvalitContextException(nameof(VarP)); }
        
        /// <summary>
        /// AVG function.
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Average.</returns>
        [FuncStyleConverter]
        public static double Avg(object expression) { throw new InvalitContextException(nameof(Avg)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Count.</returns>
        [FuncStyleConverter]
        public static int Count(object expression) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="asterisk">*</param>
        /// <returns>Count.</returns>
        [FuncStyleConverter]
        public static int Count(AsteriskBase asterisk) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Count.</returns>
        [MethodFormatConverter(Format = "COUNT(|[0] [1])")]
        public static int Count(AggregatePredicateBase aggregatePredicate, object expression) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Count.</returns>
        [MethodFormatConverter(Format = "COUNT(|[0] [1])")]
        public static int Count(AggregatePredicateBase aggregatePredicate, AsteriskBase asterisk) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// MIN function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Minimum.</returns>
        [FuncStyleConverter]
        public static T Min<T>(T expression) { throw new InvalitContextException(nameof(Min)); }

        /// <summary>
        /// MAX function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Maximum.</returns>
        [FuncStyleConverter]
        public static T Max<T>(T expression) { throw new InvalitContextException(nameof(Max)); }

        /// <summary>
        /// SUM function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Total.</returns>
        [FuncStyleConverter]
        public static T Sum<T>(T expression) { throw new InvalitContextException(nameof(Sum)); }

        /// <summary>
        /// SUM function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="expression">The column or expression that is function target.</param>
        /// <returns>Total.</returns>
        [MethodFormatConverter(Format = "SUM(|[0] [1])")]
        public static T Sum<T>(AggregatePredicateBase aggregatePredicate, T expression) { throw new InvalitContextException(nameof(Sum)); }
    }
}
