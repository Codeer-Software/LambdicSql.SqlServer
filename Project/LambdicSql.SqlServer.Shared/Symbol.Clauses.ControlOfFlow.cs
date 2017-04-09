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
        /// <summary>
        /// IF clause.
        /// </summary>
        /// <param name="condition">condition.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> If(bool condition) { throw new InvalitContextException(nameof(If)); }

        /// <summary>
        /// Else clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Else<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Else)); }

        /*
        https://msdn.microsoft.com/en-us/library/ms174290.aspx
        BEGIN...END
        BREAK
        CONTINUE
        END (BEGIN...END)
        GOTO
        RETURN
        THROW
        TRY...CATCH
        WAITFOR
        WHILE*/
    }
}
