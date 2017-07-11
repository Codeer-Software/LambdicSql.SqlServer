using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.Specialized.SymbolConverters;

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
        public static void sp_sproc_columns(string procedure_name, string procedure_owner, string procedure_qualifier, string column_name, int ODBCVer, bool? fUsePattern) => throw new InvalitContextException(nameof(sp_sproc_columns));

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
        public static void sp_stored_procedures(string sp_name, string sp_owner, string qualifier, bool? fUsePattern) => throw new InvalitContextException(nameof(sp_stored_procedures));

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
        public static void sp_table_privileges(string table_name, string table_owner, string table_qualifier, bool? fUsePattern) => throw new InvalitContextException(nameof(sp_table_privileges));

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
        public static void sp_tables(string table_name, string table_owner, string table_qualifier, string table_type, bool? fUsePattern) => throw new InvalitContextException(nameof(sp_tables));

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
        //public static void sp_cursor_list(string cursor_return, string table_owner, string table_qualifier, string table_type, bool? fUsePattern) => throw new InvalitContextException(nameof(sp_tables));

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
        public static bool sp_syscollector_create_collection_item(int collection_set_id, string collector_type_uid, string name, int frequency, string parameters, int collection_item_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_item));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_create_collection_set(string name) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_create_collection_set(string name, string target) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collection_set   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collection-set-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="target">Reserved for future use.</param>
        /// <param name="collection_mode">Specifies the manner in which the data is collected and stored.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

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
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

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
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

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
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

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
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

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
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

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
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

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
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level, string description) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

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
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level, string description, int collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

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
        public static bool sp_syscollector_create_collection_set(string name, string target, short collection_mode, short days_until_expiration, int? proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level, string description, int collection_set_id, string collection_set_uid) => throw new InvalitContextException(nameof(sp_syscollector_create_collection_set));

        /// <summary>
        /// sp_syscollector_create_collector_type   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_create_collector_type(string collector_type_uid) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

        /// <summary>
        /// sp_syscollector_create_collector_type   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_create_collector_type(string collector_type_uid, string name) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

        /// <summary>
        /// sp_syscollector_create_collector_type   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-create-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <param name="parameter_schema">Is the XML schema for this collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_create_collector_type(string collector_type_uid, string name, string parameter_schema) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

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
        public static bool sp_syscollector_create_collector_type(string collector_type_uid, string name, string parameter_schema, string parameter_formatter) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

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
        public static bool sp_syscollector_create_collector_type(string collector_type_uid, string name, string parameter_schema, string parameter_formatter, string collection_package_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

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
        public static bool sp_syscollector_create_collector_type(string collector_type_uid, string name, string parameter_schema, string parameter_formatter, string collection_package_id, string upload_package_id) => throw new InvalitContextException(nameof(sp_syscollector_create_collector_type));

        /// <summary>
        /// sp_syscollector_delete_collection_item   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-item-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_collection_item() => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_item));

        /// <summary>
        /// sp_syscollector_delete_collection_item   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifier for the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_collection_item(int? collection_item_id) => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_item));

        /// <summary>
        /// sp_syscollector_delete_collection_item   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifier for the collection item.</param>
        /// <param name="name">Is the name of the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_collection_item(int? collection_item_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_item));

        /// <summary>
        /// sp_syscollector_delete_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_set));

        /// <summary>
        /// sp_syscollector_delete_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_set));

        /// <summary>
        /// sp_syscollector_delete_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_delete_collection_set));

        /// <summary>
        /// sp_syscollector_delete_collector_type    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collector-type-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_collector_type() => throw new InvalitContextException(nameof(sp_syscollector_delete_collector_type));

        /// <summary>
        /// sp_syscollector_delete_collector_type    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_collector_type(string collector_type_uid) => throw new InvalitContextException(nameof(sp_syscollector_delete_collector_type));

        /// <summary>
        /// sp_syscollector_delete_collector_type    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-collector-type-transact-sql
        /// </summary>
        /// <param name="collector_type_uid">Is the GUID for the collector type.</param>
        /// <param name="name">Is the name of the collector type.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_collector_type(string collector_type_uid, string name) => throw new InvalitContextException(nameof(sp_syscollector_delete_collector_type));

        /// <summary>
        /// sp_syscollector_delete_execution_log_tree    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-delete-execution-log-tree-transact-sql
        /// </summary>
        /// <param name="log_id">Is the unique identifier for the collection set log.</param>
        /// <param name="from_collection_set">Is the identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_delete_execution_log_tree(int log_id, bool? from_collection_set) => throw new InvalitContextException(nameof(sp_syscollector_delete_execution_log_tree));

        /// <summary>
        /// sp_syscollector_disable_collector    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-disable-collector-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_disable_collector() => throw new InvalitContextException(nameof(sp_syscollector_disable_collector));

        /// <summary>
        /// sp_syscollector_enable_collector    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-enable-collector-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_enable_collector() => throw new InvalitContextException(nameof(sp_syscollector_enable_collector));

        /// <summary>
        /// sp_syscollector_set_cache_directory    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-set-cache-directory-transact-sql
        /// </summary>
        /// <param name="cache_directory">The directory in the file system where collected data is stored temporarily.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_set_cache_directory(string cache_directory) => throw new InvalitContextException(nameof(sp_syscollector_set_cache_directory));

        /// <summary>
        /// sp_syscollector_set_cache_window    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-set-cache-window-transact-sql
        /// </summary>
        /// <param name="cache_window">Is the number of times a failed data upload to the management data warehouse is retried without losing data.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_set_cache_window(int cache_window) => throw new InvalitContextException(nameof(sp_syscollector_set_cache_window));

        /// <summary>
        /// sp_syscollector_set_warehouse_database_name    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-set-warehouse-database-name-transact-sql
        /// </summary>
        /// <param name="database_name">Is the name of the management data warehouse.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_set_warehouse_database_name(string database_name) => throw new InvalitContextException(nameof(sp_syscollector_set_warehouse_database_name));

        /// <summary>
        /// sp_syscollector_set_warehouse_instance_name    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-set-warehouse-instance-name-transact-sql
        /// </summary>
        /// <param name="instance_name">Is the instance name.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_set_warehouse_instance_name(string instance_name) => throw new InvalitContextException(nameof(sp_syscollector_set_warehouse_instance_name));

        /// <summary>
        /// sp_syscollector_start_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-start-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_start_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_start_collection_set));

        /// <summary>
        /// sp_syscollector_start_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-start-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_start_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_start_collection_set));

        /// <summary>
        /// sp_syscollector_start_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-start-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_start_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_start_collection_set));

        /// <summary>
        /// sp_syscollector_stop_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-stop-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_stop_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_stop_collection_set));

        /// <summary>
        /// sp_syscollector_stop_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-stop-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_stop_collection_set(int? collection_set_id ) => throw new InvalitContextException(nameof(sp_syscollector_stop_collection_set));

        /// <summary>
        /// sp_syscollector_stop_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-stop-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_stop_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_stop_collection_set));

        /// <summary>
        /// sp_syscollector_stop_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-stop-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="stop_collection_job">Specifies that the collection job for the collection set be stopped if it is running.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_stop_collection_set(int? collection_set_id, string name, bool? stop_collection_job) => throw new InvalitContextException(nameof(sp_syscollector_stop_collection_set));

        /// <summary>
        /// sp_syscollector_run_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-run-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_run_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_run_collection_set));

        /// <summary>
        /// sp_syscollector_run_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-run-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_run_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_run_collection_set));

        /// <summary>
        /// sp_syscollector_run_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-run-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_run_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_run_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_update_collection_item() => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifer that identifies the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_update_collection_item(int? collection_item_id) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifer that identifies the collection item.</param>
        /// <param name="name">Is the name of the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_update_collection_item(int? collection_item_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_item    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-item-transact-sql
        /// </summary>
        /// <param name="collection_item_id">Is the unique identifer that identifies the collection item.</param>
        /// <param name="name">Is the name of the collection item.</param>
        /// <param name="new_name">Is the new name for the collection item.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_update_collection_item(int? collection_item_id, string name, string new_name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

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
        public static bool sp_syscollector_update_collection_item(int? collection_item_id, string name, string new_name, int frequency) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

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
        public static bool sp_syscollector_update_collection_item(int? collection_item_id, string name, string new_name, int frequency, string parameters) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_item));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_update_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_update_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

        /// <summary>
        /// sp_syscollector_update_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-update-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <param name="new_name">Is the new name for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

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
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

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
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

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
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

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
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

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
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id, string proxy_name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

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
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id, string proxy_name, string schedule_uid) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

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
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id, string proxy_name, string schedule_uid, string schedule_name) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

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
        public static bool sp_syscollector_update_collection_set(int? collection_set_id, string name, string new_name, object target, short collection_mode, short days_until_expiration, int proxy_id, string proxy_name, string schedule_uid, string schedule_name, short logging_level) => throw new InvalitContextException(nameof(sp_syscollector_update_collection_set));

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
        public static bool sp_syscollector_update_collector_type(string collector_type_uid, string name, string parameter_schema, string collection_package_id, string upload_package_id) => throw new InvalitContextException(nameof(sp_syscollector_update_collector_type));

        /// <summary>
        /// sp_syscollector_upload_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-upload-collection-set-transact-sql
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_upload_collection_set() => throw new InvalitContextException(nameof(sp_syscollector_upload_collection_set));

        /// <summary>
        /// sp_syscollector_upload_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-upload-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_upload_collection_set(int? collection_set_id) => throw new InvalitContextException(nameof(sp_syscollector_upload_collection_set));

        /// <summary>
        /// sp_syscollector_upload_collection_set    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-syscollector-upload-collection-set-transact-sql
        /// </summary>
        /// <param name="collection_set_id">Is the unique local identifier for the collection set.</param>
        /// <param name="name">Is the name of the collection set.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_syscollector_upload_collection_set(int? collection_set_id, string name) => throw new InvalitContextException(nameof(sp_syscollector_upload_collection_set));

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
        public static bool sp_add_data_file_recover_suspect_db(string dbName, string filegroup, string name, string filename, string size, string maxsize, string filegrowth) => throw new InvalitContextException(nameof(sp_add_data_file_recover_suspect_db));

        /// <summary>
        /// sp_addextendedproc    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproc-transact-sql
        /// </summary>
        /// <param name="functname">Is the name of the function to call within the dynamic-link library (DLL).</param>
        /// <param name="dllname">Is the name of the DLL that contains the function.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_addextendedproc(string functname, string dllname) => throw new InvalitContextException(nameof(sp_addextendedproc));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_addextendedproperty(string name) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <param name="value">Is the value to be associated with the property.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_addextendedproperty(string name, object value) => throw new InvalitContextException(nameof(sp_addextendedproperty));

        /// <summary>
        /// sp_addextendedproperty    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-addextendedproperty-transact-sql
        /// </summary>
        /// <param name="name">Is the name of the property to be added.</param>
        /// <param name="value">Is the value to be associated with the property.</param>
        /// <param name="level0type">Is the type of level 0 object.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [ClauseStyleConverter]
        public static bool sp_addextendedproperty(string name, object value, string level0type) => throw new InvalitContextException(nameof(sp_addextendedproperty));

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
        public static bool sp_addextendedproperty(string name, object value, string level0type, string level0name) => throw new InvalitContextException(nameof(sp_addextendedproperty));

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
        public static bool sp_addextendedproperty(string name, object value, string level0type, string level0name, string level1type) => throw new InvalitContextException(nameof(sp_addextendedproperty));

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
        public static bool sp_addextendedproperty(string name, object value, string level0type, string level0name, string level1type, string level1name) => throw new InvalitContextException(nameof(sp_addextendedproperty));

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
        public static bool sp_addextendedproperty(string name, object value, string level0type, string level0name, string level1type, string level1name, string level2type) => throw new InvalitContextException(nameof(sp_addextendedproperty));

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
        public static bool sp_addextendedproperty(string name, object value, string level0type, string level0name, string level1type, string level1name, string level2type, string level2name) => throw new InvalitContextException(nameof(sp_addextendedproperty));

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
        public static bool sp_add_log_file_recover_suspect_db(string dbName, string name, string filename, string size, string maxsize, string filegrowth) => throw new InvalitContextException(nameof(sp_add_log_file_recover_suspect_db));

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
        public static bool sp_addmessage(string dbName, string name, string filename, string size, string maxsize, string filegrowth) => throw new InvalitContextException(nameof(sp_add_log_file_recover_suspect_db));













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
