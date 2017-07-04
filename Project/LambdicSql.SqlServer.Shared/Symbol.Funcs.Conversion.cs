using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// CAST function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/cast-and-convert-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Type of destination.</typeparam>
        /// <param name="target"></param>
        /// <param name="destinationType">Type of destination.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "CAST(|[0] AS [1])")]
        public static TDst Cast<TDst>(object target, DataTypeElement destinationType) { throw new InvalitContextException(nameof(Cast)); }

        /// <summary>
        /// CONVERT function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/cast-and-convert-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Converts an expression of one data type to another data type.</typeparam>
        /// <param name="target"></param>
        /// <param name="destinationType">Type of destination.</param>
        /// <returns>Converted data.</returns>
        [FuncStyleConverter]
        public static TDst Convert<TDst>(DataTypeElement type, object expression) { throw new InvalitContextException(nameof(Convert)); }

        /// <summary>
        /// PARSE function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/parse-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Converts an expression of one data type to another data type.</typeparam>
        /// <param name="value"></param>
        /// <param name="type">Type of destination.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "PARSE([0] AS [1])")]
        public static TDst Parse<TDst>(object value, DataTypeElement type) { throw new InvalitContextException(nameof(Parse)); }

        [MethodFormatConverter(Format = "PARSE([0] AS [1] USING [2])")]
        public static TDst Parse<TDst>(object value, DataTypeElement type, string culture) { throw new InvalitContextException(nameof(Parse)); }

        /// <summary>
        /// TRY_CAST function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/try-cast-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Returns a value cast to the specified data type if the cast succeeds; otherwise, returns null.</typeparam>
        /// <param name="value"></param>
        /// <param name="type">Type of destination.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "TRY_CAST([0] AS [1])")]
        public static TDst Try_Cast<TDst>(object value, DataTypeElement type) { throw new InvalitContextException(nameof(Try_Cast)); }

        /// <summary>
        /// TRY_CONVERT function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/try-convert-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Returns a value cast to the specified data type if the cast succeeds; otherwise, returns null.</typeparam>
        /// <param name="value"></param>
        /// <param name="type">Type of destination.</param>
        /// <returns>Converted data.</returns>
        [FuncStyleConverter]
        public static TDst Try_Convert<TDst>(DataTypeElement type, object expression) { throw new InvalitContextException(nameof(Try_Convert)); }

        /// <summary>
        /// TRY_PARSE function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/try-parse-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Returns a value cast to the specified data type if the cast succeeds; otherwise, returns null.</typeparam>
        /// <param name="value"></param>
        /// <param name="type">Type of destination.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "TRY_PARSE([0] AS [1])")]
        public static TDst Try_Parse<TDst>(object value, DataTypeElement type) { throw new InvalitContextException(nameof(Try_Parse)); }

        [MethodFormatConverter(Format = "TRY_PARSE([0] AS [1] USING [2])")]
        public static TDst Try_Parse<TDst>(object value, DataTypeElement type, string culture) { throw new InvalitContextException(nameof(Try_Parse)); }

    }
}
