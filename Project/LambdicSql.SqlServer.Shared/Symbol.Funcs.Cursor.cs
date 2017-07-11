using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// @@CURSOR_ROWS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/cursor-rows-transact-sql
        /// </summary>
        /// <returns>cursor rows count.</returns>
        [ClauseStyleConverter(Name = "@@CURSOR_ROWS")]
        public static int AtAtCursor_Rows() => throw new InvalitContextException(nameof(AtAtCursor_Rows));

        /// <summary>
        /// @@FETCH_STATUS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/fetch-status-transact-sql
        /// </summary>
        /// <returns>the status of the last cursor FETCH statement issued against any cursor currently opened by the connection.</returns>
        [ClauseStyleConverter(Name = "@@FETCH_STATUS")]
        public static int AtAtFetch_Status() => throw new InvalitContextException(nameof(AtAtCursor_Rows));

        /// <summary>
        /// CURSOR_STATUS.
        /// </summary>
        /// <param name="type">local or global or variable.</param>
        /// <param name="value">cursor_name or cursor_variable.</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static ushort Cursor_Status(string type, string value) => throw new InvalitContextException(nameof(IsJson));
    }
}
