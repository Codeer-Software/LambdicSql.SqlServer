using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// @@PROCID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/procid-transact-sql
        /// </summary>
        /// <returns>proc id.</returns>
        [ClauseStyleConverter(Name = "@@PROCID")]
        public static int AtAtProcId() => throw new InvalitContextException(nameof(AtAtProcId));

        /// <summary>
        /// APP_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/app-name-transact-sql
        /// </summary>
        /// <returns>app name.</returns>
        [FuncStyleConverter]
        public static string App_Name() => throw new InvalitContextException(nameof(App_Name));

        //TODO test.
        /// <summary>
        /// APPLOCK_MODE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/applock-mode-transact-sql
        /// </summary>
        /// <param name="database_principal">database_principal.</param>
        /// <param name="resource_name">resource_name.</param>
        /// <param name="lock_owner">lock_owner.</param>
        /// <returns>app lock mode.</returns>
        [FuncStyleConverter]
        public static string AppLock_Mode(string database_principal, string resource_name, string lock_owner) => throw new InvalitContextException(nameof(AppLock_Mode));

        //TOTO test.
        /// <summary>
        /// APPLOCK_TEST.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/applock-test-transact-sql
        /// </summary>
        /// <param name="database_principal">database_principal.</param>
        /// <param name="resource_name">resource_name.</param>
        /// <param name="lock_mode">lock_mode.</param>
        /// <param name="lock_owner">lock_owner.</param>
        /// <returns>0 or 1.</returns>
        [FuncStyleConverter]
        public static short AppLock_Test(string database_principal, string resource_name, string lock_mode, string lock_owner) => throw new InvalitContextException(nameof(AppLock_Test));

        /// <summary>
        /// ASSEMBLYPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/assemblyproperty-transact-sql
        /// </summary>
        /// <param name="assembly_name">assembly_name.</param>
        /// <param name="property_name">property_name.</param>
        /// <returns>assembly property.</returns>
        [FuncStyleConverter]
        public static object AssemblyProperty(string assembly_name, string property_name) => throw new InvalitContextException(nameof(AssemblyProperty));

        /// <summary>
        /// COL_LENGTH.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/col-length-transact-sql
        /// </summary>
        /// <param name="table">table object or table name text.</param>
        /// <param name="column">column or column name.</param>
        /// <returns>column length.</returns>
        [MethodFormatConverter(Format = "COL_LENGTH([%0], [#%1])")]
        public static short? Col_Length(object table, object column) => throw new InvalitContextException(nameof(Col_Length));

        /// <summary>
        /// COL_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/col-name-transact-sql
        /// </summary>
        /// <param name="table_id">table_id.</param>
        /// <param name="column_id">column_id.</param>
        /// <returns>column name.</returns>
        [FuncStyleConverter]
        public static string Col_Name(int? table_id, int column_id) => throw new InvalitContextException(nameof(Col_Name));

        /// <summary>
        /// COLUMNPROPERTY
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/columnproperty-transact-sql
        /// </summary>
        /// <param name="table_id">table_id</param>
        /// <param name="column_name">column object or column name.</param>
        /// <param name="property">property</param>
        /// <returns>column property.</returns>
        [MethodFormatConverter(Format = "COLUMNPROPERTY([0], [#%1], [2])")]
        public static int? ColumnProperty(int? table_id, object column_name, string property) => throw new InvalitContextException(nameof(ColumnProperty));

        /// <summary>
        /// DATABASE_PRINCIPAL_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/database-principal-id-transact-sql
        /// </summary>
        /// <returns>database principal id.</returns>
        [FuncStyleConverter]
        public static int DataBase_Principal_Id() => throw new InvalitContextException(nameof(DataBase_Principal_Id));

        /// <summary>
        /// DATABASE_PRINCIPAL_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/database-principal-id-transact-sql
        /// </summary>
        /// <param name=" sysname">sysname.</param>
        /// <returns>database principal id.</returns>
        [FuncStyleConverter]
        public static int? DataBase_Principal_Id(string sysname) => throw new InvalitContextException(nameof(DataBase_Principal_Id));

        /// <summary>
        /// DATABASEPROPERTYEX.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/databasepropertyex-transact-sql
        /// </summary>
        /// <param name="database">database.</param>
        /// <param name="property">property.</param>
        /// <returns>database property.</returns>
        [FuncStyleConverter]
        public static object DataBasePropertyEx(string database, string property) => throw new InvalitContextException(nameof(DataBasePropertyEx));

        /// <summary>
        /// DB_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/db-id-transact-sql
        /// </summary>
        /// <param name="database_name">database_name.</param>
        /// <returns>id.</returns>
        [FuncStyleConverter]
        public static int? Db_Id(string database_name) => throw new InvalitContextException(nameof(Db_Id));

        /// <summary>
        /// DB_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/db-name-transact-sql
        /// </summary>
        /// <param name="database_id">database_id.</param>
        /// <returns>name.</returns>
        [FuncStyleConverter]
        public static string Db_Name(int? database_id) => throw new InvalitContextException(nameof(Db_Name));

        /// <summary>
        /// FILE_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/file-id-transact-sql
        /// </summary>
        /// <param name="file_name">file_name.</param>
        /// <returns>file id.</returns>
        [FuncStyleConverter]
        public static ushort? File_Id(string file_name) => throw new InvalitContextException(nameof(File_Id));

        /// <summary>
        /// FILE_IDEX.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/file-idex-transact-sql
        /// </summary>
        /// <param name="file_name">file_name.</param>
        /// <returns>file index.</returns>
        [FuncStyleConverter]
        public static int? File_Idex(string file_name) => throw new InvalitContextException(nameof(File_Idex));

        /// <summary>
        /// FILE_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/file-name-transact-sql
        /// </summary>
        /// <param name="file_id">file_id.</param>
        /// <returns>file name.</returns>
        [FuncStyleConverter]
        public static string File_Name(ushort? file_id) => throw new InvalitContextException(nameof(File_Name));

        /// <summary>
        /// FILEGROUP_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/filegroup-id-transact-sql
        /// </summary>
        /// <param name="filegroup_name">filegroup_name.</param>
        /// <returns>file group id.</returns>
        [FuncStyleConverter]
        public static int? FileGroup_Id(string filegroup_name) => throw new InvalitContextException(nameof(FileGroup_Id));

        /// <summary>
        /// FILEGROUP_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/filegroup-name-transact-sql
        /// </summary>
        /// <param name="file_id">file_id.</param>
        /// <returns>file group name.</returns>
        [FuncStyleConverter]
        public static string FileGroup_Name(int? file_id) => throw new InvalitContextException(nameof(FileGroup_Name));

        /// <summary>
        /// FILEGROUPPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/filegroupproperty-transact-sql
        /// </summary>
        /// <param name="filegroup_name">filegroup_name.</param>
        /// <param name="property">property.</param>
        /// <returns>file gropu property.</returns>
        [FuncStyleConverter]
        public static int? FileGroupProperty(string filegroup_name, string property) => throw new InvalitContextException(nameof(FileGroupProperty));

        /// <summary>
        /// FILEPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/fileproperty-transact-sql
        /// </summary>
        /// <param name="file_name">file_name.</param>
        /// <param name="property">property.</param>
        /// <returns>file property.</returns>
        [FuncStyleConverter]
        public static int? FileProperty(string file_name, string property) => throw new InvalitContextException(nameof(FileProperty));

        /// <summary>
        /// FULLTEXTCATALOGPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/fulltextcatalogproperty-transact-sql
        /// </summary>
        /// <param name="catalog_name">catalog_name.</param>
        /// <param name="property">property.</param>
        /// <returns>full text catalog property.</returns>
        [FuncStyleConverter]
        public static int? FullTextCatalogProperty(string catalog_name, string property) => throw new InvalitContextException(nameof(FullTextCatalogProperty));

        /// <summary>
        /// FULLTEXTSERVICEPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/fulltextserviceproperty-transact-sql
        /// </summary>
        /// <param name="property">property.</param>
        /// <returns>full text service property.</returns>
        [FuncStyleConverter]
        public static int? FullTextServiceProperty(string property) => throw new InvalitContextException(nameof(FullTextServiceProperty));

        /// <summary>
        /// INDEX_COL.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/index-col-transact-sql
        /// </summary>
        /// <param name="table_or_view_name">object or name text.</param>
        /// <param name="index_id">index_id.</param>
        /// <param name="key_id">key_id.</param>
        /// <returns>index column.</returns>
        [MethodFormatConverter(Format = "INDEX_COL([%0], [1], [2])")]
        public static string Index_Col(object table_or_view_name, int index_id , int key_id) => throw new InvalitContextException(nameof(FullTextServiceProperty));

        /// <summary>
        /// INDEXKEY_PROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/indexkey-property-transact-sql
        /// </summary>
        /// <param name="object_id">object_id.</param>
        /// <param name="index_id">index_id.</param>
        /// <param name="key_id">key_id.</param>
        /// <param name="property">property.</param>
        /// <returns>indexkey property.</returns>
        [FuncStyleConverter]
        public static int? IndexKey_Property(int? object_id, int index_id, int key_id, string property) => throw new InvalitContextException(nameof(IndexKey_Property));

        /// <summary>
        /// INDEXPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/indexproperty-transact-sql
        /// </summary>
        /// <param name="object_id">object_id.</param>
        /// <param name="index_or_statistics_name">index_or_statistics_name.</param>
        /// <param name="property">property.</param>
        /// <returns>index property.</returns>
        [FuncStyleConverter]
        public static int? IndexProperty(int? object_id, string index_or_statistics_name, string property) => throw new InvalitContextException(nameof(IndexProperty));

        //TODO test.
        /// <summary>
        /// NEXT VALUE FOR.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/next-value-for-transact-sql
        /// </summary>
        /// <param name="sequence_name">sequence_name.</param>
        /// <returns>number.</returns>
        [MethodFormatConverter(Format = "NEXT VALUE FOR [!0]")]
        public static int? NextValueFor(object sequence_name) => throw new InvalitContextException(nameof(NextValueFor));

        /// <summary>
        /// OBJECT_DEFINITION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/object-definition-transact-sql
        /// </summary>
        /// <param name="object_id">object_id.</param>
        /// <returns>number.</returns>
        [FuncStyleConverter]
        public static object Object_Definition(int? object_id) => throw new InvalitContextException(nameof(Object_Definition));

        /// <summary>
        /// OBJECT_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/object-id-transact-sql
        /// </summary>
        /// <param name="obj">db object or name text.</param>
        /// <returns>object id.</returns>
        [MethodFormatConverter(Format = "OBJECT_ID([%0])")]
        public static int? Object_Id(object obj) => throw new InvalitContextException(nameof(Object_Id));

        /// <summary>
        /// OBJECT_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/object-id-transact-sql
        /// </summary>
        /// <param name="obj">db object or name text.</param>
        /// <param name="object_type">object_type.</param>
        /// <returns>object id.</returns>
        [MethodFormatConverter(Format = "OBJECT_ID([%0], [1])")]
        public static int? Object_Id(object obj, string object_type) => throw new InvalitContextException(nameof(Object_Id));

        /// <summary>
        /// OBJECT_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/object-name-transact-sql
        /// </summary>
        /// <param name="object_id">object_id.</param>
        /// <returns>object name.</returns>
        [FuncStyleConverter]
        public static string Object_Name(int? object_id) => throw new InvalitContextException(nameof(Object_Name));

        /// <summary>
        /// OBJECT_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/object-name-transact-sql
        /// </summary>
        /// <param name="object_id">object_id.</param>
        /// <param name="database_id">database_id.</param>
        /// <returns>object name.</returns>
        [FuncStyleConverter]
        public static string Object_Name(int? object_id, int? database_id) => throw new InvalitContextException(nameof(Object_Name));

        /// <summary>
        /// OBJECT_SCHEMA_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/object-schema-name-transact-sql
        /// </summary>
        /// <param name="object_id">object_id.</param>
        /// <returns>object schema name.</returns>
        [FuncStyleConverter]
        public static string Object_Schema_Name(int? object_id) => throw new InvalitContextException(nameof(Object_Schema_Name));

        /// <summary>
        /// OBJECTPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/objectproperty-transact-sql
        /// </summary>
        /// <param name="object_id">object_id.</param>
        /// <param name="property">property.</param>
        /// <returns>object property.</returns>
        [FuncStyleConverter]
        public static object ObjectProperty(int? object_id, string property) => throw new InvalitContextException(nameof(ObjectProperty));
        
        /// <summary>
        /// OBJECTPROPERTYEX.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/objectpropertyex-transact-sql
        /// </summary>
        /// <param name="object_id">object_id.</param>
        /// <param name="property">property.</param>
        /// <returns>object propertyex.</returns>
        [FuncStyleConverter]
        public static object ObjectPropertyEx(int? object_id, string property) => throw new InvalitContextException(nameof(ObjectPropertyEx));

        /// <summary>
        /// ORIGINAL_DB_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/original-db-name-transact-sql
        /// </summary>
        /// <returns>original db name.</returns>
        [FuncStyleConverter]
        public static string Original_Db_Name() => throw new InvalitContextException(nameof(Original_Db_Name));

        /// <summary>
        /// PARSENAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/parsename-transact-sql
        /// </summary>
        /// <param name="object_name">object_name.</param>
        /// <param name="object_piece">object_piece.</param>
        /// <returns>parsed name.</returns>
        [MethodFormatConverter(Format = "PARSENAME([%0], [1])")]
        public static string ParseName(object object_name, int object_piece) => throw new InvalitContextException(nameof(ParseName));

        /// <summary>
        /// SCHEMA_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/schema-id-transact-sql
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <returns>schema id.</returns>
        [MethodFormatConverter(Format = "SCHEMA_ID([%0])")]
        public static int? Schema_Id(object schema) => throw new InvalitContextException(nameof(Schema_Id));

        /// <summary>
        /// SCHEMA_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/schema-name-transact-sql
        /// </summary>
        /// <param name="schema_id">schema_id.</param>
        /// <returns>schema name.</returns>
        [FuncStyleConverter]
        public static string Schema_Name(int? schema_id) => throw new InvalitContextException(nameof(Schema_Name));

        /// <summary>
        /// SCOPE_IDENTITY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/scope-identity-transact-sql
        /// </summary>
        /// <returns>scope identity.</returns>
        [FuncStyleConverter]
        public static decimal? Scope_Identity() => throw new InvalitContextException(nameof(Scope_Identity));

        /// <summary>
        /// SERVERPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/serverproperty-transact-sql
        /// </summary>
        /// <param name="propertyname">propertyname.</param>
        /// <returns>server property.</returns>
        [FuncStyleConverter]
        public static object ServerProperty(string propertyname) => throw new InvalitContextException(nameof(Scope_Identity));

        /// <summary>
        /// STATS_DATE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/stats-date-transact-sql
        /// </summary>
        /// <param name="object_id">object_id.</param>
        /// <param name="stats_id">stats_id.</param>
        /// <returns>stats date.</returns>
        [FuncStyleConverter]
        public static DateTime? Stats_Date(int? object_id, int stats_id) => throw new InvalitContextException(nameof(Stats_Date));
      
        /// <summary>
        /// TYPE_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/type-id-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <returns>type id.</returns>
        [FuncStyleConverter]
        public static int? Type_Id(string name) => throw new InvalitContextException(nameof(Type_Id));

        //TODO Ç±ÇÍÇ‡%Ç≈âåàÇ≈Ç´ÇΩÇÁÇ¢Ç¢ÇÊÇ»Å[
        /*
        /// <summary>
        /// TYPE_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/type-id-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <returns>type id.</returns>
        [FuncStyleConverter]
        public static int? Type_Id(DataTypeElement name) => throw new InvalitContextException(nameof(Type_Id));
        */

        /// <summary>
        /// TYPE_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/type-name-transact-sql
        /// </summary>
        /// <param name="type_id">type_id.</param>
        /// <returns>type name.</returns>
        [FuncStyleConverter]
        public static string Type_Name(int? type_id) => throw new InvalitContextException(nameof(Type_Name));
        
        /// <summary>
        /// TYPEPROPERTY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/typeproperty-transact-sql
        /// </summary>
        /// <param name="type_id">type_id.</param>
        /// <param name="property">property.</param>
        /// <returns>type property.</returns>
        [FuncStyleConverter]
        public static int? TypeProperty(int? type_id, string property) => throw new InvalitContextException(nameof(TypeProperty));

        //TODO can't use.
        /// <summary>
        /// VERSION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/version-transact-sql-metadata-functions
        /// </summary>
        /// <returns>version.</returns>
        [FuncStyleConverter]
        public static int Version() => throw new InvalitContextException(nameof(Version));
    }
}
