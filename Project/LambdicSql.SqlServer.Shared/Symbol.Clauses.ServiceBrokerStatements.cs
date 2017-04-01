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
        //https://msdn.microsoft.com/en-us/library/ff848765.aspx
        /*Symbol.Clause.ServiceBrokerStatements
        BEGIN CONVERSATION TIMER
        BEGIN DIALOG CONVERSATION
        END CONVERSATION
        GET CONVERSATION GROUP
        GET_TRANSMISSION_STATUS
        MOVE CONVERSATION
        RECEIVE
        SEND*/
    }
}
