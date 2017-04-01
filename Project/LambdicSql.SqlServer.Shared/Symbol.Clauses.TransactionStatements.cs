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
        //https://msdn.microsoft.com/en-us/library/ms174377.aspx
        /*Symbol.Clauses.TransactionStatements
        BEGIN DISTRIBUTED TRANSACTION
        BEGIN TRANSACTION
        COMMIT TRANSACTION
        COMMIT WORK
        ROLLBACK TRANSACTION
        ROLLBACK WORK
        SAVE TRANSACTION*/
    }
}
