using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// Change data capture records insert, update, and delete activity applied to SQL Server tables, supplying the details of the changes in an easily consumed relational format
    /// </summary>
    public class CdcSymbols
    {
        /// <summary>
        /// sys.fn_cdc_get_all_changes_capture_instance
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/cdc-fn-cdc-get-all-changes-capture-instance-transact-sql
        /// </summary>
        /// <param name="capture_instance_name">capture instance name</param>
        /// <param name="from_lsn">The LSN value that represents the low endpoint of the LSN range to include in the result set. from_lsn is binary(10).</param>
        /// <param name="to_lsn">The LSN value that represents the high endpoint of the LSN range to include in the result set. to_lsn is binary(10).</param>
        /// <param name="row_filter_option">An option that governs the content of the metadata columns as well as the rows returned in the result set</param>
        /// <returns>Type of destination.</returns>
        [MethodFormatConverter(Format = "cdc.fn_cdc_get_all_changes_[0]([1], [2], [3])")]
        public object fn_cdc_get_all_changes_capture_instance(string capture_instance_name, byte[] from_lsn, byte[] to_lsn, string row_filter_option) => throw new InvalitContextException(nameof(fn_cdc_get_all_changes_capture_instance));

        /// <summary>
        /// sys.fn_cdc_get_net_changes_capture_instance
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/cdc-fn-cdc-get-net-changes-capture-instance-transact-sql
        /// </summary>
        /// <param name="capture_instance_name">capture instance name</param>
        /// <param name="from_lsn">The LSN that represents the low endpoint of the LSN range to include in the result set. from_lsn is binary(10).</param>
        /// <param name="to_lsn">The LSN that represents the high endpoint of the LSN range to include in the result set. to_lsn is binary(10).</param>
        /// <param name="row_filter_option">An option that governs the content of the metadata columns as well as the rows returned in the result set. Can be one of the following options</param>
        /// <returns>Type of destination.</returns>
        [MethodFormatConverter(Format = "cdc.fn_cdc_get_net_changes_[0]([1], [2], [3])")]
        public object fn_cdc_get_net_changes_capture_instance(string capture_instance_name, byte[] from_lsn, byte[] to_lsn, string row_filter_option) => throw new InvalitContextException(nameof(fn_cdc_get_net_changes_capture_instance));

        //@@@ can't use.
        /*
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-capture-instance-ct-transact-sql
        /// cdc.captured_columns
        /// </summary>
        [MemberTableConverter(Name = "cdc.captured_columns")]
        public Table_cdc_<capture_instance>_CT <capture_instance>_CT => throw new InvalitContextException(nameof(<capture_instance>_CT));
        */

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-captured-columns-transact-sql
        /// cdc.captured_columns
        /// </summary>
        [MemberTableConverter(Name = "cdc.captured_columns")]
        public Table_cdc_captured_columns Captured_columns => throw new InvalitContextException(nameof(Captured_columns));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-change-tables-transact-sql
        /// cdc.change_tables
        /// </summary>
        [MemberTableConverter(Name = "cdc.change_tables")]
        public Table_cdc_change_tables Change_tables => throw new InvalitContextException(nameof(Change_tables));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-ddl-history-transact-sql
        /// cdc.ddl_history
        /// </summary>
        [MemberTableConverter(Name = "cdc.ddl_history")]
        public Table_cdc_ddl_history Ddl_history => throw new InvalitContextException(nameof(Ddl_history));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-lsn-time-mapping-transact-sql
        /// cdc.lsn_time_mapping
        /// </summary>
        [MemberTableConverter(Name = "cdc.lsn_time_mapping")]
        public Table_cdc_lsn_time_mapping Lsn_time_mapping => throw new InvalitContextException(nameof(Lsn_time_mapping));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-index-columns-transact-sql
        /// cdc.index_columns
        /// </summary>
        [MemberTableConverter(Name = "cdc.index_columns")]
        public Table_cdc_index_columns Index_columns => throw new InvalitContextException(nameof(Index_columns));
    }
}
