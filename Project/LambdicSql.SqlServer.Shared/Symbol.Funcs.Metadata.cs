using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

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
        [MethodFormatConverter(Format = "OBJECT_ID('[0]')")]
        public static int? Object_Id(object obj) { throw new InvalitContextException(nameof(Constraint)); }
        //TODO type.
        //やっぱり、stringかなー
        //ToSqlString的なHelper考えるか？

        /*
        @@PROCID
        APP_NAME
        APPLOCK_MODE
        APPLOCK_TEST
        ASSEMBLYPROPERTY
        COL_LENGTH
        COL_NAME
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
