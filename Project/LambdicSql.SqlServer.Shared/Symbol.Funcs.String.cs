using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// CONCAT function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/concat-transact-sql
        /// </summary>
        /// <param name="targets">A string value to concatenate to the other values.</param>
        /// <returns>concatenated result.</returns>
        [FuncStyleConverter]
        public static string Concat(params string[] targets) { throw new InvalitContextException(nameof(Concat)); }

        /// <summary>
        /// CONCAT_WS function.
        /// support start with SQL Server 2017
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/concat-ws-transact-sql
        /// </summary>
        /// <param name="targets">A string value to concatenate to the other values.</param>
        /// <returns>concatenat-ws-ed result.</returns>
        [FuncStyleConverter]
        public static string Concat_WS(params string[] targets) { throw new InvalitContextException(nameof(Concat_WS)); }

        /// <summary>
        /// LEN function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/len-transact-sql
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>String length.</returns>
        [FuncStyleConverter]
        public static int Len(string target) { throw new InvalitContextException(nameof(Len)); }

        /// <summary>
        /// LOWER function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/lower-transact-sql
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>Changed string.</returns>
        [FuncStyleConverter]
        public static string Lower(string target) { throw new InvalitContextException(nameof(Lower)); }

        /// <summary>
        /// REPLACE function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/replace-transact-sql
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="src">source.</param>
        /// <param name="dst">destination.</param>
        /// <returns>Changed string.</returns>
        [FuncStyleConverter]
        public static string Replace(string target, string src, string dst) { throw new InvalitContextException(nameof(Replace)); }

        /// <summary>
        /// SUBSTRING function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/substring-transact-sql
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="startIndex">Specify the starting position of the character string to be acquired.</param>
        /// <param name="length">Specify the length of the string to be retrieved.</param>
        /// <returns>Part of a text.</returns>
        [FuncStyleConverter]
        public static string Substring(string target, int startIndex, int length) { throw new InvalitContextException(nameof(Substring)); }


        /// <summary>
        /// UPPER function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/upper-transact-sql
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>Changed string.</returns>
        [FuncStyleConverter]
        public static string Upper(string target) { throw new InvalitContextException(nameof(Upper)); }

        /// <summary>
        /// SPACE Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/space-transact-sql
        /// </summary>
        /// <param name="expression">number of spaces</param>
        /// <returns>same as SPACE(n) result</returns>
        [FuncStyleConverter]
        public static string Space(int expression) { throw new InvalitContextException(nameof(Space)); }

        /// <summary>
        /// STR Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/str-transact-sql
        /// </summary>
        /// <param name="expression">float expression</param>
        /// <param name="length">total length</param>
        /// <param name="decimalFormat">Decimal format</param>
        /// <returns>same as STR(value, int, int) result</returns>
        [FuncStyleConverter]
        public static string Str(double expression, int length, int decimalFormat) { throw new InvalitContextException(nameof(Str)); }

        /// <summary>
        /// ASCII Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/ascii-transact-sql
        /// </summary>
        /// <param name="value">ASCII charactor</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static int Ascii(char value) { throw new InvalitContextException(nameof(Ascii)); }

        /// <summary>
        /// CHAR Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/char-transact-sql
        /// </summary>
        /// <param name="value">CHAR charactor</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static char Char(int value) { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CHARINDEX Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/charindex-transact-sql
        /// Lambda expression does not support default value.
        /// </summary>
        /// <param name="searchTarget">Search string</param>
        /// <param name="searchString">Search Source String</param>
        /// <param name="startLocation">search index position</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static int CharIndex(string searchTarget, string searchString, int startLocation) { throw new InvalitContextException(nameof(CharIndex)); }

        /// <summary>
        /// CHARINDEX Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/charindex-transact-sql
        /// </summary>
        /// <param name="searchTarget">Search string</param>
        /// <param name="searchString">Search Source String</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static int CharIndex(string searchTarget, string searchString) { throw new InvalitContextException(nameof(CharIndex)); }

        /// <summary>
        /// DIFFERENCE Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/difference-transact-sql
        /// </summary>
        /// <param name="target1">difference string</param>
        /// <param name="target2">difference string</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static int Difference(string target1, string target2) { throw new InvalitContextException(nameof(Difference)); }

        /// <summary>
        /// FORMAT Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/format-transact-sql
        /// </summary>
        /// <param name="value">1st is target value, 2nd is format string</param>
        /// <param name="formatStrings">1st is target value, 2nd is format string</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Format(object value, params string[] formatStrings) { throw new InvalitContextException(nameof(Symbol.Format)); }

        /// <summary>
        /// LEFT Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/left-transact-sql
        /// </summary>
        /// <param name="searchTarget">Search string</param>
        /// <param name="startLocation">start index</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Left(string searchTarget, int startLocation) { throw new InvalitContextException(nameof(Left)); }

        /// <summary>
        /// LTRIM Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/ltrim-transact-sql
        /// </summary>
        /// <param name="searchTarget">Trim position</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Ltrim(string searchTarget) { throw new InvalitContextException(nameof(Ltrim)); }

        /// <summary>
        /// NCHAR Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/nchar-transact-sql
        /// </summary>
        /// <param name="codepoint">unicode codepoint</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static char NChar(int codepoint) { throw new InvalitContextException(nameof(NChar)); }

        /// <summary>
        /// PATINDEX Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/patindex-transact-sql
        /// </summary>
        /// <param name="searchString">search pattern</param>
        /// <param name="targetString">search target</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static int PatIndex(string searchString, string targetString) { throw new InvalitContextException(nameof(PatIndex)); }

        /// <summary>
        /// QUOTENAME Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/quotename-transact-sql
        /// </summary>
        /// <param name="value">Quotering string</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string QuoteName(string value) { throw new InvalitContextException(nameof(QuoteName)); }

        /// <summary>
        /// REPLICATE Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/replicate-transact-sql
        /// </summary>
        /// <param name="value">repeate value</param>
        /// <param name="replicateCounter">repete count</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Replicate(string value, int replicateCounter) { throw new InvalitContextException(nameof(Replicate)); }

        /// <summary>
        /// REPLICATE Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/reverse-transact-sql
        /// </summary>
        /// <param name="value">reverse string</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Reverse(string value) { throw new InvalitContextException(nameof(Reverse)); }

        /// <summary>
        /// RIGHT Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/right-transact-sql
        /// </summary>
        /// <param name="searchTarget">Search string</param>
        /// <param name="startLocation">start index</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Right(string searchTarget, int startLocation) { throw new InvalitContextException(nameof(Right)); }

        /// <summary>
        /// RTRIM Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/rtrim-transact-sql
        /// </summary>
        /// <param name="searchTarget">Trim position</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Rtrim(string searchTarget) { throw new InvalitContextException(nameof(Rtrim)); }

        /// <summary>
        /// SOUNDEX Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/soundex-transact-sql
        /// </summary>
        /// <param name="value">sound text</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string SoundEx(string value) { throw new InvalitContextException(nameof(SoundEx)); }

        /// <summary>
        /// STRING_AGG Function
        /// Supports with start SQL Server 2017
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/string-agg-transact-sql
        /// </summary>
        /// <param name="value">Aggrigate string</param>
        /// <param name="separator">separator charactor</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string String_Agg(string value, string separator) { throw new InvalitContextException(nameof(String_Agg)); }

        /// <summary>
        /// STRING_AGG Function
        /// Supports with start SQL Server 2017
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/string-agg-transact-sql
        /// </summary>
        /// <param name="value">Aggrigate string</param>
        /// <param name="separator">separator charactor</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string String_Agg(string value, char separator) { throw new InvalitContextException(nameof(String_Agg)); }

        /// <summary>
        /// STRING_ESCAPE Function
        /// Supports with start SQL Server 2016
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/string-escape-transact-sql
        /// </summary>
        /// <param name="value">escape string</param>
        /// <param name="escapeType"> supports only 'JSON'</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string String_Escape(string value, string escapeType) { throw new InvalitContextException(nameof(String_Escape)); }

        /// <summary>
        /// STRING_SPLIT Function
        /// Supports with start SQL Server 2016
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/string-split-transact-sql
        /// </summary>
        /// <param name="value">Aggrigate string</param>
        /// <param name="separator">separator charactor</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string String_Split(string value, string separator) { throw new InvalitContextException(nameof(String_Split)); }

        /// <summary>
        /// STRING_SPLIT Function
        /// Supports with start SQL Server 2016
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/string-agg-transact-sql
        /// </summary>
        /// <param name="value">Aggrigate string</param>
        /// <param name="separator">separator charactor</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string String_Split(string value, char separator) { throw new InvalitContextException(nameof(String_Split)); }

        /// <summary>
        /// STUFF Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/stuff-transact-sql
        /// </summary>
        /// <param name="value">stuff text</param>
        /// <param name="start">stuff start position</param>
        /// <param name="length">stuff length</param>
        /// <param name="replaceString">replacement string</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Stuff(string value, long start, long length, string replaceString) { throw new InvalitContextException(nameof(Stuff)); }

        /// <summary>
        /// TRANSLATE Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/translate-transact-sql
        /// </summary>
        /// <param name="value">translate text</param>
        /// <param name="targetString">replace target</param>
        /// <param name="replaceString">replace string</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Translate(string value, string targetString, string replaceString) { throw new InvalitContextException(nameof(Translate)); }

        /// <summary>
        /// TRIM Function
        /// TRIM supports start with SQL Server 2017
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/trim-transact-sql
        /// </summary>
        /// <param name="trimString">Trim String</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static string Trim(string trimString) { throw new InvalitContextException(nameof(Rtrim)); }

        /// <summary>
        /// UNICODE Function
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/unicode-transact-sql
        /// </summary>
        /// <param name="UnicodeString">Unicode String</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static int Unicode(string UnicodeString) { throw new InvalitContextException(nameof(Unicode)); }
    }
}
