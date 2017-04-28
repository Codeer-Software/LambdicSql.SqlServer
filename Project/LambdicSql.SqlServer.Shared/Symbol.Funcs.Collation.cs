using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        //----------------@@@---------------
        /// <summary>
        /// COLLATIONPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/collation-functions-collationproperty-transact-sql
        /// </summary>
        /// <param name="collation_name">collation_name.</param>
        /// <param name="property">property.</param>
        /// <returns>Collation property.</returns>
        [FuncStyleConverter]
        public static object CollationProperty(string collation_name , string property ) => throw new InvalitContextException(nameof(CollationProperty));

        /// <summary>
        /// TERTIARY_WEIGHTS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/collation-functions-tertiary-weights-transact-sql
        /// </summary>
        /// <param name="non_Unicode_character_string_expression">non_Unicode_character_string_expression.</param>
        /// <returns>Tertiary weights.</returns>
        [FuncStyleConverter]
        public static string Tertiary_Weights(string non_Unicode_character_string_expression) => throw new InvalitContextException(nameof(Tertiary_Weights));
    }
}
