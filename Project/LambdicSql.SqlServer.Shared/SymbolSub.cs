using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;

namespace LambdicSql.SqlServer
{
    /// <summary>
    /// TOP keyword.
    /// </summary>
    public abstract class TopElement { }

    /// <summary>
    /// Data type.
    /// </summary>
    public abstract class DataTypeElement { }

    /// <summary>
    /// It's *.
    /// Used in Select clause and Count function.
    /// </summary>
    public abstract class AsteriskElement { }

    /// <summary>
    /// It's *.
    /// Used in Select clause and Count function.
    /// </summary>
    /// <typeparam name="T">It represents the type to select when used in the Select clause.</typeparam>
    public abstract class AsteriskElement<T> : AsteriskElement { }

    /// <summary>
    /// It is an object representing the sort order
    /// Implemented classes include Asc and Desc.
    /// </summary>
    public abstract class OrderByElement { }

    /// <summary>
    /// Aggregation predicate.
    /// ALL or DISTINCT.
    /// </summary>
    public abstract class AggregatePredicateElement { }

    /// <summary>
    /// Aggregation predicate.
    /// ALL
    /// </summary>
    public abstract class AggregatePredicateAllElement : AggregatePredicateElement { }

    /// <summary>
    /// OVER clause argument.
    /// </summary>
    public abstract class OverElement { }

    /// <summary>
    /// OVER clause result.
    /// </summary>
    public abstract class OverReturnValue : SqlExpression
    {
        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static object operator +(object value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static string operator +(string value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static bool operator +(bool value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static bool? operator +(bool? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static byte operator +(byte value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static byte? operator +(byte? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static short operator +(short value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static short? operator +(short? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static int operator +(int value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static int? operator +(int? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static long operator +(long value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static long? operator +(long? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static float operator +(float value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static float? operator +(float? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static double operator +(double value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static double? operator +(double? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static decimal operator +(decimal value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static decimal? operator +(decimal? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static DateTime operator +(DateTime value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static DateTime? operator +(DateTime? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static DateTimeOffset operator +(DateTimeOffset value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static DateTimeOffset? operator +(DateTimeOffset? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static TimeSpan operator +(TimeSpan value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static TimeSpan? operator +(TimeSpan? value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static byte[] operator +(byte[] value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }

        /// <summary>
        /// Additional operator.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="returnValue">Return value.</param>
        /// <returns>Value.</returns>
        public static char[] operator +(char[] value, OverReturnValue returnValue) { throw new InvalitContextException("additional operator"); }
    }

    /// <summary>
    /// Table definition item.
    /// </summary>
    public abstract class TableDefinitionElement { }

    /// <summary>
    /// Constraint object.
    /// </summary>
    public abstract class ConstraintElement : TableDefinitionElement { }

    /// <summary>
    /// Column definition.
    /// It can only be used within lambda of the LambdicSql.
    /// </summary>
    public class Column : TableDefinitionElement
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="column">Column.</param>
        /// <param name="type">Type.</param>
        [NewFormatConverter(Format = "[0] [1]")]
        public Column(object column, DataTypeElement type) { throw new InvalitContextException("new " + nameof(Column)); }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="column">Column.</param>
        /// <param name="type">Type.</param>
        /// <param name="constraints">Constraints.</param>
        [NewFormatConverter(Format = "[0] [1] [< >2]")]
        public Column(object column, DataTypeElement type, params ConstraintElement[] constraints) { throw new InvalitContextException("new " + nameof(Column)); }
    }

    /// <summary>
    /// It represents assignment. It is used in the Set clause.
    /// new Assign(db.tbl_staff.name, name) -> tbl_staff.name = "@name"
    /// It can only be used within lambda of the LambdicSql.
    /// </summary>
    public class Assign
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="rhs">Rvalue</param>
        /// <param name="lhs">Lvalue</param>
        [NewFormatConverter(Format = "[#0] = [1]")]
        public Assign(object rhs, object lhs) { throw new InvalitContextException("new " + nameof(Assign)); }
    }

    /// <summary>
    /// ExpandArguments's result value.
    /// </summary>
    public abstract class ArgumentsExpandedObject { }

    /// <summary>
    /// The type of the element in the WITH clause of BULKINSERT.
    /// </summary>
    public abstract class BulkInsertWithElement { }

    /// <summary>
    /// DELAYED_DURABILITY's result value.展開するパラメータのインデックス
    /// </summary>
    public abstract class DelayedDurability { }

    /// <summary>
    /// Object when targeting non-table with CREATE TRIGGER.
    /// </summary>
    public abstract class TriggerTarget { }

    /// <summary>
    /// DDL trigger option.
    /// </summary>
    public abstract class DDLTriggerOption { }

    /// <summary>
    /// Query hint.
    /// </summary>
    public abstract class QueryHintElement { }

    /// <summary>
    /// Table hint.
    /// </summary>
    public abstract class TableHintElement
    {
        /// <summary>
        /// cast from ConstraintElement at implicit.
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator TableHintElement(ConstraintElement src) => throw new InvalitContextException("operator TableHintElement");

        /// <summary>
        /// cast from Clause&lt;ConstraintElement&gt; at implicit.
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator TableHintElement(Clause<ConstraintElement> src) => throw new InvalitContextException("operator TableHintElement");

        /// <summary>
        /// cast from BulkInsertWithElement at implicit.
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator TableHintElement(BulkInsertWithElement src) => throw new InvalitContextException("operator TableHintElement");

        /// <summary>
        /// cast from (Clause&lt;BulkInsertWithElement&gt; at implicit.
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator TableHintElement(Clause<BulkInsertWithElement> src) => throw new InvalitContextException("operator TableHintElement");
    }
}
