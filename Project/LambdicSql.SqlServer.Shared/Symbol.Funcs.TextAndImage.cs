using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// TEXTPTR.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/text-and-image-functions-textptr-transact-sql
        /// </summary>
        /// <param name="column">column.</param>
        /// <returns>varbinary.</returns>
        [FuncStyleConverter]
        public static byte[] TextPtr(object column) => throw new InvalitContextException(nameof(TextPtr));

        /// <summary>
        /// TEXTVALID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/text-and-image-functions-textvalid-transact-sql
        /// </summary>
        /// <param name="column">column.</param>
        /// <param name="text_ptr">text_ptr.</param>
        /// <returns>Returns 1 if the pointer is valid and 0 if the pointer is not valid. </returns>
        [FuncStyleConverter]
        public static int TextValid(string column, byte[] text_ptr) => throw new InvalitContextException(nameof(TextPtr));
    }
}
