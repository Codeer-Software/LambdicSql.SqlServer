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
        //https://docs.microsoft.com/en-us/sql/t-sql/statements/add-signature-transact-sql
        /*Security Statements
        ADD SIGNATURE
        CLOSE MASTER KEY
        CLOSE SYMMETRIC KEY
        DENY
        EXECUTE AS
        EXECUTE AS Clause
        GRANT
        OPEN MASTER KEY
        OPEN SYMMETRIC KEY
        REVERT
        REVOKE
        SETUSER
        Azure SQL Data Warehouse and Parallel Data Warehouse Security Statements*/

        //https://docs.microsoft.com/en-us/sql/t-sql/database-console-commands/database-console-commands
        /*
        Management Commands
        DBCC SHOW_STATISTICS
        CHECKPOINT
        DBCC
        KILL
        KILL QUERY NOTIFICATION SUBSCRIPTION
        KILL STATS JOB
        RECONFIGURE
        SHUTDOWN*/

    }
}
