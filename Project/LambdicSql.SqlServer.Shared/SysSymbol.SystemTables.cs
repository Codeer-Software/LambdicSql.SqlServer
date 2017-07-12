using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// SQL Server provides the following groups of system functions.
    /// </summary>
    public partial class SysSymbol
    {
        /// <summary>
        /// Contains one row for each Extended Events action that is mapped to a SQL Trace column ID. This table is stored in the master database, in the sys schema.
        /// </summary>
        [MemberTableConverter(Name = "sys.trace_xe_action_map")]
        public Table_trace_xe_action_map trace_xe_action_map => throw new InvalitContextException(nameof(trace_xe_action_map));
    }

    /// <summary>
    /// Contains one row for each Extended Events action that is mapped to a SQL Trace column ID. This table is stored in the master database, in the sys schema.
    /// </summary>
    public class Table_trace_xe_action_map
    {
        /// <summary>
        /// The ID of the SQL Trace column that is being mapped.
        /// </summary>
        public short trace_column_id { get; set; }

        /// <summary>
        /// The name of the Extended Events package where the mapped action resides.
        /// </summary>
        public string package_name { get; set; }

        /// <summary>
        /// The name of the Extended Events action that is mapped to the SQL Trace column.
        /// </summary>
        public string xe_action_name { get; set; }
    }
}
