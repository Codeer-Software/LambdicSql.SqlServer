using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// OPENDATASOURCE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/opendatasource-transact-sql
        /// </summary>
        /// <typeparam name="T">table type.</typeparam>
        /// <param name="provider">provider.</param>
        /// <param name="init_string">init_string.</param>
        /// <param name="table">table.</param>
        /// <returns>table.</returns>
        [MethodFormatConverter(Format = "OPENDATASOURCE([$0], [$1]).[$2]")]
        public static T OpenDataSource<T>(string provider, string init_string, string table) => throw new InvalitContextException(nameof(OpenDataSource));

        /// <summary>
        /// OPENJSON
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openjson-transact-sql
        /// </summary>
        /// <typeparam name="T">json value type.</typeparam>
        /// <param name="jsonExpression">jsonExpression.</param>
        /// <returns>json value.</returns>
        [FuncStyleConverter]
        public static T OpenJson<T>(string jsonExpression) => throw new InvalitContextException(nameof(OpenJson));

        /// <summary>
        /// OPENJSON
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openjson-transact-sql
        /// </summary>
        /// <typeparam name="T">json value type.</typeparam>
        /// <param name="jsonExpression">jsonExpression.</param>
        /// <param name="path">path.</param>
        /// <returns>json value.</returns>
        [FuncStyleConverter]
        public static T OpenJson<T>(string jsonExpression, string path) => throw new InvalitContextException(nameof(OpenJson));

        /// <summary>
        /// OPENQUERY
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openquery-transact-sql
        /// </summary>
        /// <typeparam name="T">query result type.</typeparam>
        /// <param name="linkServer">link server.</param>
        /// <param name="query">query.</param>
        /// <returns>query result.</returns>
        [MethodFormatConverter(Format = "OPENQUERY([$0], '[$1]')")]
        public static T OpenQuery<T>(object linkServer, Sql<T> query) => throw new InvalitContextException(nameof(OpenQuery));

        /// <summary>
        /// OPENROWSET.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openrowset-transact-sql
        /// </summary>
        /// <typeparam name="T">table type.</typeparam>
        /// <param name="provider">provider.</param>
        /// <param name="init_string">init_string.</param>
        /// <param name="query">query.</param>
        /// <returns>query result.</returns>
        [MethodFormatConverter(Format = "OPENROWSET([$0], [$1], '[$2]')")]
        public static T OpernRowset<T>(string provider, string init_string, Sql<T> query) => throw new InvalitContextException(nameof(OpernRowset));

        /// <summary>
        /// OPENXML
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openxml-transact-sql
        /// </summary>
        /// <typeparam name="T">xml value type.</typeparam>
        /// <param name="idoc">idoc.</param>
        /// <param name="path">path.</param>
        /// <returns>xml value.</returns>
        [FuncStyleConverter]
        public static T OpenXml<T>(string idoc, string path) => throw new InvalitContextException(nameof(OpenXml));

        /// <summary>
        /// OPENXML
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openxml-transact-sql
        /// </summary>
        /// <typeparam name="T">xml value type.</typeparam>
        /// <param name="idoc">idoc.</param>
        /// <param name="path">path.</param>
        /// <param name="flags">flags.</param>
        /// <returns>xml value.</returns>
        [FuncStyleConverter]
        public static T OpenXml<T>(string idoc, string path, byte flags) => throw new InvalitContextException(nameof(OpenXml));

        //TODO WITH
    }
}
