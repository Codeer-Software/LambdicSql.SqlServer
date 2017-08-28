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
        public static Clause<Non> CreateTable(object table, params TableDefinitionBase[] designer) { throw new InvalitContextException(nameof(CreateTable)); }

        /// <summary>
        /// CREATE TABLE clause.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">table names.</param>
        /// <param name="designer">table design info.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CREATE TABLE [1](|[#$<,>2])", FormatDirection = FormatDirection.Vertical)]
        public static Clause<T> CreateTable<T>(this Clause<T> before, object table, params TableDefinitionBase[] designer) { throw new InvalitContextException(nameof(CreateTable)); }

        /// <summary>
        /// CONSTRAINT clause.
        /// </summary>
        /// <param name="name">Constraint name.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CONSTRAINT [!0]")]
        public static Clause<ConstraintBase> Constraint(string name) { throw new InvalitContextException(nameof(Constraint)); }

        /// <summary>
        /// PRIMARY KEY clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "PRIMARY KEY")]
        public static Clause<ConstraintBase> PrimaryKey() { throw new InvalitContextException(nameof(PrimaryKey)); }

        /// <summary>
        /// PRIMARY KEY clause.
        /// </summary>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "PRIMARY KEY")]
        public static Clause<ConstraintBase> PrimaryKey(params object[] columns) { throw new InvalitContextException(nameof(PrimaryKey)); }

        /// <summary>
        /// PRIMARY KEY clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "PRIMARY KEY", Indent = 1)]
        public static Clause<ConstraintBase> PrimaryKey<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(PrimaryKey)); }

        /// <summary>
        /// CHECK clause.
        /// </summary>
        /// <param name="condition">Condition.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<ConstraintBase> Check(bool condition) { throw new InvalitContextException(nameof(Check)); }

        /// <summary>
        /// CHECK clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">Condition.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<ConstraintBase> Check<T>(this Clause<T> before, bool condition) { throw new InvalitContextException(nameof(Check)); }

        /// <summary>
        /// UNIQUE clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<ConstraintBase> Unique() { throw new InvalitContextException(nameof(Unique)); }

        /// <summary>
        /// UNIQUE clause.
        /// </summary>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<ConstraintBase> Unique(params object[] columns) { throw new InvalitContextException(nameof(Unique)); }

        /// <summary>
        /// UNIQUE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<ConstraintBase> Unique<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(Unique)); }

        /// <summary>
        /// FOREIGN KEY clause.
        /// </summary>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "FOREIGN KEY")]
        public static Clause<ConstraintBase> ForeignKey(params object[] columns) { throw new InvalitContextException(nameof(ForeignKey)); }

        /// <summary>
        /// FOREIGN KEY clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "FOREIGN KEY", Indent = 1)]
        public static Clause<ConstraintBase> ForeignKey<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(ForeignKey)); }

        /// <summary>
        /// NOT NULL
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "NOT NULL")]
        public static Clause<ConstraintBase> NotNull() { throw new InvalitContextException(nameof(NotNull)); }

        /// <summary>
        /// DEFAULT
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<ConstraintBase> Default(object value) { throw new InvalitContextException(nameof(Default)); }

        /// <summary>
        /// REFERENCES clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "REFERENCES [1](|[<, >2])", Indent = 1)]
        public static Clause<ConstraintBase> References<T>(this Clause<T> before, object table, params object[] columns) { throw new InvalitContextException(nameof(References)); }

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
        public static Clause<ConstraintBase> Identity(int seed, int increment) => throw new InvalitContextException(nameof(Identity));

        /// <summary>
        /// IDENTITY
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="seed">Seed.</param>
        /// <param name="increment">Increment.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<ConstraintBase> Identity<T>(this Clause<T> before, int seed, int increment) => throw new InvalitContextException(nameof(Identity));

        /// <summary>
        /// INDEX
        /// </summary>
        /// <param name="name">Index name.</param>
        /// <param name="column">Column.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "INDEX [!0]([1])")]
        public static Clause<ConstraintBase> Index(string name, object column) => throw new InvalitContextException(nameof(Index));

        /// <summary>
        /// INDEX
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="name">Index name.</param>
        /// <param name="column">Column.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "INDEX [!0]([1])")]
        public static Clause<ConstraintBase> Index<T>(this Clause<T> before, string name, object column) => throw new InvalitContextException(nameof(Index));


        //@@@↓
        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-aggregate-transact-sql
        /// </summary>
        /// <param name="name"></param>
        /// <param name="aggregateArguments"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "CREATE AGGREGATE [!0]([<, >1])")]
        public static Clause<Non> CreateAggregate(string name, params AggregateArgument[] aggregateArguments) => throw new InvalitContextException(nameof(CreateAggregate));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-aggregate-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="name"></param>
        /// <param name="aggregateArguments"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "CREATE AGGREGATE [!1]([<, >2])")]
        public static Clause<Non> CreateAggregate<T>(this Clause<T> before, string name, params AggregateArgument[] aggregateArguments) => throw new InvalitContextException(nameof(CreateAggregate));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-aggregate-transact-sql
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> Returns(DataTypeBase type) => throw new InvalitContextException(nameof(Returns));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-aggregate-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> Returns<T>(this Clause<T> before, DataTypeBase type) => throw new InvalitContextException(nameof(Returns));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-aggregate-transact-sql
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "EXTERNAL NAME ![0]")]
        public static Clause<Non> ExternalName(string name) => throw new InvalitContextException(nameof(ExternalName));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-aggregate-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "EXTERNAL NAME ![1]")]
        public static Clause<Non> ExternalName<T>(this Clause<T> before, string name) => throw new InvalitContextException(nameof(ExternalName));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-application-role-transact-sql
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "CREATE APPLICATION ROLE ![0]")]
        public static Clause<Non> CreateApplicationRole(string name) => throw new InvalitContextException(nameof(CreateApplicationRole));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-application-role-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "CREATE APPLICATION ROLE ![1]")]
        public static Clause<Non> CreateApplicationRole<T>(this Clause<T> before, string name) => throw new InvalitContextException(nameof(CreateApplicationRole));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-application-role-transact-sql
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> With(params CreateApplicationRoleBase[] elements) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-application-role-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> With<T>(this Clause<T> before, params CreateApplicationRoleBase[] elements) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-application-role-transact-sql
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "PASSWORD $[0]")]
        public static CreateApplicationRoleBase Password_Assign(string password) => throw new InvalitContextException(nameof(Password_Assign));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-application-role-transact-sql
        /// </summary>
        /// <param name="schema_name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "DEFAULT_SCHEMA $[0]")]
        public static CreateApplicationRoleBase Default_Schema_Assign(string schema_name) => throw new InvalitContextException(nameof(Default_Schema_Assign));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "CREATE ASSEMBLY ![0]")]
        public static Clause<Non> CreateAssembly(string name) => throw new InvalitContextException(nameof(CreateAssembly));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "CREATE ASSEMBLY ![1]")]
        public static Clause<Non> CreateAssembly<T>(this Clause<T> before, string name) => throw new InvalitContextException(nameof(CreateAssembly));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "AUTHORIZATION ![0]")]
        public static Clause<Non> Authorization(string name) => throw new InvalitContextException(nameof(Authorization));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "AUTHORIZATION ![1]")]
        public static Clause<Non> Authorization<T>(this Clause<T> before, string name) => throw new InvalitContextException(nameof(Authorization));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "FROM ![0]")]
        public static Clause<Non> From(string from) => throw new InvalitContextException(nameof(From));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="from"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "FROM ![1]")]
        public static Clause<Non> From<T>(this Clause<T> before, string from) => throw new InvalitContextException(nameof(From));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> With(params CreateAssemblyBase[] elements) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> With<T>(this Clause<T> before, params CreateAssemblyBase[] elements) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-assembly-transact-sql
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "PERMISSION_SET = ")]
        public static CreateAssemblyBase PermissionSet_Assign(PermissionSetElement element) => throw new InvalitContextException(nameof(PermissionSet_Assign));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="ssym_Key_Name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "CREATE ASYMMETRIC KEY [!0]")]
        public static Clause<Non> CreateAsymmetricKey(string ssym_Key_Name) => throw new InvalitContextException(nameof(CreateAsymmetricKey));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="ssym_Key_Name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "CREATE ASYMMETRIC KEY [!1]")]
        public static Clause<Non> CreateAsymmetricKey<T>(this Clause<T> before, string ssym_Key_Name) => throw new InvalitContextException(nameof(CreateAsymmetricKey));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="database_principal_name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "AUTHORIZATION [!0]")]
        public static Clause<Non> Authoriazation(string database_principal_name) => throw new InvalitContextException(nameof(Authoriazation));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="database_principal_name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "AUTHORIZATION [!1]")]
        public static Clause<Non> Authoriazation<T>(this Clause<T> before, string database_principal_name) => throw new InvalitContextException(nameof(Authoriazation));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> From(AsymKeySourceBase element) => throw new InvalitContextException(nameof(From));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> From<T>(this Clause<T> before, AsymKeySourceBase element) => throw new InvalitContextException(nameof(From));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> With(KeyOptionBase element) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        [ClauseStyleConverter]
        public static Clause<Non> With<T>(this Clause<T> before, KeyOptionBase element) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="path_to_strong"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "FILE = [$0]")]
        public static AsymKeySourceBase File_Assign(string path_to_strong) => throw new InvalitContextException(nameof(File_Assign));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="path_to_executable_file"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "EXECUTABLE FILE = [$0]")]
        public static AsymKeySourceBase ExecutableFile_Assign(string path_to_executable_file) => throw new InvalitContextException(nameof(ExecutableFile_Assign));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="assembly_Name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "ASSEMBLY [$0]")]
        public static AsymKeySourceBase Assembly(string assembly_Name) => throw new InvalitContextException(nameof(Assembly));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="provider_Name"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "PROVIDER [$0]")]
        public static AsymKeySourceBase Provider(string provider_Name) => throw new InvalitContextException(nameof(Provider));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="algorithm"></param>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "ALGORITHM = ")]
        public static KeyOptionBase Algorithm_Assign(AlgorithmElement algorithm) => throw new InvalitContextException(nameof(Algorithm_Assign));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="key_name_in_provider"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "PROVIDER_KEY_NAME = [$0]")]
        public static KeyOptionBase Provider_Key_Name(string key_name_in_provider) => throw new InvalitContextException(nameof(Provider_Key_Name));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-asymmetric-key-transact-sql
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        [ClauseStyleConverter(Name = "CREATION_DISPOSITION = ")]
        public static KeyOptionBase Creation_Disposition_Assign(CreationDispositionElement element) => throw new InvalitContextException(nameof(Creation_Disposition_Assign));







        //???
        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-availability-group-transact-sql
        /*
        CREATE AVAILABILITY GROUP
        WITH
            <with_option_spec>::=   
                AUTOMATED_BACKUP_PREFERENCE = { PRIMARY | SECONDARY_ONLY| SECONDARY | NONE }  
              | FAILURE_CONDITION_LEVEL  = { 1 | 2 | 3 | 4 | 5 }   
              | HEALTH_CHECK_TIMEOUT = milliseconds  
              | DB_FAILOVER  = { ON | OFF }   
              | DTC_SUPPORT  = { PER_DB | NONE }  
              | BASIC  
              | DISTRIBUTED
              | REQUIRED_SYNCHRONOUS_SECONDARIES_TO_COMMIT = { integer }
              | CLUSTER_TYPE = { WSFC | EXTERNAL | NONE } 
        FOR  [ DATABASE database_name [ ,...n ] ]  
            →ForDataBase
        REPLICA ON
        WITH → 複数個
        <add_replica_spec>::=  
              <server_instance>  
                (  
                   ENDPOINT_URL = 'TCP://system-address:port',  
                   AVAILABILITY_MODE = { SYNCHRONOUS_COMMIT | ASYNCHRONOUS_COMMIT },  
                   FAILOVER_MODE = { AUTOMATIC | MANUAL }  
                   [ , <add_replica_option> [ ,...n ] ]  
                )   

              <add_replica_option>::=  
                   SEEDING_MODE = { AUTOMATIC | MANUAL }  
                 | BACKUP_PRIORITY = n  
                 | SECONDARY_ROLE ( {   
                        [ ALLOW_CONNECTIONS = { NO | READ_ONLY | ALL } ]   
                    [,] [ READ_ONLY_ROUTING_URL = 'TCP://system-address:port' ]  
                 } )  
                 | PRIMARY_ROLE ( {   
                        [ ALLOW_CONNECTIONS = { READ_WRITE | ALL } ]   
                    [,] [ READ_ONLY_ROUTING_LIST = { ( ‘<server_instance>’ [ ,...n ] ) | NONE } ]  
                 } )  
                 | SESSION_TIMEOUT = integer  
                 
        AVAILABILITY GROUP ON WITH
            <add_availability_group_spec>::=  
                 <ag_name>  
                    (  
                       LISTENER_URL = 'TCP://system-address:port',  
                       AVAILABILITY_MODE = { SYNCHRONOUS_COMMIT | ASYNCHRONOUS_COMMIT },  
                       FAILOVER_MODE = MANUAL,  
                       SEEDING_MODE = { AUTOMATIC | MANUAL }  
                    )  
        ADD LISTENER‘dns_name’ ( <listener_option> )


            <listener_option> ::=  
               {  
                  WITH DHCP [ ON ( <network_subnet_option> ) ]  
                | WITH IP ( { ( <ip_address_option> ) } [ , ...n ] ) [ , PORT = listener_port ]  
               }  

              <network_subnet_option> ::=  
                 ‘four_part_ipv4_address’, ‘four_part_ipv4_mask’    

              <ip_address_option> ::=  
                 {   
                    ‘four_part_ipv4_address’, ‘four_part_ipv4_mask’  
                  | ‘ipv6_address’  
                 }  

             */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-broker-priority-transact-sql
        /*
        CREATE BROKER PRIORITY 
        FOR CONVERSATION  
        SET()
            [ CONTRACT_NAME = {ContractName | ANY } ]  
            [ [ , ] LOCAL_SERVICE_NAME = {LocalServiceName | ANY } ]  
            [ [ , ] REMOTE_SERVICE_NAME = {'RemoteServiceName' | ANY } ]  
            [ [ , ] PRIORITY_LEVEL = {PriorityValue | DEFAULT } ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-certificate-transact-sql
        /*
        CREATE CERTIFICATE 
        FROM 
                <existing_keys> ::=   
                    ASSEMBLY assembly_name  
                    | {   
                        [ EXECUTABLE ] FILE = 'path_to_file'  
                        [ WITH PRIVATE KEY ( <private_key_options> ) ]   
                      }  
                    | {   
                        BINARY = asn_encoded_certificate  
                        [ WITH PRIVATE KEY ( <private_key_options> ) ]  
                      }  
        <generate_new_keys> ::=   
            [ ENCRYPTION BY PASSWORD = 'password' ]   
            WITH SUBJECT = 'certificate_subject_name'   
            [ , <date_options> [ ,...n ] ]   

                <private_key_options> ::=  
                        {   
                        FILE = 'path_to_private_key'  
                            [ , DECRYPTION BY PASSWORD = 'password' ]  
                            [ , ENCRYPTION BY PASSWORD = 'password' ]    
                        }  
                    |  
                        {   
                        BINARY = private_key_bits  
                            [ , DECRYPTION BY PASSWORD = 'password' ]  
                            [ , ENCRYPTION BY PASSWORD = 'password' ]    
                        }  

                <date_options> ::=  
                    START_DATE = 'datetime' | EXPIRY_DATE = 'datetime' 

          [ ACTIVE FOR BEGIN_DIALOG =  { ON | OFF } ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-columnstore-index-transact-sql
        /*
         CREATE CLUSTERED COLUMNSTORE INDEX index_name  ON [database_name. [schema_name ] . | schema_name . ] table_name  
         WITH 
            <with_option> ::=  
                  DROP_EXISTING = { ON | OFF } -- default is OFF  
                | MAXDOP = max_degree_of_parallelism 
                | ONLINE = { ON | OFF } 
                | COMPRESSION_DELAY  = { 0 | delay [ Minutes ] }  
                | DATA_COMPRESSION = { COLUMNSTORE | COLUMNSTORE_ARCHIVE }  
                  [ ON PARTITIONS ( { partition_number_expression | range } [ ,...n ] ) ]  
        ON
            <on_option>::=  
                  partition_scheme_name ( column_name )   
                | filegroup_name   
                | "default"   
         
        ON xdimProduct (ProductKey, ProductAlternateKey, ProductSubcategoryKey, WeightUnitMeasureCode)  
        
        CREATE [NONCLUSTERED]  COLUMNSTORE INDEX index_name   ON [database_name. [schema_name ] . | schema_name . ] table_name  ( column  [ ,...n ] )  
        WHERE → 普通
        WITH, ON →上のと同じ
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-column-encryption-key-transact-sql
        /*
        CREATE COLUMN ENCRYPTION KEY key_name   
        WITH VALUES  (),() 複数個
        COLUMN_MASTER_KEY = column_master_key_name,   
    ALGORITHM = 'algorithm_name',   
    ENCRYPTED_VALUE = varbinary_literal
         */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-column-master-key-transact-sql
        /*
        CREATE COLUMN MASTER KEY key_name   
            WITH (  
                KEY_STORE_PROVIDER_NAME = 'key_store_provider_name',  
                KEY_PATH = 'key_path'   
                 ) 
         */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-contract-transact-sql
        /*
        CREATE CONTRACT contract_name  
           [ AUTHORIZATION owner_name ]  
              (  {   { message_type_name | [ DEFAULT ] }  
                  SENT BY { INITIATOR | TARGET | ANY }   
               } [ ,...n] )   
        [ ; ]  */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-credential-transact-sql
        /*
        CREATE CREDENTIAL credential_name   
        WITH IDENTITY = 'identity_name'  
            [ , SECRET = 'secret' ]  
                [ FOR CRYPTOGRAPHIC PROVIDER cryptographic_provider_name ]  */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-cryptographic-provider-transact-sql
        /*
         CREATE CRYPTOGRAPHIC PROVIDER provider_name   
                FROM FILE = path_of_DLL  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-database-sql-server-transact-sql
        /*
        CREATE DATABASE database_name   
        [ CONTAINMENT = { NONE | PARTIAL } ]  
        [ ON   
              [ PRIMARY ] <filespec> [ ,...n ]   
              [ , <filegroup> [ ,...n ] ]   
              [ LOG ON <filespec> [ ,...n ] ]   
        ]   
        [ COLLATE collation_name ]  →ある
        [ WITH  <option> [,...n ] ]  
        [;]  
        <option> ::=  
        {  
              FILESTREAM ( <filestream_option> [,...n ] )  
            | DEFAULT_FULLTEXT_LANGUAGE = { lcid | language_name | language_alias }  
            | DEFAULT_LANGUAGE = { lcid | language_name | language_alias }  
            | NESTED_TRIGGERS = { OFF | ON }  
            | TRANSFORM_NOISE_WORDS = { OFF | ON}  
            | TWO_DIGIT_YEAR_CUTOFF = <two_digit_year_cutoff>   
            | DB_CHAINING { OFF | ON }  
            | TRUSTWORTHY { OFF | ON }  
        }  


        <filestream_option> ::=  
        {  
              NON_TRANSACTED_ACCESS = { OFF | READ_ONLY | FULL }  
            | DIRECTORY_NAME = 'directory_name'   
        }  

        <filespec> ::=   
        {  
        (  
            NAME = logical_file_name ,  
            FILENAME = { 'os_file_name' | 'filestream_path' }   
            [ , SIZE = size [ KB | MB | GB | TB ] ]   
            [ , MAXSIZE = { max_size [ KB | MB | GB | TB ] | UNLIMITED } ]   
            [ , FILEGROWTH = growth_increment [ KB | MB | GB | TB | % ] ]  
        )  
        }  

        <filegroup> ::=   
        {  
        いや、Primiryの引数としてでよいやろ。
        FILEGROUP filegroup name [ [ CONTAINS FILESTREAM ] [ DEFAULT ] | CONTAINS MEMORY_OPTIMIZED_DATA ]  
            <filespec> [ ,...n ]  
        }  

        <service_broker_option> ::=  
        {  
            ENABLE_BROKER  
          | NEW_BROKER  
          | ERROR_BROKER_CONVERSATIONS  
        }  
        */
        /*
        CREATE DATABASE database_name   
            ON <filespec> [ ,...n ]   
            FOR { { ATTACH [ WITH <attach_database_option> [ , ...n ] ] }  
                | ATTACH_REBUILD_LOG }  
        [;]  

        <attach_database_option> ::=  
        {  
              <service_broker_option>  
            | RESTRICTED_USER  
            | FILESTREAM ( DIRECTORY_NAME = { 'directory_name' | NULL } )  
        }  
         */
        /*
        CREATE DATABASE database_snapshot_name   
           ON   
           (  
               NAME = logical_file_name,  
               FILENAME = 'os_file_name'   
           ) [ ,...n ]   
           AS SNAPSHOT OF source_database_name          
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-database-azure-sql-database
        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-database-azure-sql-data-warehouse
        /*
            CREATE DATABASE database_name [ COLLATE collation_name ]  
            {  
               (<edition_options> [, ...n])   
            }  
        <edition_options> ::=   
        {  
              MAXSIZE = { 100 MB | 500 MB | 1 | 5 | 10 | 20 | 30 … 150…500 } GB    
            | ( EDITION = {  'basic' | 'standard' | 'premium' | 'premiumrs'}   
            | SERVICE_OBJECTIVE =   
                  {  'basic' | 'S0' | 'S1' | 'S2' | 'S3'   
                    | 'P1' | 'P2' | 'P3' | 'P4'| 'P6' | 'P11'  | 'P15'  
                    | 'PRS1' | 'PRS2' | 'PRS4' | 'PRS6' 
                    | { ELASTIC_POOL(name = <elastic_pool_name>) } }  ) 
        }  
        [;]
             
        */
        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-database-parallel-data-warehouse
        /*
       CREATE DATABASE database_name   
        WITH (   
            [ AUTOGROW = ON | OFF , ]   
            REPLICATED_SIZE = replicated_size [ GB ] ,  
            DISTRIBUTED_SIZE = distributed_size [ GB ] ,  
            LOG_SIZE = log_size [ GB ] )  
        [;]     
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-database-audit-specification-transact-sql
        /*
        CREATE DATABASE AUDIT SPECIFICATION audit_specification_name  
        {  
            FOR SERVER AUDIT audit_name   
                [ { ADD ( { <audit_action_specification> | audit_action_group_name } )   
              } [, ...n] ]  
            [ WITH ( STATE = { ON | OFF } ) ]  
        }  
        [ ; ]  
        <audit_action_specification>::=  
        {  
              action [ ,...n ]ON [ class :: ] securable BY principal [ ,...n ]  
        }          
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-database-encryption-key-transact-sql
        /*
        CREATE DATABASE ENCRYPTION KEY  
               WITH ALGORITHM = { AES_128 | AES_192 | AES_256 | TRIPLE_DES_3KEY }  
           ENCRYPTION BY SERVER   
            {  
                CERTIFICATE Encryptor_Name |  
                ASYMMETRIC KEY Encryptor_Name  
            }         
        */
        /*
         CREATE DATABASE ENCRYPTION KEY  
               WITH ALGORITHM = { AES_128 | AES_192 | AES_256 | TRIPLE_DES_3KEY }  
           ENCRYPTION BY SERVER CERTIFICATE Encryptor_Name   
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-database-scoped-credential-transact-sql
        /*
        CREATE DATABASE SCOPED CREDENTIAL credential_name   
        WITH IDENTITY = 'identity_name'  
            [ , SECRET = 'secret' ]  */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-default-transact-sql
        /*
        CREATE DEFAULT [ schema_name . ] default_name   
        AS constant_expression [ ; ]  */



        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-endpoint-transact-sql
        /*
        CREATE ENDPOINT endPointName [ AUTHORIZATION login ]  
        [ STATE = { STARTED | STOPPED | DISABLED } ]  
        AS { TCP } (  
           <protocol_specific_arguments>  
                )  

        TSQLはないのかな？
        FOR { TSQL | SERVICE_BROKER | DATABASE_MIRRORING } (  
           <language_specific_arguments>  
                )  

        <AS TCP_protocol_specific_arguments> ::=  
        AS TCP (  
          LISTENER_PORT = listenerPort  
          [ [ , ] LISTENER_IP = ALL | ( 4-part-ip ) | ( "ip_address_v6" ) ]  

        )  

        <FOR SERVICE_BROKER_language_specific_arguments> ::=  
        FOR SERVICE_BROKER (  
           [ AUTHENTICATION = {   
                    WINDOWS [ { NTLM | KERBEROS | NEGOTIATE } ]   
              | CERTIFICATE certificate_name   
              | WINDOWS [ { NTLM | KERBEROS | NEGOTIATE } ] CERTIFICATE certificate_name   
              | CERTIFICATE certificate_name WINDOWS [ { NTLM | KERBEROS | NEGOTIATE } ]   
            } ]  
           [ [ , ] ENCRYPTION = { DISABLED | { { SUPPORTED | REQUIRED }   
               [ ALGORITHM { AES | RC4 | AES RC4 | RC4 AES } ] }   
           ]  
           [ [ , ] MESSAGE_FORWARDING = { ENABLED | DISABLED } ]  
           [ [ , ] MESSAGE_FORWARD_SIZE = forward_size ]  
        )  


        <FOR DATABASE_MIRRORING_language_specific_arguments> ::=  
        FOR DATABASE_MIRRORING (  
           [ AUTHENTICATION = {   
                    WINDOWS [ { NTLM | KERBEROS | NEGOTIATE } ]   
              | CERTIFICATE certificate_name   
              | WINDOWS [ { NTLM | KERBEROS | NEGOTIATE } ] CERTIFICATE certificate_name   
              | CERTIFICATE certificate_name WINDOWS [ { NTLM | KERBEROS | NEGOTIATE } ]   
           [ [ [ , ] ] ENCRYPTION = { DISABLED | { { SUPPORTED | REQUIRED }   
               [ ALGORITHM { AES | RC4 | AES RC4 | RC4 AES } ] }   

            ]   
           [ , ] ROLE = { WITNESS | PARTNER | ALL }  
        )          
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-event-notification-transact-sql
        /*
        CREATE EVENT NOTIFICATION event_notification_name   
            ON { SERVER | DATABASE | QUEUE queue_name }   
            [ WITH FAN_IN ]  
            FOR { event_type | event_group } [ ,...n ]  
            TO SERVICE 'broker_service' , { 'broker_instance_specifier' | 'current database' }  
            [ ; ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-event-session-transact-sql
        /*
         CREATE EVENT SESSION event_session_name  
        ON SERVER  
        {  
            <event_definition> [ ,...n]  
            [ <event_target_definition> [ ,...n] ]  
            [ WITH ( <event_session_options> [ ,...n] ) ]  
        }  
        ;  

            <event_definition>::=  
            {  
                ADD EVENT [event_module_guid].event_package_name.event_name   
                     [ ( {   
                             [ SET { event_customizable_attribute = <value> [ ,...n] } ]  
                             [ ACTION ( { [event_module_guid].event_package_name.action_name [ ,...n] } ) ]  
                             [ WHERE <predicate_expression> ]  
                    } ) ]  
            }  

            <predicate_expression> ::=   
            {  
                [ NOT ] <predicate_factor> | {( <predicate_expression> ) }   
                [ { AND | OR } [ NOT ] { <predicate_factor> | ( <predicate_expression> ) } ]   
                [ ,...n ]  
            }  

            <predicate_factor>::=   
            {  
                <predicate_leaf> | ( <predicate_expression> )  
            }  

            <predicate_leaf>::=  
            {  
                  <predicate_source_declaration> { = | < > | ! = | > | > = | < | < = } <value>   
                | [event_module_guid].event_package_name.predicate_compare_name ( <predicate_source_declaration>, <value> )   
            }  

            <predicate_source_declaration>::=   
            {  
                event_field_name | ( [event_module_guid].event_package_name.predicate_source_name )  
            }  

            <value>::=   
            {  
                number | 'string'  
            }  

            <event_target_definition>::=  
            {  
                ADD TARGET [event_module_guid].event_package_name.target_name  
                    [ ( SET { target_parameter_name = <value> [ ,...n] } ) ]  
            }  

            <event_session_options>::=  
            {  
                [    MAX_MEMORY = size [ KB | MB ] ]  
                [ [,] EVENT_RETENTION_MODE = { ALLOW_SINGLE_EVENT_LOSS | ALLOW_MULTIPLE_EVENT_LOSS | NO_EVENT_LOSS } ]  
                [ [,] MAX_DISPATCH_LATENCY = { seconds SECONDS | INFINITE } ]  
                [ [,] MAX_EVENT_SIZE = size [ KB | MB ] ]  
                [ [,] MEMORY_PARTITION_MODE = { NONE | PER_NODE | PER_CPU } ]  
                [ [,] TRACK_CAUSALITY = { ON | OFF } ]  
                [ [,] STARTUP_STATE = { ON | OFF } ]  
            }         
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-external-data-source-transact-sql
        /*
        -- PolyBase only:  Hadoop cluster as data source   
        -- (on SQL Server 2016)  
        CREATE EXTERNAL DATA SOURCE data_source_name  
            WITH (   
                TYPE = HADOOP,
                LOCATION = 'hdfs://NameNode_URI[:port]'  
                [, RESOURCE_MANAGER_LOCATION = 'ResourceManager_URI[:port]' ]  
                [, CREDENTIAL = credential_name ]
            )
        [;]  

        -- PolyBase only: Azure Storage Blob as data source   
        -- (on SQL Server 2016 and Azure SQL Data Warehouse)  
        CREATE EXTERNAL DATA SOURCE data_source_name  
            WITH (   
                TYPE = HADOOP,  
                LOCATION = 'wasb[s]://container@account_name.blob.core.windows.net'
                [, CREDENTIAL = credential_name ]
            )  
        [;]

        -- PolyBase only: Azure Data Lake Store
        -- (on Azure SQL Data Warehouse)
        CREATE EXTERNAL DATA SOURCE AzureDataLakeStore
        WITH (
            TYPE = HADOOP,
            LOCATION = 'adl://<AzureDataLake account_name>.azuredatalake.net',
            CREDENTIAL = AzureStorageCredential
        );

        -- PolyBase only: Hadoop cluster as data source
        -- (on Parallel Data Warehouse)
        CREATE EXTERNAL DATA SOURCE data_source_name
            WITH ( 
                TYPE = HADOOP, 
                LOCATION = 'hdfs://NameNode_URI[:port]'
                [, JOB_TRACKER_LOCATION = 'JobTracker_URI[:port]' ]
            )
        [;]

        -- PolyBase only: Azure Storage Blob as data source 
        -- (on Parallel Data Warehouse)
        CREATE EXTERNAL DATA SOURCE data_source_name
            WITH ( 
                TYPE = HADOOP,
                LOCATION = 'wasb[s]://container@account_name.blob.core.windows.net'
            )
        [;]

        -- Elastic Database query only: a shard map manager as data source   
        -- (only on Azure SQL Database v12 or later)  
        CREATE EXTERNAL DATA SOURCE data_source_name  
            WITH (   
                TYPE = SHARD_MAP_MANAGER,  
                LOCATION = '<server_name>.database.windows.net',  
                DATABASE_NAME = '\<ElasticDatabase_ShardMapManagerDb'>,  
                CREDENTIAL = <ElasticDBQueryCred>,  
                SHARD_MAP_NAME = '<ShardMapName>'  
            )  
        [;]  

        -- Elastic Database query only: a remote database on Azure SQL Database as data source   
        -- (only on Azure SQL Database v12 or later)  
        CREATE EXTERNAL DATA SOURCE data_source_name  
            WITH (   
                TYPE = RDBMS,  
                LOCATION = '<server_name>.database.windows.net',  
                DATABASE_NAME = '<Remote_Database_Name>',  
                CREDENTIAL = <SQL_Credential>  
            )  
        [;]  

        -- Bulk operations only: Azure Storage Blob as data source   
        -- (on SQL Server 2017 and Azure SQL Database).
        CREATE EXTERNAL DATA SOURCE data_source_name  
            WITH (   
                TYPE = BLOB_STORAGE,  
                LOCATION = 'https://storage_account_name.blob.core.windows.net/container_name'
                [, CREDENTIAL = credential_name ]
            )  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-external-library-transact-sql
        /*
        CREATE EXTERNAL LIBRARY library_name  
            [ AUTHORIZATION owner_name ]  
        FROM <file_spec> [,…2]  →  (CONTENT = 'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\ggplot2.zip') 
        WITH ( LANGUAGE = 'R' )  
        [ ; ]  

        <file_spec> ::=  
        {  
        (CONTENT = { <client_library_specifier> | <library_bits> }  
        [, PLATFORM = WINDOWS ])  
        }  

        <client_library_specifier> :: =  
          '[\\computer_name\]share_name\[path\]manifest_file_name'  
        | '[local_path\]manifest_file_name'  
        | '<relative_path_in_external_data_source>'  

        <library_bits> :: =  
        { varbinary_literal | varbinary_expression }  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-external-file-format-transact-sql
        /*
        -- Create an external file format for PARQUET files.  
        CREATE EXTERNAL FILE FORMAT file_format_name  
        WITH (  
            FORMAT_TYPE = PARQUET  
             [ , DATA_COMPRESSION = {  
                'org.apache.hadoop.io.compress.SnappyCodec'  
              | 'org.apache.hadoop.io.compress.GzipCodec'      }  
            ]);  

        --Create an external file format for ORC files.  
        CREATE EXTERNAL FILE FORMAT file_format_name  
        WITH (  
            FORMAT_TYPE = ORC  
             [ , DATA_COMPRESSION = {  
                'org.apache.hadoop.io.compress.SnappyCodec'  
              | 'org.apache.hadoop.io.compress.DefaultCodec'      }  
            ]);  

        --Create an external file format for RCFILE.  
        CREATE EXTERNAL FILE FORMAT file_format_name  
        WITH (  
            FORMAT_TYPE = RCFILE,  
            SERDE_METHOD = {  
                'org.apache.hadoop.hive.serde2.columnar.LazyBinaryColumnarSerDe'  
              | 'org.apache.hadoop.hive.serde2.columnar.ColumnarSerDe'  
            }  
            [ , DATA_COMPRESSION = 'org.apache.hadoop.io.compress.DefaultCodec' ]);  

        --Create an external file format for DELIMITED TEXT files.  
        CREATE EXTERNAL FILE FORMAT file_format_name  
        WITH (  
            FORMAT_TYPE = DELIMITEDTEXT  
            [ , FORMAT_OPTIONS ( <format_options> [ ,...n  ] ) ]  
            [ , DATA_COMPRESSION = {  
                   'org.apache.hadoop.io.compress.GzipCodec'  
                 | 'org.apache.hadoop.io.compress.DefaultCodec'  
                }  
             ]);  

        <format_options> ::=  
        {  
            FIELD_TERMINATOR = field_terminator  
            | STRING_DELIMITER = string_delimiter  
            | DATE_FORMAT = datetime_format  
            | USE_TYPE_DEFAULT = { TRUE | FALSE } 
            | Encoding = {'UTF8' | 'UTF16'} 
        } 
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-external-resource-pool-transact-sql
        /*
        CREATE EXTERNAL RESOURCE POOL pool_name  
        [ WITH (  
            [ MAX_CPU_PERCENT = value ]  
            [ [ , ] AFFINITY CPU =    
                    {  
                        AUTO   
                      | ( <cpu_range_spec> )   
                      | NUMANODE = ( <NUMA_node_id> )   
                    } ]   
            [ [ , ] MAX_MEMORY_PERCENT = value ]  
            [ [ , ] MAX_PROCESSES = value ]   
            )   
        ]  
        [ ; ]  

        <CPU_range_spec> ::=    
        { CPU_ID | CPU_ID  TO CPU_ID } [ ,...n ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-external-table-transact-sql
        /*
        -- Syntax for SQL Server 

        -- Create a new external table  
        CREATE EXTERNAL TABLE [ database_name . [ schema_name ] . | schema_name. ] table_name   
            ( <column_definition> [ ,...n ] )  
            WITH (   
                LOCATION = 'folder_or_filepath',  
                DATA_SOURCE = external_data_source_name,  
                FILE_FORMAT = external_file_format_name  
                [ , <reject_options> [ ,...n ] ]  
            )  
        [;]  

        <reject_options> ::=  
        {  
            | REJECT_TYPE = value | percentage  
            | REJECT_VALUE = reject_value  
            | REJECT_SAMPLE_VALUE = reject_sample_value  

        }  

        -- Create a table for use with Elastic Database query  
        CREATE EXTERNAL TABLE [ database_name . [ schema_name ] . | schema_name. ] table_name   
            ( <column_definition> [ ,...n ] )  
            WITH ( <sharded_external_table_options> )  
        [;]  

        <sharded_external_table_options> ::=  
                DATA_SOURCE = external_data_source_name,   
                SCHEMA_NAME = N'nonescaped_schema_name',  
                OBJECT_NAME = N'nonescaped_object_name',  
                [DISTRIBUTION  = SHARDED(sharding_column_name) | REPLICATED | ROUND_ROBIN]]  
            )  
        [;]
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-external-table-as-select-transact-sql
        /*    
        CREATE EXTERNAL TABLE [ [database_name  . [ schema_name ] . ] | schema_name . ] table_name   
            WITH (   
                LOCATION = 'hdfs_folder',  
                DATA_SOURCE = external_data_source_name,  
                FILE_FORMAT = external_file_format_name  
                [ , <reject_options> [ ,...n ] ]  
            )  
            AS <select_statement>  
        [;]  

        <reject_options> ::=  
        {  
            | REJECT_TYPE = value | percentage  
            | REJECT_VALUE = reject_value  
            | REJECT_SAMPLE_VALUE = reject_sample_value  
        }  

        <select_statement> ::=  
            [ WITH <common_table_expression> [ ,...n ] ]  
            SELECT <select_criteria>  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-fulltext-catalog-transact-sql
        /*
        CREATE FULLTEXT CATALOG catalog_name  
             [ON FILEGROUP filegroup ]  
             [IN PATH 'rootpath']  
             [WITH <catalog_option>]  
             [AS DEFAULT]  
             [AUTHORIZATION owner_name ]  

        <catalog_option>::=  
             ACCENT_SENSITIVITY = {ON|OFF}  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-fulltext-index-transact-sql
        /*
        CREATE FULLTEXT INDEX ON table_name  
           [ ( { column_name   
                     [ TYPE COLUMN type_column_name ]  
                     [ LANGUAGE language_term ]   
                     [ STATISTICAL_SEMANTICS ]  
                } [ ,...n]   
              ) ]  
            KEY INDEX index_name   
            [ ON <catalog_filegroup_option> ]  
            [ WITH [ ( ] <with_option> [ ,...n] [ ) ] ]  
        [;]  

        <catalog_filegroup_option>::=  
         {  
            fulltext_catalog_name   
         | ( fulltext_catalog_name, FILEGROUP filegroup_name )  
         | ( FILEGROUP filegroup_name, fulltext_catalog_name )  
         | ( FILEGROUP filegroup_name )  
         }  

        <with_option>::=  
         {  
           CHANGE_TRACKING [ = ] { MANUAL | AUTO | OFF [, NO POPULATION ] }   
         | STOPLIST [ = ] { OFF | SYSTEM | stoplist_name }  
         | SEARCH PROPERTY LIST [ = ] property_list_name   
         }  */


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-fulltext-stoplist-transact-sql
        /*
        CREATE FULLTEXT STOPLIST stoplist_name  
        [ FROM { [ database_name.]source_stoplist_name } | SYSTEM STOPLIST ]  
        [ AUTHORIZATION owner_name ]  
        ;  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-function-transact-sql
        //CREATE FUNCTION
        //意味わからんわー

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-function-sql-data-warehouse
        /*
        -- Syntax for Azure SQL Data Warehouse and Parallel Data Warehouse  

        --Transact-SQL Scalar Function Syntax  
        CREATE FUNCTION [ schema_name. ] function_name   
        ( [ { @parameter_name [ AS ] parameter_data_type   
            [ = default ] }   
            [ ,...n ]  
          ]  
        )  
        RETURNS return_data_type  
            [ WITH <function_option> [ ,...n ] ]  
            [ AS ]  
            BEGIN   
                function_body   
                RETURN scalar_expression  
            END  
        [ ; ]  

        <function_option>::=   
        {  
            [ SCHEMABINDING ]  
          | [ RETURNS NULL ON NULL INPUT | CALLED ON NULL INPUT ]  
        }  
        */


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-index-transact-sql
        //CreateIndex これもきついわー


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-login-transact-sql
        /*
        -- Syntax for SQL Server  

        CREATE LOGIN login_name { WITH <option_list1> | FROM <sources> }  

        <option_list1> ::=   
            PASSWORD = { 'password' | hashed_password HASHED } [ MUST_CHANGE ]  
            [ , <option_list2> [ ,... ] ]  

        <option_list2> ::=    
            SID = sid  
            | DEFAULT_DATABASE = database      
            | DEFAULT_LANGUAGE = language  
            | CHECK_EXPIRATION = { ON | OFF}  
            | CHECK_POLICY = { ON | OFF}  
            | CREDENTIAL = credential_name   

        <sources> ::=  
            WINDOWS [ WITH <windows_options>[ ,... ] ]  
            | CERTIFICATE certname  
            | ASYMMETRIC KEY asym_key_name  

        <windows_options> ::=        
            DEFAULT_DATABASE = database  
            | DEFAULT_LANGUAGE = language  


        -- Syntax for Azure SQL Database and Azure SQL Data Warehouse  

        CREATE LOGIN login_name  
         { WITH <option_list3> }  

        <option_list3> ::=   
            PASSWORD = { 'password' }  
            [ SID = sid ]  
        
             
          -- Syntax for Parallel Data Warehouse  

        CREATE LOGIN loginName { WITH <option_list1> | FROM WINDOWS }  

        <option_list1> ::=   
            PASSWORD = { 'password' } [ MUST_CHANGE ]  
            [ , <option_list2> [ ,... ] ]  

        <option_list2> ::=    
              CHECK_EXPIRATION = { ON | OFF}  
            | CHECK_POLICY = { ON | OFF}             
             */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-master-key-transact-sql
        //CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'password'  

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-message-type-transact-sql
        /*
        CREATE MESSAGE TYPE message_type_name  
            [ AUTHORIZATION owner_name ]  
            [ VALIDATION = {  NONE  
                            | EMPTY   
                            | WELL_FORMED_XML  
                            | VALID_XML WITH SCHEMA COLLECTION schema_collection_name  
                           } ]  
        [ ; ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-partition-function-transact-sql
        /*
        CREATE PARTITION FUNCTION partition_function_name ( input_parameter_type )  
        AS RANGE [ LEFT | RIGHT ]   
        FOR VALUES ( [ boundary_value [ ,...n ] ] )   
        */


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-partition-scheme-transact-sql
        /*
        CREATE PARTITION SCHEME partition_scheme_name  
        AS PARTITION partition_function_name  
        [ ALL ] TO ( { file_group_name | [ PRIMARY ] } [ ,...n ] )
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-procedure-transact-sql
        /*
        -- Transact-SQL Syntax for Stored Procedures in SQL Server and Azure SQL Database  

        CREATE [ OR ALTER ] { PROC | PROCEDURE } [schema_name.] procedure_name [ ; number ]   
            [ { @parameter [ type_schema_name. ] data_type }  
                [ VARYING ] [ = default ] [ OUT | OUTPUT | [READONLY]  
            ] [ ,...n ]   
        [ WITH <procedure_option> [ ,...n ] ]  
        [ FOR REPLICATION ]   
        AS { [ BEGIN ] sql_statement [;] [ ...n ] [ END ] }  
        [;]  

        <procedure_option> ::=   
            [ ENCRYPTION ]  
            [ RECOMPILE ]  
            [ EXECUTE AS Clause ]  
        */
        /*
        -- Transact-SQL Syntax for CLR Stored Procedures  

        CREATE [ OR ALTER ] { PROC | PROCEDURE } [schema_name.] procedure_name [ ; number ]   
            [ { @parameter [ type_schema_name. ] data_type }   
                [ = default ] [ OUT | OUTPUT ] [READONLY]  
            ] [ ,...n ]   
        [ WITH EXECUTE AS Clause ]  
        AS { EXTERNAL NAME assembly_name.class_name.method_name }  
        [;]  
        */
        /*
        -- Transact-SQL Syntax for Natively Compiled Stored Procedures  

        CREATE [ OR ALTER ] { PROC | PROCEDURE } [schema_name.] procedure_name  
            [ { @parameter data_type } [ NULL | NOT NULL ] [ = default ] 
                [ OUT | OUTPUT ] [READONLY] 
            ] [ ,... n ]  
          WITH NATIVE_COMPILATION, SCHEMABINDING [ , EXECUTE AS clause ]  
        AS  
        {  
          BEGIN ATOMIC WITH (set_option [ ,... n ] )  
        sql_statement [;] [ ... n ]  
         [ END ]  
        }  
         [;]  

        <set_option> ::=  
            LANGUAGE =  [ N ] 'language'  
          | TRANSACTION ISOLATION LEVEL =  { SNAPSHOT | REPEATABLE READ | SERIALIZABLE }  
          | [ DATEFIRST = number ]  
          | [ DATEFORMAT = format ]  
          | [ DELAYED_DURABILITY = { OFF | ON } ]  
        */
        /*
        -- Transact-SQL Syntax for Stored Procedures in Azure SQL Data Warehouse
        -- and Parallel Data Warehouse  

        -- Create a stored procedure   
        CREATE { PROC | PROCEDURE } [ schema_name.] procedure_name  
            [ { @parameterdata_type } [ OUT | OUTPUT ] ] [ ,...n ]  
        AS { [ BEGIN ] sql_statement [;][ ,...n ] [ END ] }  
        [;]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-queue-transact-sql
        /*
        CREATE QUEUE <object>  
           [ WITH  
             [ STATUS = { ON | OFF }  [ , ] ]  
             [ RETENTION = { ON | OFF } [ , ] ]   
             [ ACTIVATION (  
                 [ STATUS = { ON | OFF } , ]   
                   PROCEDURE_NAME = <procedure> ,  
                   MAX_QUEUE_READERS = max_readers ,   
                   EXECUTE AS { SELF | 'user_name' | OWNER }   
                    ) [ , ] ]  
             [ POISON_MESSAGE_HANDLING (  
                 [ STATUS = { ON | OFF } ] ) ] 
            ]  
             [ ON { filegroup | [ DEFAULT ] } ]  
        [ ; ]  

        <object> ::=  
        {  
            [ database_name. [ schema_name ] . | schema_name. ]  
                queue_name  
        }   

        <procedure> ::=  
        {  
            [ database_name. [ schema_name ] . | schema_name. ]  
                stored_procedure_name  
        }  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-remote-service-binding-transact-sql
        /*
        CREATE REMOTE SERVICE BINDING binding_name   
           [ AUTHORIZATION owner_name ]   
           TO SERVICE 'service_name'   
           WITH  USER = user_name [ , ANONYMOUS = { ON | OFF } ]  
        [ ; ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-remote-table-as-select-parallel-data-warehouse
        /*
        CREATE REMOTE TABLE [ database_name . [ schema_name ] . | schema_name. ] table_name     AT ('<connection_string>')  
            [ WITH ( BATCH_SIZE = batch_size ) ]  
            AS <select_statement>  
        [;]  

        <connection_string> ::=   
            Data Source = { IP_address | hostname } [, port ]; User ID = user_name ;Password = password;  

        <select_statement> ::=  
            [ WITH <common_table_expression> [ ,...n ] ]  
            SELECT <select_criteria>  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-resource-pool-transact-sql
        /*
        CREATE RESOURCE POOL pool_name  
        [ WITH  
            (  
                [ MIN_CPU_PERCENT = value ]  
                [ [ , ] MAX_CPU_PERCENT = value ]   
                [ [ , ] CAP_CPU_PERCENT = value ]   
                [ [ , ] AFFINITY {SCHEDULER =  
                          AUTO 
                        | ( <scheduler_range_spec> )   
                        | NUMANODE = ( <NUMA_node_range_spec> )
                        } ]   
                [ [ , ] MIN_MEMORY_PERCENT = value ]  
                [ [ , ] MAX_MEMORY_PERCENT = value ]  
                [ [ , ] MIN_IOPS_PER_VOLUME = value ]  
                [ [ , ] MAX_IOPS_PER_VOLUME = value ]  
            )   
        ]  
        [;]  

        <scheduler_range_spec> ::=  
        { SCHED_ID | SCHED_ID TO SCHED_ID }[,…n]  

        <NUMA_node_range_spec> ::=  
        { NUMA_node_ID | NUMA_node_ID TO NUMA_node_ID }[,…n]  */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-role-transact-sql
        //CREATE ROLE role_name [ AUTHORIZATION owner_name ]  


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-route-transact-sql
        /*
        CREATE ROUTE route_name  
        [ AUTHORIZATION owner_name ]  
        WITH    
           [ SERVICE_NAME = 'service_name', ]  
           [ BROKER_INSTANCE = 'broker_instance_identifier' , ]  
           [ LIFETIME = route_lifetime , ]  
           ADDRESS =  'next_hop_address'  
           [ , MIRROR_ADDRESS = 'next_hop_mirror_address' ]  
        [ ; ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-rule-transact-sql
        /*
        CREATE RULE [ schema_name . ] rule_name   
        AS condition_expression  
        [ ; ]  
        */


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-schema-transact-sql
        /*
        -- Syntax for SQL Server and Azure SQL Database  

        CREATE SCHEMA schema_name_clause [ <schema_element> [ ...n ] ]  

        <schema_name_clause> ::=  
            {  
            schema_name  
            | AUTHORIZATION owner_name  
            | schema_name AUTHORIZATION owner_name  
            }  

        <schema_element> ::=   
            {   
                table_definition | view_definition | grant_statement |   
                revoke_statement | deny_statement   
            }  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-search-property-list-transact-sql
        /*
        CREATE SEARCH PROPERTY LIST new_list_name  
           [ FROM [ database_name. ] source_list_name ]  
           [ AUTHORIZATION owner_name ]  
        ; 
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-security-policy-transact-sql
        /*
        CREATE SECURITY POLICY [schema_name. ] security_policy_name    
            { ADD [ FILTER | BLOCK ] } PREDICATE tvf_schema_name.security_predicate_function_name   
              ( { column_name | arguments } [ , …n] ) ON table_schema_name. table_name    
              [ <block_dml_operation> ] , [ , …n] 
            [ WITH ( STATE = { ON | OFF }  [,] [ SCHEMABINDING = { ON | OFF } ] ) ]  
            [ NOT FOR REPLICATION ] 
        [;]  

        <block_dml_operation>  
            [ { AFTER { INSERT | UPDATE } }   
            | { BEFORE { UPDATE | DELETE } } ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-selective-xml-index-transact-sql
        /*
        CREATE SELECTIVE XML INDEX index_name  
            ON <table_object> (xml_column_name)  
            [WITH XMLNAMESPACES (<xmlnamespace_list>)]  
            FOR (<promoted_node_path_list>)  
            [WITH (<index_options>)]  

        <table_object> ::=  
         { [database_name. [schema_name ] . | schema_name. ] table_name }  

        <promoted_node_path_list> ::=   
        <named_promoted_node_path_item> [, <promoted_node_path_list>]  

        <named_promoted_node_path_item> ::=   
        <path_name> = <promoted_node_path_item>  

        <promoted_node_path_item>::=  
        <xquery_node_path_item> | <sql_values_node_path_item>  

        <xquery_node_path_item> ::=   
        <node_path> [AS XQUERY <xsd_type_or_node_hint>] [SINGLETON]  

        <xsd_type_or_node_hint> ::=   
        [<xsd_type>] [MAXLENGTH(x)] | node()  

        <sql_values_node_path_item> ::=  
        <node_path> AS SQL <sql_type> [SINGLETON]  

        <node_path> ::=   
        character_string_literal  

        <xsd_type> ::=   
        character_string_literal  

        <sql_type> ::=   
        identifier  

        <path_name> ::=   
        identifier  

        <xmlnamespace_list> ::=   
        <xmlnamespace_item> [, <xmlnamespace_list>]  

        <xmlnamespace_item> ::=   
        <xmlnamespace_uri> AS <xmlnamespace_prefix>  

        <xml_namespace_uri> ::=   
        character_string_literal  

        <xml_namespace_prefix> ::=   
        identifier  

        <index_options> ::=   
        (   
          | PAD_INDEX  = { ON | OFF }  
          | FILLFACTOR = fillfactor  
          | SORT_IN_TEMPDB = { ON | OFF }  
          | IGNORE_DUP_KEY = OFF  
          | DROP_EXISTING = { ON | OFF }  
          | ONLINE = OFF  
          | ALLOW_ROW_LOCKS = { ON | OFF }  
          | ALLOW_PAGE_LOCKS = { ON | OFF }  
          | MAXDOP = max_degree_of_parallelism  
        )  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-sequence-transact-sql
        /*
        CREATE SEQUENCE [schema_name . ] sequence_name  
            [ AS [ built_in_integer_type | user-defined_integer_type ] ]  
            [ START WITH <constant> ]  
            [ INCREMENT BY <constant> ]  
            [ { MINVALUE [ <constant> ] } | { NO MINVALUE } ]  
            [ { MAXVALUE [ <constant> ] } | { NO MAXVALUE } ]  
            [ CYCLE | { NO CYCLE } ]  
            [ { CACHE [ <constant> ] } | { NO CACHE } ]  
            [ ; ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-server-audit-transact-sql
        /*
        CREATE SERVER AUDIT audit_name  
        {  
            TO { [ FILE (<file_options> [ , ...n ] ) ] | APPLICATION_LOG | SECURITY_LOG }  
            [ WITH ( <audit_options> [ , ...n ] ) ]   
            [ WHERE <predicate_expression> ]  
        }  
        [ ; ]  

        <file_options>::=  
        {  
                FILEPATH = 'os_file_path'  
            [ , MAXSIZE = { max_size { MB | GB | TB } | UNLIMITED } ]  
            [ , { MAX_ROLLOVER_FILES = { integer | UNLIMITED } } | { MAX_FILES = integer } ]  
            [ , RESERVE_DISK_SPACE = { ON | OFF } ]   
        }  

        <audit_options>::=  
        {  
            [   QUEUE_DELAY = integer ]  
            [ , ON_FAILURE = { CONTINUE | SHUTDOWN | FAIL_OPERATION } ]  
            [ , AUDIT_GUID = uniqueidentifier ]  
        }  

        <predicate_expression>::=  
        {  
            [NOT ] <predicate_factor>   
            [ { AND | OR } [NOT ] { <predicate_factor> } ]   
            [,...n ]  
        }  

        <predicate_factor>::=   
            event_field_name { = | < > | ! = | > | > = | < | < = } { number | ' string ' }  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-server-audit-specification-transact-sql
        /*
        CREATE SERVER AUDIT SPECIFICATION audit_specification_name  
        FOR SERVER AUDIT audit_name  
        {  
            { ADD ( { audit_action_group_name } )   
            } [, ...n]  
            [ WITH ( STATE = { ON | OFF } ) ]  
        }  
        [ ; ]  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-server-role-transact-sql
        //CREATE SERVER ROLE role_name [ AUTHORIZATION server_principal ]  

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-service-transact-sql
        /*
        CREATE SERVICE service_name  
           [ AUTHORIZATION owner_name ]  
           ON QUEUE [ schema_name. ]queue_name  
           [ ( contract_name | [DEFAULT][ ,...n ] ) ]  
        [ ; ] 
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-spatial-index-transact-sql
        /*
        -- SQL Server Syntax  

        CREATE SPATIAL INDEX index_name   
          ON <object> ( spatial_column_name )  
            {  
               <geometry_tessellation> | <geography_tessellation>  
            }   
          [ ON { filegroup_name | "default" } ]  
        [;]   

        <object> ::=  
            [ database_name. [ schema_name ] . | schema_name. ]  table_name  

        <geometry_tessellation> ::=  
        {   
          <geometry_automatic_grid_tessellation>   
        | <geometry_manual_grid_tessellation>   
        }  

        <geometry_automatic_grid_tessellation> ::=  
        {  
            [ USING GEOMETRY_AUTO_GRID ]  
                  WITH  (  
                <bounding_box>  
                    [ [,] <tessellation_cells_per_object> [ ,…n] ]  
                    [ [,] <spatial_index_option> [ ,…n] ]  
                         )  
        }  

        <geometry_manual_grid_tessellation> ::=  
        {  
               [ USING GEOMETRY_GRID ]  
                 WITH (  
                            <bounding_box>  
                                [ [,]<tessellation_grid> [ ,…n] ]  
                                [ [,]<tessellation_cells_per_object> [ ,…n] ]  
                                [ [,]<spatial_index_option> [ ,…n] ]  
           )  
        }   

        <geography_tessellation> ::=  
        {  
              <geography_automatic_grid_tessellation> | <geography_manual_grid_tessellation>  
        }  

        <geography_automatic_grid_tessellation> ::=  
        {  
            [ USING GEOGRAPHY_AUTO_GRID ]  
            [ WITH (  
                [ [,] <tessellation_cells_per_object> [ ,…n] ]  
                [ [,] <spatial_index_option> ]  
             ) ]  
        }  

        <geography_manual_grid_tessellation> ::=  
        {  
            [ USING GEOGRAPHY_GRID ]  
            [ WITH (  
                        [ <tessellation_grid> [ ,…n] ]  
                        [ [,] <tessellation_cells_per_object> [ ,…n] ]  
                        [ [,] <spatial_index_option> [ ,…n] ]  
                        ) ]  
        }  

        <bounding_box> ::=  
        {  
              BOUNDING_BOX = ( {  
               xmin, ymin, xmax, ymax   
               | <named_bb_coordinate>, <named_bb_coordinate>, <named_bb_coordinate>, <named_bb_coordinate>   
          } )  
        }  

        <named_bb_coordinate> ::= { XMIN = xmin | YMIN = ymin | XMAX = xmax | YMAX=ymax }  

        <tesselation_grid> ::=  
        {   
            GRIDS = ( { <grid_level> [ ,...n ] | <grid_size>, <grid_size>, <grid_size>, <grid_size>  }   
                )  
        }  
        <tesseallation_cells_per_object> ::=  
        {   
           CELLS_PER_OBJECT = n   
        }  

        <grid_level> ::=  
        {  
             LEVEL_1 = <grid_size>   
          |  LEVEL_2 = <grid_size>   
          |  LEVEL_3 = <grid_size>   
          |  LEVEL_4 = <grid_size>   
        }  

        <grid_size> ::= { LOW | MEDIUM | HIGH }  

        <spatial_index_option> ::=  
        {  
            PAD_INDEX = { ON | OFF }  
          | FILLFACTOR = fillfactor  
          | SORT_IN_TEMPDB = { ON | OFF }  
          | IGNORE_DUP_KEY = OFF  
          | STATISTICS_NORECOMPUTE = { ON | OFF }  
          | DROP_EXISTING = { ON | OFF }  
          | ONLINE = OFF  
          | ALLOW_ROW_LOCKS = { ON | OFF }  
          | ALLOW_PAGE_LOCKS = { ON | OFF }  
          | MAXDOP = max_degree_of_parallelism  
            | DATA_COMPRESSION = { NONE | ROW | PAGE }  
        }  
        */
        /*
        -- Windows Azure SQL Database Syntax   

        CREATE SPATIAL INDEX index_name   
            ON <object> ( spatial_column_name )   
            {   
              [ USING <geometry_grid_tessellation> ]   
                  WITH ( <bounding_box>   
                        [ [,] <tesselation_parameters> [,... n ] ]   
                        [ [,] <spatial_index_option> [,... n ] ] )   
             | [ USING <geography_grid_tessellation> ]   
                  [ WITH ( [ <tesselation_parameters> [,... n ] ]   
                           [ [,] <spatial_index_option> [,... n ] ] ) ]   
            }  

        [ ; ]  

        <object> ::=  
        {  
            [database_name. [schema_name ] . | schema_name. ]   
                        table_name   
        }  

        <geometry_grid_tessellation> ::=   
        { GEOMETRY_GRID }  

        <bounding_box> ::=   
        BOUNDING_BOX = ( {  
                xmin, ymin, xmax, ymax   
           | <named_bb_coordinate>, <named_bb_coordinate>, <named_bb_coordinate>, <named_bb_coordinate>   
          } )  

        <named_bb_coordinate> ::= { XMIN = xmin | YMIN = ymin | XMAX = xmax | YMAX=ymax }  

        <tesselation_parameters> ::=   
        {   
            GRIDS = ( { <grid_density> [ ,... n ] | <density>, <density>, <density>, <density>  } )   
          | CELLS_PER_OBJECT = n   
        }  

        <grid_density> ::=   
        {  
             LEVEL_1 = <density>   
          |  LEVEL_2 = <density>   
          |  LEVEL_3 = <density>   
          |  LEVEL_4 = <density>   
        }  

        <density> ::= { LOW | MEDIUM | HIGH }  

        <geography_grid_tessellation> ::=   
        { GEOGRAPHY_GRID }  

        <spatial_index_option> ::=   
        {  
            IGNORE_DUP_KEY = OFF  
          | STATISTICS_NORECOMPUTE = { ON | OFF }  
          | DROP_EXISTING = { ON | OFF }  
          | ONLINE = OFF   
        }  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-statistics-transact-sql
        /*
        -- Syntax for SQL Server and Azure SQL Database  

        -- Create statistics on an external table  
        CREATE STATISTICS statistics_name   
        ON { table_or_indexed_view_name } ( column [ ,...n ] )   
            [ WITH FULLSCAN ] ;  

        -- Create statistics on a regular table or indexed view  
        CREATE STATISTICS statistics_name   
        ON { table_or_indexed_view_name } ( column [ ,...n ] )   
            [ WHERE <filter_predicate> ]  
            [ WITH   
                [ [ FULLSCAN   
                    [ [ , ] PERSIST_SAMPLE_PERCENT = { ON | OFF } ]    
                  | SAMPLE number { PERCENT | ROWS }   
                    [ [ , ] PERSIST_SAMPLE_PERCENT = { ON | OFF } ]    
                  | STATS_STREAM = stats_stream ] ]   
                [ [ , ] NORECOMPUTE ]   
                [ [ , ] INCREMENTAL = { ON | OFF } ]  
            ] ;  

        <filter_predicate> ::=   
            <conjunct> [AND <conjunct>]  

        <conjunct> ::=  
            <disjunct> | <comparison>  

        <disjunct> ::=  
                column_name IN (constant ,…)  

        <comparison> ::=  
                column_name <comparison_op> constant  

        <comparison_op> ::=  
            IS | IS NOT | = | <> | != | > | >= | !> | < | <= | !<  
        */
        /*
        -- Syntax for Azure SQL Data Warehouse and Parallel Data Warehouse  

        CREATE STATISTICS statistics_name   
            ON [ database_name . [schema_name ] . | schema_name. ] table_name   
            ( column_name  [ ,...n ] )   
            [ WHERE <filter_predicate> ]  
            [ WITH {  
                   FULLSCAN   
                   | SAMPLE number PERCENT   
              }  
            ]  
        [;]  

        <filter_predicate> ::=   
            <conjunct> [AND <conjunct>]  

        <conjunct> ::=  
            <disjunct> | <comparison>  

        <disjunct> ::=  
                column_name IN (constant ,…)  

        <comparison> ::=  
                column_name <comparison_op> constant  

        <comparison_op> ::=  
            IS | IS NOT | = | <> | != | > | >= | !> | < | <= | !< 
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-symmetric-key-transact-sql
        /*
        CREATE SYMMETRIC KEY key_name   
            [ AUTHORIZATION owner_name ]  
            [ FROM PROVIDER provider_name ]  
            WITH 
              [
                  <key_options> [ , ... n ]  
                | ENCRYPTION BY <encrypting_mechanism> [ , ... n ] 
              ]

        <key_options> ::=  
              KEY_SOURCE = 'pass_phrase'  
            | ALGORITHM = <algorithm>  
            | IDENTITY_VALUE = 'identity_phrase'  
            | PROVIDER_KEY_NAME = 'key_name_in_provider'   
            | CREATION_DISPOSITION = {CREATE_NEW | OPEN_EXISTING }  

        <algorithm> ::=  
            DES | TRIPLE_DES | TRIPLE_DES_3KEY | RC2 | RC4 | RC4_128  
            | DESX | AES_128 | AES_192 | AES_256   

        <encrypting_mechanism> ::=  
              CERTIFICATE certificate_name   
            | PASSWORD = 'password'   
            | SYMMETRIC KEY symmetric_key_name   
            | ASYMMETRIC KEY asym_key_name
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-synonym-transact-sql
        /*
        -- SQL Server Syntax  

        CREATE SYNONYM [ schema_name_1. ] synonym_name FOR <object>  

        <object> :: =  
        {  
            [ server_name.[ database_name ] . [ schema_name_2 ]. object_name   
          | database_name . [ schema_name_2 ].| schema_name_2. ] object_name  
        }  
        */
        /*
        -- Windows Azure SQL Database Syntax  

        CREATE SYNONYM [ schema_name_1. ] synonym_name FOR < object >  

        < object > :: =  
        {  
            [database_name. [ schema_name_2 ].| schema_name_2. ] object_name  
        } 
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-table-transact-sql
        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-table-azure-sql-data-warehouse
        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-table-sql-graph
        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-table-as-select-azure-sql-data-warehouse
        //Create Table ...


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-table-transact-sql-identity-property
        //IDENTITY [ (seed , increment) ]  

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /*
        CREATE [ OR ALTER ] TRIGGER [ schema_name . ]trigger_name   
        ON { table | view }   
        [ WITH <dml_trigger_option> [ ,...n ] ]  
        { FOR | AFTER | INSTEAD OF }   
        { [ INSERT ] [ , ] [ UPDATE ] [ , ] [ DELETE ] }   
        [ WITH APPEND ]  
        [ NOT FOR REPLICATION ]   
        AS { sql_statement  [ ; ] [ ,...n ] | EXTERNAL NAME <method specifier [ ; ] > }  

        <dml_trigger_option> ::=  
            [ ENCRYPTION ]  
            [ EXECUTE AS Clause ]  

        <method_specifier> ::=  
            assembly_name.class_name.method_name  
        */


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-type-transact-sql
        /*
        -- Disk-Based Type Syntax  
        CREATE TYPE [ schema_name. ] type_name  
        {   
            FROM base_type   
            [ ( precision [ , scale ] ) ]  
            [ NULL | NOT NULL ]   
          | EXTERNAL NAME assembly_name [ .class_name ]   
          | AS TABLE ( { <column_definition> | <computed_column_definition> }  
                [ <table_constraint> ] [ ,...n ] )    
        } [ ; ]  

        <column_definition> ::=  
        column_name <data_type>  
            [ COLLATE collation_name ]   
            [ NULL | NOT NULL ]  
            [   
                DEFAULT constant_expression ]   
              | [ IDENTITY [ ( seed ,increment ) ]   
            ]  
            [ ROWGUIDCOL ] [ <column_constraint> [ ...n ] ]   

        <data type> ::=   
        [ type_schema_name . ] type_name   
            [ ( precision [ , scale ] | max |   
                        [ { CONTENT | DOCUMENT } ] xml_schema_collection ) ]   

        <column_constraint> ::=   
        {     { PRIMARY KEY | UNIQUE }   
                [ CLUSTERED | NONCLUSTERED ]   
                [   
                    WITH ( <index_option> [ ,...n ] )   
                ]  
          | CHECK ( logical_expression )   
        }   

        <computed_column_definition> ::=  

        column_name AS computed_column_expression   
        [ PERSISTED [ NOT NULL ] ]  
        [   
            { PRIMARY KEY | UNIQUE }  
                [ CLUSTERED | NONCLUSTERED ]  
                [   
                    WITH ( <index_option> [ ,...n ] )  
                ]  
            | CHECK ( logical_expression )   
        ]   

        <table_constraint> ::=  
        {   
            { PRIMARY KEY | UNIQUE }   
                [ CLUSTERED | NONCLUSTERED ]   
            ( column [ ASC | DESC ] [ ,...n ] )   
                [   
            WITH ( <index_option> [ ,...n ] )   
                ]  
            | CHECK ( logical_expression )   
        }   

        <index_option> ::=  
        {  
            IGNORE_DUP_KEY = { ON | OFF }  
        }  
        */

        /*
        -- Memory-Optimized Table Type Syntax  
        CREATE TYPE [schema_name. ] type_name  
        AS TABLE ( { <column_definition> }  
            |  [ <table_constraint> ] [ ,... n ]    
            | [ <table_index> ] [ ,... n ]    } )
            [ WITH ( <table_option> [ ,... n ] ) ]  
         [ ; ]  

        <column_definition> ::=  
        column_name <data_type>  
            [ COLLATE collation_name ]   [ NULL | NOT NULL ]    [  
              [ IDENTITY [ (1 , 1) ]  
            ]  
            [ <column_constraint> [ ... n ] ]    [ <column_index> ]  

        <data type> ::=  
         [type_schema_name . ] type_name [ (precision [ , scale ]) ]  

        <column_constraint> ::=  
        { PRIMARY KEY {   NONCLUSTERED HASH WITH (BUCKET_COUNT = bucket_count) 
                        | NONCLUSTERED } }  

        < table_constraint > ::=  
        { PRIMARY KEY { NONCLUSTERED HASH (column [ ,... n ] ) 
                           WITH (BUCKET_COUNT = bucket_count) 
                       | NONCLUSTERED  (column [ ASC | DESC ] [ ,... n ] )  } }  

        <column_index> ::=  
          INDEX index_name  
        { { [ NONCLUSTERED ] HASH WITH (BUCKET_COUNT = bucket_count) 
             | NONCLUSTERED } }  

        < table_index > ::=  
          INDEX constraint_name  
        { { [ NONCLUSTERED ] HASH (column [ ,... n ] ) WITH (BUCKET_COUNT = bucket_count) 
         |  [NONCLUSTERED]  (column [ ASC | DESC ] [ ,... n ] )} }  

        <table_option> ::=  
        {  
            [MEMORY_OPTIMIZED = {ON | OFF}]  
        }  
        */


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-user-transact-sql
        /*
        -- Syntax for SQL Server and Azure SQL Database  

        -- Syntax Users based on logins in master  
        CREATE USER user_name   
            [   
                { FOR | FROM } LOGIN login_name   
            ]  
            [ WITH <limited_options_list> [ ,... ] ]   
        [ ; ]  

        --Users that authenticate at the database  
        CREATE USER   
            {  
              windows_principal [ WITH <options_list> [ ,... ] ]  

            | user_name WITH PASSWORD = 'password' [ , <options_list> [ ,... ]   
            | Azure_Active_Directory_principal FROM EXTERNAL PROVIDER   
            }  

         [ ; ]  

        --Users based on Windows principals that connect through Windows group logins  
        CREATE USER   
            {   
                  windows_principal [ { FOR | FROM } LOGIN windows_principal ]  
                | user_name { FOR | FROM } LOGIN windows_principal  
        }  
            [ WITH <limited_options_list> [ ,... ] ]   
        [ ; ]  

        --Users that cannot authenticate   
        CREATE USER user_name   
            {  
                 WITHOUT LOGIN [ WITH <limited_options_list> [ ,... ] ]  
               | { FOR | FROM } CERTIFICATE cert_name   
               | { FOR | FROM } ASYMMETRIC KEY asym_key_name   
            }  
         [ ; ]  

        <options_list> ::=  
              DEFAULT_SCHEMA = schema_name  
            | DEFAULT_LANGUAGE = { NONE | lcid | language name | language alias }  
            | SID = sid   
            | ALLOW_ENCRYPTED_VALUE_MODIFICATIONS = [ ON | OFF ] ]  

        <limited_options_list> ::=  
              DEFAULT_SCHEMA = schema_name ]   
            | ALLOW_ENCRYPTED_VALUE_MODIFICATIONS = [ ON | OFF ] ]  

        -- SQL Database syntax when connected to a federation member  
        CREATE USER user_name  
        [;]  
        */
        /*
        -- Syntax for Azure SQL Data Warehouse  

        CREATE USER user_name   
            [ { { FOR | FROM } { LOGIN login_name }   
              | WITHOUT LOGIN  
            ]   
            [ WITH DEFAULT_SCHEMA = schema_name ]  
        [;]

        CREATE USER Azure_Active_Directory_principal FROM EXTERNAL PROVIDER  
            [ WITH DEFAULT_SCHEMA = schema_name ]  
        [;]
        */
        /*
        -- Syntax for Parallel Data Warehouse  

        CREATE USER user_name   
            [ { { FOR | FROM }  
              {   
                LOGIN login_name   
              }   
              | WITHOUT LOGIN  
            ]   
            [ WITH DEFAULT_SCHEMA = schema_name ]  
        [;]  
        */
        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-view-transact-sql
        /*
        -- Syntax for SQL Server and Azure SQL Database  

        CREATE [ OR ALTER ] VIEW [ schema_name . ] view_name [ (column [ ,...n ] ) ]   
        [ WITH <view_attribute> [ ,...n ] ]   
        AS select_statement   
        [ WITH CHECK OPTION ]   
        [ ; ]  

        <view_attribute> ::=   
        {  
            [ ENCRYPTION ]  
            [ SCHEMABINDING ]  
            [ VIEW_METADATA ]       
        }   
        */
        /*
        -- Syntax for Azure SQL Data Warehouse and Parallel Data Warehouse  

        CREATE VIEW [ schema_name . ] view_name [  ( column_name [ ,...n ] ) ]   
        AS <select_statement>   
        [;]  

        <select_statement> ::=  
            [ WITH <common_table_expression> [ ,...n ] ]  
            SELECT <select_criteria>  
        */


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-workload-group-transact-sql
        /*
        CREATE WORKLOAD GROUP group_name  
        [ WITH  
            ( [ IMPORTANCE = { LOW | MEDIUM | HIGH } ]  
              [ [ , ] REQUEST_MAX_MEMORY_GRANT_PERCENT = value ]  
              [ [ , ] REQUEST_MAX_CPU_TIME_SEC = value ]  
              [ [ , ] REQUEST_MEMORY_GRANT_TIMEOUT_SEC = value ]   
              [ [ , ] MAX_DOP = value ]  
              [ [ , ] GROUP_MAX_REQUESTS = value ] )  
         ]  
        [ USING {   
            [ pool_name | "default" ]    
            [ [ , ] EXTERNAL external_pool_name | "default" ] ]   
            } ]  
        [ ; ]  
        */


        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-xml-index-transact-sql
        /*
        Create XML Index   
        CREATE [ PRIMARY ] XML INDEX index_name   
            ON <object> ( xml_column_name )  
            [ USING XML INDEX xml_index_name   
                [ FOR { VALUE | PATH | PROPERTY } ] ]  
            [ WITH ( <xml_index_option> [ ,...n ] ) ]  
        [ ; ]  

        <object> ::=  
        {  
            [ database_name. [ schema_name ] . | schema_name. ]   
            table_name  
        }  

        <xml_index_option> ::=  
        {   
            PAD_INDEX  = { ON | OFF }  
          | FILLFACTOR = fillfactor  
          | SORT_IN_TEMPDB = { ON | OFF }  
          | IGNORE_DUP_KEY = OFF  
          | DROP_EXISTING = { ON | OFF }  
          | ONLINE = OFF  
          | ALLOW_ROW_LOCKS = { ON | OFF }  
          | ALLOW_PAGE_LOCKS = { ON | OFF }  
          | MAXDOP = max_degree_of_parallelism  
        } 
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-xml-index-selective-xml-indexes
        /*
        CREATE XML INDEX index_name  
            ON <table_object> ( xml_column_name )  
            USING XML INDEX sxi_index_name  
            FOR ( <xquery_or_sql_values_path> )  
            [WITH ( <index_options> )]  

        <table_object> ::=   
        { [database_name. [schema_name ] . | schema_name. ] table_name }  

        <xquery_or_sql_values_path>::=   
        <path_name>   

        <path_name> ::=   
        character string literal  

        <xmlnamespace_list> ::=   
        <xmlnamespace_item> [, <xmlnamespace_list>]  

        <xmlnamespace_item> ::=   
        xmlnamespace_uri AS xmlnamespace_prefix  

        <index_options> ::=   
        (    
          | PAD_INDEX  = { ON | OFF }  
          | FILLFACTOR = fillfactor  
          | SORT_IN_TEMPDB = { ON | OFF }  
          | IGNORE_DUP_KEY = OFF  
          | DROP_EXISTING = { ON | OFF }  
          | ONLINE = OFF  
          | ALLOW_ROW_LOCKS = { ON | OFF }  
          | ALLOW_PAGE_LOCKS = { ON | OFF }  
          | MAXDOP = max_degree_of_parallelism  
        )  
        */

        //https://docs.microsoft.com/en-us/sql/t-sql/statements/create-xml-schema-collection-transact-sql
        //CREATE XML SCHEMA COLLECTION [ <relational_schema>. ]sql_identifier AS Expression  



        /*
         https://msdn.microsoft.com/en-us/library/ff848799.aspx
        >ALTER Statements
            AlterApplicationWith()
        >CREATE Statements
        >DROP Statements
        
        RENAME
        UPDATE STATISTICS

        TRUNCATE TABLE
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
        public static Clause<Non> CreateTreggerOn(string name, TriggerTargetBase target) => throw new InvalitContextException(nameof(CreateTreggerOn));

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
        public static Clause<T> CreateTreggerOn<T>(Clause<T> before, string name, TriggerTargetBase target) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// WITH
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <param name="option">option.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> With(params DDLTriggerOptionBase[] option) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// WITH
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="option">option.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> With<T>(Clause<T> before, params DDLTriggerOptionBase[] option) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// ENCRYPTION
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <returns>IDDLTriggerOption</returns>
        [ClauseStyleConverter]
        public static DDLTriggerOptionBase Encryption() => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// EXECUTE AS CLAUSE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <returns>IDDLTriggerOption</returns>
        [ClauseStyleConverter(Name = "EXECUTE AS CLAUSE")]
        public static DDLTriggerOptionBase ExecuteAsClause() => throw new InvalitContextException(nameof(ExecuteAsClause));

        /// <summary>
        /// DATABASE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <returns>IDDLTriggerOption</returns>
        [ClauseStyleConverter]
        public static TriggerTargetBase DataBase() => throw new InvalitContextException(nameof(ExecuteAsClause));

        /// <summary>
        /// ALL SERVER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/create-trigger-transact-sql
        /// </summary>
        /// <returns>IDDLTriggerOption</returns>
        [ClauseStyleConverter(Name = "ALL SERVER")]
        public static TriggerTargetBase AllServer() => throw new InvalitContextException(nameof(ExecuteAsClause));

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
