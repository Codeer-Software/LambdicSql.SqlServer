using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// DENSE_RANK function.
        /// </summary>
        /// <returns>Ranked value.</returns>
        [FuncStyleConverter]
        public static int Dense_Rank() { throw new InvalitContextException(nameof(Dense_Rank)); }

        /// <summary>
        /// NTILE function.
        /// </summary>
        /// <param name="groupCount">The number of ranking groups.</param>
        /// <returns>For each row, NTILE returns the number of the group to which the row belongs.</returns>
        [FuncStyleConverter]
        public static int Ntile(object groupCount) { throw new InvalitContextException(nameof(Ntile)); }


        /// <summary>
        /// RANK function.
        /// </summary>
        /// <returns>Ranked value.</returns>
        [FuncStyleConverter]
        public static int Rank() { throw new InvalitContextException(nameof(Rank)); }

        /// <summary>
        /// ROW_NUMBER function.
        /// </summary>
        /// <returns>Row number.</returns>
        [FuncStyleConverter]
        public static int Row_Number() { throw new InvalitContextException(nameof(Row_Number)); }
    }
}
