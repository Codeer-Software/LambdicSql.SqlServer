using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

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
        public static decimal AtAtIdentity() => throw new InvalitContextException(nameof(AtAtIdentity));

        /// <summary>
        /// @@PACK_RECEIVED
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/pack-received-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@PACK_RECEIVED")]
        public static int AtAtPackReceived() => throw new InvalitContextException(nameof(AtAtPackReceived));

        /// <summary>
        /// @@ROWCOUNT
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/rowcount-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@ROWCOUNT")]
        public static int AtAtRowCount() => throw new InvalitContextException(nameof(AtAtRowCount));

        /// <summary>
        /// @@TRANCOUNT
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/trancount-transact-sql
        /// </summary>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "@@TRANCOUNT")]
        public static int AtAtTranCount() => throw new InvalitContextException(nameof(AtAtError));

        /// <summary>
        /// BINARY_CHECKSUM
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/binary-checksum-transact-sql
        /// </summary>
        /// <param name="expression">columns or Asterisk()</param>
        /// <returns>check sum.</returns>
        [FuncStyleConverter]
        public static int Binary_CheckSum(params object[] expression) => throw new InvalitContextException(nameof(Binary_CheckSum));

        /// <summary>
        /// CHECKSUM
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/checksum-transact-sql
        /// </summary>
        /// <param name="expression">columns or Asterisk()</param>
        /// <returns>check sum.</returns>
        [FuncStyleConverter]
        public static int CheckSum(params object[] expression) => throw new InvalitContextException(nameof(CheckSum));

        /// <summary>
        /// COMPRESS
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/compress-transact-sql
        /// </summary>
        /// <param name="expression">columns or Asterisk()</param>
        /// <returns>Compressed value.</returns>
        [FuncStyleConverter]
        public static byte[] Compress(object expression) => throw new InvalitContextException(nameof(Compress));

        /// <summary>
        /// CONNECTIONPROPERTY
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/connectionproperty-transact-sql
        /// </summary>
        /// <param name="property">columns or Asterisk()</param>
        /// <returns>Connection property.</returns>
        [FuncStyleConverter]
        public static object ConnectionProperty(object property) => throw new InvalitContextException(nameof(ConnectionProperty));

        /// <summary>
        /// CONTEXT_INFO
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/context-info-transact-sql
        /// </summary>
        /// <returns>context_info.</returns>
        [FuncStyleConverter]
        public static byte[] Context_Info() => throw new InvalitContextException(nameof(Context_Info));

        /// <summary>
        /// CURRENT_REQUEST_ID
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/current-request-id-transact-sql
        /// </summary>
        /// <returns>To find exact information about the current session and current request, use @@SPID and CURRENT_REQUEST_ID(), respectively.</returns>
        [FuncStyleConverter]
        public static short Current_Request_Id() => throw new InvalitContextException(nameof(Current_Request_Id));

        /// <summary>
        /// CURRENT_TRANSACTION_ID
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/current-transaction-id-transact-sql
        /// </summary>
        /// <returns>Transaction ID of the current transaction in the current session, taken from sys.dm_tran_current_transaction (Transact-SQL).</returns>
        [FuncStyleConverter]
        public static long Current_Transaction_Id() => throw new InvalitContextException(nameof(Current_Transaction_Id));

        /// <summary>
        /// DECOMPRESS
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/decompress-transact-sql
        /// </summary>
        /// <param name="expression">compressed value.</param>
        /// <returns>decompressed value.</returns>
        [FuncStyleConverter]
        public static byte[] Decompress(byte[] expression) => throw new InvalitContextException(nameof(Decompress));

        /// <summary>
        /// ERROR_LINE
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/error-line-transact-sql
        /// </summary>
        /// <returns>error line.</returns>
        [FuncStyleConverter]
        public static int Error_Line() => throw new InvalitContextException(nameof(Error_Line));

        /// <summary>
        /// ERROR_MESSAGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/error-message-transact-sql
        /// </summary>
        /// <returns>error message.</returns>
        [FuncStyleConverter]
        public static int Error_Message() => throw new InvalitContextException(nameof(Error_Message));

        /// <summary>
        /// ERROR_NUMBER
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/error-number-transact-sql
        /// </summary>
        /// <returns>error number.</returns>
        [FuncStyleConverter]
        public static int Error_Number() => throw new InvalitContextException(nameof(Error_Number));

        /// <summary>
        /// ERROR_PROCEDURE
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/error-procedure-transact-sql
        /// </summary>
        /// <returns>error procedure.</returns>
        [FuncStyleConverter]
        public static int Error_Procedure() => throw new InvalitContextException(nameof(Error_Procedure));

        /// <summary>
        /// ERROR_SEVERITY
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/error-severity-transact-sql
        /// </summary>
        /// <returns>error severity.</returns>
        [FuncStyleConverter]
        public static int Error_Severity() => throw new InvalitContextException(nameof(Error_Severity));

        /// <summary>
        /// ERROR_STATE
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/error-state-transact-sql
        /// </summary>
        /// <returns>error .</returns>
        [FuncStyleConverter]
        public static int Error_State() => throw new InvalitContextException(nameof(Error_State));

        /// <summary>
        /// FORMATMESSAGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/formatmessage-transact-sql
        /// </summary>
        /// <param name="msg">msg.</param>
        /// <param name="param_values">param_values.</param>
        /// <returns>formated message.</returns>
        [FuncStyleConverter]
        public static string FormatMessage(object msg, params object[] param_values) => throw new InvalitContextException(nameof(FormatMessage));

        /// <summary>
        /// GET_FILESTREAM_TRANSACTION_CONTEXT
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/get-filestream-transaction-context-transact-sql
        /// </summary>
        /// <returns>token.</returns>
        [FuncStyleConverter]
        public static object Get_FileStream_Transaction_Context() => throw new InvalitContextException(nameof(Get_FileStream_Transaction_Context));

        /// <summary>
        /// GETANSINULL
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/getansinull-transact-sql
        /// </summary>
        /// <param name="database">database.</param>
        /// <returns>Returns the default nullability for the database for this session.</returns>
        [FuncStyleConverter]
        public static int GetAnsiNull(string database) => throw new InvalitContextException(nameof(GetAnsiNull));

        /// <summary>
        /// HOST_ID
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/host-id-transact-sql
        /// </summary>
        /// <returns>host id.</returns>
        [FuncStyleConverter]
        public static string Host_Id() => throw new InvalitContextException(nameof(Host_Id));

        /// <summary>
        /// HOST_NAME
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/host-name-transact-sql
        /// </summary>
        /// <returns>host name.</returns>
        [FuncStyleConverter]
        public static string Host_Name() => throw new InvalitContextException(nameof(Host_Name));

        /// <summary>
        /// Replaces NULL with the specified replacement value.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/isnull-transact-sql
        /// </summary>
        /// <param name="check_expression"></param>
        /// <param name="replacement_value"></param>
        /// <returns>check_expression or replacement_value.</returns>
        [FuncStyleConverter]
        public static object IsNull(object check_expression, object replacement_value) => throw new InvalitContextException(nameof(IsNull));

        /// <summary>
        /// ISNUMERIC
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/isnumeric-transact-sql
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>is numeric expression.</returns>
        [FuncStyleConverter]
        public static int IsNumeric(object expression) => throw new InvalitContextException(nameof(IsNumeric));

        //TODO ????
        /*
        $PARTITION
        */

        /*
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
