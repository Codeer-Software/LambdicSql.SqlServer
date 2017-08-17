using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Server provides the following groups of dbo functions.
    /// </summary>
    public class DboSymbol
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/data-tier-application-tables-sysdac-history-internal
        /// msdb.dbo.sysdac_history_internal
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysdac_history_internal")]
        public Table_msdb_dbo_sysdac_history_internal Sysdac_history_internal => throw new InvalitContextException(nameof(Sysdac_history_internal));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/data-tier-application-tables-sysdac-instances-internal
        /// msdb.dbo.sysdac_instances_internal
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysdac_instances_internal")]
        public Table_msdb_dbo_sysdac_instances_internal Sysdac_instances_internal => throw new InvalitContextException(nameof(Sysdac_instances_internal));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupfile-transact-sql
        /// msdb.dbo.backupfile
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.backupfile")]
        public Table_msdb_dbo_backupfile Backupfile => throw new InvalitContextException(nameof(Backupfile));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupfilegroup-transact-sql
        /// msdb.dbo.backupfilegroup
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.backupfilegroup")]
        public Table_msdb_dbo_backupfilegroup Backupfilegroup => throw new InvalitContextException(nameof(Backupfilegroup));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupmediafamily-transact-sql
        /// msdb.dbo.backupmediafamily
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.backupmediafamily")]
        public Table_msdb_dbo_backupmediafamily Backupmediafamily => throw new InvalitContextException(nameof(Backupmediafamily));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupmediaset-transact-sql
        /// msdb.dbo.backupmediaset
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.backupmediaset")]
        public Table_msdb_dbo_backupmediaset Backupmediaset => throw new InvalitContextException(nameof(Backupmediaset));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/backupset-transact-sql
        /// msdb.dbo.backupset
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.backupset")]
        public Table_msdb_dbo_backupset Backupset => throw new InvalitContextException(nameof(Backupset));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/logmarkhistory-transact-sql
        /// msdb.dbo.logmarkhistory
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.logmarkhistory")]
        public Table_msdb_dbo_logmarkhistory Logmarkhistory => throw new InvalitContextException(nameof(Logmarkhistory));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/restorefile-transact-sql
        /// msdb.dbo.restorefile
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.restorefile")]
        public Table_msdb_dbo_restorefile Restorefile => throw new InvalitContextException(nameof(Restorefile));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/restorefilegroup-transact-sql
        /// msdb.dbo.restorefilegroup
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.restorefilegroup")]
        public Table_msdb_dbo_restorefilegroup Restorefilegroup => throw new InvalitContextException(nameof(Restorefilegroup));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/restorehistory-transact-sql
        /// msdb.dbo.restorehistory
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.restorehistory")]
        public Table_msdb_dbo_restorehistory Restorehistory => throw new InvalitContextException(nameof(Restorehistory));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/suspect-pages-transact-sql
        /// msdb.dbo.suspect_pages
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.suspect_pages")]
        public Table_msdb_dbo_suspect_pages Suspect_pages => throw new InvalitContextException(nameof(Suspect_pages));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysdbmaintplan-databases-transact-sql
        /// msdb.dbo.sysdbmaintplan_databases
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysdbmaintplan_databases")]
        public Table_msdb_dbo_sysdbmaintplan_databases Sysdbmaintplan_databases => throw new InvalitContextException(nameof(Sysdbmaintplan_databases));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysdbmaintplan-history-transact-sql
        /// msdb.dbo.sysdbmaintplan_history
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysdbmaintplan_history")]
        public Table_msdb_dbo_sysdbmaintplan_history Sysdbmaintplan_history => throw new InvalitContextException(nameof(Sysdbmaintplan_history));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysdbmaintplan-jobs-transact-sql
        /// msdb.dbo.sysdbmaintplan_jobs
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysdbmaintplan_jobs")]
        public Table_msdb_dbo_sysdbmaintplan_jobs Sysdbmaintplan_jobs => throw new InvalitContextException(nameof(Sysdbmaintplan_jobs));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysdbmaintplans-transact-sql
        /// msdb.dbo.sysdbmaintplans
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysdbmaintplans")]
        public Table_msdb_dbo_sysdbmaintplans Sysdbmaintplans => throw new InvalitContextException(nameof(Sysdbmaintplans));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysssislog-transact-sql
        /// msdb.dbo.sysssislog
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysssislog")]
        public Table_msdb_dbo_sysssislog Sysssislog => throw new InvalitContextException(nameof(Sysssislog));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysssispackagefolders-transact-sql
        /// msdb.dbo.sysssispackagefolders
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysssispackagefolders")]
        public Table_msdb_dbo_sysssispackagefolders Sysssispackagefolders => throw new InvalitContextException(nameof(Sysssispackagefolders));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysssispackages-transact-sql
        /// msdb.dbo.sysssispackages
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysssispackages")]
        public Table_msdb_dbo_sysssispackages Sysssispackages => throw new InvalitContextException(nameof(Sysssispackages));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-alert-transact-sql
        /// msdb.dbo.log_shipping_monitor_alert
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.log_shipping_monitor_alert")]
        public Table_msdb_dbo_log_shipping_monitor_alert Log_shipping_monitor_alert => throw new InvalitContextException(nameof(Log_shipping_monitor_alert));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-error-detail-transact-sql
        /// msdb.dbo.log_shipping_monitor_error_detail
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.log_shipping_monitor_error_detail")]
        public Table_msdb_dbo_log_shipping_monitor_error_detail Log_shipping_monitor_error_detail => throw new InvalitContextException(nameof(Log_shipping_monitor_error_detail));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-history-detail-transact-sql
        /// msdb.dbo.log_shipping_monitor_history_detail
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.log_shipping_monitor_history_detail")]
        public Table_msdb_dbo_log_shipping_monitor_history_detail Log_shipping_monitor_history_detail => throw new InvalitContextException(nameof(Log_shipping_monitor_history_detail));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-primary-transact-sql
        /// msdb.dbo.log_shipping_monitor_primary
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.log_shipping_monitor_primary")]
        public Table_msdb_dbo_log_shipping_monitor_primary Log_shipping_monitor_primary => throw new InvalitContextException(nameof(Log_shipping_monitor_primary));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-monitor-secondary-transact-sql
        /// msdb.dbo.log_shipping_monitor_secondary
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.log_shipping_monitor_secondary")]
        public Table_msdb_dbo_log_shipping_monitor_secondary Log_shipping_monitor_secondary => throw new InvalitContextException(nameof(Log_shipping_monitor_secondary));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-primary-databases-transact-sql
        /// msdb.dbo.log_shipping_primary_databases
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.log_shipping_primary_databases")]
        public Table_msdb_dbo_log_shipping_primary_databases Log_shipping_primary_databases => throw new InvalitContextException(nameof(Log_shipping_primary_databases));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-primary-secondaries-transact-sql
        /// msdb.dbo.log_shipping_primary_secondaries
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.log_shipping_primary_secondaries")]
        public Table_msdb_dbo_log_shipping_primary_secondaries Log_shipping_primary_secondaries => throw new InvalitContextException(nameof(Log_shipping_primary_secondaries));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-secondary-transact-sql
        /// msdb.dbo.log_shipping_secondary
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.log_shipping_secondary")]
        public Table_msdb_dbo_log_shipping_secondary Log_shipping_secondary => throw new InvalitContextException(nameof(Log_shipping_secondary));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/log-shipping-secondary-databases-transact-sql
        /// msdb.dbo.log_shipping_secondary_databases
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.log_shipping_secondary_databases")]
        public Table_msdb_dbo_log_shipping_secondary_databases Log_shipping_secondary_databases => throw new InvalitContextException(nameof(Log_shipping_secondary_databases));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysalerts-transact-sql
        /// msdb.dbo.sysalerts
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysalerts")]
        public Table_msdb_dbo_sysalerts Sysalerts => throw new InvalitContextException(nameof(Sysalerts));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-syscategories-transact-sql
        /// msdb.dbo.syscategories
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.syscategories")]
        public Table_msdb_dbo_syscategories Syscategories => throw new InvalitContextException(nameof(Syscategories));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysdownloadlist-transact-sql
        /// msdb.dbo.sysdownloadlist
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysdownloadlist")]
        public Table_msdb_dbo_sysdownloadlist Sysdownloadlist => throw new InvalitContextException(nameof(Sysdownloadlist));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobactivity-transact-sql
        /// msdb.dbo.sysjobactivity
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysjobactivity")]
        public Table_msdb_dbo_sysjobactivity Sysjobactivity => throw new InvalitContextException(nameof(Sysjobactivity));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobhistory-transact-sql
        /// msdb.dbo.sysjobhistory
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysjobhistory")]
        public Table_msdb_dbo_sysjobhistory Sysjobhistory => throw new InvalitContextException(nameof(Sysjobhistory));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobs-transact-sql
        /// msdb.dbo.sysjobs
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysjobs")]
        public Table_msdb_dbo_sysjobs Sysjobs => throw new InvalitContextException(nameof(Sysjobs));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobschedules-transact-sql
        /// msdb.dbo.sysjobschedules
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysjobschedules")]
        public Table_msdb_dbo_sysjobschedules Sysjobschedules => throw new InvalitContextException(nameof(Sysjobschedules));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobservers-transact-sql
        /// msdb.dbo.sysjobservers
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysjobservers")]
        public Table_msdb_dbo_sysjobservers Sysjobservers => throw new InvalitContextException(nameof(Sysjobservers));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobsteps-transact-sql
        /// msdb.dbo.sysjobsteps
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysjobsteps")]
        public Table_msdb_dbo_sysjobsteps Sysjobsteps => throw new InvalitContextException(nameof(Sysjobsteps));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysjobstepslogs-transact-sql
        /// msdb.dbo.sysjobstepslogs
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysjobstepslogs")]
        public Table_msdb_dbo_sysjobstepslogs Sysjobstepslogs => throw new InvalitContextException(nameof(Sysjobstepslogs));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysnotifications-transact-sql
        /// msdb.dbo.sysnotifications
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysnotifications")]
        public Table_msdb_dbo_sysnotifications Sysnotifications => throw new InvalitContextException(nameof(Sysnotifications));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysoperators-transact-sql
        /// msdb.dbo.sysoperators
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysoperators")]
        public Table_msdb_dbo_sysoperators Sysoperators => throw new InvalitContextException(nameof(Sysoperators));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysproxies-transact-sql
        /// msdb.dbo.sysproxies
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysproxies")]
        public Table_msdb_dbo_sysproxies Sysproxies => throw new InvalitContextException(nameof(Sysproxies));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysproxylogin-transact-sql
        /// msdb.dbo.sysproxylogin
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysproxylogin")]
        public Table_msdb_dbo_sysproxylogin Sysproxylogin => throw new InvalitContextException(nameof(Sysproxylogin));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysproxysubsystem-transact-sql
        /// msdb.dbo.sysproxysubsystem
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysproxysubsystem")]
        public Table_msdb_dbo_sysproxysubsystem Sysproxysubsystem => throw new InvalitContextException(nameof(Sysproxysubsystem));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-sysschedules-transact-sql
        /// msdb.dbo.sysschedules
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.sysschedules")]
        public Table_msdb_dbo_sysschedules Sysschedules => throw new InvalitContextException(nameof(Sysschedules));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-syssessions-transact-sql
        /// msdb.dbo.syssessions
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.syssessions")]
        public Table_msdb_dbo_syssessions Syssessions => throw new InvalitContextException(nameof(Syssessions));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-syssubsystems-transact-sql
        /// msdb.dbo.syssubsystems
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.syssubsystems")]
        public Table_msdb_dbo_syssubsystems Syssubsystems => throw new InvalitContextException(nameof(Syssubsystems));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-systargetservergroupmembers-transact-sql
        /// msdb.dbo.systargetservergroupmembers
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.systargetservergroupmembers")]
        public Table_msdb_dbo_systargetservergroupmembers Systargetservergroupmembers => throw new InvalitContextException(nameof(Systargetservergroupmembers));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-systargetservergroups-transact-sql
        /// msdb.dbo.systargetservergroups
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.systargetservergroups")]
        public Table_msdb_dbo_systargetservergroups Systargetservergroups => throw new InvalitContextException(nameof(Systargetservergroups));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-systargetservers-transact-sql
        /// msdb.dbo.systargetservers
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.systargetservers")]
        public Table_msdb_dbo_systargetservers Systargetservers => throw new InvalitContextException(nameof(Systargetservers));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-systaskids-transact-sql
        /// msdb.dbo.systaskids
        /// </summary>
        [MemberTableConverter(Name = "msdb.dbo.systaskids")]
        public Table_msdb_dbo_systaskids Systaskids => throw new InvalitContextException(nameof(Systaskids));
    }
}
