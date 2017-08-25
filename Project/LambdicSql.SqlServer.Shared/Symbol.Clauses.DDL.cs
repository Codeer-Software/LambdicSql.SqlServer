using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.Specialized.SymbolConverters;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Symbol.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// Use[using static LambdicSql.SqlServer.Symbol;], you can use to write natural SQL.
    /// </summary>
    public static partial class Symbol
    {
        /// <summary>
        /// CREATE TABLE clause.
        /// </summary>
        /// <param name="table">table names.</param>
        /// <param name="designer">table design info.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CREATE TABLE [0](|[#$<,>1])", FormatDirection = FormatDirection.Vertical)]
        public static Clause<Non> CreateTable(object table, params TableDefinitionElement[] designer) { throw new InvalitContextException(nameof(CreateTable)); }

        /// <summary>
        /// CREATE TABLE clause.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">table names.</param>
        /// <param name="designer">table design info.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CREATE TABLE [1](|[#$<,>2])", FormatDirection = FormatDirection.Vertical)]
        public static Clause<T> CreateTable<T>(this Clause<T> before, object table, params TableDefinitionElement[] designer) { throw new InvalitContextException(nameof(CreateTable)); }

        /// <summary>
        /// CONSTRAINT clause.
        /// </summary>
        /// <param name="name">Constraint name.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CONSTRAINT [!0]")]
        public static Clause<ConstraintElement> Constraint(string name) { throw new InvalitContextException(nameof(Constraint)); }

        /// <summary>
        /// PRIMARY KEY clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "PRIMARY KEY")]
        public static Clause<ConstraintElement> PrimaryKey() { throw new InvalitContextException(nameof(PrimaryKey)); }

        /// <summary>
        /// PRIMARY KEY clause.
        /// </summary>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "PRIMARY KEY")]
        public static Clause<ConstraintElement> PrimaryKey(params object[] columns) { throw new InvalitContextException(nameof(PrimaryKey)); }

        /// <summary>
        /// PRIMARY KEY clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "PRIMARY KEY", Indent = 1)]
        public static Clause<ConstraintElement> PrimaryKey(this Clause<ConstraintElement> before, params object[] columns) { throw new InvalitContextException(nameof(PrimaryKey)); }

        /// <summary>
        /// CHECK clause.
        /// </summary>
        /// <param name="condition">Condition.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<ConstraintElement> Check(bool condition) { throw new InvalitContextException(nameof(Check)); }

        /// <summary>
        /// CHECK clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">Condition.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<ConstraintElement> Check(this Clause<ConstraintElement> before, bool condition) { throw new InvalitContextException(nameof(Check)); }

        /// <summary>
        /// UNIQUE clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<ConstraintElement> Unique() { throw new InvalitContextException(nameof(Unique)); }

        /// <summary>
        /// UNIQUE clause.
        /// </summary>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<ConstraintElement> Unique(params object[] columns) { throw new InvalitContextException(nameof(Unique)); }

        /// <summary>
        /// UNIQUE clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<ConstraintElement> Unique(this Clause<ConstraintElement> before, params object[] columns) { throw new InvalitContextException(nameof(Unique)); }

        /// <summary>
        /// FOREIGN KEY clause.
        /// </summary>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "FOREIGN KEY")]
        public static Clause<ConstraintElement> ForeignKey(params object[] columns) { throw new InvalitContextException(nameof(ForeignKey)); }

        /// <summary>
        /// FOREIGN KEY clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "FOREIGN KEY", Indent = 1)]
        public static Clause<ConstraintElement> ForeignKey(this Clause<ConstraintElement> before, params object[] columns) { throw new InvalitContextException(nameof(ForeignKey)); }

        /// <summary>
        /// NOT NULL
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "NOT NULL")]
        public static Clause<ConstraintElement> NotNull() { throw new InvalitContextException(nameof(NotNull)); }

        /// <summary>
        /// DEFAULT
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<ConstraintElement> Default(object value) { throw new InvalitContextException(nameof(Default)); }

        /// <summary>
        /// REFERENCES clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "REFERENCES [1](|[<, >2])", Indent = 1)]
        public static Clause<ConstraintElement> References(this Clause<ConstraintElement> before, object table, params object[] columns) { throw new InvalitContextException(nameof(References)); }

        /// <summary>
        /// DROP TABLE clause.
        /// </summary>
        /// <param name="tables">Tables.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "DROP TABLE")]
        public static Clause<Non> DropTable(params object[] tables) { throw new InvalitContextException(nameof(DropTable)); }

        //@@@
        /// <summary>
        /// DROP TABLE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="tables">Tables.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "DROP TABLE")]
        public static Clause<T> DropTable<T>(this Clause<T> before, params object[] tables) { throw new InvalitContextException(nameof(DropTable)); }

        /// <summary>
        /// DROP DATABASE clause.
        /// </summary>
        /// <param name="name">DataBase name.</param>
        /// <returns>Clause chain. You can write SQL statements in succession, of course you can end it.</returns>
        [MethodFormatConverter(Format = "CREATE DATABASE [!0]")]
        public static Clause<Non> CreateDataBase(string name) { throw new InvalitContextException(nameof(CreateDataBase)); }

        //@@@
        /// <summary>
        /// DROP DATABASE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">DataBase name.</param>
        /// <returns>Clause chain. You can write SQL statements in succession, of course you can end it.</returns>
        [MethodFormatConverter(Format = "CREATE DATABASE [!0]")]
        public static Clause<T> CreateDataBase<T>(this Clause<T> before, string name) { throw new InvalitContextException(nameof(CreateDataBase)); }

        /// <summary>
        /// DROP DATABASE clause.
        /// </summary>
        /// <param name="name">DataBase name.</param>
        /// <returns>Clause chain. You can write SQL statements in succession, of course you can end it.</returns>
        [MethodFormatConverter(Format = "DROP DATABASE [!0]")]
        public static Clause<Non> DropDataBase(string name) { throw new InvalitContextException(nameof(DropDataBase)); }

        //@@@
        /// <summary>
        /// DROP DATABASE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">DataBase name.</param>
        /// <returns>Clause chain. You can write SQL statements in succession, of course you can end it.</returns>
        [MethodFormatConverter(Format = "DROP DATABASE [!0]")]
        public static Clause<T> DropDataBase<T>(this Clause<T> before, string name) { throw new InvalitContextException(nameof(DropDataBase)); }

        /// <summary>
        /// IDENTITY
        /// </summary>
        /// <param name="seed">Seed.</param>
        /// <param name="increment">Increment.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<ConstraintElement> Identity(int seed, int increment) => null;

        /// <summary>
        /// INDEX
        /// </summary>
        /// <param name="name">Index name.</param>
        /// <param name="column">Column.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "INDEX [!0]([1])")]
        public static Clause<ConstraintElement> Index(string name, object column) => null;


        /*
         https://msdn.microsoft.com/en-us/library/ff848799.aspx
        >ALTER Statements
            AlterApplicationWith()
        >CREATE Statements
        >DROP Statements
        RENAME
        UPDATE STATISTICS

        ★TRUNCATE TABLE
        https://docs.microsoft.com/en-us/sql/t-sql/statements/truncate-table-transact-sql

        */




        /// <summary>
        /// CREATE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CREATE TRIGGER [!0] ON [1]")]
        public static Clause<Non> CreateTreggerOn(string name, object table) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// CREATE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">name.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CREATE TRIGGER [!1] ON [2]")]
        public static Clause<T> CreateTreggerOn<T>(Clause<T> before, string name, object table) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// CREATE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="target">target.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CREATE TRIGGER [!0] ON [1]")]
        public static Clause<Non> CreateTreggerOn(string name, TriggerTarget target) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// CREATE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">name.</param>
        /// <param name="target">target.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CREATE TRIGGER [!1] ON [2]")]
        public static Clause<T> CreateTreggerOn<T>(Clause<T> before, string name, TriggerTarget target) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// WITH
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <param name="option">option.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> With(params DDLTriggerOption[] option) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// WITH
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="option">option.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> With<T>(Clause<T> before, params DDLTriggerOption[] option) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// ENCRYPTION
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <returns>IDDLTriggerOption</returns>
        [ClauseStyleConverter]
        public static DDLTriggerOption Encryption() => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// EXECUTE AS CLAUSE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <returns>IDDLTriggerOption</returns>
        [ClauseStyleConverter(Name = "EXECUTE AS CLAUSE")]
        public static DDLTriggerOption ExecuteAsClause() => throw new InvalitContextException(nameof(ExecuteAsClause));

        /// <summary>
        /// DATABASE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <returns>IDDLTriggerOption</returns>
        [ClauseStyleConverter]
        public static TriggerTarget DataBase() => throw new InvalitContextException(nameof(ExecuteAsClause));

        /// <summary>
        /// ALL SERVER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <returns>IDDLTriggerOption</returns>
        [ClauseStyleConverter(Name = "ALL SERVER")]
        public static TriggerTarget AllServer() => throw new InvalitContextException(nameof(ExecuteAsClause));

        //TODO  WITH APPEND, NOT FOR REPLICATION
        /// <summary>
        /// FOR eventNames AS
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <param name="eventNames">eventNames.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "FOR [!<, >0] AS")]
        public static Clause<Non> ForAs(params string[] eventNames) => throw new InvalitContextException(nameof(ForAs));

        /// <summary>
        /// FOR eventNames AS
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="eventNames">eventNames.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "FOR [!<, >1] AS")]
        public static Clause<T> ForAs<T>(Clause<T> before, params string[] eventNames) => throw new InvalitContextException(nameof(ForAs));

        /// <summary>
        /// AFTER eventNames AS
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <param name="eventNames">eventNames.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "AFTER [!<, >0] AS")]
        public static Clause<Non> AfterAs(params string[] eventNames) => throw new InvalitContextException(nameof(AfterAs));

        /// <summary>
        /// AFTER eventNames AS
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="eventNames">eventNames.</param>
        /// <returns>Clause.</returns>
        public static Clause<T> AfterAs<T>(Clause<T> before, params string[] eventNames) => throw new InvalitContextException(nameof(AfterAs));
    }
}
