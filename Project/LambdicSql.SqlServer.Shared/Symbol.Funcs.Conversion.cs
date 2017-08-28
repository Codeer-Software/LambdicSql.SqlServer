using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// CAST function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/cast-and-convert-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Type of destination.</typeparam>
        /// <param name="target">The string to test.</param>
        /// <param name="destinationType">Type of destination.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "CAST(|[0] AS [1])")]
        public static TDst Cast<TDst>(object target, DataTypeBase destinationType) => throw new InvalitContextException(nameof(Cast));

        /// <summary>
        /// CONVERT function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/cast-and-convert-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Converts an expression of one data type to another data type.</typeparam>
        /// <param name="type">Is the target data type. This includes xml, bigint, and sql_variant. Alias data types cannot be used.</param>
        /// <param name="expression">Is any valid expression.</param>
        /// <returns>Converted data.</returns>
        [FuncStyleConverter]
        public static TDst Convert<TDst>(DataTypeBase type, object expression) => throw new InvalitContextException(nameof(Convert));

        /// <summary>
        /// PARSE function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/parse-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Converts an expression of one data type to another data type.</typeparam>
        /// <param name="string_value">string_value must be a valid representation of the requested data type, or PARSE raises an error.</param>
        /// <param name="data_type">Literal value representing the data type requested for the result.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "PARSE([0] AS [1])")]
        public static TDst Parse<TDst>(object string_value, DataTypeBase data_type) => throw new InvalitContextException(nameof(Parse));

        /// <summary>
        /// PARSE function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/parse-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Converts an expression of one data type to another data type.</typeparam>
        /// <param name="string_value">string_value must be a valid representation of the requested data type, or PARSE raises an error.</param>
        /// <param name="data_type">Literal value representing the data type requested for the result.</param>
        /// <param name="culture">Optional string that identifies the culture in which string_value is formatted.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "PARSE([0] AS [1] USING [2])")]
        public static TDst Parse<TDst>(object string_value, DataTypeBase data_type, string culture) => throw new InvalitContextException(nameof(Parse));

        /// <summary>
        /// TRY_CAST function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/try-cast-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Returns a value cast to the specified data type if the cast succeeds; otherwise, returns null.</typeparam>
        /// <param name="expression">The value to be cast. Any valid expression.</param>
        /// <param name="data_type">The data type into which to cast expression.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "TRY_CAST([0] AS [1])")]
        public static TDst Try_Cast<TDst>(object expression, DataTypeBase data_type) => throw new InvalitContextException(nameof(Try_Cast));

        /// <summary>
        /// TRY_CONVERT function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/try-convert-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Returns a value cast to the specified data type if the cast succeeds; otherwise, returns null.</typeparam>
        /// <param name="type">Type of destination.</param>
        /// <param name="expression">Is any valid expression.</param>
        /// <returns>Converted data.</returns>
        [FuncStyleConverter]
        public static TDst Try_Convert<TDst>(DataTypeBase type, object expression) => throw new InvalitContextException(nameof(Try_Convert));

        /// <summary>
        /// TRY_PARSE function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/try-parse-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Returns a value cast to the specified data type if the cast succeeds; otherwise, returns null.</typeparam>
        /// <param name="string_value">nvarchar(4000) value representing the formatted value to parse into the specified data type.</param>
        /// <param name="data_type">Literal representing the data type requested for the result.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "TRY_PARSE([0] AS [1])")]
        public static TDst Try_Parse<TDst>(object string_value, DataTypeBase data_type) => throw new InvalitContextException(nameof(Try_Parse));

        /// <summary>
        /// TRY_PARSE function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/try-parse-transact-sql
        /// </summary>
        /// <typeparam name="TDst">Returns a value cast to the specified data type if the cast succeeds; otherwise, returns null.</typeparam>
        /// <param name="string_value">nvarchar(4000) value representing the formatted value to parse into the specified data type.</param>
        /// <param name="data_type">Literal representing the data type requested for the result.</param>
        /// <param name="culture">Optional string that identifies the culture in which string_value is formatted.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "TRY_PARSE([0] AS [1] USING [2])")]
        public static TDst Try_Parse<TDst>(object string_value, DataTypeBase data_type, string culture) => throw new InvalitContextException(nameof(Try_Parse));
    }
}
