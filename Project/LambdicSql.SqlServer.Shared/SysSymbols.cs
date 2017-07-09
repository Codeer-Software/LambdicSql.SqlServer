using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.Specialized.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //@@@
    public class SysSymbols
    {
        /// <summary>
        /// sys.fn_hadr_backup_is_preferred_replica
        /// https://docs.microsoft.com/en-us/sql/relational-databases/system-functions/sys-fn-hadr-backup-is-preferred-replica-transact-sql
        /// </summary>
        /// <param name="dbname">db name</param>
        /// <returns>1 or 0.</returns>
        [FuncStyleConverter(Name = "sys.fn_hadr_backup_is_preferred_replica")]
        public int fn_hadr_backup_is_preferred_replica(string dbname) => throw new InvalitContextException(nameof(fn_hadr_backup_is_preferred_replica));
    }
}
