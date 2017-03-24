using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /*
        ACOS
        ASIN
        ATAN
        ATN2
        CEILING
        COS
        COT
        DEGREES
        EXP
        FLOOR
        LOG
        LOG10
        PI
        POWER
        RADIANS
        RAND
        SIGN
        SIN
        SQRT
        SQUARE
        TAN
         */
        /// <summary>
        /// ABS function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Absolute value.</returns>
        [FuncStyleConverter]
        public static T Abs<T>(T column) { throw new InvalitContextException(nameof(Abs)); }

        /// <summary>
        /// ROUND function.
        /// </summary>
        /// <typeparam name="T1">Type represented by target.</typeparam>
        /// <typeparam name="T2">Type represented by digit</typeparam>
        /// <param name="target">Numeric expression to round.</param>
        /// <param name="digit">Is the precision to which it is to be rounded.</param>
        /// <returns>Rounded result.</returns>
        [FuncStyleConverter]
        public static T1 Round<T1, T2>(T1 target, T2 digit) { throw new InvalitContextException(nameof(Round)); }
    }
}
