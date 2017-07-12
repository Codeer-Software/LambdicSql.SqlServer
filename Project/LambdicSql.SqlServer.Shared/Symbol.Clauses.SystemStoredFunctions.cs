using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

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
        //Change Tracking Functions
        //--------------------------

        /// <summary>
        /// CHANGETABLE 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/changetable-transact-sql
        /// </summary>
        /// <param name="column_alias">Is the alias name of the table that is returned by CHANGETABLE.</param>
        /// <returns>Table.</returns>
        [MethodFormatConverter(Format = "CHANGETABLE() AS [0]")]
        public static object Changetable(params TableDefinitionElement[] column_alias) => throw new InvalitContextException(nameof(Changetable));

        /// <summary>
        /// CHANGETABLE 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/changetable-transact-sql
        /// </summary>
        /// <param name="CHANGES_table">Returns tracking information for all changes to a table that have occurred since the version that is specified by last_sync_version.</param>
        /// <param name="column_alias">Is the alias name of the table that is returned by CHANGETABLE.</param>
        /// <returns>Table.</returns>
        [MethodFormatConverter(Format = "CHANGETABLE([0]) AS [1]")]
        public static object Changetable(object CHANGES_table, params TableDefinitionElement[] column_alias) => throw new InvalitContextException(nameof(Changetable));

        /// <summary>
        /// CHANGETABLE 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/changetable-transact-sql
        /// </summary>
        /// <param name="CHANGES_table">Returns tracking information for all changes to a table that have occurred since the version that is specified by last_sync_version.</param>
        /// <param name="version">Returns tracking information for all changes to a table that have occurred since the version that is specified by last_sync_version.</param>
        /// <param name="column_alias">Is the alias name of the table that is returned by CHANGETABLE.</param>
        /// <returns>Table.</returns>
        [MethodFormatConverter(Format = "CHANGETABLE([0], [1]) AS [2]")]
        public static object Changetable(object CHANGES_table, object version, params TableDefinitionElement[] column_alias) => throw new InvalitContextException(nameof(Changetable));

        /// <summary>
        /// CHANGETABLE 
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/changetable-transact-sql
        /// </summary>
        /// <param name="CHANGES_table">Returns tracking information for all changes to a table that have occurred since the version that is specified by last_sync_version.</param>
        /// <param name="version">Returns tracking information for all changes to a table that have occurred since the version that is specified by last_sync_version.</param>
        /// <param name="primary_key_values">Is the user-defined table on which to obtain change tracking information. Change tracking must be enabled on the table. A one-, two-, three-, or four-part table name can be used. The table name can be a synonym to the table.</param>
        /// <param name="column_alias">Is the alias name of the table that is returned by CHANGETABLE.</param>
        /// <returns>Table.</returns>
        [MethodFormatConverter(Format = "CHANGETABLE([0], [1], [2]) AS [3]")]
        public static object Changetable(object CHANGES_table, object version, object primary_key_values, params TableDefinitionElement[] column_alias) => throw new InvalitContextException(nameof(Changetable));

        /// <summary>
        /// CHANGE_TRACKING_MIN_VALID_VERSION  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/change-tracking-min-valid-version-transact-sql
        /// </summary>
        /// <param name="table_object_id">Is the object ID of the table. table_object_id is an int.</param>
        /// <returns>bigint</returns>
        [FuncStyleConverter]
        public static long Change_Tracking_Min_Valid_Version(int table_object_id) => throw new InvalitContextException(nameof(Change_Tracking_Min_Valid_Version));

        /// <summary>
        /// CHANGE_TRACKING_CURRENT_VERSION  
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/change-tracking-current-version-transact-sql
        /// </summary>
        /// <returns>bigint</returns>
        [FuncStyleConverter]
        public static long Change_Tracking_Current_Version() => throw new InvalitContextException(nameof(Change_Tracking_Current_Version));

        /// <summary>
        /// CHANGE_TRACKING_IS_COLUMN_IN_MASK   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/change-tracking-current-version-transact-sql
        /// </summary>
        /// <param name="column_id">Is the ID of the column that is being checked. The column ID can be obtained by using the COLUMNPROPERTY function.</param>
        /// <param name="change_columns">Is the binary data from the SYS_CHANGE_COLUMNS column of the CHANGETABLE data.</param>
        /// <returns>bit</returns>
        [FuncStyleConverter]
        public static byte? Change_Tracking_Is_Column_In_Mask<TDst>(int column_id, TDst change_columns) => throw new InvalitContextException(nameof(Change_Tracking_Is_Column_In_Mask));

        //--------------------------
        //Data Collector Functions
        //--------------------------

        /// <summary>
        /// fn_syscollector_get_execution_details   
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/fn-syscollector-get-execution-details-transact-sql
        /// </summary>
        /// <param name="log_id">The local unique identifier for the execution log. log_id is int.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter]
        public static object fn_syscollector_get_execution_details(int log_id) => throw new InvalitContextException(nameof(fn_syscollector_get_execution_details));

        /// <summary>
        /// fn_syscollector_get_execution_stats    
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/fn-syscollector-get-execution-stats-transact-sql
        /// </summary>
        /// <param name="log_id">The local unique identifier for the execution log. log_id is int.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter]
        public static object fn_syscollector_get_execution_stats(int log_id) => throw new InvalitContextException(nameof(fn_syscollector_get_execution_stats));

        //--------------------------
        //Filestream and FileTable Functions
        //--------------------------

        /// <summary>
        /// FileTableRootPath     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/filetablerootpath-transact-sql
        /// </summary>
        /// <returns>nvarchar(4000)</returns>
        [FuncStyleConverter]
        public static string FileTableRootPath() => throw new InvalitContextException(nameof(fn_syscollector_get_execution_stats));

        /// <summary>
        /// FileTableRootPath     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/filetablerootpath-transact-sql
        /// </summary>
        /// <param name="FileTable_name">The name of the FileTable. FileTable_name is of type nvarchar.</param>
        /// <returns>nvarchar(4000)</returns>
        [FuncStyleConverter]
        public static string FileTableRootPath(string FileTable_name) => throw new InvalitContextException(nameof(fn_syscollector_get_execution_stats));

        /// <summary>
        /// FileTableRootPath     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/filetablerootpath-transact-sql
        /// </summary>
        /// <param name="FileTable_name">The name of the FileTable. FileTable_name is of type nvarchar.</param>
        /// <param name="option">An integer expression that defines how the server component of the path should be formatted. @option can have one of the following values.</param>
        /// <returns>nvarchar(4000)</returns>
        [FuncStyleConverter]
        public static string FileTableRootPath(string FileTable_name, int option) => throw new InvalitContextException(nameof(fn_syscollector_get_execution_stats));

        /// <summary>
        /// GetFileNamespacePath     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/filetablerootpath-transact-sql
        /// </summary>
        /// <param name="column_name">The column name of the VARBINARY(MAX) file_stream column in a FileTable.</param>
        /// <returns>nvarchar(max)</returns>
        [FuncStyleConverter]
        public static string GetFileNamespacePath(string column_name) => throw new InvalitContextException(nameof(GetFileNamespacePath));

        /// <summary>
        /// GetFileNamespacePath     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/filetablerootpath-transact-sql
        /// </summary>
        /// <param name="column_name">The column name of the VARBINARY(MAX) file_stream column in a FileTable.</param>
        /// <param name="is_full_path">An integer expression that specifies whether to return a relative or an absolute path. is_full_path can have one of the following values:</param>
        /// <returns>nvarchar(max)</returns>
        [FuncStyleConverter]
        public static string GetFileNamespacePath(string column_name, int is_full_path) => throw new InvalitContextException(nameof(GetFileNamespacePath));

        /// <summary>
        /// GetFileNamespacePath     
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/filetablerootpath-transact-sql
        /// </summary>
        /// <param name="column_name">The column name of the VARBINARY(MAX) file_stream column in a FileTable.</param>
        /// <param name="is_full_path">An integer expression that specifies whether to return a relative or an absolute path. is_full_path can have one of the following values:</param>
        /// <param name="option">An integer expression that defines how the server component of the path should be formatted. @option can have one of the following values:</param>
        /// <returns>nvarchar(max)</returns>
        [FuncStyleConverter]
        public static string GetFileNamespacePath(string column_name, int is_full_path, int option) => throw new InvalitContextException(nameof(GetFileNamespacePath));

        /// <summary>
        /// GetPathLocator      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/getpathlocator-transact-sql
        /// </summary>
        /// <param name="filenamespace_path">A namespace path in the FileTable. The namespace path is of type nvarchar(max).</param>
        /// <returns>hierarchyid</returns>
        [FuncStyleConverter]
        public static string GetPathLocator(string filenamespace_path) => throw new InvalitContextException(nameof(GetPathLocator));

        /// <summary>
        /// PathName      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/pathname-transact-sql
        /// </summary>
        /// <param name="column_name">Is the column name of a varbinary(max) FILESTREAM column. column_name must be a column name. It cannot be an expression nor the result of a CAST or CONVERT statement.</param>
        /// <returns>nvarchar(max)</returns>
        [FuncStyleConverter]
        public static string PathName(string column_name) => throw new InvalitContextException(nameof(PathName));

        /// <summary>
        /// PathName      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/pathname-transact-sql
        /// </summary>
        /// <param name="column_name">Is the column name of a varbinary(max) FILESTREAM column. column_name must be a column name. It cannot be an expression nor the result of a CAST or CONVERT statement.</param>
        /// <param name="option">An integer expression that defines how the server component of the path should be formatted. @option can be one of the following values. The default is 0.</param>
        /// <returns>nvarchar(max)</returns>
        [FuncStyleConverter]
        public static string PathName(string column_name, int option) => throw new InvalitContextException(nameof(PathName));

        /// <summary>
        /// PathName      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/pathname-transact-sql
        /// </summary>
        /// <param name="column_name">Is the column name of a varbinary(max) FILESTREAM column. column_name must be a column name. It cannot be an expression nor the result of a CAST or CONVERT statement.</param>
        /// <param name="option">An integer expression that defines how the server component of the path should be formatted. @option can be one of the following values. The default is 0.</param>
        /// <param name="use_replica_computer_name">A bit value that defines how the server name should be returned in an Always On availability group.</param>
        /// <returns>nvarchar(max)</returns>
        [FuncStyleConverter]
        public static string PathName(string column_name, int option, bool? use_replica_computer_name) => throw new InvalitContextException(nameof(PathName));

        //--------------------------
        //Managed Backup Functions
        //--------------------------
        /// <summary>
        /// Managed Backup Functions
        /// </summary>
        public static Managed_BackupSymbols Managed_Backup => throw new InvalitContextException(nameof(Managed_Backup));

        //--------------------------
        //Full-Text Search and Semantic Search Functions
        //--------------------------
        /// <summary>
        /// CONTAINSTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Containstable(string table) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// CONTAINSTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <param name="column">column_name | ( column_list ) | * .</param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Containstable(string table, object column) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// CONTAINSTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <param name="column">column_name | ( column_list ) | * .</param>
        /// <param name="contains_search_condition"></param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Containstable(string table, object column, object contains_search_condition) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// CONTAINSTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <param name="column">column_name | ( column_list ) | * .</param>
        /// <param name="contains_search_condition"></param>
        /// <param name="language_term">Is the language whose resources will be used for word breaking, stemming, and thesaurus and noise-word (or stopword) removal as part of the query</param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Containstable(string table, object column, object contains_search_condition, object language_term) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// CONTAINSTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <param name="column">column_name | ( column_list ) | * .</param>
        /// <param name="contains_search_condition"></param>
        /// <param name="language_term">Is the language whose resources will be used for word breaking, stemming, and thesaurus and noise-word (or stopword) removal as part of the query</param>
        /// <param name="top_n_by_rank">Specifies that only the n highest ranked matches, in descending order, are returned</param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Containstable(string table, object column, object contains_search_condition, object language_term, int top_n_by_rank) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// FREETEXTTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Freetexttable(string table) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// FREETEXTTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <param name="column">column_name | ( column_list ) | * .</param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Freetexttable(string table, object column) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// FREETEXTTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <param name="column">column_name | ( column_list ) | * .</param>
        /// <param name="freetext_string">Is text to search for in the column_name</param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Freetexttable(string table, object column, string freetext_string) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// FREETEXTTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <param name="column">column_name | ( column_list ) | * .</param>
        /// <param name="freetext_string">Is text to search for in the column_name</param>
        /// <param name="language_term">Is the language whose resources will be used for word breaking, stemming, and thesaurus and noise-word (or stopword) removal as part of the query</param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Freetexttable(string table, object column, string freetext_string, object language_term) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// FREETEXTTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/containstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has been full-text indexed.</param>
        /// <param name="column">column_name | ( column_list ) | * .</param>
        /// <param name="freetext_string">Is text to search for in the column_name</param>
        /// <param name="language_term">Is the language whose resources will be used for word breaking, stemming, and thesaurus and noise-word (or stopword) removal as part of the query</param>
        /// <param name="top_n_by_rank">Specifies that only the n highest ranked matches, in descending order, are returned</param>
        /// <returns>table</returns>
        [FuncStyleConverter]
        public static object Freetexttable(string table, object column, string freetext_string, object language_term, int top_n_by_rank) => throw new InvalitContextException(nameof(Containstable));

        /// <summary>
        /// SEMANTICKEYPHRASETABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/semantickeyphrasetable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has full-text and semantic indexing enabled.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter]
        public static object Semantickeyphrasetable(string table) => throw new InvalitContextException(nameof(Semantickeyphrasetable));

        /// <summary>
        /// SEMANTICKEYPHRASETABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/semantickeyphrasetable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has full-text and semantic indexing enabled.</param>
        /// <param name="column">column | (column_list) | * .</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter]
        public static object Semantickeyphrasetable(string table, object column) => throw new InvalitContextException(nameof(Semantickeyphrasetable));

        /// <summary>
        /// SEMANTICKEYPHRASETABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/semantickeyphrasetable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has full-text and semantic indexing enabled.</param>
        /// <param name="column">column | (column_list) | * .</param>
        /// <param name="source_key">Unique key for the row, to request results for a specific row.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter]
        public static object Semantickeyphrasetable(string table, object column, object source_key) => throw new InvalitContextException(nameof(Semantickeyphrasetable));

        /// <summary>
        /// SEMANTICSIMILARITYDETAILSTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/semanticsimilaritydetailstable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has full-text and semantic indexing enabled.</param>
        /// <param name="source_column">Name of the column in the source row that contains the content to be compared for similarity.</param>
        /// <param name="source_key">The unique key that represents the row of the source document.</param>
        /// <param name="matched_column">Name of the column in the matched row that contains the content to be compared for similarity.</param>
        /// <param name="matched_key">The unique key that represents the row of the matched document.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter]
        public static object Semanticsimilaritydetailstable(string table, string source_column, object source_key, string matched_column, object matched_key) => throw new InvalitContextException(nameof(Semantickeyphrasetable));

        /// <summary>
        /// SEMANTICSIMILARITYTABLE      
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/semanticsimilaritytable-transact-sql
        /// </summary>
        /// <param name="table">Is the name of a table that has full-text and semantic indexing enabled.</param>
        /// <param name="column">column | (column_list) | * .</param>
        /// <param name="source_key">Unique key for the row, to request results for a specific row.</param>
        /// <returns>Table Returned</returns>
        [FuncStyleConverter]
        public static object Semanticsimilaritytable(string table, object column, object source_key) => throw new InvalitContextException(nameof(Semantickeyphrasetable));
    }
}
