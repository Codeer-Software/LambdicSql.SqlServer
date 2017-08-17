using System;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/extended-events-tables-trace-xe-action-map
    /// </summary>
    public class Table_sys_trace_xe_action_map
    {
        /// <summary>
        /// trace_column_id
        /// </summary>
        public short Trace_column_id { get; set; }

        /// <summary>
        /// package_name
        /// </summary>
        public string Package_name { get; set; }

        /// <summary>
        /// xe_action_name
        /// </summary>
        public string Xe_action_name { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/extended-events-tables-trace-xe-event-map
    /// </summary>
    public class Table_sys_trace_xe_event_map
    {
        /// <summary>
        /// trace_event_id
        /// </summary>
        public short Trace_event_id { get; set; }

        /// <summary>
        /// package_name
        /// </summary>
        public string Package_name { get; set; }

        /// <summary>
        /// xe_event_name
        /// </summary>
        public string Xe_event_name { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/data-tier-application-tables-sysdac-history-internal
    /// </summary>
    public class Table_msdb_dbo_sysdac_history_internal
    {
        /// <summary>
        /// action_id
        /// </summary>
        public int Action_id { get; set; }

        /// <summary>
        /// sequence_id
        /// </summary>
        public int Sequence_id { get; set; }

        /// <summary>
        /// instance_id
        /// </summary>
        public object Instance_id { get; set; }

        /// <summary>
        /// action_type
        /// </summary>
        public byte Action_type { get; set; }

        /// <summary>
        /// action_type_name
        /// </summary>
        public string Action_type_name { get; set; }

        /// <summary>
        /// dac_object_type
        /// </summary>
        public byte Dac_object_type { get; set; }

        /// <summary>
        /// dac_object_type_name
        /// </summary>
        public string Dac_object_type_name { get; set; }

        /// <summary>
        /// action_status
        /// </summary>
        public byte Action_status { get; set; }

        /// <summary>
        /// action_status_name
        /// </summary>
        public string Action_status_name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// dac_object_name_pretran
        /// </summary>
        public string Dac_object_name_pretran { get; set; }

        /// <summary>
        /// dac_object_name_posttran
        /// </summary>
        public string Dac_object_name_posttran { get; set; }

        /// <summary>
        /// sqlscript
        /// </summary>
        public string Sqlscript { get; set; }

        /// <summary>
        /// payload
        /// </summary>
        public byte[] Payload { get; set; }

        /// <summary>
        /// Comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// error_string
        /// </summary>
        public string Error_string { get; set; }

        /// <summary>
        /// created_by
        /// </summary>
        public string Created_by { get; set; }

        /// <summary>
        /// date_created
        /// </summary>
        public DateTime Date_created { get; set; }

        /// <summary>
        /// date_modified
        /// </summary>
        public DateTime Date_modified { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/data-tier-application-tables-sysdac-instances-internal
    /// </summary>
    public class Table_msdb_dbo_sysdac_instances_internal
    {
        /// <summary>
        /// instance_id
        /// </summary>
        public object Instance_id { get; set; }

        /// <summary>
        /// instance_name
        /// </summary>
        public string Instance_name { get; set; }

        /// <summary>
        /// type_name
        /// </summary>
        public string Type_name { get; set; }

        /// <summary>
        /// type_version
        /// </summary>
        public string Type_version { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// type_stream
        /// </summary>
        public byte[] Type_stream { get; set; }

        /// <summary>
        /// date_created
        /// </summary>
        public DateTime Date_created { get; set; }

        /// <summary>
        /// created_by
        /// </summary>
        public string Created_by { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-master-files-transact-sql
    /// </summary>
    public class Table_sys_master_files
    {
        /// <summary>
        /// database_id
        /// </summary>
        public int Database_id { get; set; }

        /// <summary>
        /// file_id
        /// </summary>
        public int File_id { get; set; }

        /// <summary>
        /// file_guid
        /// </summary>
        public object File_guid { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// type_desc
        /// </summary>
        public string Type_desc { get; set; }

        /// <summary>
        /// data_space_id
        /// </summary>
        public int Data_space_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// physical_name
        /// </summary>
        public string Physical_name { get; set; }

        /// <summary>
        /// state
        /// </summary>
        public byte State { get; set; }

        /// <summary>
        /// state_desc
        /// </summary>
        public string State_desc { get; set; }

        /// <summary>
        /// size
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// max_size
        /// </summary>
        public int Max_size { get; set; }

        /// <summary>
        /// growth
        /// </summary>
        public int Growth { get; set; }

        /// <summary>
        /// is_media_read_onlyF
        /// </summary>
        public bool Is_media_read_onlyF { get; set; }

        /// <summary>
        /// is_read_only
        /// </summary>
        public bool Is_read_only { get; set; }

        /// <summary>
        /// is_sparse
        /// </summary>
        public bool Is_sparse { get; set; }

        /// <summary>
        /// is_percent_growth
        /// </summary>
        public bool Is_percent_growth { get; set; }

        /// <summary>
        /// is_name_reserved
        /// </summary>
        public bool Is_name_reserved { get; set; }

        /// <summary>
        /// create_lsn
        /// </summary>
        public decimal Create_lsn { get; set; }

        /// <summary>
        /// drop_lsn
        /// </summary>
        public decimal Drop_lsn { get; set; }

        /// <summary>
        /// read_only_lsn
        /// </summary>
        public decimal Read_only_lsn { get; set; }

        /// <summary>
        /// read_write_lsn
        /// </summary>
        public decimal Read_write_lsn { get; set; }

        /// <summary>
        /// differential_base_lsn
        /// </summary>
        public decimal Differential_base_lsn { get; set; }

        /// <summary>
        /// differential_base_guid
        /// </summary>
        public object Differential_base_guid { get; set; }

        /// <summary>
        /// differential_base_time
        /// </summary>
        public DateTime Differential_base_time { get; set; }

        /// <summary>
        /// redo_start_lsn
        /// </summary>
        public decimal Redo_start_lsn { get; set; }

        /// <summary>
        /// redo_start_fork_guid
        /// </summary>
        public object Redo_start_fork_guid { get; set; }

        /// <summary>
        /// redo_target_lsn
        /// </summary>
        public decimal Redo_target_lsn { get; set; }

        /// <summary>
        /// redo_target_fork_guid
        /// </summary>
        public object Redo_target_fork_guid { get; set; }

        /// <summary>
        /// backup_lsn
        /// </summary>
        public decimal Backup_lsn { get; set; }

        /// <summary>
        /// credential_id
        /// </summary>
        public int Credential_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-cached-plans-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_cached_plans
    {
        /// <summary>
        /// bucketid
        /// </summary>
        public int Bucketid { get; set; }

        /// <summary>
        /// refcounts
        /// </summary>
        public int Refcounts { get; set; }

        /// <summary>
        /// usecounts
        /// </summary>
        public int Usecounts { get; set; }

        /// <summary>
        /// size_in_bytes
        /// </summary>
        public int Size_in_bytes { get; set; }

        /// <summary>
        /// memory_object_address
        /// </summary>
        public byte[] Memory_object_address { get; set; }

        /// <summary>
        /// cacheobjtype
        /// </summary>
        public string Cacheobjtype { get; set; }

        /// <summary>
        /// objtype
        /// </summary>
        public string Objtype { get; set; }

        /// <summary>
        /// plan_handle
        /// </summary>
        public byte[] Plan_handle { get; set; }

        /// <summary>
        /// pool_id
        /// </summary>
        public int Pool_id { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }
    }

    //TODO can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-plan-attributes-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_plan_attributes
    {
        /// <summary>
        /// attribute
        /// </summary>
        public string Attribute { get; set; }

        /// <summary>
        /// value
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// is_cache_key
        /// </summary>
        public bool Is_cache_key { get; set; }

        /// <summary>
        /// set_options
        /// </summary>
        public int Set_options { get; set; }

        /// <summary>
        /// objectid
        /// </summary>
        public int Objectid { get; set; }

        /// <summary>
        /// dbid
        /// </summary>
        public int Dbid { get; set; }

        /// <summary>
        /// dbid_execute
        /// </summary>
        public int Dbid_execute { get; set; }

        /// <summary>
        /// user_id
        /// </summary>
        public int User_id { get; set; }

        /// <summary>
        /// language_id
        /// </summary>
        public short Language_id { get; set; }

        /// <summary>
        /// date_format
        /// </summary>
        public short Date_format { get; set; }

        /// <summary>
        /// date_first
        /// </summary>
        public byte Date_first { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// required_cursor_options
        /// </summary>
        public int Required_cursor_options { get; set; }

        /// <summary>
        /// acceptable_cursor_options
        /// </summary>
        public int Acceptable_cursor_options { get; set; }

        /// <summary>
        /// inuse_exec_context
        /// </summary>
        public int Inuse_exec_context { get; set; }

        /// <summary>
        /// free_exec_context
        /// </summary>
        public int Free_exec_context { get; set; }

        /// <summary>
        /// hits_exec_context
        /// </summary>
        public int Hits_exec_context { get; set; }

        /// <summary>
        /// misses_exec_context
        /// </summary>
        public int Misses_exec_context { get; set; }

        /// <summary>
        /// removed_exec_context
        /// </summary>
        public int Removed_exec_context { get; set; }

        /// <summary>
        /// inuse_cursors
        /// </summary>
        public int Inuse_cursors { get; set; }

        /// <summary>
        /// free_cursors
        /// </summary>
        public int Free_cursors { get; set; }

        /// <summary>
        /// hits_cursors
        /// </summary>
        public int Hits_cursors { get; set; }

        /// <summary>
        /// misses_cursors
        /// </summary>
        public int Misses_cursors { get; set; }

        /// <summary>
        /// removed_cursors
        /// </summary>
        public int Removed_cursors { get; set; }

        /// <summary>
        /// sql_handle
        /// </summary>
        public byte[] Sql_handle { get; set; }

        /// <summary>
        /// merge_action_type
        /// </summary>
        public short Merge_action_type { get; set; }
    }

    //TODO can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-sql-text-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_sql_text
    {
        /// <summary>
        /// dbid
        /// </summary>
        public short Dbid { get; set; }

        /// <summary>
        /// objectid
        /// </summary>
        public int Objectid { get; set; }

        /// <summary>
        /// number
        /// </summary>
        public short Number { get; set; }

        /// <summary>
        /// encrypted
        /// </summary>
        public bool Encrypted { get; set; }

        /// <summary>
        /// text
        /// </summary>
        public string Text { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-query-stats-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_query_stats
    {
        /// <summary>
        /// sql_handle
        /// </summary>
        public byte[] Sql_handle { get; set; }

        /// <summary>
        /// statement_start_offset
        /// </summary>
        public int Statement_start_offset { get; set; }

        /// <summary>
        /// statement_end_offset
        /// </summary>
        public int Statement_end_offset { get; set; }

        /// <summary>
        /// plan_generation_num
        /// </summary>
        public long Plan_generation_num { get; set; }

        /// <summary>
        /// plan_handle
        /// </summary>
        public byte[] Plan_handle { get; set; }

        /// <summary>
        /// creation_time
        /// </summary>
        public DateTime Creation_time { get; set; }

        /// <summary>
        /// last_execution_time
        /// </summary>
        public DateTime Last_execution_time { get; set; }

        /// <summary>
        /// execution_count
        /// </summary>
        public long Execution_count { get; set; }

        /// <summary>
        /// total_worker_time
        /// </summary>
        public long Total_worker_time { get; set; }

        /// <summary>
        /// last_worker_time
        /// </summary>
        public long Last_worker_time { get; set; }

        /// <summary>
        /// min_worker_time
        /// </summary>
        public long Min_worker_time { get; set; }

        /// <summary>
        /// max_worker_time
        /// </summary>
        public long Max_worker_time { get; set; }

        /// <summary>
        /// total_physical_reads
        /// </summary>
        public long Total_physical_reads { get; set; }

        /// <summary>
        /// last_physical_reads
        /// </summary>
        public long Last_physical_reads { get; set; }

        /// <summary>
        /// min_physical_reads
        /// </summary>
        public long Min_physical_reads { get; set; }

        /// <summary>
        /// max_physical_reads
        /// </summary>
        public long Max_physical_reads { get; set; }

        /// <summary>
        /// total_logical_writes
        /// </summary>
        public long Total_logical_writes { get; set; }

        /// <summary>
        /// last_logical_writes
        /// </summary>
        public long Last_logical_writes { get; set; }

        /// <summary>
        /// min_logical_writes
        /// </summary>
        public long Min_logical_writes { get; set; }

        /// <summary>
        /// max_logical_writes
        /// </summary>
        public long Max_logical_writes { get; set; }

        /// <summary>
        /// total_logical_reads
        /// </summary>
        public long Total_logical_reads { get; set; }

        /// <summary>
        /// last_logical_reads
        /// </summary>
        public long Last_logical_reads { get; set; }

        /// <summary>
        /// min_logical_reads
        /// </summary>
        public long Min_logical_reads { get; set; }

        /// <summary>
        /// max_logical_reads
        /// </summary>
        public long Max_logical_reads { get; set; }

        /// <summary>
        /// total_clr_time
        /// </summary>
        public long Total_clr_time { get; set; }

        /// <summary>
        /// last_clr_time
        /// </summary>
        public long Last_clr_time { get; set; }

        /// <summary>
        /// min_clr_time
        /// </summary>
        public long Min_clr_time { get; set; }

        /// <summary>
        /// max_clr_time
        /// </summary>
        public long Max_clr_time { get; set; }

        /// <summary>
        /// total_elapsed_time
        /// </summary>
        public long Total_elapsed_time { get; set; }

        /// <summary>
        /// last_elapsed_time
        /// </summary>
        public long Last_elapsed_time { get; set; }

        /// <summary>
        /// min_elapsed_time
        /// </summary>
        public long Min_elapsed_time { get; set; }

        /// <summary>
        /// max_elapsed_time
        /// </summary>
        public long Max_elapsed_time { get; set; }

        /// <summary>
        /// query_hash
        /// </summary>
        public byte[] Query_hash { get; set; }

        /// <summary>
        /// query_plan_hash
        /// </summary>
        public byte[] Query_plan_hash { get; set; }

        /// <summary>
        /// total_rows
        /// </summary>
        public long Total_rows { get; set; }

        /// <summary>
        /// last_rows
        /// </summary>
        public long Last_rows { get; set; }

        /// <summary>
        /// min_rows
        /// </summary>
        public long Min_rows { get; set; }

        /// <summary>
        /// max_rows
        /// </summary>
        public long Max_rows { get; set; }

        /// <summary>
        /// statement_sql_handle
        /// </summary>
        public byte[] Statement_sql_handle { get; set; }

        /// <summary>
        /// statement_context_id
        /// </summary>
        public long Statement_context_id { get; set; }

        /// <summary>
        /// total_dop
        /// </summary>
        public long Total_dop { get; set; }

        /// <summary>
        /// last_dop
        /// </summary>
        public long Last_dop { get; set; }

        /// <summary>
        /// min_dop
        /// </summary>
        public long Min_dop { get; set; }

        /// <summary>
        /// max_dop
        /// </summary>
        public long Max_dop { get; set; }

        /// <summary>
        /// total_grant_kb
        /// </summary>
        public long Total_grant_kb { get; set; }

        /// <summary>
        /// last_grant_kb
        /// </summary>
        public long Last_grant_kb { get; set; }

        /// <summary>
        /// min_grant_kb
        /// </summary>
        public long Min_grant_kb { get; set; }

        /// <summary>
        /// max_grant_kb
        /// </summary>
        public long Max_grant_kb { get; set; }

        /// <summary>
        /// total_used_grant_kb
        /// </summary>
        public long Total_used_grant_kb { get; set; }

        /// <summary>
        /// last_used_grant_kb
        /// </summary>
        public long Last_used_grant_kb { get; set; }

        /// <summary>
        /// min_used_grant_kb
        /// </summary>
        public long Min_used_grant_kb { get; set; }

        /// <summary>
        /// max_used_grant_kb
        /// </summary>
        public long Max_used_grant_kb { get; set; }

        /// <summary>
        /// total_ideal_grant_kb
        /// </summary>
        public long Total_ideal_grant_kb { get; set; }

        /// <summary>
        /// last_ideal_grant_kb
        /// </summary>
        public long Last_ideal_grant_kb { get; set; }

        /// <summary>
        /// min_ideal_grant_kb
        /// </summary>
        public long Min_ideal_grant_kb { get; set; }

        /// <summary>
        /// max_ideal_grant_kb
        /// </summary>
        public long Max_ideal_grant_kb { get; set; }

        /// <summary>
        /// total_reserved_threads
        /// </summary>
        public long Total_reserved_threads { get; set; }

        /// <summary>
        /// last_reserved_threads
        /// </summary>
        public long Last_reserved_threads { get; set; }

        /// <summary>
        /// min_reserved_threads
        /// </summary>
        public long Min_reserved_threads { get; set; }

        /// <summary>
        /// max_reserved_threads
        /// </summary>
        public long Max_reserved_threads { get; set; }

        /// <summary>
        /// total_used_threads
        /// </summary>
        public long Total_used_threads { get; set; }

        /// <summary>
        /// last_used_threads
        /// </summary>
        public long Last_used_threads { get; set; }

        /// <summary>
        /// min_used_threads
        /// </summary>
        public long Min_used_threads { get; set; }

        /// <summary>
        /// max_used_threads
        /// </summary>
        public long Max_used_threads { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-requests-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_requests
    {
        /// <summary>
        /// session_id
        /// </summary>
        public short Session_id { get; set; }

        /// <summary>
        /// request_id
        /// </summary>
        public int Request_id { get; set; }

        /// <summary>
        /// start_time
        /// </summary>
        public DateTime Start_time { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// command
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// sql_handle
        /// </summary>
        public byte[] Sql_handle { get; set; }

        /// <summary>
        /// statement_start_offset
        /// </summary>
        public int Statement_start_offset { get; set; }

        /// <summary>
        /// statement_end_offset
        /// </summary>
        public int Statement_end_offset { get; set; }

        /// <summary>
        /// plan_handle
        /// </summary>
        public byte[] Plan_handle { get; set; }

        /// <summary>
        /// database_id
        /// </summary>
        public short Database_id { get; set; }

        /// <summary>
        /// user_id
        /// </summary>
        public int User_id { get; set; }

        /// <summary>
        /// connection_id
        /// </summary>
        public object Connection_id { get; set; }

        /// <summary>
        /// blocking_session_id
        /// </summary>
        public short Blocking_session_id { get; set; }

        /// <summary>
        /// wait_type
        /// </summary>
        public string Wait_type { get; set; }

        /// <summary>
        /// wait_time
        /// </summary>
        public int Wait_time { get; set; }

        /// <summary>
        /// last_wait_type
        /// </summary>
        public string Last_wait_type { get; set; }

        /// <summary>
        /// wait_resource
        /// </summary>
        public string Wait_resource { get; set; }

        /// <summary>
        /// open_transaction_count
        /// </summary>
        public int Open_transaction_count { get; set; }

        /// <summary>
        /// open_resultset_count
        /// </summary>
        public int Open_resultset_count { get; set; }

        /// <summary>
        /// transaction_id
        /// </summary>
        public long Transaction_id { get; set; }

        /// <summary>
        /// context_info
        /// </summary>
        public byte[] Context_info { get; set; }

        /// <summary>
        /// percent_complete
        /// </summary>
        public double Percent_complete { get; set; }

        /// <summary>
        /// estimated_completion_time
        /// </summary>
        public long Estimated_completion_time { get; set; }

        /// <summary>
        /// cpu_time
        /// </summary>
        public int Cpu_time { get; set; }

        /// <summary>
        /// total_elapsed_time
        /// </summary>
        public int Total_elapsed_time { get; set; }

        /// <summary>
        /// scheduler_id
        /// </summary>
        public int Scheduler_id { get; set; }

        /// <summary>
        /// task_address
        /// </summary>
        public byte[] Task_address { get; set; }

        /// <summary>
        /// reads
        /// </summary>
        public long Reads { get; set; }

        /// <summary>
        /// writes
        /// </summary>
        public long Writes { get; set; }

        /// <summary>
        /// logical_reads
        /// </summary>
        public long Logical_reads { get; set; }

        /// <summary>
        /// text_size
        /// </summary>
        public int Text_size { get; set; }

        /// <summary>
        /// language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// date_format
        /// </summary>
        public string Date_format { get; set; }

        /// <summary>
        /// date_first
        /// </summary>
        public short Date_first { get; set; }

        /// <summary>
        /// quoted_identifier
        /// </summary>
        public bool Quoted_identifier { get; set; }

        /// <summary>
        /// arithabort
        /// </summary>
        public bool Arithabort { get; set; }

        /// <summary>
        /// ansi_null_dflt_on
        /// </summary>
        public bool Ansi_null_dflt_on { get; set; }

        /// <summary>
        /// ansi_defaults
        /// </summary>
        public bool Ansi_defaults { get; set; }

        /// <summary>
        /// ansi_warnings
        /// </summary>
        public bool Ansi_warnings { get; set; }

        /// <summary>
        /// ansi_padding
        /// </summary>
        public bool Ansi_padding { get; set; }

        /// <summary>
        /// ansi_nulls
        /// </summary>
        public bool Ansi_nulls { get; set; }

        /// <summary>
        /// concat_null_yields_null
        /// </summary>
        public bool Concat_null_yields_null { get; set; }

        /// <summary>
        /// transaction_isolation_level
        /// </summary>
        public short Transaction_isolation_level { get; set; }

        /// <summary>
        /// lock_timeout
        /// </summary>
        public int Lock_timeout { get; set; }

        /// <summary>
        /// deadlock_priority
        /// </summary>
        public int Deadlock_priority { get; set; }

        /// <summary>
        /// row_count
        /// </summary>
        public long Row_count { get; set; }

        /// <summary>
        /// prev_error
        /// </summary>
        public int Prev_error { get; set; }

        /// <summary>
        /// nest_level
        /// </summary>
        public int Nest_level { get; set; }

        /// <summary>
        /// granted_query_memory
        /// </summary>
        public int Granted_query_memory { get; set; }

        /// <summary>
        /// executing_managed_code
        /// </summary>
        public bool Executing_managed_code { get; set; }

        /// <summary>
        /// group_id
        /// </summary>
        public int Group_id { get; set; }

        /// <summary>
        /// query_hash
        /// </summary>
        public byte[] Query_hash { get; set; }

        /// <summary>
        /// query_plan_hash
        /// </summary>
        public byte[] Query_plan_hash { get; set; }

        /// <summary>
        /// statement_sql_handle
        /// </summary>
        public byte[] Statement_sql_handle { get; set; }

        /// <summary>
        /// statement_context_id
        /// </summary>
        public long Statement_context_id { get; set; }

        /// <summary>
        /// dop
        /// </summary>
        public int Dop { get; set; }

        /// <summary>
        /// parallel_worker_count
        /// </summary>
        public int Parallel_worker_count { get; set; }

        /// <summary>
        /// external_script_request_id
        /// </summary>
        public object External_script_request_id { get; set; }

        /// <summary>
        /// is_resumable
        /// </summary>
        public bool Is_resumable { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }
    }

    //TODO can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-cursors-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_cursors
    {
        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// cursor_id
        /// </summary>
        public int Cursor_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// properties
        /// </summary>
        public string Properties { get; set; }

        /// <summary>
        /// sql_handle
        /// </summary>
        public byte[] Sql_handle { get; set; }

        /// <summary>
        /// statement_start_offset
        /// </summary>
        public int Statement_start_offset { get; set; }

        /// <summary>
        /// statement_end_offset
        /// </summary>
        public int Statement_end_offset { get; set; }

        /// <summary>
        /// plan_generation_num
        /// </summary>
        public long Plan_generation_num { get; set; }

        /// <summary>
        /// creation_time
        /// </summary>
        public DateTime Creation_time { get; set; }

        /// <summary>
        /// is_open
        /// </summary>
        public bool Is_open { get; set; }

        /// <summary>
        /// is_async_population
        /// </summary>
        public bool Is_async_population { get; set; }

        /// <summary>
        /// is_close_on_commit
        /// </summary>
        public bool Is_close_on_commit { get; set; }

        /// <summary>
        /// fetch_status
        /// </summary>
        public int Fetch_status { get; set; }

        /// <summary>
        /// fetch_buffer_size
        /// </summary>
        public int Fetch_buffer_size { get; set; }

        /// <summary>
        /// fetch_buffer_start
        /// </summary>
        public int Fetch_buffer_start { get; set; }

        /// <summary>
        /// ansi_position
        /// </summary>
        public int Ansi_position { get; set; }

        /// <summary>
        /// worker_time
        /// </summary>
        public long Worker_time { get; set; }

        /// <summary>
        /// reads
        /// </summary>
        public long Reads { get; set; }

        /// <summary>
        /// writes
        /// </summary>
        public long Writes { get; set; }

        /// <summary>
        /// dormant_duration
        /// </summary>
        public long Dormant_duration { get; set; }
    }

    //TODO can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-xml-handles-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_xml_handles
    {
        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// document_id
        /// </summary>
        public int Document_id { get; set; }

        /// <summary>
        /// namespace_document_id
        /// </summary>
        public int Namespace_document_id { get; set; }

        /// <summary>
        /// sql_handle
        /// </summary>
        public byte[] Sql_handle { get; set; }

        /// <summary>
        /// statement_start_offset
        /// </summary>
        public int Statement_start_offset { get; set; }

        /// <summary>
        /// statement_end_offset
        /// </summary>
        public int Statement_end_offset { get; set; }

        /// <summary>
        /// creation_time
        /// </summary>
        public DateTime Creation_time { get; set; }

        /// <summary>
        /// original_document_size_bytes
        /// </summary>
        public long Original_document_size_bytes { get; set; }

        /// <summary>
        /// original_namespace_document_size_bytes
        /// </summary>
        public long Original_namespace_document_size_bytes { get; set; }

        /// <summary>
        /// num_openxml_calls
        /// </summary>
        public long Num_openxml_calls { get; set; }

        /// <summary>
        /// row_count
        /// </summary>
        public long Row_count { get; set; }

        /// <summary>
        /// dormant_duration_ms
        /// </summary>
        public long Dormant_duration_ms { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-query-memory-grants-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_query_memory_grants
    {
        /// <summary>
        /// session_id
        /// </summary>
        public short Session_id { get; set; }

        /// <summary>
        /// request_id
        /// </summary>
        public int Request_id { get; set; }

        /// <summary>
        /// scheduler_id
        /// </summary>
        public int Scheduler_id { get; set; }

        /// <summary>
        /// dop
        /// </summary>
        public short Dop { get; set; }

        /// <summary>
        /// request_time
        /// </summary>
        public DateTime Request_time { get; set; }

        /// <summary>
        /// grant_time
        /// </summary>
        public DateTime Grant_time { get; set; }

        /// <summary>
        /// requested_memory_kb
        /// </summary>
        public long Requested_memory_kb { get; set; }

        /// <summary>
        /// granted_memory_kb
        /// </summary>
        public long Granted_memory_kb { get; set; }

        /// <summary>
        /// required_memory_kb
        /// </summary>
        public long Required_memory_kb { get; set; }

        /// <summary>
        /// used_memory_kb
        /// </summary>
        public long Used_memory_kb { get; set; }

        /// <summary>
        /// max_used_memory_kb
        /// </summary>
        public long Max_used_memory_kb { get; set; }

        /// <summary>
        /// query_cost
        /// </summary>
        public double Query_cost { get; set; }

        /// <summary>
        /// timeout_sec
        /// </summary>
        public int Timeout_sec { get; set; }

        /// <summary>
        /// resource_semaphore_id
        /// </summary>
        public short Resource_semaphore_id { get; set; }

        /// <summary>
        /// queue_id
        /// </summary>
        public short Queue_id { get; set; }

        /// <summary>
        /// wait_order
        /// </summary>
        public int Wait_order { get; set; }

        /// <summary>
        /// is_next_candidate
        /// </summary>
        public bool Is_next_candidate { get; set; }

        /// <summary>
        /// wait_time_ms
        /// </summary>
        public long Wait_time_ms { get; set; }

        /// <summary>
        /// plan_handle
        /// </summary>
        public byte[] Plan_handle { get; set; }

        /// <summary>
        /// sql_handle
        /// </summary>
        public byte[] Sql_handle { get; set; }

        /// <summary>
        /// group_id
        /// </summary>
        public int Group_id { get; set; }

        /// <summary>
        /// pool_id
        /// </summary>
        public int Pool_id { get; set; }

        /// <summary>
        /// is_small
        /// </summary>
        public byte Is_small { get; set; }

        /// <summary>
        /// ideal_memory_kb
        /// </summary>
        public long Ideal_memory_kb { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-connections-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_connections
    {
        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// most_recent_session_id
        /// </summary>
        public int Most_recent_session_id { get; set; }

        /// <summary>
        /// connect_time
        /// </summary>
        public DateTime Connect_time { get; set; }

        /// <summary>
        /// net_transport
        /// </summary>
        public string Net_transport { get; set; }

        /// <summary>
        /// protocol_type
        /// </summary>
        public string Protocol_type { get; set; }

        /// <summary>
        /// protocol_version
        /// </summary>
        public int Protocol_version { get; set; }

        /// <summary>
        /// endpoint_id
        /// </summary>
        public int Endpoint_id { get; set; }

        /// <summary>
        /// encrypt_option
        /// </summary>
        public string Encrypt_option { get; set; }

        /// <summary>
        /// auth_scheme
        /// </summary>
        public string Auth_scheme { get; set; }

        /// <summary>
        /// node_affinity
        /// </summary>
        public short Node_affinity { get; set; }

        /// <summary>
        /// num_reads
        /// </summary>
        public int Num_reads { get; set; }

        /// <summary>
        /// num_writes
        /// </summary>
        public int Num_writes { get; set; }

        /// <summary>
        /// last_read
        /// </summary>
        public DateTime Last_read { get; set; }

        /// <summary>
        /// last_write
        /// </summary>
        public DateTime Last_write { get; set; }

        /// <summary>
        /// net_packet_size
        /// </summary>
        public int Net_packet_size { get; set; }

        /// <summary>
        /// client_net_address
        /// </summary>
        public string Client_net_address { get; set; }

        /// <summary>
        /// client_tcp_port
        /// </summary>
        public int Client_tcp_port { get; set; }

        /// <summary>
        /// local_net_address
        /// </summary>
        public string Local_net_address { get; set; }

        /// <summary>
        /// local_tcp_port
        /// </summary>
        public int Local_tcp_port { get; set; }

        /// <summary>
        /// connection_id
        /// </summary>
        public object Connection_id { get; set; }

        /// <summary>
        /// parent_connection_id
        /// </summary>
        public object Parent_connection_id { get; set; }

        /// <summary>
        /// most_recent_sql_handle
        /// </summary>
        public byte[] Most_recent_sql_handle { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }
    }

    //TODO can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-cached-plan-dependent-objects-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_cached_plan_dependent_objects
    {
        /// <summary>
        /// usecounts
        /// </summary>
        public int Usecounts { get; set; }

        /// <summary>
        /// memory_object_address
        /// </summary>
        public byte[] Memory_object_address { get; set; }

        /// <summary>
        /// cacheobjtype
        /// </summary>
        public string Cacheobjtype { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-compatibility-views/sys-syscharsets-transact-sql
    /// </summary>
    public class Table_sys_syscharsets
    {
        /// <summary>
        /// type
        /// </summary>
        public short Type { get; set; }

        /// <summary>
        /// id
        /// </summary>
        public byte Id { get; set; }

        /// <summary>
        /// csid
        /// </summary>
        public byte Csid { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public short Status { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// binarydefinition
        /// </summary>
        public byte[] Binarydefinition { get; set; }

        /// <summary>
        /// definition
        /// </summary>
        public byte[] Definition { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-configurations-transact-sql
    /// </summary>
    public class Table_sys_configurations
    {
        /// <summary>
        /// configuration_id
        /// </summary>
        public int Configuration_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// value
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// minimum
        /// </summary>
        public object Minimum { get; set; }

        /// <summary>
        /// maximum
        /// </summary>
        public object Maximum { get; set; }

        /// <summary>
        /// value_in_use
        /// </summary>
        public object Value_in_use { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// is_dynamic
        /// </summary>
        public bool Is_dynamic { get; set; }

        /// <summary>
        /// is_advanced
        /// </summary>
        public bool Is_advanced { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-databases-transact-sql
    /// </summary>
    public class Table_sys_databases
    {
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// database_id
        /// </summary>
        public int Database_id { get; set; }

        /// <summary>
        /// source_database_id
        /// </summary>
        public int Source_database_id { get; set; }

        /// <summary>
        /// owner_sid
        /// </summary>
        public byte[] Owner_sid { get; set; }

        /// <summary>
        /// create_date
        /// </summary>
        public DateTime Create_date { get; set; }

        /// <summary>
        /// compatibility_level
        /// </summary>
        public byte Compatibility_level { get; set; }

        /// <summary>
        /// collation_name
        /// </summary>
        public string Collation_name { get; set; }

        /// <summary>
        /// user_access
        /// </summary>
        public byte User_access { get; set; }

        /// <summary>
        /// user_access_desc
        /// </summary>
        public string User_access_desc { get; set; }

        /// <summary>
        /// is_read_only
        /// </summary>
        public bool Is_read_only { get; set; }

        /// <summary>
        /// is_auto_close_on
        /// </summary>
        public bool Is_auto_close_on { get; set; }

        /// <summary>
        /// is_auto_shrink_on
        /// </summary>
        public bool Is_auto_shrink_on { get; set; }

        /// <summary>
        /// state
        /// </summary>
        public byte State { get; set; }

        /// <summary>
        /// state_desc
        /// </summary>
        public string State_desc { get; set; }

        /// <summary>
        /// is_in_standby
        /// </summary>
        public bool Is_in_standby { get; set; }

        /// <summary>
        /// is_cleanly_shutdown
        /// </summary>
        public bool Is_cleanly_shutdown { get; set; }

        /// <summary>
        /// is_supplemental_logging_enabled
        /// </summary>
        public bool Is_supplemental_logging_enabled { get; set; }

        /// <summary>
        /// snapshot_isolation_state
        /// </summary>
        public byte Snapshot_isolation_state { get; set; }

        /// <summary>
        /// snapshot_isolation_state_desc
        /// </summary>
        public string Snapshot_isolation_state_desc { get; set; }

        /// <summary>
        /// is_read_committed_snapshot_on
        /// </summary>
        public bool Is_read_committed_snapshot_on { get; set; }

        /// <summary>
        /// recovery_model
        /// </summary>
        public byte Recovery_model { get; set; }

        /// <summary>
        /// recovery_model_desc
        /// </summary>
        public string Recovery_model_desc { get; set; }

        /// <summary>
        /// page_verify_option
        /// </summary>
        public byte Page_verify_option { get; set; }

        /// <summary>
        /// page_verify_option_desc
        /// </summary>
        public string Page_verify_option_desc { get; set; }

        /// <summary>
        /// is_auto_create_stats_on
        /// </summary>
        public bool Is_auto_create_stats_on { get; set; }

        /// <summary>
        /// is_auto_create_stats_incremental_on
        /// </summary>
        public bool Is_auto_create_stats_incremental_on { get; set; }

        /// <summary>
        /// is_auto_update_stats_on
        /// </summary>
        public bool Is_auto_update_stats_on { get; set; }

        /// <summary>
        /// is_auto_update_stats_async_on
        /// </summary>
        public bool Is_auto_update_stats_async_on { get; set; }

        /// <summary>
        /// is_ansi_null_default_on
        /// </summary>
        public bool Is_ansi_null_default_on { get; set; }

        /// <summary>
        /// is_ansi_nulls_on
        /// </summary>
        public bool Is_ansi_nulls_on { get; set; }

        /// <summary>
        /// is_ansi_padding_on
        /// </summary>
        public bool Is_ansi_padding_on { get; set; }

        /// <summary>
        /// is_ansi_warnings_on
        /// </summary>
        public bool Is_ansi_warnings_on { get; set; }

        /// <summary>
        /// is_arithabort_on
        /// </summary>
        public bool Is_arithabort_on { get; set; }

        /// <summary>
        /// is_concat_null_yields_null_on
        /// </summary>
        public bool Is_concat_null_yields_null_on { get; set; }

        /// <summary>
        /// is_numeric_roundabort_on
        /// </summary>
        public bool Is_numeric_roundabort_on { get; set; }

        /// <summary>
        /// is_quoted_identifier_on
        /// </summary>
        public bool Is_quoted_identifier_on { get; set; }

        /// <summary>
        /// is_recursive_triggers_on
        /// </summary>
        public bool Is_recursive_triggers_on { get; set; }

        /// <summary>
        /// is_cursor_close_on_commit_on
        /// </summary>
        public bool Is_cursor_close_on_commit_on { get; set; }

        /// <summary>
        /// is_local_cursor_default
        /// </summary>
        public bool Is_local_cursor_default { get; set; }

        /// <summary>
        /// is_fulltext_enabled
        /// </summary>
        public bool Is_fulltext_enabled { get; set; }

        /// <summary>
        /// is_trustworthy_on
        /// </summary>
        public bool Is_trustworthy_on { get; set; }

        /// <summary>
        /// is_db_chaining_on
        /// </summary>
        public bool Is_db_chaining_on { get; set; }

        /// <summary>
        /// is_parameterization_forced
        /// </summary>
        public bool Is_parameterization_forced { get; set; }

        /// <summary>
        /// is_master_key_encrypted_by_server
        /// </summary>
        public bool Is_master_key_encrypted_by_server { get; set; }

        /// <summary>
        /// is_query_store_on
        /// </summary>
        public bool Is_query_store_on { get; set; }

        /// <summary>
        /// is_published
        /// </summary>
        public bool Is_published { get; set; }

        /// <summary>
        /// is_subscribed
        /// </summary>
        public bool Is_subscribed { get; set; }

        /// <summary>
        /// is_merge_published
        /// </summary>
        public bool Is_merge_published { get; set; }

        /// <summary>
        /// is_distributor
        /// </summary>
        public bool Is_distributor { get; set; }

        /// <summary>
        /// is_sync_with_backup
        /// </summary>
        public bool Is_sync_with_backup { get; set; }

        /// <summary>
        /// service_broker_guid
        /// </summary>
        public object Service_broker_guid { get; set; }

        /// <summary>
        /// is_broker_enabled
        /// </summary>
        public bool Is_broker_enabled { get; set; }

        /// <summary>
        /// log_reuse_wait
        /// </summary>
        public byte Log_reuse_wait { get; set; }

        /// <summary>
        /// log_reuse_wait_desc
        /// </summary>
        public string Log_reuse_wait_desc { get; set; }

        /// <summary>
        /// is_date_correlation_on
        /// </summary>
        public bool Is_date_correlation_on { get; set; }

        /// <summary>
        /// is_cdc_enabled
        /// </summary>
        public bool Is_cdc_enabled { get; set; }

        /// <summary>
        /// is_encrypted
        /// </summary>
        public bool Is_encrypted { get; set; }

        /// <summary>
        /// is_honor_broker_priority_on
        /// </summary>
        public bool Is_honor_broker_priority_on { get; set; }

        /// <summary>
        /// replica_id
        /// </summary>
        public object Replica_id { get; set; }

        /// <summary>
        /// group_database_id
        /// </summary>
        public object Group_database_id { get; set; }

        /// <summary>
        /// resource_pool_id
        /// </summary>
        public int Resource_pool_id { get; set; }

        /// <summary>
        /// default_language_lcid
        /// </summary>
        public short Default_language_lcid { get; set; }

        /// <summary>
        /// default_language_name
        /// </summary>
        public string Default_language_name { get; set; }

        /// <summary>
        /// default_fulltext_language_lcid
        /// </summary>
        public int Default_fulltext_language_lcid { get; set; }

        /// <summary>
        /// default_fulltext_language_name
        /// </summary>
        public string Default_fulltext_language_name { get; set; }

        /// <summary>
        /// is_nested_triggers_on
        /// </summary>
        public bool Is_nested_triggers_on { get; set; }

        /// <summary>
        /// is_transform_noise_words_on
        /// </summary>
        public bool Is_transform_noise_words_on { get; set; }

        /// <summary>
        /// two_digit_year_cutoff
        /// </summary>
        public short Two_digit_year_cutoff { get; set; }

        /// <summary>
        /// containment
        /// </summary>
        public byte Containment { get; set; }

        /// <summary>
        /// containment_desc
        /// </summary>
        public string Containment_desc { get; set; }

        /// <summary>
        /// target_recovery_time_in_seconds
        /// </summary>
        public int Target_recovery_time_in_seconds { get; set; }

        /// <summary>
        /// delayed_durability
        /// </summary>
        public int Delayed_durability { get; set; }

        /// <summary>
        /// delayed_durability_desc
        /// </summary>
        public string Delayed_durability_desc { get; set; }

        /// <summary>
        /// is_memory_optimized_elevate_to_snapshot_on
        /// </summary>
        public bool Is_memory_optimized_elevate_to_snapshot_on { get; set; }

        /// <summary>
        /// is_federation_member
        /// </summary>
        public bool Is_federation_member { get; set; }

        /// <summary>
        /// is_remote_data_archive_enabled
        /// </summary>
        public bool Is_remote_data_archive_enabled { get; set; }

        /// <summary>
        /// is_mixed_page_allocation_on
        /// </summary>
        public bool Is_mixed_page_allocation_on { get; set; }

        /// <summary>
        /// is_temporal_retention_enabled
        /// </summary>
        public bool Is_temporal_retention_enabled { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-backup-devices-transact-sql
    /// </summary>
    public class Table_sys_backup_devices
    {
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// type_desc
        /// </summary>
        public string Type_desc { get; set; }

        /// <summary>
        /// physical_name
        /// </summary>
        public string Physical_name { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-compatibility-views/sys-syslanguages-transact-sql
    /// </summary>
    public class Table_sys_syslanguages
    {
        /// <summary>
        /// langid
        /// </summary>
        public short Langid { get; set; }

        /// <summary>
        /// dateformat
        /// </summary>
        public string Dateformat { get; set; }

        /// <summary>
        /// datefirst
        /// </summary>
        public byte Datefirst { get; set; }

        /// <summary>
        /// upgrade
        /// </summary>
        public int Upgrade { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// alias
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// months
        /// </summary>
        public string Months { get; set; }

        /// <summary>
        /// shortmonths
        /// </summary>
        public string Shortmonths { get; set; }

        /// <summary>
        /// days
        /// </summary>
        public string Days { get; set; }

        /// <summary>
        /// lcid
        /// </summary>
        public int Lcid { get; set; }

        /// <summary>
        /// msglangid
        /// </summary>
        public short Msglangid { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-tran-locks-transact-sql
    /// </summary>
    public class Table_sys_dm_tran_locks
    {
        /// <summary>
        /// resource_type
        /// </summary>
        public string Resource_type { get; set; }

        /// <summary>
        /// resource_subtype
        /// </summary>
        public string Resource_subtype { get; set; }

        /// <summary>
        /// resource_database_id
        /// </summary>
        public int Resource_database_id { get; set; }

        /// <summary>
        /// resource_description
        /// </summary>
        public string Resource_description { get; set; }

        /// <summary>
        /// resource_associated_entity_id
        /// </summary>
        public long Resource_associated_entity_id { get; set; }

        /// <summary>
        /// resource_lock_partition
        /// </summary>
        public int Resource_lock_partition { get; set; }

        /// <summary>
        /// request_mode
        /// </summary>
        public string Request_mode { get; set; }

        /// <summary>
        /// request_type
        /// </summary>
        public string Request_type { get; set; }

        /// <summary>
        /// request_status
        /// </summary>
        public string Request_status { get; set; }

        /// <summary>
        /// request_reference_count
        /// </summary>
        public short Request_reference_count { get; set; }

        /// <summary>
        /// request_lifetime
        /// </summary>
        public int Request_lifetime { get; set; }

        /// <summary>
        /// request_session_id
        /// </summary>
        public int Request_session_id { get; set; }

        /// <summary>
        /// request_exec_context_id
        /// </summary>
        public int Request_exec_context_id { get; set; }

        /// <summary>
        /// request_request_id
        /// </summary>
        public int Request_request_id { get; set; }

        /// <summary>
        /// request_owner_type
        /// </summary>
        public string Request_owner_type { get; set; }

        /// <summary>
        /// request_owner_id
        /// </summary>
        public long Request_owner_id { get; set; }

        /// <summary>
        /// request_owner_guid
        /// </summary>
        public object Request_owner_guid { get; set; }

        /// <summary>
        /// request_owner_lockspace_id
        /// </summary>
        public string Request_owner_lockspace_id { get; set; }

        /// <summary>
        /// lock_owner_address
        /// </summary>
        public byte[] Lock_owner_address { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-server-principals-transact-sql
    /// </summary>
    public class Table_sys_server_principals
    {
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// principal_id
        /// </summary>
        public int Principal_id { get; set; }

        /// <summary>
        /// sid
        /// </summary>
        public byte[] Sid { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// type_desc
        /// </summary>
        public string Type_desc { get; set; }

        /// <summary>
        /// is_disabled
        /// </summary>
        public int Is_disabled { get; set; }

        /// <summary>
        /// create_date
        /// </summary>
        public DateTime Create_date { get; set; }

        /// <summary>
        /// modify_date
        /// </summary>
        public DateTime Modify_date { get; set; }

        /// <summary>
        /// default_database_name
        /// </summary>
        public string Default_database_name { get; set; }

        /// <summary>
        /// default_language_name
        /// </summary>
        public string Default_language_name { get; set; }

        /// <summary>
        /// credential_id
        /// </summary>
        public int Credential_id { get; set; }

        /// <summary>
        /// owning_principal_id
        /// </summary>
        public int Owning_principal_id { get; set; }

        /// <summary>
        /// is_fixed_role
        /// </summary>
        public bool Is_fixed_role { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-sql-logins-transact-sql
    /// </summary>
    public class Table_sys_sql_logins
    {
        /// <summary>
        /// is_policy_checked
        /// </summary>
        public bool Is_policy_checked { get; set; }

        /// <summary>
        /// is_expiration_checked
        /// </summary>
        public bool Is_expiration_checked { get; set; }

        /// <summary>
        /// password_hash
        /// </summary>
        public byte[] Password_hash { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/messages-for-errors-catalog-views-sys-messages
    /// </summary>
    public class Table_sys_messages
    {
        /// <summary>
        /// message_id
        /// </summary>
        public int Message_id { get; set; }

        /// <summary>
        /// language_id
        /// </summary>
        public short Language_id { get; set; }

        /// <summary>
        /// severity
        /// </summary>
        public byte Severity { get; set; }

        /// <summary>
        /// is_event_logged
        /// </summary>
        public bool Is_event_logged { get; set; }

        /// <summary>
        /// text
        /// </summary>
        public string Text { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-linked-logins-transact-sql
    /// </summary>
    public class Table_sys_linked_logins
    {
        /// <summary>
        /// server_id
        /// </summary>
        public int Server_id { get; set; }

        /// <summary>
        /// local_principal_id
        /// </summary>
        public int Local_principal_id { get; set; }

        /// <summary>
        /// uses_self_credential
        /// </summary>
        public bool Uses_self_credential { get; set; }

        /// <summary>
        /// remote_name
        /// </summary>
        public string Remote_name { get; set; }

        /// <summary>
        /// modify_date
        /// </summary>
        public DateTime Modify_date { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-io-backup-tapes-transact-sql
    /// </summary>
    public class Table_sys_dm_io_backup_tapes
    {
        /// <summary>
        /// physical_device_name
        /// </summary>
        public string Physical_device_name { get; set; }

        /// <summary>
        /// logical_device_name
        /// </summary>
        public string Logical_device_name { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// status_desc
        /// </summary>
        public string Status_desc { get; set; }

        /// <summary>
        /// mount_request_time
        /// </summary>
        public DateTime Mount_request_time { get; set; }

        /// <summary>
        /// mount_expiration_time
        /// </summary>
        public DateTime Mount_expiration_time { get; set; }

        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }

        /// <summary>
        /// spid
        /// </summary>
        public int Spid { get; set; }

        /// <summary>
        /// command
        /// </summary>
        public int Command { get; set; }

        /// <summary>
        /// command_desc
        /// </summary>
        public string Command_desc { get; set; }

        /// <summary>
        /// media_family_id
        /// </summary>
        public int Media_family_id { get; set; }

        /// <summary>
        /// media_set_name
        /// </summary>
        public string Media_set_name { get; set; }

        /// <summary>
        /// media_set_guid
        /// </summary>
        public object Media_set_guid { get; set; }

        /// <summary>
        /// media_sequence_number
        /// </summary>
        public int Media_sequence_number { get; set; }

        /// <summary>
        /// tape_operation
        /// </summary>
        public int Tape_operation { get; set; }

        /// <summary>
        /// tape_operation_desc
        /// </summary>
        public string Tape_operation_desc { get; set; }

        /// <summary>
        /// mount_request_type
        /// </summary>
        public int Mount_request_type { get; set; }

        /// <summary>
        /// mount_request_type_desc
        /// </summary>
        public string Mount_request_type_desc { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-os-performance-counters-transact-sql
    /// </summary>
    public class Table_sys_dm_os_performance_counters
    {
        /// <summary>
        /// object_name
        /// </summary>
        public string Object_name { get; set; }

        /// <summary>
        /// counter_name
        /// </summary>
        public string Counter_name { get; set; }

        /// <summary>
        /// instance_name
        /// </summary>
        public string Instance_name { get; set; }

        /// <summary>
        /// cntr_value
        /// </summary>
        public long Cntr_value { get; set; }

        /// <summary>
        /// cntr_type
        /// </summary>
        public int Cntr_type { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-sessions-transact-sql
    /// </summary>
    public class Table_sys_dm_exec_sessions
    {
        /// <summary>
        /// session_id
        /// </summary>
        public short Session_id { get; set; }

        /// <summary>
        /// login_time
        /// </summary>
        public DateTime Login_time { get; set; }

        /// <summary>
        /// host_name
        /// </summary>
        public string Host_name { get; set; }

        /// <summary>
        /// program_name
        /// </summary>
        public string Program_name { get; set; }

        /// <summary>
        /// host_process_id
        /// </summary>
        public int Host_process_id { get; set; }

        /// <summary>
        /// client_version
        /// </summary>
        public int Client_version { get; set; }

        /// <summary>
        /// client_interface_name
        /// </summary>
        public string Client_interface_name { get; set; }

        /// <summary>
        /// security_id
        /// </summary>
        public byte[] Security_id { get; set; }

        /// <summary>
        /// login_name
        /// </summary>
        public string Login_name { get; set; }

        /// <summary>
        /// nt_domain
        /// </summary>
        public string Nt_domain { get; set; }

        /// <summary>
        /// nt_user_name
        /// </summary>
        public string Nt_user_name { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// context_info
        /// </summary>
        public byte[] Context_info { get; set; }

        /// <summary>
        /// cpu_time
        /// </summary>
        public int Cpu_time { get; set; }

        /// <summary>
        /// memory_usage
        /// </summary>
        public int Memory_usage { get; set; }

        /// <summary>
        /// total_scheduled_time
        /// </summary>
        public int Total_scheduled_time { get; set; }

        /// <summary>
        /// total_elapsed_time
        /// </summary>
        public int Total_elapsed_time { get; set; }

        /// <summary>
        /// endpoint_id
        /// </summary>
        public int Endpoint_id { get; set; }

        /// <summary>
        /// last_request_start_time
        /// </summary>
        public DateTime Last_request_start_time { get; set; }

        /// <summary>
        /// last_request_end_time
        /// </summary>
        public DateTime Last_request_end_time { get; set; }

        /// <summary>
        /// reads
        /// </summary>
        public long Reads { get; set; }

        /// <summary>
        /// writes
        /// </summary>
        public long Writes { get; set; }

        /// <summary>
        /// logical_reads
        /// </summary>
        public long Logical_reads { get; set; }

        /// <summary>
        /// is_user_process
        /// </summary>
        public bool Is_user_process { get; set; }

        /// <summary>
        /// text_size
        /// </summary>
        public int Text_size { get; set; }

        /// <summary>
        /// language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// date_format
        /// </summary>
        public string Date_format { get; set; }

        /// <summary>
        /// date_first
        /// </summary>
        public short Date_first { get; set; }

        /// <summary>
        /// quoted_identifier
        /// </summary>
        public bool Quoted_identifier { get; set; }

        /// <summary>
        /// arithabort
        /// </summary>
        public bool Arithabort { get; set; }

        /// <summary>
        /// ansi_null_dflt_on
        /// </summary>
        public bool Ansi_null_dflt_on { get; set; }

        /// <summary>
        /// ansi_defaults
        /// </summary>
        public bool Ansi_defaults { get; set; }

        /// <summary>
        /// ansi_warnings
        /// </summary>
        public bool Ansi_warnings { get; set; }

        /// <summary>
        /// ansi_padding
        /// </summary>
        public bool Ansi_padding { get; set; }

        /// <summary>
        /// ansi_nulls
        /// </summary>
        public bool Ansi_nulls { get; set; }

        /// <summary>
        /// concat_null_yields_null
        /// </summary>
        public bool Concat_null_yields_null { get; set; }

        /// <summary>
        /// transaction_isolation_level
        /// </summary>
        public short Transaction_isolation_level { get; set; }

        /// <summary>
        /// lock_timeout
        /// </summary>
        public int Lock_timeout { get; set; }

        /// <summary>
        /// deadlock_priority
        /// </summary>
        public int Deadlock_priority { get; set; }

        /// <summary>
        /// row_count
        /// </summary>
        public long Row_count { get; set; }

        /// <summary>
        /// prev_error
        /// </summary>
        public int Prev_error { get; set; }

        /// <summary>
        /// original_security_id
        /// </summary>
        public byte[] Original_security_id { get; set; }

        /// <summary>
        /// original_login_name
        /// </summary>
        public string Original_login_name { get; set; }

        /// <summary>
        /// last_successful_logon
        /// </summary>
        public DateTime Last_successful_logon { get; set; }

        /// <summary>
        /// last_unsuccessful_logon
        /// </summary>
        public DateTime Last_unsuccessful_logon { get; set; }

        /// <summary>
        /// unsuccessful_logons
        /// </summary>
        public long Unsuccessful_logons { get; set; }

        /// <summary>
        /// group_id
        /// </summary>
        public int Group_id { get; set; }

        /// <summary>
        /// database_id
        /// </summary>
        public short Database_id { get; set; }

        /// <summary>
        /// authenticating_database_id
        /// </summary>
        public int Authenticating_database_id { get; set; }

        /// <summary>
        /// open_transaction_count
        /// </summary>
        public int Open_transaction_count { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-remote-logins-transact-sql
    /// </summary>
    public class Table_sys_remote_logins
    {
        /// <summary>
        /// server_id
        /// </summary>
        public int Server_id { get; set; }

        /// <summary>
        /// remote_name
        /// </summary>
        public string Remote_name { get; set; }

        /// <summary>
        /// local_principal_id
        /// </summary>
        public int Local_principal_id { get; set; }

        /// <summary>
        /// modify_date
        /// </summary>
        public DateTime Modify_date { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-servers-transact-sql
    /// </summary>
    public class Table_sys_servers
    {
        /// <summary>
        /// server_id
        /// </summary>
        public int Server_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// product
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        /// provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// data_source
        /// </summary>
        public string Data_source { get; set; }

        /// <summary>
        /// location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// provider_string
        /// </summary>
        public string Provider_string { get; set; }

        /// <summary>
        /// catalog
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// connect_timeout
        /// </summary>
        public int Connect_timeout { get; set; }

        /// <summary>
        /// query_timeout
        /// </summary>
        public int Query_timeout { get; set; }

        /// <summary>
        /// is_linked
        /// </summary>
        public bool Is_linked { get; set; }

        /// <summary>
        /// is_remote_login_enabled
        /// </summary>
        public bool Is_remote_login_enabled { get; set; }

        /// <summary>
        /// is_rpc_out_enabled
        /// </summary>
        public bool Is_rpc_out_enabled { get; set; }

        /// <summary>
        /// is_data_access_enabled
        /// </summary>
        public bool Is_data_access_enabled { get; set; }

        /// <summary>
        /// is_collation_compatible
        /// </summary>
        public bool Is_collation_compatible { get; set; }

        /// <summary>
        /// uses_remote_collation
        /// </summary>
        public bool Uses_remote_collation { get; set; }

        /// <summary>
        /// collation_name
        /// </summary>
        public string Collation_name { get; set; }

        /// <summary>
        /// lazy_schema_validation
        /// </summary>
        public bool Lazy_schema_validation { get; set; }

        /// <summary>
        /// is_system
        /// </summary>
        public bool Is_system { get; set; }

        /// <summary>
        /// is_publisher
        /// </summary>
        public bool Is_publisher { get; set; }

        /// <summary>
        /// is_subscriber
        /// </summary>
        public bool Is_subscriber { get; set; }

        /// <summary>
        /// is_distributor
        /// </summary>
        public bool Is_distributor { get; set; }

        /// <summary>
        /// is_nonsql_subscriber
        /// </summary>
        public bool Is_nonsql_subscriber { get; set; }

        /// <summary>
        /// is_remote_proc_transaction_promotion_enabled
        /// </summary>
        public bool Is_remote_proc_transaction_promotion_enabled { get; set; }

        /// <summary>
        /// modify_date
        /// </summary>
        public DateTime Modify_date { get; set; }
    }

    //TODO can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-io-virtual-file-stats-transact-sql
    /// </summary>
    public class Table_sys_dm_io_virtual_file_stats
    {
        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }

        /// <summary>
        /// database_id
        /// </summary>
        public short Database_id { get; set; }

        /// <summary>
        /// file_id
        /// </summary>
        public short File_id { get; set; }

        /// <summary>
        /// sample_ms
        /// </summary>
        public long Sample_ms { get; set; }

        /// <summary>
        /// num_of_reads
        /// </summary>
        public long Num_of_reads { get; set; }

        /// <summary>
        /// num_of_bytes_read
        /// </summary>
        public long Num_of_bytes_read { get; set; }

        /// <summary>
        /// io_stall_read_ms
        /// </summary>
        public long Io_stall_read_ms { get; set; }

        /// <summary>
        /// num_of_writes
        /// </summary>
        public long Num_of_writes { get; set; }

        /// <summary>
        /// num_of_bytes_written
        /// </summary>
        public long Num_of_bytes_written { get; set; }

        /// <summary>
        /// io_stall_write_ms
        /// </summary>
        public long Io_stall_write_ms { get; set; }

        /// <summary>
        /// io_stall
        /// </summary>
        public long Io_stall { get; set; }

        /// <summary>
        /// size_on_disk_bytes
        /// </summary>
        public long Size_on_disk_bytes { get; set; }

        /// <summary>
        /// file_handle
        /// </summary>
        public byte[] File_handle { get; set; }

        /// <summary>
        /// io_stall_queued_read_ms
        /// </summary>
        public long Io_stall_queued_read_ms { get; set; }

        /// <summary>
        /// io_stall_queued_write_ms
        /// </summary>
        public long Io_stall_queued_write_ms { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-columns-transact-sql
    /// </summary>
    public class Table_sys_columns
    {
        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// column_id
        /// </summary>
        public int Column_id { get; set; }

        /// <summary>
        /// system_type_id
        /// </summary>
        public byte System_type_id { get; set; }

        /// <summary>
        /// user_type_id
        /// </summary>
        public int User_type_id { get; set; }

        /// <summary>
        /// max_length
        /// </summary>
        public short Max_length { get; set; }

        /// <summary>
        /// precision
        /// </summary>
        public byte Precision { get; set; }

        /// <summary>
        /// scale
        /// </summary>
        public byte Scale { get; set; }

        /// <summary>
        /// collation_name
        /// </summary>
        public string Collation_name { get; set; }

        /// <summary>
        /// is_nullable
        /// </summary>
        public bool Is_nullable { get; set; }

        /// <summary>
        /// is_ansi_padded
        /// </summary>
        public bool Is_ansi_padded { get; set; }

        /// <summary>
        /// is_rowguidcol
        /// </summary>
        public bool Is_rowguidcol { get; set; }

        /// <summary>
        /// is_identity
        /// </summary>
        public bool Is_identity { get; set; }

        /// <summary>
        /// is_computed
        /// </summary>
        public bool Is_computed { get; set; }

        /// <summary>
        /// is_filestream
        /// </summary>
        public bool Is_filestream { get; set; }

        /// <summary>
        /// is_replicated
        /// </summary>
        public bool Is_replicated { get; set; }

        /// <summary>
        /// is_non_sql_subscribed
        /// </summary>
        public bool Is_non_sql_subscribed { get; set; }

        /// <summary>
        /// is_merge_published
        /// </summary>
        public bool Is_merge_published { get; set; }

        /// <summary>
        /// is_dts_replicated
        /// </summary>
        public bool Is_dts_replicated { get; set; }

        /// <summary>
        /// is_xml_document
        /// </summary>
        public bool Is_xml_document { get; set; }

        /// <summary>
        /// xml_collection_id
        /// </summary>
        public int Xml_collection_id { get; set; }

        /// <summary>
        /// default_object_id
        /// </summary>
        public int Default_object_id { get; set; }

        /// <summary>
        /// rule_object_id
        /// </summary>
        public int Rule_object_id { get; set; }

        /// <summary>
        /// is_sparse
        /// </summary>
        public bool Is_sparse { get; set; }

        /// <summary>
        /// is_column_set
        /// </summary>
        public bool Is_column_set { get; set; }

        /// <summary>
        /// generated_always_type
        /// </summary>
        public byte Generated_always_type { get; set; }

        /// <summary>
        /// generated_always_type_desc
        /// </summary>
        public string Generated_always_type_desc { get; set; }

        /// <summary>
        /// encryption_type
        /// </summary>
        public int Encryption_type { get; set; }

        /// <summary>
        /// encryption_type_desc
        /// </summary>
        public string Encryption_type_desc { get; set; }

        /// <summary>
        /// encryption_algorithm_name
        /// </summary>
        public string Encryption_algorithm_name { get; set; }

        /// <summary>
        /// column_encryption_key_id
        /// </summary>
        public int Column_encryption_key_id { get; set; }

        /// <summary>
        /// column_encryption_key_database_name
        /// </summary>
        public string Column_encryption_key_database_name { get; set; }

        /// <summary>
        /// is_hidden
        /// </summary>
        public bool Is_hidden { get; set; }

        /// <summary>
        /// is_masked
        /// </summary>
        public bool Is_masked { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-sql-modules-transact-sql
    /// </summary>
    public class Table_sys_sql_modules
    {
        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// definition
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// uses_ansi_nulls
        /// </summary>
        public bool Uses_ansi_nulls { get; set; }

        /// <summary>
        /// uses_quoted_identifier
        /// </summary>
        public bool Uses_quoted_identifier { get; set; }

        /// <summary>
        /// is_schema_bound
        /// </summary>
        public bool Is_schema_bound { get; set; }

        /// <summary>
        /// uses_database_collation
        /// </summary>
        public bool Uses_database_collation { get; set; }

        /// <summary>
        /// is_recompiled
        /// </summary>
        public bool Is_recompiled { get; set; }

        /// <summary>
        /// null_on_null_input
        /// </summary>
        public bool Null_on_null_input { get; set; }

        /// <summary>
        /// execute_as_principal_id
        /// </summary>
        public int Execute_as_principal_id { get; set; }

        /// <summary>
        /// uses_native_compilation
        /// </summary>
        public bool Uses_native_compilation { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-check-constraints-transact-sql
    /// </summary>
    public class Table_sys_check_constraints
    {
        /// <summary>
        /// is_disabled
        /// </summary>
        public bool Is_disabled { get; set; }

        /// <summary>
        /// is_not_for_replication
        /// </summary>
        public bool Is_not_for_replication { get; set; }

        /// <summary>
        /// is_not_trusted
        /// </summary>
        public bool Is_not_trusted { get; set; }

        /// <summary>
        /// parent_column_id
        /// </summary>
        public int Parent_column_id { get; set; }

        /// <summary>
        /// definition
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// uses_database_collation
        /// </summary>
        public bool Uses_database_collation { get; set; }

        /// <summary>
        /// is_system_named
        /// </summary>
        public bool Is_system_named { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-default-constraints-transact-sql
    /// </summary>
    public class Table_sys_default_constraints
    {
        /// <summary>
        /// parent_column_id
        /// </summary>
        public int Parent_column_id { get; set; }

        /// <summary>
        /// Definition
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// is_system_named
        /// </summary>
        public bool Is_system_named { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-key-constraints-transact-sql
    /// </summary>
    public class Table_sys_key_constraints
    {
        /// <summary>
        /// unique_index_id
        /// </summary>
        public int Unique_index_id { get; set; }

        /// <summary>
        /// is_system_named
        /// </summary>
        public bool Is_system_named { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-foreign-keys-transact-sql
    /// </summary>
    public class Table_sys_foreign_keys
    {
        /// <summary>
        /// referenced_object_id
        /// </summary>
        public int Referenced_object_id { get; set; }

        /// <summary>
        /// key_index_id
        /// </summary>
        public int Key_index_id { get; set; }

        /// <summary>
        /// is_disabled
        /// </summary>
        public bool Is_disabled { get; set; }

        /// <summary>
        /// is_not_for_replication
        /// </summary>
        public bool Is_not_for_replication { get; set; }

        /// <summary>
        /// is_not_trusted
        /// </summary>
        public bool Is_not_trusted { get; set; }

        /// <summary>
        /// delete_referential_action
        /// </summary>
        public byte Delete_referential_action { get; set; }

        /// <summary>
        /// delete_referential_action_desc
        /// </summary>
        public string Delete_referential_action_desc { get; set; }

        /// <summary>
        /// update_referential_action
        /// </summary>
        public byte Update_referential_action { get; set; }

        /// <summary>
        /// update_referential_action_desc
        /// </summary>
        public string Update_referential_action_desc { get; set; }

        /// <summary>
        /// is_system_named
        /// </summary>
        public bool Is_system_named { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-sql-expression-dependencies-transact-sql
    /// </summary>
    public class Table_sys_sql_expression_dependencies
    {
        /// <summary>
        /// referencing_id
        /// </summary>
        public int Referencing_id { get; set; }

        /// <summary>
        /// referencing_minor_id
        /// </summary>
        public int Referencing_minor_id { get; set; }

        /// <summary>
        /// referencing_class
        /// </summary>
        public byte Referencing_class { get; set; }

        /// <summary>
        /// referencing_class_desc
        /// </summary>
        public string Referencing_class_desc { get; set; }

        /// <summary>
        /// is_schema_bound_reference
        /// </summary>
        public bool Is_schema_bound_reference { get; set; }

        /// <summary>
        /// referenced_class
        /// </summary>
        public byte Referenced_class { get; set; }

        /// <summary>
        /// referenced_class_desc
        /// </summary>
        public string Referenced_class_desc { get; set; }

        /// <summary>
        /// referenced_server_name
        /// </summary>
        public string Referenced_server_name { get; set; }

        /// <summary>
        /// referenced_database_name
        /// </summary>
        public string Referenced_database_name { get; set; }

        /// <summary>
        /// referenced_schema_name
        /// </summary>
        public string Referenced_schema_name { get; set; }

        /// <summary>
        /// referenced_entity_name
        /// </summary>
        public string Referenced_entity_name { get; set; }

        /// <summary>
        /// referenced_id
        /// </summary>
        public int Referenced_id { get; set; }

        /// <summary>
        /// referenced_minor_id
        /// </summary>
        public int Referenced_minor_id { get; set; }

        /// <summary>
        /// is_caller_dependent
        /// </summary>
        public bool Is_caller_dependent { get; set; }

        /// <summary>
        /// is_ambiguous
        /// </summary>
        public bool Is_ambiguous { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-filegroups-transact-sql
    /// </summary>
    public class Table_sys_filegroups
    {
        /// <summary>
        /// filegroup_guid
        /// </summary>
        public object Filegroup_guid { get; set; }

        /// <summary>
        /// log_filegroup_id
        /// </summary>
        public int Log_filegroup_id { get; set; }

        /// <summary>
        /// is_read_only
        /// </summary>
        public bool Is_read_only { get; set; }

        /// <summary>
        /// is_autogrow_all_files
        /// </summary>
        public bool Is_autogrow_all_files { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-database-files-transact-sql
    /// </summary>
    public class Table_sys_database_files
    {
        /// <summary>
        /// file_id
        /// </summary>
        public int File_id { get; set; }

        /// <summary>
        /// file_guid
        /// </summary>
        public object File_guid { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// type_desc
        /// </summary>
        public string Type_desc { get; set; }

        /// <summary>
        /// data_space_id
        /// </summary>
        public int Data_space_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// physical_name
        /// </summary>
        public string Physical_name { get; set; }

        /// <summary>
        /// state
        /// </summary>
        public byte State { get; set; }

        /// <summary>
        /// state_desc
        /// </summary>
        public string State_desc { get; set; }

        /// <summary>
        /// size
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// max_size
        /// </summary>
        public int Max_size { get; set; }

        /// <summary>
        /// growth
        /// </summary>
        public int Growth { get; set; }

        /// <summary>
        /// is_media_read_only
        /// </summary>
        public bool Is_media_read_only { get; set; }

        /// <summary>
        /// is_read_only
        /// </summary>
        public bool Is_read_only { get; set; }

        /// <summary>
        /// is_sparse
        /// </summary>
        public bool Is_sparse { get; set; }

        /// <summary>
        /// is_percent_growth
        /// </summary>
        public bool Is_percent_growth { get; set; }

        /// <summary>
        /// is_name_reserved
        /// </summary>
        public bool Is_name_reserved { get; set; }

        /// <summary>
        /// create_lsn
        /// </summary>
        public decimal Create_lsn { get; set; }

        /// <summary>
        /// drop_lsn
        /// </summary>
        public decimal Drop_lsn { get; set; }

        /// <summary>
        /// read_only_lsn
        /// </summary>
        public decimal Read_only_lsn { get; set; }

        /// <summary>
        /// read_write_lsn
        /// </summary>
        public decimal Read_write_lsn { get; set; }

        /// <summary>
        /// differential_base_lsn
        /// </summary>
        public decimal Differential_base_lsn { get; set; }

        /// <summary>
        /// differential_base_guid
        /// </summary>
        public object Differential_base_guid { get; set; }

        /// <summary>
        /// differential_base_time
        /// </summary>
        public DateTime Differential_base_time { get; set; }

        /// <summary>
        /// redo_start_lsn
        /// </summary>
        public decimal Redo_start_lsn { get; set; }

        /// <summary>
        /// redo_start_fork_guid
        /// </summary>
        public object Redo_start_fork_guid { get; set; }

        /// <summary>
        /// redo_target_lsn
        /// </summary>
        public decimal Redo_target_lsn { get; set; }

        /// <summary>
        /// redo_target_fork_guid
        /// </summary>
        public object Redo_target_fork_guid { get; set; }

        /// <summary>
        /// backup_lsn
        /// </summary>
        public decimal Backup_lsn { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-foreign-key-columns-transact-sql
    /// </summary>
    public class Table_sys_foreign_key_columns
    {
        /// <summary>
        /// constraint_object_id
        /// </summary>
        public int Constraint_object_id { get; set; }

        /// <summary>
        /// constraint_column_id
        /// </summary>
        public int Constraint_column_id { get; set; }

        /// <summary>
        /// parent_object_id
        /// </summary>
        public int Parent_object_id { get; set; }

        /// <summary>
        /// parent_column_id
        /// </summary>
        public int Parent_column_id { get; set; }

        /// <summary>
        /// referenced_object_id
        /// </summary>
        public int Referenced_object_id { get; set; }

        /// <summary>
        /// referenced_column_id
        /// </summary>
        public int Referenced_column_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-indexes-transact-sql
    /// </summary>
    public class Table_sys_indexes
    {
        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// index_id
        /// </summary>
        public int Index_id { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// type_desc
        /// </summary>
        public string Type_desc { get; set; }

        /// <summary>
        /// is_unique
        /// </summary>
        public bool Is_unique { get; set; }

        /// <summary>
        /// data_space_id
        /// </summary>
        public int Data_space_id { get; set; }

        /// <summary>
        /// ignore_dup_key
        /// </summary>
        public bool Ignore_dup_key { get; set; }

        /// <summary>
        /// is_primary_key
        /// </summary>
        public bool Is_primary_key { get; set; }

        /// <summary>
        /// is_unique_constraint
        /// </summary>
        public bool Is_unique_constraint { get; set; }

        /// <summary>
        /// fill_factor
        /// </summary>
        public byte Fill_factor { get; set; }

        /// <summary>
        /// is_padded
        /// </summary>
        public bool Is_padded { get; set; }

        /// <summary>
        /// is_disabled
        /// </summary>
        public bool Is_disabled { get; set; }

        /// <summary>
        /// is_hypothetical
        /// </summary>
        public bool Is_hypothetical { get; set; }

        /// <summary>
        /// allow_row_locks
        /// </summary>
        public bool Allow_row_locks { get; set; }

        /// <summary>
        /// allow_page_locks
        /// </summary>
        public bool Allow_page_locks { get; set; }

        /// <summary>
        /// has_filter
        /// </summary>
        public bool Has_filter { get; set; }

        /// <summary>
        /// filter_definition
        /// </summary>
        public string Filter_definition { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-partitions-transact-sql
    /// </summary>
    public class Table_sys_partitions
    {
        /// <summary>
        /// partition_id
        /// </summary>
        public long Partition_id { get; set; }

        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// index_id
        /// </summary>
        public int Index_id { get; set; }

        /// <summary>
        /// partition_number
        /// </summary>
        public int Partition_number { get; set; }

        /// <summary>
        /// hobt_id
        /// </summary>
        public long Hobt_id { get; set; }

        /// <summary>
        /// rows
        /// </summary>
        public long Rows { get; set; }

        /// <summary>
        /// filestream_filegroup_id
        /// </summary>
        public short Filestream_filegroup_id { get; set; }

        /// <summary>
        /// data_compression
        /// </summary>
        public byte Data_compression { get; set; }

        /// <summary>
        /// data_compression_desc
        /// </summary>
        public string Data_compression_desc { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-allocation-units-transact-sql
    /// </summary>
    public class Table_sys_allocation_units
    {
        /// <summary>
        /// allocation_unit_id
        /// </summary>
        public long Allocation_unit_id { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// type_desc
        /// </summary>
        public string Type_desc { get; set; }

        /// <summary>
        /// container_id
        /// </summary>
        public long Container_id { get; set; }

        /// <summary>
        /// data_space_id
        /// </summary>
        public int Data_space_id { get; set; }

        /// <summary>
        /// total_pages
        /// </summary>
        public long Total_pages { get; set; }

        /// <summary>
        /// used_pages
        /// </summary>
        public long Used_pages { get; set; }

        /// <summary>
        /// data_pages
        /// </summary>
        public long Data_pages { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-db-partition-stats-transact-sql
    /// </summary>
    public class Table_sys_dm_db_partition_stats
    {
        /// <summary>
        /// partition_id
        /// </summary>
        public long Partition_id { get; set; }

        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// index_id
        /// </summary>
        public int Index_id { get; set; }

        /// <summary>
        /// partition_number
        /// </summary>
        public int Partition_number { get; set; }

        /// <summary>
        /// in_row_data_page_count
        /// </summary>
        public long In_row_data_page_count { get; set; }

        /// <summary>
        /// in_row_used_page_count
        /// </summary>
        public long In_row_used_page_count { get; set; }

        /// <summary>
        /// in_row_reserved_page_count
        /// </summary>
        public long In_row_reserved_page_count { get; set; }

        /// <summary>
        /// lob_used_page_count
        /// </summary>
        public long Lob_used_page_count { get; set; }

        /// <summary>
        /// lob_reserved_page_count
        /// </summary>
        public long Lob_reserved_page_count { get; set; }

        /// <summary>
        /// row_overflow_used_page_count
        /// </summary>
        public long Row_overflow_used_page_count { get; set; }

        /// <summary>
        /// row_overflow_reserved_page_count
        /// </summary>
        public long Row_overflow_reserved_page_count { get; set; }

        /// <summary>
        /// used_page_count
        /// </summary>
        public long Used_page_count { get; set; }

        /// <summary>
        /// reserved_page_count
        /// </summary>
        public long Reserved_page_count { get; set; }

        /// <summary>
        /// row_count
        /// </summary>
        public long Row_count { get; set; }

        /// <summary>
        /// pdw_node_id
        /// </summary>
        public int Pdw_node_id { get; set; }

        /// <summary>
        /// distribution_id
        /// </summary>
        public int Distribution_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-index-columns-transact-sql
    /// </summary>
    public class Table_sys_index_columns
    {
        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// index_id
        /// </summary>
        public int Index_id { get; set; }

        /// <summary>
        /// index_column_id
        /// </summary>
        public int Index_column_id { get; set; }

        /// <summary>
        /// column_id
        /// </summary>
        public int Column_id { get; set; }

        /// <summary>
        /// key_ordinal
        /// </summary>
        public byte Key_ordinal { get; set; }

        /// <summary>
        /// partition_ordinal
        /// </summary>
        public byte Partition_ordinal { get; set; }

        /// <summary>
        /// is_descending_key
        /// </summary>
        public bool Is_descending_key { get; set; }

        /// <summary>
        /// is_included_column
        /// </summary>
        public bool Is_included_column { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-database-role-members-transact-sql
    /// </summary>
    public class Table_sys_database_role_members
    {
        /// <summary>
        /// role_principal_id
        /// </summary>
        public int Role_principal_id { get; set; }

        /// <summary>
        /// member_principal_id
        /// </summary>
        public int Member_principal_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-objects-transact-sql
    /// </summary>
    public class Table_sys_objects
    {
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// principal_id
        /// </summary>
        public int Principal_id { get; set; }

        /// <summary>
        /// schema_id
        /// </summary>
        public int Schema_id { get; set; }

        /// <summary>
        /// parent_object_id
        /// </summary>
        public int Parent_object_id { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// type_desc
        /// </summary>
        public string Type_desc { get; set; }

        /// <summary>
        /// create_date
        /// </summary>
        public DateTime Create_date { get; set; }

        /// <summary>
        /// modify_date
        /// </summary>
        public DateTime Modify_date { get; set; }

        /// <summary>
        /// is_ms_shipped
        /// </summary>
        public bool Is_ms_shipped { get; set; }

        /// <summary>
        /// is_published
        /// </summary>
        public bool Is_published { get; set; }

        /// <summary>
        /// is_schema_published
        /// </summary>
        public bool Is_schema_published { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-database-permissions-transact-sql
    /// </summary>
    public class Table_sys_database_permissions
    {
        /// <summary>
        /// class
        /// </summary>
        public byte Class { get; set; }

        /// <summary>
        /// class_desc
        /// </summary>
        public string Class_desc { get; set; }

        /// <summary>
        /// major_id
        /// </summary>
        public int Major_id { get; set; }

        /// <summary>
        /// minor_id
        /// </summary>
        public int Minor_id { get; set; }

        /// <summary>
        /// grantee_principal_id
        /// </summary>
        public int Grantee_principal_id { get; set; }

        /// <summary>
        /// grantor_principal_id
        /// </summary>
        public int Grantor_principal_id { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// permission_name
        /// </summary>
        public string Permission_name { get; set; }

        /// <summary>
        /// state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// state_desc
        /// </summary>
        public string State_desc { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-server-permissions-transact-sql
    /// </summary>
    public class Table_sys_server_permissions
    {
        /// <summary>
        /// class
        /// </summary>
        public byte Class { get; set; }

        /// <summary>
        /// class_desc
        /// </summary>
        public string Class_desc { get; set; }

        /// <summary>
        /// major_id
        /// </summary>
        public int Major_id { get; set; }

        /// <summary>
        /// minor_id
        /// </summary>
        public int Minor_id { get; set; }

        /// <summary>
        /// grantee_principal_id
        /// </summary>
        public int Grantee_principal_id { get; set; }

        /// <summary>
        /// grantor_principal_id
        /// </summary>
        public int Grantor_principal_id { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// permission_name
        /// </summary>
        public string Permission_name { get; set; }

        /// <summary>
        /// state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// state_desc
        /// </summary>
        public string State_desc { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-types-transact-sql
    /// </summary>
    public class Table_sys_types
    {
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// system_type_id
        /// </summary>
        public byte System_type_id { get; set; }

        /// <summary>
        /// user_type_id
        /// </summary>
        public int User_type_id { get; set; }

        /// <summary>
        /// schema_id
        /// </summary>
        public int Schema_id { get; set; }

        /// <summary>
        /// principal_id
        /// </summary>
        public int Principal_id { get; set; }

        /// <summary>
        /// max_length
        /// </summary>
        public short Max_length { get; set; }

        /// <summary>
        /// precision
        /// </summary>
        public byte Precision { get; set; }

        /// <summary>
        /// scale
        /// </summary>
        public byte Scale { get; set; }

        /// <summary>
        /// collation_name
        /// </summary>
        public string Collation_name { get; set; }

        /// <summary>
        /// is_nullable
        /// </summary>
        public bool Is_nullable { get; set; }

        /// <summary>
        /// is_user_defined
        /// </summary>
        public bool Is_user_defined { get; set; }

        /// <summary>
        /// is_assembly_type
        /// </summary>
        public bool Is_assembly_type { get; set; }

        /// <summary>
        /// default_object_id
        /// </summary>
        public int Default_object_id { get; set; }

        /// <summary>
        /// rule_object_id
        /// </summary>
        public int Rule_object_id { get; set; }

        /// <summary>
        /// is_table_type
        /// </summary>
        public bool Is_table_type { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-database-principals-transact-sql
    /// </summary>
    public class Table_sys_database_principals
    {
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// principal_id
        /// </summary>
        public int Principal_id { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// type_desc
        /// </summary>
        public string Type_desc { get; set; }

        /// <summary>
        /// default_schema_name
        /// </summary>
        public string Default_schema_name { get; set; }

        /// <summary>
        /// create_date
        /// </summary>
        public DateTime Create_date { get; set; }

        /// <summary>
        /// modify_date
        /// </summary>
        public DateTime Modify_date { get; set; }

        /// <summary>
        /// owning_principal_id
        /// </summary>
        public int Owning_principal_id { get; set; }

        /// <summary>
        /// sid
        /// </summary>
        public byte[] Sid { get; set; }

        /// <summary>
        /// is_fixed_role
        /// </summary>
        public bool Is_fixed_role { get; set; }

        /// <summary>
        /// authentication_type
        /// </summary>
        public int Authentication_type { get; set; }

        /// <summary>
        /// authentication_type_desc
        /// </summary>
        public string Authentication_type_desc { get; set; }

        /// <summary>
        /// default_language_name
        /// </summary>
        public string Default_language_name { get; set; }

        /// <summary>
        /// default_language_lcid
        /// </summary>
        public int Default_language_lcid { get; set; }

        /// <summary>
        /// allow_encrypted_value_modifications
        /// </summary>
        public bool Allow_encrypted_value_modifications { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-fulltext-catalogs-transact-sql
    /// </summary>
    public class Table_sys_fulltext_catalogs
    {
        /// <summary>
        /// fulltext_catalog_id
        /// </summary>
        public int Fulltext_catalog_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// is_default
        /// </summary>
        public bool Is_default { get; set; }

        /// <summary>
        /// is_accent_sensitivity_on
        /// </summary>
        public bool Is_accent_sensitivity_on { get; set; }

        /// <summary>
        /// data_space_id
        /// </summary>
        public int Data_space_id { get; set; }

        /// <summary>
        /// file_id
        /// </summary>
        public int File_id { get; set; }

        /// <summary>
        /// principal_id
        /// </summary>
        public int Principal_id { get; set; }

        /// <summary>
        /// is_importing
        /// </summary>
        public bool Is_importing { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupfile-transact-sql
    /// </summary>
    public class Table_msdb_dbo_backupfile
    {
        /// <summary>
        /// backup_set_id
        /// </summary>
        public int Backup_set_id { get; set; }

        /// <summary>
        /// first_family_number
        /// </summary>
        public byte First_family_number { get; set; }

        /// <summary>
        /// first_media_number
        /// </summary>
        public short First_media_number { get; set; }

        /// <summary>
        /// filegroup_name
        /// </summary>
        public string Filegroup_name { get; set; }

        /// <summary>
        /// page_size
        /// </summary>
        public int Page_size { get; set; }

        /// <summary>
        /// file_number
        /// </summary>
        public decimal File_number { get; set; }

        /// <summary>
        /// backed_up_page_count
        /// </summary>
        public decimal Backed_up_page_count { get; set; }

        /// <summary>
        /// file_type
        /// </summary>
        public string File_type { get; set; }

        /// <summary>
        /// source_file_block_size
        /// </summary>
        public decimal Source_file_block_size { get; set; }

        /// <summary>
        /// file_size
        /// </summary>
        public decimal File_size { get; set; }

        /// <summary>
        /// logical_name
        /// </summary>
        public string Logical_name { get; set; }

        /// <summary>
        /// physical_drive
        /// </summary>
        public string Physical_drive { get; set; }

        /// <summary>
        /// physical_name
        /// </summary>
        public string Physical_name { get; set; }

        /// <summary>
        /// state
        /// </summary>
        public byte State { get; set; }

        /// <summary>
        /// state_desc
        /// </summary>
        public string State_desc { get; set; }

        /// <summary>
        /// create_lsn
        /// </summary>
        public decimal Create_lsn { get; set; }

        /// <summary>
        /// drop_lsn
        /// </summary>
        public decimal Drop_lsn { get; set; }

        /// <summary>
        /// file_guid
        /// </summary>
        public object File_guid { get; set; }

        /// <summary>
        /// read_only_lsn
        /// </summary>
        public decimal Read_only_lsn { get; set; }

        /// <summary>
        /// read_write_lsn
        /// </summary>
        public decimal Read_write_lsn { get; set; }

        /// <summary>
        /// differential_base_lsn
        /// </summary>
        public decimal Differential_base_lsn { get; set; }

        /// <summary>
        /// differential_base_guid
        /// </summary>
        public object Differential_base_guid { get; set; }

        /// <summary>
        /// backup_size
        /// </summary>
        public decimal Backup_size { get; set; }

        /// <summary>
        /// filegroup_guid
        /// </summary>
        public object Filegroup_guid { get; set; }

        /// <summary>
        /// is_readonly
        /// </summary>
        public bool Is_readonly { get; set; }

        /// <summary>
        /// is_present
        /// </summary>
        public bool Is_present { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupfilegroup-transact-sql
    /// </summary>
    public class Table_msdb_dbo_backupfilegroup
    {
        /// <summary>
        /// backup_set_id
        /// </summary>
        public int Backup_set_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// filegroup_id
        /// </summary>
        public int Filegroup_id { get; set; }

        /// <summary>
        /// filegroup_guid
        /// </summary>
        public object Filegroup_guid { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// type_desc
        /// </summary>
        public string Type_desc { get; set; }

        /// <summary>
        /// is_default
        /// </summary>
        public bool Is_default { get; set; }

        /// <summary>
        /// is_readonly
        /// </summary>
        public bool Is_readonly { get; set; }

        /// <summary>
        /// log_filegroup_guid
        /// </summary>
        public object Log_filegroup_guid { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupmediafamily-transact-sql
    /// </summary>
    public class Table_msdb_dbo_backupmediafamily
    {
        /// <summary>
        /// media_set_id
        /// </summary>
        public int Media_set_id { get; set; }

        /// <summary>
        /// family_sequence_number
        /// </summary>
        public byte Family_sequence_number { get; set; }

        /// <summary>
        /// media_family_id
        /// </summary>
        public object Media_family_id { get; set; }

        /// <summary>
        /// media_count
        /// </summary>
        public int Media_count { get; set; }

        /// <summary>
        /// logical_device_name
        /// </summary>
        public string Logical_device_name { get; set; }

        /// <summary>
        /// physical_device_name
        /// </summary>
        public string Physical_device_name { get; set; }

        /// <summary>
        /// device_type
        /// </summary>
        public byte Device_type { get; set; }

        /// <summary>
        /// physical_block_size
        /// </summary>
        public int Physical_block_size { get; set; }

        /// <summary>
        /// mirror
        /// </summary>
        public byte Mirror { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupmediaset-transact-sql
    /// </summary>
    public class Table_msdb_dbo_backupmediaset
    {
        /// <summary>
        /// media_set_id
        /// </summary>
        public int Media_set_id { get; set; }

        /// <summary>
        /// media_uuid
        /// </summary>
        public object Media_uuid { get; set; }

        /// <summary>
        /// media_family_count
        /// </summary>
        public byte Media_family_count { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// software_name
        /// </summary>
        public string Software_name { get; set; }

        /// <summary>
        /// software_vendor_id
        /// </summary>
        public int Software_vendor_id { get; set; }

        /// <summary>
        /// MTF_major_version
        /// </summary>
        public byte MTF_major_version { get; set; }

        /// <summary>
        /// mirror_count
        /// </summary>
        public byte Mirror_count { get; set; }

        /// <summary>
        /// is_password_protected
        /// </summary>
        public bool Is_password_protected { get; set; }

        /// <summary>
        /// is_compressed
        /// </summary>
        public bool Is_compressed { get; set; }

        /// <summary>
        /// is_encrypted
        /// </summary>
        public bool Is_encrypted { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupset-transact-sql
    /// </summary>
    public class Table_msdb_dbo_backupset
    {
        /// <summary>
        /// backup_set_id
        /// </summary>
        public int Backup_set_id { get; set; }

        /// <summary>
        /// backup_set_uuid
        /// </summary>
        public object Backup_set_uuid { get; set; }

        /// <summary>
        /// media_set_id
        /// </summary>
        public int Media_set_id { get; set; }

        /// <summary>
        /// first_family_number
        /// </summary>
        public byte First_family_number { get; set; }

        /// <summary>
        /// first_media_number
        /// </summary>
        public short First_media_number { get; set; }

        /// <summary>
        /// last_family_number
        /// </summary>
        public byte Last_family_number { get; set; }

        /// <summary>
        /// last_media_number
        /// </summary>
        public short Last_media_number { get; set; }

        /// <summary>
        /// catalog_family_number
        /// </summary>
        public byte Catalog_family_number { get; set; }

        /// <summary>
        /// catalog_media_number
        /// </summary>
        public short Catalog_media_number { get; set; }

        /// <summary>
        /// position
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// expiration_date
        /// </summary>
        public DateTime Expiration_date { get; set; }

        /// <summary>
        /// software_vendor_id
        /// </summary>
        public int Software_vendor_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// user_name
        /// </summary>
        public string User_name { get; set; }

        /// <summary>
        /// software_major_version
        /// </summary>
        public byte Software_major_version { get; set; }

        /// <summary>
        /// software_minor_version
        /// </summary>
        public byte Software_minor_version { get; set; }

        /// <summary>
        /// software_build_version
        /// </summary>
        public short Software_build_version { get; set; }

        /// <summary>
        /// time_zone
        /// </summary>
        public short Time_zone { get; set; }

        /// <summary>
        /// mtf_minor_version
        /// </summary>
        public byte Mtf_minor_version { get; set; }

        /// <summary>
        /// first_lsn
        /// </summary>
        public decimal First_lsn { get; set; }

        /// <summary>
        /// last_lsn
        /// </summary>
        public decimal Last_lsn { get; set; }

        /// <summary>
        /// checkpoint_lsn
        /// </summary>
        public decimal Checkpoint_lsn { get; set; }

        /// <summary>
        /// database_backup_lsn
        /// </summary>
        public decimal Database_backup_lsn { get; set; }

        /// <summary>
        /// database_creation_date
        /// </summary>
        public DateTime Database_creation_date { get; set; }

        /// <summary>
        /// backup_start_date
        /// </summary>
        public DateTime Backup_start_date { get; set; }

        /// <summary>
        /// backup_finish_date
        /// </summary>
        public DateTime Backup_finish_date { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// sort_order
        /// </summary>
        public short Sort_order { get; set; }

        /// <summary>
        /// code_page
        /// </summary>
        public short Code_page { get; set; }

        /// <summary>
        /// compatibility_level
        /// </summary>
        public byte Compatibility_level { get; set; }

        /// <summary>
        /// database_version
        /// </summary>
        public int Database_version { get; set; }

        /// <summary>
        /// backup_size
        /// </summary>
        public decimal Backup_size { get; set; }

        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }

        /// <summary>
        /// server_name
        /// </summary>
        public string Server_name { get; set; }

        /// <summary>
        /// machine_name
        /// </summary>
        public string Machine_name { get; set; }

        /// <summary>
        /// flags
        /// </summary>
        public int Flags { get; set; }

        /// <summary>
        /// unicode_locale
        /// </summary>
        public int Unicode_locale { get; set; }

        /// <summary>
        /// unicode_compare_style
        /// </summary>
        public int Unicode_compare_style { get; set; }

        /// <summary>
        /// collation_name
        /// </summary>
        public string Collation_name { get; set; }

        /// <summary>
        /// Is_password_protected
        /// </summary>
        public bool Is_password_protected { get; set; }

        /// <summary>
        /// recovery_model
        /// </summary>
        public string Recovery_model { get; set; }

        /// <summary>
        /// has_bulk_logged_data
        /// </summary>
        public bool Has_bulk_logged_data { get; set; }

        /// <summary>
        /// is_snapshot
        /// </summary>
        public bool Is_snapshot { get; set; }

        /// <summary>
        /// is_readonly
        /// </summary>
        public bool Is_readonly { get; set; }

        /// <summary>
        /// is_single_user
        /// </summary>
        public bool Is_single_user { get; set; }

        /// <summary>
        /// has_backup_checksums
        /// </summary>
        public bool Has_backup_checksums { get; set; }

        /// <summary>
        /// is_damaged
        /// </summary>
        public bool Is_damaged { get; set; }

        /// <summary>
        /// begins_log_chain
        /// </summary>
        public bool Begins_log_chain { get; set; }

        /// <summary>
        /// has_incomplete_metadata
        /// </summary>
        public bool Has_incomplete_metadata { get; set; }

        /// <summary>
        /// is_force_offline
        /// </summary>
        public bool Is_force_offline { get; set; }

        /// <summary>
        /// is_copy_only
        /// </summary>
        public bool Is_copy_only { get; set; }

        /// <summary>
        /// first_recovery_fork_guid
        /// </summary>
        public object First_recovery_fork_guid { get; set; }

        /// <summary>
        /// last_recovery_fork_guid
        /// </summary>
        public object Last_recovery_fork_guid { get; set; }

        /// <summary>
        /// fork_point_lsn
        /// </summary>
        public decimal Fork_point_lsn { get; set; }

        /// <summary>
        /// database_guid
        /// </summary>
        public object Database_guid { get; set; }

        /// <summary>
        /// family_guid
        /// </summary>
        public object Family_guid { get; set; }

        /// <summary>
        /// differential_base_lsn
        /// </summary>
        public decimal Differential_base_lsn { get; set; }

        /// <summary>
        /// differential_base_guid
        /// </summary>
        public object Differential_base_guid { get; set; }

        /// <summary>
        /// compressed_backup_size
        /// </summary>
        public decimal Compressed_backup_size { get; set; }

        /// <summary>
        /// key_algorithm
        /// </summary>
        public string Key_algorithm { get; set; }

        /// <summary>
        /// encryptor_thumbprint
        /// </summary>
        public byte[] Encryptor_thumbprint { get; set; }

        /// <summary>
        /// encryptor_type
        /// </summary>
        public string Encryptor_type { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/logmarkhistory-transact-sql
    /// </summary>
    public class Table_msdb_dbo_logmarkhistory
    {
        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }

        /// <summary>
        /// mark_name
        /// </summary>
        public string Mark_name { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// user_name
        /// </summary>
        public string User_name { get; set; }

        /// <summary>
        /// lsn
        /// </summary>
        public decimal Lsn { get; set; }

        /// <summary>
        /// mark_time
        /// </summary>
        public DateTime Mark_time { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/restorefile-transact-sql
    /// </summary>
    public class Table_msdb_dbo_restorefile
    {
        /// <summary>
        /// restore_history_id
        /// </summary>
        public int Restore_history_id { get; set; }

        /// <summary>
        /// file_number
        /// </summary>
        public decimal File_number { get; set; }

        /// <summary>
        /// destination_phys_drive
        /// </summary>
        public string Destination_phys_drive { get; set; }

        /// <summary>
        /// destination_phys_name
        /// </summary>
        public string Destination_phys_name { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/restorefilegroup-transact-sql
    /// </summary>
    public class Table_msdb_dbo_restorefilegroup
    {
        /// <summary>
        /// restore_history_id
        /// </summary>
        public int Restore_history_id { get; set; }

        /// <summary>
        /// filegroup_name
        /// </summary>
        public string Filegroup_name { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/restorehistory-transact-sql
    /// </summary>
    public class Table_msdb_dbo_restorehistory
    {
        /// <summary>
        /// restore_history_id
        /// </summary>
        public int Restore_history_id { get; set; }

        /// <summary>
        /// restore_date
        /// </summary>
        public DateTime Restore_date { get; set; }

        /// <summary>
        /// destination_database_name
        /// </summary>
        public string Destination_database_name { get; set; }

        /// <summary>
        /// user_name
        /// </summary>
        public string User_name { get; set; }

        /// <summary>
        /// backup_set_id
        /// </summary>
        public int Backup_set_id { get; set; }

        /// <summary>
        /// restore_type
        /// </summary>
        public string Restore_type { get; set; }

        /// <summary>
        /// replace
        /// </summary>
        public bool Replace { get; set; }

        /// <summary>
        /// recovery
        /// </summary>
        public bool Recovery { get; set; }

        /// <summary>
        /// restart
        /// </summary>
        public bool Restart { get; set; }

        /// <summary>
        /// stop_at
        /// </summary>
        public DateTime Stop_at { get; set; }

        /// <summary>
        /// device_count
        /// </summary>
        public byte Device_count { get; set; }

        /// <summary>
        /// stop_at_mark_name
        /// </summary>
        public string Stop_at_mark_name { get; set; }

        /// <summary>
        /// stop_before
        /// </summary>
        public bool Stop_before { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/suspect-pages-transact-sql
    /// </summary>
    public class Table_msdb_dbo_suspect_pages
    {
        /// <summary>
        /// database_id
        /// </summary>
        public int Database_id { get; set; }

        /// <summary>
        /// file_id
        /// </summary>
        public int File_id { get; set; }

        /// <summary>
        /// page_id
        /// </summary>
        public long Page_id { get; set; }

        /// <summary>
        /// event_type
        /// </summary>
        public int Event_type { get; set; }

        /// <summary>
        /// error_count
        /// </summary>
        public int Error_count { get; set; }

        /// <summary>
        /// last_update_date
        /// </summary>
        public DateTime Last_update_date { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysopentapes-transact-sql
    /// </summary>
    public class Table_sysopentapes
    {
        /// <summary>
        /// openTape
        /// </summary>
        public string OpenTape { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysdbmaintplan-databases-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysdbmaintplan_databases
    {
        /// <summary>
        /// plan_id
        /// </summary>
        public object Plan_id { get; set; }

        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysdbmaintplan-history-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysdbmaintplan_history
    {
        /// <summary>
        /// sequence_id
        /// </summary>
        public int Sequence_id { get; set; }

        /// <summary>
        /// plan_id
        /// </summary>
        public object Plan_id { get; set; }

        /// <summary>
        /// plan_name
        /// </summary>
        public string Plan_name { get; set; }

        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }

        /// <summary>
        /// server_name
        /// </summary>
        public string Server_name { get; set; }

        /// <summary>
        /// activity
        /// </summary>
        public string Activity { get; set; }

        /// <summary>
        /// succeeded
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// end_time
        /// </summary>
        public DateTime End_time { get; set; }

        /// <summary>
        /// duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// start_time
        /// </summary>
        public DateTime Start_time { get; set; }

        /// <summary>
        /// error_number
        /// </summary>
        public int Error_number { get; set; }

        /// <summary>
        /// message
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysdbmaintplan-jobs-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysdbmaintplan_jobs
    {
        /// <summary>
        /// plan_id
        /// </summary>
        public object Plan_id { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysdbmaintplans-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysdbmaintplans
    {
        /// <summary>
        /// plan_id
        /// </summary>
        public object Plan_id { get; set; }

        /// <summary>
        /// plan_name
        /// </summary>
        public string Plan_name { get; set; }

        /// <summary>
        /// date_created
        /// </summary>
        public DateTime Date_created { get; set; }

        /// <summary>
        /// owner
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// max_history_rows
        /// </summary>
        public int Max_history_rows { get; set; }

        /// <summary>
        /// remote_history_server
        /// </summary>
        public string Remote_history_server { get; set; }

        /// <summary>
        /// max_remote_history_rows
        /// </summary>
        public int Max_remote_history_rows { get; set; }

        /// <summary>
        /// user_defined_1
        /// </summary>
        public int User_defined_1 { get; set; }

        /// <summary>
        /// user_defined_2
        /// </summary>
        public string User_defined_2 { get; set; }

        /// <summary>
        /// user_defined_3
        /// </summary>
        public DateTime User_defined_3 { get; set; }

        /// <summary>
        /// user_defined_4
        /// </summary>
        public object User_defined_4 { get; set; }

        /// <summary>
        /// log_shipping
        /// </summary>
        public bool Log_shipping { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysssislog-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysssislog
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// event
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// computer
        /// </summary>
        public string Computer { get; set; }

        /// <summary>
        /// operator
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// source
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// sourceid
        /// </summary>
        public object Sourceid { get; set; }

        /// <summary>
        /// executionid
        /// </summary>
        public object Executionid { get; set; }

        /// <summary>
        /// starttime
        /// </summary>
        public DateTime Starttime { get; set; }

        /// <summary>
        /// endtime
        /// </summary>
        public DateTime Endtime { get; set; }

        /// <summary>
        /// datacode
        /// </summary>
        public int Datacode { get; set; }

        /// <summary>
        /// databytes
        /// </summary>
        public byte[] Databytes { get; set; }

        /// <summary>
        /// message
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysssispackagefolders-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysssispackagefolders
    {
        /// <summary>
        /// folderid
        /// </summary>
        public object Folderid { get; set; }

        /// <summary>
        /// parentfolderid
        /// </summary>
        public object Parentfolderid { get; set; }

        /// <summary>
        /// foldername
        /// </summary>
        public string Foldername { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysssispackages-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysssispackages
    {
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// id
        /// </summary>
        public object Id { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// createdate
        /// </summary>
        public DateTime Createdate { get; set; }

        /// <summary>
        /// folderid
        /// </summary>
        public object Folderid { get; set; }

        /// <summary>
        /// ownersid
        /// </summary>
        public byte[] Ownersid { get; set; }

        /// <summary>
        /// packagedata
        /// </summary>
        public byte[] Packagedata { get; set; }

        /// <summary>
        /// packageformat
        /// </summary>
        public int Packageformat { get; set; }

        /// <summary>
        /// packagetype
        /// </summary>
        public int Packagetype { get; set; }

        /// <summary>
        /// vermajor
        /// </summary>
        public int Vermajor { get; set; }

        /// <summary>
        /// verminor
        /// </summary>
        public int Verminor { get; set; }

        /// <summary>
        /// verbuild
        /// </summary>
        public int Verbuild { get; set; }

        /// <summary>
        /// vercomments
        /// </summary>
        public string Vercomments { get; set; }

        /// <summary>
        /// verid
        /// </summary>
        public object Verid { get; set; }

        /// <summary>
        /// isencrypted
        /// </summary>
        public bool Isencrypted { get; set; }

        /// <summary>
        /// readrolesid
        /// </summary>
        public byte[] Readrolesid { get; set; }

        /// <summary>
        /// writerolesid
        /// </summary>
        public byte[] Writerolesid { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-alert-transact-sql
    /// </summary>
    public class Table_msdb_dbo_log_shipping_monitor_alert
    {
        /// <summary>
        /// alert_job_id
        /// </summary>
        public object Alert_job_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-error-detail-transact-sql
    /// </summary>
    public class Table_msdb_dbo_log_shipping_monitor_error_detail
    {
        /// <summary>
        /// agent_id
        /// </summary>
        public object Agent_id { get; set; }

        /// <summary>
        /// agent_type
        /// </summary>
        public byte Agent_type { get; set; }

        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }

        /// <summary>
        /// sequence_number
        /// </summary>
        public int Sequence_number { get; set; }

        /// <summary>
        /// log_time
        /// </summary>
        public DateTime Log_time { get; set; }

        /// <summary>
        /// log_time_utc
        /// </summary>
        public DateTime Log_time_utc { get; set; }

        /// <summary>
        /// message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// source
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// help_url
        /// </summary>
        public string Help_url { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-history-detail-transact-sql
    /// </summary>
    public class Table_msdb_dbo_log_shipping_monitor_history_detail
    {
        /// <summary>
        /// agent_id
        /// </summary>
        public object Agent_id { get; set; }

        /// <summary>
        /// agent_type
        /// </summary>
        public byte Agent_type { get; set; }

        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }

        /// <summary>
        /// session_status
        /// </summary>
        public byte Session_status { get; set; }

        /// <summary>
        /// log_time
        /// </summary>
        public DateTime Log_time { get; set; }

        /// <summary>
        /// log_time_utc
        /// </summary>
        public DateTime Log_time_utc { get; set; }

        /// <summary>
        /// message
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-primary-transact-sql
    /// </summary>
    public class Table_msdb_dbo_log_shipping_monitor_primary
    {
        /// <summary>
        /// primary_id
        /// </summary>
        public object Primary_id { get; set; }

        /// <summary>
        /// primary_server
        /// </summary>
        public string Primary_server { get; set; }

        /// <summary>
        /// primary_database
        /// </summary>
        public string Primary_database { get; set; }

        /// <summary>
        /// backup_threshold
        /// </summary>
        public int Backup_threshold { get; set; }

        /// <summary>
        /// threshold_alert
        /// </summary>
        public int Threshold_alert { get; set; }

        /// <summary>
        /// threshold_alert_enabled
        /// </summary>
        public bool Threshold_alert_enabled { get; set; }

        /// <summary>
        /// last_backup_file
        /// </summary>
        public string Last_backup_file { get; set; }

        /// <summary>
        /// last_backup_date
        /// </summary>
        public DateTime Last_backup_date { get; set; }

        /// <summary>
        /// last_backup_date_utc
        /// </summary>
        public DateTime Last_backup_date_utc { get; set; }

        /// <summary>
        /// history_retention_period
        /// </summary>
        public int History_retention_period { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-secondary-transact-sql
    /// </summary>
    public class Table_msdb_dbo_log_shipping_monitor_secondary
    {
        /// <summary>
        /// secondary_server
        /// </summary>
        public string Secondary_server { get; set; }

        /// <summary>
        /// secondary_database
        /// </summary>
        public string Secondary_database { get; set; }

        /// <summary>
        /// secondary_id
        /// </summary>
        public object Secondary_id { get; set; }

        /// <summary>
        /// primary_server
        /// </summary>
        public string Primary_server { get; set; }

        /// <summary>
        /// primary_database
        /// </summary>
        public string Primary_database { get; set; }

        /// <summary>
        /// restore_threshold
        /// </summary>
        public int Restore_threshold { get; set; }

        /// <summary>
        /// threshold_alert
        /// </summary>
        public int Threshold_alert { get; set; }

        /// <summary>
        /// threshold_alert_enabled
        /// </summary>
        public bool Threshold_alert_enabled { get; set; }

        /// <summary>
        /// last_copied_file
        /// </summary>
        public string Last_copied_file { get; set; }

        /// <summary>
        /// last_copied_date
        /// </summary>
        public DateTime Last_copied_date { get; set; }

        /// <summary>
        /// last_copied_date_utc
        /// </summary>
        public DateTime Last_copied_date_utc { get; set; }

        /// <summary>
        /// last_restored_file
        /// </summary>
        public string Last_restored_file { get; set; }

        /// <summary>
        /// last_restored_date
        /// </summary>
        public DateTime Last_restored_date { get; set; }

        /// <summary>
        /// last_restored_date_utc
        /// </summary>
        public DateTime Last_restored_date_utc { get; set; }

        /// <summary>
        /// last_restored_latency
        /// </summary>
        public int Last_restored_latency { get; set; }

        /// <summary>
        /// history_retention_period
        /// </summary>
        public int History_retention_period { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-primary-databases-transact-sql
    /// </summary>
    public class Table_msdb_dbo_log_shipping_primary_databases
    {
        /// <summary>
        /// primary_id
        /// </summary>
        public object Primary_id { get; set; }

        /// <summary>
        /// primary_database
        /// </summary>
        public string Primary_database { get; set; }

        /// <summary>
        /// backup_directory
        /// </summary>
        public string Backup_directory { get; set; }

        /// <summary>
        /// backup_share
        /// </summary>
        public string Backup_share { get; set; }

        /// <summary>
        /// backup_retention_period
        /// </summary>
        public int Backup_retention_period { get; set; }

        /// <summary>
        /// backup_job_id
        /// </summary>
        public object Backup_job_id { get; set; }

        /// <summary>
        /// monitor_server
        /// </summary>
        public string Monitor_server { get; set; }

        /// <summary>
        /// monitor_server_security_mode
        /// </summary>
        public bool Monitor_server_security_mode { get; set; }

        /// <summary>
        /// last_backup_file
        /// </summary>
        public string Last_backup_file { get; set; }

        /// <summary>
        /// last_backup_date
        /// </summary>
        public DateTime Last_backup_date { get; set; }

        /// <summary>
        /// user_specified_monitor
        /// </summary>
        public bool User_specified_monitor { get; set; }

        /// <summary>
        /// backup_compression
        /// </summary>
        public byte Backup_compression { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-primary-secondaries-transact-sql
    /// </summary>
    public class Table_msdb_dbo_log_shipping_primary_secondaries
    {
        /// <summary>
        /// primary_id
        /// </summary>
        public object Primary_id { get; set; }

        /// <summary>
        /// secondary_server
        /// </summary>
        public string Secondary_server { get; set; }

        /// <summary>
        /// secondary_database
        /// </summary>
        public string Secondary_database { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-secondary-transact-sql
    /// </summary>
    public class Table_msdb_dbo_log_shipping_secondary
    {
        /// <summary>
        /// secondary_id
        /// </summary>
        public object Secondary_id { get; set; }

        /// <summary>
        /// primary_server
        /// </summary>
        public string Primary_server { get; set; }

        /// <summary>
        /// primary_database
        /// </summary>
        public string Primary_database { get; set; }

        /// <summary>
        /// backup_source_directory
        /// </summary>
        public string Backup_source_directory { get; set; }

        /// <summary>
        /// backup_destination_directory
        /// </summary>
        public string Backup_destination_directory { get; set; }

        /// <summary>
        /// file_retention_period
        /// </summary>
        public int File_retention_period { get; set; }

        /// <summary>
        /// copy_job_id
        /// </summary>
        public object Copy_job_id { get; set; }

        /// <summary>
        /// restore_job_id
        /// </summary>
        public object Restore_job_id { get; set; }

        /// <summary>
        /// monitor_server
        /// </summary>
        public string Monitor_server { get; set; }

        /// <summary>
        /// monitor_server_security_mode
        /// </summary>
        public bool Monitor_server_security_mode { get; set; }

        /// <summary>
        /// last_copied_file
        /// </summary>
        public string Last_copied_file { get; set; }

        /// <summary>
        /// last_copied_date
        /// </summary>
        public DateTime Last_copied_date { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-secondary-databases-transact-sql
    /// </summary>
    public class Table_msdb_dbo_log_shipping_secondary_databases
    {
        /// <summary>
        /// secondary_database
        /// </summary>
        public string Secondary_database { get; set; }

        /// <summary>
        /// secondary_id
        /// </summary>
        public object Secondary_id { get; set; }

        /// <summary>
        /// restore_delay
        /// </summary>
        public int Restore_delay { get; set; }

        /// <summary>
        /// restore_all
        /// </summary>
        public bool Restore_all { get; set; }

        /// <summary>
        /// restore_mode
        /// </summary>
        public bool Restore_mode { get; set; }

        /// <summary>
        /// disconnect_users
        /// </summary>
        public bool Disconnect_users { get; set; }

        /// <summary>
        /// block_size
        /// </summary>
        public int Block_size { get; set; }

        /// <summary>
        /// buffer_count
        /// </summary>
        public int Buffer_count { get; set; }

        /// <summary>
        /// max_transfer_size
        /// </summary>
        public int Max_transfer_size { get; set; }

        /// <summary>
        /// last_restored_file
        /// </summary>
        public string Last_restored_file { get; set; }

        /// <summary>
        /// last_restored_date
        /// </summary>
        public DateTime Last_restored_date { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysalerts-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysalerts
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// event_source
        /// </summary>
        public string Event_source { get; set; }

        /// <summary>
        /// event_category_id
        /// </summary>
        public int Event_category_id { get; set; }

        /// <summary>
        /// event_id
        /// </summary>
        public int Event_id { get; set; }

        /// <summary>
        /// message_id
        /// </summary>
        public int Message_id { get; set; }

        /// <summary>
        /// severity
        /// </summary>
        public int Severity { get; set; }

        /// <summary>
        /// enabled
        /// </summary>
        public byte Enabled { get; set; }

        /// <summary>
        /// delay_between_responses
        /// </summary>
        public int Delay_between_responses { get; set; }

        /// <summary>
        /// last_occurrence_date
        /// </summary>
        public int Last_occurrence_date { get; set; }

        /// <summary>
        /// last_occurrence_time
        /// </summary>
        public int Last_occurrence_time { get; set; }

        /// <summary>
        /// last_response_date
        /// </summary>
        public int Last_response_date { get; set; }

        /// <summary>
        /// last_response_time
        /// </summary>
        public int Last_response_time { get; set; }

        /// <summary>
        /// notification_message
        /// </summary>
        public string Notification_message { get; set; }

        /// <summary>
        /// include_event_description
        /// </summary>
        public byte Include_event_description { get; set; }

        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }

        /// <summary>
        /// event_description_keyword
        /// </summary>
        public string Event_description_keyword { get; set; }

        /// <summary>
        /// occurrence_count
        /// </summary>
        public int Occurrence_count { get; set; }

        /// <summary>
        /// count_reset_date
        /// </summary>
        public int Count_reset_date { get; set; }

        /// <summary>
        /// count_reset_time
        /// </summary>
        public int Count_reset_time { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// has_notification
        /// </summary>
        public int Has_notification { get; set; }

        /// <summary>
        /// flags
        /// </summary>
        public int Flags { get; set; }

        /// <summary>
        /// performance_condition
        /// </summary>
        public string Performance_condition { get; set; }

        /// <summary>
        /// category_id
        /// </summary>
        public int Category_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-syscategories-transact-sql
    /// </summary>
    public class Table_msdb_dbo_syscategories
    {
        /// <summary>
        /// category_id
        /// </summary>
        public int Category_id { get; set; }

        /// <summary>
        /// category_class
        /// </summary>
        public int Category_class { get; set; }

        /// <summary>
        /// category_type
        /// </summary>
        public byte Category_type { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysdownloadlist-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysdownloadlist
    {
        /// <summary>
        /// instance_id
        /// </summary>
        public int Instance_id { get; set; }

        /// <summary>
        /// source_server
        /// </summary>
        public string Source_server { get; set; }

        /// <summary>
        /// operation_code
        /// </summary>
        public byte Operation_code { get; set; }

        /// <summary>
        /// object_type
        /// </summary>
        public byte Object_type { get; set; }

        /// <summary>
        /// object_id
        /// </summary>
        public object Object_id { get; set; }

        /// <summary>
        /// target_server
        /// </summary>
        public string Target_server { get; set; }

        /// <summary>
        /// error_message
        /// </summary>
        public string Error_message { get; set; }

        /// <summary>
        /// date_posted
        /// </summary>
        public DateTime Date_posted { get; set; }

        /// <summary>
        /// date_downloaded
        /// </summary>
        public DateTime Date_downloaded { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// deleted_object_name
        /// </summary>
        public string Deleted_object_name { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobactivity-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysjobactivity
    {
        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// run_requested_date
        /// </summary>
        public DateTime Run_requested_date { get; set; }

        /// <summary>
        /// run_requested_source
        /// </summary>
        public string Run_requested_source { get; set; }

        /// <summary>
        /// queued_date
        /// </summary>
        public DateTime Queued_date { get; set; }

        /// <summary>
        /// start_execution_date
        /// </summary>
        public DateTime Start_execution_date { get; set; }

        /// <summary>
        /// last_executed_step_id
        /// </summary>
        public int Last_executed_step_id { get; set; }

        /// <summary>
        /// date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// stop_execution_date
        /// </summary>
        public DateTime Stop_execution_date { get; set; }

        /// <summary>
        /// job_history_id
        /// </summary>
        public int Job_history_id { get; set; }

        /// <summary>
        /// next_scheduled_run_date
        /// </summary>
        public DateTime Next_scheduled_run_date { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobhistory-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysjobhistory
    {
        /// <summary>
        /// instance_id
        /// </summary>
        public int Instance_id { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// step_id
        /// </summary>
        public int Step_id { get; set; }

        /// <summary>
        /// step_name
        /// </summary>
        public string Step_name { get; set; }

        /// <summary>
        /// sql_message_id
        /// </summary>
        public int Sql_message_id { get; set; }

        /// <summary>
        /// sql_severity
        /// </summary>
        public int Sql_severity { get; set; }

        /// <summary>
        /// message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// run_status
        /// </summary>
        public int Run_status { get; set; }

        /// <summary>
        /// run_date
        /// </summary>
        public int Run_date { get; set; }

        /// <summary>
        /// run_time
        /// </summary>
        public int Run_time { get; set; }

        /// <summary>
        /// run_duration
        /// </summary>
        public int Run_duration { get; set; }

        /// <summary>
        /// operator_id_emailed
        /// </summary>
        public int Operator_id_emailed { get; set; }

        /// <summary>
        /// operator_id_netsent
        /// </summary>
        public int Operator_id_netsent { get; set; }

        /// <summary>
        /// operator_id_paged
        /// </summary>
        public int Operator_id_paged { get; set; }

        /// <summary>
        /// retries_attempted
        /// </summary>
        public int Retries_attempted { get; set; }

        /// <summary>
        /// server
        /// </summary>
        public string Server { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobs-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysjobs
    {
        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// originating_server_id
        /// </summary>
        public int Originating_server_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// enabled
        /// </summary>
        public byte Enabled { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// start_step_id
        /// </summary>
        public int Start_step_id { get; set; }

        /// <summary>
        /// category_id
        /// </summary>
        public int Category_id { get; set; }

        /// <summary>
        /// owner_sid
        /// </summary>
        public byte[] Owner_sid { get; set; }

        /// <summary>
        /// notify_level_eventlog
        /// </summary>
        public int Notify_level_eventlog { get; set; }

        /// <summary>
        /// notify_level_email
        /// </summary>
        public int Notify_level_email { get; set; }

        /// <summary>
        /// notify_level_netsend
        /// </summary>
        public int Notify_level_netsend { get; set; }

        /// <summary>
        /// notify_level_page
        /// </summary>
        public int Notify_level_page { get; set; }

        /// <summary>
        /// notify_email_operator_id
        /// </summary>
        public int Notify_email_operator_id { get; set; }

        /// <summary>
        /// notify_netsend_operator_id
        /// </summary>
        public int Notify_netsend_operator_id { get; set; }

        /// <summary>
        /// notify_page_operator_id
        /// </summary>
        public int Notify_page_operator_id { get; set; }

        /// <summary>
        /// delete_level
        /// </summary>
        public int Delete_level { get; set; }

        /// <summary>
        /// date_created
        /// </summary>
        public DateTime Date_created { get; set; }

        /// <summary>
        /// date_modified
        /// </summary>
        public DateTime Date_modified { get; set; }

        /// <summary>
        /// version_number
        /// </summary>
        public int Version_number { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobschedules-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysjobschedules
    {
        /// <summary>
        /// schedule_id
        /// </summary>
        public int Schedule_id { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// next_run_date
        /// </summary>
        public int Next_run_date { get; set; }

        /// <summary>
        /// next_run_time
        /// </summary>
        public int Next_run_time { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobservers-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysjobservers
    {
        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// server_id
        /// </summary>
        public int Server_id { get; set; }

        /// <summary>
        /// last_run_outcome
        /// </summary>
        public byte Last_run_outcome { get; set; }

        /// <summary>
        /// last_outcome_ message
        /// </summary>
        public string Last_outcome_message { get; set; }

        /// <summary>
        /// last_run_date
        /// </summary>
        public int Last_run_date { get; set; }

        /// <summary>
        /// last_run_time
        /// </summary>
        public int Last_run_time { get; set; }

        /// <summary>
        /// last_run_duration
        /// </summary>
        public int Last_run_duration { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobsteps-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysjobsteps
    {
        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// step_id
        /// </summary>
        public int Step_id { get; set; }

        /// <summary>
        /// step_name
        /// </summary>
        public string Step_name { get; set; }

        /// <summary>
        /// subsystem
        /// </summary>
        public string Subsystem { get; set; }

        /// <summary>
        /// command
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// flags
        /// </summary>
        public int Flags { get; set; }

        /// <summary>
        /// additional_parameters
        /// </summary>
        public byte[] Additional_parameters { get; set; }

        /// <summary>
        /// cmdexec_success_code
        /// </summary>
        public int Cmdexec_success_code { get; set; }

        /// <summary>
        /// on_success_action
        /// </summary>
        public byte On_success_action { get; set; }

        /// <summary>
        /// on_success_step_id
        /// </summary>
        public int On_success_step_id { get; set; }

        /// <summary>
        /// on_fail_action
        /// </summary>
        public byte On_fail_action { get; set; }

        /// <summary>
        /// on_fail_step_id
        /// </summary>
        public int On_fail_step_id { get; set; }

        /// <summary>
        /// server
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// database_name
        /// </summary>
        public string Database_name { get; set; }

        /// <summary>
        /// database_user_name
        /// </summary>
        public string Database_user_name { get; set; }

        /// <summary>
        /// retry_attempts
        /// </summary>
        public int Retry_attempts { get; set; }

        /// <summary>
        /// retry_interval
        /// </summary>
        public int Retry_interval { get; set; }

        /// <summary>
        /// os_run_priority
        /// </summary>
        public int Os_run_priority { get; set; }

        /// <summary>
        /// output_file_name
        /// </summary>
        public string Output_file_name { get; set; }

        /// <summary>
        /// last_run_outcome
        /// </summary>
        public int Last_run_outcome { get; set; }

        /// <summary>
        /// last_run_duration
        /// </summary>
        public int Last_run_duration { get; set; }

        /// <summary>
        /// last_run_retries
        /// </summary>
        public int Last_run_retries { get; set; }

        /// <summary>
        /// last_run_date
        /// </summary>
        public int Last_run_date { get; set; }

        /// <summary>
        /// last_run_time
        /// </summary>
        public int Last_run_time { get; set; }

        /// <summary>
        /// proxy_id
        /// </summary>
        public int Proxy_id { get; set; }

        /// <summary>
        /// step_uid
        /// </summary>
        public object Step_uid { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobstepslogs-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysjobstepslogs
    {
        /// <summary>
        /// log_id
        /// </summary>
        public int Log_id { get; set; }

        /// <summary>
        /// log
        /// </summary>
        public string Log { get; set; }

        /// <summary>
        /// date_created
        /// </summary>
        public DateTime Date_created { get; set; }

        /// <summary>
        /// date_modified
        /// </summary>
        public DateTime Date_modified { get; set; }

        /// <summary>
        /// log_size
        /// </summary>
        public int Log_size { get; set; }

        /// <summary>
        /// step_uid
        /// </summary>
        public object Step_uid { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysnotifications-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysnotifications
    {
        /// <summary>
        /// alert_id
        /// </summary>
        public int Alert_id { get; set; }

        /// <summary>
        /// operator_id
        /// </summary>
        public int Operator_id { get; set; }

        /// <summary>
        /// notification_method
        /// </summary>
        public byte Notification_method { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysoperators-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysoperators
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// enabled
        /// </summary>
        public byte Enabled { get; set; }

        /// <summary>
        /// email_address
        /// </summary>
        public string Email_address { get; set; }

        /// <summary>
        /// last_email_date
        /// </summary>
        public int Last_email_date { get; set; }

        /// <summary>
        /// last_email_time
        /// </summary>
        public int Last_email_time { get; set; }

        /// <summary>
        /// pager_address
        /// </summary>
        public string Pager_address { get; set; }

        /// <summary>
        /// last_pager_date
        /// </summary>
        public int Last_pager_date { get; set; }

        /// <summary>
        /// last_pager_time
        /// </summary>
        public int Last_pager_time { get; set; }

        /// <summary>
        /// weekday_pager_start_time
        /// </summary>
        public int Weekday_pager_start_time { get; set; }

        /// <summary>
        /// weekday_pager_end_time
        /// </summary>
        public int Weekday_pager_end_time { get; set; }

        /// <summary>
        /// saturday_pager_start_time
        /// </summary>
        public int Saturday_pager_start_time { get; set; }

        /// <summary>
        /// saturday_pager_end_time
        /// </summary>
        public int Saturday_pager_end_time { get; set; }

        /// <summary>
        /// sunday_pager_start_time
        /// </summary>
        public int Sunday_pager_start_time { get; set; }

        /// <summary>
        /// sunday_pager_end_time
        /// </summary>
        public int Sunday_pager_end_time { get; set; }

        /// <summary>
        /// pager_days
        /// </summary>
        public byte Pager_days { get; set; }

        /// <summary>
        /// netsend_address
        /// </summary>
        public string Netsend_address { get; set; }

        /// <summary>
        /// last_netsend_date
        /// </summary>
        public int Last_netsend_date { get; set; }

        /// <summary>
        /// last_netsend_time
        /// </summary>
        public int Last_netsend_time { get; set; }

        /// <summary>
        /// category_id
        /// </summary>
        public int Category_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysproxies-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysproxies
    {
        /// <summary>
        /// proxy_id
        /// </summary>
        public int Proxy_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// credential_id
        /// </summary>
        public int Credential_id { get; set; }

        /// <summary>
        /// enabled
        /// </summary>
        public byte Enabled { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// user_sid
        /// </summary>
        public byte[] User_sid { get; set; }

        /// <summary>
        /// credential_date_created
        /// </summary>
        public DateTime Credential_date_created { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysproxylogin-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysproxylogin
    {
        /// <summary>
        /// proxy_id
        /// </summary>
        public int Proxy_id { get; set; }

        /// <summary>
        /// sid
        /// </summary>
        public byte[] Sid { get; set; }

        /// <summary>
        /// principal_id
        /// </summary>
        public int Principal_id { get; set; }

        /// <summary>
        /// flags
        /// </summary>
        public int Flags { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysproxysubsystem-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysproxysubsystem
    {
        /// <summary>
        /// subsystem_id
        /// </summary>
        public int Subsystem_id { get; set; }

        /// <summary>
        /// proxy_id
        /// </summary>
        public int Proxy_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysschedules-transact-sql
    /// </summary>
    public class Table_msdb_dbo_sysschedules
    {
        /// <summary>
        /// schedule_id
        /// </summary>
        public int Schedule_id { get; set; }

        /// <summary>
        /// schedule_uid
        /// </summary>
        public object Schedule_uid { get; set; }

        /// <summary>
        /// originating_server_id
        /// </summary>
        public int Originating_server_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// owner_sid
        /// </summary>
        public byte[] Owner_sid { get; set; }

        /// <summary>
        /// enabled
        /// </summary>
        public int Enabled { get; set; }

        /// <summary>
        /// freq_type
        /// </summary>
        public int Freq_type { get; set; }

        /// <summary>
        /// freq_interval
        /// </summary>
        public int Freq_interval { get; set; }

        /// <summary>
        /// freq_subday_type
        /// </summary>
        public int Freq_subday_type { get; set; }

        /// <summary>
        /// freq_subday_interval
        /// </summary>
        public int Freq_subday_interval { get; set; }

        /// <summary>
        /// freq_relative_interval
        /// </summary>
        public int Freq_relative_interval { get; set; }

        /// <summary>
        /// factor
        /// </summary>
        public int Factor { get; set; }

        /// <summary>
        /// active_start_date
        /// </summary>
        public int Active_start_date { get; set; }

        /// <summary>
        /// active_end_date
        /// </summary>
        public int Active_end_date { get; set; }

        /// <summary>
        /// active_start_time
        /// </summary>
        public int Active_start_time { get; set; }

        /// <summary>
        /// active_end_time
        /// </summary>
        public int Active_end_time { get; set; }

        /// <summary>
        /// date_created
        /// </summary>
        public DateTime Date_created { get; set; }

        /// <summary>
        /// date_modified
        /// </summary>
        public DateTime Date_modified { get; set; }

        /// <summary>
        /// version_number
        /// </summary>
        public int Version_number { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-syssessions-transact-sql
    /// </summary>
    public class Table_msdb_dbo_syssessions
    {
        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// agent_start_date
        /// </summary>
        public DateTime Agent_start_date { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-syssubsystems-transact-sql
    /// </summary>
    public class Table_msdb_dbo_syssubsystems
    {
        /// <summary>
        /// subsystem_id
        /// </summary>
        public int Subsystem_id { get; set; }

        /// <summary>
        /// subsystem
        /// </summary>
        public string Subsystem { get; set; }

        /// <summary>
        /// description_id
        /// </summary>
        public int Description_id { get; set; }

        /// <summary>
        /// subsystem_dll
        /// </summary>
        public string Subsystem_dll { get; set; }

        /// <summary>
        /// agent_exe
        /// </summary>
        public string Agent_exe { get; set; }

        /// <summary>
        /// start_entry_point
        /// </summary>
        public string Start_entry_point { get; set; }

        /// <summary>
        /// event_entry_point
        /// </summary>
        public string Event_entry_point { get; set; }

        /// <summary>
        /// stop_entry_point
        /// </summary>
        public string Stop_entry_point { get; set; }

        /// <summary>
        /// max_worker_threads
        /// </summary>
        public int Max_worker_threads { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-systargetservergroupmembers-transact-sql
    /// </summary>
    public class Table_msdb_dbo_systargetservergroupmembers
    {
        /// <summary>
        /// servergroup_id
        /// </summary>
        public int Servergroup_id { get; set; }

        /// <summary>
        /// server_id
        /// </summary>
        public int Server_id { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-systargetservergroups-transact-sql
    /// </summary>
    public class Table_msdb_dbo_systargetservergroups
    {
        /// <summary>
        /// servergroup_id
        /// </summary>
        public int Servergroup_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-systargetservers-transact-sql
    /// </summary>
    public class Table_msdb_dbo_systargetservers
    {
        /// <summary>
        /// server_id
        /// </summary>
        public int Server_id { get; set; }

        /// <summary>
        /// server_name
        /// </summary>
        public string Server_name { get; set; }

        /// <summary>
        /// location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// time_zone_adjustment
        /// </summary>
        public int Time_zone_adjustment { get; set; }

        /// <summary>
        /// enlist_date
        /// </summary>
        public DateTime Enlist_date { get; set; }

        /// <summary>
        /// last_poll_date
        /// </summary>
        public DateTime Last_poll_date { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// local_time_at_last_poll
        /// </summary>
        public DateTime Local_time_at_last_poll { get; set; }

        /// <summary>
        /// enlisted_by_nt_user
        /// </summary>
        public string Enlisted_by_nt_user { get; set; }

        /// <summary>
        /// poll_internal
        /// </summary>
        public int Poll_internal { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-systaskids-transact-sql
    /// </summary>
    public class Table_msdb_dbo_systaskids
    {
        /// <summary>
        /// task_id
        /// </summary>
        public int Task_id { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }
    }
}