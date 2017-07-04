using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// ISJSON function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/isjson-transact-sql
        /// </summary>
        /// <param name="target">The string to test.</param>
        /// <returns>Returns 1 if the string contains valid JSON; otherwise, returns 0. Returns null if expression is null. Does not return errors.</returns>
        [FuncStyleConverter]
        public static int? IsJson(object target) => throw new InvalitContextException(nameof(IsJson));

        /// <summary>
        /// JSON_VALUE function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/json-value-transact-sql
        /// </summary>
        /// <param name="expression">An expression. Typically the name of a variable or a column that contains JSON text.</param>
        /// <param name="path">A JSON path that specifies the property to extract.</param>
        /// <returns>Returns a single text value of type nvarchar(4000). The collation of the returned value is the same as the collation of the input expression.</returns>
        [MethodFormatConverter(Format = "JSON_VALUE([0], [$1])")]
        public static string Json_Value(object expression, string path) => throw new InvalitContextException(nameof(Json_Value));

        /// <summary>
        /// JSON_QUERY
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/json-query-transact-sql
        /// </summary>
        /// <param name="expression">An expression. Typically the name of a variable or a column that contains JSON text.</param>
        /// <returns>Returns a JSON fragment of type nvarchar(max). The collation of the returned value is the same as the collation of the input expression.</returns>
        [FuncStyleConverter]
        public static string Json_Query(object expression) => throw new InvalitContextException(nameof(Json_Query));

        /// <summary>
        /// JSON_QUERY
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/json-query-transact-sql
        /// </summary>
        /// <param name="expression">An expression. Typically the name of a variable or a column that contains JSON text.</param>
        /// <param name="path">A JSON path that specifies the property to extract.</param>
        /// <returns>Returns a JSON fragment of type nvarchar(max). The collation of the returned value is the same as the collation of the input expression.</returns>
        [MethodFormatConverter(Format = "JSON_QUERY([0], [$1])")]
        public static string Json_Query(object expression, string path) => throw new InvalitContextException(nameof(Json_Query));

        /// <summary>
        /// JSON_MODIFY
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/json-modify-transact-sql
        /// </summary>
        /// <param name="expression">An expression. Typically the name of a variable or a column that contains JSON text.</param>
        /// <param name="path">A JSON path expression that specifies the property to update.</param>
        /// <param name="newValue">The new value for the property specified by path.</param>
        /// <returns>Returns the updated value of expression as properly formatted JSON text.</returns>
        [MethodFormatConverter(Format = "JSON_MODIFY([0], [$1], [2])")]
        public static string Json_Modify(object expression, string path, string newValue) => throw new InvalitContextException(nameof(Json_Value));
    }
}
