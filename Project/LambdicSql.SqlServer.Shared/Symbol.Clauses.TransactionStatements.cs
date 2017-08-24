using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.SqlServer.ConverterAttributes;

namespace LambdicSql.SqlServer
{
    //@@@
    /// <summary>
    /// SQL Symbol.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// Use[using static LambdicSql.SqlServer.Symbol;], you can use to write natural SQL.
    /// </summary>
    public static partial class Symbol
    {
        /// <summary>
        /// BEGIN TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-transaction-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN TRANSACTION")]
        public static Clause<Non> BeginTransaction() => throw new InvalitContextException(nameof(BeginTransaction));

        /// <summary>
        /// BEGIN TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN TRANSACTION")]
        public static Clause<T> BeginTransaction<T>(this Clause<T> before) => throw new InvalitContextException(nameof(BeginTransaction));

        /// <summary>
        /// BEGIN TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-transaction-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN TRANSACTION")]
        public static Clause<Non> BeginTransaction(string name) => throw new InvalitContextException(nameof(BeginTransaction));

        /// <summary>
        /// BEGIN TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN TRANSACTION")]
        public static Clause<T> BeginTransaction<T>(this Clause<T> before, string name) => throw new InvalitContextException(nameof(BeginTransaction));

        /// <summary>
        /// BEGIN DISTRIBUTED TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-distributed-transaction-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN DISTRIBUTED TRANSACTION")]
        public static Clause<Non> BeginDistributedTransaction() => throw new InvalitContextException(nameof(BeginDistributedTransaction));

        /// <summary>
        /// BEGIN DISTRIBUTED TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-distributed-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN DISTRIBUTED TRANSACTION")]
        public static Clause<T> BeginDistributedTransaction<T>(this Clause<T> before) => throw new InvalitContextException(nameof(BeginDistributedTransaction));

        /// <summary>
        /// BEGIN DISTRIBUTED TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-distributed-transaction-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN DISTRIBUTED TRANSACTION")]
        public static Clause<Non> BeginDistributedTransaction(string name) => throw new InvalitContextException(nameof(BeginDistributedTransaction));

        /// <summary>
        /// BEGIN DISTRIBUTED TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-distributed-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BEGIN DISTRIBUTED TRANSACTION")]
        public static Clause<T> BeginDistributedTransaction<T>(this Clause<T> before, string name) => throw new InvalitContextException(nameof(BeginDistributedTransaction));

        /// <summary>
        /// COMMIT TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-transaction-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "COMMIT TRANSACTION")]
        public static Clause<Non> CommitTransaction() => throw new InvalitContextException(nameof(CommitTransaction));

        /// <summary>
        /// COMMIT TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "COMMIT TRANSACTION")]
        public static Clause<T> CommitTransaction<T>(this Clause<T> before) => throw new InvalitContextException(nameof(CommitTransaction));

        /// <summary>
        /// COMMIT TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-transaction-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "COMMIT TRANSACTION")]
        public static Clause<Non> CommitTransaction(string name) => throw new InvalitContextException(nameof(CommitTransaction));

        /// <summary>
        /// COMMIT TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "COMMIT TRANSACTION")]
        public static Clause<T> CommitTransaction<T>(this Clause<T> before, string name) => throw new InvalitContextException(nameof(CommitTransaction));

        /// <summary>
        /// WITH MARK.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-transaction-transact-sql
        /// </summary>
        /// <param name="description">description.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "WITH MARK [$0]")]
        public static Clause<Non> WithMark(string description) => throw new InvalitContextException(nameof(WithMark));

        /// <summary>
        /// WITH MARK.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/begin-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="description">description.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "WITH MARK [$1]")]
        public static Clause<T> WithMark<T>(this Clause<T> before, string description) => throw new InvalitContextException(nameof(WithMark));

        /// <summary>
        /// DELAYED_DURABILITY
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-transaction-transact-sql
        /// </summary>
        /// <param name="isOn"></param>
        /// <returns>IDelayedDurability.</returns>
        [OnOffClause(Name = "DELAYED_DURABILITY =")]
        public static IDelayedDurability Delayed_Durability_Assign(bool isOn) => throw new InvalitContextException(nameof(Delayed_Durability_Assign));

        /// <summary>
        /// WITH.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-transaction-transact-sql
        /// </summary>
        /// <param name="delayedDurability">delayed durability</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> With(IDelayedDurability delayedDurability) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// WITH.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="delayedDurability">delayed durability</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> With<T>(this Clause<T> before, IDelayedDurability delayedDurability) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// COMMIT WORK.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-work-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "COMMIT WORK")]
        public static Clause<Non> CommitWork() => throw new InvalitContextException(nameof(CommitWork));

        /// <summary>
        /// COMMIT WORK.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/commit-work-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "COMMIT WORK")]
        public static Clause<T> CommitWork<T>(this Clause<T> before) => throw new InvalitContextException(nameof(CommitWork));

        /// <summary>
        /// ROLLBACK WORK.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/rollback-work-transact-sql
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "ROLLBACK WORK")]
        public static Clause<Non> RollbackWork() => throw new InvalitContextException(nameof(RollbackWork));

        /// <summary>
        /// ROLLBACK WORK.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/rollback-work-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "ROLLBACK WORK")]
        public static Clause<T> RollbackWork<T>(this Clause<T> before) => throw new InvalitContextException(nameof(RollbackWork));

        /// <summary>
        /// ROLLBACK TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/rollback-transaction-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "ROLLBACK TRANSACTION")]
        public static Clause<Non> RollbackTransaction(string name) => throw new InvalitContextException(nameof(RollbackTransaction));

        /// <summary>
        /// ROLLBACK TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/rollback-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "ROLLBACK TRANSACTION")]
        public static Clause<T> RollbackTransaction<T>(this Clause<T> before, string name) => throw new InvalitContextException(nameof(RollbackTransaction));

        /// <summary>
        /// SAVE TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/save-transaction-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SAVE TRANSACTION")]
        public static Clause<Non> SaveTransaction(string name) => throw new InvalitContextException(nameof(SaveTransaction));

        /// <summary>
        /// SAVE TRANSACTION.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/save-transaction-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">name.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "SAVE TRANSACTION")]
        public static Clause<T> SaveTransaction<T>(this Clause<T> before, string name) => throw new InvalitContextException(nameof(SaveTransaction));
    }
}
