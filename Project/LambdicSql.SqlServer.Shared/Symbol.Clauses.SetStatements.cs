using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// SET ANSI_DEFAULTS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-defaults-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_DEFAULTS")]
        public static Clause<Non> Set_Ansi_Defaults(bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Defaults));

        /// <summary>
        /// SET ANSI_DEFAULTS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-defaults-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_DEFAULTS")]
        public static Clause<T> Set_Ansi_Defaults<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Defaults));

        /// <summary>
        /// SET ANSI_NULL_DFLT_OFF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-null-dflt-off-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_NULL_DFLT_OFF")]
        public static Clause<Non> Set_Ansi_Null_Dflt_Off(bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Null_Dflt_Off));

        /// <summary>
        /// SET ANSI_NULL_DFLT_OFF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-null-dflt-off-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_NULL_DFLT_OFF")]
        public static Clause<T> Set_Ansi_Null_Dflt_Off<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Null_Dflt_Off));

        /// <summary>
        /// SET ANSI_NULL_DFLT_ON.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-null-dflt-on-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_NULL_DFLT_ON")]
        public static Clause<Non> Set_Ansi_Null_Dflt_On(bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Null_Dflt_On));

        /// <summary>
        /// SET ANSI_NULL_DFLT_ON.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-null-dflt-on-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_NULL_DFLT_ON")]
        public static Clause<T> Set_Ansi_Null_Dflt_On<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Null_Dflt_On));

        /// <summary>
        /// SET ANSI_NULLS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-nulls-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_NULLS")]
        public static Clause<Non> Set_Ansi_Nulls(bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Nulls));

        /// <summary>
        /// SET ANSI_NULLS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-nulls-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_NULLS")]
        public static Clause<T> Set_Ansi_Nulls<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Nulls));

        /// <summary>
        /// SET ANSI_PADDING.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-padding-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_PADDING")]
        public static Clause<Non> Set_Ansi_Padding(bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Padding));

        /// <summary>
        /// SET ANSI_PADDING.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-padding-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_PADDING")]
        public static Clause<T> Set_Ansi_Padding<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Padding));

        /// <summary>
        /// SET ANSI_WARNINGS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-warnings-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_WARNINGS")]
        public static Clause<Non> Set_Ansi_Warnings(bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Warnings));

        /// <summary>
        /// SET ANSI_WARNINGS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-ansi-warnings-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ANSI_WARNINGS")]
        public static Clause<T> Set_Ansi_Warnings<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Ansi_Warnings));

        /// <summary>
        /// SET ARITHABORT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-arithabort-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ARITHABORT")]
        public static Clause<Non> Set_ArithAbort(bool isOn) => throw new InvalitContextException(nameof(Set_ArithAbort));

        /// <summary>
        /// SET ARITHABORT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-arithabort-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ARITHABORT")]
        public static Clause<T> Set_ArithAbort<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_ArithAbort));

        /// <summary>
        /// SET ARITHIGNORE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-arithignore-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ARITHIGNORE")]
        public static Clause<Non> Set_ArithIgnore(bool isOn) => throw new InvalitContextException(nameof(Set_ArithIgnore));

        /// <summary>.
        /// SET ARITHIGNORE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-arithignore-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET ARITHIGNORE")]
        public static Clause<T> Set_ArithIgnore<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_ArithIgnore));

        /// <summary>
        /// SET CONCAT_NULL_YIELDS_NULL.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-concat-null-yields-null-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET CONCAT_NULL_YIELDS_NULL")]
        public static Clause<Non> Set_Concat_Null_Yields_Null(bool isOn) => throw new InvalitContextException(nameof(Set_Concat_Null_Yields_Null));

        /// <summary>
        /// SET CONCAT_NULL_YIELDS_NULL.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-concat-null-yields-null-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET CONCAT_NULL_YIELDS_NULL")]
        public static Clause<T> Set_Concat_Null_Yields_Null<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Concat_Null_Yields_Null));

        /// <summary>
        /// SET CONTEXT_INFO.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-context-info-transact-sql
        /// </summary>
        /// <param name="bin">binary_str or binary_var.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET CONTEXT_INFO")]
        public static Clause<Non> Set_Context_Info(object bin) => throw new InvalitContextException(nameof(Set_Context_Info));

        /// <summary>
        /// SET CONTEXT_INFO.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-context-info-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="bin">binary_str or binary_var.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET CONTEXT_INFO")]
        public static Clause<T> Set_Context_Info<T>(this Clause<T> before, object bin) => throw new InvalitContextException(nameof(Set_Context_Info));

        /// <summary>
        /// SET CURSOR_CLOSE_ON_COMMIT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-cursor-close-on-commit-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET CURSOR_CLOSE_ON_COMMIT")]
        public static Clause<Non> Set_Cursor_Close_On_Commit(bool isOn) => throw new InvalitContextException(nameof(Set_Cursor_Close_On_Commit));

        /// <summary>
        /// SET CURSOR_CLOSE_ON_COMMIT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-cursor-close-on-commit-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET CURSOR_CLOSE_ON_COMMIT")]
        public static Clause<T> Set_Cursor_Close_On_Commit<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Cursor_Close_On_Commit));

        /// <summary>
        /// SET DATEFIRST.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-datefirst-transact-sql
        /// </summary>
        /// <param name="number">number.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET DATEFIRST")]
        public static Clause<Non> Set_DateFirst(int number) => throw new InvalitContextException(nameof(Set_DateFirst));

        /// <summary>
        /// SET DATEFIRST.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-datefirst-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="number">number.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET DATEFIRST")]
        public static Clause<T> Set_DateFirst<T>(this Clause<T> before, int number) => throw new InvalitContextException(nameof(Set_DateFirst));

        /// <summary>
        /// SET DATEFORMAT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-dateformat-transact-sql
        /// </summary>
        /// <param name="format">format.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET DATEFORMAT [!0]")]
        public static Clause<Non> Set_DateFormat(string format) => throw new InvalitContextException(nameof(Set_DateFormat));

        /// <summary>
        /// SET DATEFORMAT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-dateformat-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="format">format.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET DATEFORMAT [!1]")]
        public static Clause<T> Set_DateFormat<T>(this Clause<T> before, string format) => throw new InvalitContextException(nameof(Set_DateFormat));

        /// <summary>
        /// SET DEADLOCK_PRIORITY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-deadlock-priority-transact-sql
        /// </summary>
        /// <param name="priority">priority.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET DEADLOCK_PRIORITY")]
        public static Clause<Non> Set_DeadLock_Priority(object priority) => throw new InvalitContextException(nameof(Set_DeadLock_Priority));

        /// <summary>
        /// SET DEADLOCK_PRIORITY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-deadlock-priority-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="priority">priority.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET DEADLOCK_PRIORITY")]
        public static Clause<T> Set_DeadLock_Priority<T>(this Clause<T> before, object priority) => throw new InvalitContextException(nameof(Set_DeadLock_Priority));

        /// <summary>
        /// SET FIPS_FLAGGER.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-fips-flagger-transact-sql
        /// </summary>
        /// <param name="level">level.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET FIPS_FLAGGER")]
        public static Clause<Non> Set_Fips_Flagger(string level) => throw new InvalitContextException(nameof(Set_Fips_Flagger));

        /// <summary>
        /// SET FIPS_FLAGGER.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-fips-flagger-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="level">level.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET FIPS_FLAGGER")]
        public static Clause<T> Set_Fips_Flagger<T>(this Clause<T> before, string level) => throw new InvalitContextException(nameof(Set_Fips_Flagger));

        /// <summary>
        /// SET FIPS_FLAGGER OFF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-fips-flagger-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET FIPS_FLAGGER OFF")]
        public static Clause<Non> Set_Fips_Flagger_Off() => throw new InvalitContextException(nameof(Set_Fips_Flagger_Off));

        /// <summary>
        /// SET FIPS_FLAGGER.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-fips-flagger-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET FIPS_FLAGGER OFF")]
        public static Clause<T> Set_Fips_Flagger_Off<T>(this Clause<T> before) => throw new InvalitContextException(nameof(Set_Fips_Flagger_Off));

        /// <summary>
        /// SET FMTONLY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-fmtonly-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET FMTONLY")]
        public static Clause<Non> Set_Fmtonly(bool isOn) => throw new InvalitContextException(nameof(Set_Fmtonly));

        /// <summary>
        /// SET FMTONLY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-fmtonly-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET FMTONLY")]
        public static Clause<T> Set_Fmtonly<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Fmtonly));

        /// <summary>
        /// SET FORCEPLAN.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-forceplan-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET FORCEPLAN")]
        public static Clause<Non> Set_ForcePlan(bool isOn) => throw new InvalitContextException(nameof(Set_ForcePlan));

        /// <summary>
        /// SET FORCEPLAN.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-forceplan-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET FORCEPLAN")]
        public static Clause<T> Set_ForcePlan<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_ForcePlan));

        /// <summary>
        /// SET IDENTITY_INSERT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-identity-insert-transact-sql
        /// </summary>
        /// <param name="SET IDENTITY_INSERT">.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "")]
        public static Clause<Non> Set_Identity_Insert(object bin) => throw new InvalitContextException(nameof(Set_Identity_Insert));

        /// <summary>
        /// SET IDENTITY_INSERT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-identity-insert-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="SET IDENTITY_INSERT">.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "")]
        public static Clause<T> Set_Identity_Insert<T>(this Clause<T> before, object bin) => throw new InvalitContextException(nameof(Set_Identity_Insert));

        /// <summary>
        /// SET IMPLICIT_TRANSACTIONS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-implicit-transactions-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET IMPLICIT_TRANSACTIONS")]
        public static Clause<Non> Set_Implicit_Transactions(bool isOn) => throw new InvalitContextException(nameof(Set_Implicit_Transactions));

        /// <summary>
        /// SET IMPLICIT_TRANSACTIONS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-implicit-transactions-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET IMPLICIT_TRANSACTIONS")]
        public static Clause<T> Set_Implicit_Transactions<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Implicit_Transactions));

        /// <summary>
        /// SET LANGUAGE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-language-transact-sql
        /// </summary>
        /// <param name="language">language.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET LANGUAGE")]
        public static Clause<Non> Set_Language(string language) => throw new InvalitContextException(nameof(Set_Language));

        /// <summary>
        /// SET LANGUAGE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-language-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="language">language.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET LANGUAGE")]
        public static Clause<T> Set_Language<T>(this Clause<T> before, string language) => throw new InvalitContextException(nameof(Set_Language));

        /// <summary>
        /// SET LOCK_TIMEOUT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-lock-timeout-transact-sql
        /// </summary>
        /// <param name="timeout_period">timeout_period.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET LOCK_TIMEOUT")]
        public static Clause<Non> Set_Lock_Timeout(int timeout_period) => throw new InvalitContextException(nameof(Set_Lock_Timeout));

        /// <summary>
        /// SET LOCK_TIMEOUT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-lock-timeout-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="timeout_period">timeout_period.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET LOCK_TIMEOUT")]
        public static Clause<T> Set_Lock_Timeout<T>(this Clause<T> before, int timeout_period) => throw new InvalitContextException(nameof(Set_Lock_Timeout));

        /// <summary>
        /// SET NOCOUNT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-nocount-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET NOCOUNT")]
        public static Clause<Non> Set_NoCount(bool isOn) => throw new InvalitContextException(nameof(Set_NoCount));

        /// <summary>
        /// SET NOCOUNT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-nocount-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET NOCOUNT")]
        public static Clause<T> Set_NoCount<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_NoCount));

        /// <summary>
        /// SET NOEXEC.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-noexec-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET NOEXEC")]
        public static Clause<Non> SetNoExec(bool isOn) => throw new InvalitContextException(nameof(SetNoExec));

        /// <summary>
        /// SET NOEXEC.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-noexec-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET NOEXEC")]
        public static Clause<T> SetNoExec<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(SetNoExec));

        /// <summary>
        /// SET NUMERIC_ROUNDABORT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-numeric-roundabort-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET NUMERIC_ROUNDABORT")]
        public static Clause<Non> Set_Numeric_RoundAbort(bool isOn) => throw new InvalitContextException(nameof(Set_Numeric_RoundAbort));

        /// <summary>
        /// SET NUMERIC_ROUNDABORT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-numeric-roundabort-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET NUMERIC_ROUNDABORT")]
        public static Clause<T> Set_Numeric_RoundAbort<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Numeric_RoundAbort));

        /// <summary>
        /// SET OFFSETS keyword_list ON.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-offsets-transact-sql
        /// </summary>
        /// <param name="keyword_list">keyword_list.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET OFFSETS [!<, >0] ON")]
        public static Clause<Non> Set_Offsets_On(params string[] keyword_list) => throw new InvalitContextException(nameof(Set_Offsets_On));

        /// <summary>
        /// SET OFFSETS keyword_list ON.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-offsets-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="keyword_list">keyword_list.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET OFFSETS [!<, >1] ON")]
        public static Clause<T> Set_Offsets_On<T>(this Clause<T> before, params string[] keyword_list) => throw new InvalitContextException(nameof(Set_Offsets_On));

        /// <summary>
        /// SET OFFSETS keyword_list OFF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-offsets-transact-sql
        /// </summary>
        /// <param name="keyword_list">keyword_list.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET OFFSETS [!<, >0] OFF")]
        public static Clause<Non> Set_Offsets_Off(params string[] keyword_list) => throw new InvalitContextException(nameof(Set_Offsets_Off));

        /// <summary>
        /// SET OFFSETS keyword_list OFF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-offsets-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="keyword_list">keyword_list.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET OFFSETS [!<, >1] OFF")]
        public static Clause<T> Set_Offsets_Off<T>(this Clause<T> before, params string[] keyword_list) => throw new InvalitContextException(nameof(Set_Offsets_Off));

        /// <summary>
        /// SET PARSEONLY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-parseonly-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET PARSEONLY")]
        public static Clause<Non> SetParseOnly(bool isOn) => throw new InvalitContextException(nameof(SetParseOnly));

        /// <summary>
        /// SET PARSEONLY.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-parseonly-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET PARSEONLY")]
        public static Clause<T> SetParseOnly<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(SetParseOnly));

        /// <summary>
        /// SET QUERY_GOVERNOR_COST_LIMIT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-query-governor-cost-limit-transact-sql
        /// </summary>
        /// <param name="value">value.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET QUERY_GOVERNOR_COST_LIMIT")]
        public static Clause<Non> Set_Query_Governor_Cost_Limit(int value) => throw new InvalitContextException(nameof(Set_Query_Governor_Cost_Limit));

        /// <summary>
        /// SET QUERY_GOVERNOR_COST_LIMIT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-query-governor-cost-limit-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="value">value.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET QUERY_GOVERNOR_COST_LIMIT")]
        public static Clause<T> Set_Query_Governor_Cost_Limit<T>(this Clause<T> before, int value) => throw new InvalitContextException(nameof(Set_Query_Governor_Cost_Limit));

        /// <summary>
        /// SET QUOTED_IDENTIFIER.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-quoted-identifier-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET QUOTED_IDENTIFIER")]
        public static Clause<Non> Set_Quoted_Identifier(bool isOn) => throw new InvalitContextException(nameof(Set_Quoted_Identifier));

        /// <summary>
        /// SET QUOTED_IDENTIFIER.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-quoted-identifier-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET QUOTED_IDENTIFIER")]
        public static Clause<T> Set_Quoted_Identifier<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Quoted_Identifier));

        /// <summary>
        /// SET REMOTE_PROC_TRANSACTIONS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-remote-proc-transactions-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET REMOTE_PROC_TRANSACTIONS")]
        public static Clause<Non> Set_Remote_Proc_Transactions(bool isOn) => throw new InvalitContextException(nameof(Set_Remote_Proc_Transactions));

        /// <summary>
        /// SET REMOTE_PROC_TRANSACTIONS.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-remote-proc-transactions-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET REMOTE_PROC_TRANSACTIONS")]
        public static Clause<T> Set_Remote_Proc_Transactions<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Remote_Proc_Transactions));

        /// <summary>
        /// SET ROWCOUNT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-rowcount-transact-sql
        /// </summary>
        /// <param name="count">count.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET ROWCOUNT")]
        public static Clause<Non> Set_RowCount(int count) => throw new InvalitContextException(nameof(Set_RowCount));

        /// <summary>
        /// SET ROWCOUNT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-rowcount-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="count">count.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET ROWCOUNT")]
        public static Clause<T> Set_RowCount<T>(this Clause<T> before, int count) => throw new InvalitContextException(nameof(Set_RowCount));

        /// <summary>
        /// SET SHOWPLAN_ALL.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-showplan-all-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET SHOWPLAN_ALL")]
        public static Clause<Non> Set_ShowPlan_All(bool isOn) => throw new InvalitContextException(nameof(Set_ShowPlan_All));

        /// <summary>
        /// SET SHOWPLAN_ALL.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-showplan-all-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET SHOWPLAN_ALL")]
        public static Clause<T> Set_ShowPlan_All<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_ShowPlan_All));

        /// <summary>
        /// SET SHOWPLAN_TEXT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-showplan-text-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET SHOWPLAN_TEXT")]
        public static Clause<Non> Set_ShowPlan_Text(bool isOn) => throw new InvalitContextException(nameof(Set_ShowPlan_Text));

        /// <summary>
        /// SET SHOWPLAN_TEXT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-showplan-text-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET SHOWPLAN_TEXT")]
        public static Clause<T> Set_ShowPlan_Text<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_ShowPlan_Text));

        /// <summary>
        /// SET SHOWPLAN_XML.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-showplan-xml-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET SHOWPLAN_XML")]
        public static Clause<Non> Set_ShowPlan_Xml(bool isOn) => throw new InvalitContextException(nameof(Set_ShowPlan_Xml));

        /// <summary>
        /// SET SHOWPLAN_XML.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-showplan-xml-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET SHOWPLAN_XML")]
        public static Clause<T> Set_ShowPlan_Xml<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_ShowPlan_Xml));

        /// <summary>
        /// SET STATISTICS IO.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-statistics-io-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET STATISTICS IO")]
        public static Clause<Non> Set_Statistics_IO(bool isOn) => throw new InvalitContextException(nameof(Set_Statistics_IO));

        /// <summary>
        /// SET STATISTICS IO.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-statistics-io-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET STATISTICS IO")]
        public static Clause<T> Set_Statistics_IO<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Statistics_IO));

        /// <summary>
        /// SET STATISTICS PROFILE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-statistics-profile-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET STATISTICS PROFILE")]
        public static Clause<Non> Set_Statistics_Profile(bool isOn) => throw new InvalitContextException(nameof(Set_Statistics_Profile));

        /// <summary>
        /// SET STATISTICS PROFILE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-statistics-profile-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET STATISTICS PROFILE")]
        public static Clause<T> Set_Statistics_Profile<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Statistics_Profile));

        /// <summary>
        /// SET STATISTICS TIME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-statistics-time-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET STATISTICS TIME")]
        public static Clause<Non> Set_Statistics_Time(bool isOn) => throw new InvalitContextException(nameof(Set_Statistics_Time));

        /// <summary>
        /// SET STATISTICS TIME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-statistics-time-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET STATISTICS TIME")]
        public static Clause<T> Set_Statistics_Time<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Statistics_Time));

        /// <summary>
        /// SET STATISTICS XML.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-statistics-xml-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET STATISTICS XML")]
        public static Clause<Non> Set_Statistics_Xml(bool isOn) => throw new InvalitContextException(nameof(Set_Statistics_Xml));

        /// <summary>
        /// SET STATISTICS XML.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-statistics-xml-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET STATISTICS XML")]
        public static Clause<T> Set_Statistics_Xml<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Statistics_Xml));

        /// <summary>
        /// SET TEXTSIZE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-textsize-transact-sql
        /// </summary>
        /// <param name="size">size.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET TEXTSIZE")]
        public static Clause<Non> Set_TextSize(int size) => throw new InvalitContextException(nameof(Set_TextSize));

        /// <summary>
        /// SET TEXTSIZE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-textsize-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="size">size.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SET TEXTSIZE")]
        public static Clause<T> Set_TextSize<T>(this Clause<T> before, int size) => throw new InvalitContextException(nameof(Set_TextSize));

        /// <summary>
        /// SET TRANSACTION ISOLATION LEVEL.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-transaction-isolation-level-transact-sql
        /// </summary>
        /// <param name="level">level.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET TRANSACTION ISOLATION LEVEL [!0]")]
        public static Clause<Non> Set_Transaction_ISolation_Level(string level) => throw new InvalitContextException(nameof(Set_Transaction_ISolation_Level));

        /// <summary>
        /// SET TRANSACTION ISOLATION LEVEL.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-transaction-isolation-level-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="level">level.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET TRANSACTION ISOLATION LEVEL [!1]")]
        public static Clause<T> Set_Transaction_ISolation_Level<T>(this Clause<T> before, string level) => throw new InvalitContextException(nameof(Set_Transaction_ISolation_Level));

        /// <summary>
        /// SET XACT_ABORT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-xact-abort-transact-sql
        /// </summary>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET XACT_ABORT")]
        public static Clause<Non> Set_Xact_Abort(bool isOn) => throw new InvalitContextException(nameof(Set_Xact_Abort));

        /// <summary>
        /// SET XACT_ABORT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/set-xact-abort-transact-sql
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="isOn">is on.</param>
        /// <returns>Clause.</returns>
        [SetOnOffClause(Name = "SET XACT_ABORT")]
        public static Clause<T> Set_Xact_Abort<T>(this Clause<T> before, bool isOn) => throw new InvalitContextException(nameof(Set_Xact_Abort));
    }
}
