using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// PUBLISHINGSERVERNAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/replication-functions-publishingservername
        /// </summary>
        /// <returns>server name.</returns>
        [FuncStyleConverter]
        public static string PublishingServerName() => throw new InvalitContextException(nameof(PublishingServerName));
    }
}
