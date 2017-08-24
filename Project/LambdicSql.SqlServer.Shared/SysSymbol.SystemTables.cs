using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //TODO 
    //Change Data Capture Tables(Transact-SQL)
    //Replication Tables

        //@@@
    /// <summary>
    /// SQL Server provides the following groups of system functions.
    /// </summary>
    public partial class SysSymbol
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/extended-events-tables-trace-xe-action-map
        /// sys.trace_xe_action_map
        /// </summary>
        [MemberTableConverter(Name = "sys.trace_xe_action_map")]
        public Table_sys_trace_xe_action_map Trace_xe_action_map => throw new InvalitContextException(nameof(Trace_xe_action_map));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/extended-events-tables-trace-xe-event-map
        /// sys.trace_xe_event_map
        /// </summary>
        [MemberTableConverter(Name = "sys.trace_xe_event_map")]
        public Table_sys_trace_xe_event_map Trace_xe_event_map => throw new InvalitContextException(nameof(Trace_xe_event_map));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-master-files-transact-sql
        /// sys.master_files
        /// </summary>
        [MemberTableConverter(Name = "sys.master_files")]
        public Table_sys_master_files Master_files => throw new InvalitContextException(nameof(Master_files));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-cached-plans-transact-sql
        /// sys.dm_exec_cached_plans
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_cached_plans")]
        public Table_sys_dm_exec_cached_plans Dm_exec_cached_plans => throw new InvalitContextException(nameof(Dm_exec_cached_plans));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-plan-attributes-transact-sql
        /// sys.dm_exec_plan_attributes
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_plan_attributes")]
        public Table_sys_dm_exec_plan_attributes Dm_exec_plan_attributes => throw new InvalitContextException(nameof(Dm_exec_plan_attributes));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-sql-text-transact-sql
        /// sys.dm_exec_sql_text
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_sql_text")]
        public Table_sys_dm_exec_sql_text Dm_exec_sql_text => throw new InvalitContextException(nameof(Dm_exec_sql_text));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-query-stats-transact-sql
        /// sys.dm_exec_query_stats
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_query_stats")]
        public Table_sys_dm_exec_query_stats Dm_exec_query_stats => throw new InvalitContextException(nameof(Dm_exec_query_stats));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-requests-transact-sql
        /// sys.dm_exec_requests
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_requests")]
        public Table_sys_dm_exec_requests Dm_exec_requests => throw new InvalitContextException(nameof(Dm_exec_requests));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-cursors-transact-sql
        /// sys.dm_exec_cursors
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_cursors")]
        public Table_sys_dm_exec_cursors Dm_exec_cursors => throw new InvalitContextException(nameof(Dm_exec_cursors));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-xml-handles-transact-sql
        /// sys.dm_exec_xml_handles
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_xml_handles")]
        public Table_sys_dm_exec_xml_handles Dm_exec_xml_handles => throw new InvalitContextException(nameof(Dm_exec_xml_handles));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-query-memory-grants-transact-sql
        /// sys.dm_exec_query_memory_grants
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_query_memory_grants")]
        public Table_sys_dm_exec_query_memory_grants Dm_exec_query_memory_grants => throw new InvalitContextException(nameof(Dm_exec_query_memory_grants));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-connections-transact-sql
        /// sys.dm_exec_connections
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_connections")]
        public Table_sys_dm_exec_connections Dm_exec_connections => throw new InvalitContextException(nameof(Dm_exec_connections));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-cached-plan-dependent-objects-transact-sql
        /// sys.dm_exec_cached_plan_dependent_objects
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_cached_plan_dependent_objects")]
        public Table_sys_dm_exec_cached_plan_dependent_objects Dm_exec_cached_plan_dependent_objects => throw new InvalitContextException(nameof(Dm_exec_cached_plan_dependent_objects));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-compatibility-views/sys-syscharsets-transact-sql
        /// sys.syscharsets
        /// </summary>
        [MemberTableConverter(Name = "sys.syscharsets")]
        public Table_sys_syscharsets Syscharsets => throw new InvalitContextException(nameof(Syscharsets));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-configurations-transact-sql
        /// sys.configurations
        /// </summary>
        [MemberTableConverter(Name = "sys.configurations")]
        public Table_sys_configurations Configurations => throw new InvalitContextException(nameof(Configurations));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-databases-transact-sql
        /// sys.databases
        /// </summary>
        [MemberTableConverter(Name = "sys.databases")]
        public Table_sys_databases Databases => throw new InvalitContextException(nameof(Databases));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-backup-devices-transact-sql
        /// sys.backup_devices
        /// </summary>
        [MemberTableConverter(Name = "sys.backup_devices")]
        public Table_sys_backup_devices Backup_devices => throw new InvalitContextException(nameof(Backup_devices));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-compatibility-views/sys-syslanguages-transact-sql
        /// sys.syslanguages
        /// </summary>
        [MemberTableConverter(Name = "sys.syslanguages")]
        public Table_sys_syslanguages Syslanguages => throw new InvalitContextException(nameof(Syslanguages));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-tran-locks-transact-sql
        /// sys.dm_tran_locks
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_tran_locks")]
        public Table_sys_dm_tran_locks Dm_tran_locks => throw new InvalitContextException(nameof(Dm_tran_locks));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-server-principals-transact-sql
        /// sys.server_principals
        /// </summary>
        [MemberTableConverter(Name = "sys.server_principals")]
        public Table_sys_server_principals Server_principals => throw new InvalitContextException(nameof(Server_principals));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-sql-logins-transact-sql
        /// sys.sql_logins
        /// </summary>
        [MemberTableConverter(Name = "sys.sql_logins")]
        public Table_sys_sql_logins Sql_logins => throw new InvalitContextException(nameof(Sql_logins));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/messages-for-errors-catalog-views-sys-messages
        /// sys.messages
        /// </summary>
        [MemberTableConverter(Name = "sys.messages")]
        public Table_sys_messages Messages => throw new InvalitContextException(nameof(Messages));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-linked-logins-transact-sql
        /// sys.linked_logins
        /// </summary>
        [MemberTableConverter(Name = "sys.linked_logins")]
        public Table_sys_linked_logins Linked_logins => throw new InvalitContextException(nameof(Linked_logins));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-io-backup-tapes-transact-sql
        /// sys.dm_io_backup_tapes
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_io_backup_tapes")]
        public Table_sys_dm_io_backup_tapes Dm_io_backup_tapes => throw new InvalitContextException(nameof(Dm_io_backup_tapes));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-os-performance-counters-transact-sql
        /// sys.dm_os_performance_counters
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_os_performance_counters")]
        public Table_sys_dm_os_performance_counters Dm_os_performance_counters => throw new InvalitContextException(nameof(Dm_os_performance_counters));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-sessions-transact-sql
        /// sys.dm_exec_sessions
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_exec_sessions")]
        public Table_sys_dm_exec_sessions Dm_exec_sessions => throw new InvalitContextException(nameof(Dm_exec_sessions));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-remote-logins-transact-sql
        /// sys.remote_logins
        /// </summary>
        [MemberTableConverter(Name = "sys.remote_logins")]
        public Table_sys_remote_logins Remote_logins => throw new InvalitContextException(nameof(Remote_logins));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-servers-transact-sql
        /// sys.servers
        /// </summary>
        [MemberTableConverter(Name = "sys.servers")]
        public Table_sys_servers Servers => throw new InvalitContextException(nameof(Servers));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-io-virtual-file-stats-transact-sql
        /// sys.dm_io_virtual_file_stats
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_io_virtual_file_stats")]
        public Table_sys_dm_io_virtual_file_stats Dm_io_virtual_file_stats => throw new InvalitContextException(nameof(Dm_io_virtual_file_stats));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-columns-transact-sql
        /// sys.columns
        /// </summary>
        [MemberTableConverter(Name = "sys.columns")]
        public Table_sys_columns Columns => throw new InvalitContextException(nameof(Columns));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-sql-modules-transact-sql
        /// sys.sql_modules
        /// </summary>
        [MemberTableConverter(Name = "sys.sql_modules")]
        public Table_sys_sql_modules Sql_modules => throw new InvalitContextException(nameof(Sql_modules));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-check-constraints-transact-sql
        /// sys.check_constraints
        /// </summary>
        [MemberTableConverter(Name = "sys.check_constraints")]
        public Table_sys_check_constraints Check_constraints => throw new InvalitContextException(nameof(Check_constraints));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-default-constraints-transact-sql
        /// sys.default_constraints
        /// </summary>
        [MemberTableConverter(Name = "sys.default_constraints")]
        public Table_sys_default_constraints Default_constraints => throw new InvalitContextException(nameof(Default_constraints));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-key-constraints-transact-sql
        /// sys.key_constraints
        /// </summary>
        [MemberTableConverter(Name = "sys.key_constraints")]
        public Table_sys_key_constraints Key_constraints => throw new InvalitContextException(nameof(Key_constraints));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-foreign-keys-transact-sql
        /// sys.foreign_keys
        /// </summary>
        [MemberTableConverter(Name = "sys.foreign_keys")]
        public Table_sys_foreign_keys Foreign_keys => throw new InvalitContextException(nameof(Foreign_keys));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-sql-expression-dependencies-transact-sql
        /// sys.sql_expression_dependencies
        /// </summary>
        [MemberTableConverter(Name = "sys.sql_expression_dependencies")]
        public Table_sys_sql_expression_dependencies Sql_expression_dependencies => throw new InvalitContextException(nameof(Sql_expression_dependencies));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-filegroups-transact-sql
        /// sys.filegroups
        /// </summary>
        [MemberTableConverter(Name = "sys.filegroups")]
        public Table_sys_filegroups Filegroups => throw new InvalitContextException(nameof(Filegroups));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-database-files-transact-sql
        /// sys.database_files
        /// </summary>
        [MemberTableConverter(Name = "sys.database_files")]
        public Table_sys_database_files Database_files => throw new InvalitContextException(nameof(Database_files));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-foreign-key-columns-transact-sql
        /// sys.foreign_key_columns
        /// </summary>
        [MemberTableConverter(Name = "sys.foreign_key_columns")]
        public Table_sys_foreign_key_columns Foreign_key_columns => throw new InvalitContextException(nameof(Foreign_key_columns));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-indexes-transact-sql
        /// sys.indexes
        /// </summary>
        [MemberTableConverter(Name = "sys.indexes")]
        public Table_sys_indexes Indexes => throw new InvalitContextException(nameof(Indexes));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-partitions-transact-sql
        /// sys.partitions
        /// </summary>
        [MemberTableConverter(Name = "sys.partitions")]
        public Table_sys_partitions Partitions => throw new InvalitContextException(nameof(Partitions));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-allocation-units-transact-sql
        /// sys.allocation_units
        /// </summary>
        [MemberTableConverter(Name = "sys.allocation_units")]
        public Table_sys_allocation_units Allocation_units => throw new InvalitContextException(nameof(Allocation_units));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-db-partition-stats-transact-sql
        /// sys.dm_db_partition_stats
        /// </summary>
        [MemberTableConverter(Name = "sys.dm_db_partition_stats")]
        public Table_sys_dm_db_partition_stats Dm_db_partition_stats => throw new InvalitContextException(nameof(Dm_db_partition_stats));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-index-columns-transact-sql
        /// sys.index_columns
        /// </summary>
        [MemberTableConverter(Name = "sys.index_columns")]
        public Table_sys_index_columns Index_columns => throw new InvalitContextException(nameof(Index_columns));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-database-role-members-transact-sql
        /// sys.database_role_members
        /// </summary>
        [MemberTableConverter(Name = "sys.database_role_members")]
        public Table_sys_database_role_members Database_role_members => throw new InvalitContextException(nameof(Database_role_members));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-objects-transact-sql
        /// sys.objects
        /// </summary>
        [MemberTableConverter(Name = "sys.objects")]
        public Table_sys_objects Objects => throw new InvalitContextException(nameof(Objects));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-database-permissions-transact-sql
        /// sys.database_permissions
        /// </summary>
        [MemberTableConverter(Name = "sys.database_permissions")]
        public Table_sys_database_permissions Database_permissions => throw new InvalitContextException(nameof(Database_permissions));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-server-permissions-transact-sql
        /// sys.server_permissions
        /// </summary>
        [MemberTableConverter(Name = "sys.server_permissions")]
        public Table_sys_server_permissions Server_permissions => throw new InvalitContextException(nameof(Server_permissions));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-types-transact-sql
        /// sys.types
        /// </summary>
        [MemberTableConverter(Name = "sys.types")]
        public Table_sys_types Types => throw new InvalitContextException(nameof(Types));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-database-principals-transact-sql
        /// sys.database_principals
        /// </summary>
        [MemberTableConverter(Name = "sys.database_principals")]
        public Table_sys_database_principals Database_principals => throw new InvalitContextException(nameof(Database_principals));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-catalog-views/sys-fulltext-catalogs-transact-sql
        /// sys.fulltext_catalogs
        /// </summary>
        [MemberTableConverter(Name = "sys.fulltext_catalogs")]
        public Table_sys_fulltext_catalogs Fulltext_catalogs => throw new InvalitContextException(nameof(Fulltext_catalogs));
    }
}
