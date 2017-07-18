using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Symbol.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// Use[using static LambdicSql.SqlServer.Symbol;], you can use to write natural SQL.
    /// </summary>
    public static partial class Symbol
    {
        //--------------------------
        //Spatial Index Stored Procedures
        //--------------------------
        /// <summary>
        /// sp_help_spatial_geometry_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_index(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index));

        /// <summary>
        /// sp_help_spatial_geometry_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_index(string tabname, string indexname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index));

        /// <summary>
        /// sp_help_spatial_geometry_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_index(string tabname, string indexname, byte verboseoutput) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index));

        /// <summary>
        /// sp_help_spatial_geometry_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <param name="query_sample">Is a representative query sample that can be used to test the usefulness of the index.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_index(string tabname, string indexname, byte verboseoutput, object query_sample) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index));

        /// <summary>
        /// sp_help_spatial_geometry_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_index_xml(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index_xml));

        /// <summary>
        /// sp_help_spatial_geometry_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_index_xml(string tabname, string indexname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index_xml));

        /// <summary>
        /// sp_help_spatial_geometry_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_index_xml(string tabname, string indexname, byte verboseoutput) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index_xml));

        /// <summary>
        /// sp_help_spatial_geometry_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <param name="query_sample">Is a representative query sample that can be used to test the usefulness of the index.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_index_xml(string tabname, string indexname, byte verboseoutput, object query_sample) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index_xml));

        /// <summary>
        /// sp_help_spatial_geometry_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <param name="query_sample">Is a representative query sample that can be used to test the usefulness of the index.</param>
        /// <param name="xml_output">Is an output parameter that returns the result set in an XML fragment.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_index_xml(string tabname, string indexname, byte verboseoutput, object query_sample, string xml_output) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index_xml));

        /// <summary>
        /// sp_help_spatial_geography_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_index(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index));

        /// <summary>
        /// sp_help_spatial_geography_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_index(string tabname, string indexname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index));

        /// <summary>
        /// sp_help_spatial_geography_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_index(string tabname, string indexname, byte verboseoutput) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index));

        /// <summary>
        /// sp_help_spatial_geography_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <param name="query_sample">Is a representative query sample that can be used to test the usefulness of the index.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_index(string tabname, string indexname, byte verboseoutput, object query_sample) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index));

        /// <summary>
        /// sp_help_spatial_geography_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_index_xml(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index_xml));

        /// <summary>
        /// sp_help_spatial_geography_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_index_xml(string tabname, string indexname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index_xml));

        /// <summary>
        /// sp_help_spatial_geography_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_index_xml(string tabname, string indexname, byte verboseoutput) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index_xml));

        /// <summary>
        /// sp_help_spatial_geography_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <param name="query_sample">Is a representative query sample that can be used to test the usefulness of the index.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_index_xml(string tabname, string indexname, byte verboseoutput, object query_sample) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index_xml));

        /// <summary>
        /// sp_help_spatial_geography_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <param name="query_sample">Is a representative query sample that can be used to test the usefulness of the index.</param>
        /// <param name="xml_output">Is an output parameter that returns the result set in an XML fragment.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_index_xml(string tabname, string indexname, byte verboseoutput, object query_sample, string xml_output) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index_xml));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname, string columnname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname, string columnname, int resolution) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <param name="xmin">Is the X-minimum bounding box property.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname, string columnname, int resolution, float xmin) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <param name="xmin">Is the X-minimum bounding box property.</param>
        /// <param name="ymin">Is the Y-minimum bounding box property.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname, string columnname, int resolution, float xmin, float ymin) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <param name="xmin">Is the X-minimum bounding box property.</param>
        /// <param name="ymin">Is the Y-minimum bounding box property.</param>
        /// <param name="xmax">Is the X-maximum bounding box property. .</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname, string columnname, int resolution, float xmin, float ymin, float xmax) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <param name="xmin">Is the X-minimum bounding box property.</param>
        /// <param name="ymin">Is the Y-minimum bounding box property.</param>
        /// <param name="xmax">Is the X-maximum bounding box property. .</param>
        /// <param name="ymax">Is the Y-maximum bounding box property. .</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname, string columnname, int resolution, float xmin, float ymin, float xmax, float ymax) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <param name="xmin">Is the X-minimum bounding box property.</param>
        /// <param name="ymin">Is the Y-minimum bounding box property.</param>
        /// <param name="xmax">Is the X-maximum bounding box property. .</param>
        /// <param name="ymax">Is the Y-maximum bounding box property. .</param>
        /// <param name="sample">Is the percentage of the table that is used. Valid values are from 0 to 100</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname, string columnname, int resolution, float xmin, float ymin, float xmax, float ymax, float sample) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geography_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_histogram(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_histogram));

        /// <summary>
        /// sp_help_spatial_geography_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_histogram(string tabname, string columnname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_histogram));

        /// <summary>
        /// sp_help_spatial_geography_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_histogram(string tabname, string columnname, int resolution) => throw new InvalitContextException(nameof(sp_help_spatial_geography_histogram));

        /// <summary>
        /// sp_help_spatial_geography_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <param name="tablesample">Is the percentage of the table that is used.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static object sp_help_spatial_geography_histogram(string tabname, string columnname, int resolution, float tablesample) => throw new InvalitContextException(nameof(sp_help_spatial_geography_histogram));

        //--------------------------
        //Temporal Table
        //--------------------------
        /// <summary>
        /// sp_xtp_flush_temporal_history 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/temporal-table-sp-xtp-flush-temporal-history
        /// </summary>
        /// <param name="schema_name">The schema name for the current or temporal table.</param>
        /// <param name="object_name">The name of the current or temporal table.</param>
        /// <returns>Table.</returns>
        [ClauseStyleConverter]
        public static int sp_xtp_flush_temporal_history(string schema_name, string object_name) => throw new InvalitContextException(nameof(sp_xtp_flush_temporal_history));

        //--------------------------
        //Snapshot Backup
        //--------------------------
        /// <summary>
        /// sp_delete_backup_file_snapshot 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/snapshot-backup-sp-delete-backup-file-snapshot
        /// </summary>
        /// <param name="db_name">The name of the database containing the snapshot to be deleted, provided as a Unicode string.</param>
        /// <param name="snapshot_url">The URL of the snapshot to be deleted, provided as a Unicode string.</param>
        [ClauseStyleConverter]
        public static void sp_delete_backup_file_snapshot(string db_name, string snapshot_url) => throw new InvalitContextException(nameof(sp_delete_backup_file_snapshot));

        /// <summary>
        /// sp_delete_backup 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/snapshot-backup-sp-delete-backup
        /// </summary>
        /// <param name="backup_url">The URL of the backup to be deleted, which deletes all snapshots comprising the specified backup set including the backup file itself.</param>
        /// <param name="db_name">The name of the database containing the snapshot to be deleted.</param>
        [ClauseStyleConverter]
        public static void sp_delete_backup(string backup_url, string db_name) => throw new InvalitContextException(nameof(sp_delete_backup));

        //--------------------------
        //PolyBase stored procedures
        //--------------------------
        /// <summary>
        /// sp_polybase_join_group 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/polybase-stored-procedures-sp-polybase-join-group
        /// </summary>
        /// <param name="head_node_address">The name of the machine that hosts the SQL Server head node of the PolyBase scale-out group.</param>
        /// <param name="dms_control_channel_port">The port where the control channel for the head node PolyBase Data Movement Service is running.</param>
        /// <param name="head_node_sql_server_instance_name">The name of the head node SQL Server instance in the PolyBase scale-out group.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_polybase_join_group(string head_node_address, int dms_control_channel_port, string head_node_sql_server_instance_name) => throw new InvalitContextException(nameof(sp_polybase_join_group));

        /// <summary>
        /// sp_polybase_leave_group 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/polybase-stored-procedures-sp-polybase-leave-group
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_polybase_leave_group() => throw new InvalitContextException(nameof(sp_polybase_leave_group));

        //--------------------------
        //Filestream and FileTable
        //--------------------------
        /// <summary>
        /// sp_polybase_join_group 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-filestream-force-garbage-collection
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_filestream_force_garbage_collection() => throw new InvalitContextException(nameof(sp_filestream_force_garbage_collection));

        /// <summary>
        /// sp_polybase_join_group 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-filestream-force-garbage-collection
        /// </summary>
        /// <param name="dbname">Signifies the name of the database to run the garbage collector on.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_filestream_force_garbage_collection(string dbname) => throw new InvalitContextException(nameof(sp_filestream_force_garbage_collection));

        /// <summary>
        /// sp_polybase_join_group 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-filestream-force-garbage-collection
        /// </summary>
        /// <param name="dbname">Signifies the name of the database to run the garbage collector on.</param>
        /// <param name="filename">Specifies the logical name of the FILESTREAM container to run the garbage collector on.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_filestream_force_garbage_collection(string dbname, string filename) => throw new InvalitContextException(nameof(sp_filestream_force_garbage_collection));

        /// <summary>
        /// sp_kill_filestream_non_transacted_handles 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-kill-filestream-non-transacted-handles
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_kill_filestream_non_transacted_handles() => throw new InvalitContextException(nameof(sp_kill_filestream_non_transacted_handles));

        /// <summary>
        /// sp_kill_filestream_non_transacted_handles 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-kill-filestream-non-transacted-handles
        /// </summary>
        /// <param name="table_name">The name of the table in which to close non-transactional handles.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_kill_filestream_non_transacted_handles(string table_name) => throw new InvalitContextException(nameof(sp_kill_filestream_non_transacted_handles));

        /// <summary>
        /// sp_kill_filestream_non_transacted_handles 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-kill-filestream-non-transacted-handles
        /// </summary>
        /// <param name="table_name">The name of the table in which to close non-transactional handles.</param>
        /// <param name="handle_id">The optional ID of the individual handle to be closed.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_kill_filestream_non_transacted_handles(string table_name, object handle_id) => throw new InvalitContextException(nameof(sp_kill_filestream_non_transacted_handles));

        //--------------------------
        //Active Geo-Replication
        //--------------------------
        /// <summary>
        /// sp_wait_for_database_copy_sync 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/active-geo-replication-sp-wait-for-database-copy-sync
        /// </summary>
        /// <param name="target_server">The name of the SQL Database server that hosts the active secondary database.</param>
        /// <param name="target_database">The name of the active secondary database. database_name is sysname, with no default.</param>
        /// <returns>Returns 0 for success or an error number for failure</returns>
        [ClauseStyleConverter]
        public static int sp_wait_for_database_copy_sync(string target_server, string target_database) => throw new InvalitContextException(nameof(sp_wait_for_database_copy_sync));

        //--------------------------
        //Catalog Stored Procedures
        //--------------------------
        /// <summary>
        /// sp_column_privileges 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_column_privileges(string table_name) => throw new InvalitContextException(nameof(sp_column_privileges));

        /// <summary>
        /// sp_column_privileges 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        /// <param name="table_owner">Is the owner of the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_column_privileges(string table_name, string table_owner) => throw new InvalitContextException(nameof(sp_column_privileges));

        /// <summary>
        /// sp_column_privileges 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        /// <param name="table_owner">Is the owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_column_privileges(string table_name, string table_owner, string table_qualifier) => throw new InvalitContextException(nameof(sp_column_privileges));

        /// <summary>
        /// sp_column_privileges 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        /// <param name="table_owner">Is the owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="column_name">Is a single column used when only one column of catalog information is being obtained.</param>
        [ClauseStyleConverter]
        public static void sp_column_privileges(string table_name, string table_owner, string table_qualifier, string column_name) => throw new InvalitContextException(nameof(sp_column_privileges));

        /// <summary>
        /// sp_columns  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_columns(string table_name) => throw new InvalitContextException(nameof(sp_columns));

        /// <summary>
        /// sp_columns  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        /// <param name="table_owner">Is the owner of the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_columns(string table_name, string table_owner) => throw new InvalitContextException(nameof(sp_columns));

        /// <summary>
        /// sp_columns  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        /// <param name="table_owner">Is the owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_columns(string table_name, string table_owner, string table_qualifier) => throw new InvalitContextException(nameof(sp_columns));

        /// <summary>
        /// sp_columns  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        /// <param name="table_owner">Is the owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="column_name">Is a single column used when only one column of catalog information is being obtained.</param>
        [ClauseStyleConverter]
        public static void sp_columns(string table_name, string table_owner, string table_qualifier, string column_name) => throw new InvalitContextException(nameof(sp_columns));

        /// <summary>
        /// sp_columns  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        /// <param name="table_owner">Is the owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="column_name">Is a single column used when only one column of catalog information is being obtained.</param>
        /// <param name="ODBCVer">Is the version of ODBC that is being used.</param>
        [ClauseStyleConverter]
        public static void sp_columns(string table_name, string table_owner, string table_qualifier, string column_name, int ODBCVer) => throw new InvalitContextException(nameof(sp_columns));

        /// <summary>
        /// sp_databases  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-databases-transact-sql
        /// </summary>
        [ClauseStyleConverter]
        public static void sp_databases() => throw new InvalitContextException(nameof(sp_databases));

        /// <summary>
        /// sp_fkeys   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fkeys-transact-sql
        /// </summary>
        /// <param name="pktable_name">Is the name of the table, with the primary key, used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_fkeys(string pktable_name) => throw new InvalitContextException(nameof(sp_fkeys));

        /// <summary>
        /// sp_fkeys   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fkeys-transact-sql
        /// </summary>
        /// <param name="pktable_name">Is the name of the table, with the primary key, used to return catalog information.</param>
        /// <param name="pktable_owner">Is the name of the owner of the table (with the primary key) used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_fkeys(string pktable_name, string pktable_owner) => throw new InvalitContextException(nameof(sp_fkeys));

        /// <summary>
        /// sp_fkeys   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fkeys-transact-sql
        /// </summary>
        /// <param name="pktable_name">Is the name of the table, with the primary key, used to return catalog information.</param>
        /// <param name="pktable_owner">Is the name of the owner of the table (with the primary key) used to return catalog information.</param>
        /// <param name="pktable_qualifier">Is the name of the table (with the primary key) qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_fkeys(string pktable_name, string pktable_owner, string pktable_qualifier) => throw new InvalitContextException(nameof(sp_fkeys));

        /// <summary>
        /// sp_fkeys   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fkeys-transact-sql
        /// </summary>
        /// <param name="pktable_name">Is the name of the table, with the primary key, used to return catalog information.</param>
        /// <param name="pktable_owner">Is the name of the owner of the table (with the primary key) used to return catalog information.</param>
        /// <param name="pktable_qualifier">Is the name of the table (with the primary key) qualifier.</param>
        /// <param name="fktable_name">Is the name of the table (with a foreign key) used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_fkeys(string pktable_name, string pktable_owner, string pktable_qualifier, string fktable_name) => throw new InvalitContextException(nameof(sp_fkeys));

        /// <summary>
        /// sp_fkeys   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fkeys-transact-sql
        /// </summary>
        /// <param name="pktable_name">Is the name of the table, with the primary key, used to return catalog information.</param>
        /// <param name="pktable_owner">Is the name of the owner of the table (with the primary key) used to return catalog information.</param>
        /// <param name="pktable_qualifier">Is the name of the table (with the primary key) qualifier.</param>
        /// <param name="fktable_name">Is the name of the table (with a foreign key) used to return catalog information.</param>
        /// <param name="fktable_owner">Is the name of the owner of the table (with a foreign key) used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_fkeys(string pktable_name, string pktable_owner, string pktable_qualifier, string fktable_name, string fktable_owner) => throw new InvalitContextException(nameof(sp_fkeys));

        /// <summary>
        /// sp_fkeys   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fkeys-transact-sql
        /// </summary>
        /// <param name="pktable_name">Is the name of the table, with the primary key, used to return catalog information.</param>
        /// <param name="pktable_owner">Is the name of the owner of the table (with the primary key) used to return catalog information.</param>
        /// <param name="pktable_qualifier">Is the name of the table (with the primary key) qualifier.</param>
        /// <param name="fktable_name">Is the name of the table (with a foreign key) used to return catalog information.</param>
        /// <param name="fktable_owner">Is the name of the owner of the table (with a foreign key) used to return catalog information.</param>
        /// <param name="fktable_qualifier">Is the name of the table (with a foreign key) qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_fkeys(string pktable_name, string pktable_owner, string pktable_qualifier, string fktable_name, string fktable_owner, string fktable_qualifier) => throw new InvalitContextException(nameof(sp_fkeys));

        /// <summary>
        /// sp_pkeys   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-pkeys-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table for which to return information.</param>
        [ClauseStyleConverter]
        public static void sp_pkeys(string table_name) => throw new InvalitContextException(nameof(sp_pkeys));

        /// <summary>
        /// sp_pkeys   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-pkeys-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table for which to return information.</param>
        /// <param name="table_owner">Specifies the table owner of the specified table.</param>
        [ClauseStyleConverter]
        public static void sp_pkeys(string table_name, string table_owner) => throw new InvalitContextException(nameof(sp_pkeys));

        /// <summary>
        /// sp_pkeys   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-pkeys-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table for which to return information.</param>
        /// <param name="table_owner">Specifies the table owner of the specified table.</param>
        /// <param name="table_qualifier">Is the table qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_pkeys(string table_name, string table_owner, string table_qualifier) => throw new InvalitContextException(nameof(sp_pkeys));

        /// <summary>
        /// sp_server_info   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-info-transact-sql
        /// </summary>
        [ClauseStyleConverter]
        public static void sp_server_info() => throw new InvalitContextException(nameof(sp_server_info));

        /// <summary>
        /// sp_server_info   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-info-transact-sql
        /// </summary>
        /// <param name="attribute_id">Is the integer ID of the attribute.</param>
        [ClauseStyleConverter]
        public static void sp_server_info(int? attribute_id) => throw new InvalitContextException(nameof(sp_server_info));

        /// <summary>
        /// sp_special_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-info-transact-sql
        /// </summary>
        /// <param name="table_name">Is the name of the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_special_columns(string table_name) => throw new InvalitContextException(nameof(sp_special_columns));

        /// <summary>
        /// sp_special_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-info-transact-sql
        /// </summary>
        /// <param name="table_name">Is the name of the table used to return catalog information.</param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_special_columns(string table_name, string table_owner) => throw new InvalitContextException(nameof(sp_special_columns));

        /// <summary>
        /// sp_special_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-info-transact-sql
        /// </summary>
        /// <param name="table_name">Is the name of the table used to return catalog information.</param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="qualifier">Is the name of the table qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_special_columns(string table_name, string table_owner, string qualifier) => throw new InvalitContextException(nameof(sp_special_columns));

        /// <summary>
        /// sp_special_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-info-transact-sql
        /// </summary>
        /// <param name="table_name">Is the name of the table used to return catalog information.</param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="qualifier">Is the name of the table qualifier.</param>
        /// <param name="col_type">Is the column type.</param>
        [ClauseStyleConverter]
        public static void sp_special_columns(string table_name, string table_owner, string qualifier, char col_type) => throw new InvalitContextException(nameof(sp_special_columns));

        /// <summary>
        /// sp_special_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-info-transact-sql
        /// </summary>
        /// <param name="table_name">Is the name of the table used to return catalog information.</param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="qualifier">Is the name of the table qualifier.</param>
        /// <param name="col_type">Is the column type.</param>
        /// <param name="scope">Is the minimum required scope of the ROWID.</param>
        [ClauseStyleConverter]
        public static void sp_special_columns(string table_name, string table_owner, string qualifier, char col_type, char scope) => throw new InvalitContextException(nameof(sp_special_columns));

        /// <summary>
        /// sp_special_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-info-transact-sql
        /// </summary>
        /// <param name="table_name">Is the name of the table used to return catalog information.</param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="qualifier">Is the name of the table qualifier.</param>
        /// <param name="col_type">Is the column type.</param>
        /// <param name="scope">Is the minimum required scope of the ROWID.</param>
        /// <param name="nullable">Is whether the special columns can accept a null value.</param>
        [ClauseStyleConverter]
        public static void sp_special_columns(string table_name, string table_owner, string qualifier, char col_type, char scope, char nullable) => throw new InvalitContextException(nameof(sp_special_columns));

        /// <summary>
        /// sp_special_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-info-transact-sql
        /// </summary>
        /// <param name="table_name">Is the name of the table used to return catalog information.</param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="qualifier">Is the name of the table qualifier.</param>
        /// <param name="col_type">Is the column type.</param>
        /// <param name="scope">Is the minimum required scope of the ROWID.</param>
        /// <param name="nullable">Is whether the special columns can accept a null value.</param>
        /// <param name="ODBCVer">Is the ODBC version being used.</param>
        [ClauseStyleConverter]
        public static void sp_special_columns(string table_name, string table_owner, string qualifier, char col_type, char scope, char nullable, int ODBCVer) => throw new InvalitContextException(nameof(sp_special_columns));

        /// <summary>
        /// sp_sproc_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sproc-columns-transact-sql
        /// </summary>
        /// <param name="procedure_name">Is the name of the procedure used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_sproc_columns(string procedure_name) => throw new InvalitContextException(nameof(sp_sproc_columns));

        /// <summary>
        /// sp_sproc_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sproc-columns-transact-sql
        /// </summary>
        /// <param name="procedure_name">Is the name of the procedure used to return catalog information.</param>
        /// <param name="procedure_owner">Is the name of the owner of the procedure.</param>
        [ClauseStyleConverter]
        public static void sp_sproc_columns(string procedure_name, string procedure_owner) => throw new InvalitContextException(nameof(sp_sproc_columns));

        /// <summary>
        /// sp_sproc_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sproc-columns-transact-sql
        /// </summary>
        /// <param name="procedure_name">Is the name of the procedure used to return catalog information.</param>
        /// <param name="procedure_owner">Is the name of the owner of the procedure.</param>
        /// <param name="procedure_qualifier">Is the name of the procedure qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_sproc_columns(string procedure_name, string procedure_owner, string procedure_qualifier) => throw new InvalitContextException(nameof(sp_sproc_columns));

        /// <summary>
        /// sp_sproc_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sproc-columns-transact-sql
        /// </summary>
        /// <param name="procedure_name">Is the name of the procedure used to return catalog information.</param>
        /// <param name="procedure_owner">Is the name of the owner of the procedure.</param>
        /// <param name="procedure_qualifier">Is the name of the procedure qualifier.</param>
        /// <param name="column_name">Is a single column and is used when only one column of catalog information is desired.</param>
        [ClauseStyleConverter]
        public static void sp_sproc_columns(string procedure_name, string procedure_owner, string procedure_qualifier, string column_name) => throw new InvalitContextException(nameof(sp_sproc_columns));

        /// <summary>
        /// sp_sproc_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sproc-columns-transact-sql
        /// </summary>
        /// <param name="procedure_name">Is the name of the procedure used to return catalog information.</param>
        /// <param name="procedure_owner">Is the name of the owner of the procedure.</param>
        /// <param name="procedure_qualifier">Is the name of the procedure qualifier.</param>
        /// <param name="column_name">Is a single column and is used when only one column of catalog information is desired.</param>
        /// <param name="ODBCVer">Is the version of ODBC being used.</param>
        [ClauseStyleConverter]
        public static void sp_sproc_columns(string procedure_name, string procedure_owner, string procedure_qualifier, string column_name, int ODBCVer) => throw new InvalitContextException(nameof(sp_sproc_columns));

        /// <summary>
        /// sp_sproc_columns   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sproc-columns-transact-sql
        /// </summary>
        /// <param name="procedure_name">Is the name of the procedure used to return catalog information.</param>
        /// <param name="procedure_owner">Is the name of the owner of the procedure.</param>
        /// <param name="procedure_qualifier">Is the name of the procedure qualifier.</param>
        /// <param name="column_name">Is a single column and is used when only one column of catalog information is desired.</param>
        /// <param name="ODBCVer">Is the version of ODBC being used.</param>
        /// <param name="fUsePattern">Determines whether the underscore (_), percent (%), and bracket ([ ]) characters are interpreted as wildcard characters.</param>
        [ClauseStyleConverter]
        public static void sp_sproc_columns(string procedure_name, string procedure_owner, string procedure_qualifier, string column_name, int?ODBCVer, int? fUsePattern) => throw new InvalitContextException(nameof(sp_sproc_columns));

        /// <summary>
        /// sp_statistics   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-statistics-transact-sql
        /// </summary>
        /// <param name="table_name">Specifies the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_statistics(string table_name) => throw new InvalitContextException(nameof(sp_statistics));

        /// <summary>
        /// sp_statistics   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-statistics-transact-sql
        /// </summary>
        /// <param name="table_name">Specifies the table used to return catalog information.</param>
        /// <param name="table_owner">Is the name of the table owner of the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_statistics(string table_name, string table_owner) => throw new InvalitContextException(nameof(sp_statistics));

        /// <summary>
        /// sp_statistics   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-statistics-transact-sql
        /// </summary>
        /// <param name="table_name">Specifies the table used to return catalog information.</param>
        /// <param name="table_owner">Is the name of the table owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_statistics(string table_name, string table_owner, string table_qualifier) => throw new InvalitContextException(nameof(sp_statistics));

        /// <summary>
        /// sp_statistics   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-statistics-transact-sql
        /// </summary>
        /// <param name="table_name">Specifies the table used to return catalog information.</param>
        /// <param name="table_owner">Is the name of the table owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="index_name">Is the index name.</param>
        [ClauseStyleConverter]
        public static void sp_statistics(string table_name, string table_owner, string table_qualifier, string index_name) => throw new InvalitContextException(nameof(sp_statistics));

        /// <summary>
        /// sp_statistics   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-statistics-transact-sql
        /// </summary>
        /// <param name="table_name">Specifies the table used to return catalog information.</param>
        /// <param name="table_owner">Is the name of the table owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="index_name">Is the index name.</param>
        /// <param name="is_unique">Is whether only unique indexes (if Y) are to be returned.</param>
        [ClauseStyleConverter]
        public static void sp_statistics(string table_name, string table_owner, string table_qualifier, string index_name, char is_unique) => throw new InvalitContextException(nameof(sp_statistics));

        /// <summary>
        /// sp_statistics   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-statistics-transact-sql
        /// </summary>
        /// <param name="table_name">Specifies the table used to return catalog information.</param>
        /// <param name="table_owner">Is the name of the table owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="index_name">Is the index name.</param>
        /// <param name="is_unique">Is whether only unique indexes (if Y) are to be returned.</param>
        /// <param name="accuracy">Is the level of cardinality and page accuracy for statistics.</param>
        [ClauseStyleConverter]
        public static void sp_statistics(string table_name, string table_owner, string table_qualifier, string index_name, char is_unique, char accuracy) => throw new InvalitContextException(nameof(sp_statistics));

        /// <summary>
        /// sp_stored_procedures   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-stored-procedures-transact-sql
        /// </summary>
        /// <param name="sp_name">Is the name of the procedure used to return catalog information. </param>
        [ClauseStyleConverter]
        public static void sp_stored_procedures(string sp_name) => throw new InvalitContextException(nameof(sp_stored_procedures));

        /// <summary>
        /// sp_stored_procedures   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-stored-procedures-transact-sql
        /// </summary>
        /// <param name="sp_name">Is the name of the procedure used to return catalog information. </param>
        /// <param name="sp_owner">Is the name of the schema to which the procedure belongs.</param>
        [ClauseStyleConverter]
        public static void sp_stored_procedures(string sp_name, string sp_owner) => throw new InvalitContextException(nameof(sp_stored_procedures));

        /// <summary>
        /// sp_stored_procedures   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-stored-procedures-transact-sql
        /// </summary>
        /// <param name="sp_name">Is the name of the procedure used to return catalog information. </param>
        /// <param name="sp_owner">Is the name of the schema to which the procedure belongs.</param>
        /// <param name="qualifier">Is the name of the procedure qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_stored_procedures(string sp_name, string sp_owner, string qualifier) => throw new InvalitContextException(nameof(sp_stored_procedures));

        /// <summary>
        /// sp_stored_procedures   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-stored-procedures-transact-sql
        /// </summary>
        /// <param name="sp_name">Is the name of the procedure used to return catalog information. </param>
        /// <param name="sp_owner">Is the name of the schema to which the procedure belongs.</param>
        /// <param name="qualifier">Is the name of the procedure qualifier.</param>
        /// <param name="fUsePattern">Determines whether the underscore (_), percent (%), or brackets [ ]) are interpreted as wildcard characters.</param>
        [ClauseStyleConverter]
        public static void sp_stored_procedures(string sp_name, string sp_owner, string qualifier, int? fUsePattern) => throw new InvalitContextException(nameof(sp_stored_procedures));

        /// <summary>
        /// sp_table_privileges   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-table-privileges-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information. </param>
        [ClauseStyleConverter]
        public static void sp_table_privileges(string table_name) => throw new InvalitContextException(nameof(sp_table_privileges));

        /// <summary>
        /// sp_table_privileges   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-table-privileges-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information. </param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_table_privileges(string table_name, string table_owner) => throw new InvalitContextException(nameof(sp_table_privileges));

        /// <summary>
        /// sp_table_privileges   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-table-privileges-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information. </param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_table_privileges(string table_name, string table_owner, string table_qualifier) => throw new InvalitContextException(nameof(sp_table_privileges));

        /// <summary>
        /// sp_table_privileges   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-table-privileges-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information. </param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="fUsePattern">Determines whether the underscore (_), percent (%), and bracket ([ or ]) characters are interpreted as wildcard characters.</param>
        [ClauseStyleConverter]
        public static void sp_table_privileges(string table_name, string table_owner, string table_qualifier, int? fUsePattern) => throw new InvalitContextException(nameof(sp_table_privileges));

        /// <summary>
        /// sp_tables   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information. </param>
        [ClauseStyleConverter]
        public static void sp_tables(string table_name) => throw new InvalitContextException(nameof(sp_tables));

        /// <summary>
        /// sp_tables   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information. </param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        [ClauseStyleConverter]
        public static void sp_tables(string table_name, string table_owner) => throw new InvalitContextException(nameof(sp_tables));

        /// <summary>
        /// sp_tables   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information. </param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        [ClauseStyleConverter]
        public static void sp_tables(string table_name, string table_owner, string table_qualifier) => throw new InvalitContextException(nameof(sp_tables));

        /// <summary>
        /// sp_tables   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information. </param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="table_type">Is a list of values, separated by commas, that gives information about all tables of the table types that are specified.</param>
        [ClauseStyleConverter]
        public static void sp_tables(string table_name, string table_owner, string table_qualifier, string table_type) => throw new InvalitContextException(nameof(sp_tables));

        /// <summary>
        /// sp_tables   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information. </param>
        /// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="table_type">Is a list of values, separated by commas, that gives information about all tables of the table types that are specified.</param>
        /// <param name="fUsePattern">Determines whether the underscore ( _ ), percent ( % ), and bracket ( [ or ] ) characters are interpreted as wildcard characters.</param>
        [ClauseStyleConverter]
        public static void sp_tables(string table_name, string table_owner, string table_qualifier, string table_type, int? fUsePattern) => throw new InvalitContextException(nameof(sp_tables));

        //--------------------------
        //Cursor Stored Procedures
        //--------------------------
        //TODO:
        ///// <summary>
        ///// sp_tables   
        ///// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-transact-sql
        ///// </summary>
        ///// <param name="table_name">Is the table used to return catalog information. </param>
        ///// <param name="table_owner">Is the table owner of the table used to return catalog information.</param>
        ///// <param name="table_qualifier">Is the name of the table qualifier.</param>
        ///// <param name="table_type">Is a list of values, separated by commas, that gives information about all tables of the table types that are specified.</param>
        ///// <param name="fUsePattern">Determines whether the underscore ( _ ), percent ( % ), and bracket ( [ or ] ) characters are interpreted as wildcard characters.</param>
        //[ClauseStyleConverter]
        //public static void sp_cursor_list(string cursor_return, string table_owner, string table_qualifier, string table_type, int?fUsePattern) => throw new InvalitContextException(nameof(sp_tables));

        //--------------------------
        //Data Collector Stored Procedures
        //--------------------------
        /// <summary>
        /// sp_syscollector_create_collection_item   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="collector_type_uid">Is the GUID that identifies the collector type to use for this item collector_type_uid is uniqueidentifier with no default value.</param>
        /// <param name="name">Is the name of the collection item.</param>
        /// <param name="frequency">Is used to specify (in seconds) how frequently data is collected by this collection item.</param>
        /// <param name="parameters">The input parameters for the collector type.</param>
        /// <param name="collection_item_id">Is the unique identifer that identifies the collection set item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_item(int collection_set_id, string collector_type_uid, string name, int frequency, string parameters, int collection_item_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_item));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy account.</param>
        /// <param name="schedule_uid">Is the GUID that points to a schedule.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy account.</param>
        /// <param name="schedule_uid">Is the GUID that points to a schedule.</param>
        /// <param name="schedule_name">Is the name of the schedule.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy account.</param>
        /// <param name="schedule_uid">Is the GUID that points to a schedule.</param>
        /// <param name="schedule_name">Is the name of the schedule.</param>
        /// <param name="logging_level">Is the logging level.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy account.</param>
        /// <param name="schedule_uid">Is the GUID that points to a schedule.</param>
        /// <param name="schedule_name">Is the name of the schedule.</param>
        /// <param name="logging_level">Is the logging level.</param>
        /// <param name="description">Is the description of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level, string description) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy account.</param>
        /// <param name="schedule_uid">Is the GUID that points to a schedule.</param>
        /// <param name="schedule_name">Is the name of the schedule.</param>
        /// <param name="logging_level">Is the logging level.</param>
        /// <param name="description">Is the description of the collection set.</param>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level, string description, int collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy account.</param>
        /// <param name="schedule_uid">Is the GUID that points to a schedule.</param>
        /// <param name="schedule_name">Is the name of the schedule.</param>
        /// <param name="logging_level">Is the logging level.</param>
        /// <param name="description">Is the description of the collection set.</param>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="collection_set_uid">Is the GUID for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level, string description, int collection_set_id, string collection_set_uid) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collector_type   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collector_type(string collector_type_uid) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

        /// <summary>
        /// sp_syscollector_create_collector_type   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collector_type(string collector_type_uid, string name) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

        /// <summary>
        /// sp_syscollector_create_collector_type   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <param name="parameter_schema">Is the XML schema for this collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collector_type(string collector_type_uid, string name, string parameter_schema) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

        /// <summary>
        /// sp_syscollector_create_collector_type   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <param name="parameter_schema">Is the XML schema for this collector type.</param>
        /// <param name="parameter_formatter">Is the template to use to transform the XML for use in the collection set property page.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collector_type(string collector_type_uid, string name, string parameter_schema, string parameter_formatter) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

        /// <summary>
        /// sp_syscollector_create_collector_type   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <param name="parameter_schema">Is the XML schema for this collector type.</param>
        /// <param name="parameter_formatter">Is the template to use to transform the XML for use in the collection set property page.</param>
        /// <param name="collection_package_id">Is a local unique identifier that points to the SSIS collection package used by the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collector_type(string collector_type_uid, string name, string parameter_schema, string parameter_formatter, string collection_package_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

        /// <summary>
        /// sp_syscollector_create_collector_type   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <param name="parameter_schema">Is the XML schema for this collector type.</param>
        /// <param name="parameter_formatter">Is the template to use to transform the XML for use in the collection set property page.</param>
        /// <param name="collection_package_id">Is a local unique identifier that points to the SSIS collection package used by the collection set.</param>
        /// <param name="upload_package_id">Is a local unique identifier that points to the SSIS upload package used by the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_create_collector_type(string collector_type_uid, string name, string parameter_schema, string parameter_formatter, string collection_package_id, string upload_package_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

        /// <summary>
        /// sp_syscollector_delete_collection_item   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-item-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_collection_item() => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_item));

        /// <summary>
        /// sp_syscollector_delete_collection_item   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifier for the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_collection_item(int? collection_item_id) => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_item));

        /// <summary>
        /// sp_syscollector_delete_collection_item   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifier for the collection item.</param>
        /// <param name="name">Is the name of the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_collection_item(int? collection_item_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_item));

        /// <summary>
        /// sp_syscollector_delete_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_set));

        /// <summary>
        /// sp_syscollector_delete_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_set));

        /// <summary>
        /// sp_syscollector_delete_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_set));

        /// <summary>
        /// sp_syscollector_delete_collector_type    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collector-type-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_collector_type() => throw new InvalitContextException(nameof(sp_syscollector_delete_collector_type));

        /// <summary>
        /// sp_syscollector_delete_collector_type    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_collector_type(string collector_type_uid) => throw new InvalitContextException(nameof(sp_syscollector_delete_collector_type));

        /// <summary>
        /// sp_syscollector_delete_collector_type    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_collector_type(string collector_type_uid, string name) => throw new InvalitContextException(nameof(sp_syscollector_delete_collector_type));

        /// <summary>
        /// sp_syscollector_delete_execution_log_tree    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-execution-log-tree-transact-sql
        /// </summary>
        /// <param name="log_id">Is the unique identifier for the collection set log.</param>
        /// <param name="from_collection_set">Is the identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_delete_execution_log_tree(int log_id, int? from_collection_set) => throw new InvalitContextException(nameof(sp_syscollector_delete_execution_log_tree));

        /// <summary>
        /// sp_syscollector_disable_collector    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-disable-collector-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_disable_collector() => throw new InvalitContextException(nameof(sp_syscollector_disable_collector));

        /// <summary>
        /// sp_syscollector_enable_collector    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-enable-collector-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_enable_collector() => throw new InvalitContextException(nameof(sp_syscollector_enable_collector));

        /// <summary>
        /// sp_syscollector_set_cache_directory    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-set-cache-directory-transact-sql
        /// </summary>
        /// <param name="cache_directory">The directory in the file system where collected data is stored temporarily.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_set_cache_directory(string cache_directory) => throw new InvalitContextException(nameof(sp_syscollector_set_cache_directory));

        /// <summary>
        /// sp_syscollector_set_cache_window    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-set-cache-window-transact-sql
        /// </summary>
        /// <param name="cache_window">Is the number of times a failed data upload to the management data warehouse is retried without losing data.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_set_cache_window(int cache_window) => throw new InvalitContextException(nameof(sp_syscollector_set_cache_window));

        /// <summary>
        /// sp_syscollector_set_warehouse_database_name    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-set-warehouse-database-name-transact-sql
        /// </summary>
        /// <param name="database_name">Is the name of the management data warehouse.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_set_warehouse_database_name(string database_name) => throw new InvalitContextException(nameof(sp_syscollector_set_warehouse_database_name));

        /// <summary>
        /// sp_syscollector_set_warehouse_instance_name    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-set-warehouse-instance-name-transact-sql
        /// </summary>
        /// <param name="instance_name">Is the instance name.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_set_warehouse_instance_name(string instance_name) => throw new InvalitContextException(nameof(sp_syscollector_set_warehouse_instance_name));

        /// <summary>
        /// sp_syscollector_start_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-start-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_start_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_start_collection_set));

        /// <summary>
        /// sp_syscollector_start_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-start-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_start_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_start_collection_set));

        /// <summary>
        /// sp_syscollector_start_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-start-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_start_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_start_collection_set));

        /// <summary>
        /// sp_syscollector_stop_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-stop-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_stop_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_stop_collection_set));

        /// <summary>
        /// sp_syscollector_stop_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-stop-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_stop_collection_set(int? collection_set_id ) => throw new InvalitContextException(nameof(sp_syscollector_stop_collection_set));

        /// <summary>
        /// sp_syscollector_stop_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-stop-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_stop_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_stop_collection_set));

        /// <summary>
        /// sp_syscollector_stop_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-stop-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="stop_collection_job">Specifies that the collection job for the collection set be stopped if it is running.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_stop_collection_set(int? collection_set_id, string name, int? stop_collection_job) => throw new InvalitContextException(nameof(sp_syscollector_stop_collection_set));

        /// <summary>
        /// sp_syscollector_run_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-run-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_run_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_run_collection_set));

        /// <summary>
        /// sp_syscollector_run_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-run-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_run_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_run_collection_set));

        /// <summary>
        /// sp_syscollector_run_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-run-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_run_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_run_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_item() => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifer that identifies the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_item(int? collection_item_id) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifer that identifies the collection item.</param>
        /// <param name="name">Is the name of the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_item(int? collection_item_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifer that identifies the collection item.</param>
        /// <param name="name">Is the name of the collection item.</param>
        /// <param name="new_name">Is the new name for the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_item(int? collection_item_id, string name, string new_name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifer that identifies the collection item.</param>
        /// <param name="name">Is the name of the collection item.</param>
        /// <param name="new_name">Is the new name for the collection item.</param>
        /// <param name="frequency">Is the frequency (in seconds) that data is collected by this collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_item(int? collection_item_id, string name, string new_name, int frequency) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifer that identifies the collection item.</param>
        /// <param name="name">Is the name of the collection item.</param>
        /// <param name="new_name">Is the new name for the collection item.</param>
        /// <param name="frequency">Is the frequency (in seconds) that data is collected by this collection item.</param>
        /// <param name="parameters">The input parameters for the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_item(int? collection_item_id, string name, string new_name, int frequency, string parameters) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Is the type of data collection to use.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Is the type of data collection to use.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Is the type of data collection to use.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Is the type of data collection to use.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id, string proxy_name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Is the type of data collection to use.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy.</param>
        /// <param name="schedule_uid">Is the GUID that points to a schedule.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id, string proxy_name, string schedule_uid) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Is the type of data collection to use.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy.</param>
        /// <param name="schedule_uid">Is the GUID that points to a schedule.</param>
        /// <param name="schedule_name">Is the name of the schedule.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id, string proxy_name, string schedule_uid, string schedule_name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Is the type of data collection to use.</param>
        /// <param name="days_until_expiration">Is the number of days that the collected data is saved in the management data warehouse.</param>
        /// <param name="proxy_id">Is the unique identifier for a SQL Server Agent proxy account.</param>
        /// <param name="proxy_name">Is the name of the proxy.</param>
        /// <param name="schedule_uid">Is the GUID that points to a schedule.</param>
        /// <param name="schedule_name">Is the name of the schedule.</param>
        /// <param name="logging_level">Is the logging level.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collector_type    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <param name="parameter_schema">Is the XML schema for this collector type.</param>
        /// <param name="collection_package_id">Is a local unique identifier that points to the SSIS collection package used by the collection set.</param>
        /// <param name="upload_package_id">Is a local unique identifier that points to the SSIS upload package used by the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_update_collector_type(string collector_type_uid, string name, string parameter_schema, string collection_package_id, string upload_package_id) => throw new InvalitContextException(nameof(sp_syscollector_update_collector_type));

        /// <summary>
        /// sp_syscollector_upload_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-upload-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_upload_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_upload_collection_set));

        /// <summary>
        /// sp_syscollector_upload_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-upload-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_upload_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_upload_collection_set));

        /// <summary>
        /// sp_syscollector_upload_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-upload-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_syscollector_upload_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_upload_collection_set));

        //--------------------------
        //Database Engine Stored Procedures
        //--------------------------
        /// <summary>
        /// sp_add_data_file_recover_suspect_db    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-add-data-file-recover-suspect-db-transact-sql
        /// </summary>
        /// <param name="dbName">Is the name of the database.</param>
        /// <param name="filegroup">Is the filegroup to which to add the file.</param>
        /// <param name="name">Is the name used in the SQL Server to reference the file.</param>
        /// <param name="filename">Is the path and file name used by the operating system for the file.</param>
        /// <param name="size">Is the initial size of the file.</param>
        /// <param name="maxsize">Is the maximum size to which the file can grow.</param>
        /// <param name="filegrowth">Is the amount of space added to the file each time new space is required.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_add_data_file_recover_suspect_db(string dbName, string filegroup, string name, string filename, string size, string maxsize, string filegrowth) => throw new InvalitContextException(nameof(sp_add_data_file_recover_suspect_db));

        /// <summary>
        /// sp_addextendedproc    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproc-transact-sql
        /// </summary>
        /// <param name="functname">Is the name of the function to call within the dynamic-link library (DLL).</param>
        /// <param name="dllname">Is the name of the DLL that contains the function.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addextendedproc(string functname, string dllname) => throw new InvalitContextException(nameof(sp_addextendedproc));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addextendedproperty(string name) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <param name="value">Is the value to be associated with the property.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addextendedproperty(string name, object value) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <param name="value">Is the value to be associated with the property.</param>
        /// <param name="level0type">Is the type of level 0 object.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addextendedproperty(string name, object value, string level0type) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <param name="value">Is the value to be associated with the property.</param>
        /// <param name="level0type">Is the type of level 0 object.</param>
        /// <param name="level0name">Is the name of the level 0 object type specified.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addextendedproperty(string name, object value, string level0type, string level0name) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <param name="value">Is the value to be associated with the property.</param>
        /// <param name="level0type">Is the type of level 0 object.</param>
        /// <param name="level0name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1type">Is the type of level 1 object.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addextendedproperty(string name, object value, string level0type, string level0name, string level1type) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <param name="value">Is the value to be associated with the property.</param>
        /// <param name="level0type">Is the type of level 0 object.</param>
        /// <param name="level0name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1type">Is the type of level 1 object.</param>
        /// <param name="level1name">Is the name of the level 1 object type specified.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addextendedproperty(string name, object value, string level0type, string level0name, string level1type, string level1name) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <param name="value">Is the value to be associated with the property.</param>
        /// <param name="level0type">Is the type of level 0 object.</param>
        /// <param name="level0name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1type">Is the type of level 1 object.</param>
        /// <param name="level1name">Is the name of the level 1 object type specified.</param>
        /// <param name="level2type">Is the type of level 2 object.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addextendedproperty(string name, object value, string level0type, string level0name, string level1type, string level1name, string level2type) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <param name="value">Is the value to be associated with the property.</param>
        /// <param name="level0type">Is the type of level 0 object.</param>
        /// <param name="level0name">Is the name of the level 0 object type specified.</param>
        /// <param name="level1type">Is the type of level 1 object.</param>
        /// <param name="level1name">Is the name of the level 1 object type specified.</param>
        /// <param name="level2type">Is the type of level 2 object.</param>
        /// <param name="level2name">Is the name of the level 2 object type specified.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addextendedproperty(string name, object value, string level0type, string level0name, string level1type, string level1name, string level2type, string level2name) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_add_log_file_recover_suspect_db    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-add-log-file-recover-suspect-db-transact-sql
        /// </summary>
        /// <param name="dbName">Is the name of the property to be added.</param>
        /// <param name="name">Is the value to be associated with the property.</param>
        /// <param name="filename">Is the type of level 0 object.</param>
        /// <param name="size">Is the name of the level 0 object type specified.</param>
        /// <param name="maxsize">Is the type of level 1 object.</param>
        /// <param name="filegrowth">Is the name of the level 1 object type specified.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_add_log_file_recover_suspect_db(string dbName, string name, string filename, string size, string maxsize, string filegrowth) => throw new InvalitContextException(nameof(sp_add_log_file_recover_suspect_db));

        /// <summary>
        /// sp_addmessage    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addmessage-transact-sql
        /// </summary>
        /// <param name="msgnum">Is the ID of the message.</param>
        /// <param name="severity">Is the severity level of the error.</param>
        /// <param name="msgtext">Is the text of the error message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addmessage(int msgnum, short severity, string msgtext) => throw new InvalitContextException(nameof(sp_addmessage));

        /// <summary>
        /// sp_addmessage    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addmessage-transact-sql
        /// </summary>
        /// <param name="msgnum">Is the ID of the message.</param>
        /// <param name="severity">Is the severity level of the error.</param>
        /// <param name="msgtext">Is the text of the error message.</param>
        /// <param name="lang">Is the language for this message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addmessage(int msgnum, short severity, string msgtext, string lang) => throw new InvalitContextException(nameof(sp_addmessage));

        /// <summary>
        /// sp_addmessage    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addmessage-transact-sql
        /// </summary>
        /// <param name="msgnum">Is the ID of the message.</param>
        /// <param name="severity">Is the severity level of the error.</param>
        /// <param name="msgtext">Is the text of the error message.</param>
        /// <param name="lang">Is the language for this message.</param>
        /// <param name="with_log">Is whether the message is to be written to the Windows application log when it occurs.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addmessage(int msgnum, short severity, string msgtext, string lang, string with_log) => throw new InvalitContextException(nameof(sp_addmessage));

        /// <summary>
        /// sp_addmessage    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addmessage-transact-sql
        /// </summary>
        /// <param name="msgnum">Is the ID of the message.</param>
        /// <param name="severity">Is the severity level of the error.</param>
        /// <param name="msgtext">Is the text of the error message.</param>
        /// <param name="lang">Is the language for this message.</param>
        /// <param name="with_log">Is whether the message is to be written to the Windows application log when it occurs.</param>
        /// <param name="replace">If specified as the string replace, an existing error message is overwritten with new message text and severity level.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addmessage(int msgnum, short severity, string msgtext, string lang, string with_log, string replace) => throw new InvalitContextException(nameof(sp_addmessage));

        /// <summary>
        /// sp_addtype    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addtype-transact-sql
        /// </summary>
        /// <param name="typename">Is the name of the alias data type.</param>
        /// <param name="phystype">Is the physical, or SQL Server supplied, data type on which the alias data type is based.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addtype(string typename, string phystype) => throw new InvalitContextException(nameof(sp_addtype));

        /// <summary>
        /// sp_addumpdevice    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addumpdevice-transact-sql
        /// </summary>
        /// <param name="devtype">Is the type of backup device.</param>
        /// <param name="logicalname">Is the logical name of the backup device used in the BACKUP and RESTORE statements.</param>
        /// <param name="physicalname">Is the physical name of the backup device.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addumpdevice(string devtype, string logicalname, string physicalname) => throw new InvalitContextException(nameof(sp_addumpdevice));

        /// <summary>
        /// sp_altermessage     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-altermessage-transact-sql
        /// </summary>
        /// <param name="message_id">Is the error number of the message to alter from sys.messages.</param>
        /// <param name="parameter">Is used with @parameter_value to indicate that the message is to be written to the Microsoft Windows application log.</param>
        /// <param name="parameter_value">Is used with @parameter to indicate that the error is to be written to the Microsoft Windows application log.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_altermessage(int message_id, string parameter, string parameter_value) => throw new InvalitContextException(nameof(sp_altermessage));

        /// <summary>
        /// sp_attach_db     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-attach-db-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to be attached to the server.</param>
        /// <param name="filename1">Is the physical name, including path, of a database file.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_attach_db(string dbname, string filename1) => throw new InvalitContextException(nameof(sp_attach_db));

        /// <summary>
        /// sp_attach_single_file_db     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-attach-single-file-db-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to be attached to the server.</param>
        /// <param name="physname">Is the physical name, including path, of the database file.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_attach_single_file_db(string dbname, string physname) => throw new InvalitContextException(nameof(sp_attach_single_file_db));

        /// <summary>
        /// sp_autostats     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-autostats-transact-sql
        /// </summary>
        /// <param name="tblname">Is the name of the table or indexed view to display the AUTO_UPDATE_STATISTICS option on.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_autostats(string tblname) => throw new InvalitContextException(nameof(sp_autostats));

        /// <summary>
        /// sp_autostats     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-autostats-transact-sql
        /// </summary>
        /// <param name="tblname">Is the name of the table or indexed view to display the AUTO_UPDATE_STATISTICS option on.</param>
        /// <param name="flagc">Updates the AUTO_UPDATE_STATISTICS option to one of these values.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_autostats(string tblname, string flagc) => throw new InvalitContextException(nameof(sp_autostats));

        /// <summary>
        /// sp_autostats     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-autostats-transact-sql
        /// </summary>
        /// <param name="tblname">Is the name of the table or indexed view to display the AUTO_UPDATE_STATISTICS option on.</param>
        /// <param name="flagc">Updates the AUTO_UPDATE_STATISTICS option to one of these values.</param>
        /// <param name="indname">Is the name of the statistics to display or update the AUTO_UPDATE_STATISTICS option on.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_autostats(string tblname, string flagc, string indname) => throw new InvalitContextException(nameof(sp_autostats));

        /// <summary>
        /// sp_batch_params     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-batch-params-transact-sql
        /// </summary>
        [ClauseStyleConverter]
        public static void sp_batch_params() => throw new InvalitContextException(nameof(sp_batch_params));

        /// <summary>
        /// sp_batch_params     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-batch-params-transact-sql
        /// </summary>
        /// <param name="tsqlbatch">Is the name of the table or indexed view to display the AUTO_UPDATE_STATISTICS option on.</param>
        [ClauseStyleConverter]
        public static void sp_batch_params(string tsqlbatch) => throw new InvalitContextException(nameof(sp_batch_params));

        /// <summary>
        /// sp_bindefault     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-bindefault-transact-sql
        /// </summary>
        /// <param name="defname">Is the name of the default that is created by CREATE DEFAULT.</param>
        /// <param name="objname">Is the name of table and column or the alias data type to which the default is to be bound.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_bindefault(string defname, string objname) => throw new InvalitContextException(nameof(sp_bindefault));

        /// <summary>
        /// sp_bindefault     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-bindefault-transact-sql
        /// </summary>
        /// <param name="defname">Is the name of the default that is created by CREATE DEFAULT.</param>
        /// <param name="objname">Is the name of table and column or the alias data type to which the default is to be bound.</param>
        /// <param name="futureonly">Is used only when binding a default to an alias data type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_bindefault(string defname, string objname, string futureonly) => throw new InvalitContextException(nameof(sp_bindefault));

        /// <summary>
        /// sp_bindrule     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-bindrule-transact-sql
        /// </summary>
        /// <param name="rulename">Is the name of a rule created by the CREATE RULE statement.</param>
        /// <param name="objname">Is the table and column, or the alias data type to which the rule is to be bound.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_bindrule(string rulename, string objname) => throw new InvalitContextException(nameof(sp_bindrule));

        /// <summary>
        /// sp_bindrule     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-bindrule-transact-sql
        /// </summary>
        /// <param name="rulename">Is the name of a rule created by the CREATE RULE statement.</param>
        /// <param name="objname">Is the table and column, or the alias data type to which the rule is to be bound.</param>
        /// <param name="futureonly">Is used only when binding a rule to an alias data type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_bindrule(string rulename, string objname, string futureonly) => throw new InvalitContextException(nameof(sp_bindrule));

        /// <summary>
        /// sp_bindsession     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-bindsession-transact-sql
        /// </summary>
        /// <param name="bind_token">Is the name of a rule created by the CREATE RULE statement.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_bindsession(string bind_token) => throw new InvalitContextException(nameof(sp_bindsession));

        /// <summary>
        /// sp_certify_removable     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-certify-removable-transact-sql
        /// </summary>
        /// <param name="dbname">Specifies the database to be verified.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_certify_removable(string dbname) => throw new InvalitContextException(nameof(sp_certify_removable));

        /// <summary>
        /// sp_certify_removable     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-certify-removable-transact-sql
        /// </summary>
        /// <param name="dbname">Specifies the database to be verified.</param>
        /// <param name="autofix">Gives ownership of the database and all database objects to the system administrator, and drops any user-created database users and nondefault permissions.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_certify_removable(string dbname, string autofix) => throw new InvalitContextException(nameof(sp_certify_removable));

        /// <summary>
        /// sp_clean_db_free_space     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-clean-db-free-space-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to clean.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_clean_db_free_space(string dbname) => throw new InvalitContextException(nameof(sp_clean_db_free_space));

        /// <summary>
        /// sp_clean_db_free_space     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-clean-db-free-space-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to clean.</param>
        /// <param name="cleaning_delay">Specifies an interval to delay between the cleaning of pages.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_clean_db_free_space(string dbname, int cleaning_delay) => throw new InvalitContextException(nameof(sp_clean_db_free_space));

        /// <summary>
        /// sp_clean_db_file_free_space     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-clean-db-file-free-space-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to clean.</param>
        /// <param name="fileid">Is the data file id to clean.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_clean_db_file_free_space(string dbname, int fileid) => throw new InvalitContextException(nameof(sp_clean_db_file_free_space));

        /// <summary>
        /// sp_clean_db_file_free_space     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-clean-db-file-free-space-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to clean.</param>
        /// <param name="fileid">Is the data file id to clean.</param>
        /// <param name="cleaning_delay">Specifies an interval to delay between the cleaning of pages.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_clean_db_file_free_space(string dbname, int fileid, int cleaning_delay) => throw new InvalitContextException(nameof(sp_clean_db_file_free_space));

        /// <summary>
        /// sp_configure     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-configure-transact-sql
        /// </summary>
        /// <param name="configname">Is the name of a configuration option.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_configure(string configname) => throw new InvalitContextException(nameof(sp_configure));

        /// <summary>
        /// sp_configure     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-configure-transact-sql
        /// </summary>
        /// <param name="configname">Is the name of a configuration option.</param>
        /// <param name="configvalue">Is the new configuration setting.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_configure(string configname, int? configvalue) => throw new InvalitContextException(nameof(sp_configure));

        /// <summary>
        /// sp_control_plan_guide     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-control-plan-guide-transact-sql
        /// </summary>
        /// <param name="operation">DROP | DROP ALL| DISABLE | DISABLE ALL | ENABLE | ENABLE ALL</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_control_plan_guide(string operation) => throw new InvalitContextException(nameof(sp_control_plan_guide));

        /// <summary>
        /// sp_control_plan_guide     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-control-plan-guide-transact-sql
        /// </summary>
        /// <param name="operation">DROP | DROP ALL| DISABLE | DISABLE ALL | ENABLE | ENABLE ALL</param>
        /// <param name="name">Specifies the plan guide that is being dropped, enabled, or disabled.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_control_plan_guide(string operation, string name) => throw new InvalitContextException(nameof(sp_control_plan_guide));

        /// <summary>
        /// sp_create_plan_guide     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-create-plan-guide-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the plan guide.</param>
        /// <param name="stmt">Is a Transact-SQL statement against which to create a plan guide.</param>
        /// <param name="type">Is the type of entity in which statement_text appears.</param>
        /// <param name="module_or_batch">Specifies either the name of the object in which statement_text appears, or the batch text in which statement_text appears.</param>
        /// <param name="params">Specifies the definitions of all parameters that are embedded in statement_text.</param>
        /// <param name="hint">Specifies an OPTION clause to attach to a query that matches @stmt.</param>
        [ClauseStyleConverter]
        public static void sp_create_plan_guide(string name, string stmt, string type, string module_or_batch, string @params, string hint) => throw new InvalitContextException(nameof(sp_create_plan_guide));

        /// <summary>
        /// sp_create_plan_guide_from_handle     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-create-plan-guide-from-handle-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the plan guide.</param>
        /// <param name="plan_handle">Identifies a batch in the plan cache.</param>
        [ClauseStyleConverter]
        public static void sp_create_plan_guide_from_handle(string name, string plan_handle) => throw new InvalitContextException(nameof(sp_create_plan_guide_from_handle));

        /// <summary>
        /// sp_create_plan_guide_from_handle     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-create-plan-guide-from-handle-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the plan guide.</param>
        /// <param name="plan_handle">Identifies a batch in the plan cache.</param>
        /// <param name="statement_start_offset">Identifies the starting position of the statement within the batch of the specified plan_handle.</param>
        [ClauseStyleConverter]
        public static void sp_create_plan_guide_from_handle(string name, string plan_handle, int? statement_start_offset) => throw new InvalitContextException(nameof(sp_create_plan_guide_from_handle));

        /// <summary>
        /// sp_create_removable     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-create-removable-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to create for use on removable media.</param>
        /// <param name="syslogical">Is the logical name of the file that contains the system catalog tables.</param>
        /// <param name="sysphysical">Is the physical name.</param>
        /// <param name="syssize">Is the size, in megabytes, of the file that holds the system catalog tables.</param>
        /// <param name="loglogical">Is the logical name of the file that contains the transaction log.</param>
        /// <param name="logphysical">Is the physical name.</param>
        /// <param name="logsize"> the size, in megabytes, of the file that contains the transaction log.</param>
        /// <param name="datalogical1">Is the logical name of a file that contains the data tables.</param>
        /// <param name="dataphysical1">Is the physical name.</param>
        /// <param name="datasize1">Is the size, in megabytes, of a file that contains data tables.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_create_removable(string dbname, string syslogical, string sysphysical, int syssize, string loglogical, string logphysical, int logsize, string datalogical1, string dataphysical1, int datasize1) => throw new InvalitContextException(nameof(sp_create_removable));

        /// <summary>
        /// sp_createstats     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-createstats-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_createstats() => throw new InvalitContextException(nameof(sp_createstats));

        /// <summary>
        /// sp_createstats     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-createstats-transact-sql
        /// </summary>
        /// <param name="indexonly">Creates statistics only on columns that are in an existing index and are not the first column in any index definition.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_createstats(string indexonly) => throw new InvalitContextException(nameof(sp_createstats));

        /// <summary>
        /// sp_createstats     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-createstats-transact-sql
        /// </summary>
        /// <param name="indexonly">Creates statistics only on columns that are in an existing index and are not the first column in any index definition.</param>
        /// <param name="fullscan">Uses the CREATE STATISTICS statement with the FULLSCAN option.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_createstats(string indexonly, string fullscan) => throw new InvalitContextException(nameof(sp_createstats));

        /// <summary>
        /// sp_createstats     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-createstats-transact-sql
        /// </summary>
        /// <param name="indexonly">Creates statistics only on columns that are in an existing index and are not the first column in any index definition.</param>
        /// <param name="fullscan">Uses the CREATE STATISTICS statement with the FULLSCAN option.</param>
        /// <param name="norecompute">Uses the CREATE STATISTICS statement with the NORECOMPUTE option.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_createstats(string indexonly, string fullscan, string norecompute) => throw new InvalitContextException(nameof(sp_createstats));

        /// <summary>
        /// sp_createstats     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-createstats-transact-sql
        /// </summary>
        /// <param name="indexonly">Creates statistics only on columns that are in an existing index and are not the first column in any index definition.</param>
        /// <param name="fullscan">Uses the CREATE STATISTICS statement with the FULLSCAN option.</param>
        /// <param name="norecompute">Uses the CREATE STATISTICS statement with the NORECOMPUTE option.</param>
        /// <param name="incremental">Uses the CREATE STATISTICS statement with the INCREMENTAL = ON option.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_createstats(string indexonly, string fullscan, string norecompute, string incremental) => throw new InvalitContextException(nameof(sp_createstats));

        /// <summary>
        /// sp_datatype_info     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-datatype-info-transact-sql
        /// </summary>
        /// <param name="data_type">Is the code number for the specified data type.</param>
        [ClauseStyleConverter]
        public static void sp_datatype_info(int data_type) => throw new InvalitContextException(nameof(sp_datatype_info));

        /// <summary>
        /// sp_datatype_info     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-datatype-info-transact-sql
        /// </summary>
        /// <param name="data_type">Is the code number for the specified data type.</param>
        /// <param name="ODBCVer">Is the version of ODBC that is used.</param>
        [ClauseStyleConverter]
        public static void sp_datatype_info(int data_type, byte ODBCVer) => throw new InvalitContextException(nameof(sp_datatype_info));

        /// <summary>
        /// sp_db_increased_partitions     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-db-increased-partitions
        /// </summary>
        /// <param name="dbname">Is the name of the database.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_db_increased_partitions(string dbname) => throw new InvalitContextException(nameof(sp_db_increased_partitions));

        /// <summary>
        /// sp_db_increased_partitions     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-db-increased-partitions
        /// </summary>
        /// <param name="dbname">Is the name of the database.</param>
        /// <param name="increased_partitions">Enables or disables support for 15,000 partitions on the specified database.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_db_increased_partitions(string dbname, string increased_partitions) => throw new InvalitContextException(nameof(sp_db_increased_partitions));

        /// <summary>
        /// sp_db_vardecimal_storage_format     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-db-vardecimal-storage-format-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database for which the storage format is to be changed.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_db_vardecimal_storage_format(string dbname) => throw new InvalitContextException(nameof(sp_db_vardecimal_storage_format));

        /// <summary>
        /// sp_db_vardecimal_storage_format     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-db-vardecimal-storage-format-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database for which the storage format is to be changed.</param>
        /// <param name="vardecimal_storage_format">Specifies whether the vardecimal storage format is enabled.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_db_vardecimal_storage_format(string dbname, string vardecimal_storage_format) => throw new InvalitContextException(nameof(sp_db_vardecimal_storage_format));

        /// <summary>
        /// sp_dbcmptlevel     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbcmptlevel-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database for which the compatibility level is to be changed.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dbcmptlevel(string dbname) => throw new InvalitContextException(nameof(sp_dbcmptlevel));

        /// <summary>
        /// sp_dbcmptlevel     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbcmptlevel-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database for which the compatibility level is to be changed.</param>
        /// <param name="new_cmptlevel">Is the version of SQL Server with which the database is to be made compatible.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dbcmptlevel(string dbname, byte new_cmptlevel) => throw new InvalitContextException(nameof(sp_dbcmptlevel));

        /// <summary>
        /// sp_dbmmonitoraddmonitoring     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitoraddmonitoring-transact-sql
        /// </summary>
        /// <param name="update_period">Specifies the interval between updates in minutes.</param>
        [ClauseStyleConverter]
        public static void sp_dbmmonitoraddmonitoring(int update_period) => throw new InvalitContextException(nameof(sp_dbmmonitoraddmonitoring));

        /// <summary>
        /// sp_dbmmonitorchangealert     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitorchangealert-transact-sql
        /// </summary>
        /// <param name="database_name">Specifies the database for which to add or change the specified warning threshold.</param>
        /// <param name="alert_id">An integer value that identifies the warning to be added or changed.</param>
        /// <param name="alert_threshold">The threshold value for the warning.</param>
        /// <param name="enabled">Is the warning enabled.</param>
        [ClauseStyleConverter]
        public static void sp_dbmmonitorchangealert(string database_name, int alert_id, int alert_threshold, bool enabled) => throw new InvalitContextException(nameof(sp_dbmmonitorchangealert));

        /// <summary>
        /// sp_dbmmonitorchangemonitoring     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitorchangemonitoring-transact-sql
        /// </summary>
        /// <param name="parameter">Specifies the identifier of the parameter to be changed.</param>
        /// <param name="value">Specifies the new value for the parameter that is being changed.</param>
        [ClauseStyleConverter]
        public static void sp_dbmmonitorchangemonitoring(int parameter, int value) => throw new InvalitContextException(nameof(sp_dbmmonitorchangemonitoring));

        /// <summary>
        /// sp_dbmmonitordropalert     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitordropalert-transact-sql
        /// </summary>
        /// <param name="database_name">Specifies the database for which to drop the specified warning threshold.</param>
        /// <param name="alert_id">An integer value that identifies the warning to be dropped.</param>
        [ClauseStyleConverter]
        public static void sp_dbmmonitordropalert(string database_name, int alert_id) => throw new InvalitContextException(nameof(sp_dbmmonitordropalert));

        /// <summary>
        /// sp_dbmmonitordropmonitoring     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitordropmonitoring-transact-sql
        /// </summary>
        [ClauseStyleConverter]
        public static void sp_dbmmonitordropmonitoring() => throw new InvalitContextException(nameof(sp_dbmmonitordropmonitoring));

        /// <summary>
        /// sp_dbmmonitorhelpalert     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitorhelpalert-transact-sql
        /// </summary>
        /// <param name="database_name">Specifies the database.</param>
        /// <param name="alert_id">An integer value that identifies the warning to be returned.</param>
        [ClauseStyleConverter]
        public static void sp_dbmmonitorhelpalert(string database_name, int alert_id) => throw new InvalitContextException(nameof(sp_dbmmonitorhelpalert));

        /// <summary>
        /// sp_dbmmonitorhelpmonitoring     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitorhelpmonitoring-transact-sql
        /// </summary>
        [ClauseStyleConverter]
        public static void sp_dbmmonitorhelpmonitoring() => throw new InvalitContextException(nameof(sp_dbmmonitorhelpmonitoring));

        /// <summary>
        /// sp_dbmmonitorresults      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitorresults-transact-sql
        /// </summary>
        /// <param name="database_name">Specifies the database for which to return mirroring status.</param>
        /// <param name="rows_to_return">Specifies the quantity of rows returned.</param>
        /// <param name="update_status">Specifies that before returning results the procedure.</param>
        [ClauseStyleConverter]
        public static void sp_dbmmonitorresults(string database_name, int rows_to_return, int update_status) => throw new InvalitContextException(nameof(sp_dbmmonitorresults));

        /// <summary>
        /// sp_dbmmonitorupdate      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitorupdate-transact-sql
        /// </summary>
        /// <param name="database_name">The name of the database for which to update mirroring status.</param>
        [ClauseStyleConverter]
        public static void sp_dbmmonitorupdate(string database_name) => throw new InvalitContextException(nameof(sp_dbmmonitorupdate));

        /// <summary>
        /// sp_dbremove       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dbmmonitorupdate-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to be removed.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dbremove(string dbname) => throw new InvalitContextException(nameof(sp_dbremove));

        /// <summary>
        /// sp_delete_backuphistory       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-delete-backuphistory-transact-sql
        /// </summary>
        /// <param name="oldest_date">Is the oldest date retained in the backup and restore history tables.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_delete_backuphistory(DateTime oldest_date) => throw new InvalitContextException(nameof(sp_delete_backuphistory));

        /// <summary>
        /// sp_delete_database_backuphistory       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-delete-database-backuphistory-transact-sql
        /// </summary>
        /// <param name="database_name">Specifies the name of the database involved in backup and restore operations.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_delete_database_backuphistory(string database_name) => throw new InvalitContextException(nameof(sp_delete_database_backuphistory));

        /// <summary>
        /// sp_depends       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-depends-transact-sql
        /// </summary>
        /// <param name="object_name">Is the database object to examine for dependencies.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_depends(string object_name) => throw new InvalitContextException(nameof(sp_depends));

        /// <summary>
        /// sp_describe_first_result_set       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-describe-first-result-set-transact-sql
        /// </summary>
        /// <param name="tsql">One or more Transact-SQL statements.</param>
        /// <param name="params">params provides a declaration string for parameters for the Transact-SQL batch, which is similar to sp_executesql.</param>
        /// <param name="browse_information_mode">Specifies if additional key columns and source table information are returned.</param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static object sp_describe_first_result_set(string tsql, string @params, byte browse_information_mode) => throw new InvalitContextException(nameof(sp_describe_first_result_set));

        /// <summary>
        /// sp_describe_undeclared_parameters       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-describe-undeclared-parameters-transact-sql
        /// </summary>
        /// <param name="tsql">One or more Transact-SQL statements.</param>
        /// <param name="params">params provides a declaration string for parameters for the Transact-SQL batch, similarly to the way sp_executesql works.</param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static object sp_describe_undeclared_parameters(string tsql, string @params) => throw new InvalitContextException(nameof(sp_describe_undeclared_parameters));

        /// <summary>
        /// sp_detach_db       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-detach-db-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to be detached.</param>
        /// <param name="skipchecks">Specifies whether to skip or run UPDATE STATISTIC.</param>
        /// <param name="keepfulltextindexfile">Specifies that the full-text index file associated with the database that is being detached will not be dropped during the database detach operation.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_detach_db(string dbname, string skipchecks, string keepfulltextindexfile) => throw new InvalitContextException(nameof(sp_detach_db));

        /// <summary>
        /// sp_dropdevice       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropdevice-transact-sql
        /// </summary>
        /// <param name="logicalname">Is the logical name of the database device or backup device as listed in master.dbo.sysdevices.name.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropdevice(string logicalname) => throw new InvalitContextException(nameof(sp_dropdevice));

        /// <summary>
        /// sp_dropdevice       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropdevice-transact-sql
        /// </summary>
        /// <param name="logicalname">Is the logical name of the database device or backup device as listed in master.dbo.sysdevices.name.</param>
        /// <param name="delfile">Specifies whether the physical backup device file should be deleted.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropdevice(string logicalname, string delfile) => throw new InvalitContextException(nameof(sp_dropdevice));

        /// <summary>
        /// sp_dropextendedproc       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropextendedproc-transact-sql
        /// </summary>
        /// <param name="functname">Is the name of the extended stored procedure to drop</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropextendedproc(string functname) => throw new InvalitContextException(nameof(sp_dropextendedproc));

        /// <summary>
        /// sp_dropextendedproperty       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be dropped</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropextendedproperty(string name) => throw new InvalitContextException(nameof(sp_dropextendedproperty));

        /// <summary>
        /// sp_dropextendedproperty       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be dropped</param>
        /// <param name="level0type">Is the name of the level 0 object type specified</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropextendedproperty(string name, string level0type) => throw new InvalitContextException(nameof(sp_dropextendedproperty));

        /// <summary>
        /// sp_dropextendedproperty       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be dropped</param>
        /// <param name="level0type">Is the name of the level 0 object type specified</param>
        /// <param name="level0name">Is the name of the level 0 object type specified</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropextendedproperty(string name, string level0type, string level0name) => throw new InvalitContextException(nameof(sp_dropextendedproperty));

        /// <summary>
        /// sp_dropextendedproperty       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be dropped</param>
        /// <param name="level0type">Is the name of the level 0 object type specified</param>
        /// <param name="level0name">Is the name of the level 0 object type specified</param>
        /// <param name="level1type">Is the type of level 1 object</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropextendedproperty(string name, string level0type, string level0name, string level1type) => throw new InvalitContextException(nameof(sp_dropextendedproperty));

        /// <summary>
        /// sp_dropextendedproperty       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be dropped</param>
        /// <param name="level0type">Is the name of the level 0 object type specified</param>
        /// <param name="level0name">Is the name of the level 0 object type specified</param>
        /// <param name="level1type">Is the type of level 1 object</param>
        /// <param name="level1name">Is the name of the level 1 object type specified</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropextendedproperty(string name, string level0type, string level0name, string level1type, string level1name) => throw new InvalitContextException(nameof(sp_dropextendedproperty));

        /// <summary>
        /// sp_dropextendedproperty       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be dropped</param>
        /// <param name="level0type">Is the name of the level 0 object type specified</param>
        /// <param name="level0name">Is the name of the level 0 object type specified</param>
        /// <param name="level1type">Is the type of level 1 object</param>
        /// <param name="level1name">Is the name of the level 1 object type specified</param>
        /// <param name="level2type">Is the type of level 2 object</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropextendedproperty(string name, string level0type, string level0name, string level1type, string level1name, string level2type) => throw new InvalitContextException(nameof(sp_dropextendedproperty));

        /// <summary>
        /// sp_dropextendedproperty       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be dropped</param>
        /// <param name="level0type">Is the name of the level 0 object type specified</param>
        /// <param name="level0name">Is the name of the level 0 object type specified</param>
        /// <param name="level1type">Is the type of level 1 object</param>
        /// <param name="level1name">Is the name of the level 1 object type specified</param>
        /// <param name="level2type">Is the type of level 2 object</param>
        /// <param name="level2name">Is the name of the level 2 object type specified</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropextendedproperty(string name, string level0type, string level0name, string level1type, string level1name, string level2type, string level2name) => throw new InvalitContextException(nameof(sp_dropextendedproperty));

        /// <summary>
        /// sp_dropmessage       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropmessage-transact-sql
        /// </summary>
        /// <param name="msgnum">Is the message number to drop</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropmessage(int? msgnum) => throw new InvalitContextException(nameof(sp_dropmessage));

        /// <summary>
        /// sp_dropmessage       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-dropmessage-transact-sql
        /// </summary>
        /// <param name="msgnum">Is the message number to drop</param>
        /// <param name="lang">Is the language of the message to drop</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_dropmessage(int? msgnum, string lang) => throw new InvalitContextException(nameof(sp_dropmessage));

        /// <summary>
        /// sp_droptype       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-droptype-transact-sql
        /// </summary>
        /// <param name="typename">Is the name of an alias data type that you own</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_droptype(string typename) => throw new InvalitContextException(nameof(sp_droptype));

        /// <summary>
        /// sp_estimate_data_compression_savings       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-estimate-data-compression-savings-transact-sql
        /// </summary>
        /// <param name="schema_name">Is the name of the database schema that contains the table or indexed view</param>
        /// <param name="object_name">Is the name of the table or indexed view that the index is on</param>
        /// <param name="index_id">Is the ID of the index</param>
        /// <param name="partition_number">Is the partition number in the object</param>
        /// <param name="data_compression">Is the type of compression to be evaluated</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_estimate_data_compression_savings(string schema_name, string object_name, int index_id, int? partition_number, string data_compression) => throw new InvalitContextException(nameof(sp_estimate_data_compression_savings));

        /// <summary>
        /// sp_estimated_rowsize_reduction_for_vardecimal       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-estimated-rowsize-reduction-for-vardecimal-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_estimated_rowsize_reduction_for_vardecimal() => throw new InvalitContextException(nameof(sp_estimated_rowsize_reduction_for_vardecimal));

        /// <summary>
        /// sp_estimated_rowsize_reduction_for_vardecimal       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-estimated-rowsize-reduction-for-vardecimal-transact-sql
        /// </summary>
        /// <param name="table_name">Is the three part name of the table for which the storage format is to be changed</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_estimated_rowsize_reduction_for_vardecimal(string table_name) => throw new InvalitContextException(nameof(sp_estimated_rowsize_reduction_for_vardecimal));

        /// <summary>
        /// sp_execute_remote       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-remote-azure-sql-database
        /// </summary>
        /// <param name="data_source_name">Identifies the external data source where the statement is executed</param>
        /// <param name="stmt">Is a Unicode string that contains a Transact-SQL statement or batch</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_execute_remote(string data_source_name, string stmt) => throw new InvalitContextException(nameof(sp_execute_remote));

        /// <summary>
        /// sp_execute_remote       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-remote-azure-sql-database
        /// </summary>
        /// <param name="data_source_name">Identifies the external data source where the statement is executed</param>
        /// <param name="stmt">Is a Unicode string that contains a Transact-SQL statement or batch</param>
        /// <param name="params">Is one string that contains the definitions of all parameters that have been embedded in @stmt</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_execute_remote(string data_source_name, string stmt, string @params) => throw new InvalitContextException(nameof(sp_execute_remote));

        /// <summary>
        /// sp_execute_remote       
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-remote-azure-sql-database
        /// </summary>
        /// <param name="data_source_name">Identifies the external data source where the statement is executed</param>
        /// <param name="stmt">Is a Unicode string that contains a Transact-SQL statement or batch</param>
        /// <param name="params">Is one string that contains the definitions of all parameters that have been embedded in @stmt</param>
        /// <param name="param1">Is a value for the first parameter that is defined in the parameter string</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_execute_remote(string data_source_name, string stmt, string @params, string param1) => throw new InvalitContextException(nameof(sp_execute_remote));

        /// <summary>
        /// sp_executesql        
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-executesql-transact-sql
        /// </summary>
        /// <param name="stmt">Is a Unicode string that contains a Transact-SQL statement or batch</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_executesql(string stmt) => throw new InvalitContextException(nameof(sp_executesql));

        /// <summary>
        /// sp_executesql        
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-executesql-transact-sql
        /// </summary>
        /// <param name="stmt">Is a Unicode string that contains a Transact-SQL statement or batch</param>
        /// <param name="params">Is one string that contains the definitions of all parameters that have been embedded in @stmt</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_executesql(string stmt, string @params) => throw new InvalitContextException(nameof(sp_executesql));

        /// <summary>
        /// sp_executesql        
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-executesql-transact-sql
        /// </summary>
        /// <param name="stmt">Is a Unicode string that contains a Transact-SQL statement or batch</param>
        /// <param name="params">Is one string that contains the definitions of all parameters that have been embedded in @stmt</param>
        /// <param name="param1">Is a value for the first parameter that is defined in the parameter string</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_executesql(string stmt, string @params, string param1) => throw new InvalitContextException(nameof(sp_executesql));

        /// <summary>
        /// sp_execute_external_script         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="language">Indicates the script language</param>
        /// <param name="script">External language script specified as a literal or variable input</param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static object sp_execute_external_script(string language, string script) => throw new InvalitContextException(nameof(sp_execute_external_script));

        /// <summary>
        /// sp_execute_external_script         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="language">Indicates the script language</param>
        /// <param name="script">External language script specified as a literal or variable input</param>
        /// <param name="input_data_1_name">Specifies the name of the variable used to represent the query defined by @input_data_1</param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static object sp_execute_external_script(string language, string script, string input_data_1_name) => throw new InvalitContextException(nameof(sp_execute_external_script));

        /// <summary>
        /// sp_execute_external_script         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="language">Indicates the script language</param>
        /// <param name="script">External language script specified as a literal or variable input</param>
        /// <param name="input_data_1_name">Specifies the name of the variable used to represent the query defined by @input_data_1</param>
        /// <param name="input_data_1">Specifies the input data used by the external script in the form of a Transact-SQL query</param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static object sp_execute_external_script(string language, string script, string input_data_1_name, string input_data_1) => throw new InvalitContextException(nameof(sp_execute_external_script));

        /// <summary>
        /// sp_execute_external_script         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="language">Indicates the script language</param>
        /// <param name="script">External language script specified as a literal or variable input</param>
        /// <param name="input_data_1_name">Specifies the name of the variable used to represent the query defined by @input_data_1</param>
        /// <param name="input_data_1">Specifies the input data used by the external script in the form of a Transact-SQL query</param>
        /// <param name="output_data_1_name">Specifies the name of the variable in the external script that will contain the data to be returned to SQL Server upon completion of the stored procedure call.</param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static object sp_execute_external_script(string language, string script, string input_data_1_name, string input_data_1, string output_data_1_name) => throw new InvalitContextException(nameof(sp_execute_external_script));

        /// <summary>
        /// sp_execute_external_script         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="language">Indicates the script language</param>
        /// <param name="script">External language script specified as a literal or variable input</param>
        /// <param name="input_data_1_name">Specifies the name of the variable used to represent the query defined by @input_data_1</param>
        /// <param name="input_data_1">Specifies the input data used by the external script in the form of a Transact-SQL query</param>
        /// <param name="output_data_1_name">Specifies the name of the variable in the external script that will contain the data to be returned to SQL Server upon completion of the stored procedure call.</param>
        /// <param name="parallel">Enable parallel execution of R scripts by setting the @parallel parameter to 1</param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static object sp_execute_external_script(string language, string script, string input_data_1_name, string input_data_1, string output_data_1_name, int parallel) => throw new InvalitContextException(nameof(sp_execute_external_script));

        /// <summary>
        /// sp_execute_external_script         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="language">Indicates the script language</param>
        /// <param name="script">External language script specified as a literal or variable input</param>
        /// <param name="input_data_1_name">Specifies the name of the variable used to represent the query defined by @input_data_1</param>
        /// <param name="input_data_1">Specifies the input data used by the external script in the form of a Transact-SQL query</param>
        /// <param name="output_data_1_name">Specifies the name of the variable in the external script that will contain the data to be returned to SQL Server upon completion of the stored procedure call.</param>
        /// <param name="parallel">Enable parallel execution of R scripts by setting the @parallel parameter to 1</param>
        /// <param name="params">A list of input parameter declarations that will be used in the external script.</param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static object sp_execute_external_script(string language, string script, string input_data_1_name, string input_data_1, string output_data_1_name, int parallel, string @params ) => throw new InvalitContextException(nameof(sp_execute_external_script));

        /// <summary>
        /// sp_execute_external_script         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="language">Indicates the script language</param>
        /// <param name="script">External language script specified as a literal or variable input</param>
        /// <param name="input_data_1_name">Specifies the name of the variable used to represent the query defined by @input_data_1</param>
        /// <param name="input_data_1">Specifies the input data used by the external script in the form of a Transact-SQL query</param>
        /// <param name="output_data_1_name">Specifies the name of the variable in the external script that will contain the data to be returned to SQL Server upon completion of the stored procedure call.</param>
        /// <param name="parallel">Enable parallel execution of R scripts by setting the @parallel parameter to 1</param>
        /// <param name="params">A list of input parameter declarations that will be used in the external script.</param>
        /// <param name="parameter1">A list of values for the input parameters used by the external script. </param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static object sp_execute_external_script(string language, string script, string input_data_1_name, string input_data_1, string output_data_1_name, int parallel, string @params, string parameter1) => throw new InvalitContextException(nameof(sp_execute_external_script));

        /// <summary>
        /// sp_getbindtoken         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-getbindtoken-transact-sql
        /// </summary>
        /// <param name="out_token">Is the token to use to bind sessions</param>
        [MethodFormatConverter(Format = "sp_getbindtoken [0] OUTPUT")]
        public static void sp_getbindtoken(string out_token) => throw new InvalitContextException(nameof(sp_getbindtoken));

        /// <summary>
        /// sp_getapplock    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="Resource">Is a string specifying a name that identifies the lock resource</param>
        /// <param name="LockMode">External language script specified as a literal or variable input</param>
        /// <returns>>= 0 (success), or &lt; 0 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_getapplock(string Resource, string LockMode) => throw new InvalitContextException(nameof(sp_getapplock));

        /// <summary>
        /// sp_getapplock         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="Resource">Is a string specifying a name that identifies the lock resource</param>
        /// <param name="LockMode">External language script specified as a literal or variable input</param>
        /// <param name="LockOwner">Specifies the name of the variable used to represent the query defined by @input_data_1</param>
        /// <returns>>= 0 (success), or &lt; 0 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_getapplock(string Resource, string LockMode, string LockOwner) => throw new InvalitContextException(nameof(sp_getapplock));

        /// <summary>
        /// sp_getapplock         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="Resource">Is a string specifying a name that identifies the lock resource</param>
        /// <param name="LockMode">External language script specified as a literal or variable input</param>
        /// <param name="LockOwner">Specifies the name of the variable used to represent the query defined by @input_data_1</param>
        /// <param name="LockTimeout">Specifies the input data used by the external script in the form of a Transact-SQL query</param>
        /// <returns>>= 0 (success), or &lt; 0 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_getapplock(string Resource, string LockMode, string LockOwner, int LockTimeout) => throw new InvalitContextException(nameof(sp_getapplock));

        /// <summary>
        /// sp_getapplock         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-execute-external-script-transact-sql
        /// </summary>
        /// <param name="Resource">Is a string specifying a name that identifies the lock resource</param>
        /// <param name="LockMode">External language script specified as a literal or variable input</param>
        /// <param name="LockOwner">Specifies the name of the variable used to represent the query defined by @input_data_1</param>
        /// <param name="LockTimeout">Specifies the input data used by the external script in the form of a Transact-SQL query</param>
        /// <param name="DbPrincipal">Specifies the name of the variable in the external script that will contain the data to be returned to SQL Server upon completion of the stored procedure call.</param>
        /// <returns>>= 0 (success), or &lt; 0 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_getapplock(string Resource, string LockMode, string LockOwner, int LockTimeout, string DbPrincipal) => throw new InvalitContextException(nameof(sp_getapplock));

        /// <summary>
        /// sp_get_query_template         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-get-query-template-transact-sql
        /// </summary>
        /// <param name="query_text">Is the query for which the parameterized version is to be generated</param>
        /// <param name="templatetext">Is an output parameter of type nvarchar(max), provided as indicated, to receive the parameterized form of query_text as a string literal</param>
        /// <param name="parameters">Is an output parameter of type nvarchar(max), provided as indicated, to receive a string literal of the parameter names and data types that have been parameterized in @templatetext</param>
        [ClauseStyleConverter]
        public static void sp_get_query_template(string query_text, string templatetext, string parameters) => throw new InvalitContextException(nameof(sp_get_query_template));

        /// <summary>
        /// sp_help         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help() => throw new InvalitContextException(nameof(sp_help));

        /// <summary>
        /// sp_help         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-transact-sql
        /// </summary>
        /// <param name="objname">Is the name of any object, in sysobjects or any user-defined data type in the systypes table</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help(string objname) => throw new InvalitContextException(nameof(sp_help));

        /// <summary>
        /// sp_helpconstraint         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpconstraint-transact-sql
        /// </summary>
        /// <param name="objname">Is the table about which constraint information is returned</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpconstraint(string objname) => throw new InvalitContextException(nameof(sp_helpconstraint));

        /// <summary>
        /// sp_helpconstraint         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpconstraint-transact-sql
        /// </summary>
        /// <param name="objname">Is the table about which constraint information is returned</param>
        /// <param name="nomsg">Is an optional parameter that prints the table name</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpconstraint(string objname, string nomsg) => throw new InvalitContextException(nameof(sp_helpconstraint));

        /// <summary>
        /// sp_helpdb         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpdb-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpdb() => throw new InvalitContextException(nameof(sp_helpdb));

        /// <summary>
        /// sp_helpdb         
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpdb-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database for which information is reported</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpdb(string dbname) => throw new InvalitContextException(nameof(sp_helpdb));

        /// <summary>
        /// sp_helpdevice          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpdevice-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpdevice() => throw new InvalitContextException(nameof(sp_helpdevice));

        /// <summary>
        /// sp_helpdevice          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpdevice-transact-sql
        /// </summary>
        /// <param name="devname">Is the name of the backup device for which information is reported</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpdevice(string devname) => throw new InvalitContextException(nameof(sp_helpdevice));

        /// <summary>
        /// sp_helpextendedproc          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpextendedproc-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpextendedproc() => throw new InvalitContextException(nameof(sp_helpextendedproc));

        /// <summary>
        /// sp_helpextendedproc          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpextendedproc-transact-sql
        /// </summary>
        /// <param name="funcname">Is the name of the extended stored procedure for which information is reported</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpextendedproc(string funcname) => throw new InvalitContextException(nameof(sp_helpextendedproc));

        /// <summary>
        /// sp_helpfile          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpfile-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpfile() => throw new InvalitContextException(nameof(sp_helpfile));

        /// <summary>
        /// sp_helpfile          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpfile-transact-sql
        /// </summary>
        /// <param name="filename">Is the logical name of any file in the current database</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpfile(string filename) => throw new InvalitContextException(nameof(sp_helpfile));

        /// <summary>
        /// sp_helpfilegroup          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpfilegroup-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpfilegroup() => throw new InvalitContextException(nameof(sp_helpfilegroup));

        /// <summary>
        /// sp_helpfilegroup          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpfilegroup-transact-sql
        /// </summary>
        /// <param name="filegroupname ">Is the logical name of any filegroup in the current database</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpfilegroup(string filegroupname) => throw new InvalitContextException(nameof(sp_helpfilegroup));

        /// <summary>
        /// sp_helpindex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpindex-transact-sql
        /// </summary>
        /// <param name="objname">Is the qualified or nonqualified name of a user-defined table or view</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpindex(string objname) => throw new InvalitContextException(nameof(sp_helpindex));

        /// <summary>
        /// sp_helplanguage          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helplanguage-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helplanguage() => throw new InvalitContextException(nameof(sp_helplanguage));

        /// <summary>
        /// sp_helplanguage          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helplanguage-transact-sql
        /// </summary>
        /// <param name="language">Is the name of the alternative language for which to display information.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helplanguage(string language) => throw new InvalitContextException(nameof(sp_helplanguage));

        /// <summary>
        /// sp_helpserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpserver-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpserver() => throw new InvalitContextException(nameof(sp_helpserver));

        /// <summary>
        /// sp_helpserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpserver-transact-sql
        /// </summary>
        /// <param name="server">Is the server about which information is reported.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpserver(string server) => throw new InvalitContextException(nameof(sp_helpserver));

        /// <summary>
        /// sp_helpserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpserver-transact-sql
        /// </summary>
        /// <param name="server">Is the server about which information is reported.</param>
        /// <param name="optname">Is the option describing the server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpserver(string server, string optname) => throw new InvalitContextException(nameof(sp_helpserver));

        /// <summary>
        /// sp_helpserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpserver-transact-sql
        /// </summary>
        /// <param name="server">Is the server about which information is reported.</param>
        /// <param name="optname">Is the option describing the server.</param>
        /// <param name="show_topology">Is the relationship of the specified server to other servers.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpserver(string server, string optname, string show_topology) => throw new InvalitContextException(nameof(sp_helpserver));

        /// <summary>
        /// sp_helpsort          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpsort-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpsort() => throw new InvalitContextException(nameof(sp_helpsort));

        /// <summary>
        /// sp_helpstats          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpstats-transact-sql
        /// </summary>
        /// <param name="objname">Specifies the table on which to provide statistics information.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpstats(string objname) => throw new InvalitContextException(nameof(sp_helpstats));

        /// <summary>
        /// sp_helpstats          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helpstats-transact-sql
        /// </summary>
        /// <param name="objname">Specifies the table on which to provide statistics information.</param>
        /// <param name="results">Specifies the extent of information to provide.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helpstats(string objname, string results) => throw new InvalitContextException(nameof(sp_helpstats));

        /// <summary>
        /// sp_helptext          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helptext-transact-sql
        /// </summary>
        /// <param name="objname">Is the qualified or nonqualified name of a user-defined, schema-scoped object.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helptext(string objname) => throw new InvalitContextException(nameof(sp_helptext));

        /// <summary>
        /// sp_helptext          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helptext-transact-sql
        /// </summary>
        /// <param name="objname">Is the qualified or nonqualified name of a user-defined, schema-scoped object.</param>
        /// <param name="columnname">Is the name of the computed column for which to display definition information.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helptext(string objname, string columnname) => throw new InvalitContextException(nameof(sp_helptext));

        /// <summary>
        /// sp_helptrigger          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helptrigger-transact-sql
        /// </summary>
        /// <param name="tabname">Is the name of the table in the current database for which to return trigger information.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helptrigger(string tabname) => throw new InvalitContextException(nameof(sp_helptrigger));

        /// <summary>
        /// sp_helptrigger          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-helptrigger-transact-sql
        /// </summary>
        /// <param name="tabname">Is the name of the table in the current database for which to return trigger information.</param>
        /// <param name="triggertype">Is the type of DML trigger to return information about.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_helptrigger(string tabname, string triggertype) => throw new InvalitContextException(nameof(sp_helptrigger));

        /// <summary>
        /// sp_indexoption          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-indexoption-transact-sql
        /// </summary>
        /// <param name="IndexNamePattern">Is the qualified or nonqualified name of a user-defined table or index.</param>
        /// <param name="OptionName">Is an index option name.</param>
        /// <param name="OptionValue">Specifies whether the option_name setting is enabled (TRUE, ON, yes, or 1) or disabled (FALSE, OFF, no, or 0).</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_indexoption(string IndexNamePattern, string OptionName, string OptionValue) => throw new InvalitContextException(nameof(sp_indexoption));

        /// <summary>
        /// sp_invalidate_textptr          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-invalidate-textptr-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_invalidate_textptr() => throw new InvalitContextException(nameof(sp_invalidate_textptr));

        /// <summary>
        /// sp_invalidate_textptr          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-invalidate-textptr-transact-sql
        /// </summary>
        /// <param name="TextPtrValue">Is the in-row text pointer that to be invalidated.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_invalidate_textptr(string TextPtrValue) => throw new InvalitContextException(nameof(sp_invalidate_textptr));

        /// <summary>
        /// sp_lock          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-invalidate-textptr-transact-sql
        /// </summary>
        /// <returns>0 (success)</returns>
        [ClauseStyleConverter]
        public static int sp_lock() => throw new InvalitContextException(nameof(sp_lock));

        /// <summary>
        /// sp_lock          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-invalidate-textptr-transact-sql
        /// </summary>
        /// <param name="spid1">Is a Database Engine session ID number from sys.dm_exec_sessions for which the user wants locking information.</param>
        /// <returns>0 (success)</returns>
        [ClauseStyleConverter]
        public static int sp_lock(int? spid1) => throw new InvalitContextException(nameof(sp_lock));

        /// <summary>
        /// sp_lock          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-invalidate-textptr-transact-sql
        /// </summary>
        /// <param name="spid1">Is a Database Engine session ID number from sys.dm_exec_sessions for which the user wants locking information.</param>
        /// <param name="spid2">Is another Database Engine session ID number from sys.dm_exec_sessions that might have a lock at the same time as session ID1 and about which the user also wants information.</param>
        /// <returns>0 (success)</returns>
        [ClauseStyleConverter]
        public static int sp_lock(int? spid1, int? spid2) => throw new InvalitContextException(nameof(sp_lock));

        /// <summary>
        /// sp_monitor          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-monitor-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_monitor() => throw new InvalitContextException(nameof(sp_monitor));

        /// <summary>
        /// sp_procoption          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-procoption-transact-sql
        /// </summary>
        /// <param name="ProcName">Is the name of the procedure for which to set an option.</param>
        /// <param name="OptionName">Is the name of the option to set.</param>
        /// <param name="OptionValue">Is whether to set the option on (true or on) or off (false or off).</param>
        /// <returns>0 (success) or error number (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_procoption(string ProcName, string OptionName, string OptionValue) => throw new InvalitContextException(nameof(sp_procoption));

        /// <summary>
        /// sp_recompile          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-recompile-transact-sql
        /// </summary>
        /// <param name="objname">The qualified or unqualified name of a stored procedure, trigger, table, view, or user-defined function in the current database.</param>
        /// <returns>0 (success) or a nonzero number (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_recompile(string objname) => throw new InvalitContextException(nameof(sp_recompile));

        /// <summary>
        /// sp_refreshsqlmodule          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-procoption-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the stored procedure, user-defined function, view, DML trigger, database-level DDL trigger, or server-level DDL trigger.</param>
        /// <returns>0 (success) or a nonzero number (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_refreshsqlmodule(string name) => throw new InvalitContextException(nameof(sp_refreshsqlmodule));

        /// <summary>
        /// sp_refreshsqlmodule          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-procoption-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the stored procedure, user-defined function, view, DML trigger, database-level DDL trigger, or server-level DDL trigger.</param>
        /// <param name="namespace">Is the class of the specified module.</param>
        /// <returns>0 (success) or a nonzero number (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_refreshsqlmodule(string name, string @namespace) => throw new InvalitContextException(nameof(sp_refreshsqlmodule));

        /// <summary>
        /// sp_refreshview          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-refreshview-transact-sql
        /// </summary>
        /// <param name="viewname">Is the name of the view.</param>
        /// <returns>0 (success) or a nonzero number (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_refreshview(string viewname) => throw new InvalitContextException(nameof(sp_refreshview));

        /// <summary>
        /// sp_releaseapplock          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-releaseapplock-transact-sql
        /// </summary>
        /// <param name="Resource">Is a lock resource name specified by the client application.</param>
        /// <returns>>= 0 (success), or &lt; 0 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_releaseapplock(string Resource) => throw new InvalitContextException(nameof(sp_releaseapplock));

        /// <summary>
        /// sp_releaseapplock          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-releaseapplock-transact-sql
        /// </summary>
        /// <param name="Resource">Is a lock resource name specified by the client application.</param>
        /// <param name="LockOwner">Is the owner of the lock, which is the lock_owner value when the lock was requested.</param>
        /// <returns>>= 0 (success), or &lt; 0 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_releaseapplock(string Resource, string LockOwner) => throw new InvalitContextException(nameof(sp_releaseapplock));

        /// <summary>
        /// sp_releaseapplock          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-releaseapplock-transact-sql
        /// </summary>
        /// <param name="Resource">Is a lock resource name specified by the client application.</param>
        /// <param name="LockOwner">Is the owner of the lock, which is the lock_owner value when the lock was requested.</param>
        /// <param name="DbPrincipal">Is the user, role, or application role that has permissions to an object in a database.</param>
        /// <returns>>= 0 (success), or &lt; 0 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_releaseapplock(string Resource, string LockOwner, string DbPrincipal) => throw new InvalitContextException(nameof(sp_releaseapplock));

        /// <summary>
        /// sp_rename          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-rename-transact-sql
        /// </summary>
        /// <param name="objname">Is the current qualified or nonqualified name of the user object or data type.</param>
        /// <param name="newname">Is the new name for the specified object.</param>
        /// <param name="objtype">Is the type of object being renamed.</param>
        /// <returns>>= 0 (success) or a nonzero number (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_rename(string objname, string newname, string objtype) => throw new InvalitContextException(nameof(sp_rename));

        /// <summary>
        /// sp_renamedb          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-renamedb-transact-sql
        /// </summary>
        /// <param name="dbname">Is the current name of the database.</param>
        /// <param name="newname">Is the new name of the database.</param>
        /// <returns>>= 0 (success) or a nonzero number (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_renamedb(string dbname, string newname) => throw new InvalitContextException(nameof(sp_renamedb));

        /// <summary>
        /// sp_resetstatus          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-resetstatus-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the database to reset.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_resetstatus(string dbname) => throw new InvalitContextException(nameof(sp_resetstatus));

        /// <summary>
        /// sp_sequence_get_range          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sequence-get-range-transact-sql
        /// </summary>
        /// <param name="sequence_name">The name of the sequence object.</param>
        /// <param name="range_size">The number of values to fetch from the sequence.</param>
        /// <param name="range_first_value">Output parameter returns the first (minimum or maximum) value of the sequence object used to calculate the requested range.</param>
        /// <param name="range_last_value">Optional output parameter returns the last value of the requested range.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_sequence_get_range(string sequence_name, long range_size, object range_first_value, object range_last_value) => throw new InvalitContextException(nameof(sp_sequence_get_range));

        /// <summary>
        /// sp_sequence_get_range          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sequence-get-range-transact-sql
        /// </summary>
        /// <param name="sequence_name">The name of the sequence object.</param>
        /// <param name="range_size">The number of values to fetch from the sequence.</param>
        /// <param name="range_first_value">Output parameter returns the first (minimum or maximum) value of the sequence object used to calculate the requested range.</param>
        /// <param name="range_last_value">Optional output parameter returns the last value of the requested range.</param>
        /// <param name="range_cycle_count">Optional output parameter returns the number of times that the sequence object cycled in order to return the requested range.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_sequence_get_range(string sequence_name, long range_size, object range_first_value, object range_last_value, int range_cycle_count) => throw new InvalitContextException(nameof(sp_sequence_get_range));

        /// <summary>
        /// sp_sequence_get_range          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sequence-get-range-transact-sql
        /// </summary>
        /// <param name="sequence_name">The name of the sequence object.</param>
        /// <param name="range_size">The number of values to fetch from the sequence.</param>
        /// <param name="range_first_value">Output parameter returns the first (minimum or maximum) value of the sequence object used to calculate the requested range.</param>
        /// <param name="range_last_value">Optional output parameter returns the last value of the requested range.</param>
        /// <param name="range_cycle_count">Optional output parameter returns the number of times that the sequence object cycled in order to return the requested range.</param>
        /// <param name="sequence_increment">Optional output parameter returns the increment of the sequence object used to calculate the requested range.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_sequence_get_range(string sequence_name, long range_size, object range_first_value, object range_last_value, int range_cycle_count, object sequence_increment) => throw new InvalitContextException(nameof(sp_sequence_get_range));

        /// <summary>
        /// sp_sequence_get_range          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sequence-get-range-transact-sql
        /// </summary>
        /// <param name="sequence_name">The name of the sequence object.</param>
        /// <param name="range_size">The number of values to fetch from the sequence.</param>
        /// <param name="range_first_value">Output parameter returns the first (minimum or maximum) value of the sequence object used to calculate the requested range.</param>
        /// <param name="range_last_value">Optional output parameter returns the last value of the requested range.</param>
        /// <param name="range_cycle_count">Optional output parameter returns the number of times that the sequence object cycled in order to return the requested range.</param>
        /// <param name="sequence_increment">Optional output parameter returns the increment of the sequence object used to calculate the requested range.</param>
        /// <param name="sequence_min_value">Optional output parameter returns the minimum value of the sequence object.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_sequence_get_range(string sequence_name, long range_size, object range_first_value, object range_last_value, int range_cycle_count, object sequence_increment, object sequence_min_value) => throw new InvalitContextException(nameof(sp_sequence_get_range));

        /// <summary>
        /// sp_sequence_get_range          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-sequence-get-range-transact-sql
        /// </summary>
        /// <param name="sequence_name">The name of the sequence object.</param>
        /// <param name="range_size">The number of values to fetch from the sequence.</param>
        /// <param name="range_first_value">Output parameter returns the first (minimum or maximum) value of the sequence object used to calculate the requested range.</param>
        /// <param name="range_last_value">Optional output parameter returns the last value of the requested range.</param>
        /// <param name="range_cycle_count">Optional output parameter returns the number of times that the sequence object cycled in order to return the requested range.</param>
        /// <param name="sequence_increment">Optional output parameter returns the increment of the sequence object used to calculate the requested range.</param>
        /// <param name="sequence_min_value">Optional output parameter returns the minimum value of the sequence object.</param>
        /// <param name="sequence_max_value">Optional output parameter returns the maximum value of the sequence object.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_sequence_get_range(string sequence_name, long range_size, object range_first_value, object range_last_value, int range_cycle_count, object sequence_increment, object sequence_min_value, object sequence_max_value) => throw new InvalitContextException(nameof(sp_sequence_get_range));

        /// <summary>
        /// sp_server_diagnostics          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-server-diagnostics-transact-sql
        /// </summary>
        /// <param name="repeat_interval">The name of the sequence object.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_server_diagnostics(int repeat_interval) => throw new InvalitContextException(nameof(sp_server_diagnostics));

        /// <summary>
        /// sp_set_session_context          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-set-session-context-transact-sql
        /// </summary>
        /// <param name="key">The key being set, of type sysname.</param>
        /// <param name="value">The value for the specified key, of type sql_variant.</param>
        [ClauseStyleConverter]
        public static void sp_set_session_context(string key, object value) => throw new InvalitContextException(nameof(sp_set_session_context));

        /// <summary>
        /// sp_set_session_context          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-set-session-context-transact-sql
        /// </summary>
        /// <param name="key">The key being set, of type sysname.</param>
        /// <param name="value">The value for the specified key, of type sql_variant.</param>
        /// <param name="read_only">A flag of type bit.</param>
        [ClauseStyleConverter]
        public static void sp_set_session_context(string key, object value, int read_only) => throw new InvalitContextException(nameof(sp_set_session_context));

        /// <summary>
        /// sp_setnetname          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-setnetname-transact-sql
        /// </summary>
        /// <param name="server">Is the name of the remote server as referenced in user-coded remote stored procedure call syntax.</param>
        /// <param name="netname">Is the network name of the computer to which remote stored procedure calls are made.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_setnetname(string server, string netname) => throw new InvalitContextException(nameof(sp_setnetname));

        /// <summary>
        /// sp_settriggerorder          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-settriggerorder-transact-sql
        /// </summary>
        /// <param name="triggername">Is the name of the trigger and the schema to which it belongs, if applicable, whose order is to be set or changed.</param>
        /// <param name="order">Is the setting for the new order of the trigger.</param>
        /// <param name="stmttype">Specifies the SQL statement that fires the trigger.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_settriggerorder(string triggername, string order, string stmttype) => throw new InvalitContextException(nameof(sp_settriggerorder));

        /// <summary>
        /// sp_settriggerorder          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-settriggerorder-transact-sql
        /// </summary>
        /// <param name="triggername">Is the name of the trigger and the schema to which it belongs, if applicable, whose order is to be set or changed.</param>
        /// <param name="order">Is the setting for the new order of the trigger.</param>
        /// <param name="stmttype">Specifies the SQL statement that fires the trigger.</param>
        /// <param name="namespace">When triggername is a DDL trigger, @namespace specifies whether triggername was created with database scope or server scope.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_settriggerorder(string triggername, string order, string stmttype, string @namespace) => throw new InvalitContextException(nameof(sp_settriggerorder));

        /// <summary>
        /// sp_spaceused          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-spaceused-transact-sql
        /// </summary>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_spaceused() => throw new InvalitContextException(nameof(sp_spaceused));

        /// <summary>
        /// sp_spaceused          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-spaceused-transact-sql
        /// </summary>
        /// <param name="objname">Is the qualified or nonqualified name of the table, indexed view, or queue for which space usage information is requested.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_spaceused(string objname) => throw new InvalitContextException(nameof(sp_spaceused));

        /// <summary>
        /// sp_spaceused          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-spaceused-transact-sql
        /// </summary>
        /// <param name="objname">Is the qualified or nonqualified name of the table, indexed view, or queue for which space usage information is requested.</param>
        /// <param name="updateusage">Indicates DBCC UPDATEUSAGE should be run to update space usage information.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_spaceused(string objname, string updateusage) => throw new InvalitContextException(nameof(sp_spaceused));

        /// <summary>
        /// sp_spaceused          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-spaceused-transact-sql
        /// </summary>
        /// <param name="objname">Is the qualified or nonqualified name of the table, indexed view, or queue for which space usage information is requested.</param>
        /// <param name="updateusage">Indicates DBCC UPDATEUSAGE should be run to update space usage information.</param>
        /// <param name="mode">Indicates the scope of the results.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_spaceused(string objname, string updateusage, string mode) => throw new InvalitContextException(nameof(sp_spaceused));

        /// <summary>
        /// sp_spaceused          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-spaceused-transact-sql
        /// </summary>
        /// <param name="objname">Is the qualified or nonqualified name of the table, indexed view, or queue for which space usage information is requested.</param>
        /// <param name="updateusage">Indicates DBCC UPDATEUSAGE should be run to update space usage information.</param>
        /// <param name="mode">Indicates the scope of the results.</param>
        /// <param name="oneresultset">Indicates whether to return a single result set.</param>
        /// <returns>>= 0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_spaceused(string objname, string updateusage, string mode, int oneresultset) => throw new InvalitContextException(nameof(sp_spaceused));

        /// <summary>
        /// sp_tableoption          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tableoption-transact-sql
        /// </summary>
        /// <param name="TableNamePattern">Is the qualified or nonqualified name of a user-defined database table.</param>
        /// <param name="OptionName">Is a table option name.</param>
        /// <param name="OptionValue">Is whether the option_name is enabled (TRUE, ON, or 1) or disabled (FALSE, OFF, or 0).</param>
        /// <returns>>= 0 (success) or error number (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_tableoption(string TableNamePattern, string OptionName, string OptionValue) => throw new InvalitContextException(nameof(sp_tableoption));

        /// <summary>
        /// sp_unbindefault          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-unbindefault-transact-sql
        /// </summary>
        /// <param name="objname">Is the name of the table and column or the alias data type from which the default is to be unbound.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_unbindefault(string objname) => throw new InvalitContextException(nameof(sp_unbindefault));

        /// <summary>
        /// sp_unbindefault          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-unbindefault-transact-sql
        /// </summary>
        /// <param name="objname">Is the name of the table and column or the alias data type from which the default is to be unbound.</param>
        /// <param name="futureonly">Is used only when unbinding a default from an alias data type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_unbindefault(string objname, string futureonly) => throw new InvalitContextException(nameof(sp_unbindefault));

        /// <summary>
        /// sp_unbindrule          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-unbindrule-transact-sql
        /// </summary>
        /// <param name="objname">Is the name of the table and column or the alias data type from which the default is to be unbound.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_unbindrule(string objname) => throw new InvalitContextException(nameof(sp_unbindrule));

        /// <summary>
        /// sp_unbindrule          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-unbindrule-transact-sql
        /// </summary>
        /// <param name="objname">Is the name of the table and column or the alias data type from which the default is to be unbound.</param>
        /// <param name="futureonly">Is used only when unbinding a default from an alias data type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_unbindrule(string objname, string futureonly) => throw new InvalitContextException(nameof(sp_unbindrule));

        /// <summary>
        /// sp_updateextendedproperty          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-updateextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be updated.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_updateextendedproperty(string name) => throw new InvalitContextException(nameof(sp_updateextendedproperty));

        /// <summary>
        /// sp_updateextendedproperty          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-updateextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be updated.</param>
        /// <param name="value">Is the value associated with the property.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_updateextendedproperty(string name, object value) => throw new InvalitContextException(nameof(sp_updateextendedproperty));

        /// <summary>
        /// sp_updateextendedproperty          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-updateextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be updated.</param>
        /// <param name="value">Is the value associated with the property.</param>
        /// <param name="level0type">Is the user or user-defined type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_updateextendedproperty(string name, object value, string level0type) => throw new InvalitContextException(nameof(sp_updateextendedproperty));

        /// <summary>
        /// sp_updateextendedproperty          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-updateextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be updated.</param>
        /// <param name="value">Is the value associated with the property.</param>
        /// <param name="level0type">Is the user or user-defined type.</param>
        /// <param name="level0name">Is the name of the level 1 object type specified.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_updateextendedproperty(string name, object value, string level0type, string level0name) => throw new InvalitContextException(nameof(sp_updateextendedproperty));

        /// <summary>
        /// sp_updateextendedproperty          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-updateextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be updated.</param>
        /// <param name="value">Is the value associated with the property.</param>
        /// <param name="level0type">Is the user or user-defined type.</param>
        /// <param name="level0name">Is the name of the level 1 object type specified.</param>
        /// <param name="level1type">Is the type of level 1 object.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_updateextendedproperty(string name, object value, string level0type, string level0name, string level1type) => throw new InvalitContextException(nameof(sp_updateextendedproperty));

        /// <summary>
        /// sp_updateextendedproperty          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-updateextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be updated.</param>
        /// <param name="value">Is the value associated with the property.</param>
        /// <param name="level0type">Is the user or user-defined type.</param>
        /// <param name="level0name">Is the name of the level 1 object type specified.</param>
        /// <param name="level1type">Is the type of level 1 object.</param>
        /// <param name="level1name">Is the name of the level 1 object type specified.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_updateextendedproperty(string name, object value, string level0type, string level0name, string level1type, string level1name) => throw new InvalitContextException(nameof(sp_updateextendedproperty));

        /// <summary>
        /// sp_updateextendedproperty          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-updateextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be updated.</param>
        /// <param name="value">Is the value associated with the property.</param>
        /// <param name="level0type">Is the user or user-defined type.</param>
        /// <param name="level0name">Is the name of the level 1 object type specified.</param>
        /// <param name="level1type">Is the type of level 1 object.</param>
        /// <param name="level1name">Is the name of the level 1 object type specified.</param>
        /// <param name="level2type">Is the type of level 2 object.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_updateextendedproperty(string name, object value, string level0type, string level0name, string level1type, string level1name, string level2type) => throw new InvalitContextException(nameof(sp_updateextendedproperty));

        /// <summary>
        /// sp_updateextendedproperty          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-updateextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be updated.</param>
        /// <param name="value">Is the value associated with the property.</param>
        /// <param name="level0type">Is the user or user-defined type.</param>
        /// <param name="level0name">Is the name of the level 1 object type specified.</param>
        /// <param name="level1type">Is the type of level 1 object.</param>
        /// <param name="level1name">Is the name of the level 1 object type specified.</param>
        /// <param name="level2type">Is the type of level 2 object.</param>
        /// <param name="level2name">Is the name of the level 2 object type specified.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_updateextendedproperty(string name, object value, string level0type, string level0name, string level1type, string level1name, string level2type, string level2name) => throw new InvalitContextException(nameof(sp_updateextendedproperty));

        /// <summary>
        /// sp_updatestats          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-updatestats-transact-sql
        /// </summary>
        /// <param name="resample">Specifies that sp_updatestats will use the RESAMPLE option of the UPDATE STATISTICS statement.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_updatestats(string resample) => throw new InvalitContextException(nameof(sp_updatestats));

        /// <summary>
        /// sp_validname          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-validname-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the identifiers for which to check validity.</param>
        [ClauseStyleConverter]
        public static int sp_validname(string name) => throw new InvalitContextException(nameof(sp_validname));

        /// <summary>
        /// sp_validname          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-validname-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the identifiers for which to check validity.</param>
        /// <param name="raise_error">Specifies whether to raise an error.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_validname(string name, int? raise_error) => throw new InvalitContextException(nameof(sp_validname));

        /// <summary>
        /// sp_who          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-who-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_who() => throw new InvalitContextException(nameof(sp_who));

        /// <summary>
        /// sp_who          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-who-transact-sql
        /// </summary>
        /// <param name="loginame">Is used to filter the result set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_who(object loginame) => throw new InvalitContextException(nameof(sp_who));

        //--------------------------
        //Database Mail Stored Procedures
        //--------------------------
        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail() => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <param name="query_attachment_filename">Specifies the file name to use for the result set of the query attachment.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file, string query_attachment_filename) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <param name="query_attachment_filename">Specifies the file name to use for the result set of the query attachment.</param>
        /// <param name="query_result_header">Specifies whether the query results include column headers.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file, string query_attachment_filename, int? query_result_header) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <param name="query_attachment_filename">Specifies the file name to use for the result set of the query attachment.</param>
        /// <param name="query_result_header">Specifies whether the query results include column headers.</param>
        /// <param name="query_result_width">Is the line width, in characters, to use for formatting the results of the query.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file, string query_attachment_filename, int? query_result_header, int query_result_width) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <param name="query_attachment_filename">Specifies the file name to use for the result set of the query attachment.</param>
        /// <param name="query_result_header">Specifies whether the query results include column headers.</param>
        /// <param name="query_result_width">Is the line width, in characters, to use for formatting the results of the query.</param>
        /// <param name="query_result_separator">Is the character used to separate columns in the query output.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file, string query_attachment_filename, int? query_result_header, int query_result_width,
            char query_result_separator) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <param name="query_attachment_filename">Specifies the file name to use for the result set of the query attachment.</param>
        /// <param name="query_result_header">Specifies whether the query results include column headers.</param>
        /// <param name="query_result_width">Is the line width, in characters, to use for formatting the results of the query.</param>
        /// <param name="query_result_separator">Is the character used to separate columns in the query output.</param>
        /// <param name="exclude_query_output">Specifies whether to return the output of the query execution in the e-mail message.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file, string query_attachment_filename, int? query_result_header, int query_result_width,
            char query_result_separator, int exclude_query_output) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <param name="query_attachment_filename">Specifies the file name to use for the result set of the query attachment.</param>
        /// <param name="query_result_header">Specifies whether the query results include column headers.</param>
        /// <param name="query_result_width">Is the line width, in characters, to use for formatting the results of the query.</param>
        /// <param name="query_result_separator">Is the character used to separate columns in the query output.</param>
        /// <param name="exclude_query_output">Specifies whether to return the output of the query execution in the e-mail message.</param>
        /// <param name="append_query_error">Specifies whether to send the e-mail when an error returns from the query specified in the @query argument.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file, string query_attachment_filename, int? query_result_header, int query_result_width,
            char query_result_separator, int exclude_query_output, int? append_query_error) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <param name="query_attachment_filename">Specifies the file name to use for the result set of the query attachment.</param>
        /// <param name="query_result_header">Specifies whether the query results include column headers.</param>
        /// <param name="query_result_width">Is the line width, in characters, to use for formatting the results of the query.</param>
        /// <param name="query_result_separator">Is the character used to separate columns in the query output.</param>
        /// <param name="exclude_query_output">Specifies whether to return the output of the query execution in the e-mail message.</param>
        /// <param name="append_query_error">Specifies whether to send the e-mail when an error returns from the query specified in the @query argument.</param>
        /// <param name="query_no_truncate">Specifies whether to execute the query with the option that avoids truncation of large variable length data types (varchar(max), nvarchar(max), varbinary(max), xml, text, ntext, image, and user-defined data types).</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file, string query_attachment_filename, int? query_result_header, int query_result_width,
            char query_result_separator, int exclude_query_output, int? append_query_error, string query_no_truncate) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <param name="query_attachment_filename">Specifies the file name to use for the result set of the query attachment.</param>
        /// <param name="query_result_header">Specifies whether the query results include column headers.</param>
        /// <param name="query_result_width">Is the line width, in characters, to use for formatting the results of the query.</param>
        /// <param name="query_result_separator">Is the character used to separate columns in the query output.</param>
        /// <param name="exclude_query_output">Specifies whether to return the output of the query execution in the e-mail message.</param>
        /// <param name="append_query_error">Specifies whether to send the e-mail when an error returns from the query specified in the @query argument.</param>
        /// <param name="query_no_truncate">Specifies whether to execute the query with the option that avoids truncation of large variable length data types (varchar(max), nvarchar(max), varbinary(max), xml, text, ntext, image, and user-defined data types).</param>
        /// <param name="query_result_no_padding">The type is bit. The default is 0. When you set to 1, the query results are not padded, possibly reducing the file size.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file, string query_attachment_filename, int? query_result_header, int query_result_width,
            char query_result_separator, int exclude_query_output, int? append_query_error, string query_no_truncate, int? query_result_no_padding) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sp_send_dbmail          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-send-dbmail-transact-sql
        /// </summary>
        /// <param name="profile_name">Is the name of the profile to send the message from.</param>
        /// <param name="recipients">Is a semicolon-delimited list of e-mail addresses to send the message to.</param>
        /// <param name="copy_recipients">Is a semicolon-delimited list of e-mail addresses to carbon copy the message to.</param>
        /// <param name="blind_copy_recipients">Is a semicolon-delimited list of e-mail addresses to blind carbon copy the message to.</param>
        /// <param name="from_address">Is the value of the 'from address' of the email message.</param>
        /// <param name="reply_to">Is the value of the 'reply to address' of the email message.</param>
        /// <param name="subject">Is the subject of the e-mail message.</param>
        /// <param name="body">Is the body of the e-mail message.</param>
        /// <param name="body_format">Is the format of the message body.</param>
        /// <param name="importance">Is the importance of the message.</param>
        /// <param name="sensitivity">Is the sensitivity of the message.</param>
        /// <param name="file_attachments">Is a semicolon-delimited list of file names to attach to the e-mail message.</param>
        /// <param name="query">Is a query to execute.</param>
        /// <param name="execute_query_database">Is the database context within which the stored procedure runs the query.</param>
        /// <param name="attach_query_result_as_file">Specifies whether the result set of the query is returned as an attached file.</param>
        /// <param name="query_attachment_filename">Specifies the file name to use for the result set of the query attachment.</param>
        /// <param name="query_result_header">Specifies whether the query results include column headers.</param>
        /// <param name="query_result_width">Is the line width, in characters, to use for formatting the results of the query.</param>
        /// <param name="query_result_separator">Is the character used to separate columns in the query output.</param>
        /// <param name="exclude_query_output">Specifies whether to return the output of the query execution in the e-mail message.</param>
        /// <param name="append_query_error">Specifies whether to send the e-mail when an error returns from the query specified in the @query argument.</param>
        /// <param name="query_no_truncate">Specifies whether to execute the query with the option that avoids truncation of large variable length data types (varchar(max), nvarchar(max), varbinary(max), xml, text, ntext, image, and user-defined data types).</param>
        /// <param name="query_result_no_padding">The type is bit. The default is 0. When you set to 1, the query results are not padded, possibly reducing the file size.</param>
        /// <param name="mailitem_id">A return code of 0 means success.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_send_dbmail(string profile_name, string recipients, string copy_recipients, string blind_copy_recipients, string from_address,
            string reply_to, string subject, string body, string body_format, string importance, string sensitivity, string file_attachments, string query,
            string execute_query_database, int? attach_query_result_as_file, string query_attachment_filename, int? query_result_header, int query_result_width,
            char query_result_separator, int exclude_query_output, int? append_query_error, string query_no_truncate, int? query_result_no_padding, int mailitem_id) => throw new InvalitContextException(nameof(sp_send_dbmail));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <param name="description">Is a description for the account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address, string description) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <param name="description">Is a description for the account.</param>
        /// <param name="mailserver_name">The name or IP address of the SMTP mail server to use for this account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address, string description,
            string mailserver_name) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <param name="description">Is a description for the account.</param>
        /// <param name="mailserver_name">The name or IP address of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The type of e-mail server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address, string description,
            string mailserver_name, string mailserver_type) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <param name="description">Is a description for the account.</param>
        /// <param name="mailserver_name">The name or IP address of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The type of e-mail server.</param>
        /// <param name="port">The port number for the e-mail server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address, string description,
            string mailserver_name, string mailserver_type, int port) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <param name="description">Is a description for the account.</param>
        /// <param name="mailserver_name">The name or IP address of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The type of e-mail server.</param>
        /// <param name="port">The port number for the e-mail server.</param>
        /// <param name="username">The user name to use to log on to the e-mail server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address, string description,
            string mailserver_name, string mailserver_type, int port, string username) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <param name="description">Is a description for the account.</param>
        /// <param name="mailserver_name">The name or IP address of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The type of e-mail server.</param>
        /// <param name="port">The port number for the e-mail server.</param>
        /// <param name="username">The user name to use to log on to the e-mail server.</param>
        /// <param name="password">The password to use to log on to the e-mail server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address, string description,
            string mailserver_name, string mailserver_type, int port, string username, string password) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <param name="description">Is a description for the account.</param>
        /// <param name="mailserver_name">The name or IP address of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The type of e-mail server.</param>
        /// <param name="port">The port number for the e-mail server.</param>
        /// <param name="username">The user name to use to log on to the e-mail server.</param>
        /// <param name="password">The password to use to log on to the e-mail server.</param>
        /// <param name="use_default_credentials">Specifies whether to send the mail to the SMTP server using the credentials of the SQL Server Database Engine.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address, string description,
            string mailserver_name, string mailserver_type, int port, string username, string password, int? use_default_credentials) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <param name="description">Is a description for the account.</param>
        /// <param name="mailserver_name">The name or IP address of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The type of e-mail server.</param>
        /// <param name="port">The port number for the e-mail server.</param>
        /// <param name="username">The user name to use to log on to the e-mail server.</param>
        /// <param name="password">The password to use to log on to the e-mail server.</param>
        /// <param name="use_default_credentials">Specifies whether to send the mail to the SMTP server using the credentials of the SQL Server Database Engine.</param>
        /// <param name="enable_ssl">Specifies whether Database Mail encrypts communication using Secure Sockets Layer.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address, string description,
            string mailserver_name, string mailserver_type, int port, string username, string password, int? use_default_credentials, int? enable_ssl) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-account-sp-transact-sql
        /// </summary>
        /// <param name="account_name">The name of the account to add. </param>
        /// <param name="email_address">The e-mail address to send the message from.</param>
        /// <param name="display_name">The display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The address that responses to messages from this account are sent to.</param>
        /// <param name="description">Is a description for the account.</param>
        /// <param name="mailserver_name">The name or IP address of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The type of e-mail server.</param>
        /// <param name="port">The port number for the e-mail server.</param>
        /// <param name="username">The user name to use to log on to the e-mail server.</param>
        /// <param name="password">The password to use to log on to the e-mail server.</param>
        /// <param name="use_default_credentials">Specifies whether to send the mail to the SMTP server using the credentials of the SQL Server Database Engine.</param>
        /// <param name="enable_ssl">Specifies whether Database Mail encrypts communication using Secure Sockets Layer.</param>
        /// <param name="account_id">Returns the account id for the new account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_account_sp(string account_name, string email_address, string display_name, string replyto_address, string description,
            string mailserver_name, string mailserver_type, int port, string username, string password, int? use_default_credentials, int? enable_ssl, int? account_id) => throw new InvalitContextException(nameof(sysmail_add_account_sp));

        /// <summary>
        /// sysmail_add_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-principalprofile-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_principalprofile_sp() => throw new InvalitContextException(nameof(sysmail_add_principalprofile_sp));

        /// <summary>
        /// sysmail_add_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_principalprofile_sp(int principal_id) => throw new InvalitContextException(nameof(sysmail_add_principalprofile_sp));

        /// <summary>
        /// sysmail_add_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association. </param>
        /// <param name="principal_name">The name of the database user or role in the msdb database for the association.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_principalprofile_sp(int principal_id, string principal_name) => throw new InvalitContextException(nameof(sysmail_add_principalprofile_sp));

        /// <summary>
        /// sysmail_add_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association. </param>
        /// <param name="principal_name">The name of the database user or role in the msdb database for the association.</param>
        /// <param name="profile_id">The id of the profile for the association.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_principalprofile_sp(int principal_id, string principal_name, int profile_id) => throw new InvalitContextException(nameof(sysmail_add_principalprofile_sp));

        /// <summary>
        /// sysmail_add_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association. </param>
        /// <param name="principal_name">The name of the database user or role in the msdb database for the association.</param>
        /// <param name="profile_id">The id of the profile for the association.</param>
        /// <param name="profile_name">The name of the profile for the association.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_principalprofile_sp(int principal_id, string principal_name, int profile_id, string profile_name) => throw new InvalitContextException(nameof(sysmail_add_principalprofile_sp));

        /// <summary>
        /// sysmail_add_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association. </param>
        /// <param name="principal_name">The name of the database user or role in the msdb database for the association.</param>
        /// <param name="profile_id">The id of the profile for the association.</param>
        /// <param name="profile_name">The name of the profile for the association.</param>
        /// <param name="is_default">Specifies whether this profile is the default profile for the principal.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_principalprofile_sp(int principal_id, string principal_name, int profile_id, string profile_name, int? is_default) => throw new InvalitContextException(nameof(sysmail_add_principalprofile_sp));

        /// <summary>
        /// sysmail_add_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-profile-sp-transact-sql
        /// </summary>
        /// <param name="profile_name">The name for the new profile. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_profile_sp(string profile_name) => throw new InvalitContextException(nameof(sysmail_add_profile_sp));

        /// <summary>
        /// sysmail_add_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-profile-sp-transact-sql
        /// </summary>
        /// <param name="profile_name">The name for the new profile. </param>
        /// <param name="description">The optional description for the new profile.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_profile_sp(string profile_name, string description) => throw new InvalitContextException(nameof(sysmail_add_profile_sp));

        /// <summary>
        /// sysmail_add_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-profile-sp-transact-sql
        /// </summary>
        /// <param name="profile_name">The name for the new profile. </param>
        /// <param name="description">The optional description for the new profile.</param>
        /// <param name="profile_id">Returns the ID for the new profile.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_profile_sp(string profile_name, string description, int profile_id) => throw new InvalitContextException(nameof(sysmail_add_profile_sp));

        /// <summary>
        /// sysmail_add_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-profileaccount-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_profileaccount_sp() => throw new InvalitContextException(nameof(sysmail_add_profileaccount_sp));

        /// <summary>
        /// sysmail_add_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to add the account to. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_profileaccount_sp(int profile_id) => throw new InvalitContextException(nameof(sysmail_add_profileaccount_sp));

        /// <summary>
        /// sysmail_add_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to add the account to. </param>
        /// <param name="profile_name">The profile name to add the account to.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_profileaccount_sp(int profile_id, string profile_name) => throw new InvalitContextException(nameof(sysmail_add_profileaccount_sp));

        /// <summary>
        /// sysmail_add_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to add the account to. </param>
        /// <param name="profile_name">The profile name to add the account to.</param>
        /// <param name="account_id">The account id to add to the profile.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_profileaccount_sp(int profile_id, string profile_name, int account_id) => throw new InvalitContextException(nameof(sysmail_add_profileaccount_sp));

        /// <summary>
        /// sysmail_add_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to add the account to. </param>
        /// <param name="profile_name">The profile name to add the account to.</param>
        /// <param name="account_id">The account id to add to the profile.</param>
        /// <param name="account_name">The name of the account to add to the profile.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_profileaccount_sp(int profile_id, string profile_name, int account_id, string account_name) => throw new InvalitContextException(nameof(sysmail_add_profileaccount_sp));

        /// <summary>
        /// sysmail_add_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-add-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to add the account to. </param>
        /// <param name="profile_name">The profile name to add the account to.</param>
        /// <param name="account_id">The account id to add to the profile.</param>
        /// <param name="account_name">The name of the account to add to the profile.</param>
        /// <param name="sequence_number">The sequence number of the account within the profile.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_add_profileaccount_sp(int profile_id, string profile_name, int account_id, string account_name, int sequence_number) => throw new InvalitContextException(nameof(sysmail_add_profileaccount_sp));

        /// <summary>
        /// sysmail_configure_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-configure-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_configure_sp() => throw new InvalitContextException(nameof(sysmail_configure_sp));

        /// <summary>
        /// sysmail_configure_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-configure-sp-transact-sql
        /// </summary>
        /// <param name="parameter_name">The name of the parameter to change. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_configure_sp(string parameter_name) => throw new InvalitContextException(nameof(sysmail_configure_sp));

        /// <summary>
        /// sysmail_configure_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-configure-sp-transact-sql
        /// </summary>
        /// <param name="parameter_name">The name of the parameter to change. </param>
        /// <param name="parameter_value">The new value of the parameter.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_configure_sp(string parameter_name, string parameter_value) => throw new InvalitContextException(nameof(sysmail_configure_sp));

        /// <summary>
        /// sysmail_configure_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-configure-sp-transact-sql
        /// </summary>
        /// <param name="parameter_name">The name of the parameter to change. </param>
        /// <param name="parameter_value">The new value of the parameter.</param>
        /// <param name="description">A description of the parameter.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_configure_sp(string parameter_name, string parameter_value, string description) => throw new InvalitContextException(nameof(sysmail_configure_sp));

        /// <summary>
        /// sysmail_delete_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-account-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_account_sp() => throw new InvalitContextException(nameof(sysmail_delete_account_sp));

        /// <summary>
        /// sysmail_delete_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The ID number of the account to delete. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_account_sp(int account_id) => throw new InvalitContextException(nameof(sysmail_delete_account_sp));

        /// <summary>
        /// sysmail_delete_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The ID number of the account to delete. </param>
        /// <param name="account_name">The name of the account to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_account_sp(int account_id, string account_name) => throw new InvalitContextException(nameof(sysmail_delete_account_sp));

        /// <summary>
        /// sysmail_delete_log_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-log-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_log_sp() => throw new InvalitContextException(nameof(sysmail_delete_log_sp));

        /// <summary>
        /// sysmail_delete_log_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-log-sp-transact-sql
        /// </summary>
        /// <param name="logged_before">Deletes entries up to the date and time specified by the logged_before argument. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_log_sp(DateTime logged_before) => throw new InvalitContextException(nameof(sysmail_delete_log_sp));

        /// <summary>
        /// sysmail_delete_log_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-log-sp-transact-sql
        /// </summary>
        /// <param name="logged_before">Deletes log entries of the type specified as the event_type. </param>
        /// <param name="event_type">The name of the account to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_log_sp(DateTime logged_before, string event_type) => throw new InvalitContextException(nameof(sysmail_delete_log_sp));

        /// <summary>
        /// sysmail_delete_mailitems_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-mailitems-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_mailitems_sp() => throw new InvalitContextException(nameof(sysmail_delete_mailitems_sp));

        /// <summary>
        /// sysmail_delete_mailitems_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-mailitems-sp-transact-sql
        /// </summary>
        /// <param name="sent_before">Deletes log entries of the type specified as the event_type. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_mailitems_sp(DateTime sent_before) => throw new InvalitContextException(nameof(sysmail_delete_mailitems_sp));

        /// <summary>
        /// sysmail_delete_mailitems_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-mailitems-sp-transact-sql
        /// </summary>
        /// <param name="sent_before">Deletes log entries of the type specified as the event_type. </param>
        /// <param name="sent_status">The name of the account to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_mailitems_sp(DateTime sent_before, string sent_status) => throw new InvalitContextException(nameof(sysmail_delete_mailitems_sp));

        /// <summary>
        /// sysmail_delete_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-principalprofile-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_principalprofile_sp() => throw new InvalitContextException(nameof(sysmail_delete_principalprofile_sp));

        /// <summary>
        /// sysmail_delete_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">Is the ID of the database user or role in the msdb database for the association to delete. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_principalprofile_sp(int principal_id) => throw new InvalitContextException(nameof(sysmail_delete_principalprofile_sp));

        /// <summary>
        /// sysmail_delete_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">Is the ID of the database user or role in the msdb database for the association to delete. </param>
        /// <param name="principal_name">Is the name of the database user or role in the msdb database for the association to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_principalprofile_sp(int principal_id, string principal_name) => throw new InvalitContextException(nameof(sysmail_delete_principalprofile_sp));

        /// <summary>
        /// sysmail_delete_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">Is the ID of the database user or role in the msdb database for the association to delete. </param>
        /// <param name="principal_name">Is the name of the database user or role in the msdb database for the association to delete.</param>
        /// <param name="profile_id">Is the ID of the profile for the association to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_principalprofile_sp(int principal_id, string principal_name, int profile_id) => throw new InvalitContextException(nameof(sysmail_delete_principalprofile_sp));

        /// <summary>
        /// sysmail_delete_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">Is the ID of the database user or role in the msdb database for the association to delete. </param>
        /// <param name="principal_name">Is the name of the database user or role in the msdb database for the association to delete.</param>
        /// <param name="profile_id">Is the ID of the profile for the association to delete.</param>
        /// <param name="profile_name">Is the name of the profile for the association to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_principalprofile_sp(int principal_id, string principal_name, int profile_id, string profile_name) => throw new InvalitContextException(nameof(sysmail_delete_principalprofile_sp));

        /// <summary>
        /// sysmail_delete_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-profile-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_profile_sp() => throw new InvalitContextException(nameof(sysmail_delete_profile_sp));

        /// <summary>
        /// sysmail_delete_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-profile-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The ID number of the account to delete. </param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_profile_sp(int account_id) => throw new InvalitContextException(nameof(sysmail_delete_profile_sp));

        /// <summary>
        /// sysmail_delete_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-profile-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The ID number of the account to delete. </param>
        /// <param name="account_name">The name of the account to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_profile_sp(int account_id, string account_name) => throw new InvalitContextException(nameof(sysmail_delete_profile_sp));

        /// <summary>
        /// sysmail_delete_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-profileaccount-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_profileaccount_sp() => throw new InvalitContextException(nameof(sysmail_delete_profileaccount_sp));

        /// <summary>
        /// sysmail_delete_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile ID of the profile to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_profileaccount_sp(int profile_id) => throw new InvalitContextException(nameof(sysmail_delete_profileaccount_sp));

        /// <summary>
        /// sysmail_delete_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile ID of the profile to delete.</param>
        /// <param name="profile_name">The profile name of the profile to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_profileaccount_sp(int profile_id, string profile_name) => throw new InvalitContextException(nameof(sysmail_delete_profileaccount_sp));

        /// <summary>
        /// sysmail_delete_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile ID of the profile to delete.</param>
        /// <param name="profile_name">The profile name of the profile to delete.</param>
        /// <param name="account_id">The account ID to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_profileaccount_sp(int profile_id, string profile_name, int account_id) => throw new InvalitContextException(nameof(sysmail_delete_profileaccount_sp));

        /// <summary>
        /// sysmail_delete_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-delete-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile ID of the profile to delete.</param>
        /// <param name="profile_name">The profile name of the profile to delete.</param>
        /// <param name="account_id">The account ID to delete.</param>
        /// <param name="account_name">The name of the account to delete.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_delete_profileaccount_sp(int profile_id, string profile_name, int account_id, string account_name) => throw new InvalitContextException(nameof(sysmail_delete_profileaccount_sp));

        /// <summary>
        /// sysmail_help_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-account-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_account_sp() => throw new InvalitContextException(nameof(sysmail_help_account_sp));

        /// <summary>
        /// sysmail_help_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID of the account to list information for.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_account_sp(int account_id) => throw new InvalitContextException(nameof(sysmail_help_account_sp));

        /// <summary>
        /// sysmail_help_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID of the account to list information for.</param>
        /// <param name="account_name">The name of the account to list information for.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_account_sp(int account_id, string account_name) => throw new InvalitContextException(nameof(sysmail_help_account_sp));

        /// <summary>
        /// sysmail_help_configure_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-configure-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_configure_sp() => throw new InvalitContextException(nameof(sysmail_help_configure_sp));

        /// <summary>
        /// sysmail_help_configure_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-configure-sp-transact-sql
        /// </summary>
        /// <param name="parameter_name">The name of the configuration setting to retrieve.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_configure_sp(string parameter_name) => throw new InvalitContextException(nameof(sysmail_help_configure_sp));

        /// <summary>
        /// sysmail_help_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-principalprofile-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_principalprofile_sp() => throw new InvalitContextException(nameof(sysmail_help_principalprofile_sp));

        /// <summary>
        /// sysmail_help_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">Is the ID of the database user or role in the msdb database for the association to list.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_principalprofile_sp(int principal_id) => throw new InvalitContextException(nameof(sysmail_help_principalprofile_sp));

        /// <summary>
        /// sysmail_help_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">Is the ID of the database user or role in the msdb database for the association to list.</param>
        /// <param name="principal_name">Is the name of the database user or role in the msdb database for the association to list.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_principalprofile_sp(int principal_id, string principal_name) => throw new InvalitContextException(nameof(sysmail_help_principalprofile_sp));

        /// <summary>
        /// sysmail_help_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">Is the ID of the database user or role in the msdb database for the association to list.</param>
        /// <param name="principal_name">Is the name of the database user or role in the msdb database for the association to list.</param>
        /// <param name="profile_id">Is the ID of the profile for the association to list.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_principalprofile_sp(int principal_id, string principal_name, int profile_id) => throw new InvalitContextException(nameof(sysmail_help_principalprofile_sp));

        /// <summary>
        /// sysmail_help_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">Is the ID of the database user or role in the msdb database for the association to list.</param>
        /// <param name="principal_name">Is the name of the database user or role in the msdb database for the association to list.</param>
        /// <param name="profile_id">Is the ID of the profile for the association to list.</param>
        /// <param name="profile_name">Is the name of the profile for the association to list.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_principalprofile_sp(int principal_id, string principal_name, int profile_id, string profile_name) => throw new InvalitContextException(nameof(sysmail_help_principalprofile_sp));

        /// <summary>
        /// sysmail_help_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-profile-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_profile_sp() => throw new InvalitContextException(nameof(sysmail_help_profile_sp));

        /// <summary>
        /// sysmail_help_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-profile-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to return information for.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_profile_sp(int profile_id) => throw new InvalitContextException(nameof(sysmail_help_profile_sp));

        /// <summary>
        /// sysmail_help_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-profile-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to return information for.</param>
        /// <param name="profile_name">The profile name to return information for.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_profile_sp(int profile_id, string profile_name) => throw new InvalitContextException(nameof(sysmail_help_profile_sp));

        /// <summary>
        /// sysmail_help_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-profileaccount-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_profileaccount_sp() => throw new InvalitContextException(nameof(sysmail_help_profileaccount_sp));

        /// <summary>
        /// sysmail_help_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">Is the profile ID of the profile to list.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_profileaccount_sp(int profile_id) => throw new InvalitContextException(nameof(sysmail_help_profileaccount_sp));

        /// <summary>
        /// sysmail_help_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">Is the profile ID of the profile to list.</param>
        /// <param name="profile_name">Is the profile name of the profile to list.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_profileaccount_sp(int profile_id, string profile_name) => throw new InvalitContextException(nameof(sysmail_help_profileaccount_sp));

        /// <summary>
        /// sysmail_help_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">Is the profile ID of the profile to list.</param>
        /// <param name="profile_name">Is the profile name of the profile to list.</param>
        /// <param name="account_id">Is the account ID to list.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_profileaccount_sp(int profile_id, string profile_name, int account_id) => throw new InvalitContextException(nameof(sysmail_help_profileaccount_sp));

        /// <summary>
        /// sysmail_help_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">Is the profile ID of the profile to list.</param>
        /// <param name="profile_name">Is the profile name of the profile to list.</param>
        /// <param name="account_id">Is the account ID to list.</param>
        /// <param name="account_name">Is the name of the account to list.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_profileaccount_sp(int profile_id, string profile_name, int account_id, string account_name) => throw new InvalitContextException(nameof(sysmail_help_profileaccount_sp));

        /// <summary>
        /// sysmail_help_queue_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-queue-sp-transact-sql
        /// </summary>
        /// <param name="queue_type">Optional argument deletes e-mails of the type specified as the queue_type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_queue_sp(string queue_type) => throw new InvalitContextException(nameof(sysmail_help_queue_sp));

        /// <summary>
        /// sysmail_help_status_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-help-status-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_help_status_sp() => throw new InvalitContextException(nameof(sysmail_help_status_sp));

        /// <summary>
        /// sysmail_start_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-start-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_start_sp() => throw new InvalitContextException(nameof(sysmail_start_sp));

        /// <summary>
        /// sysmail_stop_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-stop-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_stop_sp() => throw new InvalitContextException(nameof(sysmail_stop_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp() => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <param name="description">The new description for the account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address,
            string description) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <param name="description">The new description for the account.</param>
        /// <param name="mailserver_name">The new name of the SMTP mail server to use for this account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address,
            string description, string mailserver_name) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <param name="description">The new description for the account.</param>
        /// <param name="mailserver_name">The new name of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The new type of the mail server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address,
            string description, string mailserver_name, string mailserver_type) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <param name="description">The new description for the account.</param>
        /// <param name="mailserver_name">The new name of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The new type of the mail server.</param>
        /// <param name="port">The new port number of the mail server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address,
            string description, string mailserver_name, string mailserver_type, int port) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <param name="description">The new description for the account.</param>
        /// <param name="mailserver_name">The new name of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The new type of the mail server.</param>
        /// <param name="port">The new port number of the mail server.</param>
        /// <param name="timeout">Timeout parameter for SmtpClient.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address,
            string description, string mailserver_name, string mailserver_type, int port, int timeout) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <param name="description">The new description for the account.</param>
        /// <param name="mailserver_name">The new name of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The new type of the mail server.</param>
        /// <param name="port">The new port number of the mail server.</param>
        /// <param name="timeout">Timeout parameter for SmtpClient.</param>
        /// <param name="username">The new user name to use to log on to the mail server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address,
            string description, string mailserver_name, string mailserver_type, int port, int timeout, string username) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <param name="description">The new description for the account.</param>
        /// <param name="mailserver_name">The new name of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The new type of the mail server.</param>
        /// <param name="port">The new port number of the mail server.</param>
        /// <param name="timeout">Timeout parameter for SmtpClient.</param>
        /// <param name="username">The new user name to use to log on to the mail server.</param>
        /// <param name="password">The new password to use to log on to the mail server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address,
            string description, string mailserver_name, string mailserver_type, int port, int timeout, string username, string password) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <param name="description">The new description for the account.</param>
        /// <param name="mailserver_name">The new name of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The new type of the mail server.</param>
        /// <param name="port">The new port number of the mail server.</param>
        /// <param name="timeout">Timeout parameter for SmtpClient.</param>
        /// <param name="username">The new user name to use to log on to the mail server.</param>
        /// <param name="password">The new password to use to log on to the mail server.</param>
        /// <param name="use_default_credentials">Specifies whether to send the mail to the SMTP server using the credentials of the SQL Server Database Engine service.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address,
            string description, string mailserver_name, string mailserver_type, int port, int timeout, string username, string password, int? use_default_credentials) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_account_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-account-sp-transact-sql
        /// </summary>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="email_address">The new e-mail address to send the message from.</param>
        /// <param name="display_name">The new display name to use on e-mail messages from this account.</param>
        /// <param name="replyto_address">The new address to use in the Reply-To header of e-mail messages from this account.</param>
        /// <param name="description">The new description for the account.</param>
        /// <param name="mailserver_name">The new name of the SMTP mail server to use for this account.</param>
        /// <param name="mailserver_type">The new type of the mail server.</param>
        /// <param name="port">The new port number of the mail server.</param>
        /// <param name="timeout">Timeout parameter for SmtpClient.</param>
        /// <param name="username">The new user name to use to log on to the mail server.</param>
        /// <param name="password">The new password to use to log on to the mail server.</param>
        /// <param name="use_default_credentials">Specifies whether to send the mail to the SMTP server using the credentials of the SQL Server Database Engine service.</param>
        /// <param name="enable_ssl">Specifies whether Database Mail encrypts communication using Secure Sockets Layer (SSL).</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_account_sp(int account_id, string account_name, string email_address, string display_name, string replyto_address,
            string description, string mailserver_name, string mailserver_type, int port, int timeout, string username, string password, int? use_default_credentials, int? enable_ssl) => throw new InvalitContextException(nameof(sysmail_update_account_sp));

        /// <summary>
        /// sysmail_update_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-principalprofile-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_principalprofile_sp() => throw new InvalitContextException(nameof(sysmail_update_principalprofile_sp));

        /// <summary>
        /// sysmail_update_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association to change.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_principalprofile_sp(int principal_id) => throw new InvalitContextException(nameof(sysmail_update_principalprofile_sp));

        /// <summary>
        /// sysmail_update_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association to change.</param>
        /// <param name="principal_name">The name of the database user or role in the msdb database for the association to update.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_principalprofile_sp(int principal_id, string principal_name) => throw new InvalitContextException(nameof(sysmail_update_principalprofile_sp));

        /// <summary>
        /// sysmail_update_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association to change.</param>
        /// <param name="principal_name">The name of the database user or role in the msdb database for the association to update.</param>
        /// <param name="profile_id">The id of the profile for the association to change.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_principalprofile_sp(int principal_id, string principal_name, int profile_id) => throw new InvalitContextException(nameof(sysmail_update_principalprofile_sp));

        /// <summary>
        /// sysmail_update_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association to change.</param>
        /// <param name="principal_name">The name of the database user or role in the msdb database for the association to update.</param>
        /// <param name="profile_id">The id of the profile for the association to change.</param>
        /// <param name="profile_name">The name of the profile for the association to change.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_principalprofile_sp(int principal_id, string principal_name, int profile_id, string profile_name) => throw new InvalitContextException(nameof(sysmail_update_principalprofile_sp));

        /// <summary>
        /// sysmail_update_principalprofile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-principalprofile-sp-transact-sql
        /// </summary>
        /// <param name="principal_id">The ID of the database user or role in the msdb database for the association to change.</param>
        /// <param name="principal_name">The name of the database user or role in the msdb database for the association to update.</param>
        /// <param name="profile_id">The id of the profile for the association to change.</param>
        /// <param name="profile_name">The name of the profile for the association to change.</param>
        /// <param name="is_default">Is whether this profile is the default profile for the database user.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_principalprofile_sp(int principal_id, string principal_name, int profile_id, string profile_name, int? is_default) => throw new InvalitContextException(nameof(sysmail_update_principalprofile_sp));

        /// <summary>
        /// sysmail_update_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-profile-sp-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_profile_sp() => throw new InvalitContextException(nameof(sysmail_update_profile_sp));

        /// <summary>
        /// sysmail_update_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-profile-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to update.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_profile_sp(int profile_id) => throw new InvalitContextException(nameof(sysmail_update_profile_sp));

        /// <summary>
        /// sysmail_update_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-profile-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to update.</param>
        /// <param name="profile_name">The name of the profile to update or the new name for the profile.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_profile_sp(int profile_id, string profile_name) => throw new InvalitContextException(nameof(sysmail_update_profile_sp));

        /// <summary>
        /// sysmail_update_profile_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-profile-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile id to update.</param>
        /// <param name="profile_name">The name of the profile to update or the new name for the profile.</param>
        /// <param name="description">The new description for the profile.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_profile_sp(int profile_id, string profile_name, string description) => throw new InvalitContextException(nameof(sysmail_update_profile_sp));

        /// <summary>
        /// sysmail_update_profileaccount_sp          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sysmail-update-profileaccount-sp-transact-sql
        /// </summary>
        /// <param name="profile_id">The profile ID of the profile to update.</param>
        /// <param name="profile_name">The profile name of the profile to update.</param>
        /// <param name="account_id">The account ID to update.</param>
        /// <param name="account_name">The name of the account to update.</param>
        /// <param name="sequence_number">The new sequence number for the account.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sysmail_update_profileaccount_sp(int profile_id, string profile_name, int account_id, string account_name, int sequence_number) => throw new InvalitContextException(nameof(sysmail_update_profileaccount_sp));

        //--------------------------
        //Database Maintenance Plan Stored Procedures
        //--------------------------
        /// <summary>
        /// sp_add_maintenance_plan          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-add-maintenance-plan-transact-sql
        /// </summary>
        /// <param name="plan_name">Specifies the name of the maintenance plan to be added.</param>
        /// <param name="plan_id">Specifies the ID of the maintenance plan.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_add_maintenance_plan(string plan_name, string plan_id) => throw new InvalitContextException(nameof(sp_add_maintenance_plan));

        /// <summary>
        /// sp_add_maintenance_plan_db          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-add-maintenance-plan-db-transact-sql
        /// </summary>
        /// <param name="plan_id">Specifies the plan ID of the maintenance plan.</param>
        /// <param name="db_name">Specifies the name of the database to be added to the maintenance plan.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_add_maintenance_plan_db(string plan_id, string db_name) => throw new InvalitContextException(nameof(sp_add_maintenance_plan_db));

        /// <summary>
        /// sp_add_maintenance_plan_job          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-add-maintenance-plan-job-transact-sql
        /// </summary>
        /// <param name="plan_id">Specifies the ID of the maintenance plan.</param>
        /// <param name="job_id">Specifies the ID of the job to be associated with the maintenance plan.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_add_maintenance_plan_job(string plan_id, string job_id) => throw new InvalitContextException(nameof(sp_add_maintenance_plan_job));

        /// <summary>
        /// sp_delete_maintenance_plan          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-delete-maintenance-plan-transact-sql
        /// </summary>
        /// <param name="plan_id">Specifies the ID of the maintenance plan to be deleted.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_delete_maintenance_plan(string plan_id) => throw new InvalitContextException(nameof(sp_delete_maintenance_plan));

        /// <summary>
        /// sp_delete_maintenance_plan_db          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-delete-maintenance-plan-db-transact-sql
        /// </summary>
        /// <param name="plan_id">Specifies the maintenance plan ID.</param>
        /// <param name="db_name">Specifies the database name to be deleted from the maintenance plan.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_delete_maintenance_plan_db(string plan_id, string db_name) => throw new InvalitContextException(nameof(sp_delete_maintenance_plan_db));

        /// <summary>
        /// sp_delete_maintenance_plan_job          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-delete-maintenance-plan-job-transact-sql
        /// </summary>
        /// <param name="plan_id">Specifies the ID of the maintenance plan.</param>
        /// <param name="job_id">Specifies the ID of the job with which the maintenance plan is associated.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_delete_maintenance_plan_job(string plan_id, string job_id) => throw new InvalitContextException(nameof(sp_delete_maintenance_plan_job));

        /// <summary>
        /// sp_help_maintenance_plan          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-maintenance-plan-transact-sql
        /// </summary>
        /// <param name="plan_id">Specifies the plan ID of the maintenance plan.</param>
        [ClauseStyleConverter]
        public static void sp_help_maintenance_plan(string plan_id) => throw new InvalitContextException(nameof(sp_help_maintenance_plan));

        //--------------------------
        //Distributed Queries Stored Procedures
        //--------------------------
        /// <summary>
        /// sp_addlinkedserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedserver-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedserver() => throw new InvalitContextException(nameof(sp_addlinkedserver));

        /// <summary>
        /// sp_addlinkedserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedserver-transact-sql
        /// </summary>
        /// <param name="server">Is the name of the linked server to create.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedserver(string server) => throw new InvalitContextException(nameof(sp_addlinkedserver));

        /// <summary>
        /// sp_addlinkedserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedserver-transact-sql
        /// </summary>
        /// <param name="server">Is the name of the linked server to create.</param>
        /// <param name="srvproduct">Is the product name of the OLE DB data source to add as a linked server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedserver(string server, string srvproduct) => throw new InvalitContextException(nameof(sp_addlinkedserver));

        /// <summary>
        /// sp_addlinkedserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedserver-transact-sql
        /// </summary>
        /// <param name="server">Is the name of the linked server to create.</param>
        /// <param name="srvproduct">Is the product name of the OLE DB data source to add as a linked server.</param>
        /// <param name="provider">Is the unique programmatic identifier (PROGID) of the OLE DB provider that corresponds to this data source.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedserver(string server, string srvproduct, string provider) => throw new InvalitContextException(nameof(sp_addlinkedserver));

        /// <summary>
        /// sp_addlinkedserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedserver-transact-sql
        /// </summary>
        /// <param name="server">Is the name of the linked server to create.</param>
        /// <param name="srvproduct">Is the product name of the OLE DB data source to add as a linked server.</param>
        /// <param name="provider">Is the unique programmatic identifier (PROGID) of the OLE DB provider that corresponds to this data source.</param>
        /// <param name="datasrc">Is the name of the data source as interpreted by the OLE DB provider.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedserver(string server, string srvproduct, string provider, string datasrc) => throw new InvalitContextException(nameof(sp_addlinkedserver));

        /// <summary>
        /// sp_addlinkedserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedserver-transact-sql
        /// </summary>
        /// <param name="server">Is the name of the linked server to create.</param>
        /// <param name="srvproduct">Is the product name of the OLE DB data source to add as a linked server.</param>
        /// <param name="provider">Is the unique programmatic identifier (PROGID) of the OLE DB provider that corresponds to this data source.</param>
        /// <param name="datasrc">Is the name of the data source as interpreted by the OLE DB provider.</param>
        /// <param name="location">Is the location of the database as interpreted by the OLE DB provider.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedserver(string server, string srvproduct, string provider, string datasrc, string location) => throw new InvalitContextException(nameof(sp_addlinkedserver));

        /// <summary>
        /// sp_addlinkedserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedserver-transact-sql
        /// </summary>
        /// <param name="server">Is the name of the linked server to create.</param>
        /// <param name="srvproduct">Is the product name of the OLE DB data source to add as a linked server.</param>
        /// <param name="provider">Is the unique programmatic identifier (PROGID) of the OLE DB provider that corresponds to this data source.</param>
        /// <param name="datasrc">Is the name of the data source as interpreted by the OLE DB provider.</param>
        /// <param name="location">Is the location of the database as interpreted by the OLE DB provider.</param>
        /// <param name="provstr">Is the OLE DB provider-specific connection string that identifies a unique data source.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedserver(string server, string srvproduct, string provider, string datasrc, string location, string provstr) => throw new InvalitContextException(nameof(sp_addlinkedserver));

        /// <summary>
        /// sp_addlinkedsrvlogin          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedsrvlogin-transact-sql
        /// </summary>
        /// <param name="rmtsrvname">Is the name of a linked server that the login mapping applies to.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedsrvlogin(string rmtsrvname) => throw new InvalitContextException(nameof(sp_addlinkedsrvlogin));

        /// <summary>
        /// sp_addlinkedsrvlogin          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedsrvlogin-transact-sql
        /// </summary>
        /// <param name="rmtsrvname">Is the name of a linked server that the login mapping applies to.</param>
        /// <param name="useself">Determines whether to connect to rmtsrvname by impersonating local logins or explicitly submitting a login and password.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedsrvlogin(string rmtsrvname, string useself) => throw new InvalitContextException(nameof(sp_addlinkedsrvlogin));

        /// <summary>
        /// sp_addlinkedsrvlogin          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedsrvlogin-transact-sql
        /// </summary>
        /// <param name="rmtsrvname">Is the name of a linked server that the login mapping applies to.</param>
        /// <param name="useself">Determines whether to connect to rmtsrvname by impersonating local logins or explicitly submitting a login and password.</param>
        /// <param name="locallogin">Is a login on the local server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedsrvlogin(string rmtsrvname, string useself, string locallogin) => throw new InvalitContextException(nameof(sp_addlinkedsrvlogin));

        /// <summary>
        /// sp_addlinkedsrvlogin          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedsrvlogin-transact-sql
        /// </summary>
        /// <param name="rmtsrvname">Is the name of a linked server that the login mapping applies to.</param>
        /// <param name="useself">Determines whether to connect to rmtsrvname by impersonating local logins or explicitly submitting a login and password.</param>
        /// <param name="locallogin">Is a login on the local server.</param>
        /// <param name="rmtuser">Is the remote login used to connect to rmtsrvname when @useself is FALSE.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedsrvlogin(string rmtsrvname, string useself, string locallogin, string rmtuser) => throw new InvalitContextException(nameof(sp_addlinkedsrvlogin));

        /// <summary>
        /// sp_addlinkedsrvlogin          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addlinkedsrvlogin-transact-sql
        /// </summary>
        /// <param name="rmtsrvname">Is the name of a linked server that the login mapping applies to.</param>
        /// <param name="useself">Determines whether to connect to rmtsrvname by impersonating local logins or explicitly submitting a login and password.</param>
        /// <param name="locallogin">Is a login on the local server.</param>
        /// <param name="rmtuser">Is the remote login used to connect to rmtsrvname when @useself is FALSE.</param>
        /// <param name="rmtpassword">Is the password associated with rmtuser.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_addlinkedsrvlogin(string rmtsrvname, string useself, string locallogin, string rmtuser, string rmtpassword) => throw new InvalitContextException(nameof(sp_addlinkedsrvlogin));

        /// <summary>
        /// sp_catalogs          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-catalogs-transact-sql
        /// </summary>
        /// <param name="server_name">Is the name of a linked server.</param>
        [ClauseStyleConverter]
        public static void sp_catalogs(string server_name) => throw new InvalitContextException(nameof(sp_catalogs));

        /// <summary>
        /// sp_column_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        [ClauseStyleConverter]
        public static void sp_column_privileges_ex(string table_server) => throw new InvalitContextException(nameof(sp_column_privileges_ex));

        /// <summary>
        /// sp_column_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        /// <param name="table_name">Is the name of the table that contains the specified column.</param>
        [ClauseStyleConverter]
        public static void sp_column_privileges_ex(string table_server, string table_name) => throw new InvalitContextException(nameof(sp_column_privileges_ex));

        /// <summary>
        /// sp_column_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        /// <param name="table_name">Is the name of the table that contains the specified column.</param>
        /// <param name="table_schema">Is the table schema.</param>
        [ClauseStyleConverter]
        public static void sp_column_privileges_ex(string table_server, string table_name, string table_schema) => throw new InvalitContextException(nameof(sp_column_privileges_ex));

        /// <summary>
        /// sp_column_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        /// <param name="table_name">Is the name of the table that contains the specified column.</param>
        /// <param name="table_schema">Is the table schema.</param>
        /// <param name="table_catalog">Is the name of the database in which the specified table_name resides.</param>
        [ClauseStyleConverter]
        public static void sp_column_privileges_ex(string table_server, string table_name, string table_schema, string table_catalog) => throw new InvalitContextException(nameof(sp_column_privileges_ex));

        /// <summary>
        /// sp_column_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        /// <param name="table_name">Is the name of the table that contains the specified column.</param>
        /// <param name="table_schema">Is the table schema.</param>
        /// <param name="table_catalog">Is the name of the database in which the specified table_name resides.</param>
        /// <param name="column_name">Is the name of the column for which to provide privilege information.</param>
        [ClauseStyleConverter]
        public static void sp_column_privileges_ex(string table_server, string table_name, string table_schema, string table_catalog, string column_name) => throw new InvalitContextException(nameof(sp_column_privileges_ex));

        /// <summary>
        /// sp_columns_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return column information.</param>
        [ClauseStyleConverter]
        public static void sp_columns_ex(string table_server) => throw new InvalitContextException(nameof(sp_columns_ex));

        /// <summary>
        /// sp_columns_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return column information.</param>
        /// <param name="table_name">Is the name of the table for which to return column information.</param>
        [ClauseStyleConverter]
        public static void sp_columns_ex(string table_server, string table_name) => throw new InvalitContextException(nameof(sp_columns_ex));

        /// <summary>
        /// sp_columns_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return column information.</param>
        /// <param name="table_name">Is the name of the table for which to return column information.</param>
        /// <param name="table_schema">Is the schema name of the table for which to return column information.</param>
        [ClauseStyleConverter]
        public static void sp_columns_ex(string table_server, string table_name, string table_schema) => throw new InvalitContextException(nameof(sp_columns_ex));

        /// <summary>
        /// sp_columns_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return column information.</param>
        /// <param name="table_name">Is the name of the table for which to return column information.</param>
        /// <param name="table_schema">Is the schema name of the table for which to return column information.</param>
        /// <param name="table_catalog">Is the catalog name of the table for which to return column information.</param>
        [ClauseStyleConverter]
        public static void sp_columns_ex(string table_server, string table_name, string table_schema, string table_catalog) => throw new InvalitContextException(nameof(sp_columns_ex));

        /// <summary>
        /// sp_columns_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return column information.</param>
        /// <param name="table_name">Is the name of the table for which to return column information.</param>
        /// <param name="table_schema">Is the schema name of the table for which to return column information.</param>
        /// <param name="table_catalog">Is the catalog name of the table for which to return column information.</param>
        /// <param name="column_name">Is the name of the database column for which to provide information.</param>
        [ClauseStyleConverter]
        public static void sp_columns_ex(string table_server, string table_name, string table_schema, string table_catalog, string column_name) => throw new InvalitContextException(nameof(sp_columns_ex));

        /// <summary>
        /// sp_columns_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return column information.</param>
        /// <param name="table_name">Is the name of the table for which to return column information.</param>
        /// <param name="table_schema">Is the schema name of the table for which to return column information.</param>
        /// <param name="table_catalog">Is the catalog name of the table for which to return column information.</param>
        /// <param name="column_name">Is the name of the database column for which to provide information.</param>
        /// <param name="ODBCVer">Is the version of ODBC that is being used.</param>
        [ClauseStyleConverter]
        public static void sp_columns_ex(string table_server, string table_name, string table_schema, string table_catalog, string column_name, int ODBCVer) => throw new InvalitContextException(nameof(sp_columns_ex));

        /// <summary>
        /// sp_droplinkedsrvlogin          
        /// rmtsrvname
        /// </summary>
        /// <param name="rmtsrvname">Is the name of a linked server that the SQL Server login mapping applies to.</param>
        /// <param name="locallogin">Is the SQL Server login on the local server that has a mapping to the linked server rmtsrvname.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_droplinkedsrvlogin(string rmtsrvname, string locallogin) => throw new InvalitContextException(nameof(sp_droplinkedsrvlogin));

        /// <summary>
        /// sp_foreignkeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-foreignkeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        [ClauseStyleConverter]
        public static void sp_foreignkeys(string table_server) => throw new InvalitContextException(nameof(sp_foreignkeys));

        /// <summary>
        /// sp_foreignkeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-foreignkeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="pktab_name">Is the name of the table with a primary key.</param>
        [ClauseStyleConverter]
        public static void sp_foreignkeys(string table_server, string pktab_name) => throw new InvalitContextException(nameof(sp_foreignkeys));

        /// <summary>
        /// sp_foreignkeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-foreignkeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="pktab_name">Is the name of the table with a primary key.</param>
        /// <param name="pktab_schema">Is the name of the schema with a primary key.</param>
        [ClauseStyleConverter]
        public static void sp_foreignkeys(string table_server, string pktab_name, string pktab_schema) => throw new InvalitContextException(nameof(sp_foreignkeys));

        /// <summary>
        /// sp_foreignkeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-foreignkeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="pktab_name">Is the name of the table with a primary key.</param>
        /// <param name="pktab_schema">Is the name of the schema with a primary key.</param>
        /// <param name="pktab_catalog">Is the name of the catalog with a primary key.</param>
        [ClauseStyleConverter]
        public static void sp_foreignkeys(string table_server, string pktab_name, string pktab_schema, string pktab_catalog) => throw new InvalitContextException(nameof(sp_foreignkeys));

        /// <summary>
        /// sp_foreignkeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-foreignkeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="pktab_name">Is the name of the table with a primary key.</param>
        /// <param name="pktab_schema">Is the name of the schema with a primary key.</param>
        /// <param name="pktab_catalog">Is the name of the catalog with a primary key.</param>
        /// <param name="fktab_name">Is the name of the table with a foreign key.</param>
        [ClauseStyleConverter]
        public static void sp_foreignkeys(string table_server, string pktab_name, string pktab_schema, string pktab_catalog, string fktab_name) => throw new InvalitContextException(nameof(sp_foreignkeys));

        /// <summary>
        /// sp_foreignkeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-foreignkeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="pktab_name">Is the name of the table with a primary key.</param>
        /// <param name="pktab_schema">Is the name of the schema with a primary key.</param>
        /// <param name="pktab_catalog">Is the name of the catalog with a primary key.</param>
        /// <param name="fktab_name">Is the name of the table with a foreign key.</param>
        /// <param name="fktab_schema">Is the name of the schema with a foreign key.</param>
        [ClauseStyleConverter]
        public static void sp_foreignkeys(string table_server, string pktab_name, string pktab_schema, string pktab_catalog, string fktab_name, string fktab_schema) => throw new InvalitContextException(nameof(sp_foreignkeys));

        /// <summary>
        /// sp_foreignkeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-foreignkeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="pktab_name">Is the name of the table with a primary key.</param>
        /// <param name="pktab_schema">Is the name of the schema with a primary key.</param>
        /// <param name="pktab_catalog">Is the name of the catalog with a primary key.</param>
        /// <param name="fktab_name">Is the name of the table with a foreign key.</param>
        /// <param name="fktab_schema">Is the name of the schema with a foreign key.</param>
        /// <param name="fktab_catalog">Is the name of the catalog with a foreign key.</param>
        [ClauseStyleConverter]
        public static void sp_foreignkeys(string table_server, string pktab_name, string pktab_schema, string pktab_catalog, string fktab_name, string fktab_schema, string fktab_catalog) => throw new InvalitContextException(nameof(sp_foreignkeys));

        /// <summary>
        /// sp_indexes          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-indexes-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of a linked server running SQL Server for which table information is being requested.</param>
        [ClauseStyleConverter]
        public static void sp_indexes(string table_server) => throw new InvalitContextException(nameof(sp_indexes));

        /// <summary>
        /// sp_indexes          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-indexes-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of a linked server running SQL Server for which table information is being requested.</param>
        /// <param name="table_name">Is the name of the remote table for which to provide index information.</param>
        [ClauseStyleConverter]
        public static void sp_indexes(string table_server, string table_name) => throw new InvalitContextException(nameof(sp_indexes));

        /// <summary>
        /// sp_indexes          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-indexes-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of a linked server running SQL Server for which table information is being requested.</param>
        /// <param name="table_name">Is the name of the remote table for which to provide index information.</param>
        /// <param name="table_schema">Specifies the table schema.</param>
        [ClauseStyleConverter]
        public static void sp_indexes(string table_server, string table_name, string table_schema) => throw new InvalitContextException(nameof(sp_indexes));

        /// <summary>
        /// sp_indexes          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-indexes-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of a linked server running SQL Server for which table information is being requested.</param>
        /// <param name="table_name">Is the name of the remote table for which to provide index information.</param>
        /// <param name="table_schema">Specifies the table schema.</param>
        /// <param name="table_catalog">Is the name of the database in which table_name resides.</param>
        [ClauseStyleConverter]
        public static void sp_indexes(string table_server, string table_name, string table_schema, string table_catalog) => throw new InvalitContextException(nameof(sp_indexes));

        /// <summary>
        /// sp_indexes          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-indexes-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of a linked server running SQL Server for which table information is being requested.</param>
        /// <param name="table_name">Is the name of the remote table for which to provide index information.</param>
        /// <param name="table_schema">Specifies the table schema.</param>
        /// <param name="table_catalog">Is the name of the database in which table_name resides.</param>
        /// <param name="index_name">Is the name of the index for which information is being requested.</param>
        [ClauseStyleConverter]
        public static void sp_indexes(string table_server, string table_name, string table_schema, string table_catalog, string index_name) => throw new InvalitContextException(nameof(sp_indexes));

        /// <summary>
        /// sp_indexes          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-indexes-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of a linked server running SQL Server for which table information is being requested.</param>
        /// <param name="table_name">Is the name of the remote table for which to provide index information.</param>
        /// <param name="table_schema">Specifies the table schema.</param>
        /// <param name="table_catalog">Is the name of the database in which table_name resides.</param>
        /// <param name="index_name">Is the name of the index for which information is being requested.</param>
        /// <param name="is_unique">Is the type of index for which to return information.</param>
        [ClauseStyleConverter]
        public static void sp_indexes(string table_server, string table_name, string table_schema, string table_catalog, string index_name, int? is_unique) => throw new InvalitContextException(nameof(sp_indexes));

        /// <summary>
        /// sp_linkedservers          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-linkedservers-transact-sql
        /// </summary>
        /// <returns>0 (success) or a nonzero number (failure)</returns>
       [ClauseStyleConverter]
        public static bool sp_linkedservers() => throw new InvalitContextException(nameof(sp_linkedservers));

        /// <summary>
        /// sp_primarykeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-primarykeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server from which to return primary key information.</param>
        [ClauseStyleConverter]
        public static void sp_primarykeys(string table_server) => throw new InvalitContextException(nameof(sp_primarykeys));

        /// <summary>
        /// sp_primarykeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-primarykeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server from which to return primary key information.</param>
        /// <param name="table_name">Is the name of the table for which to provide primary key information.</param>
        [ClauseStyleConverter]
        public static void sp_primarykeys(string table_server, string table_name) => throw new InvalitContextException(nameof(sp_primarykeys));

        /// <summary>
        /// sp_primarykeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-primarykeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server from which to return primary key information.</param>
        /// <param name="table_name">Is the name of the table for which to provide primary key information.</param>
        /// <param name="table_schema">Is the table schema.</param>
        [ClauseStyleConverter]
        public static void sp_primarykeys(string table_server, string table_name, string table_schema) => throw new InvalitContextException(nameof(sp_primarykeys));

        /// <summary>
        /// sp_primarykeys          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-primarykeys-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server from which to return primary key information.</param>
        /// <param name="table_name">Is the name of the table for which to provide primary key information.</param>
        /// <param name="table_schema">Is the table schema.</param>
        /// <param name="table_catalog">Is the name of the catalog in which the specified table_name resides.</param>
        [ClauseStyleConverter]
        public static void sp_primarykeys(string table_server, string table_name, string table_schema, string table_catalog) => throw new InvalitContextException(nameof(sp_primarykeys));

        /// <summary>
        /// sp_serveroption          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-serveroption-transact-sql
        /// </summary>
        /// <param name="server">Is the name of the server for which to set the option.</param>
        /// <param name="optname">Is the option to set for the specified server.</param>
        /// <param name="optvalue">Specifies whether or not the option_name should be enabled (TRUE or on) or disabled (FALSE or off). option_value is varchar(10), with no default.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_serveroption(string server, string optname, string optvalue) => throw new InvalitContextException(nameof(sp_serveroption));

        /// <summary>
        /// sp_table_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-table-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        [ClauseStyleConverter]
        public static void sp_table_privileges_ex(string table_server) => throw new InvalitContextException(nameof(sp_table_privileges_ex));

        /// <summary>
        /// sp_table_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-table-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        /// <param name="table_name">Is the name of the table for which to provide table privilege information.</param>
        [ClauseStyleConverter]
        public static void sp_table_privileges_ex(string table_server, string table_name) => throw new InvalitContextException(nameof(sp_table_privileges_ex));

        /// <summary>
        /// sp_table_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-table-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        /// <param name="table_name">Is the name of the table for which to provide table privilege information.</param>
        /// <param name="table_schema">Is the table schema. This in some DBMS environments is the table owner.</param>
        [ClauseStyleConverter]
        public static void sp_table_privileges_ex(string table_server, string table_name, string table_schema) => throw new InvalitContextException(nameof(sp_table_privileges_ex));

        /// <summary>
        /// sp_table_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-table-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        /// <param name="table_name">Is the name of the table for which to provide table privilege information.</param>
        /// <param name="table_schema">Is the table schema. This in some DBMS environments is the table owner.</param>
        /// <param name="table_catalog">Is the name of the database in which the specified table_name resides.</param>
        [ClauseStyleConverter]
        public static void sp_table_privileges_ex(string table_server, string table_name, string table_schema, string table_catalog) => throw new InvalitContextException(nameof(sp_table_privileges_ex));

        /// <summary>
        /// sp_table_privileges_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-table-privileges-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return information.</param>
        /// <param name="table_name">Is the name of the table for which to provide table privilege information.</param>
        /// <param name="table_schema">Is the table schema. This in some DBMS environments is the table owner.</param>
        /// <param name="table_catalog">Is the name of the database in which the specified table_name resides.</param>
        /// <param name="fUsePattern">Determines whether the characters '_', '%', '[', and ']' are interpreted as wildcard characters.</param>
        [ClauseStyleConverter]
        public static void sp_table_privileges_ex(string table_server, string table_name, string table_schema, string table_catalog, int? fUsePattern) => throw new InvalitContextException(nameof(sp_table_privileges_ex));

        /// <summary>
        /// sp_tables_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        [ClauseStyleConverter]
        public static void sp_tables_ex(string table_server) => throw new InvalitContextException(nameof(sp_tables_ex));

        /// <summary>
        /// sp_tables_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="table_name">Is the name of the table for which to return data type information.</param>
        [ClauseStyleConverter]
        public static void sp_tables_ex(string table_server, string table_name) => throw new InvalitContextException(nameof(sp_tables_ex));

        /// <summary>
        /// sp_tables_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="table_name">Is the name of the table for which to return data type information.</param>
        /// <param name="table_schema">Is the table schema.</param>
        [ClauseStyleConverter]
        public static void sp_tables_ex(string table_server, string table_name, string table_schema) => throw new InvalitContextException(nameof(sp_tables_ex));

        /// <summary>
        /// sp_tables_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="table_name">Is the name of the table for which to return data type information.</param>
        /// <param name="table_schema">Is the table schema.</param>
        /// <param name="table_catalog">Is the name of the database in which the specified table_name resides.</param>
        [ClauseStyleConverter]
        public static void sp_tables_ex(string table_server, string table_name, string table_schema, string table_catalog) => throw new InvalitContextException(nameof(sp_tables_ex));

        /// <summary>
        /// sp_tables_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="table_name">Is the name of the table for which to return data type information.</param>
        /// <param name="table_schema">Is the table schema.</param>
        /// <param name="table_catalog">Is the name of the database in which the specified table_name resides.</param>
        /// <param name="table_type">Is the type of the table to return.</param>
        [ClauseStyleConverter]
        public static void sp_tables_ex(string table_server, string table_name, string table_schema, string table_catalog, string table_type) => throw new InvalitContextException(nameof(sp_tables_ex));

        /// <summary>
        /// sp_tables_ex          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-tables-ex-transact-sql
        /// </summary>
        /// <param name="table_server">Is the name of the linked server for which to return table information.</param>
        /// <param name="table_name">Is the name of the table for which to return data type information.</param>
        /// <param name="table_schema">Is the table schema.</param>
        /// <param name="table_catalog">Is the name of the database in which the specified table_name resides.</param>
        /// <param name="table_type">Is the type of the table to return.</param>
        /// <param name="fUsePattern">Determines whether the characters _, %, [, and ] are interpreted as wildcard characters.</param>
        [ClauseStyleConverter]
        public static void sp_tables_ex(string table_server, string table_name, string table_schema, string table_catalog, string table_type, int? fUsePattern) => throw new InvalitContextException(nameof(sp_tables_ex));

        /// <summary>
        /// sp_testlinkedserver          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-testlinkedserver-transact-sql
        /// </summary>
        /// <param name="servername">Is the name of the linked server.</param>
        [ClauseStyleConverter]
        public static void sp_testlinkedserver(string servername) => throw new InvalitContextException(nameof(sp_testlinkedserver));

        //--------------------------
        //Firewall Rules Stored Procedures
        //--------------------------
        /// <summary>
        /// sp_set_firewall_rule          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-set-firewall-rule-azure-sql-database
        /// </summary>
        /// <param name="name">The name used to describe and distinguish the server-level firewall setting.</param>
        /// <param name="start_ip_address">The lowest IP address in the range of the server-level firewall setting.</param>
        /// <param name="end_ip_address">The highest IP address in the range of the server-level firewall setting.</param>
        [ClauseStyleConverter]
        public static void sp_set_firewall_rule(string name, string start_ip_address, string end_ip_address) => throw new InvalitContextException(nameof(sp_set_firewall_rule));

        /// <summary>
        /// sp_set_database_firewall_rule          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-set-database-firewall-rule-azure-sql-database
        /// </summary>
        /// <param name="name">The name used to describe and distinguish the database-level firewall setting.</param>
        /// <param name="start_ip_address">The lowest IP address in the range of the database-level firewall setting.</param>
        /// <param name="end_ip_address">The highest IP address in the range of the database-level firewall setting.</param>
        [ClauseStyleConverter]
        public static void sp_set_database_firewall_rule(string name, string start_ip_address, string end_ip_address) => throw new InvalitContextException(nameof(sp_set_database_firewall_rule));

        /// <summary>
        /// sp_delete_firewall_rule          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-delete-firewall-rule-azure-sql-database
        /// </summary>
        /// <param name="name">The name of the server-level firewall setting that will be removed.</param>
        [ClauseStyleConverter]
        public static void sp_delete_firewall_rule(string name) => throw new InvalitContextException(nameof(sp_delete_firewall_rule));

        /// <summary>
        /// sp_delete_database_firewall_rule          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-delete-database-firewall-rule-azure-sql-database
        /// </summary>
        /// <param name="name">The name of the database-level firewall setting that will be removed.</param>
        [ClauseStyleConverter]
        public static void sp_delete_database_firewall_rule(string name) => throw new InvalitContextException(nameof(sp_delete_database_firewall_rule));

        //--------------------------
        //Full-Text Search and Semantic Search Stored Procedures 
        //--------------------------
        /// <summary>
        /// sp_fulltext_catalog          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-catalog-transact-sql
        /// </summary>
        /// <param name="ftcat">Is the name of the full-text catalog.</param>
        /// <param name="action">Is the action to be performed.</param>
        /// <param name="path">Is the root directory (not the complete physical path) for a create action.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_catalog(string ftcat, string action, string path) => throw new InvalitContextException(nameof(sp_fulltext_catalog));

        /// <summary>
        /// sp_fulltext_column          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-column-transact-sql
        /// </summary>
        /// <param name="tabname">Is a one- or two-part table name.</param>
        /// <param name="colname">Is the name of a column in qualified_table_name.</param>
        /// <param name="action">Is the action to be performed.</param>
        /// <param name="language">Is the language of the data stored in the column.</param>
        /// <param name="type_colname">Is the name of a column in qualified_table_name that holds the document type of column_name.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_column(string tabname, string colname, string action, string language, string type_colname) => throw new InvalitContextException(nameof(sp_fulltext_column));

        /// <summary>
        /// sp_fulltext_database          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-column-transact-sql
        /// </summary>
        /// <param name="action">Is the action to be performed.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_database(string action) => throw new InvalitContextException(nameof(sp_fulltext_database));

        /// <summary>
        /// sp_fulltext_keymappings          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-keymappings-transact-sql
        /// </summary>
        [ClauseStyleConverter]
        public static void sp_fulltext_keymappings() => throw new InvalitContextException(nameof(sp_fulltext_keymappings));

        /// <summary>
        /// sp_fulltext_keymappings          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-keymappings-transact-sql
        /// </summary>
        /// <param name="table_id">Is the object ID of the full-text indexed table.</param>
        [ClauseStyleConverter]
        public static void sp_fulltext_keymappings(int table_id) => throw new InvalitContextException(nameof(sp_fulltext_keymappings));

        /// <summary>
        /// sp_fulltext_keymappings          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-keymappings-transact-sql
        /// </summary>
        /// <param name="table_id">Is the object ID of the full-text indexed table.</param>
        /// <param name="docid">Is an internal document identifier (DocId) that corresponds to the key value.</param>
        [ClauseStyleConverter]
        public static void sp_fulltext_keymappings(int table_id, int docid) => throw new InvalitContextException(nameof(sp_fulltext_keymappings));

        /// <summary>
        /// sp_fulltext_keymappings          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-keymappings-transact-sql
        /// </summary>
        /// <param name="table_id">Is the object ID of the full-text indexed table.</param>
        /// <param name="docid">Is an internal document identifier (DocId) that corresponds to the key value.</param>
        /// <param name="null">null.</param>
        [ClauseStyleConverter]
        public static void sp_fulltext_keymappings(int table_id, int docid, object @null) => throw new InvalitContextException(nameof(sp_fulltext_keymappings));

        /// <summary>
        /// sp_fulltext_keymappings          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-keymappings-transact-sql
        /// </summary>
        /// <param name="table_id">Is the object ID of the full-text indexed table.</param>
        /// <param name="docid">Is an internal document identifier (DocId) that corresponds to the key value.</param>
        /// <param name="null">null.</param>
        /// <param name="key">Is the full-text key value from the specified table.</param>
        [ClauseStyleConverter]
        public static void sp_fulltext_keymappings(int table_id, int docid, object @null, string key) => throw new InvalitContextException(nameof(sp_fulltext_keymappings));

        /// <summary>
        /// sp_fulltext_load_thesaurus_file          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-load-thesaurus-file-transact-sql
        /// </summary>
        /// <param name="lcid">Integer mapping the locale identifier (LCID) of the language for which you want to lade the thesaurus XML definition.</param>
        [ClauseStyleConverter]
        public static void sp_fulltext_load_thesaurus_file(int lcid) => throw new InvalitContextException(nameof(sp_fulltext_load_thesaurus_file));

        /// <summary>
        /// sp_fulltext_load_thesaurus_file          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-load-thesaurus-file-transact-sql
        /// </summary>
        /// <param name="lcid">Integer mapping the locale identifier (LCID) of the language for which you want to lade the thesaurus XML definition.</param>
        /// <param name="loadOnlyIfNotLoaded">Specifies whether the thesaurus file is loaded into the internal thesaurus tables even if it has already been loaded.</param>
        [ClauseStyleConverter]
        public static void sp_fulltext_load_thesaurus_file(int lcid, int loadOnlyIfNotLoaded) => throw new InvalitContextException(nameof(sp_fulltext_load_thesaurus_file));

        /// <summary>
        /// sp_fulltext_pendingchanges          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-pendingchanges-transact-sql
        /// </summary>
        /// <param name="table_id">ID of the table.</param>
        [ClauseStyleConverter]
        public static void sp_fulltext_pendingchanges(int table_id) => throw new InvalitContextException(nameof(sp_fulltext_pendingchanges));

        /// <summary>
        /// sp_fulltext_semantic_register_language_statistics_db          
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-semantic-register-language-statistics-db-transact-sql
        /// </summary>
        /// <param name="dbname">Is the name of the Semantic Language Statistics database to be registered for the current instance of SQL Server.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_semantic_register_language_statistics_db(string dbname) => throw new InvalitContextException(nameof(sp_fulltext_semantic_register_language_statistics_db));

        /// <summary>
        /// sp_fulltext_semantic_unregister_language_statistics_db           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-semantic-unregister-language-statistics-db-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_semantic_unregister_language_statistics_db() => throw new InvalitContextException(nameof(sp_fulltext_semantic_unregister_language_statistics_db));

        /// <summary>
        /// sp_fulltext_service           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-service-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_service() => throw new InvalitContextException(nameof(sp_fulltext_service));

        /// <summary>
        /// sp_fulltext_service           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-service-transact-sql
        /// </summary>
        /// <param name="action">Is the property to be changed or reset.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_service(string action) => throw new InvalitContextException(nameof(sp_fulltext_service));

        /// <summary>
        /// sp_fulltext_service           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-service-transact-sql
        /// </summary>
        /// <param name="action">Is the property to be changed or reset.</param>
        /// <param name="value">Is the value of the specified property.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_service(string action, object value) => throw new InvalitContextException(nameof(sp_fulltext_service));

        /// <summary>
        /// sp_fulltext_table           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-table-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_table() => throw new InvalitContextException(nameof(sp_fulltext_table));

        /// <summary>
        /// sp_fulltext_table           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-table-transact-sql
        /// </summary>
        /// <param name="tabname">Is a one- or two-part table name.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_table(string tabname) => throw new InvalitContextException(nameof(sp_fulltext_table));

        /// <summary>
        /// sp_fulltext_table           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-table-transact-sql
        /// </summary>
        /// <param name="tabname">Is a one- or two-part table name.</param>
        /// <param name="action">Is the action to be performed.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_table(string tabname, string action) => throw new InvalitContextException(nameof(sp_fulltext_table));

        /// <summary>
        /// sp_fulltext_table           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-table-transact-sql
        /// </summary>
        /// <param name="tabname">Is a one- or two-part table name.</param>
        /// <param name="action">Is the action to be performed.</param>
        /// <param name="ftcat">Is a valid, existing full-text catalog name for a create action.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_table(string tabname, string action, string ftcat) => throw new InvalitContextException(nameof(sp_fulltext_table));

        /// <summary>
        /// sp_fulltext_table           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-fulltext-table-transact-sql
        /// </summary>
        /// <param name="tabname">Is a one- or two-part table name.</param>
        /// <param name="action">Is the action to be performed.</param>
        /// <param name="ftcat">Is a valid, existing full-text catalog name for a create action.</param>
        /// <param name="keyname">Is a valid single-key-column, unique nonnullable index on qualified_table_name for a create action.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_fulltext_table(string tabname, string action, string ftcat, string keyname) => throw new InvalitContextException(nameof(sp_fulltext_table));

        /// <summary>
        /// sp_help_fulltext_catalogs           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-catalogs-transact-sql
        /// </summary>
        /// <param name="fulltext_catalog_name">Is the name of the full-text catalog.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_catalogs(string fulltext_catalog_name) => throw new InvalitContextException(nameof(sp_help_fulltext_catalogs));

        /// <summary>
        /// sp_help_fulltext_catalog_components           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-catalog-components-transact-sql
        /// </summary>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_catalog_components() => throw new InvalitContextException(nameof(sp_help_fulltext_catalog_components));

        /// <summary>
        /// sp_help_fulltext_catalogs_cursor           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-catalogs-cursor-transact-sql
        /// </summary>
        /// <param name="cursor_return">Is the output variable of type cursor.</param>
        /// <param name="fulltext_catalog_name">Is the name of the full-text catalog.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_catalogs_cursor(object cursor_return, string fulltext_catalog_name) => throw new InvalitContextException(nameof(sp_help_fulltext_catalogs_cursor));

        /// <summary>
        /// sp_help_fulltext_columns           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-columns-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_columns() => throw new InvalitContextException(nameof(sp_help_fulltext_columns));

        /// <summary>
        /// sp_help_fulltext_columns           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-columns-transact-sql
        /// </summary>
        /// <param name="table_name">Is the one- or two-part table name for which full-text index information is requested.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_columns(string table_name) => throw new InvalitContextException(nameof(sp_help_fulltext_columns));

        /// <summary>
        /// sp_help_fulltext_columns           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-columns-transact-sql
        /// </summary>
        /// <param name="table_name">Is the one- or two-part table name for which full-text index information is requested.</param>
        /// <param name="column_name">Is the name of the column for which full-text index metadata is requested.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_columns(string table_name, string column_name) => throw new InvalitContextException(nameof(sp_help_fulltext_columns));

        /// <summary>
        /// sp_help_fulltext_columns_cursor           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-columns-cursor-transact-sql
        /// </summary>
        /// <param name="cursor_return">Is the output variable of type cursor.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_columns_cursor(object cursor_return) => throw new InvalitContextException(nameof(sp_help_fulltext_columns_cursor));

        /// <summary>
        /// sp_help_fulltext_columns_cursor           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-columns-cursor-transact-sql
        /// </summary>
        /// <param name="cursor_return">Is the output variable of type cursor.</param>
        /// <param name="table_name">Is the one- or two-part table name for which full-text index information is requested.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_columns_cursor(object cursor_return, string table_name) => throw new InvalitContextException(nameof(sp_help_fulltext_columns_cursor));

        /// <summary>
        /// sp_help_fulltext_columns_cursor           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-columns-cursor-transact-sql
        /// </summary>
        /// <param name="cursor_return">Is the output variable of type cursor.</param>
        /// <param name="table_name">Is the one- or two-part table name for which full-text index information is requested.</param>
        /// <param name="column_name">Is the name of the column for which full-text index metadata is desired.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_columns_cursor(object cursor_return, string table_name, string column_name) => throw new InvalitContextException(nameof(sp_help_fulltext_columns_cursor));

        /// <summary>
        /// sp_help_fulltext_system_components           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-system-components-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_system_components() => throw new InvalitContextException(nameof(sp_help_fulltext_system_components));

        /// <summary>
        /// sp_help_fulltext_system_components           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-system-components-transact-sql
        /// </summary>
        /// <param name="component_type">Specifies the type of component. component_type can be one of the following.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_system_components(string component_type) => throw new InvalitContextException(nameof(sp_help_fulltext_system_components));

        /// <summary>
        /// sp_help_fulltext_system_components           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-system-components-transact-sql
        /// </summary>
        /// <param name="component_type">Specifies the type of component. component_type can be one of the following.</param>
        /// <param name="param">Depending on component type, this is one of the following.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_system_components(string component_type, int @param) => throw new InvalitContextException(nameof(sp_help_fulltext_system_components));

        /// <summary>
        /// sp_help_fulltext_tables           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-tables-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_tables() => throw new InvalitContextException(nameof(sp_help_fulltext_tables));

        /// <summary>
        /// sp_help_fulltext_tables           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-tables-transact-sql
        /// </summary>
        /// <param name="fulltext_catalog_name">Is the name of the full-text catalog.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_tables(string fulltext_catalog_name) => throw new InvalitContextException(nameof(sp_help_fulltext_tables));

        /// <summary>
        /// sp_help_fulltext_tables           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-tables-transact-sql
        /// </summary>
        /// <param name="fulltext_catalog_name">Is the name of the full-text catalog.</param>
        /// <param name="table_name">Is the one- or two-part table name for which the full-text metadata is requested.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_tables(string fulltext_catalog_name, string table_name) => throw new InvalitContextException(nameof(sp_help_fulltext_tables));

        /// <summary>
        /// sp_help_fulltext_tables_cursor           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-tables-cursor-transact-sql
        /// </summary>
        /// <param name="cursor_return">Is the output variable of type cursor.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_tables_cursor(object cursor_return) => throw new InvalitContextException(nameof(sp_help_fulltext_tables_cursor));

        /// <summary>
        /// sp_help_fulltext_tables_cursor           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-tables-cursor-transact-sql
        /// </summary>
        /// <param name="cursor_return">Is the output variable of type cursor.</param>
        /// <param name="fulltext_catalog_name">Is the name of the full-text catalog.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_tables_cursor(object cursor_return, string fulltext_catalog_name) => throw new InvalitContextException(nameof(sp_help_fulltext_tables_cursor));

        /// <summary>
        /// sp_help_fulltext_tables_cursor           
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-fulltext-tables-cursor-transact-sql
        /// </summary>
        /// <param name="cursor_return">Is the output variable of type cursor.</param>
        /// <param name="fulltext_catalog_name">Is the name of the full-text catalog.</param>
        /// <param name="table_name">Is the one- or two-part table name for which the full-text metadata is requested.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static int sp_help_fulltext_tables_cursor(object cursor_return, string fulltext_catalog_name, string table_name) => throw new InvalitContextException(nameof(sp_help_fulltext_tables_cursor));











        //https://msdn.microsoft.com/en-us/library/ms187961.aspx
        /*
        
        Temporal Table - sys.sp_cleanup_temporal_history
        PolyBase stored procedures - sp_polybase_leave_group
        Active Geo-Replication Stored Procedures
        Catalog Stored Procedures
        Change Data Capture Stored Procedures
        Cursor Stored Procedures
        Data Collector Stored Procedures
        Database Engine Stored Procedures
        Database Mail Stored Procedures
        Database Maintenance Plan Stored Procedures
        Distributed Queries Stored Procedures
        Filestream and FileTable Stored Procedures
        Firewall Rules Stored Procedures (Azure SQL Database)
        Full-Text Search and Semantic Search Stored Procedures
        General Extended Stored Procedures
        Log Shipping Stored Procedures
        Managed Backup Stored Procedures
        Management Data Warehouse Stored Procedures
        OLE Automation Stored Procedures
        Policy-Based Management Stored Procedures
        PolyBase stored procedures
        Query Store Stored Procedures
        Security Stored Procedures
        Snapshot Backup Stored Procedures
        Spatial Index Stored Procedures
        SQL Data Warehouse Stored Procedures
        SQL Server Agent Stored Procedures
        SQL Server Profiler Stored Procedures
        Stretch Database Extended Stored Procedures
        Temporal Table Stored Procedures
        XML Stored Procedures*/
    }
}
