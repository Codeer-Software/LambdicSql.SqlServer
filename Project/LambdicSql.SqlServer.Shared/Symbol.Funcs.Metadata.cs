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
        OBJECT_ID Å® special version.
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
    }
}
