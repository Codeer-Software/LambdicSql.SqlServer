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
        [FuncStyleConverter]
        public static object sp_help_spatial_geometry_index(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index));

        /// <summary>
        /// sp_help_spatial_geometry_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geometry_index(string tabname, string indexname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index));

        /// <summary>
        /// sp_help_spatial_geometry_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
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
        [FuncStyleConverter]
        public static object sp_help_spatial_geometry_index(string tabname, string indexname, byte verboseoutput, object query_sample) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index));

        /// <summary>
        /// sp_help_spatial_geometry_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geometry_index_xml(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index_xml));

        /// <summary>
        /// sp_help_spatial_geometry_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geometry_index_xml(string tabname, string indexname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index_xml));

        /// <summary>
        /// sp_help_spatial_geometry_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
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
        [FuncStyleConverter]
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
        [FuncStyleConverter]
        public static object sp_help_spatial_geometry_index_xml(string tabname, string indexname, byte verboseoutput, object query_sample, string xml_output) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_index_xml));

        /// <summary>
        /// sp_help_spatial_geography_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geography_index(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index));

        /// <summary>
        /// sp_help_spatial_geography_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geography_index(string tabname, string indexname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index));

        /// <summary>
        /// sp_help_spatial_geography_index 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
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
        [FuncStyleConverter]
        public static object sp_help_spatial_geography_index(string tabname, string indexname, byte verboseoutput, object query_sample) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index));

        /// <summary>
        /// sp_help_spatial_geography_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geography_index_xml(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index_xml));

        /// <summary>
        /// sp_help_spatial_geography_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geography_index_xml(string tabname, string indexname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index_xml));

        /// <summary>
        /// sp_help_spatial_geography_index_xml 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-index-xml-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="indexname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="verboseoutput">Is the range of property names and values to be returned.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
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
        [FuncStyleConverter]
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
        [FuncStyleConverter]
        public static object sp_help_spatial_geography_index_xml(string tabname, string indexname, byte verboseoutput, object query_sample, string xml_output) => throw new InvalitContextException(nameof(sp_help_spatial_geography_index_xml));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname, string columnname) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geometry_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geometry-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
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
        [FuncStyleConverter]
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
        [FuncStyleConverter]
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
        [FuncStyleConverter]
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
        [FuncStyleConverter]
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
        [FuncStyleConverter]
        public static object sp_help_spatial_geometry_histogram(string tabname, string columnname, int resolution, float xmin, float ymin, float xmax, float ymax, float sample) => throw new InvalitContextException(nameof(sp_help_spatial_geometry_histogram));

        /// <summary>
        /// sp_help_spatial_geography_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geography_histogram(string tabname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_histogram));

        /// <summary>
        /// sp_help_spatial_geography_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
        public static object sp_help_spatial_geography_histogram(string tabname, string columnname) => throw new InvalitContextException(nameof(sp_help_spatial_geography_histogram));

        /// <summary>
        /// sp_help_spatial_geography_histogram 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-help-spatial-geography-histogram-transact-sql
        /// </summary>
        /// <param name="tabname">Is the qualified or nonqualified name of the table for which the spatial index has been specified.</param>
        /// <param name="columnname">Is the name of the spatial column specified.</param>
        /// <param name="resolution">Is the resolution of the bounding box. Valid values are from 10 to 5000.</param>
        /// <returns>Table.</returns>
        [FuncStyleConverter]
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
        [FuncStyleConverter]
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
        [FuncStyleConverter]
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
        [FuncStyleConverter]
        public static void sp_delete_backup_file_snapshot(string db_name, string snapshot_url) => throw new InvalitContextException(nameof(sp_delete_backup_file_snapshot));

        /// <summary>
        /// sp_delete_backup 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/snapshot-backup-sp-delete-backup
        /// </summary>
        /// <param name="backup_url">The URL of the backup to be deleted, which deletes all snapshots comprising the specified backup set including the backup file itself.</param>
        /// <param name="db_name">The name of the database containing the snapshot to be deleted.</param>
        [FuncStyleConverter]
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
        [FuncStyleConverter]
        public static int sp_polybase_join_group(string head_node_address, int dms_control_channel_port, string head_node_sql_server_instance_name) => throw new InvalitContextException(nameof(sp_polybase_join_group));

        /// <summary>
        /// sp_polybase_leave_group 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/polybase-stored-procedures-sp-polybase-leave-group
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter]
        public static int sp_polybase_leave_group() => throw new InvalitContextException(nameof(sp_polybase_leave_group));

        //--------------------------
        //Filestream and FileTable
        //--------------------------
        /// <summary>
        /// sp_polybase_join_group 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-filestream-force-garbage-collection
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter]
        public static int sp_filestream_force_garbage_collection() => throw new InvalitContextException(nameof(sp_filestream_force_garbage_collection));

        /// <summary>
        /// sp_polybase_join_group 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-filestream-force-garbage-collection
        /// </summary>
        /// <param name="dbname">Signifies the name of the database to run the garbage collector on.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter]
        public static int sp_filestream_force_garbage_collection(string dbname) => throw new InvalitContextException(nameof(sp_filestream_force_garbage_collection));

        /// <summary>
        /// sp_polybase_join_group 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-filestream-force-garbage-collection
        /// </summary>
        /// <param name="dbname">Signifies the name of the database to run the garbage collector on.</param>
        /// <param name="filename">Specifies the logical name of the FILESTREAM container to run the garbage collector on.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter]
        public static int sp_filestream_force_garbage_collection(string dbname, string filename) => throw new InvalitContextException(nameof(sp_filestream_force_garbage_collection));

        /// <summary>
        /// sp_kill_filestream_non_transacted_handles 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-kill-filestream-non-transacted-handles
        /// </summary>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter]
        public static int sp_kill_filestream_non_transacted_handles() => throw new InvalitContextException(nameof(sp_kill_filestream_non_transacted_handles));

        /// <summary>
        /// sp_kill_filestream_non_transacted_handles 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-kill-filestream-non-transacted-handles
        /// </summary>
        /// <param name="table_name">The name of the table in which to close non-transactional handles.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter]
        public static int sp_kill_filestream_non_transacted_handles(string table_name) => throw new InvalitContextException(nameof(sp_kill_filestream_non_transacted_handles));

        /// <summary>
        /// sp_kill_filestream_non_transacted_handles 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/filestream-and-filetable-sp-kill-filestream-non-transacted-handles
        /// </summary>
        /// <param name="table_name">The name of the table in which to close non-transactional handles.</param>
        /// <param name="handle_id">The optional ID of the individual handle to be closed.</param>
        /// <returns>0 (success) or 1 (failure)</returns>
        [FuncStyleConverter]
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
        [FuncStyleConverter]
        public static int sp_wait_for_database_copy_sync(string target_server, string target_database) => throw new InvalitContextException(nameof(sp_wait_for_database_copy_sync));




        //--------------------------
        //Catalog Stored Procedures
        //--------------------------
        /// <summary>
        /// sp_column_privileges 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-column-privileges-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        /// <param name="table_owner">Is the owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="column_name">Is a single column used when only one column of catalog information is being obtained.</param>
        /// <returns>Returns column privilege information for a single table in the current environment</returns>
        [FuncStyleConverter]
        public static object sp_column_privileges(string table_name, string table_owner, string table_qualifier, string column_name) => throw new InvalitContextException(nameof(sp_column_privileges));

        /// <summary>
        /// sp_columns  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-columns-transact-sql
        /// </summary>
        /// <param name="table_name">Is the table used to return catalog information.</param>
        /// <param name="table_owner">Is the owner of the table used to return catalog information.</param>
        /// <param name="table_qualifier">Is the name of the table qualifier.</param>
        /// <param name="column_name">Is a single column used when only one column of catalog information is being obtained.</param>
        /// <param name="ODBCVer">Is the version of ODBC that is being used.</param>
        /// <returns>Returns column information for the specified objects that can be queried in the current environment</returns>
        [FuncStyleConverter]
        public static object sp_columns(string table_name, string table_owner, string table_qualifier, string column_name, int ODBCVer) => throw new InvalitContextException(nameof(sp_columns));

        /// <summary>
        /// sp_databases  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-stored-procedures/sp-databases-transact-sql
        /// </summary>
        /// <returns>Database names that are returned can be used as parameters in the USE statement to change the current database context</returns>
        [FuncStyleConverter]
        public static object sp_databases() => throw new InvalitContextException(nameof(sp_databases));

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
        /// <returns>Returns logical foreign key information for the current environment</returns>
        [FuncStyleConverter]
        public static object sp_fkeys(string pktable_name, string pktable_owner, string pktable_qualifier, string fktable_name, string fktable_owner, string fktable_qualifier) => throw new InvalitContextException(nameof(sp_fkeys));



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
