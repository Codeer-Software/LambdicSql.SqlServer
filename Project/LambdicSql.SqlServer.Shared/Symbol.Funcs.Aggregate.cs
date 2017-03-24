using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /*
        CHECKSUM_AGG
        COUNT_BIG
        GROUPING
        GROUPING_ID
        STDEV
        STDEVP
        VAR
        VARP
        */       
        
        /// <summary>
        /// AVG function.
        /// </summary>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Average.</returns>
        [FuncStyleConverter]
        public static double Avg(object column) { throw new InvalitContextException(nameof(Avg)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Count.</returns>
        [FuncStyleConverter]
        public static int Count(object column) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="asterisk">*</param>
        /// <returns>Count.</returns>
        [FuncStyleConverter]
        public static int Count(AsteriskElement asterisk) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Count.</returns>
        [MethodFormatConverter(Format = "COUNT(|[0] [1])")]
        public static int Count(AggregatePredicateElement aggregatePredicate, object column) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Count.</returns>
        [MethodFormatConverter(Format = "COUNT(|[0] [1])")]
        public static int Count(AggregatePredicateElement aggregatePredicate, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// MIN function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Minimum.</returns>
        [FuncStyleConverter]
        public static T Min<T>(T column) { throw new InvalitContextException(nameof(Min)); }

        /// <summary>
        /// MAX function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Maximum.</returns>
        [FuncStyleConverter]
        public static T Max<T>(T column) { throw new InvalitContextException(nameof(Max)); }

        /// <summary>
        /// SUM function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Total.</returns>
        [FuncStyleConverter]
        public static T Sum<T>(T column) { throw new InvalitContextException(nameof(Sum)); }

        /// <summary>
        /// SUM function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Total.</returns>
        [MethodFormatConverter(Format = "SUM(|[0] [1])")]
        public static T Sum<T>(AggregatePredicateElement aggregatePredicate, T column) { throw new InvalitContextException(nameof(Sum)); }

    }
}
