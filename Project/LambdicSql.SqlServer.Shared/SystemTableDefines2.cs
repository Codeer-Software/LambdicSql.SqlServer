using System;

namespace LambdicSql.SqlServer
{
    //@@@ can't use.
    /*
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-capture-instance-ct-transact-sql
    /// </summary>
    public class Table_cdc_<capture_instance>_CT
    {
        /// <summary>
        /// __$start_lsn
        /// </summary>
        public byte[] __$start_lsn { get; set; }

        /// <summary>
        /// __$end_lsn
        /// </summary>
        public byte[] __$end_lsn { get; set; }

        /// <summary>
        /// __$seqval
        /// </summary>
        public byte[] __$seqval { get; set; }

        /// <summary>
        /// __$operation
        /// </summary>
        public int __$operation { get; set; }

        /// <summary>
        /// __$update_mask
        /// </summary>
        public byte[] __$update_mask { get; set; }
        
        /// <summary>
        /// varies
        /// </summary>
        <captured source table columns>	varies { get; set; }

        /// <summary>
        /// __$command_id
        /// </summary>
        public int __$command_id { get; set; }
    }
    */

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-captured-columns-transact-sql
    /// </summary>
    public class Table_cdc_captured_columns
    {
        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// column_name
        /// </summary>
        public string Column_name { get; set; }

        /// <summary>
        /// column_id
        /// </summary>
        public int Column_id { get; set; }

        /// <summary>
        /// column_type
        /// </summary>
        public string Column_type { get; set; }

        /// <summary>
        /// column_ordinal
        /// </summary>
        public int Column_ordinal { get; set; }

        /// <summary>
        /// is_computed
        /// </summary>
        public bool Is_computed { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-change-tables-transact-sql
    /// </summary>
    public class Table_cdc_change_tables
    {
        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// version
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// source_object_id
        /// </summary>
        public int Source_object_id { get; set; }

        /// <summary>
        /// capture_instance
        /// </summary>
        public string Capture_instance { get; set; }

        /// <summary>
        /// start_lsn
        /// </summary>
        public byte[] Start_lsn { get; set; }

        /// <summary>
        /// end_lsn
        /// </summary>
        public byte[] End_lsn { get; set; }

        /// <summary>
        /// supports_net_changes
        /// </summary>
        public bool Supports_net_changes { get; set; }

        /// <summary>
        /// has_drop_pending
        /// </summary>
        public bool Has_drop_pending { get; set; }

        /// <summary>
        /// role_name
        /// </summary>
        public string Role_name { get; set; }

        /// <summary>
        /// index_name
        /// </summary>
        public string Index_name { get; set; }

        /// <summary>
        /// filegroup_name
        /// </summary>
        public string Filegroup_name { get; set; }

        /// <summary>
        /// create_date
        /// </summary>
        public DateTime Create_date { get; set; }

        /// <summary>
        /// partition_switch
        /// </summary>
        public bool Partition_switch { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-ddl-history-transact-sql
    /// </summary>
    public class Table_cdc_ddl_history
    {
        /// <summary>
        /// source_object_id
        /// </summary>
        public int Source_object_id { get; set; }

        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// required_column_update
        /// </summary>
        public bool Required_column_update { get; set; }

        /// <summary>
        /// ddl_command
        /// </summary>
        public string Ddl_command { get; set; }

        /// <summary>
        /// ddl_lsn
        /// </summary>
        public byte[] Ddl_lsn { get; set; }

        /// <summary>
        /// ddl_time
        /// </summary>
        public DateTime Ddl_time { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-lsn-time-mapping-transact-sql
    /// </summary>
    public class Table_cdc_lsn_time_mapping
    {
        /// <summary>
        /// start_lsn
        /// </summary>
        public byte[] Start_lsn { get; set; }

        /// <summary>
        /// tran_begin_time
        /// </summary>
        public DateTime Tran_begin_time { get; set; }

        /// <summary>
        /// tran_end_time
        /// </summary>
        public DateTime Tran_end_time { get; set; }

        /// <summary>
        /// tran_id
        /// </summary>
        public byte[] Tran_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/cdc-index-columns-transact-sql
    /// </summary>
    public class Table_cdc_index_columns
    {
        /// <summary>
        /// object_id
        /// </summary>
        public int Object_id { get; set; }

        /// <summary>
        /// column_name
        /// </summary>
        public string Column_name { get; set; }

        /// <summary>
        /// index_ordinal
        /// </summary>
        public byte Index_ordinal { get; set; }

        /// <summary>
        /// column_id
        /// </summary>
        public int Column_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/dbo-cdc-jobs-transact-sql
    /// </summary>
    public class Table_dbo_cdc_jobs
    {
        /// <summary>
        /// database_id
        /// </summary>
        public int Database_id { get; set; }

        /// <summary>
        /// job_type
        /// </summary>
        public string Job_type { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// maxtrans
        /// </summary>
        public int Maxtrans { get; set; }

        /// <summary>
        /// maxscans
        /// </summary>
        public int Maxscans { get; set; }

        /// <summary>
        /// continuous
        /// </summary>
        public bool Continuous { get; set; }

        /// <summary>
        /// pollinginterval
        /// </summary>
        public long Pollinginterval { get; set; }

        /// <summary>
        /// retention
        /// </summary>
        public long Retention { get; set; }

        /// <summary>
        /// threshold
        /// </summary>
        public long Threshold { get; set; }
    }
}
