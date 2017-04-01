using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /*
        ASCII
        CHAR
        CHARINDEX
        CONCAT
        CONCAT_WS
        DIFFERENCE
        FORMAT
        LEFT
        LTRIM
        NCHAR
        PATINDEX
        QUOTENAME
        REPLICATE
        REVERSE
        RIGHT
        RTRIM
        SOUNDEX
        STRING_AGG
        STRING_ESCAPE
        STRING_SPLIT
        STUFF
        TRANSLATE
        TRIM
        UNICODE
        UPPER
        */

        /// <summary>
        /// CONCAT function.
        /// </summary>
        /// <param name="targets">A string value to concatenate to the other values.</param>
        /// <returns>concatenated result.</returns>
        [FuncStyleConverter]
        public static string Concat(params string[] targets) { throw new InvalitContextException(nameof(Concat)); }

        /// <summary>
        /// LEN function.
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>String length.</returns>
        [FuncStyleConverter]
        public static int Len(object target) { throw new InvalitContextException(nameof(Len)); }

        /// <summary>
        /// LOWER function.
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>Changed string.</returns>
        [FuncStyleConverter]
        public static string Lower(object target) { throw new InvalitContextException(nameof(Lower)); }

        /// <summary>
        /// REPLACE function.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="src">source.</param>
        /// <param name="dst">destination.</param>
        /// <returns>Changed string.</returns>
        [FuncStyleConverter]
        public static string Replace(object target, object src, object dst) { throw new InvalitContextException(nameof(Replace)); }

        /// <summary>
        /// SUBSTRING function.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="startIndex">Specify the starting position of the character string to be acquired.</param>
        /// <param name="length">Specify the length of the string to be retrieved.</param>
        /// <returns>Part of a text.</returns>
        [FuncStyleConverter]
        public static string Substring(object target, object startIndex, object length) { throw new InvalitContextException(nameof(Substring)); }


        /// <summary>
        /// UPPER function.
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>Changed string.</returns>
        [FuncStyleConverter]
        public static string Upper(object target) { throw new InvalitContextException(nameof(Upper)); }

        /// <summary>
        /// SPACE Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/space-transact-sql
        /// </summary>
        /// <param name="target">number of spaces</param>
        /// <returns>same as SPACE(n) result</returns>
        [FuncStyleConverter]
        public static string Space(int target) { throw new InvalitContextException(nameof(Space)); }

        /// <summary>
        /// STR Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/str-transact-sql
        /// </summary>
        /// <param name="target">number of spaces</param>
        /// <param name="number">before value at point</param>
        /// <param name="point">after value at point</param>
        /// <returns>same as STR(value, int, int) result</returns>
        [FuncStyleConverter]
        public static string Str(double target, int number, int point) { throw new InvalitContextException(nameof(Str)); }

        /// <summary>
        /// ASCII Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/ascii-transact-sql
        /// </summary>
        /// <param name="value">ASCII charactor</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Ascii(Object value) { throw new InvalitContextException(nameof(Ascii)); }
    }
}
