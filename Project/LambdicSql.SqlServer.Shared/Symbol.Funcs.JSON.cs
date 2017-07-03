using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        [FuncStyleConverter]
        public static int? IsJson(object target) { throw new InvalitContextException(nameof(IsJson)); }

        [MethodFormatConverter(Format = "JSON_VALUE([0],[$1])")]
        public static string Json_Value(object expression, string path) { throw new InvalitContextException(nameof(Json_Value)); }

        [FuncStyleConverter]
        public static string Json_Query(object expression) { throw new InvalitContextException(nameof(Json_Query)); }

        [MethodFormatConverter(Format = "JSON_QUERY([0],[$1])")]
        public static string Json_Query(object expression, string path) { throw new InvalitContextException(nameof(Json_Query)); }

        [MethodFormatConverter(Format = "JSON_MODIFY([0],[$1],[2])")]
        public static string Json_Modify(object expression, string path, string newValue) { throw new InvalitContextException(nameof(Json_Value)); }
    }
}
