using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System.Linq.Expressions;

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
        /// <param name="jsonExpression">jsonExpression.</param>
        /// <returns>json value.</returns>
        [FuncStyleConverter]
        public static Clause<Non> OpenJson(string jsonExpression) => throw new InvalitContextException(nameof(OpenJson));

        /// <summary>
        /// OPENJSON
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openjson-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="jsonExpression">jsonExpression.</param>
        /// <returns>json value.</returns>
        [FuncStyleConverter]
        public static Clause<T> OpenJson<T>(this Clause<T> before, string jsonExpression) => throw new InvalitContextException(nameof(OpenJson));

        /// <summary>
        /// OPENJSON
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openjson-transact-sql
        /// </summary>
        /// <param name="jsonExpression">jsonExpression.</param>
        /// <param name="path">path.</param>
        /// <returns>json value.</returns>
        [FuncStyleConverter]
        public static Clause<Non> OpenJson(string jsonExpression, string path) => throw new InvalitContextException(nameof(OpenJson));

        /// <summary>
        /// OPENJSON
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openjson-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="jsonExpression">jsonExpression.</param>
        /// <param name="path">path.</param>
        /// <returns>json value.</returns>
        [FuncStyleConverter]
        public static Clause<T> OpenJson<T>(this Clause<T> before, string jsonExpression, string path) => throw new InvalitContextException(nameof(OpenJson));

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
        /// <param name="idoc">idoc.</param>
        /// <param name="path">path.</param>
        /// <returns>xml value.</returns>
        [FuncStyleConverter]
        public static Clause<Non> OpenXml(string idoc, string path) => throw new InvalitContextException(nameof(OpenXml));

        /// <summary>
        /// OPENXML
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openxml-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="idoc">idoc.</param>
        /// <param name="path">path.</param>
        /// <returns>xml value.</returns>
        [FuncStyleConverter]
        public static Clause<T> OpenXml<T>(this Clause<T> before, string idoc, string path) => throw new InvalitContextException(nameof(OpenXml));

        /// <summary>
        /// OPENXML
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openxml-transact-sql
        /// </summary>
        /// <param name="idoc">idoc.</param>
        /// <param name="path">path.</param>
        /// <param name="flags">flags.</param>
        /// <returns>xml value.</returns>
        [FuncStyleConverter]
        public static Clause<Non> OpenXml(string idoc, string path, byte flags) => throw new InvalitContextException(nameof(OpenXml));

        /// <summary>
        /// OPENXML
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/openxml-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="idoc">idoc.</param>
        /// <param name="path">path.</param>
        /// <param name="flags">flags.</param>
        /// <returns>xml value.</returns>
        [FuncStyleConverter]
        public static Clause<T> OpenXml<T>(this Clause<T> before, string idoc, string path, byte flags) => throw new InvalitContextException(nameof(OpenXml));

        /// <summary>
        /// WITH clause.
        /// </summary>
        /// <param name="defines">defines.</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static Clause<Non> With(params IOpenWithElement[] defines) { throw new InvalitContextException(nameof(With)); }

        /// <summary>
        /// WITH clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="defines">defines.</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static Clause<T> With<T>(this Clause<T> before, params IOpenWithElement[] defines) { throw new InvalitContextException(nameof(With)); }
    }

    /// <summary>
    /// Open function with element.
    /// </summary>
    public interface IOpenWithElement { }

    /// <summary>
    /// Open function with element.
    /// </summary>
    public class OpenWithElement : IOpenWithElement
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="column">Column.</param>
        /// <param name="type">Type.</param>
        /// <param name="path">Path.</param>
        [NewFormatConverter(Format = "[0] [1] [2]")]
        public OpenWithElement(object column, DataTypeBase type, string path) { throw new InvalitContextException("new " + nameof(OpenWithElement)); }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="column">Column.</param>
        /// <param name="type">Type.</param>
        [NewFormatConverter(Format = "[0] [1]")]
        public OpenWithElement(object column, DataTypeBase type) { throw new InvalitContextException("new " + nameof(OpenWithElement)); }
    }

    /// <summary>
    /// Open function with element.
    /// column type as json.
    /// </summary>
    public class OpenWithElementTypeAsJson : IOpenWithElement
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="column">Column.</param>
        /// <param name="type">Type.</param>
        [OpenWithElementTypeJson]
        public OpenWithElementTypeAsJson(object column, DataTypeBase type) { throw new InvalitContextException("new " + nameof(OpenWithElementTypeAsJson)); }
    }

    /// <summary>
    /// SQL symbol converter attribute for OPEN WITH.
    /// </summary>
    public class OpenWithElementTypeJsonAttribute : NewConverterAttribute
    {
        /// <summary>
        /// Convert expression to code.
        /// </summary>
        /// <param name="expression">Expression.</param>
        /// <param name="converter">Expression converter.</param>
        /// <returns>Parts.</returns>
        public override ICode Convert(NewExpression expression, ExpressionConverter converter)
        {
            var arg0 = new HCode(new SingleTextCode("["), converter.ConvertToCode(expression.Arguments[0]), new SingleTextCode("]")) { Separator = string.Empty };
            return new HCode(arg0, converter.ConvertToCode(expression.Arguments[1]), new SingleTextCode("AS JSON")) { Separator = " " };
        }
    }
}
