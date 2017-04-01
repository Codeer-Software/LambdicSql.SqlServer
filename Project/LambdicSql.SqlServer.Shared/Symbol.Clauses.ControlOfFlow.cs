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
        https://msdn.microsoft.com/en-us/library/ms174290.aspx
        BEGIN...END
        BREAK
        CONTINUE
        ELSE (IF...ELSE)
        END (BEGIN...END)
        GOTO
        IF...ELSE
        RETURN
        THROW
        TRY...CATCH
        WAITFOR
        WHILE*/        
        
        //https://msdn.microsoft.com/en-us/library/ms190286.aspx
        /*
        AT TIME ZONE
        NULLIF*/
    }
}
