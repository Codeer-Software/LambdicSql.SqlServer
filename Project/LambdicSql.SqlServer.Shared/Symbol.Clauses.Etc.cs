using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Symbols.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// Use[using static LambdicSql.SqlServer.Symbol;], you can use to write natural SQL.
    /// </summary>
    public static partial class Symbol
    {
        /// <summary>
        /// sys
        /// </summary>
        public static SysSymbol Sys => throw new InvalitContextException(nameof(Sys));

        /// <summary>
        /// msdb
        /// </summary>
        public static MsdbSymbol Msdb => throw new InvalitContextException(nameof(Msdb));

        /// <summary>
        /// cdc
        /// </summary>
        public static CdcSymbols Cdc => throw new InvalitContextException(nameof(Cdc));

        //TODO
        /// <summary>
        /// ?
        /// </summary>
        public static Replication Replication => throw new InvalitContextException(nameof(Replication));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-tables/sysopentapes-transact-sql
        /// sysopentapes
        /// </summary>
        [MemberTableConverter(Name = "sysopentapes")]
        public static Table_sysopentapes Sysopentapes => throw new InvalitContextException(nameof(Sysopentapes));

        //TODO test, and return special type.
        /// <summary>
        /// MAX
        /// </summary>
        /// <returns>MAX</returns>
        [ClauseStyleConverter]
        public static int Max() => throw new InvalitContextException(nameof(Max));

        /// <summary>
        /// It's *.
        /// </summary>
        /// <typeparam name="TSelected">Type of selected.</typeparam>
        /// <param name="selected">The type you want to obtain with the SELECT clause. Usually you specify a table element.</param>
        /// <returns>*</returns>
        [ClauseStyleConverter(Name = "*")]
        public static AsteriskElement<TSelected> Asterisk<TSelected>(TSelected selected) { throw new InvalitContextException(nameof(Asterisk)); }

        /// <summary>
        /// It's *.
        /// </summary>
        /// <typeparam name="TSelected">Type of selected.</typeparam>
        /// <returns>*</returns>
        [ClauseStyleConverter(Name = "*")]
        public static AsteriskElement<TSelected> Asterisk<TSelected>() { throw new InvalitContextException(nameof(Asterisk)); }

        /// <summary>
        /// It's *.
        /// </summary>
        /// <returns>*</returns>
        [ClauseStyleConverter(Name = "*")]
        public static AsteriskElement Asterisk() { throw new InvalitContextException(nameof(Asterisk)); }

        /// <summary>
        /// ASC Keyword.
        /// </summary>
        /// <param name="target">target column.</param>
        /// <returns>ASC.</returns>
        [MethodFormatConverter(Format = "[0] ASC")]
        public static OrderByElement Asc(object target) { throw new InvalitContextException(nameof(Asc)); }

        /// <summary>
        /// DESC Keyword.
        /// </summary>
        /// <param name="target">target column.</param>
        /// <returns>DESC.</returns>
        [MethodFormatConverter(Format = "[0] DESC")]
        public static OrderByElement Desc(object target) { throw new InvalitContextException(nameof(Desc)); }

        /// <summary>
        /// TOP Keyword.
        /// </summary>
        /// <param name="count">Count.</param>
        /// <returns>TOP.</returns>
        [MethodFormatConverter(Format = "TOP [$0]")]
        public static TopElement Top(long count) { throw new InvalitContextException(nameof(Top)); }

        /// <summary>
        /// ALL Keyword
        /// </summary>
        /// <returns>ALL.</returns>
        [ClauseStyleConverter]
        public static AggregatePredicateAllElement All() { throw new InvalitContextException(nameof(All)); }

        /// <summary>
        /// DISTINCT Keyword.
        /// </summary>
        /// <returns>DISTINCT.</returns>
        [ClauseStyleConverter]
        public static AggregatePredicateElement Distinct() { throw new InvalitContextException(nameof(All)); }

        //@@@↓
        /// <summary>
        /// ;
        /// </summary>
        /// <returns>;</returns>
        [ClauseStyleConverter(Name = ";")]
        public static Clause<Non> Semicolon() { throw new InvalitContextException(nameof(Semicolon)); }

        /// <summary>
        /// ;
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>;</returns>
        [ClauseStyleConverter(Name = ";")]
        public static Clause<T> Semicolon<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Semicolon)); }

        /// <summary>
        /// COLLATE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/collation-precedence-transact-sql
        /// </summary>
        /// <param name="type">type.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "COLLATE [!0]")]
        public static Clause<ConstraintElement> Collate(string type) => throw new InvalitContextException(nameof(type));

        /// <summary>
        /// COLLATE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/collation-precedence-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="type">type.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "COLLATE [!1]")]
        public static Clause<T> Collate<T>(Clause<T> before, string type) => throw new InvalitContextException(nameof(type));

        /// <summary>
        /// COLLATE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/collation-precedence-transact-sql
        /// </summary>
        /// <param name="type">type.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "COLLATE [!0]")]
        public static Clause<ConstraintElement> Collate(OrderByElement type) => throw new InvalitContextException(nameof(type));

        /// <summary>
        /// COLLATE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/collation-precedence-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="type">type.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "COLLATE [!1]")]
        public static Clause<T> Collate<T>(Clause<T> before, OrderByElement type) => throw new InvalitContextException(nameof(type));

        /// <summary>
        /// GO.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/sql-server-utilities-statements-go
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Go() => throw new InvalitContextException(nameof(Go));

        /// <summary>
        /// GO.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/sql-server-utilities-statements-go
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Go<T>(Clause<T> before) => throw new InvalitContextException(nameof(Go));
        
        /// <summary>
        /// SELECT clause.
        /// https://msdn.microsoft.com/en-us/library/ff848809.aspx
        /// </summary>
        /// <param name="assign">@val = value</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Select(Assign assign) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// https://msdn.microsoft.com/en-us/library/ff848809.aspx
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="assign">@val = value</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Select<T>(this Clause<T> before, Assign assign) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// xml_schema_namespace.
        /// https://docs.microsoft.com/en-us/sql/t-sql/xml/xml-schema-namespace
        /// </summary>
        /// <param name="relational_schema">relational_schema.</param>
        /// <param name="xml_schema_collection_name">xml_schema_collection_name.</param>
        /// <returns>xml schema namespace.</returns>
        [MethodFormatConverter(Format = "xml_schema_namespace([$0], [$1])")]
        public static object Xml_Schema_Namespace(string relational_schema, string xml_schema_collection_name) => throw new InvalitContextException(nameof(Xml_Schema_Namespace));

        /// <summary>
        /// xml_schema_namespace.
        /// https://docs.microsoft.com/en-us/sql/t-sql/xml/xml-schema-namespace
        /// </summary>
        /// <param name="relational_schema">relational_schema.</param>
        /// <param name="xml_schema_collection_name">xml_schema_collection_name.</param>
        /// <param name="url">url.</param>
        /// <returns>xml schema namespace.</returns>
        [MethodFormatConverter(Format = "xml_schema_namespace([$0], [$1], [$2])")]
        public static object Xml_Schema_Namespace(string relational_schema, string xml_schema_collection_name, string url) => throw new InvalitContextException(nameof(Xml_Schema_Namespace));

        /// <summary>
        /// WITH XMLNAMESPACES.
        /// https://docs.microsoft.com/en-us/sql/relational-databases/xml/add-namespaces-to-queries-with-with-xmlnamespaces
        /// </summary>
        /// <param name="xml_namespace_uri">xml_namespace_uri.</param>
        /// <param name="xml_namespace_prefix">xml_namespace_prefix.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "WITH XMLNAMESPACES([$0] AS [!1])")]
        public static Clause<Non> WithXmlNameSpace(string xml_namespace_uri, string xml_namespace_prefix) => throw new InvalitContextException(nameof(WithXmlNameSpace));

        /// <summary>
        /// WITH XMLNAMESPACES.
        /// https://docs.microsoft.com/en-us/sql/relational-databases/xml/add-namespaces-to-queries-with-with-xmlnamespaces
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="xml_namespace_uri">xml_namespace_uri.</param>
        /// <param name="xml_namespace_prefix">xml_namespace_prefix.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "WITH XMLNAMESPACES([$1] AS [!2])")]
        public static Clause<T> WithXmlNameSpace<T>(Clause<T> before, string xml_namespace_uri, string xml_namespace_prefix) => throw new InvalitContextException(nameof(WithXmlNameSpace));

        /// <summary>
        /// RAISERROR.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/raiserror-transact-sql
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="variables">variables.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<Non> RaisError(string text, params object[] variables) => throw new InvalitContextException(nameof(RaiseError));

        /// <summary>
        /// RAISERROR.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/raiserror-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="text">text.</param>
        /// <param name="variables">variables.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<T> RaiseError<T>(Clause<T> before, string text, params object[] variables) => throw new InvalitContextException(nameof(RaiseError));

        /// <summary>
        /// PRINT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/print-transact-sql
        /// </summary>
        /// <param name="text">text.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Print(string text) => throw new InvalitContextException(nameof(Print));

        /// <summary>
        /// PRINT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/print-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="text">text.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Print<T>(Clause<T> before, string text) => throw new InvalitContextException(nameof(Print));

        /// <summary>
        /// AT TIME ZONE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/at-time-zone-transact-sql
        /// </summary>
        /// <param name="timezone">timezone.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "AT TIME ZONE")]
        public static Clause<Non> AtTimeZone(string timezone) => throw new InvalitContextException(nameof(AtTimeZone));

        /// <summary>
        /// AT TIME ZONE.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/at-time-zone-transact-sql
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="timezone">timezone.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "AT TIME ZONE")]
        public static Clause<Non> AtTimeZone<T>(Clause<T> before, string timezone) => throw new InvalitContextException(nameof(AtTimeZone));

        /// <summary>
        /// NULLIF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/nullif-transact-sql
        /// </summary>
        /// <typeparam name="T">expression result.</typeparam>
        /// <param name="expression1">expression1.</param>
        /// <param name="expression2">expression2.</param>
        /// <returns>Not null expression.</returns>
        [FuncStyleConverter]
        public static T NULLIF<T>(T expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));

        /// <summary>
        /// NULLIF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/nullif-transact-sql
        /// </summary>
        /// <typeparam name="T">expression result.</typeparam>
        /// <param name="expression1">expression1.</param>
        /// <param name="expression2">expression2.</param>
        /// <returns>Not null expression.</returns>
        [FuncStyleConverter]
        public static T NULLIF<T>(Clause<T> expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));

        /// <summary>
        /// NULLIF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/nullif-transact-sql
        /// </summary>
        /// <param name="expression1">expression1.</param>
        /// <param name="expression2">expression2.</param>
        /// <returns>Not null expression.</returns>
        [FuncStyleConverter]
        public static object NULLIF(Clause<Non> expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));

        /// <summary>
        /// NULLIF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/nullif-transact-sql
        /// </summary>
        /// <param name="expression1">expression1.</param>
        /// <param name="expression2">expression2.</param>
        /// <returns>Not null expression.</returns>
        [FuncStyleConverter]
        public static object NULLIF(Sql expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));

        /// <summary>
        /// NULLIF.
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/nullif-transact-sql
        /// </summary>
        /// <typeparam name="T">expression result.</typeparam>
        /// <param name="expression1">expression1.</param>
        /// <param name="expression2">expression2.</param>
        /// <returns>Not null expression.</returns>
        [FuncStyleConverter]
        public static T NULLIF<T>(Sql<T> expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));
    }
}
