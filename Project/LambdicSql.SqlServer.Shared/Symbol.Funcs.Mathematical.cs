using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// ABS function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/abs-transact-sql
        /// </summary>
        /// <param name="numeric_expression">The column or expression that is function target.</param>
        /// <returns>Absolute value.</returns>
        [FuncStyleConverter]
        public static decimal Abs(decimal numeric_expression) { throw new InvalitContextException(nameof(Abs)); }

        /// <summary>
        /// ACOS function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/acos-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>ACOS value.</returns>
        [FuncStyleConverter]
        public static double Acos(double float_expression) { throw new InvalitContextException(nameof(Acos)); }

        /// <summary>
        /// ASIN function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/asin-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>summary value.</returns>
        [FuncStyleConverter]
        public static double Asin(double float_expression) { throw new InvalitContextException(nameof(Asin)); }

        /// <summary>
        /// ATAN function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/atan-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>ATAN value.</returns>
        [FuncStyleConverter]
        public static double Atan(double float_expression) { throw new InvalitContextException(nameof(Atan)); }

        /// <summary>
        /// ATN2 function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/atn2-transact-sql
        /// </summary>
        /// <param name="float_expression1">The column or expression that is function target.</param>
        /// <param name="float_expression2">The column or expression that is function target.</param>
        /// <returns>ATN2 value.</returns>
        [FuncStyleConverter]
        public static double Atn2(double float_expression1, double float_expression2) { throw new InvalitContextException(nameof(Atn2)); }

        /// <summary>
        /// CEILING function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/ceiling-transact-sql
        /// </summary>
        /// <param name="numeric_expression">The column or expression that is function target.</param>
        /// <returns>CEILING value.</returns>
        [FuncStyleConverter]
        public static decimal Ceiling(decimal numeric_expression) { throw new InvalitContextException(nameof(Ceiling)); }

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/cos-transact-sql
        /// COS function.
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>COS value.</returns>
        [FuncStyleConverter]
        public static double Cos(double float_expression) { throw new InvalitContextException(nameof(Cos)); }

        /// <summary>
        /// COT function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/cot-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>COT value.</returns>
        [FuncStyleConverter]
        public static double Cot(double float_expression) { throw new InvalitContextException(nameof(Cot)); }

        /// <summary>
        /// DEGREES function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/degrees-transact-sql
        /// </summary>
        /// <param name="numeric_expression">The column or expression that is function target.</param>
        /// <returns>DEGREES value.</returns>
        [FuncStyleConverter]
        public static decimal Degrees(decimal numeric_expression) { throw new InvalitContextException(nameof(Degrees)); }

        /// <summary>
        /// EXP function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/exp-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>EXP value.</returns>
        [FuncStyleConverter]
        public static double Exp(double float_expression) { throw new InvalitContextException(nameof(Ceiling)); }

        /// <summary>
        /// FLOOR function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/floor-transact-sql
        /// </summary>
        /// <param name="numeric_expression">The column or expression that is function target.</param>
        /// <returns>FLOOR value.</returns>
        [FuncStyleConverter]
        public static decimal Floor(decimal numeric_expression) { throw new InvalitContextException(nameof(Floor)); }

        /// <summary>
        /// LOG function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/log-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>LOG value.</returns>
        [FuncStyleConverter]
        public static double Log(double float_expression) { throw new InvalitContextException(nameof(Log)); }

        /// <summary>
        /// LOG10 function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/log10-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>LOG10 value.</returns>
        [FuncStyleConverter]
        public static double Log10(double float_expression) { throw new InvalitContextException(nameof(Log10)); }

        /// <summary>
        /// PI function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/pi-transact-sql
        /// </summary>
        /// <returns>PI value.</returns>
        [FuncStyleConverter]
        public static double PI() { throw new InvalitContextException(nameof(Log)); }

        /// <summary>
        /// POWER function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/power-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <param name="y">The column or expression that is function target.</param>
        /// <returns>POWER value.</returns>
        [FuncStyleConverter]
        public static double Power(double float_expression, int y) { throw new InvalitContextException(nameof(Log)); }

        /// <summary>
        /// RADIANS function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/radians-transact-sql
        /// </summary>
        /// <param name="numeric_expression">The column or expression that is function target.</param>
        /// <returns>RADIANS value.</returns>
        [FuncStyleConverter]
        public static decimal Radians(decimal numeric_expression) { throw new InvalitContextException(nameof(Sign)); }
        
        /// <summary>
        /// RAND function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/rand-transact-sql
        /// </summary>
        /// <param name="seed">seed value.</param>
        /// <returns>RAND value.</returns>
        [FuncStyleConverter]
        public static double Rand(int seed) { throw new InvalitContextException(nameof(Sign)); }

        /// <summary>
        /// ROUND function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql
        /// </summary>
        /// <param name="target">Numeric expression to round.</param>
        /// <param name="digit">Is the precision to which it is to be rounded.</param>
        /// <returns>Rounded result.</returns>
        [FuncStyleConverter]
        public static T1 Round<T1, T2>(T1 target, T2 digit) { throw new InvalitContextException(nameof(Round)); }

        /// <summary>
        /// ROUND function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql
        /// </summary>
        /// <param name="target">Numeric expression to round.</param>
        /// <param name="digit">Is the precision to which it is to be rounded.</param>
        /// <returns>Rounded result.</returns>
        [FuncStyleConverter]
        public static long Round(long target, int digit) { throw new InvalitContextException(nameof(Sign)); }

        /// <summary>
        /// ROUND function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql
        /// </summary>
        /// <param name="target">Numeric expression to round.</param>
        /// <param name="digit">Is the precision to which it is to be rounded.</param>
        /// <returns>Rounded result.</returns>
        [FuncStyleConverter]
        public static int Round(int target, int digit) { throw new InvalitContextException(nameof(Sign)); }

        /// <summary>
        /// ROUND function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql
        /// </summary>
        /// <param name="target">Numeric expression to round.</param>
        /// <param name="digit">Is the precision to which it is to be rounded.</param>
        /// <returns>Rounded result.</returns>
        [FuncStyleConverter]
        public static decimal Round(decimal target, int digit) { throw new InvalitContextException(nameof(Sign)); }

        /// <summary>
        /// ROUND function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/round-transact-sql
        /// </summary>
        /// <param name="target">Numeric expression to round.</param>
        /// <param name="digit">Is the precision to which it is to be rounded.</param>
        /// <returns>Rounded result.</returns>
        [FuncStyleConverter]
        public static double Round(double target, int digit) { throw new InvalitContextException(nameof(Sign)); }

        /// <summary>
        /// SIGN function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sign-transact-sql
        /// </summary>
        /// <param name="numeric_expression">The column or expression that is function target.</param>
        /// <returns>SIGN value.</returns>
        [FuncStyleConverter]
        public static long Sign(long numeric_expression) { throw new InvalitContextException(nameof(Sign)); }

        /// <summary>
        /// SIGN function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sign-transact-sql
        /// </summary>
        /// <param name="numeric_expression">The column or expression that is function target.</param>
        /// <returns>SIGN value.</returns>
        [FuncStyleConverter]
        public static int Sign(int numeric_expression) { throw new InvalitContextException(nameof(Sign)); }

        /// <summary>
        /// SIGN function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sign-transact-sql
        /// </summary>
        /// <param name="numeric_expression">The column or expression that is function target.</param>
        /// <returns>SIGN value.</returns>
        [FuncStyleConverter]
        public static decimal Sign(decimal numeric_expression) { throw new InvalitContextException(nameof(Sign)); }

        /// <summary>
        /// SIGN function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sign-transact-sql
        /// </summary>
        /// <param name="numeric_expression">The column or expression that is function target.</param>
        /// <returns>SIGN value.</returns>
        [FuncStyleConverter]
        public static double Sign(double numeric_expression) { throw new InvalitContextException(nameof(Sign)); }

        /// <summary>
        /// SIN function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sin-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>SIN value.</returns>
        [FuncStyleConverter]
        public static double Sin(double float_expression) { throw new InvalitContextException(nameof(Sin)); }

        /// <summary>
        /// SQRT function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sqrt-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>SQRT value.</returns>
        [FuncStyleConverter]
        public static double Sqrt(double float_expression) { throw new InvalitContextException(nameof(Log)); }

        /// <summary>
        /// SQUARE function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/square-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>SQUARE value.</returns>
        [FuncStyleConverter]
        public static double Square(double float_expression) { throw new InvalitContextException(nameof(Log)); }

        /// <summary>
        /// TAN function.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/tan-transact-sql
        /// </summary>
        /// <param name="float_expression">The column or expression that is function target.</param>
        /// <returns>TAN value.</returns>
        [FuncStyleConverter]
        public static double Tan(double float_expression) { throw new InvalitContextException(nameof(Tan)); }
    }
}
