using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// CHOOSE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/logical-functions-choose-transact-sql
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="vals">vals.</param>
        /// <returns>choose value.</returns>
        [FuncStyleConverter]
        public static object Choose(int index, params string[] vals) => throw new InvalitContextException(nameof(Choose));

        /// <summary>
        /// IIF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/logical-functions-iif-transact-sql
        /// </summary>
        /// <param name="bool_expression">bool_expression.</param>
        /// <param name="true_Value">true_Value.</param>
        /// <param name="false_Value">false_Value.</param>
        /// <returns>choose value.</returns>
        [FuncStyleConverter]
        public static object Iif(bool expression, object true_Value, object false_Value) => throw new InvalitContextException(nameof(Iif));
    }
}
