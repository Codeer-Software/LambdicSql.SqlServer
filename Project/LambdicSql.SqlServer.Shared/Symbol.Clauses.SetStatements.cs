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
        //https://msdn.microsoft.com/en-us/library/ms190356.aspx
        /*
        Symbol.Clauses.SetStatements
        SET ANSI_DEFAULTS
        SET ANSI_NULL_DFLT_OFF
        SET ANSI_NULL_DFLT_ON
        SET ANSI_NULLS
        SET ANSI_PADDING
        SET ANSI_WARNINGS
        SET ARITHABORT
        SET ARITHIGNORE
        SET CONCAT_NULL_YIELDS_NULL
        SET CONTEXT_INFO
        SET CURSOR_CLOSE_ON_COMMIT
        SET DATEFIRST
        SET DATEFORMAT
        SET DEADLOCK_PRIORITY
        SET FIPS_FLAGGER
        SET FMTONLY
        SET FORCEPLAN
        SET IDENTITY_INSERT
        SET IMPLICIT_TRANSACTIONS
        SET LANGUAGE
        SET LOCK_TIMEOUT
        SET NOCOUNT
        SET NOEXEC
        SET NUMERIC_ROUNDABORT
        SET OFFSETS
        SET PARSEONLY
        SET QUERY_GOVERNOR_COST_LIMIT
        SET QUOTED_IDENTIFIER
        SET REMOTE_PROC_TRANSACTIONS
        SET ROWCOUNT
        SET SHOWPLAN_ALL
        SET SHOWPLAN_TEXT
        SET SHOWPLAN_XML
        SET STATISTICS IO
        SET STATISTICS PROFILE
        SET STATISTICS TIME
        SET STATISTICS XML
        SET TEXTSIZE
        SET TRANSACTION ISOLATION LEVEL
        SET XACT_ABORT*/
    }
}
