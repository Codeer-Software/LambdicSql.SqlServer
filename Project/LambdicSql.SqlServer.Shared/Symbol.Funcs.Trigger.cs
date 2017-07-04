using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    public static partial class Symbol
    {
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

        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/trigger-nestlevel-transact-sql
        /// <summary>
        /// TRIGGER_NESTLEVEL function.
        /// </summary>
        /// <param name="object_id"></param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static int? Trigger_Nestlevel(object object_id) => throw new InvalitContextException(nameof(Eventdata));

        /// <summary>
        /// TRIGGER_NESTLEVEL function.
        /// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/trigger-nestlevel-transact-sql
        /// </summary>
        /// <param name="object_id"></param>
        /// <param name="trigger_type"></param>
        /// <param name="trigger_event_category"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "TRIGGER_NESTLEVEL([0], [$1], [$2])")]
        public static int? Trigger_Nestlevel(object object_id, string trigger_type, string trigger_event_category) => throw new InvalitContextException(nameof(Eventdata));

        //TODO:Clauses.DML.Basic Same Name
        //Change:  public static Clause<bool> Update(object table) { throw new InvalitContextException(nameof(Update)); }
        ///// <summary>
        ///// Update function.
        ///// https://docs.microsoft.com/ja-jp/sql/t-sql/functions/update-trigger-functions-transact-sql
        ///// </summary>
        ///// <param name="column">Is the name of the column to test for either an INSERT or UPDATE action. Because the table name is specified in the ON clause of the trigger, do not include the table name before the column name.</param>
        ///// <returns>Boolean</returns>
        //[FuncStyleConverter]
        //public static bool Update(object column) => throw new InvalitContextException(nameof(Update));
    }
}
