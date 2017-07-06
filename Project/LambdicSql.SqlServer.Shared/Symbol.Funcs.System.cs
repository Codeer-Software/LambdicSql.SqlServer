using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// @@TOTAL_WRITE
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/error-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@ERROR")]
        public static int AtAtError() => throw new InvalitContextException(nameof(AtAtError));

        /// <summary>
        /// @@IDENTITY
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/identity-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@IDENTITY")]
        public static decimal AtAtIdentity() => throw new InvalitContextException(nameof(AtAtError));

        /// <summary>
        /// @@PACK_RECEIVED
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/pack-received-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@PACK_RECEIVED")]
        public static int AtAtPackReceived() => throw new InvalitContextException(nameof(AtAtError));

        /// <summary>
        /// @@ROWCOUNT
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/rowcount-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@ROWCOUNT")]
        public static int AtAtRowCount() => throw new InvalitContextException(nameof(AtAtError));

        /// <summary>
        /// @@TRANCOUNT
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/trancount-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@TRANCOUNT")]
        public static int AtAt() => throw new InvalitContextException(nameof(AtAtError));

        /*
        $PARTITION -> ????


        BINARY_CHECKSUM
        CHECKSUM
        COMPRESS
        CONNECTIONPROPERTY
        CONTEXT_INFO
        CURRENT_REQUEST_ID
        CURRENT_TRANSACTION_ID
        DECOMPRESS
        ERROR_LINE
        ERROR_MESSAGE
        ERROR_NUMBER
        ERROR_PROCEDURE
        ERROR_SEVERITY
        ERROR_STATE
        FORMATMESSAGE
        GET_FILESTREAM_TRANSACTION_CONTEXT
        GETANSINULL
        HOST_ID
        HOST_NAME
        ISNULL
        ISNUMERIC
        MIN_ACTIVE_ROWVERSION
        NEWID
        NEWSEQUENTIALID
        ROWCOUNT_BIG
        SESSION_CONTEXT
        SESSION_ID
        XACT_STATE
         */
    }
}
