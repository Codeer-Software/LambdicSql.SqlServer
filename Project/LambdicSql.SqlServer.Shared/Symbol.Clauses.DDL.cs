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

        /// <summary>
        /// DROP DATABASE clause.
        /// </summary>
        /// <param name="name">DataBase name.</param>
        /// <returns>Clause chain. You can write SQL statements in succession, of course you can end it.</returns>
        [MethodFormatConverter(Format = "CREATE DATABASE [!0]")]
        public static Clause<Non> CreateDataBase(string name) { throw new InvalitContextException(nameof(CreateDataBase)); }

        /// <summary>
        /// DROP DATABASE clause.
        /// </summary>
        /// <param name="name">DataBase name.</param>
        /// <returns>Clause chain. You can write SQL statements in succession, of course you can end it.</returns>
        [MethodFormatConverter(Format = "DROP DATABASE [!0]")]
        public static Clause<Non> DropDataBase(string name) { throw new InvalitContextException(nameof(DropDataBase)); }

        /*
         https://msdn.microsoft.com/en-us/library/ff848799.aspx
        ALTER Statements
        BACKUP DATABASE (Parallel Data Warehouse)
        CREATE Statements
        DISABLE TRIGGER
        DROP Statements
        ENABLE TRIGGER
        RENAME
        RESTORE DATABASE (Parallel Data Warehouse)
        TRUNCATE TABLE
        UPDATE STATISTICS*/
    }
}
