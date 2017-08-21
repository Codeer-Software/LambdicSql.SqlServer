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
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>;</returns>
        [ClauseStyleConverter(Name = ";")]
        public static Clause<T> Semicolon<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Semicolon)); }
        /*
         * https://msdn.microsoft.com/en-au/library/ms184391.aspx
            https://docs.microsoft.com/en-us/sql/t-sql/statements/collation-precedence-transact-sql
         */

        //https://docs.microsoft.com/en-us/sql/t-sql/language-elements/sql-server-utilities-statements-go
        public static Clause<Non> Go() => throw new InvalitContextException(nameof(Go));
        public static Clause<T> Go<T>(Clause<T> before) => throw new InvalitContextException(nameof(Go));

        //https://msdn.microsoft.com/en-us/library/ff848809.aspx
        /*Variables
        SET @local_variable
        SELECT @local_variable = も
        DECLARE @local_variable
            →これは・・・
         */

        /*
        XML Statements
        https://docs.microsoft.com/en-us/sql/t-sql/xml/xml-schema-namespace

        WITH XMLNAMESPACES
        https://docs.microsoft.com/en-us/sql/t-sql/xml/with-xmlnamespaces
        https://docs.microsoft.com/ja-jp/sql/relational-databases/xml/add-namespaces-to-queries-with-with-xmlnamespaces
         */


        //https://docs.microsoft.com/en-us/sql/t-sql/language-elements/raiserror-transact-sql
        //RAISERROR

        //https://docs.microsoft.com/en-us/sql/t-sql/xml/xml-schema-namespace
        [FuncStyleConverter]
        public static T Xml_Schema_Namespace<T>(string Relational_schema, string XML_schema_collection_name) => throw new InvalitContextException(nameof(Xml_Schema_Namespace));
        [FuncStyleConverter]
        public static T Xml_Schema_Namespace<T>(string Relational_schema, string XML_schema_collection_name, string url) => throw new InvalitContextException(nameof(Xml_Schema_Namespace));

        //https://docs.microsoft.com/en-us/sql/t-sql/language-elements/print-transact-sql
        public static Clause<Non> Print(string text) => throw new InvalitContextException(nameof(Print));
        public static Clause<Non> Print<T>(Clause<T> before, string text) => throw new InvalitContextException(nameof(Print));
        
        //https://docs.microsoft.com/en-us/sql/t-sql/queries/at-time-zone-transact-sql
        [ClauseStyleConverter(Name = "AT TIME ZONE")]
        public static Clause<Non> AtTimeZone(string timezone) => throw new InvalitContextException(nameof(AtTimeZone));
        [ClauseStyleConverter(Name = "AT TIME ZONE")]
        public static Clause<Non> AtTimeZone<T>(Clause<T> before, string timezone) => throw new InvalitContextException(nameof(AtTimeZone));

        //https://docs.microsoft.com/en-us/sql/t-sql/language-elements/nullif-transact-sql
        [FuncStyleConverter]
        public static T NULLIF<T>(T expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));
        [FuncStyleConverter]
        public static T NULLIF<T>(Clause<T> expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));
        [FuncStyleConverter]
        public static T NULLIF<T>(Clause<Non> expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));
        [FuncStyleConverter]
        public static T NULLIF<T>(Sql expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));
        [FuncStyleConverter]
        public static T NULLIF<T>(Sql<T> expression1, object expression2) => throw new InvalitContextException(nameof(NULLIF));
    }
}
