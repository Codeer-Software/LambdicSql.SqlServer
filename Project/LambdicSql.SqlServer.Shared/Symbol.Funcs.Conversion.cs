using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /*
        
        CONVERT
        PARSE
        TRY_CAST
        TRY_CONVERT
        TRY_PARSE*/

        /// <summary>
        /// CAST function.
        /// </summary>
        /// <typeparam name="TDst">Type of destination.</typeparam>
        /// <param name="target"></param>
        /// <param name="destinationType">Type of destination.</param>
        /// <returns>Converted data.</returns>
        [MethodFormatConverter(Format = "CAST(|[0] AS [1])")]
        public static TDst Cast<TDst>(object target, DataTypeElement destinationType) { throw new InvalitContextException(nameof(Cast)); }
    }
}
