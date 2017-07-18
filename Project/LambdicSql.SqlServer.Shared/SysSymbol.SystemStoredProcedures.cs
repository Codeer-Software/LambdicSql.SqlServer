using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Server provides the following groups of system functions.
    /// </summary>
    public partial class SysSymbol
    {
        //--------------------------
        //Temporal Table
        //--------------------------
        /// <summary>
        /// sys.sp_cleanup_temporal_history  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-trace-getfilterinfo-transact-sql
        /// </summary>
        /// <param name="schema_name">The name of the schema which current temporal table belongs to.</param>
        /// <param name="table_name">The name of the temporal table for which retention cleanup is invoked.</param>
        /// <param name="row_count_var">The output parameter that returns number of deleted rows.</param>
        [FuncStyleConverter(Name = "sys.sp_cleanup_temporal_history")]
        public void sp_cleanup_temporal_history(string schema_name, string table_name, int row_count_var) => throw new InvalitContextException(nameof(sp_cleanup_temporal_history));

        //--------------------------
        //Change Data Capture Stored Procedures
        //--------------------------
        /// <summary>
        /// sys.sp_cdc_add_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-add-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_add_job")]
        public bool sp_cdc_add_job(string job_type) => throw new InvalitContextException(nameof(sp_cdc_add_job));

        /// <summary>
        /// sys.sp_cdc_add_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-add-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <param name="start_job">Flag indicating whether the job should be started immediately after it is added.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_add_job")]
        public bool sp_cdc_add_job(string job_type, int? start_job) => throw new InvalitContextException(nameof(sp_cdc_add_job));

        /// <summary>
        /// sys.sp_cdc_add_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-add-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <param name="start_job">Flag indicating whether the job should be started immediately after it is added.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_add_job")]
        public bool sp_cdc_add_job(string job_type, int? start_job, int maxtrans) => throw new InvalitContextException(nameof(sp_cdc_add_job));

        /// <summary>
        /// sys.sp_cdc_add_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-add-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <param name="start_job">Flag indicating whether the job should be started immediately after it is added.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_add_job")]
        public bool sp_cdc_add_job(string job_type, int? start_job, int maxtrans, int maxscans) => throw new InvalitContextException(nameof(sp_cdc_add_job));

        /// <summary>
        /// sys.sp_cdc_add_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-add-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <param name="start_job">Flag indicating whether the job should be started immediately after it is added.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the capture job is to run continuously (1), or run only once (0).</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_add_job")]
        public bool sp_cdc_add_job(string job_type, int? start_job, int maxtrans, int maxscans, int continuous) => throw new InvalitContextException(nameof(sp_cdc_add_job));

        /// <summary>
        /// sys.sp_cdc_add_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-add-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <param name="start_job">Flag indicating whether the job should be started immediately after it is added.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the capture job is to run continuously (1), or run only once (0).</param>
        /// <param name="pollinginterval">Number of seconds between log scan cycles.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_add_job")]
        public bool sp_cdc_add_job(string job_type, int? start_job, int maxtrans, int maxscans, int continuous, long pollinginterval) => throw new InvalitContextException(nameof(sp_cdc_add_job));

        /// <summary>
        /// sys.sp_cdc_add_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-add-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <param name="start_job">Flag indicating whether the job should be started immediately after it is added.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the capture job is to run continuously (1), or run only once (0).</param>
        /// <param name="pollinginterval">Number of seconds between log scan cycles.</param>
        /// <param name="retention">Number of minutes that change data rows are to be retained in change tables.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_add_job")]
        public bool sp_cdc_add_job(string job_type, int? start_job, int maxtrans, int maxscans, int continuous, long pollinginterval, long retention) => throw new InvalitContextException(nameof(sp_cdc_add_job));

        /// <summary>
        /// sys.sp_cdc_add_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-add-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <param name="start_job">Flag indicating whether the job should be started immediately after it is added.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the capture job is to run continuously (1), or run only once (0).</param>
        /// <param name="pollinginterval">Number of seconds between log scan cycles.</param>
        /// <param name="retention">Number of minutes that change data rows are to be retained in change tables.</param>
        /// <param name="threshold">Maximum number of delete entries that can be deleted by using a single statement on cleanup.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_add_job")]
        public bool sp_cdc_add_job(string job_type, int? start_job, int maxtrans, int maxscans, int continuous, long pollinginterval, long retention, long threshold) => throw new InvalitContextException(nameof(sp_cdc_add_job));

        /// <summary>
        /// sys.sp_cdc_change_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-change-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to modify.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_change_job")]
        public bool sp_cdc_change_job(string job_type) => throw new InvalitContextException(nameof(sp_cdc_change_job));

        /// <summary>
        /// sys.sp_cdc_change_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-change-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to modify.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_change_job")]
        public bool sp_cdc_change_job(string job_type, int? maxtrans) => throw new InvalitContextException(nameof(sp_cdc_change_job));

        /// <summary>
        /// sys.sp_cdc_change_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-change-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to modify.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_change_job")]
        public bool sp_cdc_change_job(string job_type, int? maxtrans, int? maxscans) => throw new InvalitContextException(nameof(sp_cdc_change_job));

        /// <summary>
        /// sys.sp_cdc_change_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-change-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to modify.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the capture job is to run continuously (1), or run only once (0).</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_change_job")]
        public bool sp_cdc_change_job(string job_type, int? maxtrans, int? maxscans, int? continuous) => throw new InvalitContextException(nameof(sp_cdc_change_job));

        /// <summary>
        /// sys.sp_cdc_change_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-change-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to modify.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the capture job is to run continuously (1), or run only once (0).</param>
        /// <param name="pollinginterval">Number of seconds between log scan cycles.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_change_job")]
        public bool sp_cdc_change_job(string job_type, int? maxtrans, int? maxscans, int? continuous, long? pollinginterval) => throw new InvalitContextException(nameof(sp_cdc_change_job));

        /// <summary>
        /// sys.sp_cdc_change_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-change-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to modify.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the capture job is to run continuously (1), or run only once (0).</param>
        /// <param name="pollinginterval">Number of seconds between log scan cycles.</param>
        /// <param name="retention">Number of minutes that change rows are to be retained in change tables.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_change_job")]
        public bool sp_cdc_change_job(string job_type, int? maxtrans, int? maxscans, int? continuous, long? pollinginterval, long? retention) => throw new InvalitContextException(nameof(sp_cdc_change_job));

        /// <summary>
        /// sys.sp_cdc_change_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-change-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to modify.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the capture job is to run continuously (1), or run only once (0).</param>
        /// <param name="pollinginterval">Number of seconds between log scan cycles.</param>
        /// <param name="retention">Number of minutes that change rows are to be retained in change tables.</param>
        /// <param name="threshold">Maximum number of delete entries that can be deleted using a single statement on cleanup.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_change_job")]
        public bool sp_cdc_change_job(string job_type, int? maxtrans, int? maxscans, int? continuous, long? pollinginterval, long? retention, long? threshold) => throw new InvalitContextException(nameof(sp_cdc_change_job));

        /// <summary>
        /// sys.sp_cdc_cleanup_change_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-cleanup-change-table-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the name of the capture instance associated with the change table.</param>
        /// <param name="low_water_mark">Is a log sequence number (LSN) that is to be used as the new low watermark for the capture instance.</param>
        /// <param name="threshold">Is the maximum number of delete entries that can be deleted by using a single statement on cleanup.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_cleanup_change_table")]
        public bool sp_cdc_cleanup_change_table(string capture_instance, byte[] low_water_mark, long threshold) => throw new InvalitContextException(nameof(sp_cdc_cleanup_change_table));

        /// <summary>
        /// sys.sp_cdc_disable_db  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-disable-db-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_disable_db")]
        public bool sp_cdc_disable_db() => throw new InvalitContextException(nameof(sp_cdc_disable_db));

        /// <summary>
        /// sys.sp_cdc_disable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-disable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table is contained.</param>
        /// <param name="source_name">Is the name of the source table from which change data capture is to be disabled.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_disable_table")]
        public bool sp_cdc_disable_table(string source_schema, string source_name) => throw new InvalitContextException(nameof(sp_cdc_disable_table));

        /// <summary>
        /// sys.sp_cdc_disable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-disable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table is contained.</param>
        /// <param name="source_name">Is the name of the source table from which change data capture is to be disabled.</param>
        /// <param name="capture_instance">Is the name of the capture instance to disable for the specified source table.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_disable_table")]
        public bool sp_cdc_disable_table(string source_schema, string source_name, string capture_instance) => throw new InvalitContextException(nameof(sp_cdc_disable_table));

        /// <summary>
        /// sys.sp_cdc_drop_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-drop-job-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_drop_job")]
        public bool sp_cdc_drop_job() => throw new InvalitContextException(nameof(sp_cdc_drop_job));

        /// <summary>
        /// sys.sp_cdc_drop_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-drop-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to remove.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_drop_job")]
        public bool sp_cdc_drop_job(string job_type) => throw new InvalitContextException(nameof(sp_cdc_drop_job));

        /// <summary>
        /// sys.sp_cdc_enable_db  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-enable-db-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_enable_db")]
        public bool sp_cdc_enable_db() => throw new InvalitContextException(nameof(sp_cdc_enable_db));

        /// <summary>
        /// sys.sp_cdc_enable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-enable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <param name="source_name">Is the name of the source table on which to enable change data capture.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_enable_table")]
        public bool sp_cdc_enable_table(string source_schema, string source_name) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

        /// <summary>
        /// sys.sp_cdc_enable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-enable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <param name="source_name">Is the name of the source table on which to enable change data capture.</param>
        /// <param name="capture_instance">Is the name of the capture instance used to name instance-specific change data capture objects.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_enable_table")]
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

        /// <summary>
        /// sys.sp_cdc_enable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-enable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <param name="source_name">Is the name of the source table on which to enable change data capture.</param>
        /// <param name="capture_instance">Is the name of the capture instance used to name instance-specific change data capture objects.</param>
        /// <param name="supports_net_changes">Indicates whether support for querying for net changes is to be enabled for this capture instance.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_enable_table")]
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, int? supports_net_changes) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

        /// <summary>
        /// sys.sp_cdc_enable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-enable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <param name="source_name">Is the name of the source table on which to enable change data capture.</param>
        /// <param name="capture_instance">Is the name of the capture instance used to name instance-specific change data capture objects.</param>
        /// <param name="supports_net_changes">Indicates whether support for querying for net changes is to be enabled for this capture instance.</param>
        /// <param name="role_name">Is the name of the database role used to gate access to change data.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_enable_table")]
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, int? supports_net_changes, string role_name) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

        /// <summary>
        /// sys.sp_cdc_enable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-enable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <param name="source_name">Is the name of the source table on which to enable change data capture.</param>
        /// <param name="capture_instance">Is the name of the capture instance used to name instance-specific change data capture objects.</param>
        /// <param name="supports_net_changes">Indicates whether support for querying for net changes is to be enabled for this capture instance.</param>
        /// <param name="role_name">Is the name of the database role used to gate access to change data.</param>
        /// <param name="index_name">The name of a unique index to use to uniquely identify rows in the source table.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_enable_table")]
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, int? supports_net_changes, string role_name, string index_name) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

        /// <summary>
        /// sys.sp_cdc_enable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-enable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <param name="source_name">Is the name of the source table on which to enable change data capture.</param>
        /// <param name="capture_instance">Is the name of the capture instance used to name instance-specific change data capture objects.</param>
        /// <param name="supports_net_changes">Indicates whether support for querying for net changes is to be enabled for this capture instance.</param>
        /// <param name="role_name">Is the name of the database role used to gate access to change data.</param>
        /// <param name="index_name">The name of a unique index to use to uniquely identify rows in the source table.</param>
        /// <param name="captured_column_list">Identifies the source table columns that are to be included in the change table.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_enable_table")]
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, int? supports_net_changes, string role_name, string index_name, string captured_column_list) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

        /// <summary>
        /// sys.sp_cdc_enable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-enable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <param name="source_name">Is the name of the source table on which to enable change data capture.</param>
        /// <param name="capture_instance">Is the name of the capture instance used to name instance-specific change data capture objects.</param>
        /// <param name="supports_net_changes">Indicates whether support for querying for net changes is to be enabled for this capture instance.</param>
        /// <param name="role_name">Is the name of the database role used to gate access to change data.</param>
        /// <param name="index_name">The name of a unique index to use to uniquely identify rows in the source table.</param>
        /// <param name="captured_column_list">Identifies the source table columns that are to be included in the change table.</param>
        /// <param name="filegroup_name">Is the filegroup to be used for the change table created for the capture instance.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_enable_table")]
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, int? supports_net_changes, string role_name, string index_name, string captured_column_list, string filegroup_name) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

        /// <summary>
        /// sys.sp_cdc_enable_table  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-enable-table-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <param name="source_name">Is the name of the source table on which to enable change data capture.</param>
        /// <param name="capture_instance">Is the name of the capture instance used to name instance-specific change data capture objects.</param>
        /// <param name="supports_net_changes">Indicates whether support for querying for net changes is to be enabled for this capture instance.</param>
        /// <param name="role_name">Is the name of the database role used to gate access to change data.</param>
        /// <param name="index_name">The name of a unique index to use to uniquely identify rows in the source table.</param>
        /// <param name="captured_column_list">Identifies the source table columns that are to be included in the change table.</param>
        /// <param name="filegroup_name">Is the filegroup to be used for the change table created for the capture instance.</param>
        /// <param name="allow_partition_switch">Indicates whether the SWITCH PARTITION command of ALTER TABLE can be executed against a table that is enabled for change data capture.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_enable_table")]
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, int? supports_net_changes, string role_name, string index_name, string captured_column_list, string filegroup_name, bool allow_partition_switch) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

        /// <summary>
        /// sys.sp_cdc_generate_wrapper_function  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-generate-wrapper-function-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the capture instance that scripts are to be generated for.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_generate_wrapper_function")]
        public bool sp_cdc_generate_wrapper_function(string capture_instance) => throw new InvalitContextException(nameof(sp_cdc_generate_wrapper_function));

        /// <summary>
        /// sys.sp_cdc_generate_wrapper_function  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-generate-wrapper-function-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the capture instance that scripts are to be generated for.</param>
        /// <param name="closed_high_end_point">Is the flag bit that indicates whether changes that have a commit time equal to the high endpoint are to be included within the extraction interval by the generated procedure.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_generate_wrapper_function")]
        public bool sp_cdc_generate_wrapper_function(string capture_instance, int? closed_high_end_point) => throw new InvalitContextException(nameof(sp_cdc_generate_wrapper_function));

        /// <summary>
        /// sys.sp_cdc_generate_wrapper_function  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-generate-wrapper-function-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the capture instance that scripts are to be generated for.</param>
        /// <param name="closed_high_end_point">Is the flag bit that indicates whether changes that have a commit time equal to the high endpoint are to be included within the extraction interval by the generated procedure.</param>
        /// <param name="column_list">Is a list of captured columns to be included in the result set that is returned by the wrapper function.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_generate_wrapper_function")]
        public bool sp_cdc_generate_wrapper_function(string capture_instance, int? closed_high_end_point, string column_list) => throw new InvalitContextException(nameof(sp_cdc_generate_wrapper_function));

        /// <summary>
        /// sys.sp_cdc_generate_wrapper_function  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-generate-wrapper-function-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the capture instance that scripts are to be generated for.</param>
        /// <param name="closed_high_end_point">Is the flag bit that indicates whether changes that have a commit time equal to the high endpoint are to be included within the extraction interval by the generated procedure.</param>
        /// <param name="column_list">Is a list of captured columns to be included in the result set that is returned by the wrapper function.</param>
        /// <param name="update_flag_list">Is a list of included columns for which an update flag is included in the result set that is returned by the wrapper function.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_generate_wrapper_function")]
        public bool sp_cdc_generate_wrapper_function(string capture_instance, int? closed_high_end_point, string column_list, string update_flag_list) => throw new InvalitContextException(nameof(sp_cdc_generate_wrapper_function));

        /// <summary>
        /// sys.sp_cdc_get_captured_columns  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-get-captured-columns-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the name of the capture instance associated with a source table.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_get_captured_columns")]
        public bool sp_cdc_get_captured_columns(string capture_instance) => throw new InvalitContextException(nameof(sp_cdc_get_captured_columns));

        /// <summary>
        /// sys.sp_cdc_get_ddl_history  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-get-ddl-history-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the name of the capture instance associated with a source table.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_get_ddl_history")]
        public bool sp_cdc_get_ddl_history(string capture_instance) => throw new InvalitContextException(nameof(sp_cdc_get_ddl_history));

        /// <summary>
        /// sys.sp_cdc_help_change_data_capture  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-help-change-data-capture-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_help_change_data_capture")]
        public bool sp_cdc_help_change_data_capture() => throw new InvalitContextException(nameof(sp_cdc_help_change_data_capture));

        /// <summary>
        /// sys.sp_cdc_help_change_data_capture  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-help-change-data-capture-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_help_change_data_capture")]
        public bool sp_cdc_help_change_data_capture(string source_schema) => throw new InvalitContextException(nameof(sp_cdc_help_change_data_capture));

        /// <summary>
        /// sys.sp_cdc_help_change_data_capture  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-help-change-data-capture-transact-sql
        /// </summary>
        /// <param name="source_schema">Is the name of the schema in which the source table belongs.</param>
        /// <param name="source_name">Is the name of the source table.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_help_change_data_capture")]
        public bool sp_cdc_help_change_data_capture(string source_schema, string source_name) => throw new InvalitContextException(nameof(sp_cdc_help_change_data_capture));

        /// <summary>
        /// sys.sp_cdc_help_jobs  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-help-jobs-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_help_jobs")]
        public bool sp_cdc_help_jobs() => throw new InvalitContextException(nameof(sp_cdc_help_jobs));

        /// <summary>
        /// sys.sp_cdc_scan  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-scan-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_scan")]
        public bool sp_cdc_scan() => throw new InvalitContextException(nameof(sp_cdc_scan));

        /// <summary>
        /// sys.sp_cdc_scan  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-scan-transact-sql
        /// </summary>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_scan")]
        public bool sp_cdc_scan(int maxtrans) => throw new InvalitContextException(nameof(sp_cdc_scan));

        /// <summary>
        /// sys.sp_cdc_scan  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-scan-transact-sql
        /// </summary>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_scan")]
        public bool sp_cdc_scan(int maxtrans, int maxscans) => throw new InvalitContextException(nameof(sp_cdc_scan));

        /// <summary>
        /// sys.sp_cdc_scan  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-scan-transact-sql
        /// </summary>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the stored procedure should end after executing a single scan cycle (0) or run continuously, pausing for the time specified by polling_interval before reexecuting the scan cycle (1)..</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_scan")]
        public bool sp_cdc_scan(int maxtrans, int maxscans, byte continuous) => throw new InvalitContextException(nameof(sp_cdc_scan));

        /// <summary>
        /// sys.sp_cdc_scan  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-scan-transact-sql
        /// </summary>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <param name="maxscans">Maximum number of scan cycles to execute in order to extract all rows from the log.</param>
        /// <param name="continuous">Indicates whether the stored procedure should end after executing a single scan cycle (0) or run continuously, pausing for the time specified by polling_interval before reexecuting the scan cycle (1)..</param>
        /// <param name="pollinginterval">Number of seconds between log scan cycles.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_scan")]
        public bool sp_cdc_scan(int maxtrans, int maxscans, byte continuous, long pollinginterval) => throw new InvalitContextException(nameof(sp_cdc_scan));

        /// <summary>
        /// sys.sp_cdc_start_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-start-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_start_job")]
        public bool sp_cdc_start_job(string job_type) => throw new InvalitContextException(nameof(sp_cdc_start_job));

        /// <summary>
        /// sys.sp_cdc_stop_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-stop-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_stop_job")]
        public bool sp_cdc_stop_job(string job_type) => throw new InvalitContextException(nameof(sp_cdc_stop_job));
    }
}
