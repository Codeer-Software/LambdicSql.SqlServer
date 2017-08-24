using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    /*
    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/conflict-schema-table-transact-sql
    /// </summary>
    public class Table_conflict_<schema>_<table>
    {
        /// <summary>
        /// __$originator_id
        /// </summary>
        public int __$originator_id { get; set; }

        /// <summary>
        /// __$origin_datasource
        /// </summary>
        public int __$origin_datasource { get; set; }

        /// <summary>
        /// __$tranid
        /// </summary>
        public string __$tranid { get; set; }

        /// <summary>
        /// __$conflict_type
        /// </summary>
        public int __$conflict_type { get; set; }

        /// <summary>
        /// __$is_winner
        /// </summary>
        public bool __$is_winner { get; set; }

        /// <summary>
        /// __$pre_version
        /// </summary>
        public byte[] __$pre_version { get; set; }

        /// <summary>
        /// __$reason_code
        /// </summary>
        public int __$reason_code { get; set; }

        /// <summary>
        /// __$reason_text
        /// </summary>
        public string __$reason_text { get; set; }

        /// <summary>
        /// __$update_bitmap
        /// </summary>
        public byte[] __$update_bitmap { get; set; }

        /// <summary>
        /// __$inserted_date
        /// </summary>
        public DateTime __$inserted_date { get; set; }

        /// <summary>
        /// __$row_id
        /// </summary>
        public TimeSpan __$row_id { get; set; }

        /// <summary>
        /// __$change_id
        /// </summary>
        public byte[] __$change_id { get; set; }

        /// <summary>
        /// <base table column names>
        /// </summary>
        public <base table column types> <base table column names> { get; set; }
    }
    */

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/iharticles-transact-sql
    /// </summary>
    public class Table_IHarticles
    {
        /// <summary>
        /// article_id
        /// </summary>
        public int Article_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public short Publication_id { get; set; }

        /// <summary>
        /// table_id
        /// </summary>
        public int Table_id { get; set; }

        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// creation_script
        /// </summary>
        public string Creation_script { get; set; }

        /// <summary>
        /// del_cmd
        /// </summary>
        public string Del_cmd { get; set; }

        /// <summary>
        /// filter
        /// </summary>
        public int Filter { get; set; }

        /// <summary>
        /// filter_clause
        /// </summary>
        public byte[] Filter_clause { get; set; }

        /// <summary>
        /// ins_cmd
        /// </summary>
        public string Ins_cmd { get; set; }

        /// <summary>
        /// pre_creation_cmd
        /// </summary>
        public byte Pre_creation_cmd { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// upd_cmd
        /// </summary>
        public string Upd_cmd { get; set; }

        /// <summary>
        /// schema_option
        /// </summary>
        public byte[] Schema_option { get; set; }

        /// <summary>
        /// dest_owner
        /// </summary>
        public string Dest_owner { get; set; }

        /// <summary>
        /// dest_table
        /// </summary>
        public string Dest_table { get; set; }

        /// <summary>
        /// tablespace_name
        /// </summary>
        public string Tablespace_name { get; set; }

        /// <summary>
        /// objid
        /// </summary>
        public int Objid { get; set; }

        /// <summary>
        /// sync_objid
        /// </summary>
        public int Sync_objid { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// publisher_status
        /// </summary>
        public int Publisher_status { get; set; }

        /// <summary>
        /// article_view_owner
        /// </summary>
        public string Article_view_owner { get; set; }

        /// <summary>
        /// article_view
        /// </summary>
        public string Article_view { get; set; }

        /// <summary>
        /// ins_scripting_proc
        /// </summary>
        public int Ins_scripting_proc { get; set; }

        /// <summary>
        /// del_scripting_proc
        /// </summary>
        public int Del_scripting_proc { get; set; }

        /// <summary>
        /// upd_scripting_proc
        /// </summary>
        public int Upd_scripting_proc { get; set; }

        /// <summary>
        /// custom_script
        /// </summary>
        public int Custom_script { get; set; }

        /// <summary>
        /// fire_triggers_on_snapshot
        /// </summary>
        public bool Fire_triggers_on_snapshot { get; set; }

        /// <summary>
        /// instance_id
        /// </summary>
        public int Instance_id { get; set; }

        /// <summary>
        /// use_default_datatypes
        /// </summary>
        public bool Use_default_datatypes { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihcolumns-transact-sql
    /// </summary>
    public class Table_IHcolumns
    {
        /// <summary>
        /// column_id
        /// </summary>
        public int Column_id { get; set; }

        /// <summary>
        /// publishercolumn_id
        /// </summary>
        public int Publishercolumn_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// article_id
        /// </summary>
        public int Article_id { get; set; }

        /// <summary>
        /// column_ordinal
        /// </summary>
        public int Column_ordinal { get; set; }

        /// <summary>
        /// mapped_type
        /// </summary>
        public byte Mapped_type { get; set; }

        /// <summary>
        /// mapped_length
        /// </summary>
        public long Mapped_length { get; set; }

        /// <summary>
        /// mapped_prec
        /// </summary>
        public int Mapped_prec { get; set; }

        /// <summary>
        /// mapped_scale
        /// </summary>
        public int Mapped_scale { get; set; }

        /// <summary>
        /// mapped_nullable
        /// </summary>
        public bool Mapped_nullable { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihconstrainttypes-transact-sql
    /// </summary>
    public class Table_IHconstrainttypes
    {
        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihindextypes-transact-sql
    /// </summary>
    public class Table_IHindextypes
    {
        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublications-transact-sql
    /// </summary>
    public class Table_IHpublications
    {
        /// <summary>
        /// pubid
        /// </summary>
        public int Pubid { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// repl_freq
        /// </summary>
        public byte Repl_freq { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// sync_method
        /// </summary>
        public byte Sync_method { get; set; }

        /// <summary>
        /// snapshot_jobid
        /// </summary>
        public byte[] Snapshot_jobid { get; set; }

        /// <summary>
        /// enabled_for_internet
        /// </summary>
        public bool Enabled_for_internet { get; set; }

        /// <summary>
        /// immediate_sync_ready
        /// </summary>
        public bool Immediate_sync_ready { get; set; }

        /// <summary>
        /// allow_queued_tran
        /// </summary>
        public bool Allow_queued_tran { get; set; }

        /// <summary>
        /// allow_sync_tran
        /// </summary>
        public bool Allow_sync_tran { get; set; }

        /// <summary>
        /// autogen_sync_procs
        /// </summary>
        public bool Autogen_sync_procs { get; set; }

        /// <summary>
        /// snapshot_in_defaultfolder
        /// </summary>
        public bool Snapshot_in_defaultfolder { get; set; }

        /// <summary>
        /// alt_snapshot_folder
        /// </summary>
        public string Alt_snapshot_folder { get; set; }

        /// <summary>
        /// pre_snapshot_script
        /// </summary>
        public string Pre_snapshot_script { get; set; }

        /// <summary>
        /// post_snapshot_script
        /// </summary>
        public string Post_snapshot_script { get; set; }

        /// <summary>
        /// compress_snapshot
        /// </summary>
        public bool Compress_snapshot { get; set; }

        /// <summary>
        /// ftp_address
        /// </summary>
        public string Ftp_address { get; set; }

        /// <summary>
        /// ftp_port
        /// </summary>
        public int Ftp_port { get; set; }

        /// <summary>
        /// ftp_subdirectory
        /// </summary>
        public string Ftp_subdirectory { get; set; }

        /// <summary>
        /// ftp_login
        /// </summary>
        public string Ftp_login { get; set; }

        /// <summary>
        /// ftp_password
        /// </summary>
        public string Ftp_password { get; set; }

        /// <summary>
        /// allow_dts
        /// </summary>
        public bool Allow_dts { get; set; }

        /// <summary>
        /// allow_anonymous
        /// </summary>
        public bool Allow_anonymous { get; set; }

        /// <summary>
        /// centralized_conflicts
        /// </summary>
        public bool Centralized_conflicts { get; set; }

        /// <summary>
        /// conflict_retention
        /// </summary>
        public int Conflict_retention { get; set; }

        /// <summary>
        /// conflict_policy
        /// </summary>
        public int Conflict_policy { get; set; }

        /// <summary>
        /// queue_type
        /// </summary>
        public int Queue_type { get; set; }

        /// <summary>
        /// ad_guidname
        /// </summary>
        public string Ad_guidname { get; set; }

        /// <summary>
        /// backward_comp_level
        /// </summary>
        public int Backward_comp_level { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// independent_agent
        /// </summary>
        public bool Independent_agent { get; set; }

        /// <summary>
        /// immediate_sync
        /// </summary>
        public bool Immediate_sync { get; set; }

        /// <summary>
        /// allow_push
        /// </summary>
        public bool Allow_push { get; set; }

        /// <summary>
        /// allow_pull
        /// </summary>
        public bool Allow_pull { get; set; }

        /// <summary>
        /// retention
        /// </summary>
        public int Retention { get; set; }

        /// <summary>
        /// allow_subscription_copy
        /// </summary>
        public bool Allow_subscription_copy { get; set; }

        /// <summary>
        /// allow_initialize_from_backup
        /// </summary>
        public bool Allow_initialize_from_backup { get; set; }

        /// <summary>
        /// min_autonosync_lsn
        /// </summary>
        public byte[] Min_autonosync_lsn { get; set; }

        /// <summary>
        /// replicate_ddl
        /// </summary>
        public int Replicate_ddl { get; set; }

        /// <summary>
        /// options
        /// </summary>
        public int Options { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishercolumnconstraints-transact-sql
    /// </summary>
    public class Table_IHpublishercolumnconstraints
    {
        /// <summary>
        /// publishercolumn_id
        /// </summary>
        public int Publishercolumn_id { get; set; }

        /// <summary>
        /// publisherconstraint_id
        /// </summary>
        public int Publisherconstraint_id { get; set; }

        /// <summary>
        /// indid
        /// </summary>
        public int Indid { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishercolumnindexes-transact-sql
    /// </summary>
    public class Table_IHpublishercolumnindexes
    {
        /// <summary>
        /// publishercolumn_id
        /// </summary>
        public int Publishercolumn_id { get; set; }

        /// <summary>
        /// publisherindex_id
        /// </summary>
        public int Publisherindex_id { get; set; }

        /// <summary>
        /// indid
        /// </summary>
        public int Indid { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishercolumns-transact-sql
    /// </summary>
    public class Table_IHpublishercolumns
    {
        /// <summary>
        /// publishercolumn_id
        /// </summary>
        public int Publishercolumn_id { get; set; }

        /// <summary>
        /// table_id
        /// </summary>
        public int Table_id { get; set; }

        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// column_ordinal
        /// </summary>
        public int Column_ordinal { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// length
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// prec
        /// </summary>
        public int Prec { get; set; }

        /// <summary>
        /// scale
        /// </summary>
        public int Scale { get; set; }

        /// <summary>
        /// isnullable
        /// </summary>
        public bool Isnullable { get; set; }

        /// <summary>
        /// iscaptured
        /// </summary>
        public bool Iscaptured { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublisherconstraints-transact-sql
    /// </summary>
    public class Table_IHpublisherconstraints
    {
        /// <summary>
        /// publisherconstraint_id
        /// </summary>
        public int Publisherconstraint_id { get; set; }

        /// <summary>
        /// table_id
        /// </summary>
        public int Table_id { get; set; }

        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublisherindexes-transact-sql
    /// </summary>
    public class Table_IHpublisherindexes
    {
        /// <summary>
        /// publisherindex_id
        /// </summary>
        public int Publisherindex_id { get; set; }

        /// <summary>
        /// table_id
        /// </summary>
        public int Table_id { get; set; }

        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishers-transact-sql
    /// </summary>
    public class Table_IHpublishers
    {
        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// vendor
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// publisher_guid
        /// </summary>
        public object Publisher_guid { get; set; }

        /// <summary>
        /// flush_request_time
        /// </summary>
        public DateTime Flush_request_time { get; set; }

        /// <summary>
        /// version
        /// </summary>
        public string Version { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishertables-transact-sql
    /// </summary>
    public class Table_IHpublishertables
    {
        /// <summary>
        /// table_id
        /// </summary>
        public int Table_id { get; set; }

        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// owner
        /// </summary>
        public string Owner { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihsubscriptions-transact-sql
    /// </summary>
    public class Table_IHsubscriptions
    {
        /// <summary>
        /// article_id
        /// </summary>
        public int Article_id { get; set; }

        /// <summary>
        /// srvid
        /// </summary>
        public short Srvid { get; set; }

        /// <summary>
        /// dest_db
        /// </summary>
        public string Dest_db { get; set; }

        /// <summary>
        /// login_name
        /// </summary>
        public string Login_name { get; set; }

        /// <summary>
        /// distribution_jobid
        /// </summary>
        public byte[] Distribution_jobid { get; set; }

        /// <summary>
        /// timestamp
        /// </summary>
        public TimeSpan Timestamp { get; set; }

        /// <summary>
        /// queued_reinit
        /// </summary>
        public bool Queued_reinit { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// sync_type
        /// </summary>
        public byte Sync_type { get; set; }

        /// <summary>
        /// subscription_type
        /// </summary>
        public int Subscription_type { get; set; }

        /// <summary>
        /// update_mode
        /// </summary>
        public byte Update_mode { get; set; }

        /// <summary>
        /// loopback_detection
        /// </summary>
        public bool Loopback_detection { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msagent-parameters-transact-sql
    /// </summary>
    public class Table_MSagent_parameters
    {
        /// <summary>
        /// profile_id
        /// </summary>
        public int Profile_id { get; set; }

        /// <summary>
        /// parameter_name
        /// </summary>
        public string Parameter_name { get; set; }

        /// <summary>
        /// value
        /// </summary>
        public string Value { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msagent-profiles-transact-sql
    /// </summary>
    public class Table_MSagent_profiles
    {
        /// <summary>
        /// profile_id
        /// </summary>
        public int Profile_id { get; set; }

        /// <summary>
        /// profile_name
        /// </summary>
        public string Profile_name { get; set; }

        /// <summary>
        /// agent_type
        /// </summary>
        public int Agent_type { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// def_profile
        /// </summary>
        public bool Def_profile { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msagentparameterlist-transact-sql
    /// </summary>
    public class Table_MSagentparameterlist
    {
        /// <summary>
        /// agent_type
        /// </summary>
        public byte Agent_type { get; set; }

        /// <summary>
        /// parameter_name
        /// </summary>
        public string Parameter_name { get; set; }

        /// <summary>
        /// default_value
        /// </summary>
        public string Default_value { get; set; }

        /// <summary>
        /// min_value
        /// </summary>
        public int Min_value { get; set; }

        /// <summary>
        /// max_value
        /// </summary>
        public int Max_value { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msarticles-transact-sql
    /// </summary>
    public class Table_MSarticles
    {
        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// article
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// article_id
        /// </summary>
        public int Article_id { get; set; }

        /// <summary>
        /// destination_object
        /// </summary>
        public string Destination_object { get; set; }

        /// <summary>
        /// source_owner
        /// </summary>
        public string Source_owner { get; set; }

        /// <summary>
        /// source_object
        /// </summary>
        public string Source_object { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// destination_owner
        /// </summary>
        public string Destination_owner { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mscached-peer-lsns-transact-sql
    /// </summary>
    public class Table_MScached_peer_lsns
    {
        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// originator
        /// </summary>
        public string Originator { get; set; }

        /// <summary>
        /// originator_db
        /// </summary>
        public string Originator_db { get; set; }

        /// <summary>
        /// originator_publication_id
        /// </summary>
        public int Originator_publication_id { get; set; }

        /// <summary>
        /// originator_db_version
        /// </summary>
        public int Originator_db_version { get; set; }

        /// <summary>
        /// originator_lsn
        /// </summary>
        public byte[] Originator_lsn { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdbms-transact-sql
    /// </summary>
    public class Table_msdb_dbo_MSdbms
    {
        /// <summary>
        /// dbms_id
        /// </summary>
        public int Dbms_id { get; set; }

        /// <summary>
        /// dbms
        /// </summary>
        public string Dbms { get; set; }

        /// <summary>
        /// version
        /// </summary>
        public string Version { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdbms-datatype-transact-sql
    /// </summary>
    public class Table_msdb_dbo_MSdbms_datatype
    {
        /// <summary>
        /// datatype_id
        /// </summary>
        public int Datatype_id { get; set; }

        /// <summary>
        /// dbms_id
        /// </summary>
        public int Dbms_id { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// createparams
        /// </summary>
        public int Createparams { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdbms-datatype-mapping-transact-sql
    /// </summary>
    public class Table_msdb_dbo_MSdbms_datatype_mapping
    {
        /// <summary>
        /// datatype_mapping_id
        /// </summary>
        public int Datatype_mapping_id { get; set; }

        /// <summary>
        /// map_id
        /// </summary>
        public int Map_id { get; set; }

        /// <summary>
        /// dest_datatype_id
        /// </summary>
        public int Dest_datatype_id { get; set; }

        /// <summary>
        /// dest_precision
        /// </summary>
        public long Dest_precision { get; set; }

        /// <summary>
        /// dest_scale
        /// </summary>
        public int Dest_scale { get; set; }

        /// <summary>
        /// dest_length
        /// </summary>
        public long Dest_length { get; set; }

        /// <summary>
        /// dest_nullable
        /// </summary>
        public bool Dest_nullable { get; set; }

        /// <summary>
        /// dest_createparams
        /// </summary>
        public int Dest_createparams { get; set; }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdbms-map-transact-sql
    /// </summary>
    public class Table_msdb_dbo_MSdbms_map
    {
        /// <summary>
        /// map_id
        /// </summary>
        public int Map_id { get; set; }

        /// <summary>
        /// src_dbms_id
        /// </summary>
        public int Src_dbms_id { get; set; }

        /// <summary>
        /// dest_dbms_id
        /// </summary>
        public int Dest_dbms_id { get; set; }

        /// <summary>
        /// src_datatype_id
        /// </summary>
        public int Src_datatype_id { get; set; }

        /// <summary>
        /// src_len_min
        /// </summary>
        public long Src_len_min { get; set; }

        /// <summary>
        /// src_len_max
        /// </summary>
        public long Src_len_max { get; set; }

        /// <summary>
        /// src_prec_min
        /// </summary>
        public long Src_prec_min { get; set; }

        /// <summary>
        /// src_prec_max
        /// </summary>
        public long Src_prec_max { get; set; }

        /// <summary>
        /// src_scale_min
        /// </summary>
        public int Src_scale_min { get; set; }

        /// <summary>
        /// src_scale_max
        /// </summary>
        public int Src_scale_max { get; set; }

        /// <summary>
        /// src_nullable
        /// </summary>
        public bool Src_nullable { get; set; }

        /// <summary>
        /// default_datatype_mapping_id
        /// </summary>
        public int Default_datatype_mapping_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistpublishers-transact-sql
    /// </summary>
    public class Table_MSdistpublishers
    {
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// distribution_db
        /// </summary>
        public string Distribution_db { get; set; }

        /// <summary>
        /// working_directory
        /// </summary>
        public string Working_directory { get; set; }

        /// <summary>
        /// security_mode
        /// </summary>
        public int Security_mode { get; set; }

        /// <summary>
        /// login
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// active
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// trusted
        /// </summary>
        public bool Trusted { get; set; }

        /// <summary>
        /// third_party
        /// </summary>
        public bool Third_party { get; set; }

        /// <summary>
        /// publisher_type
        /// </summary>
        public string Publisher_type { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistribution-agents-transact-sql
    /// </summary>
    public class Table_MSdistribution_agents
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
        /// publisher_database_id
        /// </summary>
        public int Publisher_database_id { get; set; }

        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// subscriber_id
        /// </summary>
        public short Subscriber_id { get; set; }

        /// <summary>
        /// subscriber_db
        /// </summary>
        public string Subscriber_db { get; set; }

        /// <summary>
        /// subscription_type
        /// </summary>
        public int Subscription_type { get; set; }

        /// <summary>
        /// local_job
        /// </summary>
        public bool Local_job { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public byte[] Job_id { get; set; }

        /// <summary>
        /// subscription_guid
        /// </summary>
        public byte[] Subscription_guid { get; set; }

        /// <summary>
        /// profile_id
        /// </summary>
        public int Profile_id { get; set; }

        /// <summary>
        /// anonymous_subid
        /// </summary>
        public object Anonymous_subid { get; set; }

        /// <summary>
        /// subscriber_name
        /// </summary>
        public string Subscriber_name { get; set; }

        /// <summary>
        /// virtual_agent_id
        /// </summary>
        public int Virtual_agent_id { get; set; }

        /// <summary>
        /// anonymous_agent_id
        /// </summary>
        public int Anonymous_agent_id { get; set; }

        /// <summary>
        /// creation_date
        /// </summary>
        public DateTime Creation_date { get; set; }

        /// <summary>
        /// queue_id
        /// </summary>
        public string Queue_id { get; set; }

        /// <summary>
        /// queue_status
        /// </summary>
        public int Queue_status { get; set; }

        /// <summary>
        /// offload_enabled
        /// </summary>
        public bool Offload_enabled { get; set; }

        /// <summary>
        /// offload_server
        /// </summary>
        public string Offload_server { get; set; }

        /// <summary>
        /// dts_package_name
        /// </summary>
        public string Dts_package_name { get; set; }

        /// <summary>
        /// dts_package_password
        /// </summary>
        public string Dts_package_password { get; set; }

        /// <summary>
        /// dts_package_location
        /// </summary>
        public int Dts_package_location { get; set; }

        /// <summary>
        /// sid
        /// </summary>
        public byte[] Sid { get; set; }

        /// <summary>
        /// queue_server
        /// </summary>
        public string Queue_server { get; set; }

        /// <summary>
        /// subscriber_security_mode
        /// </summary>
        public short Subscriber_security_mode { get; set; }

        /// <summary>
        /// subscriber_login
        /// </summary>
        public string Subscriber_login { get; set; }

        /// <summary>
        /// subscriber_password
        /// </summary>
        public string Subscriber_password { get; set; }

        /// <summary>
        /// reset_partial_snapshot_progress
        /// </summary>
        public bool Reset_partial_snapshot_progress { get; set; }

        /// <summary>
        /// job_step_uid
        /// </summary>
        public object Job_step_uid { get; set; }

        /// <summary>
        /// subscriptionstreams
        /// </summary>
        public byte Subscriptionstreams { get; set; }

        /// <summary>
        /// memory_optimized
        /// </summary>
        public bool Memory_optimized { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistribution-history-transact-sql
    /// </summary>
    public class Table_MSdistribution_history
    {
        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// runstatus
        /// </summary>
        public int Runstatus { get; set; }

        /// <summary>
        /// start_time
        /// </summary>
        public DateTime Start_time { get; set; }

        /// <summary>
        /// time
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// xact_seqno
        /// </summary>
        public byte[] Xact_seqno { get; set; }

        /// <summary>
        /// current_delivery_rate
        /// </summary>
        public double Current_delivery_rate { get; set; }

        /// <summary>
        /// current_delivery_latency
        /// </summary>
        public int Current_delivery_latency { get; set; }

        /// <summary>
        /// delivered_transactions
        /// </summary>
        public int Delivered_transactions { get; set; }

        /// <summary>
        /// delivered_commands
        /// </summary>
        public int Delivered_commands { get; set; }

        /// <summary>
        /// average_commands
        /// </summary>
        public int Average_commands { get; set; }

        /// <summary>
        /// delivery_rate
        /// </summary>
        public double Delivery_rate { get; set; }

        /// <summary>
        /// delivery_latency
        /// </summary>
        public int Delivery_latency { get; set; }

        /// <summary>
        /// total_delivered_commands
        /// </summary>
        public long Total_delivered_commands { get; set; }

        /// <summary>
        /// error_id
        /// </summary>
        public int Error_id { get; set; }

        /// <summary>
        /// updateable_row
        /// </summary>
        public bool Updateable_row { get; set; }

        /// <summary>
        /// timestamp
        /// </summary>
        public TimeSpan Timestamp { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistributiondbs-transact-sql
    /// </summary>
    public class Table_MSdistributiondbs
    {
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// min_distretention
        /// </summary>
        public int Min_distretention { get; set; }

        /// <summary>
        /// max_distretention
        /// </summary>
        public int Max_distretention { get; set; }

        /// <summary>
        /// history_retention
        /// </summary>
        public int History_retention { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistributor-transact-sql
    /// </summary>
    public class Table_MSdistributor
    {
        /// <summary>
        /// property
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// value
        /// </summary>
        public string Value { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdynamicsnapshotjobs-transact-sql
    /// </summary>
    public class Table_MSdynamicsnapshotjobs
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
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// dynamic_filter_login
        /// </summary>
        public string Dynamic_filter_login { get; set; }

        /// <summary>
        /// dynamic_filter_hostname
        /// </summary>
        public string Dynamic_filter_hostname { get; set; }

        /// <summary>
        /// dynamic_snapshot_location
        /// </summary>
        public string Dynamic_snapshot_location { get; set; }

        /// <summary>
        /// partition_id
        /// </summary>
        public int Partition_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdynamicsnapshotviews-transact-sql
    /// </summary>
    public class Table_MSdynamicsnapshotviews
    {
        /// <summary>
        /// dynamic_snapshot_view_name
        /// </summary>
        public string Dynamic_snapshot_view_name { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mslogreader-agents-transact-sql
    /// </summary>
    public class Table_MSlogreader_agents
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
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// local_job
        /// </summary>
        public bool Local_job { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public byte[] Job_id { get; set; }

        /// <summary>
        /// profile_id
        /// </summary>
        public int Profile_id { get; set; }

        /// <summary>
        /// publisher_security_mode
        /// </summary>
        public short Publisher_security_mode { get; set; }

        /// <summary>
        /// publisher_login
        /// </summary>
        public string Publisher_login { get; set; }

        /// <summary>
        /// publisher_password
        /// </summary>
        public string Publisher_password { get; set; }

        /// <summary>
        /// job_step_uid
        /// </summary>
        public object Job_step_uid { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mslogreader-history-transact-sql
    /// </summary>
    public class Table_MSlogreader_history
    {
        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// runstatus
        /// </summary>
        public int Runstatus { get; set; }

        /// <summary>
        /// start_time
        /// </summary>
        public DateTime Start_time { get; set; }

        /// <summary>
        /// time
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// xact_seqno
        /// </summary>
        public byte[] Xact_seqno { get; set; }

        /// <summary>
        /// delivery_time
        /// </summary>
        public int Delivery_time { get; set; }

        /// <summary>
        /// delivered_transactions
        /// </summary>
        public int Delivered_transactions { get; set; }

        /// <summary>
        /// delivered_commands
        /// </summary>
        public int Delivered_commands { get; set; }

        /// <summary>
        /// average_commands
        /// </summary>
        public int Average_commands { get; set; }

        /// <summary>
        /// delivery_rate
        /// </summary>
        public double Delivery_rate { get; set; }

        /// <summary>
        /// delivery_latency
        /// </summary>
        public int Delivery_latency { get; set; }

        /// <summary>
        /// error_id
        /// </summary>
        public int Error_id { get; set; }

        /// <summary>
        /// timestamp
        /// </summary>
        public TimeSpan Timestamp { get; set; }

        /// <summary>
        /// updateable_row
        /// </summary>
        public bool Updateable_row { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-agents-transact-sql
    /// </summary>
    public class Table_MSmerge_agents
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
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// subscriber_id
        /// </summary>
        public short Subscriber_id { get; set; }

        /// <summary>
        /// subscriber_db
        /// </summary>
        public string Subscriber_db { get; set; }

        /// <summary>
        /// local_job
        /// </summary>
        public bool Local_job { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public byte[] Job_id { get; set; }

        /// <summary>
        /// profile_id
        /// </summary>
        public int Profile_id { get; set; }

        /// <summary>
        /// anonymous_subid
        /// </summary>
        public object Anonymous_subid { get; set; }

        /// <summary>
        /// subscriber_name
        /// </summary>
        public string Subscriber_name { get; set; }

        /// <summary>
        /// creation_date
        /// </summary>
        public DateTime Creation_date { get; set; }

        /// <summary>
        /// offload_enabled
        /// </summary>
        public bool Offload_enabled { get; set; }

        /// <summary>
        /// offload_server
        /// </summary>
        public string Offload_server { get; set; }

        /// <summary>
        /// sid
        /// </summary>
        public byte[] Sid { get; set; }

        /// <summary>
        /// subscriber_security_mode
        /// </summary>
        public short Subscriber_security_mode { get; set; }

        /// <summary>
        /// subscriber_login
        /// </summary>
        public string Subscriber_login { get; set; }

        /// <summary>
        /// subscriber_password
        /// </summary>
        public string Subscriber_password { get; set; }

        /// <summary>
        /// publisher_security_mode
        /// </summary>
        public short Publisher_security_mode { get; set; }

        /// <summary>
        /// publisher_login
        /// </summary>
        public string Publisher_login { get; set; }

        /// <summary>
        /// publisher_password
        /// </summary>
        public string Publisher_password { get; set; }

        /// <summary>
        /// job_step_uid
        /// </summary>
        public object Job_step_uid { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-articlehistory-transact-sql
    /// </summary>
    public class Table_MSmerge_articlehistory
    {
        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// phase_id
        /// </summary>
        public int Phase_id { get; set; }

        /// <summary>
        /// article_name
        /// </summary>
        public string Article_name { get; set; }

        /// <summary>
        /// start_time
        /// </summary>
        public DateTime Start_time { get; set; }

        /// <summary>
        /// duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// inserts
        /// </summary>
        public int Inserts { get; set; }

        /// <summary>
        /// updates
        /// </summary>
        public int Updates { get; set; }

        /// <summary>
        /// deletes
        /// </summary>
        public int Deletes { get; set; }

        /// <summary>
        /// conflicts
        /// </summary>
        public int Conflicts { get; set; }

        /// <summary>
        /// conflicts_resolved
        /// </summary>
        public int Conflicts_resolved { get; set; }

        /// <summary>
        /// rows_retried
        /// </summary>
        public int Rows_retried { get; set; }

        /// <summary>
        /// percent_complete
        /// </summary>
        public decimal Percent_complete { get; set; }

        /// <summary>
        /// estimated_changes
        /// </summary>
        public int Estimated_changes { get; set; }

        /// <summary>
        /// relative_cost
        /// </summary>
        public decimal Relative_cost { get; set; }
    }
    /*
    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-conflict-publication-article-transact-sql
    /// </summary>
    public class Table_MSmerge_conflict_<publication>_<article>
{
    /// <summary>
    /// article_column_name
    /// </summary>
    public object Article_column_name { get; set; }

    /// <summary>
    /// rowguid
    /// </summary>
    public object Rowguid { get; set; }

    /// <summary>
    /// ModifiedDate
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    /// <summary>
    /// origin_datasource_id
    /// </summary>
    public object Origin_datasource_id { get; set; }
}
*/
    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-conflicts-info-transact-sql
    /// </summary>
    public class Table_MSmerge_conflicts_info
    {
        /// <summary>
        /// tablenick
        /// </summary>
        public int Tablenick { get; set; }

        /// <summary>
        /// rowguid
        /// </summary>
        public object Rowguid { get; set; }

        /// <summary>
        /// origin_datasource
        /// </summary>
        public string Origin_datasource { get; set; }

        /// <summary>
        /// conflict_type
        /// </summary>
        public int Conflict_type { get; set; }

        /// <summary>
        /// reason_code
        /// </summary>
        public int Reason_code { get; set; }

        /// <summary>
        /// reason_text
        /// </summary>
        public string Reason_text { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// MSrepl_create_time
        /// </summary>
        public DateTime MSrepl_create_time { get; set; }

        /// <summary>
        /// origin_datasource_id
        /// </summary>
        public object Origin_datasource_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-contents-transact-sql
    /// </summary>
    public class Table_MSmerge_contents
    {
        /// <summary>
        /// tablenick
        /// </summary>
        public int Tablenick { get; set; }

        /// <summary>
        /// rowguid
        /// </summary>
        public object Rowguid { get; set; }

        /// <summary>
        /// generation
        /// </summary>
        public long Generation { get; set; }

        /// <summary>
        /// partchangegen
        /// </summary>
        public long Partchangegen { get; set; }

        /// <summary>
        /// lineage
        /// </summary>
        public byte[] Lineage { get; set; }

        /// <summary>
        /// colvl
        /// </summary>
        public byte[] Colvl { get; set; }

        /// <summary>
        /// marker
        /// </summary>
        public object Marker { get; set; }

        /// <summary>
        /// logical_record_parent_rowguid
        /// </summary>
        public object Logical_record_parent_rowguid { get; set; }

        /// <summary>
        /// logical_record_lineage
        /// </summary>
        public byte[] Logical_record_lineage { get; set; }

        /// <summary>
        /// logical_relation_change_gen
        /// </summary>
        public long Logical_relation_change_gen { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-current-partition-mappings
    /// </summary>
    public class Table_MSmerge_current_partition_mappings
    {
        /// <summary>
        /// publication_number
        /// </summary>
        public short Publication_number { get; set; }

        /// <summary>
        /// tablenick
        /// </summary>
        public int Tablenick { get; set; }

        /// <summary>
        /// rowguid
        /// </summary>
        public object Rowguid { get; set; }

        /// <summary>
        /// partition_id
        /// </summary>
        public int Partition_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-dynamic-snapshots-transact-sql
    /// </summary>
    public class Table_MSmerge_dynamic_snapshots
    {
        /// <summary>
        /// partition_id
        /// </summary>
        public int Partition_id { get; set; }

        /// <summary>
        /// dynamic_snapshot_location
        /// </summary>
        public string Dynamic_snapshot_location { get; set; }

        /// <summary>
        /// last_updated
        /// </summary>
        public DateTime Last_updated { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-errorlineage-transact-sql
    /// </summary>
    public class Table_MSmerge_errorlineage
    {
        /// <summary>
        /// tablenick
        /// </summary>
        public int Tablenick { get; set; }

        /// <summary>
        /// rowguid
        /// </summary>
        public object Rowguid { get; set; }

        /// <summary>
        /// lineage
        /// </summary>
        public byte[] Lineage { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-generation-partition-mappings-transact-sql
    /// </summary>
    public class Table_MSmerge_generation_partition_mappings
    {
        /// <summary>
        /// publication_number
        /// </summary>
        public short Publication_number { get; set; }

        /// <summary>
        /// generation
        /// </summary>
        public long Generation { get; set; }

        /// <summary>
        /// partition_id
        /// </summary>
        public int Partition_id { get; set; }

        /// <summary>
        /// changecount
        /// </summary>
        public int Changecount { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-genhistory-transact-sql
    /// </summary>
    public class Table_MSmerge_genhistory
    {
        /// <summary>
        /// guidsrc
        /// </summary>
        public object Guidsrc { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// generation
        /// </summary>
        public long Generation { get; set; }

        /// <summary>
        /// art_nick
        /// </summary>
        public int Art_nick { get; set; }

        /// <summary>
        /// nicknames
        /// </summary>
        public byte[] Nicknames { get; set; }

        /// <summary>
        /// coldate
        /// </summary>
        public DateTime Coldate { get; set; }

        /// <summary>
        /// genstatus
        /// </summary>
        public byte Genstatus { get; set; }

        /// <summary>
        /// changecount
        /// </summary>
        public int Changecount { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-history-transact-sql
    /// </summary>
    public class Table_MSmerge_history
    {
        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// error_id
        /// </summary>
        public int Error_id { get; set; }

        /// <summary>
        /// timestamp
        /// </summary>
        public TimeSpan Timestamp { get; set; }

        /// <summary>
        /// updatable_row
        /// </summary>
        public bool Updatable_row { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-identity-range-transact-sql
    /// </summary>
    public class Table_MSmerge_identity_range
    {
        /// <summary>
        /// subid
        /// </summary>
        public object Subid { get; set; }

        /// <summary>
        /// artid
        /// </summary>
        public object Artid { get; set; }

        /// <summary>
        /// range_begin
        /// </summary>
        public decimal Range_begin { get; set; }

        /// <summary>
        /// range_end
        /// </summary>
        public decimal Range_end { get; set; }

        /// <summary>
        /// next_range_begin
        /// </summary>
        public decimal Next_range_begin { get; set; }

        /// <summary>
        /// next_range_end
        /// </summary>
        public decimal Next_range_end { get; set; }

        /// <summary>
        /// is_pub_range
        /// </summary>
        public bool Is_pub_range { get; set; }

        /// <summary>
        /// max_used
        /// </summary>
        public decimal Max_used { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-identity-range-allocations-transact-sql
    /// </summary>
    public class Table_MSmerge_identity_range_allocations
    {
        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// article
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// subscriber
        /// </summary>
        public string Subscriber { get; set; }

        /// <summary>
        /// subscriber_db
        /// </summary>
        public string Subscriber_db { get; set; }

        /// <summary>
        /// is_pub_range
        /// </summary>
        public bool Is_pub_range { get; set; }

        /// <summary>
        /// ranges_allocated
        /// </summary>
        public byte Ranges_allocated { get; set; }

        /// <summary>
        /// range_begin
        /// </summary>
        public decimal Range_begin { get; set; }

        /// <summary>
        /// range_end
        /// </summary>
        public decimal Range_end { get; set; }

        /// <summary>
        /// next_range_begin
        /// </summary>
        public decimal Next_range_begin { get; set; }

        /// <summary>
        /// next_range_end
        /// </summary>
        public decimal Next_range_end { get; set; }

        /// <summary>
        /// max_used
        /// </summary>
        public decimal Max_used { get; set; }

        /// <summary>
        /// time_of_allocation
        /// </summary>
        public DateTime Time_of_allocation { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-metadataaction-request-transact-sql
    /// </summary>
    public class Table_MSmerge_metadataaction_request
    {
        /// <summary>
        /// tablenick
        /// </summary>
        public int Tablenick { get; set; }

        /// <summary>
        /// rowguid
        /// </summary>
        public object Rowguid { get; set; }

        /// <summary>
        /// action
        /// </summary>
        public byte Action { get; set; }

        /// <summary>
        /// generation
        /// </summary>
        public long Generation { get; set; }

        /// <summary>
        /// changed
        /// </summary>
        public int Changed { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-partition-groups-transact-sql
    /// </summary>
    public class Table_MSmerge_partition_groups
    {
        /// <summary>
        /// partition_id
        /// </summary>
        public int Partition_id { get; set; }

        /// <summary>
        /// publication_number
        /// </summary>
        public short Publication_number { get; set; }

        /// <summary>
        /// maxgen_whenadded
        /// </summary>
        public long Maxgen_whenadded { get; set; }

        /// <summary>
        /// using_partition_groups
        /// </summary>
        public bool Using_partition_groups { get; set; }

        /// <summary>
        /// HOST_NAME_FN
        /// </summary>
        public string HOST_NAME_FN { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-past-partition-mappings-transact-sql
    /// </summary>
    public class Table_MSmerge_past_partition_mappings
    {
        /// <summary>
        /// publication_number
        /// </summary>
        public short Publication_number { get; set; }

        /// <summary>
        /// tablenick
        /// </summary>
        public int Tablenick { get; set; }

        /// <summary>
        /// rowguid
        /// </summary>
        public object Rowguid { get; set; }

        /// <summary>
        /// partition_id
        /// </summary>
        public int Partition_id { get; set; }

        /// <summary>
        /// generation
        /// </summary>
        public long Generation { get; set; }

        /// <summary>
        /// reason
        /// </summary>
        public byte Reason { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-replinfo-transact-sql
    /// </summary>
    public class Table_MSmerge_replinfo
    {
        /// <summary>
        /// repid
        /// </summary>
        public object Repid { get; set; }

        /// <summary>
        /// use_interactive_resolver
        /// </summary>
        public bool Use_interactive_resolver { get; set; }

        /// <summary>
        /// validation_level
        /// </summary>
        public int Validation_level { get; set; }

        /// <summary>
        /// resync_gen
        /// </summary>
        public long Resync_gen { get; set; }

        /// <summary>
        /// login_name
        /// </summary>
        public string Login_name { get; set; }

        /// <summary>
        /// hostname
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// merge_jobid
        /// </summary>
        public byte[] Merge_jobid { get; set; }

        /// <summary>
        /// sync_info
        /// </summary>
        public int Sync_info { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-sessions-transact-sql
    /// </summary>
    public class Table_MSmerge_sessions
    {
        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }

        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// start_time
        /// </summary>
        public DateTime Start_time { get; set; }

        /// <summary>
        /// end_time
        /// </summary>
        public DateTime End_time { get; set; }

        /// <summary>
        /// duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// delivery_time
        /// </summary>
        public int Delivery_time { get; set; }

        /// <summary>
        /// upload_time
        /// </summary>
        public int Upload_time { get; set; }

        /// <summary>
        /// download_time
        /// </summary>
        public int Download_time { get; set; }

        /// <summary>
        /// delivery_rate
        /// </summary>
        public double Delivery_rate { get; set; }

        /// <summary>
        /// time_remaining
        /// </summary>
        public int Time_remaining { get; set; }

        /// <summary>
        /// percent_complete
        /// </summary>
        public decimal Percent_complete { get; set; }

        /// <summary>
        /// upload_inserts
        /// </summary>
        public int Upload_inserts { get; set; }

        /// <summary>
        /// upload_updates
        /// </summary>
        public int Upload_updates { get; set; }

        /// <summary>
        /// upload_deletes
        /// </summary>
        public int Upload_deletes { get; set; }

        /// <summary>
        /// upload_conflicts
        /// </summary>
        public int Upload_conflicts { get; set; }

        /// <summary>
        /// upload_conflicts_resolved
        /// </summary>
        public int Upload_conflicts_resolved { get; set; }

        /// <summary>
        /// upload_rows_retried
        /// </summary>
        public int Upload_rows_retried { get; set; }

        /// <summary>
        /// download_inserts
        /// </summary>
        public int Download_inserts { get; set; }

        /// <summary>
        /// download_updates
        /// </summary>
        public int Download_updates { get; set; }

        /// <summary>
        /// download_deletes
        /// </summary>
        public int Download_deletes { get; set; }

        /// <summary>
        /// download_conflicts
        /// </summary>
        public int Download_conflicts { get; set; }

        /// <summary>
        /// download_conflicts_resolved
        /// </summary>
        public int Download_conflicts_resolved { get; set; }

        /// <summary>
        /// download_rows_retried
        /// </summary>
        public int Download_rows_retried { get; set; }

        /// <summary>
        /// schema_changes
        /// </summary>
        public int Schema_changes { get; set; }

        /// <summary>
        /// metadata_rows_cleanedup
        /// </summary>
        public int Metadata_rows_cleanedup { get; set; }

        /// <summary>
        /// runstatus
        /// </summary>
        public int Runstatus { get; set; }

        /// <summary>
        /// estimated_upload_changes
        /// </summary>
        public int Estimated_upload_changes { get; set; }

        /// <summary>
        /// estimated_download_changes
        /// </summary>
        public int Estimated_download_changes { get; set; }

        /// <summary>
        /// connection_type
        /// </summary>
        public int Connection_type { get; set; }

        /// <summary>
        /// timestamp
        /// </summary>
        public TimeSpan Timestamp { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-settingshistory-transact-sql
    /// </summary>
    public class Table_MSmerge_settingshistory
    {
        /// <summary>
        /// eventtime
        /// </summary>
        public DateTime Eventtime { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// artid
        /// </summary>
        public object Artid { get; set; }

        /// <summary>
        /// eventtype
        /// </summary>
        public byte Eventtype { get; set; }

        /// <summary>
        /// propertyname
        /// </summary>
        public string Propertyname { get; set; }

        /// <summary>
        /// previousvalue
        /// </summary>
        public string Previousvalue { get; set; }

        /// <summary>
        /// newvalue
        /// </summary>
        public string Newvalue { get; set; }

        /// <summary>
        /// eventtext
        /// </summary>
        public string Eventtext { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-subscriptions-transact-sql
    /// </summary>
    public class Table_MSmerge_subscriptions
    {
        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// subscriber_id
        /// </summary>
        public short Subscriber_id { get; set; }

        /// <summary>
        /// subscriber_db
        /// </summary>
        public string Subscriber_db { get; set; }

        /// <summary>
        /// subscription_type
        /// </summary>
        public int Subscription_type { get; set; }

        /// <summary>
        /// sync_type
        /// </summary>
        public byte Sync_type { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// subscription_time
        /// </summary>
        public DateTime Subscription_time { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-tombstone-transact-sql
    /// </summary>
    public class Table_MSmerge_tombstone
    {
        /// <summary>
        /// rowguid
        /// </summary>
        public object Rowguid { get; set; }

        /// <summary>
        /// tablenick
        /// </summary>
        public int Tablenick { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// lineage
        /// </summary>
        public byte[] Lineage { get; set; }

        /// <summary>
        /// generation
        /// </summary>
        public int Generation { get; set; }

        /// <summary>
        /// logical_record_parent_rowguid
        /// </summary>
        public object Logical_record_parent_rowguid { get; set; }

        /// <summary>
        /// logical_record_lineage
        /// </summary>
        public byte[] Logical_record_lineage { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-conflictdetectionconfigrequest-transact-sql
    /// </summary>
    public class Table_MSpeer_conflictdetectionconfigrequest
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// sent_date
        /// </summary>
        public DateTime Sent_date { get; set; }

        /// <summary>
        /// timeout
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// modified_date
        /// </summary>
        public DateTime Modified_date { get; set; }

        /// <summary>
        /// progress_phase
        /// </summary>
        public string Progress_phase { get; set; }

        /// <summary>
        /// phase_timed_out
        /// </summary>
        public bool Phase_timed_out { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-conflictdetectionconfigresponse-transact-sql
    /// </summary>
    public class Table_MSpeer_conflictdetectionconfigresponse
    {
        /// <summary>
        /// request_id
        /// </summary>
        public int Request_id { get; set; }

        /// <summary>
        /// peer_node
        /// </summary>
        public string Peer_node { get; set; }

        /// <summary>
        /// peer_db
        /// </summary>
        public string Peer_db { get; set; }

        /// <summary>
        /// peer_version
        /// </summary>
        public string Peer_version { get; set; }

        /// <summary>
        /// peer_db_version
        /// </summary>
        public string Peer_db_version { get; set; }

        /// <summary>
        /// is_peer
        /// </summary>
        public bool Is_peer { get; set; }

        /// <summary>
        /// conflict_detection_enabled
        /// </summary>
        public bool Conflict_detection_enabled { get; set; }

        /// <summary>
        /// originator_id
        /// </summary>
        public byte[] Originator_id { get; set; }

        /// <summary>
        /// peer_conflict_retention
        /// </summary>
        public int Peer_conflict_retention { get; set; }

        /// <summary>
        /// peer_subscriptions
        /// </summary>
        public string Peer_subscriptions { get; set; }

        /// <summary>
        /// progress_phase
        /// </summary>
        public string Progress_phase { get; set; }

        /// <summary>
        /// modified_date
        /// </summary>
        public DateTime Modified_date { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-lsns-transact-sql
    /// </summary>
    public class Table_MSpeer_lsns
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// last_updated
        /// </summary>
        public DateTime Last_updated { get; set; }

        /// <summary>
        /// originator
        /// </summary>
        public string Originator { get; set; }

        /// <summary>
        /// originator_db
        /// </summary>
        public string Originator_db { get; set; }

        /// <summary>
        /// originator_publication
        /// </summary>
        public string Originator_publication { get; set; }

        /// <summary>
        /// originator_publication_id
        /// </summary>
        public int Originator_publication_id { get; set; }

        /// <summary>
        /// originator_db_version
        /// </summary>
        public int Originator_db_version { get; set; }

        /// <summary>
        /// originator_lsn
        /// </summary>
        public int Originator_lsn { get; set; }

        /// <summary>
        /// originator_version
        /// </summary>
        public int Originator_version { get; set; }

        /// <summary>
        /// originator_id
        /// </summary>
        public short Originator_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-originatorid-history-transact-sql
    /// </summary>
    public class Table_MSpeer_originatorid_history
    {
        /// <summary>
        /// originator_publication
        /// </summary>
        public string Originator_publication { get; set; }

        /// <summary>
        /// originator_id
        /// </summary>
        public int Originator_id { get; set; }

        /// <summary>
        /// originator_node
        /// </summary>
        public string Originator_node { get; set; }

        /// <summary>
        /// originator_db
        /// </summary>
        public string Originator_db { get; set; }

        /// <summary>
        /// originator_db_version
        /// </summary>
        public int Originator_db_version { get; set; }

        /// <summary>
        /// originator_version
        /// </summary>
        public int Originator_version { get; set; }

        /// <summary>
        /// inserted_date
        /// </summary>
        public DateTime Inserted_date { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-request-transact-sql
    /// </summary>
    public class Table_MSpeer_request
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// sent_date
        /// </summary>
        public DateTime Sent_date { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-response-transact-sql
    /// </summary>
    public class Table_MSpeer_response
    {
        /// <summary>
        /// request_id
        /// </summary>
        public int Request_id { get; set; }

        /// <summary>
        /// peer
        /// </summary>
        public string Peer { get; set; }

        /// <summary>
        /// peer_db
        /// </summary>
        public string Peer_db { get; set; }

        /// <summary>
        /// received_date
        /// </summary>
        public DateTime Received_date { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-topologyrequest-transact-sql
    /// </summary>
    public class Table_MSpeer_topologyrequest
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// sent_date
        /// </summary>
        public DateTime Sent_date { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-topologyresponse-transact-sql
    /// </summary>
    public class Table_MSpeer_topologyresponse
    {
        /// <summary>
        /// request_id
        /// </summary>
        public int Request_id { get; set; }

        /// <summary>
        /// peer
        /// </summary>
        public string Peer { get; set; }

        /// <summary>
        /// peer_version
        /// </summary>
        public int Peer_version { get; set; }

        /// <summary>
        /// peer_db
        /// </summary>
        public string Peer_db { get; set; }

        /// <summary>
        /// originator_id
        /// </summary>
        public int Originator_id { get; set; }

        /// <summary>
        /// peer_conflict_retention
        /// </summary>
        public int Peer_conflict_retention { get; set; }

        /// <summary>
        /// received_date
        /// </summary>
        public DateTime Received_date { get; set; }

        /// <summary>
        /// connection_info
        /// </summary>
        public string Connection_info { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspub-identity-range-transact-sql
    /// </summary>
    public class Table_MSpub_identity_range
    {
        /// <summary>
        /// objid
        /// </summary>
        public int Objid { get; set; }

        /// <summary>
        /// range
        /// </summary>
        public long Range { get; set; }

        /// <summary>
        /// pub_range
        /// </summary>
        public long Pub_range { get; set; }

        /// <summary>
        /// current_pub_range
        /// </summary>
        public long Current_pub_range { get; set; }

        /// <summary>
        /// threshold
        /// </summary>
        public int Threshold { get; set; }

        /// <summary>
        /// last_seed
        /// </summary>
        public long Last_seed { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspublication-access-transact-sql
    /// </summary>
    public class Table_MSpublication_access
    {
        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// login
        /// </summary>
        public string Login { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspublications-transact-sql
    /// </summary>
    public class Table_MSpublications
    {
        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// publication_type
        /// </summary>
        public int Publication_type { get; set; }

        /// <summary>
        /// thirdparty_flag
        /// </summary>
        public bool Thirdparty_flag { get; set; }

        /// <summary>
        /// independent_agent
        /// </summary>
        public bool Independent_agent { get; set; }

        /// <summary>
        /// immediate_sync
        /// </summary>
        public bool Immediate_sync { get; set; }

        /// <summary>
        /// allow_push
        /// </summary>
        public bool Allow_push { get; set; }

        /// <summary>
        /// allow_pull
        /// </summary>
        public bool Allow_pull { get; set; }

        /// <summary>
        /// allow_anonymous
        /// </summary>
        public bool Allow_anonymous { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// vendor_name
        /// </summary>
        public string Vendor_name { get; set; }

        /// <summary>
        /// retention
        /// </summary>
        public int Retention { get; set; }

        /// <summary>
        /// sync_method
        /// </summary>
        public int Sync_method { get; set; }

        /// <summary>
        /// allow_subscription_copy
        /// </summary>
        public bool Allow_subscription_copy { get; set; }

        /// <summary>
        /// thirdparty_options
        /// </summary>
        public int Thirdparty_options { get; set; }

        /// <summary>
        /// allow_queued_tran
        /// </summary>
        public bool Allow_queued_tran { get; set; }

        /// <summary>
        /// options
        /// </summary>
        public int Options { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspublicationthresholds-transact-sql
    /// </summary>
    public class Table_MSpublicationthresholds
    {
        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// metric_id
        /// </summary>
        public int Metric_id { get; set; }

        /// <summary>
        /// value
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// shouldalert
        /// </summary>
        public bool Shouldalert { get; set; }

        /// <summary>
        /// isenabled
        /// </summary>
        public bool Isenabled { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspublisher-databases-transact-sql
    /// </summary>
    public class Table_MSpublisher_databases
    {
        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// publisher_engine_edition
        /// </summary>
        public int Publisher_engine_edition { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msqreader-agents-transact-sql
    /// </summary>
    public class Table_MSqreader_agents
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
        /// job_id
        /// </summary>
        public byte[] Job_id { get; set; }

        /// <summary>
        /// profile_id
        /// </summary>
        public int Profile_id { get; set; }

        /// <summary>
        /// job_step_uid
        /// </summary>
        public object Job_step_uid { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msqreader-history-transact-sql
    /// </summary>
    public class Table_MSqreader_history
    {
        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// runstatus
        /// </summary>
        public int Runstatus { get; set; }

        /// <summary>
        /// start_time
        /// </summary>
        public DateTime Start_time { get; set; }

        /// <summary>
        /// time
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// transaction_id
        /// </summary>
        public string Transaction_id { get; set; }

        /// <summary>
        /// transaction_status
        /// </summary>
        public int Transaction_status { get; set; }

        /// <summary>
        /// transactions_processed
        /// </summary>
        public int Transactions_processed { get; set; }

        /// <summary>
        /// commands_processed
        /// </summary>
        public int Commands_processed { get; set; }

        /// <summary>
        /// delivery_rate
        /// </summary>
        public double Delivery_rate { get; set; }

        /// <summary>
        /// transaction_rate
        /// </summary>
        public double Transaction_rate { get; set; }

        /// <summary>
        /// subscriber
        /// </summary>
        public string Subscriber { get; set; }

        /// <summary>
        /// subscriberdb
        /// </summary>
        public string Subscriberdb { get; set; }

        /// <summary>
        /// error_id
        /// </summary>
        public int Error_id { get; set; }

        /// <summary>
        /// timestamp
        /// </summary>
        public TimeSpan Timestamp { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-backup-lsns-transact-sql
    /// </summary>
    public class Table_MSrepl_backup_lsns
    {
        /// <summary>
        /// publisher_database_id
        /// </summary>
        public int Publisher_database_id { get; set; }

        /// <summary>
        /// valid_xact_id
        /// </summary>
        public byte[] Valid_xact_id { get; set; }

        /// <summary>
        /// valid_xact_seqno
        /// </summary>
        public byte[] Valid_xact_seqno { get; set; }

        /// <summary>
        /// next_xact_id
        /// </summary>
        public byte[] Next_xact_id { get; set; }

        /// <summary>
        /// nextx_xact_seqno
        /// </summary>
        public byte[] Nextx_xact_seqno { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-commands-transact-sql
    /// </summary>
    public class Table_MSrepl_commands
    {
        /// <summary>
        /// publisher_database_id
        /// </summary>
        public int Publisher_database_id { get; set; }

        /// <summary>
        /// xact_seqno
        /// </summary>
        public byte[] Xact_seqno { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// article_id
        /// </summary>
        public int Article_id { get; set; }

        /// <summary>
        /// originator_id
        /// </summary>
        public int Originator_id { get; set; }

        /// <summary>
        /// command_id
        /// </summary>
        public int Command_id { get; set; }

        /// <summary>
        /// partial_command
        /// </summary>
        public bool Partial_command { get; set; }

        /// <summary>
        /// command
        /// </summary>
        public byte[] Command { get; set; }

        /// <summary>
        /// hashkey
        /// </summary>
        public int Hashkey { get; set; }

        /// <summary>
        /// originator_lsn
        /// </summary>
        public byte[] Originator_lsn { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-errors-transact-sql
    /// </summary>
    public class Table_MSrepl_errors
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// time
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// error_type_id
        /// </summary>
        public int Error_type_id { get; set; }

        /// <summary>
        /// source_type_id
        /// </summary>
        public int Source_type_id { get; set; }

        /// <summary>
        /// source_name
        /// </summary>
        public string Source_name { get; set; }

        /// <summary>
        /// error_code
        /// </summary>
        public string Error_code { get; set; }

        /// <summary>
        /// error_text
        /// </summary>
        public byte[] Error_text { get; set; }

        /// <summary>
        /// xact_seqno
        /// </summary>
        public byte[] Xact_seqno { get; set; }

        /// <summary>
        /// command_id
        /// </summary>
        public int Command_id { get; set; }

        /// <summary>
        /// session_id
        /// </summary>
        public int Session_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-identity-range-transact-sql
    /// </summary>
    public class Table_MSrepl_identity_range
    {
        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// tablename
        /// </summary>
        public string Tablename { get; set; }

        /// <summary>
        /// identity_support
        /// </summary>
        public int Identity_support { get; set; }

        /// <summary>
        /// next_seed
        /// </summary>
        public long Next_seed { get; set; }

        /// <summary>
        /// pub_range
        /// </summary>
        public long Pub_range { get; set; }

        /// <summary>
        /// range
        /// </summary>
        public long Range { get; set; }

        /// <summary>
        /// max_identity
        /// </summary>
        public long Max_identity { get; set; }

        /// <summary>
        /// threshold
        /// </summary>
        public int Threshold { get; set; }

        /// <summary>
        /// current_max
        /// </summary>
        public long Current_max { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-originators-transact-sql
    /// </summary>
    public class Table_MSrepl_originators
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// publisher_database_id
        /// </summary>
        public int Publisher_database_id { get; set; }

        /// <summary>
        /// srvname
        /// </summary>
        public string Srvname { get; set; }

        /// <summary>
        /// dbname
        /// </summary>
        public string Dbname { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// dbversion
        /// </summary>
        public int Dbversion { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-queuedtraninfo-transact-sql
    /// </summary>
    public class Table_MSrepl_queuedtraninfo
    {
        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// tranid
        /// </summary>
        public string Tranid { get; set; }

        /// <summary>
        /// maxorderkey
        /// </summary>
        public long Maxorderkey { get; set; }

        /// <summary>
        /// commandcount
        /// </summary>
        public long Commandcount { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-transactions-transact-sql
    /// </summary>
    public class Table_MSrepl_transactions
    {
        /// <summary>
        /// publisher_database_id
        /// </summary>
        public int Publisher_database_id { get; set; }

        /// <summary>
        /// xact_id
        /// </summary>
        public byte[] Xact_id { get; set; }

        /// <summary>
        /// xact_seqno
        /// </summary>
        public byte[] Xact_seqno { get; set; }

        /// <summary>
        /// entry_time
        /// </summary>
        public DateTime Entry_time { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-version-transact-sql
    /// </summary>
    public class Table_MSrepl_version
    {
        /// <summary>
        /// major_version
        /// </summary>
        public int Major_version { get; set; }

        /// <summary>
        /// minor_version
        /// </summary>
        public int Minor_version { get; set; }

        /// <summary>
        /// revision
        /// </summary>
        public int Revision { get; set; }

        /// <summary>
        /// db_existed
        /// </summary>
        public bool Db_existed { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-monitordata-transact-sql
    /// </summary>
    public class Table_MSreplication_monitordata
    {
        /// <summary>
        /// lastrefresh
        /// </summary>
        public DateTime Lastrefresh { get; set; }

        /// <summary>
        /// computetime
        /// </summary>
        public int Computetime { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_srvid
        /// </summary>
        public int Publisher_srvid { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// publication_type
        /// </summary>
        public int Publication_type { get; set; }

        /// <summary>
        /// agent_type
        /// </summary>
        public int Agent_type { get; set; }

        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// agent_name
        /// </summary>
        public string Agent_name { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public object Job_id { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// isagentrunningnow
        /// </summary>
        public bool Isagentrunningnow { get; set; }

        /// <summary>
        /// warning
        /// </summary>
        public int Warning { get; set; }

        /// <summary>
        /// last_distsync
        /// </summary>
        public DateTime Last_distsync { get; set; }

        /// <summary>
        /// agentstoptime
        /// </summary>
        public DateTime Agentstoptime { get; set; }

        /// <summary>
        /// distdb
        /// </summary>
        public string Distdb { get; set; }

        /// <summary>
        /// retention
        /// </summary>
        public int Retention { get; set; }

        /// <summary>
        /// time_stamp
        /// </summary>
        public DateTime Time_stamp { get; set; }

        /// <summary>
        /// worst_latency
        /// </summary>
        public int Worst_latency { get; set; }

        /// <summary>
        /// best_latency
        /// </summary>
        public int Best_latency { get; set; }

        /// <summary>
        /// avg_latency
        /// </summary>
        public int Avg_latency { get; set; }

        /// <summary>
        /// cur_latency
        /// </summary>
        public int Cur_latency { get; set; }

        /// <summary>
        /// worst_runspeedPerf
        /// </summary>
        public int Worst_runspeedPerf { get; set; }

        /// <summary>
        /// best_runspeedPerf
        /// </summary>
        public int Best_runspeedPerf { get; set; }

        /// <summary>
        /// average_runspeedPerf
        /// </summary>
        public int Average_runspeedPerf { get; set; }

        /// <summary>
        /// mergePerformance
        /// </summary>
        public int MergePerformance { get; set; }

        /// <summary>
        /// mergelatestsessionrunduration
        /// </summary>
        public int Mergelatestsessionrunduration { get; set; }

        /// <summary>
        /// mergelatestsessionrunspeed
        /// </summary>
        public double Mergelatestsessionrunspeed { get; set; }

        /// <summary>
        /// mergelatestsessionconnectiontype
        /// </summary>
        public int Mergelatestsessionconnectiontype { get; set; }

        /// <summary>
        /// retention_period_unit
        /// </summary>
        public byte Retention_period_unit { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-objects-transact-sql
    /// </summary>
    public class Table_MSreplication_objects
    {
        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// object_name
        /// </summary>
        public string Object_name { get; set; }

        /// <summary>
        /// object_type
        /// </summary>
        public string Object_type { get; set; }

        /// <summary>
        /// article
        /// </summary>
        public string Article { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-options-transact-sql
    /// </summary>
    public class Table_MSreplication_options
    {
        /// <summary>
        /// optname
        /// </summary>
        public string Optname { get; set; }

        /// <summary>
        /// value
        /// </summary>
        public bool Value { get; set; }

        /// <summary>
        /// major_version
        /// </summary>
        public int Major_version { get; set; }

        /// <summary>
        /// minor_version
        /// </summary>
        public int Minor_version { get; set; }

        /// <summary>
        /// revision
        /// </summary>
        public int Revision { get; set; }

        /// <summary>
        /// install_failures
        /// </summary>
        public int Install_failures { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-queue-transact-sql
    /// </summary>
    public class Table_MSreplication_queue
    {
        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// tranid
        /// </summary>
        public string Tranid { get; set; }

        /// <summary>
        /// data
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// datalen
        /// </summary>
        public int Datalen { get; set; }

        /// <summary>
        /// commandtype
        /// </summary>
        public int Commandtype { get; set; }

        /// <summary>
        /// insertdate
        /// </summary>
        public DateTime Insertdate { get; set; }

        /// <summary>
        /// orderkey
        /// </summary>
        public long Orderkey { get; set; }

        /// <summary>
        /// cmdstate
        /// </summary>
        public bool Cmdstate { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-subscriptions-transact-sql
    /// </summary>
    public class Table_MSreplication_subscriptions
    {
        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// independent_agent
        /// </summary>
        public bool Independent_agent { get; set; }

        /// <summary>
        /// subscription_type
        /// </summary>
        public int Subscription_type { get; set; }

        /// <summary>
        /// distribution_agent
        /// </summary>
        public string Distribution_agent { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// transaction_timestamp
        /// </summary>
        public byte[] Transaction_timestamp { get; set; }

        /// <summary>
        /// update_mode
        /// </summary>
        public byte Update_mode { get; set; }

        /// <summary>
        /// agent_id
        /// </summary>
        public byte[] Agent_id { get; set; }

        /// <summary>
        /// subscription_guid
        /// </summary>
        public byte[] Subscription_guid { get; set; }

        /// <summary>
        /// subid
        /// </summary>
        public byte[] Subid { get; set; }

        /// <summary>
        /// immediate_sync
        /// </summary>
        public bool Immediate_sync { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplmonthresholdmetrics-transact-sql
    /// </summary>
    public class Table_MSreplmonthresholdmetrics
    {
        /// <summary>
        /// metric_id
        /// </summary>
        public int Metric_id { get; set; }

        /// <summary>
        /// title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// warningbitstatus
        /// </summary>
        public int Warningbitstatus { get; set; }

        /// <summary>
        /// alertmessageid
        /// </summary>
        public int Alertmessageid { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// default_value
        /// </summary>
        public object Default_value { get; set; }

        /// <summary>
        /// min_value
        /// </summary>
        public object Min_value { get; set; }

        /// <summary>
        /// max_value
        /// </summary>
        public object Max_value { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssnapshot-agents-transact-sql
    /// </summary>
    public class Table_MSsnapshot_agents
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
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// publication_type
        /// </summary>
        public int Publication_type { get; set; }

        /// <summary>
        /// local_job
        /// </summary>
        public bool Local_job { get; set; }

        /// <summary>
        /// job_id
        /// </summary>
        public byte[] Job_id { get; set; }

        /// <summary>
        /// profile_id
        /// </summary>
        public int Profile_id { get; set; }

        /// <summary>
        /// dynamic_filter_login
        /// </summary>
        public string Dynamic_filter_login { get; set; }

        /// <summary>
        /// dynamic_filter_hostname
        /// </summary>
        public string Dynamic_filter_hostname { get; set; }

        /// <summary>
        /// publisher_security_mode
        /// </summary>
        public short Publisher_security_mode { get; set; }

        /// <summary>
        /// publisher_login
        /// </summary>
        public string Publisher_login { get; set; }

        /// <summary>
        /// publisher_password
        /// </summary>
        public string Publisher_password { get; set; }

        /// <summary>
        /// job_step_uid
        /// </summary>
        public object Job_step_uid { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssnapshot-history-transact-sql
    /// </summary>
    public class Table_MSsnapshot_history
    {
        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// runstatus
        /// </summary>
        public int Runstatus { get; set; }

        /// <summary>
        /// start_time
        /// </summary>
        public DateTime Start_time { get; set; }

        /// <summary>
        /// time
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// delivered_transactions
        /// </summary>
        public int Delivered_transactions { get; set; }

        /// <summary>
        /// delivered_commands
        /// </summary>
        public int Delivered_commands { get; set; }

        /// <summary>
        /// delivery_rate
        /// </summary>
        public double Delivery_rate { get; set; }

        /// <summary>
        /// error_id
        /// </summary>
        public int Error_id { get; set; }

        /// <summary>
        /// timestamp
        /// </summary>
        public TimeSpan Timestamp { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssnapshotdeliveryprogress-transact-sql
    /// </summary>
    public class Table_MSsnapshotdeliveryprogress
    {
        /// <summary>
        /// session_token
        /// </summary>
        public string Session_token { get; set; }

        /// <summary>
        /// progress_token_hash
        /// </summary>
        public int Progress_token_hash { get; set; }

        /// <summary>
        /// progress_token
        /// </summary>
        public string Progress_token { get; set; }

        /// <summary>
        /// progress_timestamp
        /// </summary>
        public DateTime Progress_timestamp { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssub-identity-range-transact-sql
    /// </summary>
    public class Table_MSsub_identity_range
    {
        /// <summary>
        /// objid
        /// </summary>
        public int Objid { get; set; }

        /// <summary>
        /// range
        /// </summary>
        public long Range { get; set; }

        /// <summary>
        /// last_seed
        /// </summary>
        public long Last_seed { get; set; }

        /// <summary>
        /// threshold
        /// </summary>
        public int Threshold { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscriber-info-transact-sql
    /// </summary>
    public class Table_MSsubscriber_info
    {
        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// subscriber
        /// </summary>
        public string Subscriber { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// login
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// security_mode
        /// </summary>
        public int Security_mode { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscriber-schedule-transact-sql
    /// </summary>
    public class Table_MSsubscriber_schedule
    {
        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// subscriber
        /// </summary>
        public string Subscriber { get; set; }

        /// <summary>
        /// agent_type
        /// </summary>
        public short Agent_type { get; set; }

        /// <summary>
        /// frequency_type
        /// </summary>
        public int Frequency_type { get; set; }

        /// <summary>
        /// frequency_interval
        /// </summary>
        public int Frequency_interval { get; set; }

        /// <summary>
        /// frequency_relative_interval
        /// </summary>
        public int Frequency_relative_interval { get; set; }

        /// <summary>
        /// frequency_recurrence_factor
        /// </summary>
        public int Frequency_recurrence_factor { get; set; }

        /// <summary>
        /// frequency_subday
        /// </summary>
        public int Frequency_subday { get; set; }

        /// <summary>
        /// frequency_subday_interval
        /// </summary>
        public int Frequency_subday_interval { get; set; }

        /// <summary>
        /// active_start_time_of_day
        /// </summary>
        public int Active_start_time_of_day { get; set; }

        /// <summary>
        /// active_end_time_of_day
        /// </summary>
        public int Active_end_time_of_day { get; set; }

        /// <summary>
        /// active_start_date
        /// </summary>
        public int Active_start_date { get; set; }

        /// <summary>
        /// active_end_date
        /// </summary>
        public int Active_end_date { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscription-agents-transact-sql
    /// </summary>
    public class Table_MSsubscription_agents
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// subscription_type
        /// </summary>
        public int Subscription_type { get; set; }

        /// <summary>
        /// queue_id
        /// </summary>
        public string Queue_id { get; set; }

        /// <summary>
        /// update_mode
        /// </summary>
        public byte Update_mode { get; set; }

        /// <summary>
        /// failover_mode
        /// </summary>
        public bool Failover_mode { get; set; }

        /// <summary>
        /// spid
        /// </summary>
        public int Spid { get; set; }

        /// <summary>
        /// login_time
        /// </summary>
        public DateTime Login_time { get; set; }

        /// <summary>
        /// allow_subscription_copy
        /// </summary>
        public bool Allow_subscription_copy { get; set; }

        /// <summary>
        /// attach_state
        /// </summary>
        public int Attach_state { get; set; }

        /// <summary>
        /// attach_version
        /// </summary>
        public byte[] Attach_version { get; set; }

        /// <summary>
        /// last_sync_status
        /// </summary>
        public int Last_sync_status { get; set; }

        /// <summary>
        /// last_sync_summary
        /// </summary>
        public string Last_sync_summary { get; set; }

        /// <summary>
        /// last_sync_time
        /// </summary>
        public DateTime Last_sync_time { get; set; }

        /// <summary>
        /// queue_server
        /// </summary>
        public string Queue_server { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscription-articles-transact-sql
    /// </summary>
    public class Table_MSsubscription_articles
    {
        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// artid
        /// </summary>
        public int Artid { get; set; }

        /// <summary>
        /// article
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// dest_table
        /// </summary>
        public string Dest_table { get; set; }

        /// <summary>
        /// owner
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// cft_table
        /// </summary>
        public string Cft_table { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscription-properties-transact-sql
    /// </summary>
    public class Table_MSsubscription_properties
    {
        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// publication_type
        /// </summary>
        public int Publication_type { get; set; }

        /// <summary>
        /// publisher_login
        /// </summary>
        public string Publisher_login { get; set; }

        /// <summary>
        /// publisher_password
        /// </summary>
        public string Publisher_password { get; set; }

        /// <summary>
        /// publisher_security_mode
        /// </summary>
        public int Publisher_security_mode { get; set; }

        /// <summary>
        /// distributor
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// distributor_login
        /// </summary>
        public string Distributor_login { get; set; }

        /// <summary>
        /// distributor_password
        /// </summary>
        public string Distributor_password { get; set; }

        /// <summary>
        /// distributor_security_mode
        /// </summary>
        public int Distributor_security_mode { get; set; }

        /// <summary>
        /// ftp_address
        /// </summary>
        public string Ftp_address { get; set; }

        /// <summary>
        /// ftp_port
        /// </summary>
        public int Ftp_port { get; set; }

        /// <summary>
        /// ftp_login
        /// </summary>
        public string Ftp_login { get; set; }

        /// <summary>
        /// ftp_password
        /// </summary>
        public string Ftp_password { get; set; }

        /// <summary>
        /// alt_snapshot_folder
        /// </summary>
        public string Alt_snapshot_folder { get; set; }

        /// <summary>
        /// working_directory
        /// </summary>
        public string Working_directory { get; set; }

        /// <summary>
        /// use_ftp
        /// </summary>
        public bool Use_ftp { get; set; }

        /// <summary>
        /// dts_package_name
        /// </summary>
        public string Dts_package_name { get; set; }

        /// <summary>
        /// dts_package_password
        /// </summary>
        public string Dts_package_password { get; set; }

        /// <summary>
        /// dts_package_location
        /// </summary>
        public int Dts_package_location { get; set; }

        /// <summary>
        /// enabled_for_syncmgr
        /// </summary>
        public bool Enabled_for_syncmgr { get; set; }

        /// <summary>
        /// offload_agent
        /// </summary>
        public bool Offload_agent { get; set; }

        /// <summary>
        /// offload_server
        /// </summary>
        public string Offload_server { get; set; }

        /// <summary>
        /// dynamic_snapshot_location
        /// </summary>
        public string Dynamic_snapshot_location { get; set; }

        /// <summary>
        /// use_web_sync
        /// </summary>
        public bool Use_web_sync { get; set; }

        /// <summary>
        /// internet_url
        /// </summary>
        public string Internet_url { get; set; }

        /// <summary>
        /// internet_login
        /// </summary>
        public string Internet_login { get; set; }

        /// <summary>
        /// internet_password
        /// </summary>
        public string Internet_password { get; set; }

        /// <summary>
        /// internet_security_mode
        /// </summary>
        public int Internet_security_mode { get; set; }

        /// <summary>
        /// internet_timeout
        /// </summary>
        public int Internet_timeout { get; set; }

        /// <summary>
        /// hostname
        /// </summary>
        public string Hostname { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscriptions-transact-sql
    /// </summary>
    public class Table_MSsubscriptions
    {
        /// <summary>
        /// publisher_database_id
        /// </summary>
        public int Publisher_database_id { get; set; }

        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// article_id
        /// </summary>
        public int Article_id { get; set; }

        /// <summary>
        /// subscriber_id
        /// </summary>
        public short Subscriber_id { get; set; }

        /// <summary>
        /// subscriber_db
        /// </summary>
        public string Subscriber_db { get; set; }

        /// <summary>
        /// subscription_type
        /// </summary>
        public int Subscription_type { get; set; }

        /// <summary>
        /// sync_type
        /// </summary>
        public byte Sync_type { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// subscription_seqno
        /// </summary>
        public byte[] Subscription_seqno { get; set; }

        /// <summary>
        /// snapshot_seqno_flag
        /// </summary>
        public bool Snapshot_seqno_flag { get; set; }

        /// <summary>
        /// independent_agent
        /// </summary>
        public bool Independent_agent { get; set; }

        /// <summary>
        /// subscription_time
        /// </summary>
        public DateTime Subscription_time { get; set; }

        /// <summary>
        /// loopback_detection
        /// </summary>
        public bool Loopback_detection { get; set; }

        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// update_mode
        /// </summary>
        public byte Update_mode { get; set; }

        /// <summary>
        /// publisher_seqno
        /// </summary>
        public byte[] Publisher_seqno { get; set; }

        /// <summary>
        /// ss_cplt_seqno
        /// </summary>
        public byte[] Ss_cplt_seqno { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssync-states-transact-sql
    /// </summary>
    public class Table_MSsync_states
    {
        /// <summary>
        /// publisher_id
        /// </summary>
        public short Publisher_id { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mstracer-history-transact-sql
    /// </summary>
    public class Table_MStracer_history
    {
        /// <summary>
        /// parent_tracer_id
        /// </summary>
        public int Parent_tracer_id { get; set; }

        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// subscriber_commit
        /// </summary>
        public DateTime Subscriber_commit { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mstracer-tokens-transact-sql
    /// </summary>
    public class Table_MStracer_tokens
    {
        /// <summary>
        /// tracer_id
        /// </summary>
        public int Tracer_id { get; set; }

        /// <summary>
        /// publication_id
        /// </summary>
        public int Publication_id { get; set; }

        /// <summary>
        /// publisher_commit
        /// </summary>
        public DateTime Publisher_commit { get; set; }

        /// <summary>
        /// distributor_commit
        /// </summary>
        public DateTime Distributor_commit { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysarticlecolumns-transact-sql
    /// </summary>
    public class Table_sysarticlecolumns
    {
        /// <summary>
        /// artid
        /// </summary>
        public int Artid { get; set; }

        /// <summary>
        /// colid
        /// </summary>
        public short Colid { get; set; }

        /// <summary>
        /// is_udt
        /// </summary>
        public bool Is_udt { get; set; }

        /// <summary>
        /// is_xml
        /// </summary>
        public bool Is_xml { get; set; }

        /// <summary>
        /// is_max
        /// </summary>
        public bool Is_max { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysarticles-transact-sql
    /// </summary>
    public class Table_sysarticles
    {
        /// <summary>
        /// artid
        /// </summary>
        public int Artid { get; set; }

        /// <summary>
        /// creation_script
        /// </summary>
        public string Creation_script { get; set; }

        /// <summary>
        /// del_cmd
        /// </summary>
        public string Del_cmd { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// dest_table
        /// </summary>
        public string Dest_table { get; set; }

        /// <summary>
        /// filter
        /// </summary>
        public int Filter { get; set; }

        /// <summary>
        /// filter_clause
        /// </summary>
        public byte[] Filter_clause { get; set; }

        /// <summary>
        /// ins_cmd
        /// </summary>
        public string Ins_cmd { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// objid
        /// </summary>
        public int Objid { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public int Pubid { get; set; }

        /// <summary>
        /// pre_creation_cmd
        /// </summary>
        public byte Pre_creation_cmd { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// sync_objid
        /// </summary>
        public int Sync_objid { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// upd_cmd
        /// </summary>
        public string Upd_cmd { get; set; }

        /// <summary>
        /// schema_option
        /// </summary>
        public byte[] Schema_option { get; set; }

        /// <summary>
        /// dest_owner
        /// </summary>
        public string Dest_owner { get; set; }

        /// <summary>
        /// ins_scripting_proc
        /// </summary>
        public int Ins_scripting_proc { get; set; }

        /// <summary>
        /// del_scripting_proc
        /// </summary>
        public int Del_scripting_proc { get; set; }

        /// <summary>
        /// upd_scripting_proc
        /// </summary>
        public int Upd_scripting_proc { get; set; }

        /// <summary>
        /// custom_script
        /// </summary>
        public string Custom_script { get; set; }

        /// <summary>
        /// fire_triggers_on_snapshot
        /// </summary>
        public bool Fire_triggers_on_snapshot { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysarticleupdates-transact-sql
    /// </summary>
    public class Table_sysarticleupdates
    {
        /// <summary>
        /// artid
        /// </summary>
        public int Artid { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public int Pubid { get; set; }

        /// <summary>
        /// sync_ins_proc
        /// </summary>
        public int Sync_ins_proc { get; set; }

        /// <summary>
        /// sync_upd_proc
        /// </summary>
        public int Sync_upd_proc { get; set; }

        /// <summary>
        /// sync_del_proc
        /// </summary>
        public int Sync_del_proc { get; set; }

        /// <summary>
        /// autogen
        /// </summary>
        public bool Autogen { get; set; }

        /// <summary>
        /// sync_upd_trig
        /// </summary>
        public int Sync_upd_trig { get; set; }

        /// <summary>
        /// conflict_tableid
        /// </summary>
        public int Conflict_tableid { get; set; }

        /// <summary>
        /// ins_conflict_proc
        /// </summary>
        public int Ins_conflict_proc { get; set; }

        /// <summary>
        /// identity_support
        /// </summary>
        public bool Identity_support { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergearticlecolumns-transact-sql
    /// </summary>
    public class Table_sysmergearticlecolumns
    {
        /// <summary>
        /// artid
        /// </summary>
        public int Artid { get; set; }

        /// <summary>
        /// colid
        /// </summary>
        public short Colid { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergearticles-transact-sql
    /// </summary>
    public class Table_sysmergearticles
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
        /// objid
        /// </summary>
        public int Objid { get; set; }

        /// <summary>
        /// sync_objid
        /// </summary>
        public int Sync_objid { get; set; }

        /// <summary>
        /// view_type
        /// </summary>
        public byte View_type { get; set; }

        /// <summary>
        /// artid
        /// </summary>
        public object Artid { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// pre_creation_command
        /// </summary>
        public byte Pre_creation_command { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// nickname
        /// </summary>
        public int Nickname { get; set; }

        /// <summary>
        /// column_tracking
        /// </summary>
        public int Column_tracking { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// conflict_table
        /// </summary>
        public string Conflict_table { get; set; }

        /// <summary>
        /// creation_script
        /// </summary>
        public string Creation_script { get; set; }

        /// <summary>
        /// conflict_script
        /// </summary>
        public string Conflict_script { get; set; }

        /// <summary>
        /// article_resolver
        /// </summary>
        public string Article_resolver { get; set; }

        /// <summary>
        /// ins_conflict_proc
        /// </summary>
        public string Ins_conflict_proc { get; set; }

        /// <summary>
        /// insert_proc
        /// </summary>
        public string Insert_proc { get; set; }

        /// <summary>
        /// update_proc
        /// </summary>
        public string Update_proc { get; set; }

        /// <summary>
        /// select_proc
        /// </summary>
        public string Select_proc { get; set; }

        /// <summary>
        /// metadata_select_proc
        /// </summary>
        public string Metadata_select_proc { get; set; }

        /// <summary>
        /// delete_proc
        /// </summary>
        public string Delete_proc { get; set; }

        /// <summary>
        /// schema_option
        /// </summary>
        public byte[] Schema_option { get; set; }

        /// <summary>
        /// destination_object
        /// </summary>
        public string Destination_object { get; set; }

        /// <summary>
        /// destination_owner
        /// </summary>
        public string Destination_owner { get; set; }

        /// <summary>
        /// resolver_clsid
        /// </summary>
        public string Resolver_clsid { get; set; }

        /// <summary>
        /// subset_filterclause
        /// </summary>
        public string Subset_filterclause { get; set; }

        /// <summary>
        /// missing_col_count
        /// </summary>
        public int Missing_col_count { get; set; }

        /// <summary>
        /// missing_cols
        /// </summary>
        public byte[] Missing_cols { get; set; }

        /// <summary>
        /// excluded_cols
        /// </summary>
        public byte[] Excluded_cols { get; set; }

        /// <summary>
        /// excluded_col_count
        /// </summary>
        public int Excluded_col_count { get; set; }

        /// <summary>
        /// columns
        /// </summary>
        public byte[] Columns { get; set; }

        /// <summary>
        /// deleted_cols
        /// </summary>
        public byte[] Deleted_cols { get; set; }

        /// <summary>
        /// resolver_info
        /// </summary>
        public string Resolver_info { get; set; }

        /// <summary>
        /// view_sel_proc
        /// </summary>
        public string View_sel_proc { get; set; }

        /// <summary>
        /// gen_cur
        /// </summary>
        public int Gen_cur { get; set; }

        /// <summary>
        /// vertical_partition
        /// </summary>
        public int Vertical_partition { get; set; }

        /// <summary>
        /// identity_support
        /// </summary>
        public int Identity_support { get; set; }

        /// <summary>
        /// before_image_objid
        /// </summary>
        public int Before_image_objid { get; set; }

        /// <summary>
        /// before_view_objid
        /// </summary>
        public int Before_view_objid { get; set; }

        /// <summary>
        /// verify_resolver_signature
        /// </summary>
        public int Verify_resolver_signature { get; set; }

        /// <summary>
        /// allow_interactive_resolver
        /// </summary>
        public bool Allow_interactive_resolver { get; set; }

        /// <summary>
        /// fast_multicol_updateproc
        /// </summary>
        public bool Fast_multicol_updateproc { get; set; }

        /// <summary>
        /// check_permissions
        /// </summary>
        public int Check_permissions { get; set; }

        /// <summary>
        /// maxversion_at_cleanup
        /// </summary>
        public int Maxversion_at_cleanup { get; set; }

        /// <summary>
        /// processing_order
        /// </summary>
        public int Processing_order { get; set; }

        /// <summary>
        /// upload_options
        /// </summary>
        public byte Upload_options { get; set; }

        /// <summary>
        /// published_in_tran_pub
        /// </summary>
        public bool Published_in_tran_pub { get; set; }

        /// <summary>
        /// lightweight
        /// </summary>
        public bool Lightweight { get; set; }

        /// <summary>
        /// procname_postfix
        /// </summary>
        public string Procname_postfix { get; set; }

        /// <summary>
        /// well_partitioned_lightweight
        /// </summary>
        public bool Well_partitioned_lightweight { get; set; }

        /// <summary>
        /// before_upd_view_objid
        /// </summary>
        public int Before_upd_view_objid { get; set; }

        /// <summary>
        /// delete_tracking
        /// </summary>
        public bool Delete_tracking { get; set; }

        /// <summary>
        /// compensate_for_errors
        /// </summary>
        public bool Compensate_for_errors { get; set; }

        /// <summary>
        /// pub_range
        /// </summary>
        public long Pub_range { get; set; }

        /// <summary>
        /// range
        /// </summary>
        public long Range { get; set; }

        /// <summary>
        /// threshold
        /// </summary>
        public int Threshold { get; set; }

        /// <summary>
        /// stream_blob_columns
        /// </summary>
        public bool Stream_blob_columns { get; set; }

        /// <summary>
        /// preserve_rowguidcol
        /// </summary>
        public bool Preserve_rowguidcol { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergepartitioninfo-transact-sql
    /// </summary>
    public class Table_sysmergepartitioninfo
    {
        /// <summary>
        /// artid
        /// </summary>
        public object Artid { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// partition_view_id
        /// </summary>
        public int Partition_view_id { get; set; }

        /// <summary>
        /// repl_view_id
        /// </summary>
        public int Repl_view_id { get; set; }

        /// <summary>
        /// partition_deleted_view_rule
        /// </summary>
        public string Partition_deleted_view_rule { get; set; }

        /// <summary>
        /// partition_inserted_view_rule
        /// </summary>
        public string Partition_inserted_view_rule { get; set; }

        /// <summary>
        /// membership_eval_proc_name
        /// </summary>
        public string Membership_eval_proc_name { get; set; }

        /// <summary>
        /// column_list
        /// </summary>
        public string Column_list { get; set; }

        /// <summary>
        /// column_list_blob
        /// </summary>
        public string Column_list_blob { get; set; }

        /// <summary>
        /// expand_proc
        /// </summary>
        public string Expand_proc { get; set; }

        /// <summary>
        /// logical_record_parent_nickname
        /// </summary>
        public int Logical_record_parent_nickname { get; set; }

        /// <summary>
        /// logical_record_view
        /// </summary>
        public int Logical_record_view { get; set; }

        /// <summary>
        /// logical_record_deleted_view_rule
        /// </summary>
        public string Logical_record_deleted_view_rule { get; set; }

        /// <summary>
        /// logical_record_level_conflict_detection
        /// </summary>
        public bool Logical_record_level_conflict_detection { get; set; }

        /// <summary>
        /// logical_record_level_conflict_resolution
        /// </summary>
        public bool Logical_record_level_conflict_resolution { get; set; }

        /// <summary>
        /// partition_options
        /// </summary>
        public byte Partition_options { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergepublications-transact-sql
    /// </summary>
    public class Table_sysmergepublications
    {
        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// retention
        /// </summary>
        public int Retention { get; set; }

        /// <summary>
        /// publication_type
        /// </summary>
        public byte Publication_type { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// designmasterid
        /// </summary>
        public object Designmasterid { get; set; }

        /// <summary>
        /// parentid
        /// </summary>
        public object Parentid { get; set; }

        /// <summary>
        /// sync_mode
        /// </summary>
        public byte Sync_mode { get; set; }

        /// <summary>
        /// allow_push
        /// </summary>
        public int Allow_push { get; set; }

        /// <summary>
        /// allow_pull
        /// </summary>
        public int Allow_pull { get; set; }

        /// <summary>
        /// allow_anonymous
        /// </summary>
        public int Allow_anonymous { get; set; }

        /// <summary>
        /// centralized_conflicts
        /// </summary>
        public int Centralized_conflicts { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// snapshot_ready
        /// </summary>
        public byte Snapshot_ready { get; set; }

        /// <summary>
        /// enabled_for_internet
        /// </summary>
        public bool Enabled_for_internet { get; set; }

        /// <summary>
        /// dynamic_filters
        /// </summary>
        public bool Dynamic_filters { get; set; }

        /// <summary>
        /// snapshot_in_defaultfolder
        /// </summary>
        public bool Snapshot_in_defaultfolder { get; set; }

        /// <summary>
        /// alt_snapshot_folder
        /// </summary>
        public string Alt_snapshot_folder { get; set; }

        /// <summary>
        /// pre_snapshot_script
        /// </summary>
        public string Pre_snapshot_script { get; set; }

        /// <summary>
        /// post_snapshot_script
        /// </summary>
        public string Post_snapshot_script { get; set; }

        /// <summary>
        /// compress_snapshot
        /// </summary>
        public bool Compress_snapshot { get; set; }

        /// <summary>
        /// ftp_address
        /// </summary>
        public string Ftp_address { get; set; }

        /// <summary>
        /// ftp_port
        /// </summary>
        public int Ftp_port { get; set; }

        /// <summary>
        /// ftp_subdirectory
        /// </summary>
        public string Ftp_subdirectory { get; set; }

        /// <summary>
        /// ftp_login
        /// </summary>
        public string Ftp_login { get; set; }

        /// <summary>
        /// ftp_password
        /// </summary>
        public string Ftp_password { get; set; }

        /// <summary>
        /// conflict_retention
        /// </summary>
        public int Conflict_retention { get; set; }

        /// <summary>
        /// keep_before_values
        /// </summary>
        public int Keep_before_values { get; set; }

        /// <summary>
        /// allow_subscription_copy
        /// </summary>
        public bool Allow_subscription_copy { get; set; }

        /// <summary>
        /// allow_synctoalternate
        /// </summary>
        public bool Allow_synctoalternate { get; set; }

        /// <summary>
        /// validate_subscriber_info
        /// </summary>
        public string Validate_subscriber_info { get; set; }

        /// <summary>
        /// ad_guidname
        /// </summary>
        public string Ad_guidname { get; set; }

        /// <summary>
        /// backward_comp_level
        /// </summary>
        public int Backward_comp_level { get; set; }

        /// <summary>
        /// max_concurrent_merge
        /// </summary>
        public int Max_concurrent_merge { get; set; }

        /// <summary>
        /// max_concurrent_dynamic_snapshots
        /// </summary>
        public int Max_concurrent_dynamic_snapshots { get; set; }

        /// <summary>
        /// use_partition_groups
        /// </summary>
        public short Use_partition_groups { get; set; }

        /// <summary>
        /// dynamic_filters_function_list
        /// </summary>
        public string Dynamic_filters_function_list { get; set; }

        /// <summary>
        /// partition_id_eval_proc
        /// </summary>
        public string Partition_id_eval_proc { get; set; }

        /// <summary>
        /// publication_number
        /// </summary>
        public short Publication_number { get; set; }

        /// <summary>
        /// replicate_ddl
        /// </summary>
        public int Replicate_ddl { get; set; }

        /// <summary>
        /// allow_subscriber_initiated_snapshot
        /// </summary>
        public bool Allow_subscriber_initiated_snapshot { get; set; }

        /// <summary>
        /// dynamic_snapshot_queue_timeout
        /// </summary>
        public int Dynamic_snapshot_queue_timeout { get; set; }

        /// <summary>
        /// dynamic_snapshot_ready_timeout
        /// </summary>
        public int Dynamic_snapshot_ready_timeout { get; set; }

        /// <summary>
        /// distributor
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// snapshot_jobid
        /// </summary>
        public byte[] Snapshot_jobid { get; set; }

        /// <summary>
        /// allow_web_synchronization
        /// </summary>
        public bool Allow_web_synchronization { get; set; }

        /// <summary>
        /// web_synchronization_url
        /// </summary>
        public string Web_synchronization_url { get; set; }

        /// <summary>
        /// allow_partition_realignment
        /// </summary>
        public bool Allow_partition_realignment { get; set; }

        /// <summary>
        /// retention_period_unit
        /// </summary>
        public byte Retention_period_unit { get; set; }

        /// <summary>
        /// decentralized_conflicts
        /// </summary>
        public int Decentralized_conflicts { get; set; }

        /// <summary>
        /// generation_leveling_threshold
        /// </summary>
        public int Generation_leveling_threshold { get; set; }

        /// <summary>
        /// automatic_reinitialization_policy
        /// </summary>
        public bool Automatic_reinitialization_policy { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergeschemaarticles-transact-sql
    /// </summary>
    public class Table_sysmergeschemaarticles
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
        /// objid
        /// </summary>
        public int Objid { get; set; }

        /// <summary>
        /// artid
        /// </summary>
        public object Artid { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// pre_creation_command
        /// </summary>
        public byte Pre_creation_command { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// creation_script
        /// </summary>
        public string Creation_script { get; set; }

        /// <summary>
        /// schema_option
        /// </summary>
        public byte[] Schema_option { get; set; }

        /// <summary>
        /// destination_object
        /// </summary>
        public string Destination_object { get; set; }

        /// <summary>
        /// destination_owner
        /// </summary>
        public string Destination_owner { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergeschemachange-transact-sql
    /// </summary>
    public class Table_sysmergeschemachange
    {
        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// artid
        /// </summary>
        public object Artid { get; set; }

        /// <summary>
        /// schemaversion
        /// </summary>
        public int Schemaversion { get; set; }

        /// <summary>
        /// schemaguid
        /// </summary>
        public object Schemaguid { get; set; }

        /// <summary>
        /// schematype
        /// </summary>
        public int Schematype { get; set; }

        /// <summary>
        /// schematext
        /// </summary>
        public string Schematext { get; set; }

        /// <summary>
        /// schemastatus
        /// </summary>
        public byte Schemastatus { get; set; }

        /// <summary>
        /// schemasubtype
        /// </summary>
        public int Schemasubtype { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergesubscriptions-transact-sql
    /// </summary>
    public class Table_sysmergesubscriptions
    {
        /// <summary>
        /// subscriber_server
        /// </summary>
        public string Subscriber_server { get; set; }

        /// <summary>
        /// db_name
        /// </summary>
        public string Db_name { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// datasource_type
        /// </summary>
        public int Datasource_type { get; set; }

        /// <summary>
        /// subid
        /// </summary>
        public object Subid { get; set; }

        /// <summary>
        /// replnickname
        /// </summary>
        public byte[] Replnickname { get; set; }

        /// <summary>
        /// replicastate
        /// </summary>
        public object Replicastate { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// subscriber_type
        /// </summary>
        public int Subscriber_type { get; set; }

        /// <summary>
        /// subscription_type
        /// </summary>
        public int Subscription_type { get; set; }

        /// <summary>
        /// sync_type
        /// </summary>
        public byte Sync_type { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// priority
        /// </summary>
        public double Priority { get; set; }

        /// <summary>
        /// recgen
        /// </summary>
        public long Recgen { get; set; }

        /// <summary>
        /// recguid
        /// </summary>
        public object Recguid { get; set; }

        /// <summary>
        /// sentgen
        /// </summary>
        public long Sentgen { get; set; }

        /// <summary>
        /// sentguid
        /// </summary>
        public object Sentguid { get; set; }

        /// <summary>
        /// schemaversion
        /// </summary>
        public int Schemaversion { get; set; }

        /// <summary>
        /// schemaguid
        /// </summary>
        public object Schemaguid { get; set; }

        /// <summary>
        /// last_validated
        /// </summary>
        public DateTime Last_validated { get; set; }

        /// <summary>
        /// attempted_validate
        /// </summary>
        public DateTime Attempted_validate { get; set; }

        /// <summary>
        /// last_sync_date
        /// </summary>
        public DateTime Last_sync_date { get; set; }

        /// <summary>
        /// last_sync_status
        /// </summary>
        public int Last_sync_status { get; set; }

        /// <summary>
        /// last_sync_summary
        /// </summary>
        public string Last_sync_summary { get; set; }

        /// <summary>
        /// metadatacleanuptime
        /// </summary>
        public DateTime Metadatacleanuptime { get; set; }

        /// <summary>
        /// partition_id
        /// </summary>
        public int Partition_id { get; set; }

        /// <summary>
        /// cleanedup_unsent_changes
        /// </summary>
        public bool Cleanedup_unsent_changes { get; set; }

        /// <summary>
        /// replica_version
        /// </summary>
        public int Replica_version { get; set; }

        /// <summary>
        /// supportability_mode
        /// </summary>
        public int Supportability_mode { get; set; }

        /// <summary>
        /// application_name
        /// </summary>
        public string Application_name { get; set; }

        /// <summary>
        /// subscriber_number
        /// </summary>
        public int Subscriber_number { get; set; }

        /// <summary>
        /// last_makegeneration_datetime
        /// </summary>
        public DateTime Last_makegeneration_datetime { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergesubsetfilters-transact-sql
    /// </summary>
    public class Table_sysmergesubsetfilters
    {
        /// <summary>
        /// filtername
        /// </summary>
        public string Filtername { get; set; }

        /// <summary>
        /// join_filterid
        /// </summary>
        public int Join_filterid { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public object Pubid { get; set; }

        /// <summary>
        /// artid
        /// </summary>
        public object Artid { get; set; }

        /// <summary>
        /// art_nickname
        /// </summary>
        public int Art_nickname { get; set; }

        /// <summary>
        /// join_articlename
        /// </summary>
        public string Join_articlename { get; set; }

        /// <summary>
        /// join_nickname
        /// </summary>
        public int Join_nickname { get; set; }

        /// <summary>
        /// join_unique_key
        /// </summary>
        public int Join_unique_key { get; set; }

        /// <summary>
        /// expand_proc
        /// </summary>
        public string Expand_proc { get; set; }

        /// <summary>
        /// join_filterclause
        /// </summary>
        public string Join_filterclause { get; set; }

        /// <summary>
        /// filter_type
        /// </summary>
        public byte Filter_type { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/syspublications-transact-sql
    /// </summary>
    public class Table_syspublications
    {
        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public int Pubid { get; set; }

        /// <summary>
        /// repl_freq
        /// </summary>
        public byte Repl_freq { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// sync_method
        /// </summary>
        public byte Sync_method { get; set; }

        /// <summary>
        /// snapshot_jobid
        /// </summary>
        public byte[] Snapshot_jobid { get; set; }

        /// <summary>
        /// independent_agent
        /// </summary>
        public bool Independent_agent { get; set; }

        /// <summary>
        /// immediate_sync
        /// </summary>
        public bool Immediate_sync { get; set; }

        /// <summary>
        /// enabled_for_internet
        /// </summary>
        public bool Enabled_for_internet { get; set; }

        /// <summary>
        /// allow_push
        /// </summary>
        public bool Allow_push { get; set; }

        /// <summary>
        /// allow_pull
        /// </summary>
        public bool Allow_pull { get; set; }

        /// <summary>
        /// allow_anonymous
        /// </summary>
        public bool Allow_anonymous { get; set; }

        /// <summary>
        /// immediate_sync_ready
        /// </summary>
        public bool Immediate_sync_ready { get; set; }

        /// <summary>
        /// allow_sync_tran
        /// </summary>
        public bool Allow_sync_tran { get; set; }

        /// <summary>
        /// autogen_sync_procs
        /// </summary>
        public bool Autogen_sync_procs { get; set; }

        /// <summary>
        /// retention
        /// </summary>
        public int Retention { get; set; }

        /// <summary>
        /// allowed_queued_tran
        /// </summary>
        public bool Allowed_queued_tran { get; set; }

        /// <summary>
        /// snapshot_in_defaultfolder
        /// </summary>
        public bool Snapshot_in_defaultfolder { get; set; }

        /// <summary>
        /// alt_snapshot_folder
        /// </summary>
        public string Alt_snapshot_folder { get; set; }

        /// <summary>
        /// pre_snapshot_script
        /// </summary>
        public string Pre_snapshot_script { get; set; }

        /// <summary>
        /// post_snapshot_script
        /// </summary>
        public string Post_snapshot_script { get; set; }

        /// <summary>
        /// compress_snapshot
        /// </summary>
        public bool Compress_snapshot { get; set; }

        /// <summary>
        /// ftp_address
        /// </summary>
        public string Ftp_address { get; set; }

        /// <summary>
        /// ftp_port
        /// </summary>
        public int Ftp_port { get; set; }

        /// <summary>
        /// ftp_subdirectory
        /// </summary>
        public string Ftp_subdirectory { get; set; }

        /// <summary>
        /// ftp_login
        /// </summary>
        public string Ftp_login { get; set; }

        /// <summary>
        /// ftp_password
        /// </summary>
        public string Ftp_password { get; set; }

        /// <summary>
        /// allow_dts
        /// </summary>
        public bool Allow_dts { get; set; }

        /// <summary>
        /// allow_subscription_copy
        /// </summary>
        public bool Allow_subscription_copy { get; set; }

        /// <summary>
        /// centralized_conflicts
        /// </summary>
        public bool Centralized_conflicts { get; set; }

        /// <summary>
        /// conflict_retention
        /// </summary>
        public int Conflict_retention { get; set; }

        /// <summary>
        /// conflict_policy
        /// </summary>
        public int Conflict_policy { get; set; }

        /// <summary>
        /// queue_type
        /// </summary>
        public int Queue_type { get; set; }

        /// <summary>
        /// ad_guidname
        /// </summary>
        public string Ad_guidname { get; set; }

        /// <summary>
        /// backward_comp_level
        /// </summary>
        public int Backward_comp_level { get; set; }

        /// <summary>
        /// allow_initialize_from_backup
        /// </summary>
        public bool Allow_initialize_from_backup { get; set; }

        /// <summary>
        /// min_autonosync_lsn
        /// </summary>
        public byte[] Min_autonosync_lsn { get; set; }

        /// <summary>
        /// replicate_ddl
        /// </summary>
        public int Replicate_ddl { get; set; }

        /// <summary>
        /// options
        /// </summary>
        public int Options { get; set; }

        /// <summary>
        /// originator_id
        /// </summary>
        public short Originator_id { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysreplicationalerts-transact-sql
    /// </summary>
    public class Table_sysreplicationalerts
    {
        /// <summary>
        /// alert_id
        /// </summary>
        public int Alert_id { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// agent_type
        /// </summary>
        public int Agent_type { get; set; }

        /// <summary>
        /// agent_id
        /// </summary>
        public int Agent_id { get; set; }

        /// <summary>
        /// error_id
        /// </summary>
        public int Error_id { get; set; }

        /// <summary>
        /// alert_error_code
        /// </summary>
        public int Alert_error_code { get; set; }

        /// <summary>
        /// time
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// publisher
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// publisher_db
        /// </summary>
        public string Publisher_db { get; set; }

        /// <summary>
        /// publication
        /// </summary>
        public string Publication { get; set; }

        /// <summary>
        /// publication_type
        /// </summary>
        public int Publication_type { get; set; }

        /// <summary>
        /// subscriber
        /// </summary>
        public string Subscriber { get; set; }

        /// <summary>
        /// subscriber_db
        /// </summary>
        public string Subscriber_db { get; set; }

        /// <summary>
        /// article
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// destination_object
        /// </summary>
        public string Destination_object { get; set; }

        /// <summary>
        /// source_object
        /// </summary>
        public string Source_object { get; set; }

        /// <summary>
        /// alert_error_text
        /// </summary>
        public byte[] Alert_error_text { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/syssubscriptions-transact-sql
    /// </summary>
    public class Table_syssubscriptions
    {
        /// <summary>
        /// artid
        /// </summary>
        public int Artid { get; set; }

        /// <summary>
        /// srvid
        /// </summary>
        public short Srvid { get; set; }

        /// <summary>
        /// dest_db
        /// </summary>
        public string Dest_db { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// sync_type
        /// </summary>
        public byte Sync_type { get; set; }

        /// <summary>
        /// login_name
        /// </summary>
        public string Login_name { get; set; }

        /// <summary>
        /// subscription_type
        /// </summary>
        public int Subscription_type { get; set; }

        /// <summary>
        /// distribution_jobid
        /// </summary>
        public byte[] Distribution_jobid { get; set; }

        /// <summary>
        /// timestamp
        /// </summary>
        public TimeSpan Timestamp { get; set; }

        /// <summary>
        /// update_mode
        /// </summary>
        public byte Update_mode { get; set; }

        /// <summary>
        /// loopback_detection
        /// </summary>
        public bool Loopback_detection { get; set; }

        /// <summary>
        /// queued_reinit
        /// </summary>
        public bool Queued_reinit { get; set; }

        /// <summary>
        /// nosync_type
        /// </summary>
        public byte Nosync_type { get; set; }

        /// <summary>
        /// srvname
        /// </summary>
        public string Srvname { get; set; }
    }

    //@@@ can't use.
    /// <summary>
    /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysschemaarticles-transact-sql
    /// </summary>
    public class Table_sysschemaarticles
    {
        /// <summary>
        /// artid
        /// </summary>
        public int Artid { get; set; }

        /// <summary>
        /// creation_script
        /// </summary>
        public string Creation_script { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// dest_object
        /// </summary>
        public string Dest_object { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// objid
        /// </summary>
        public int Objid { get; set; }

        /// <summary>
        /// pubid
        /// </summary>
        public int Pubid { get; set; }

        /// <summary>
        /// pre_creation_cmd
        /// </summary>
        public byte Pre_creation_cmd { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public byte Type { get; set; }

        /// <summary>
        /// schema_option
        /// </summary>
        public byte[] Schema_option { get; set; }

        /// <summary>
        /// dest_owner
        /// </summary>
        public string Dest_owner { get; set; }
    }

    /// <summary>
    /// Replication.
    /// </summary>
    public class Replication
    {
        //@@@ can't use.
        /*
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/conflict-schema-table-transact-sql
        /// conflict_<schema>_<table>
        /// </summary>
        [MemberTableConverter(Name = "conflict_<schema>_<table>")]
        public Table_conflict_<schema>_<table> Conflict_<schema>_<table> => throw new InvalitContextException(nameof(Conflict_<schema>_<table>));
        */

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/iharticles-transact-sql
        /// IHarticles
        /// </summary>
        [MemberTableConverter(Name = "IHarticles")]
        public Table_IHarticles IHarticles => throw new InvalitContextException(nameof(IHarticles));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihcolumns-transact-sql
        /// IHcolumns
        /// </summary>
        [MemberTableConverter(Name = "IHcolumns")]
        public Table_IHcolumns IHcolumns => throw new InvalitContextException(nameof(IHcolumns));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihconstrainttypes-transact-sql
        /// IHconstrainttypes
        /// </summary>
        [MemberTableConverter(Name = "IHconstrainttypes")]
        public Table_IHconstrainttypes IHconstrainttypes => throw new InvalitContextException(nameof(IHconstrainttypes));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihindextypes-transact-sql
        /// IHindextypes
        /// </summary>
        [MemberTableConverter(Name = "IHindextypes")]
        public Table_IHindextypes IHindextypes => throw new InvalitContextException(nameof(IHindextypes));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublications-transact-sql
        /// IHpublications
        /// </summary>
        [MemberTableConverter(Name = "IHpublications")]
        public Table_IHpublications IHpublications => throw new InvalitContextException(nameof(IHpublications));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishercolumnconstraints-transact-sql
        /// IHpublishercolumnconstraints
        /// </summary>
        [MemberTableConverter(Name = "IHpublishercolumnconstraints")]
        public Table_IHpublishercolumnconstraints IHpublishercolumnconstraints => throw new InvalitContextException(nameof(IHpublishercolumnconstraints));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishercolumnindexes-transact-sql
        /// IHpublishercolumnindexes
        /// </summary>
        [MemberTableConverter(Name = "IHpublishercolumnindexes")]
        public Table_IHpublishercolumnindexes IHpublishercolumnindexes => throw new InvalitContextException(nameof(IHpublishercolumnindexes));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishercolumns-transact-sql
        /// IHpublishercolumns
        /// </summary>
        [MemberTableConverter(Name = "IHpublishercolumns")]
        public Table_IHpublishercolumns IHpublishercolumns => throw new InvalitContextException(nameof(IHpublishercolumns));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublisherconstraints-transact-sql
        /// IHpublisherconstraints
        /// </summary>
        [MemberTableConverter(Name = "IHpublisherconstraints")]
        public Table_IHpublisherconstraints IHpublisherconstraints => throw new InvalitContextException(nameof(IHpublisherconstraints));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublisherindexes-transact-sql
        /// IHpublisherindexes
        /// </summary>
        [MemberTableConverter(Name = "IHpublisherindexes")]
        public Table_IHpublisherindexes IHpublisherindexes => throw new InvalitContextException(nameof(IHpublisherindexes));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishers-transact-sql
        /// IHpublishers
        /// </summary>
        [MemberTableConverter(Name = "IHpublishers")]
        public Table_IHpublishers IHpublishers => throw new InvalitContextException(nameof(IHpublishers));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihpublishertables-transact-sql
        /// IHpublishertables
        /// </summary>
        [MemberTableConverter(Name = "IHpublishertables")]
        public Table_IHpublishertables IHpublishertables => throw new InvalitContextException(nameof(IHpublishertables));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/ihsubscriptions-transact-sql
        /// IHsubscriptions
        /// </summary>
        [MemberTableConverter(Name = "IHsubscriptions")]
        public Table_IHsubscriptions IHsubscriptions => throw new InvalitContextException(nameof(IHsubscriptions));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msagent-parameters-transact-sql
        /// MSagent_parameters
        /// </summary>
        [MemberTableConverter(Name = "MSagent_parameters")]
        public Table_MSagent_parameters MSagent_parameters => throw new InvalitContextException(nameof(MSagent_parameters));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msagent-profiles-transact-sql
        /// MSagent_profiles
        /// </summary>
        [MemberTableConverter(Name = "MSagent_profiles")]
        public Table_MSagent_profiles MSagent_profiles => throw new InvalitContextException(nameof(MSagent_profiles));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msagentparameterlist-transact-sql
        /// MSagentparameterlist
        /// </summary>
        [MemberTableConverter(Name = "MSagentparameterlist")]
        public Table_MSagentparameterlist MSagentparameterlist => throw new InvalitContextException(nameof(MSagentparameterlist));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msarticles-transact-sql
        /// MSarticles
        /// </summary>
        [MemberTableConverter(Name = "MSarticles")]
        public Table_MSarticles MSarticles => throw new InvalitContextException(nameof(MSarticles));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mscached-peer-lsns-transact-sql
        /// MScached_peer_lsns
        /// </summary>
        [MemberTableConverter(Name = "MScached_peer_lsns")]
        public Table_MScached_peer_lsns MScached_peer_lsns => throw new InvalitContextException(nameof(MScached_peer_lsns));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistpublishers-transact-sql
        /// MSdistpublishers
        /// </summary>
        [MemberTableConverter(Name = "MSdistpublishers")]
        public Table_MSdistpublishers MSdistpublishers => throw new InvalitContextException(nameof(MSdistpublishers));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistribution-agents-transact-sql
        /// MSdistribution_agents
        /// </summary>
        [MemberTableConverter(Name = "MSdistribution_agents")]
        public Table_MSdistribution_agents MSdistribution_agents => throw new InvalitContextException(nameof(MSdistribution_agents));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistribution-history-transact-sql
        /// MSdistribution_history
        /// </summary>
        [MemberTableConverter(Name = "MSdistribution_history")]
        public Table_MSdistribution_history MSdistribution_history => throw new InvalitContextException(nameof(MSdistribution_history));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistributiondbs-transact-sql
        /// MSdistributiondbs
        /// </summary>
        [MemberTableConverter(Name = "MSdistributiondbs")]
        public Table_MSdistributiondbs MSdistributiondbs => throw new InvalitContextException(nameof(MSdistributiondbs));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdistributor-transact-sql
        /// MSdistributor
        /// </summary>
        [MemberTableConverter(Name = "MSdistributor")]
        public Table_MSdistributor MSdistributor => throw new InvalitContextException(nameof(MSdistributor));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdynamicsnapshotjobs-transact-sql
        /// MSdynamicsnapshotjobs
        /// </summary>
        [MemberTableConverter(Name = "MSdynamicsnapshotjobs")]
        public Table_MSdynamicsnapshotjobs MSdynamicsnapshotjobs => throw new InvalitContextException(nameof(MSdynamicsnapshotjobs));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msdynamicsnapshotviews-transact-sql
        /// MSdynamicsnapshotviews
        /// </summary>
        [MemberTableConverter(Name = "MSdynamicsnapshotviews")]
        public Table_MSdynamicsnapshotviews MSdynamicsnapshotviews => throw new InvalitContextException(nameof(MSdynamicsnapshotviews));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mslogreader-agents-transact-sql
        /// MSlogreader_agents
        /// </summary>
        [MemberTableConverter(Name = "MSlogreader_agents")]
        public Table_MSlogreader_agents MSlogreader_agents => throw new InvalitContextException(nameof(MSlogreader_agents));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mslogreader-history-transact-sql
        /// MSlogreader_history
        /// </summary>
        [MemberTableConverter(Name = "MSlogreader_history")]
        public Table_MSlogreader_history MSlogreader_history => throw new InvalitContextException(nameof(MSlogreader_history));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-agents-transact-sql
        /// MSmerge_agents
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_agents")]
        public Table_MSmerge_agents MSmerge_agents => throw new InvalitContextException(nameof(MSmerge_agents));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-articlehistory-transact-sql
        /// MSmerge_articlehistory
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_articlehistory")]
        public Table_MSmerge_articlehistory MSmerge_articlehistory => throw new InvalitContextException(nameof(MSmerge_articlehistory));

        /*
        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-conflict-publication-article-transact-sql
        /// MSmerge_conflict_<publication>_<article>
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_conflict_<publication>_<article>")]
        public Table_MSmerge_conflict_<publication> _<article> MSmerge_conflict_<publication> _<article> => throw new InvalitContextException(nameof(MSmerge_conflict_<publication> _<article>));
        */

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-conflicts-info-transact-sql
        /// MSmerge_conflicts_info
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_conflicts_info")]
        public Table_MSmerge_conflicts_info MSmerge_conflicts_info => throw new InvalitContextException(nameof(MSmerge_conflicts_info));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-contents-transact-sql
        /// MSmerge_contents
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_contents")]
        public Table_MSmerge_contents MSmerge_contents => throw new InvalitContextException(nameof(MSmerge_contents));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-current-partition-mappings
        /// MSmerge_current_partition_mappings
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_current_partition_mappings")]
        public Table_MSmerge_current_partition_mappings MSmerge_current_partition_mappings => throw new InvalitContextException(nameof(MSmerge_current_partition_mappings));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-dynamic-snapshots-transact-sql
        /// MSmerge_dynamic_snapshots
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_dynamic_snapshots")]
        public Table_MSmerge_dynamic_snapshots MSmerge_dynamic_snapshots => throw new InvalitContextException(nameof(MSmerge_dynamic_snapshots));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-errorlineage-transact-sql
        /// MSmerge_errorlineage
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_errorlineage")]
        public Table_MSmerge_errorlineage MSmerge_errorlineage => throw new InvalitContextException(nameof(MSmerge_errorlineage));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-generation-partition-mappings-transact-sql
        /// MSmerge_generation_partition_mappings
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_generation_partition_mappings")]
        public Table_MSmerge_generation_partition_mappings MSmerge_generation_partition_mappings => throw new InvalitContextException(nameof(MSmerge_generation_partition_mappings));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-genhistory-transact-sql
        /// MSmerge_genhistory
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_genhistory")]
        public Table_MSmerge_genhistory MSmerge_genhistory => throw new InvalitContextException(nameof(MSmerge_genhistory));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-history-transact-sql
        /// MSmerge_history
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_history")]
        public Table_MSmerge_history MSmerge_history => throw new InvalitContextException(nameof(MSmerge_history));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-identity-range-transact-sql
        /// MSmerge_identity_range
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_identity_range")]
        public Table_MSmerge_identity_range MSmerge_identity_range => throw new InvalitContextException(nameof(MSmerge_identity_range));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-identity-range-allocations-transact-sql
        /// MSmerge_identity_range_allocations
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_identity_range_allocations")]
        public Table_MSmerge_identity_range_allocations MSmerge_identity_range_allocations => throw new InvalitContextException(nameof(MSmerge_identity_range_allocations));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-metadataaction-request-transact-sql
        /// MSmerge_metadataaction_request
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_metadataaction_request")]
        public Table_MSmerge_metadataaction_request MSmerge_metadataaction_request => throw new InvalitContextException(nameof(MSmerge_metadataaction_request));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-partition-groups-transact-sql
        /// MSmerge_partition_groups
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_partition_groups")]
        public Table_MSmerge_partition_groups MSmerge_partition_groups => throw new InvalitContextException(nameof(MSmerge_partition_groups));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-past-partition-mappings-transact-sql
        /// MSmerge_past_partition_mappings
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_past_partition_mappings")]
        public Table_MSmerge_past_partition_mappings MSmerge_past_partition_mappings => throw new InvalitContextException(nameof(MSmerge_past_partition_mappings));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-replinfo-transact-sql
        /// MSmerge_replinfo
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_replinfo")]
        public Table_MSmerge_replinfo MSmerge_replinfo => throw new InvalitContextException(nameof(MSmerge_replinfo));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-sessions-transact-sql
        /// MSmerge_sessions
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_sessions")]
        public Table_MSmerge_sessions MSmerge_sessions => throw new InvalitContextException(nameof(MSmerge_sessions));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-settingshistory-transact-sql
        /// MSmerge_settingshistory
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_settingshistory")]
        public Table_MSmerge_settingshistory MSmerge_settingshistory => throw new InvalitContextException(nameof(MSmerge_settingshistory));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-subscriptions-transact-sql
        /// MSmerge_subscriptions
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_subscriptions")]
        public Table_MSmerge_subscriptions MSmerge_subscriptions => throw new InvalitContextException(nameof(MSmerge_subscriptions));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msmerge-tombstone-transact-sql
        /// MSmerge_tombstone
        /// </summary>
        [MemberTableConverter(Name = "MSmerge_tombstone")]
        public Table_MSmerge_tombstone MSmerge_tombstone => throw new InvalitContextException(nameof(MSmerge_tombstone));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-conflictdetectionconfigrequest-transact-sql
        /// MSpeer_conflictdetectionconfigrequest
        /// </summary>
        [MemberTableConverter(Name = "MSpeer_conflictdetectionconfigrequest")]
        public Table_MSpeer_conflictdetectionconfigrequest MSpeer_conflictdetectionconfigrequest => throw new InvalitContextException(nameof(MSpeer_conflictdetectionconfigrequest));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-conflictdetectionconfigresponse-transact-sql
        /// MSpeer_conflictdetectionconfigresponse
        /// </summary>
        [MemberTableConverter(Name = "MSpeer_conflictdetectionconfigresponse")]
        public Table_MSpeer_conflictdetectionconfigresponse MSpeer_conflictdetectionconfigresponse => throw new InvalitContextException(nameof(MSpeer_conflictdetectionconfigresponse));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-lsns-transact-sql
        /// MSpeer_lsns
        /// </summary>
        [MemberTableConverter(Name = "MSpeer_lsns")]
        public Table_MSpeer_lsns MSpeer_lsns => throw new InvalitContextException(nameof(MSpeer_lsns));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-originatorid-history-transact-sql
        /// MSpeer_originatorid_history
        /// </summary>
        [MemberTableConverter(Name = "MSpeer_originatorid_history")]
        public Table_MSpeer_originatorid_history MSpeer_originatorid_history => throw new InvalitContextException(nameof(MSpeer_originatorid_history));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-request-transact-sql
        /// MSpeer_request
        /// </summary>
        [MemberTableConverter(Name = "MSpeer_request")]
        public Table_MSpeer_request MSpeer_request => throw new InvalitContextException(nameof(MSpeer_request));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-response-transact-sql
        /// MSpeer_response
        /// </summary>
        [MemberTableConverter(Name = "MSpeer_response")]
        public Table_MSpeer_response MSpeer_response => throw new InvalitContextException(nameof(MSpeer_response));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-topologyrequest-transact-sql
        /// MSpeer_topologyrequest
        /// </summary>
        [MemberTableConverter(Name = "MSpeer_topologyrequest")]
        public Table_MSpeer_topologyrequest MSpeer_topologyrequest => throw new InvalitContextException(nameof(MSpeer_topologyrequest));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspeer-topologyresponse-transact-sql
        /// MSpeer_topologyresponse
        /// </summary>
        [MemberTableConverter(Name = "MSpeer_topologyresponse")]
        public Table_MSpeer_topologyresponse MSpeer_topologyresponse => throw new InvalitContextException(nameof(MSpeer_topologyresponse));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspub-identity-range-transact-sql
        /// MSpub_identity_range
        /// </summary>
        [MemberTableConverter(Name = "MSpub_identity_range")]
        public Table_MSpub_identity_range MSpub_identity_range => throw new InvalitContextException(nameof(MSpub_identity_range));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspublication-access-transact-sql
        /// MSpublication_access
        /// </summary>
        [MemberTableConverter(Name = "MSpublication_access")]
        public Table_MSpublication_access MSpublication_access => throw new InvalitContextException(nameof(MSpublication_access));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspublications-transact-sql
        /// MSpublications
        /// </summary>
        [MemberTableConverter(Name = "MSpublications")]
        public Table_MSpublications MSpublications => throw new InvalitContextException(nameof(MSpublications));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspublicationthresholds-transact-sql
        /// MSpublicationthresholds
        /// </summary>
        [MemberTableConverter(Name = "MSpublicationthresholds")]
        public Table_MSpublicationthresholds MSpublicationthresholds => throw new InvalitContextException(nameof(MSpublicationthresholds));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mspublisher-databases-transact-sql
        /// MSpublisher_databases
        /// </summary>
        [MemberTableConverter(Name = "MSpublisher_databases")]
        public Table_MSpublisher_databases MSpublisher_databases => throw new InvalitContextException(nameof(MSpublisher_databases));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msqreader-agents-transact-sql
        /// MSqreader_agents
        /// </summary>
        [MemberTableConverter(Name = "MSqreader_agents")]
        public Table_MSqreader_agents MSqreader_agents => throw new InvalitContextException(nameof(MSqreader_agents));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msqreader-history-transact-sql
        /// MSqreader_history
        /// </summary>
        [MemberTableConverter(Name = "MSqreader_history")]
        public Table_MSqreader_history MSqreader_history => throw new InvalitContextException(nameof(MSqreader_history));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-backup-lsns-transact-sql
        /// MSrepl_backup_lsns
        /// </summary>
        [MemberTableConverter(Name = "MSrepl_backup_lsns")]
        public Table_MSrepl_backup_lsns MSrepl_backup_lsns => throw new InvalitContextException(nameof(MSrepl_backup_lsns));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-commands-transact-sql
        /// MSrepl_commands
        /// </summary>
        [MemberTableConverter(Name = "MSrepl_commands")]
        public Table_MSrepl_commands MSrepl_commands => throw new InvalitContextException(nameof(MSrepl_commands));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-errors-transact-sql
        /// MSrepl_errors
        /// </summary>
        [MemberTableConverter(Name = "MSrepl_errors")]
        public Table_MSrepl_errors MSrepl_errors => throw new InvalitContextException(nameof(MSrepl_errors));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-identity-range-transact-sql
        /// MSrepl_identity_range
        /// </summary>
        [MemberTableConverter(Name = "MSrepl_identity_range")]
        public Table_MSrepl_identity_range MSrepl_identity_range => throw new InvalitContextException(nameof(MSrepl_identity_range));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-originators-transact-sql
        /// MSrepl_originators
        /// </summary>
        [MemberTableConverter(Name = "MSrepl_originators")]
        public Table_MSrepl_originators MSrepl_originators => throw new InvalitContextException(nameof(MSrepl_originators));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-queuedtraninfo-transact-sql
        /// MSrepl_queuedtraninfo
        /// </summary>
        [MemberTableConverter(Name = "MSrepl_queuedtraninfo")]
        public Table_MSrepl_queuedtraninfo MSrepl_queuedtraninfo => throw new InvalitContextException(nameof(MSrepl_queuedtraninfo));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-transactions-transact-sql
        /// MSrepl_transactions
        /// </summary>
        [MemberTableConverter(Name = "MSrepl_transactions")]
        public Table_MSrepl_transactions MSrepl_transactions => throw new InvalitContextException(nameof(MSrepl_transactions));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msrepl-version-transact-sql
        /// MSrepl_version
        /// </summary>
        [MemberTableConverter(Name = "MSrepl_version")]
        public Table_MSrepl_version MSrepl_version => throw new InvalitContextException(nameof(MSrepl_version));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-monitordata-transact-sql
        /// MSreplication_monitordata
        /// </summary>
        [MemberTableConverter(Name = "MSreplication_monitordata")]
        public Table_MSreplication_monitordata MSreplication_monitordata => throw new InvalitContextException(nameof(MSreplication_monitordata));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-objects-transact-sql
        /// MSreplication_objects
        /// </summary>
        [MemberTableConverter(Name = "MSreplication_objects")]
        public Table_MSreplication_objects MSreplication_objects => throw new InvalitContextException(nameof(MSreplication_objects));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-options-transact-sql
        /// MSreplication_options
        /// </summary>
        [MemberTableConverter(Name = "MSreplication_options")]
        public Table_MSreplication_options MSreplication_options => throw new InvalitContextException(nameof(MSreplication_options));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-queue-transact-sql
        /// MSreplication_queue
        /// </summary>
        [MemberTableConverter(Name = "MSreplication_queue")]
        public Table_MSreplication_queue MSreplication_queue => throw new InvalitContextException(nameof(MSreplication_queue));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplication-subscriptions-transact-sql
        /// MSreplication_subscriptions
        /// </summary>
        [MemberTableConverter(Name = "MSreplication_subscriptions")]
        public Table_MSreplication_subscriptions MSreplication_subscriptions => throw new InvalitContextException(nameof(MSreplication_subscriptions));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/msreplmonthresholdmetrics-transact-sql
        /// MSreplmonthresholdmetrics
        /// </summary>
        [MemberTableConverter(Name = "MSreplmonthresholdmetrics")]
        public Table_MSreplmonthresholdmetrics MSreplmonthresholdmetrics => throw new InvalitContextException(nameof(MSreplmonthresholdmetrics));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssnapshot-agents-transact-sql
        /// MSsnapshot_agents
        /// </summary>
        [MemberTableConverter(Name = "MSsnapshot_agents")]
        public Table_MSsnapshot_agents MSsnapshot_agents => throw new InvalitContextException(nameof(MSsnapshot_agents));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssnapshot-history-transact-sql
        /// MSsnapshot_history
        /// </summary>
        [MemberTableConverter(Name = "MSsnapshot_history")]
        public Table_MSsnapshot_history MSsnapshot_history => throw new InvalitContextException(nameof(MSsnapshot_history));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssnapshotdeliveryprogress-transact-sql
        /// MSsnapshotdeliveryprogress
        /// </summary>
        [MemberTableConverter(Name = "MSsnapshotdeliveryprogress")]
        public Table_MSsnapshotdeliveryprogress MSsnapshotdeliveryprogress => throw new InvalitContextException(nameof(MSsnapshotdeliveryprogress));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssub-identity-range-transact-sql
        /// MSsub_identity_range
        /// </summary>
        [MemberTableConverter(Name = "MSsub_identity_range")]
        public Table_MSsub_identity_range MSsub_identity_range => throw new InvalitContextException(nameof(MSsub_identity_range));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscriber-info-transact-sql
        /// MSsubscriber_info
        /// </summary>
        [MemberTableConverter(Name = "MSsubscriber_info")]
        public Table_MSsubscriber_info MSsubscriber_info => throw new InvalitContextException(nameof(MSsubscriber_info));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscriber-schedule-transact-sql
        /// MSsubscriber_schedule
        /// </summary>
        [MemberTableConverter(Name = "MSsubscriber_schedule")]
        public Table_MSsubscriber_schedule MSsubscriber_schedule => throw new InvalitContextException(nameof(MSsubscriber_schedule));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscription-agents-transact-sql
        /// MSsubscription_agents
        /// </summary>
        [MemberTableConverter(Name = "MSsubscription_agents")]
        public Table_MSsubscription_agents MSsubscription_agents => throw new InvalitContextException(nameof(MSsubscription_agents));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscription-articles-transact-sql
        /// MSsubscription_articles
        /// </summary>
        [MemberTableConverter(Name = "MSsubscription_articles")]
        public Table_MSsubscription_articles MSsubscription_articles => throw new InvalitContextException(nameof(MSsubscription_articles));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscription-properties-transact-sql
        /// MSsubscription_properties
        /// </summary>
        [MemberTableConverter(Name = "MSsubscription_properties")]
        public Table_MSsubscription_properties MSsubscription_properties => throw new InvalitContextException(nameof(MSsubscription_properties));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssubscriptions-transact-sql
        /// MSsubscriptions
        /// </summary>
        [MemberTableConverter(Name = "MSsubscriptions")]
        public Table_MSsubscriptions MSsubscriptions => throw new InvalitContextException(nameof(MSsubscriptions));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mssync-states-transact-sql
        /// MSsync_states
        /// </summary>
        [MemberTableConverter(Name = "MSsync_states")]
        public Table_MSsync_states MSsync_states => throw new InvalitContextException(nameof(MSsync_states));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mstracer-history-transact-sql
        /// MStracer_history
        /// </summary>
        [MemberTableConverter(Name = "MStracer_history")]
        public Table_MStracer_history MStracer_history => throw new InvalitContextException(nameof(MStracer_history));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/mstracer-tokens-transact-sql
        /// MStracer_tokens
        /// </summary>
        [MemberTableConverter(Name = "MStracer_tokens")]
        public Table_MStracer_tokens MStracer_tokens => throw new InvalitContextException(nameof(MStracer_tokens));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysarticlecolumns-transact-sql
        /// sysarticlecolumns
        /// </summary>
        [MemberTableConverter(Name = "sysarticlecolumns")]
        public Table_sysarticlecolumns Sysarticlecolumns => throw new InvalitContextException(nameof(Sysarticlecolumns));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysarticles-transact-sql
        /// sysarticles
        /// </summary>
        [MemberTableConverter(Name = "sysarticles")]
        public Table_sysarticles Sysarticles => throw new InvalitContextException(nameof(Sysarticles));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysarticleupdates-transact-sql
        /// sysarticleupdates
        /// </summary>
        [MemberTableConverter(Name = "sysarticleupdates")]
        public Table_sysarticleupdates Sysarticleupdates => throw new InvalitContextException(nameof(Sysarticleupdates));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergearticlecolumns-transact-sql
        /// sysmergearticlecolumns
        /// </summary>
        [MemberTableConverter(Name = "sysmergearticlecolumns")]
        public Table_sysmergearticlecolumns Sysmergearticlecolumns => throw new InvalitContextException(nameof(Sysmergearticlecolumns));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergearticles-transact-sql
        /// sysmergearticles
        /// </summary>
        [MemberTableConverter(Name = "sysmergearticles")]
        public Table_sysmergearticles Sysmergearticles => throw new InvalitContextException(nameof(Sysmergearticles));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergepartitioninfo-transact-sql
        /// sysmergepartitioninfo
        /// </summary>
        [MemberTableConverter(Name = "sysmergepartitioninfo")]
        public Table_sysmergepartitioninfo Sysmergepartitioninfo => throw new InvalitContextException(nameof(Sysmergepartitioninfo));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergepublications-transact-sql
        /// sysmergepublications
        /// </summary>
        [MemberTableConverter(Name = "sysmergepublications")]
        public Table_sysmergepublications Sysmergepublications => throw new InvalitContextException(nameof(Sysmergepublications));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergeschemaarticles-transact-sql
        /// sysmergeschemaarticles
        /// </summary>
        [MemberTableConverter(Name = "sysmergeschemaarticles")]
        public Table_sysmergeschemaarticles Sysmergeschemaarticles => throw new InvalitContextException(nameof(Sysmergeschemaarticles));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergeschemachange-transact-sql
        /// sysmergeschemachange
        /// </summary>
        [MemberTableConverter(Name = "sysmergeschemachange")]
        public Table_sysmergeschemachange Sysmergeschemachange => throw new InvalitContextException(nameof(Sysmergeschemachange));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergesubscriptions-transact-sql
        /// sysmergesubscriptions
        /// </summary>
        [MemberTableConverter(Name = "sysmergesubscriptions")]
        public Table_sysmergesubscriptions Sysmergesubscriptions => throw new InvalitContextException(nameof(Sysmergesubscriptions));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysmergesubsetfilters-transact-sql
        /// sysmergesubsetfilters
        /// </summary>
        [MemberTableConverter(Name = "sysmergesubsetfilters")]
        public Table_sysmergesubsetfilters Sysmergesubsetfilters => throw new InvalitContextException(nameof(Sysmergesubsetfilters));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/syspublications-transact-sql
        /// syspublications
        /// </summary>
        [MemberTableConverter(Name = "syspublications")]
        public Table_syspublications Syspublications => throw new InvalitContextException(nameof(Syspublications));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysreplicationalerts-transact-sql
        /// sysreplicationalerts
        /// </summary>
        [MemberTableConverter(Name = "sysreplicationalerts")]
        public Table_sysreplicationalerts Sysreplicationalerts => throw new InvalitContextException(nameof(Sysreplicationalerts));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/syssubscriptions-transact-sql
        /// syssubscriptions
        /// </summary>
        [MemberTableConverter(Name = "syssubscriptions")]
        public Table_syssubscriptions Syssubscriptions => throw new InvalitContextException(nameof(Syssubscriptions));

        //@@@ can't use.
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysschemaarticles-transact-sql
        /// sysschemaarticles
        /// </summary>
        [MemberTableConverter(Name = "sysschemaarticles")]
        public Table_sysschemaarticles Sysschemaarticles => throw new InvalitContextException(nameof(Sysschemaarticles));
    }
}