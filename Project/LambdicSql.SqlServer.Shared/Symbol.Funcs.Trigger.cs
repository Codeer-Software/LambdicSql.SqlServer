using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
        /*
        COLUMNS_UPDATED
        EVENTDATA
        TRIGGER_NESTLEVEL
        UPDATE()*/

        /// <summary>
        /// COLUMNS_UPDATED function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/columns-updated-transact-sql
        /// </summary>
        /// <returns>varbinary</returns>
        [FuncStyleConverter]
        public static byte[] Columns_Updated() => throw new InvalitContextException(nameof(Columns_Updated));

        /// <summary>
        /// EVENTDATA function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/eventdata-transact-sql
        /// </summary>
        /// <returns>EVENTDATA returns a value of type xml</returns>
        [FuncStyleConverter]
        public static string Eventdata() => throw new InvalitContextException(nameof(Eventdata));

        /// <summary>
        /// TRIGGER_NESTLEVEL function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/trigger-nestlevel-transact-sql
        /// </summary>
        /// <returns>varbinary</returns>
        [FuncStyleConverter]
        public static int? Trigger_Nestlevel() => throw new InvalitContextException(nameof(Eventdata));
        public static int? Trigger_Nestlevel(object object_id) => throw new InvalitContextException(nameof(Eventdata));
        [MethodFormatConverter(Format = "TRIGGER_NESTLEVEL([0], [1], [$2])")]
        public static int? Trigger_Nestlevel(object object_id, string trigger_type) => throw new InvalitContextException(nameof(Eventdata));
        [MethodFormatConverter(Format = "TRIGGER_NESTLEVEL([0], [1], [$2], [$3])")]
        public static int? Trigger_Nestlevel(object object_id, string trigger_type, string trigger_event_category) => throw new InvalitContextException(nameof(Eventdata));
    }
}
