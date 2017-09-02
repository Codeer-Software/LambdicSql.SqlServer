using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.Specialized.SymbolConverters;
using LambdicSql.SqlServer.ConverterAttributes;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// BEGIN CONVERSATION TIMER.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-conversation-timer-transact-sql
        /// </summary>
        /// <param name="conversation_handle">conversation_handle.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "BEGIN CONVERSATION TIMER([0])")]
        public static Clause<Non> BeginConversationTimer(object conversation_handle) => throw new InvalitContextException(nameof(BeginConversationTimer));

        /// <summary>
        /// BEGIN CONVERSATION TIMER.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-conversation-timer-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="conversation_handle">conversation_handle.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "BEGIN CONVERSATION TIMER([1])")]
        public static Clause<T> BeginConversationTimer<T>(this Clause<T> before, object conversation_handle) => throw new InvalitContextException(nameof(BeginConversationTimer));

        /// <summary>
        /// TIMEOUT = 
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-conversation-timer-transact-sql
        /// </summary>
        /// <param name="timeout">timeout.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "TIMER =")]
        public static Clause<Non> Timeout_Assign(object timeout) => throw new InvalitContextException(nameof(Timeout_Assign));

        /// <summary>
        /// TIMEOUT = 
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-conversation-timer-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="timeout">timeout.</param>
        [ClauseStyleConverter(Name = "TIMER =")]
        public static Clause<T> Timeout_Assign<T>(this Clause<T> before, object timeout) => throw new InvalitContextException(nameof(Timeout_Assign));

        /// <summary>
        /// BEGIN DIALOG CONVERSATION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <param name="dialog_handle">dialog_handle.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN DIALOG CONVERSATION")]
        public static Clause<Non> BeginDialogConversation(object dialog_handle) => throw new InvalitContextException(nameof(BeginDialogConversation));

        /// <summary>
        /// BEGIN DIALOG CONVERSATION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="dialog_handle">dialog_handle.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN DIALOG CONVERSATION")]
        public static Clause<T> BeginDialogConversation<T>(this Clause<T> before, object dialog_handle) => throw new InvalitContextException(nameof(BeginDialogConversation));

        /// <summary>
        /// FROM SERVICE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <param name="path">path.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "FROM SERVICE &left;[0]&right;")]
        public static Clause<Non> FromService(string path) => throw new InvalitContextException(nameof(FromService));

        /// <summary>
        /// FROM SERVICE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="path">path.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "FROM SERVICE &left;[1]&right;")]
        public static Clause<T> FromService<T>(this Clause<T> before, string path) => throw new InvalitContextException(nameof(FromService));

        /// <summary>
        /// TO SERVICE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "TO SERVICE")]
        public static Clause<Non> ToService(string path) => throw new InvalitContextException(nameof(ToService));

        /// <summary>
        /// TO SERVICE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="path">path.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "TO SERVICE")]
        public static Clause<T> ToService<T>(this Clause<T> before, string path) => throw new InvalitContextException(nameof(ToService));

        /// <summary>
        /// ON CONTRACT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <param name="path">path.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ON CONTRACT &left;[0]&right;")]
        public static Clause<Non> OnConcat(string path) => throw new InvalitContextException(nameof(OnConcat));

        /// <summary>
        /// ON CONTRACT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="path">path.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ON CONTRACT &left;[1]&right;")]
        public static Clause<Non> OnConcat<T>(this Clause<T> before, string path) => throw new InvalitContextException(nameof(OnConcat));

        /// <summary>
        /// LIFETIME = 
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <param name="time">time.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "LIFETIME =")]
        public static Clause<Non> LifeTime_Assign(object time) => throw new InvalitContextException(nameof(LifeTime_Assign));

        /// <summary>
        /// LIFETIME = 
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="time">time.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "LIFETIME =")]
        public static Clause<T> LifeTime_Assign<T>(this Clause<T> before, object time) => throw new InvalitContextException(nameof(LifeTime_Assign));

        /// <summary>
        /// WITH.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> With() => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// WITH.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> With<T>(this Clause<T> before) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// ENCRYPTION = 
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <param name="onOff">ON/OFF.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "Encryption =")]
        public static Clause<Non> Encryption_Assign(OnOff onOff) => throw new InvalitContextException(nameof(Encryption_Assign));

        /// <summary>
        /// ENCRYPTION = 
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="onOff">ON/OFF.</param>
        [ClauseStyleConverter(Name = "Encryption =")]
        public static Clause<T> Encryption_Assign<T>(this Clause<T> before, OnOff onOff) => throw new InvalitContextException(nameof(Encryption_Assign));

        /// <summary>
        /// RELATED_CONVERSATION = 
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <param name="related_conversation_handle">related_conversation_handle.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "RELATED_CONVERSATION =")]
        public static Clause<Non> Related_Conversation_Assign(object related_conversation_handle) => throw new InvalitContextException(nameof(Related_Conversation_Assign));

        /// <summary>
        /// RELATED_CONVERSATION = 
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="related_conversation_handle">related_conversation_handle.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "RELATED_CONVERSATION =")]
        public static Clause<Non> Related_Conversation_Assign<T>(this Clause<T> before, object related_conversation_handle) => throw new InvalitContextException(nameof(Related_Conversation_Assign));

        /// <summary>
        /// RELATED_CONVERSATION_GROUP =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <param name="related_conversation_group_id">related_conversation_group_id.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "RELATED_CONVERSATION_GROUP =")]
        public static Clause<Non> Related_Conversation_Group_Assign(object related_conversation_group_id) => throw new InvalitContextException(nameof(Related_Conversation_Group_Assign));

        /// <summary>
        /// RELATED_CONVERSATION_GROUP =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/begin-dialog-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="related_conversation_group_id">related_conversation_group_id.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "RELATED_CONVERSATION_GROUP =")]
        public static Clause<Non> Related_Conversation_Group_Assign<T>(this Clause<T> before, object related_conversation_group_id) => throw new InvalitContextException(nameof(Related_Conversation_Group_Assign));

        /// <summary>
        /// END CONVERSATION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/end-conversation-transact-sql
        /// </summary>
        /// <param name="conversation_handle">conversation_handle.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "END CONVERSATION")]
        public static Clause<Non> EndConversation(object conversation_handle) => throw new InvalitContextException(nameof(EndConversation));

        /// <summary>
        /// END CONVERSATION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/end-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="conversation_handle">conversation_handle.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "END CONVERSATION")]
        public static Clause<T> EndConversation<T>(this Clause<T> before, object conversation_handle) => throw new InvalitContextException(nameof(EndConversation));

        /// <summary>
        /// ERROR =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/end-conversation-transact-sql
        /// </summary>
        /// <param name="error">error.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "ERROR =")]
        public static Clause<Non> Error_Assign(object error) => throw new InvalitContextException(nameof(Error_Assign));

        /// <summary>
        /// ERROR =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/end-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="error">error.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "ERROR =")]
        public static Clause<T> Error_Assign<T>(this Clause<T> before, object error) => throw new InvalitContextException(nameof(Error_Assign));

        /// <summary>
        /// DESCRIPTION =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/end-conversation-transact-sql
        /// </summary>
        /// <param name="description">description.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "DESCRIPTION =")]
        public static Clause<Non> Description_Assign(object description) => throw new InvalitContextException(nameof(Description_Assign));

        /// <summary>
        /// DESCRIPTION =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/end-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="description">description.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "DESCRIPTION =")]
        public static Clause<T> Description_Assign<T>(this Clause<T> before, object description) => throw new InvalitContextException(nameof(Description_Assign));

        /// <summary>
        /// CLEANUP.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/end-conversation-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Cleanup() => throw new InvalitContextException(nameof(Cleanup));

        /// <summary>
        /// CLEANUP.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/end-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Cleanup<T>(this Clause<T> before) => throw new InvalitContextException(nameof(Cleanup));

        /// <summary>
        /// GET CONVERSATION GROUP.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/get-conversation-group-transact-sql
        /// </summary>
        /// <param name="conversation_group_id">conversation_group_id.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "GET CONVERSATION GROUP")]
        public static Clause<Non> GetConversationGroup(object conversation_group_id) => throw new InvalitContextException(nameof(GetConversationGroup));

        /// <summary>
        /// GET CONVERSATION GROUP.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/get-conversation-group-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="conversation_group_id">conversation_group_id.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "GET CONVERSATION GROUP")]
        public static Clause<T> GetConversationGroup<T>(this Clause<T> before, object conversation_group_id) => throw new InvalitContextException(nameof(GetConversationGroup));

        /// <summary>
        /// WAITFOR.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/get-conversation-group-transact-sql
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "WAITFOR(|[0])")]
        public static Clause<Non> WaitFor(SqlExpression expression) => throw new InvalitContextException(nameof(WaitFor));

        /// <summary>
        /// WAITFOR.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/get-conversation-group-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="expression"></param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "WAITFOR(|[1])")]
        public static Clause<T> WaitFor<T>(this Clause<T> before, SqlExpression expression) => throw new InvalitContextException(nameof(WaitFor));

        /// <summary>
        /// WAITFOR(expression), TIMEOUT timeout.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/get-conversation-group-transact-sql
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="timeout"></param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "WAITFOR(|[0]), [1]")]
        public static Clause<Non> WaitForTimeout(SqlExpression expression, object timeout) => throw new InvalitContextException(nameof(WaitForTimeout));

        /// <summary>
        /// WAITFOR(expression), TIMEOUT timeout.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/get-conversation-group-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="expression"></param>
        /// <param name="timeout"></param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "WAITFOR(|[1]), [2]")]
        public static Clause<T> WaitForTimeout<T>(this Clause<T> before, SqlExpression expression, object timeout) => throw new InvalitContextException(nameof(WaitForTimeout));

        /// <summary>
        /// GET_TRANSMISSION_STATUS
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/get-transmission-status-transact-sql
        /// </summary>
        /// <param name="conversation_handle">conversation_handle.</param>
        /// <returns>Returns a string describing the status of the last transmission attempt for the specified conversation. </returns>
        [FuncStyleConverter]
        public static string Get_Transmission_Status(object conversation_handle) => throw new InvalitContextException(nameof(conversation_handle));

        /// <summary>
        /// MOVE CONVERSATION conversation_handle TO conversation_group_id.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/move-conversation-transact-sql
        /// </summary>
        /// <param name="conversation_handle">conversation_handle.</param>
        /// <param name="conversation_group_id">conversation_group_id.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "MOVE CONVERSATION [0] TO [1]")]
        public static Clause<Non> MoveConversationTo(object conversation_handle, object conversation_group_id) => throw new InvalitContextException(nameof(MoveConversationTo));

        /// <summary>
        /// MOVE CONVERSATION conversation_handle TO conversation_group_id.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/move-conversation-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="conversation_handle">conversation_handle.</param>
        /// <param name="conversation_group_id">conversation_group_id.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "MOVE CONVERSATION [1] TO [2]")]
        public static Clause<T> MoveConversationTo<T>(this Clause<T> before, object conversation_handle, object conversation_group_id) => throw new InvalitContextException(nameof(MoveConversationTo));

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<T> Receive<T>(T selected) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="TSrc"></typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<T> Receive<TSrc, T>(this Clause<TSrc> before, T selected) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<T> Receive<T>(TopBase top, T selected) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="TSrc">If there is a Receive clause before, it is the type selected there. Normally, the Receive clause does not exist before the Receive clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<T> Receive<TSrc, T>(this Clause<TSrc> before, TopBase top, T selected) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<Non> Receive(AsteriskBase asterisk) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="TSrc">If there is a Receive clause before, it is the type selected there. Normally, the Receive clause does not exist before the Receive clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<Non> Receive<TSrc>(this Clause<TSrc> before, AsteriskBase asterisk) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<T> Receive<T>(AsteriskBase<T> asterisk) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="TSrc">If there is a Receive clause before, it is the type selected there. Normally, the Receive clause does not exist before the Receive clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<T> Receive<TSrc, T>(this Clause<TSrc> before, AsteriskBase<T> asterisk) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<Non> Receive(TopBase top, AsteriskBase asterisk) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="TSrc">If there is a Receive clause before, it is the type selected there. Normally, the Receive clause does not exist before the Receive clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<Non> Receive<TSrc>(this Clause<TSrc> before, TopBase top, AsteriskBase asterisk) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<T> Receive<T>(TopBase top, AsteriskBase<T> asterisk) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// RECEIVE  clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/receive-transact-sql
        /// </summary>
        /// <typeparam name="TSrc">If there is a Receive clause before, it is the type selected there. Normally, the Receive clause does not exist before the Receive clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter(Name = "RECEIVE")]
        public static Clause<T> Receive<TSrc, T>(this Clause<TSrc> before, TopBase top, AsteriskBase<T> asterisk) { throw new InvalitContextException(nameof(Receive)); }

        /// <summary>
        /// SEND ON CONVERSATION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/send-transact-sql
        /// </summary>
        /// <param name="dialogHandle">dialogHandle.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SEND ON CONVERSATION")]
        public static Clause<Non> SendOnConversation(object dialogHandle) => throw new InvalitContextException(nameof(SendOnConversation));

        /// <summary>
        /// SEND ON CONVERSATION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/send-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="dialogHandle">dialogHandle.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SEND ON CONVERSATION")]
        public static Clause<T> SendOnConversation<T>(this Clause<T> before, object dialogHandle) => throw new InvalitContextException(nameof(SendOnConversation));

        /// <summary>
        /// MESSAGE TYPE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/send-transact-sql
        /// </summary>
        /// <param name="path">path.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "MESSAGE TYPE &left;[0]&right;")]
        public static Clause<Non> MessageType(string path) => throw new InvalitContextException(nameof(MessageType));

        /// <summary>
        /// MESSAGE TYPE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/send-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="path">path.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "MESSAGE TYPE &left;[1]&right;")]
        public static Clause<T> MessageType<T>(this Clause<T> before, string path) => throw new InvalitContextException(nameof(MessageType));
    }
}
