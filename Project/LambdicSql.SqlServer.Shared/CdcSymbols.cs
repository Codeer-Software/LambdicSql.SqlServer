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
    }
}
