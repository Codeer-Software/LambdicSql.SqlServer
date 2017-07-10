using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Server provides the following functions for SQL Server Managed Backup to Microsoft Azure.
    /// </summary>
    public class Managed_BackupSymbols
    {
        /// <summary>
        /// managed_backup.fn_backup_db_config 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/managed-backup-fn-backup-db-config-transact-sql
        /// </summary>
        /// <param name="db_name">The name of the database</param>
        /// <returns>1 row for the specified database, or returns the information for all the databases configured with SQL Server Managed Backup to Microsoft Azure on the instance.</returns>
        [FuncStyleConverter(Name = "managed_backup.fn_backup_db_config")]
        public object fn_backup_db_config(string db_name) => throw new InvalitContextException(nameof(fn_backup_db_config));

        /// <summary>
        /// managed_backup.fn_is_master_switch_on 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/managed-backup-fn-is-master-switch-on-transact-sql
        /// </summary>
        /// <returns>bit.</returns>
        [FuncStyleConverter(Name = "managed_backup.fn_is_master_switch_on")]
        public bool? fn_is_master_switch_on() => throw new InvalitContextException(nameof(fn_is_master_switch_on));

        /// <summary>
        /// managed_backup.fn_get_current_xevent_settings 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/managed-backup-fn-get-current-xevent-settings-transact-sql
        /// </summary>
        /// <returns>Admin, analytic, and operational channels of the Extended Events are necessary are enabled by default and not configurable.</returns>
        [FuncStyleConverter(Name = "managed_backup.fn_get_current_xevent_settings")]
        public object fn_get_current_xevent_settings() => throw new InvalitContextException(nameof(fn_get_current_xevent_settings));

        /// <summary>
        /// managed_backup.fn_get_parameter  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/managed-backup-fn-get-parameter-transact-sql
        /// </summary>
        /// <param name="parameter_name">Name of the parameter. parameter_name is NVARCHAR(128). If NULL or an empty string is supplied as an argument to the function, name-values pairs for all configured Smart Admin parameters are returned.</param>
        /// <returns>Name of the parameter. The following is a current list of parameters returned:/Current set value of the parameter.</returns>
        [FuncStyleConverter(Name = "managed_backup.fn_get_parameter")]
        public object fn_get_parameter(string parameter_name) => throw new InvalitContextException(nameof(fn_get_parameter));

        /// <summary>
        /// managed_backup.fn_available_backups  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/managed-backup-fn-available-backups-transact-sql
        /// </summary>
        /// <param name="database_name ">The name of the database. The @database_name is NVARCHAR(512).</param>
        /// <returns>The table has a unique clustered constraint on (database_guid, backup_start_date, and first_lsn, backup_type)</returns>
        [FuncStyleConverter(Name = "managed_backup.fn_available_backups")]
        public object fn_available_backups(string database_name) => throw new InvalitContextException(nameof(fn_available_backups));

        /// <summary>
        /// managed_backup.fn_get_health_status  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/managed-backup-fn-available-backups-transact-sql
        /// </summary>
        /// <param name="begin_time">The start of the time period from which the aggregated count of errors is calculated.</param>
        /// <param name="end_time">The end of the time period from which the aggregated count of errors is calculated.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "managed_backup.fn_get_health_status")]
        public object fn_get_health_status(DateTime begin_time, DateTime end_time) => throw new InvalitContextException(nameof(fn_get_health_status));

        /// <summary>
        /// managed_backup.fn_backup_instance_config   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/managed-backup-fn-backup-instance-config-transact-sql
        /// </summary>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter(Name = "managed_backup.fn_backup_instance_config")]
        public object fn_backup_instance_config() => throw new InvalitContextException(nameof(fn_backup_instance_config));
    }
}
