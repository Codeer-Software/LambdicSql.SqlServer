using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        //----------------@@@-------------------
        /// <summary>
        /// @@DBTS
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/dbts-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@DBTS")]
        public static byte[] AtAtDbts() => throw new InvalitContextException(nameof(AtAtDbts));

        /// <summary>
        /// @@LANGID
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/langid-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@LANGID")]
        public static short AtAtLangid() => throw new InvalitContextException(nameof(AtAtLangid));

        /// <summary>
        /// @@LANGUAGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/language-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@LANGUAGE")]
        public static string AtAtLanguage() => throw new InvalitContextException(nameof(AtAtLanguage));

        /// <summary>
        /// @@LOCK_TIMEOUT
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/lock-timeout-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@LOCK_TIMEOUT")]
        public static int AtAtLock_Timeout() => throw new InvalitContextException(nameof(AtAtLock_Timeout));

        /// <summary>
        /// @@MAX_CONNECTIONS
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/max-connections-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@MAX_CONNECTIONS")]
        public static int AtAtMax_Connections() => throw new InvalitContextException(nameof(AtAtMax_Connections));

        /// <summary>
        /// @@MAX_PRECISION
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/max-precision-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@MAX_PRECISION")]
        public static byte AtAtMax_Precision() => throw new InvalitContextException(nameof(AtAtMax_Precision));

        /// <summary>
        /// @@NESTLEVEL
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/nestlevel-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@NESTLEVEL")]
        public static int AtAtNestLevel() => throw new InvalitContextException(nameof(AtAtNestLevel));

        /// <summary>
        /// @@OPTIONS
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/options-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@OPTIONS")]
        public static int AtAtOptions() => throw new InvalitContextException(nameof(AtAtOptions));

        /// <summary>
        /// @@REMSERVER
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/remserver-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@REMSERVER")]
        public static string AtAtRemserver() => throw new InvalitContextException(nameof(AtAtRemserver));

        /// <summary>
        /// @@SERVERNAME
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/servername-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@SERVERNAME")]
        public static string AtAtServerName() => throw new InvalitContextException(nameof(AtAtServerName));

        /// <summary>
        /// @@SERVICENAME
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/servicename-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@SERVICENAME")]
        public static string AtAtServiceName() => throw new InvalitContextException(nameof(AtAtServiceName));

        /// <summary>
        /// @@SPID
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/spid-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@SPID")]
        public static short AtAtSpId() => throw new InvalitContextException(nameof(AtAtSpId));

        /// <summary>
        /// @@TEXTSIZE
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/textsize-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@TEXTSIZE")]
        public static int AtAtTextSize() => throw new InvalitContextException(nameof(AtAtTextSize));

        /// <summary>
        /// @@VERSION
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/version-transact-sql-configuration-functions
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@VERSION")]
        public static string AtAtVersion() => throw new InvalitContextException(nameof(AtAtVersion));
    }
}
