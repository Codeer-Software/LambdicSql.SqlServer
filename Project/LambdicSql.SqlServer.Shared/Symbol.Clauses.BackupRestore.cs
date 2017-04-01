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
        /*
         * https://msdn.microsoft.com/en-au/library/ff848768.aspx
        BACKUP
        BACKUP CERTIFICATE
        BACKUP MASTER KEY
        BACKUP SERVICE MASTER KEY
        RESTORE Statements for Restoring, Recovering, and Managing Backups
        RESTORE MASTER KEY
        RESTORE SERVICE MASTER KEY
        */
    }
}
