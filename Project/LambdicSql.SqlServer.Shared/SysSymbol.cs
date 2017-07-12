using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Server provides the following groups of system functions.
    /// </summary>
    public class SysSymbol
    {
        //--------------------------
        //Always On Availability Groups Functions
        //--------------------------

        /// <summary>
        /// sys.fn_hadr_is_primary_replica
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-hadr-is-primary-replica-transact-sql
        /// </summary>
        /// <param name="dbname">db name</param>
        /// <returns>1 or 0.</returns>
        [FuncStyleConverter(Name = "sys.fn_hadr_is_primary_replica")]
        public int fn_hadr_is_primary_replica(string dbname) => throw new InvalitContextException(nameof(fn_hadr_is_primary_replica));

        /// <summary>
        /// sys.fn_hadr_backup_is_preferred_replica
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-hadr-backup-is-preferred-replica-transact-sql
        /// </summary>
        /// <param name="dbname">db name</param>
        /// <returns>1 or 0.</returns>
        [FuncStyleConverter(Name = "sys.fn_hadr_backup_is_preferred_replica")]
        public int fn_hadr_backup_is_preferred_replica(string dbname) => throw new InvalitContextException(nameof(fn_hadr_backup_is_preferred_replica));

        /// <summary>
        /// sys.fn_hadr_distributed_ag_replica 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-hadr-backup-is-preferred-replica-transact-sql
        /// </summary>
        /// <param name="lag_Id">Is the identifier of the distributed availability group. lag_Id is type uniqueidentifier.</param>
        /// <param name="replica_id">Is the identifier of a replica in the distributed availability group. replica_id is type uniqueidentifier.</param>
        /// <returns>Returns the following information.</returns>
        [FuncStyleConverter(Name = "sys.fn_hadr_backup_is_preferred_replica")]
        public object fn_hadr_distributed_ag_replica(string lag_Id, string replica_id) => throw new InvalitContextException(nameof(fn_hadr_distributed_ag_replica));

        /// <summary>
        /// sys.fn_hadr_distributed_ag_database_replica  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-hadr-distributed-ag-database-replica-transact-sql
        /// </summary>
        /// <param name="lag_Id">Is the identifier of the distributed availability group. lag_Id is type uniqueidentifier.</param>
        /// <param name="replica_id">Is the identifier of the database in a distributed availability group. database_id is type uniqueidentifier.</param>
        /// <returns>ID of the database in the local availability group.</returns>
        [FuncStyleConverter(Name = "sys.fn_hadr_distributed_ag_database_replica")]
        public object fn_hadr_distributed_ag_database_replica(string lag_Id, string replica_id) => throw new InvalitContextException(nameof(fn_hadr_distributed_ag_database_replica));

        //--------------------------
        //Change Data Capture Functions
        //--------------------------
        /// <summary>
        /// sys.fn_cdc_decrement_lsn
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-decrement-lsn-transact-sql
        /// </summary>
        /// <param name="lsn_value">LSN value. lsn_value is binary(10).</param>
        /// <returns>binary(10).</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_decrement_lsn")]
        public byte[] fn_cdc_decrement_lsn(byte[] lsn_value) => throw new InvalitContextException(nameof(fn_cdc_decrement_lsn));

        /// <summary>
        /// sys.fn_cdc_get_column_ordinal 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-decrement-lsn-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the name of the capture instance in which the specified column is identified as a captured column. capture_instance is sysname.</param>
        /// <param name="column_name">Is the column to report on. column_name is sysname.</param>
        /// <returns>int</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_decrement_lsn")]
        public int fn_cdc_get_column_ordinal(string capture_instance, string column_name) => throw new InvalitContextException(nameof(fn_cdc_get_column_ordinal));

        /// <summary>
        /// sys.fn_cdc_get_max_lsn 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-get-max-lsn-transact-sql
        /// </summary>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_get_max_lsn")]
        public byte[] fn_cdc_get_max_lsn() => throw new InvalitContextException(nameof(fn_cdc_get_max_lsn));

        /// <summary>
        /// sys.fn_cdc_get_min_lsn 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-get-min-lsn-transact-sql
        /// </summary>
        /// <param name="capture_instance_name">Is the name of the capture instance. capture_instance_name is sysname.</param>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_get_min_lsn")]
        public byte[] fn_cdc_get_min_lsn(string capture_instance_name) => throw new InvalitContextException(nameof(fn_cdc_get_min_lsn));

        /// <summary>
        /// sys.fn_cdc_has_column_changed 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-has-column-changed-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the name of the capture instance. capture_instance is sysname.</param>
        /// <param name="column_name">Is the captured column of the specified capture instance to report on. column_name is sysname.</param>
        /// <param name="update_mask">Is the mask identifying updated columns in any associated change row. update_mask is varbinary(128).</param>
        /// <returns>bit(An integer data type that can take a value of 1, 0, or NULL.)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_has_column_changed")]
        public bool? fn_cdc_has_column_changed(string capture_instance, string column_name, byte[] update_mask) => throw new InvalitContextException(nameof(fn_cdc_has_column_changed));

        /// <summary>
        /// sys.fn_cdc_increment_lsn 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-increment-lsn-transact-sql
        /// </summary>
        /// <param name="lsn_value ">LSN value. lsn_value is binary(10).</param>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_increment_lsn")]
        public byte[] fn_cdc_increment_lsn(byte[] lsn_value) => throw new InvalitContextException(nameof(fn_cdc_increment_lsn));

        /// <summary>
        /// sys.fn_cdc_is_bit_set  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-is-bit-set-transact-sql
        /// </summary>
        /// <param name="position">Is the ordinal position in the mask to check. position is int.</param>
        /// <param name="update_mask">Is the mask identifying updated columns. update_mask is varbinary(128).</param>
        /// <returns>bit</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_is_bit_set")]
        public bool? fn_cdc_is_bit_set(int position, byte[] update_mask) => throw new InvalitContextException(nameof(fn_cdc_is_bit_set));

        /// <summary>
        /// sys.fn_cdc_map_lsn_to_time  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-map-lsn-to-time-transact-sql
        /// </summary>
        /// <param name="lsn_value">Is the LSN value to match against. lsn_value is binary(10).</param>
        /// <returns>datetime</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_map_lsn_to_time")]
        public DateTime fn_cdc_map_lsn_to_time(byte[] lsn_value) => throw new InvalitContextException(nameof(fn_cdc_map_lsn_to_time));

        /// <summary>
        /// sys.fn_cdc_map_time_to_lsn  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-cdc-map-time-to-lsn-transact-sql
        /// </summary>
        /// <param name="relational_operator">Is used to identify a distinct LSN value in within the cdc.lsn_time_mapping table with an associated tran_end_time that satisfies the relation when compared to the tracking_time value.</param>
        /// <param name="tracking_time">Is the datetime value to match against. tracking_time is datetime.</param>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_cdc_map_time_to_lsn")]
        public byte[] fn_cdc_map_time_to_lsn(string relational_operator, DateTime tracking_time) => throw new InvalitContextException(nameof(fn_cdc_map_time_to_lsn));

        /// <summary>
        /// sys.fn_all_changes_capture_instance  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-all-changes-capture-instance-transact-sql
        /// </summary>
        /// <param name="capture_instance_name">capture instance name.</param>
        /// <param name="start_time">The datetime value that represents the low endpoint of the range of change table entries to include in the result set.</param>
        /// <param name="end_time">The datetime value that represents the high endpoint of the range of change table entries to include in the result set.</param>
        /// <param name="row_filter_option">This parameter can take on one of two possible meanings depending on the value chosen for @closed_high_end_point when sys.sp_cdc_generate_wrapper_function is called to generate the create script for the wrapper function.</param>
        /// <returns>Type of destination</returns>
        [MethodFormatConverter(Format = "sys.fn_all_changes_[0]([1], [2], [3])")]
        public object fn_all_changes_capture_instance(string capture_instance_name, DateTime start_time, DateTime end_time, string row_filter_option) => throw new InvalitContextException(nameof(fn_all_changes_capture_instance));

        /// <summary>
        /// sys.fn_net_changes_capture_instance  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-net-changes-capture-instance-transact-sql
        /// </summary>
        /// <param name="capture_instance_name">capture instance name.</param>
        /// <param name="start_time">The datetime value that represents the low endpoint of the range of change table entries to include in the result set.</param>
        /// <param name="end_time">The datetime value that represents the high endpoint of the range of change table entries to include in the result set.</param>
        /// <param name="row_filter_option">This parameter can take on one of two meanings, depending on the value chosen for @closed_high_end_point when sys.sp_cdc_generate_wrapper_function is called to generate the script to create the wrapper function.</param>
        /// <returns>Table Returned</returns>
        [MethodFormatConverter(Format = "sys.fn_net_changes_[0]([1], [2], [3])")]
        public object fn_net_changes_capture_instance(string capture_instance_name, DateTime start_time, DateTime end_time, string row_filter_option) => throw new InvalitContextException(nameof(fn_net_changes_capture_instance));

        /// <summary>
        /// sys.fn_get_sql  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-get-sql-transact-sql
        /// </summary>
        /// <param name="SqlHandle">Is the handle value. SqlHandle is varbinary(64) with no default.</param>
        /// <returns>binary(10)</returns>
        [FuncStyleConverter(Name = "sys.fn_get_sql")]
        public object fn_get_sql(byte[] SqlHandle) => throw new InvalitContextException(nameof(fn_get_sql));

        /// <summary>
        /// sys.fn_MSxe_read_event_stream  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-msxe-read-event-stream-transact-sql
        /// </summary>
        /// <param name="session_name">The name of a session that is running on the server.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_MSxe_read_event_stream")]
        public object fn_MSxe_read_event_stream(string session_name) => throw new InvalitContextException(nameof(fn_MSxe_read_event_stream));

        /// <summary>
        /// sys.fn_stmt_sql_handle_from_sql_stmt  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-stmt-sql-handle-from-sql-stmt-transact-sql
        /// </summary>
        /// <param name="query_sql_text">Is the text of the query in the query store that you want the handle of.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_stmt_sql_handle_from_sql_stmt")]
        public object fn_stmt_sql_handle_from_sql_stmt(string query_sql_text) => throw new InvalitContextException(nameof(fn_stmt_sql_handle_from_sql_stmt));

        /// <summary>
        /// sys.fn_stmt_sql_handle_from_sql_stmt  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-stmt-sql-handle-from-sql-stmt-transact-sql
        /// </summary>
        /// <param name="query_sql_text">Is the text of the query in the query store that you want the handle of.</param>
        /// <param name="query_param_type">Is the parameter type of the query. query_param_type is a tinyint.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_stmt_sql_handle_from_sql_stmt")]
        public object fn_stmt_sql_handle_from_sql_stmt(string query_sql_text, byte? query_param_type) => throw new InvalitContextException(nameof(fn_stmt_sql_handle_from_sql_stmt));

        /// <summary>
        /// sys.fn_validate_plan_guide  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-validate-plan-guide-transact-sql
        /// </summary>
        /// <param name="plan_guide_id">Is the ID of the plan guide as reported in the sys.plan_guides catalog view. plan_guide_id is int with no default.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_validate_plan_guide")]
        public object fn_validate_plan_guide(int plan_guide_id) => throw new InvalitContextException(nameof(fn_validate_plan_guide));

        /// <summary>
        /// sys.fn_xe_file_target_read_file  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-xe-file-target-read-file-transact-sql
        /// </summary>
        /// <param name="path">The path to the files to read. path can contain wildcards and include the name of a file.</param>
        /// <param name="mdpath">The path to the metadata file that corresponds to the file or files specified by the path argument.</param>
        /// <param name="initial_file_name">The first file to read from path.</param>
        /// <param name="initial_offset">Used to specify last offset read previously and skips all events up to the offset (inclusive)..</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_xe_file_target_read_file")]
        public object fn_xe_file_target_read_file(string path, string mdpath, string initial_file_name, int? initial_offset) => throw new InvalitContextException(nameof(fn_xe_file_target_read_file));

        /// <summary>
        /// sys.fn_db_backup_file_snapshots  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-db-backup-file-snapshots-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_db_backup_file_snapshots")]
        public object fn_db_backup_file_snapshots() => throw new InvalitContextException(nameof(fn_db_backup_file_snapshots));

        /// <summary>
        /// sys.fn_db_backup_file_snapshots  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-db-backup-file-snapshots-transact-sql
        /// </summary>
        /// <param name="database_name">The name of the database being queried.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_db_backup_file_snapshots")]
        public object fn_db_backup_file_snapshots(string database_name) => throw new InvalitContextException(nameof(fn_db_backup_file_snapshots));

        //--------------------------
        //System Metadata Functions
        //--------------------------
        /// <summary>
        /// sys.fn_helpcollations  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-helpcollations-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_helpcollations")]
        public object fn_helpcollations() => throw new InvalitContextException(nameof(fn_helpcollations));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty() => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1_object_type">Is the type of level 1 object.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name, object level1_object_type) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1_object_type">Is the type of level 1 object.</param>
        /// <param name="level1_object_name">Is the name of the level 1 object type specified.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name, object level1_object_type, object level1_object_name) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1_object_type">Is the type of level 1 object.</param>
        /// <param name="level1_object_name">Is the name of the level 1 object type specified.</param>
        /// <param name="level2_object_type">Is the type of level 2 object.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name, object level1_object_type, object level1_object_name, object level2_object_type) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_listextendedproperty  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-listextendedproperty-transact-sql
        /// </summary>
        /// <param name="property_name">Is the name of the property.</param>
        /// <param name="level0_object_type">Is the user or user-defined type.</param>
        /// <param name="level0_object_name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1_object_type">Is the type of level 1 object.</param>
        /// <param name="level1_object_name">Is the name of the level 1 object type specified.</param>
        /// <param name="level2_object_type">Is the type of level 2 object.</param>
        /// <param name="level2_object_name">Is the name of the level 2 object type specified.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_listextendedproperty")]
        public object fn_listextendedproperty(object property_name, object level0_object_type, object level0_object_name, object level1_object_type, object level1_object_name, object level2_object_type, object level2_object_name) => throw new InvalitContextException(nameof(fn_listextendedproperty));

        /// <summary>
        /// sys.fn_servershareddrives  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-servershareddrives-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_servershareddrives")]
        public object fn_servershareddrives() => throw new InvalitContextException(nameof(fn_servershareddrives));

        /// <summary>
        /// sys.fn_virtualfilestats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-virtualfilestats-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_virtualfilestats")]
        public object fn_virtualfilestats() => throw new InvalitContextException(nameof(fn_virtualfilestats));

        /// <summary>
        /// sys.fn_virtualfilestats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-virtualfilestats-transact-sql
        /// </summary>
        /// <param name="database_id">Is the ID of the database.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_virtualfilestats")]
        public object fn_virtualfilestats(int? database_id) => throw new InvalitContextException(nameof(fn_virtualfilestats));

        /// <summary>
        /// sys.fn_virtualfilestats  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-virtualfilestats-transact-sql
        /// </summary>
        /// <param name="database_id">Is the ID of the database.</param>
        /// <param name="file_id">Is the ID of the file.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_virtualfilestats")]
        public object fn_virtualfilestats(int? database_id, int? file_id) => throw new InvalitContextException(nameof(fn_virtualfilestats));

        /// <summary>
        /// sys.fn_virtualservernodes  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-virtualservernodes-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_virtualservernodes")]
        public object fn_virtualservernodes() => throw new InvalitContextException(nameof(fn_virtualservernodes));

        //--------------------------
        //System Security Functions
        //--------------------------
        /// <summary>
        /// sys.fn_builtin_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-builtin-permissions-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_builtin_permissions")]
        public object fn_builtin_permissions() => throw new InvalitContextException(nameof(fn_builtin_permissions));

        /// <summary>
        /// sys.fn_builtin_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-builtin-permissions-transact-sql
        /// </summary>
        /// <param name="default">When it is called with the DEFAULT option (without quotes), the function will return a complete list of built in permissions.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_builtin_permissions")]
        public object fn_builtin_permissions<T>(T @default) => throw new InvalitContextException(nameof(fn_builtin_permissions));

        /// <summary>
        /// sys.fn_builtin_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-builtin-permissions-transact-sql
        /// </summary>
        /// <param name="default">When it is called with the DEFAULT option (without quotes), the function will return a complete list of built in permissions.</param>
        /// <param name="empty_string">Equivalent to DEFAULT.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_builtin_permissions")]
        public object fn_builtin_permissions<T>(T @default, T empty_string) => throw new InvalitContextException(nameof(fn_builtin_permissions));

        /// <summary>
        /// sys.fn_builtin_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-builtin-permissions-transact-sql
        /// </summary>
        /// <param name="default">When it is called with the DEFAULT option (without quotes), the function will return a complete list of built in permissions.</param>
        /// <param name="empty_string">Equivalent to DEFAULT.</param>
        /// <param name="securable_class">When it is called with the name of one securable class, sys.fn_builtin_permissions will return all permissions that apply to the class.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_builtin_permissions")]
        public object fn_builtin_permissions<T>(T @default, T empty_string, string securable_class) => throw new InvalitContextException(nameof(fn_builtin_permissions));

        /// <summary>
        /// sys.fn_check_object_signatures  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-check-object-signatures-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_check_object_signatures")]
        public object fn_check_object_signatures() => throw new InvalitContextException(nameof(fn_check_object_signatures));

        /// <summary>
        /// sys.fn_check_object_signatures  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-check-object-signatures-transact-sql
        /// </summary>
        /// <param name="class">Identifies the type of thumbprint being provided.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_check_object_signatures")]
        public object fn_check_object_signatures(string @class) => throw new InvalitContextException(nameof(fn_check_object_signatures));

        /// <summary>
        /// sys.fn_check_object_signatures  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-check-object-signatures-transact-sql
        /// </summary>
        /// <param name="class">Identifies the type of thumbprint being provided.</param>
        /// <param name="thumbprint">SHA-1 hash of the certificate with which the key is encrypted, or the GUID of the asymmetric key with which the key is encrypted.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_check_object_signatures")]
        public object fn_check_object_signatures(string @class, string thumbprint) => throw new InvalitContextException(nameof(fn_check_object_signatures));

        /// <summary>
        /// sys.fn_get_audit_file  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-get-audit-file-transact-sql
        /// </summary>
        /// <param name="file_pattern">Specifies the directory or path and file name for the audit file set to be read.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_get_audit_file")]
        public object fn_get_audit_file(string file_pattern) => throw new InvalitContextException(nameof(fn_get_audit_file));

        /// <summary>
        /// sys.fn_get_audit_file  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-get-audit-file-transact-sql
        /// </summary>
        /// <param name="file_pattern">Specifies the directory or path and file name for the audit file set to be read.</param>
        /// <param name="initial_file_name">Specifies the path and name of a specific file in the audit file set to start reading audit records from.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_get_audit_file")]
        public object fn_get_audit_file(string file_pattern, string initial_file_name) => throw new InvalitContextException(nameof(fn_get_audit_file));

        /// <summary>
        /// sys.fn_get_audit_file  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-get-audit-file-transact-sql
        /// </summary>
        /// <param name="file_pattern">Specifies the directory or path and file name for the audit file set to be read.</param>
        /// <param name="initial_file_name">Specifies the path and name of a specific file in the audit file set to start reading audit records from.</param>
        /// <param name="audit_record_offset">Specifies a known location with the file specified for the initial_file_name.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_get_audit_file")]
        public object fn_get_audit_file(string file_pattern, string initial_file_name, string audit_record_offset) => throw new InvalitContextException(nameof(fn_get_audit_file));

        /// <summary>
        /// sys.fn_my_permissions  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-my-permissions-transact-sql
        /// </summary>
        /// <param name="securable">Is the name of the securable. If the securable is the server or a database, this value should be set to NULL.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_my_permissions")]
        public object fn_my_permissions(string securable) => throw new InvalitContextException(nameof(fn_my_permissions));

        //--------------------------
        //System Trace Functions
        //--------------------------
        /// <summary>
        /// sys.fn_trace_geteventinfo  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-trace-geteventinfo-transact-sql
        /// </summary>
        /// <param name="trace_id">Is the ID of the trace.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_trace_geteventinfo")]
        public object fn_trace_geteventinfo(int trace_id) => throw new InvalitContextException(nameof(fn_trace_geteventinfo));

        /// <summary>
        /// sys.fn_trace_getfilterinfo  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-trace-getfilterinfo-transact-sql
        /// </summary>
        /// <param name="trace_id">Is the ID of the trace.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_trace_getfilterinfo")]
        public object fn_trace_getfilterinfo(int trace_id) => throw new InvalitContextException(nameof(fn_trace_getfilterinfo));

        /// <summary>
        /// sys.fn_trace_getinfo  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-trace-getfilterinfo-transact-sql
        /// </summary>
        /// <param name="trace_id">Is the ID of the trace.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_trace_getinfo")]
        public object fn_trace_getinfo(object trace_id) => throw new InvalitContextException(nameof(fn_trace_getinfo));

        /// <summary>
        /// sys.fn_trace_gettable  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-trace-gettable-transact-sql
        /// </summary>
        /// <param name="filename">Specifies the initial trace file to be read.</param>
        /// <param name="number_files">Specifies the number of rollover files to be read.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "sys.fn_trace_gettable")]
        public object fn_trace_gettable(string filename, int? number_files) => throw new InvalitContextException(nameof(fn_trace_gettable));

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
        public bool sp_cdc_add_job(string job_type, bool? start_job) => throw new InvalitContextException(nameof(sp_cdc_add_job));

        /// <summary>
        /// sys.sp_cdc_add_job  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-add-job-transact-sql
        /// </summary>
        /// <param name="job_type">Type of job to add.</param>
        /// <param name="start_job">Flag indicating whether the job should be started immediately after it is added.</param>
        /// <param name="maxtrans">Maximum number of transactions to process in each scan cycle.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_add_job")]
        public bool sp_cdc_add_job(string job_type, bool? start_job, int maxtrans) => throw new InvalitContextException(nameof(sp_cdc_add_job));

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
        public bool sp_cdc_add_job(string job_type, bool? start_job, int maxtrans, int maxscans) => throw new InvalitContextException(nameof(sp_cdc_add_job));

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
        public bool sp_cdc_add_job(string job_type, bool? start_job, int maxtrans, int maxscans, bool? continuous) => throw new InvalitContextException(nameof(sp_cdc_add_job));

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
        public bool sp_cdc_add_job(string job_type, bool? start_job, int maxtrans, int maxscans, bool? continuous, long pollinginterval) => throw new InvalitContextException(nameof(sp_cdc_add_job));

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
        public bool sp_cdc_add_job(string job_type, bool? start_job, int maxtrans, int maxscans, bool? continuous, long pollinginterval, long retention) => throw new InvalitContextException(nameof(sp_cdc_add_job));

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
        public bool sp_cdc_add_job(string job_type, bool? start_job, int maxtrans, int maxscans, bool? continuous, long pollinginterval, long retention, long threshold) => throw new InvalitContextException(nameof(sp_cdc_add_job));

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
        public bool sp_cdc_change_job(string job_type, int? maxtrans, int? maxscans, bool? continuous) => throw new InvalitContextException(nameof(sp_cdc_change_job));

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
        public bool sp_cdc_change_job(string job_type, int? maxtrans, int? maxscans, bool? continuous, long? pollinginterval) => throw new InvalitContextException(nameof(sp_cdc_change_job));

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
        public bool sp_cdc_change_job(string job_type, int? maxtrans, int? maxscans, bool? continuous, long? pollinginterval, long? retention) => throw new InvalitContextException(nameof(sp_cdc_change_job));

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
        public bool sp_cdc_change_job(string job_type, int? maxtrans, int? maxscans, bool? continuous, long? pollinginterval, long? retention, long? threshold) => throw new InvalitContextException(nameof(sp_cdc_change_job));

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
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, bool? supports_net_changes) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

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
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, bool? supports_net_changes, string role_name) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

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
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, bool? supports_net_changes, string role_name, string index_name) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

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
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, bool? supports_net_changes, string role_name, string index_name, string captured_column_list) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

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
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, bool? supports_net_changes, string role_name, string index_name, string captured_column_list, string filegroup_name) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

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
        public bool sp_cdc_enable_table(string source_schema, string source_name, string capture_instance, bool? supports_net_changes, string role_name, string index_name, string captured_column_list, string filegroup_name, bool allow_partition_switch) => throw new InvalitContextException(nameof(sp_cdc_enable_table));

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
        public bool sp_cdc_generate_wrapper_function(string capture_instance, bool? closed_high_end_point) => throw new InvalitContextException(nameof(sp_cdc_generate_wrapper_function));

        /// <summary>
        /// sys.sp_cdc_generate_wrapper_function  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sys-sp-cdc-generate-wrapper-function-transact-sql
        /// </summary>
        /// <param name="capture_instance">Is the capture instance that scripts are to be generated for.</param>
        /// <param name="closed_high_end_point">Is the flag bit that indicates whether changes that have a commit time equal to the high endpoint are to be included within the extraction interval by the generated procedure.</param>
        /// <param name="column_list">Is a list of captured columns to be included in the result set that is returned by the wrapper function.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter(Name = "sys.sp_cdc_generate_wrapper_function")]
        public bool sp_cdc_generate_wrapper_function(string capture_instance, bool? closed_high_end_point, string column_list) => throw new InvalitContextException(nameof(sp_cdc_generate_wrapper_function));

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
        public bool sp_cdc_generate_wrapper_function(string capture_instance, bool? closed_high_end_point, string column_list, string update_flag_list) => throw new InvalitContextException(nameof(sp_cdc_generate_wrapper_function));

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







        /// <summary>
        /// Contains one row for each Extended Events action that is mapped to a SQL Trace column ID. This table is stored in the master database, in the sys schema.
        /// </summary>
        [MemberTableConverter(Name = "sys.trace_xe_action_map")]
        public Table_trace_xe_action_map trace_xe_action_map => throw new InvalitContextException(nameof(trace_xe_action_map));
    }

    /// <summary>
    /// Contains one row for each Extended Events action that is mapped to a SQL Trace column ID. This table is stored in the master database, in the sys schema.
    /// </summary>
    public class Table_trace_xe_action_map
    {
        /// <summary>
        /// The ID of the SQL Trace column that is being mapped.
        /// </summary>
        public short trace_column_id { get; set; }

        /// <summary>
        /// The name of the Extended Events package where the mapped action resides.
        /// </summary>
        public string package_name { get; set; }

        /// <summary>
        /// The name of the Extended Events action that is mapped to the SQL Trace column.
        /// </summary>
        public string xe_action_name { get; set; }
    }
}
