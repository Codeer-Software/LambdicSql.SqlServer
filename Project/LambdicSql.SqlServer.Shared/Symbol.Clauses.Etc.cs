using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.Specialized.SymbolConverters;
using System;

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

        //@@@
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
            COLLATE
         */

        //https://msdn.microsoft.com/en-us/library/b2ca6791-3a07-4209-ba8e-2248a92dd738
        /*
        SQL Server Utilities Statements
        (Backslash)
        GO
        */

        //https://msdn.microsoft.com/en-us/library/ff848809.aspx
        /*Variables
        SET @local_variable
        SELECT @local_variable
        DECLARE @local_variable*/

        //https://msdn.microsoft.com/en-us/library/dbba47d7-e08e-4435-b876-35dced1f325d
        /*
         XML Statements
        WITH XMLNAMESPACES
        xml_schema_namespace
        */
        //https://msdn.microsoft.com/en-us/library/ms176047.aspx
        //PRINT

        //https://msdn.microsoft.com/en-us/library/ms178592.aspx
        //RAISERROR     

        //https://msdn.microsoft.com/en-us/library/ms190286.aspx
        /*
        AT TIME ZONE
        NULLIF*/
    }
}
