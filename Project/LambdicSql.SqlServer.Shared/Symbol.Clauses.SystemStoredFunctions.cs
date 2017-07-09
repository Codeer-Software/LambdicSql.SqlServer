using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.Specialized.SymbolConverters;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Symbol.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// Use[using static LambdicSql.SqlServer.Symbol;], you can use to write natural SQL.
    /// </summary>
    public static partial class Symbol
    {
        /// <summary>
        /// sys
        /// </summary>
        public static SysSymbols Sys => throw new InvalitContextException(nameof(Sys));
        //https://msdn.microsoft.com/en-us/library/ff848780.aspx
        /*
         * 
        Always On Availability Groups Functions
        Change Data Capture Functions
        Change Tracking Functions
        Data Collector Functions
        Filestream and FileTable Functions
        Managed Backup Functions
        sys.fn_get_sql
        sys.fn_MSxe_read_event_stream
        sys.fn_stmt_sql_handle_from_sql_stmt
        sys.fn_validate_plan_guide
        sys.fn_xe_file_target_read_file
        sys.fn_db_backup_file_snapshots
        Full-Text Search and Semantic Search Functions
        System Metadata Functions
        System Security Functions
        System Trace Functions*/
    }
}
