using LambdicSql.ConverterServices;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Server provides the following groups of msdb functions.
    /// </summary>
    public class MsdbSymbol
    {
        /// <summary>
        /// dbo
        /// </summary>
        public static DboSymbol Dbo => throw new InvalitContextException(nameof(Dbo));
    }
}
