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
        //https://msdn.microsoft.com/en-us/library/5a3b7424-408e-4cb0-8957-667ebf4596fc
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

        //https://msdn.microsoft.com/en-us/library/ff848727.aspx
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
