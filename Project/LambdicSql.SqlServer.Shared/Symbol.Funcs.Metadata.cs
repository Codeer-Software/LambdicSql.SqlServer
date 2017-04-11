using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /// <summary>
        /// Find object id.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/object-id-transact-sql
        /// </summary>
        /// <param name="obj">db object.</param>
        /// <returns>object id.</returns>
        [MethodFormatConverter(Format = "OBJECT_ID([%0])")]
        public static int? Object_Id(object obj) => throw new InvalitContextException(nameof(Object_Id));

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
        /// </summary>
        /// <param name="table">table.</param>
        /// <param name="column">column.</param>
        /// <returns>column length.</returns>
        [MethodFormatConverter(Format = "COL_LENGTH([%0], [#%1])")]
        public static short? Col_Length(object table, object column) => throw new InvalitContextException(nameof(Col_Length));

        /// <summary>
        /// COL_NAME.
        /// </summary>
        /// <param name="table_id">table_id.</param>
        /// <param name="column_id">column_id.</param>
        /// <returns>column name.</returns>
        [FuncStyleConverter]
        public static string Col_Name(int table_id, int column_id) => throw new InvalitContextException(nameof(Col_Name));

        /*
        COLUMNPROPERTY
        DATABASE_PRINCIPAL_ID
        DATABASEPROPERTYEX
        DB_ID
        DB_NAME
        FILE_ID
        FILE_IDEX
        FILE_NAME
        FILEGROUP_ID
        FILEGROUP_NAME
        FILEGROUPPROPERTY
        FILEPROPERTY
        FULLTEXTCATALOGPROPERTY
        FULLTEXTSERVICEPROPERTY
        INDEX_COL
        INDEXKEY_PROPERTY
        INDEXPROPERTY
        NEXT VALUE FOR
        OBJECT_DEFINITION
        OBJECT_ID 
        OBJECT_NAME
        OBJECT_SCHEMA_NAME
        OBJECTPROPERTY
        OBJECTPROPERTYEX
        ORIGINAL_DB_NAME
        PARSENAME
        SCHEMA_ID
        SCHEMA_NAME
        SCOPE_IDENTITY
        SERVERPROPERTY
        STATS_DATE
        TYPE_ID
        TYPE_NAME
        TYPEPROPERTY
        VERSION */




        /*
select object_name(object_id('tbl_staff'));
select OBJECT_DEFINITION(object_id('tbl_staff'));
select OBJECT_SCHEMA_NAME(object_id('tbl_staff'));

select OBJECTPROPERTY(object_id('tbl_staff'), 'CnstIsClustKey');
select OBJECTPROPERTYEX(object_id('tbl_staff'), 'CnstIsClustKey');

select OBJECT_NAME(@@PROCID); 



select APP_NAME(); 


//SELECT APPLOCK_MODE('public', 'Form1', 'Transaction');
//select APPLOCK_TEST ( 'database_principal' , 'resource_name' , 'lock_mode' , 'lock_owner' );

select ASSEMBLYPROPERTY ('HelloWorld' , 'PublicKey');
select COL_LENGTH('tbl_staff', 'id');  
select COL_Name(object_id('tbl_staff'), 1);

SELECT COLUMNPROPERTY(object_id('tbl_staff'),'id','PRECISION'); 

SELECT DATABASE_PRINCIPAL_ID('db_owner');

SELECT DATABASEPROPERTYEX('LambdicSqlTest', 'Collation');
SELECT DB_NAME(DB_ID ('LambdicSqlTest'));
SELECT FILE_ID ('LambdicSqlTest');
SELECT FILE_IDEX ('LambdicSqlTest');
SELECT FILE_NAME ( FILE_ID ('LambdicSqlTest'));
SELECT FILEPROPERTY ('LambdicSqlTest', 'IsReadOnly');


SELECT FILEGROUP_NAME (FILEGROUP_ID ('LambdicSqlTest'));
SELECT FILEGROUPPROPERTY('LambdicSqlTest', 'IsReadOnly');


SELECT FULLTEXTCATALOGPROPERTY ('Cat_Desc' ,'ItemCount');
SELECT fulltextserviceproperty('VerifySignature');


SELECT INDEX_COL ('dbo', 1,1);
SELECT INDEXKEY_PROPERTY(OBJECT_ID('Production.Location', 'U'), 1,1,'ColumnId');
*/
    }
}
