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
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc"></typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(TopElement top, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, TopElement top, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select(AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select<TSrc>(this Clause<TSrc> before, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select(TopElement top, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select<TSrc>(this Clause<TSrc> before, TopElement top, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(TopElement top, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, TopElement top, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AggregatePredicateElement predicate, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AggregatePredicateElement predicate, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AggregatePredicateElement predicate, TopElement top, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="selected">Specify a new expression to represent the selection.</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AggregatePredicateElement predicate, TopElement top, T selected) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select(AggregatePredicateElement predicate, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select<TSrc>(this Clause<TSrc> before, AggregatePredicateElement predicate, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AggregatePredicateElement predicate, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AggregatePredicateElement predicate, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select(AggregatePredicateElement predicate, TopElement top, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<Non> Select<TSrc>(this Clause<TSrc> before, AggregatePredicateElement predicate, TopElement top, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<T>(AggregatePredicateElement predicate, TopElement top, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// SELECT clause.
        /// </summary>
        /// <typeparam name="TSrc">If there is a Select clause before, it is the type selected there. Normally, the Select clause does not exist before the Select clause, and object is specified.</typeparam>
        /// <typeparam name="T">Type of selected.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="predicate">ALL or DISTINCT.</param>
        /// <param name="top">TOP keyword.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Clause.</returns>
        [SelectConverter]
        public static Clause<T> Select<TSrc, T>(this Clause<TSrc> before, AggregatePredicateElement predicate, TopElement top, AsteriskElement<T> asterisk) { throw new InvalitContextException(nameof(Select)); }

        /// <summary>
        /// CASE clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Case() { throw new InvalitContextException(nameof(Case)); }

        /// <summary>
        /// CASE clause.
        /// </summary>
        /// <param name="target">It's target of CASE branch.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Case(object target) { throw new InvalitContextException(nameof(Case)); }

        /// <summary>
        /// CASE clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Case<T>() { throw new InvalitContextException(nameof(Case)); }

        /// <summary>
        /// CASE clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="target">It's target of CASE branch.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Case<T>(object target) { throw new InvalitContextException(nameof(Case)); }

        /// <summary>
        /// WHEN clause.
        /// </summary>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="expression">It is a conditional expression of the WHEN clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<Non> When(this Clause<Non> before, object expression) { throw new InvalitContextException(nameof(When)); }

        /// <summary>
        /// WHEN clause.
        /// </summary>
        /// <param name="expression">It is a conditional expression of the WHEN clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<Non> When(object expression) { throw new InvalitContextException(nameof(When)); }

        /// <summary>
        /// WHEN clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="expression">It is a conditional expression of the WHEN clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<T> When<T>(this Clause<T> before, object expression) { throw new InvalitContextException(nameof(When)); }

        /// <summary>
        /// THEN clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="result">It is an item to return to when the THEN clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<T> Then<T>(this Clause<Non> before, T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// THEN clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="result">It is an item to return to when the THEN clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<T> Then<T>(T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// THEN clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="result">It is an item to return to when the THEN clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<T> Then<T>(this Clause<T> before, T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// ELSE clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <param name="result">It is an item to return to when the ELSE clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<T> Else<T>(this Clause<T> before, T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// ELSE clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="result">It is an item to return to when the ELSE clause is valid.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Indent = 1)]
        public static Clause<T> Else<T>(T result) { throw new InvalitContextException(nameof(Then)); }

        /// <summary>
        /// END clause.
        /// </summary>
        /// <typeparam name="T">Type represented by CASE expression.</typeparam>
        /// <param name="before">It is an before expression in the CASE clause.</param>
        /// <returns>It is the result of CASE expression.</returns>
        [ClauseStyleConverter]
        public static T End<T>(this Clause<T> before) { throw new InvalitContextException(nameof(End)); }

        /// <summary>
        /// END clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> End() { throw new InvalitContextException(nameof(End)); }

        /// <summary>
        /// FROM clause.
        /// </summary>
        /// <param name="expressions">Table or subquery.</param>
        /// <returns>Clause.</returns>
        [FromConverter]
        public static Clause<Non> From(params object[] expressions) { throw new InvalitContextException(nameof(From)); }

        /// <summary>
        /// FROM clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="tables">Table or subquery.</param>
        /// <returns>Clause.</returns>
        [FromConverter]
        public static Clause<T> From<T>(this Clause<T> before, params object[] tables) { throw new InvalitContextException(nameof(From)); }

        /// <summary>
        /// JOIN clause.
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "JOIN")]
        public static Clause<Non> Join(object table, bool condition) { throw new InvalitContextException(nameof(Join)); }

        /// <summary>
        /// JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "JOIN")]
        public static Clause<T> Join<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(Join)); }

        /// <summary>
        /// JOIN clause.
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of LEFT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "LEFT JOIN")]
        public static Clause<Non> LeftJoin(object table, bool condition) { throw new InvalitContextException(nameof(LeftJoin)); }

        /// <summary>
        /// LEFT JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of LEFT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "LEFT JOIN")]
        public static Clause<T> LeftJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(LeftJoin)); }

        /// <summary>
        /// RIGHT JOIN clause.
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of RIGHT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "RIGHT JOIN")]
        public static Clause<Non> RightJoin(object table, bool condition) { throw new InvalitContextException(nameof(RightJoin)); }

        /// <summary>
        /// RIGHT JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>>
        /// <param name="condition">It is a condition of RIGHT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "RIGHT JOIN")]
        public static Clause<T> RightJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(RightJoin)); }

        /// <summary>
        /// FULL JOIN clause.
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of RIGHT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "FULL JOIN")]
        public static Clause<Non> FullJoin(object table, bool condition) { throw new InvalitContextException(nameof(FullJoin)); }

        /// <summary>
        /// FULL JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>>
        /// <param name="condition">It is a condition of RIGHT JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "FULL JOIN")]
        public static Clause<T> FullJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(FullJoin)); }

        /// <summary>
        /// CROSS JOIN clause.
        /// </summary>
        /// <param name="expression">Table or subquery.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "CROSS JOIN")]
        public static Clause<Non> CrossJoin(object expression) { throw new InvalitContextException(nameof(CrossJoin)); }

        /// <summary>
        /// CROSS JOIN clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "CROSS JOIN")]
        public static Clause<T> CrossJoin<T>(this Clause<T> before, object table) { throw new InvalitContextException(nameof(CrossJoin)); }

        /// <summary>
        /// WHERE clause.
        /// </summary>
        /// <param name="condition">It is a conditional expression of WHERE.</param>
        /// <returns>Clause.</returns>
        [ConditionClauseConverter(Name = "WHERE")]
        public static Clause<Non> Where(bool condition) { throw new InvalitContextException(nameof(Where)); }

        /// <summary>
        /// WHERE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">It is a conditional expression of WHERE.</param>
        /// <returns>Clause.</returns>
        [ConditionClauseConverter(Name = "WHERE")]
        public static Clause<T> Where<T>(this Clause<T> before, bool condition) { throw new InvalitContextException(nameof(Where)); }

        /// <summary>
        /// GROUP BY clause.
        /// </summary>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "GROUP BY")]
        public static Clause<Non> GroupBy(params object[] columns) { throw new InvalitContextException(nameof(GroupBy)); }

        /// <summary>
        /// GROUP BY clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "GROUP BY")]
        public static Clause<T> GroupBy<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(GroupBy)); }

        /// <summary>
        /// GROUP BY ROLLUP clause.
        /// </summary>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY ROLLUP")]
        public static Clause<Non> GroupByRollup(params object[] columns) { throw new InvalitContextException(nameof(GroupByRollup)); }

        /// <summary>
        /// GROUP BY ROLLUP clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY ROLLUP")]
        public static Clause<T> GroupByRollup<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(GroupByRollup)); }

        /// <summary>
        /// GROUP BY CUBE clause.
        /// </summary>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY CUBE")]
        public static Clause<Non> GroupByCube(params object[] columns) { throw new InvalitContextException(nameof(GroupByCube)); }

        /// <summary>
        /// GROUP BY CUBE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY CUBE")]
        public static Clause<T> GroupByCube<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(GroupByCube)); }

        /// <summary>
        /// GROUP BY GROUPING SETS clause.
        /// </summary>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY GROUPING SETS")]
        public static Clause<Non> GroupByGroupingSets(params object[] columns) { throw new InvalitContextException(nameof(GroupByGroupingSets)); }

        /// <summary>
        /// GROUP BY GROUPING SETS clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Specify the target column of GROUP BY.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "GROUP BY GROUPING SETS")]
        public static Clause<T> GroupByGroupingSets<T>(this Clause<T> before, params object[] columns) { throw new InvalitContextException(nameof(GroupByGroupingSets)); }

        /// <summary>
        /// HAVING clause.
        /// </summary>
        /// <param name="condition">It is a conditional expression of HAVING.</param>
        /// <returns>Clause.</returns>
        [ConditionClauseConverter(Name = "HAVING")]
        public static Clause<Non> Having(bool condition) { throw new InvalitContextException(nameof(Having)); }

        /// <summary>
        /// HAVING clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">It is a conditional expression of HAVING.</param>
        /// <returns>Clause.</returns>
        [ConditionClauseConverter(Name = "HAVING")]
        public static Clause<T> Having<T>(this Clause<T> before, bool condition) { throw new InvalitContextException(nameof(Having)); }

        /// <summary>
        /// ORDER BY clause.
        /// </summary>
        /// <param name="elements">Specify column and sort order. Asc(column) or Desc(column).</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ORDER BY |[<, >0]", FormatDirection = FormatDirection.Vertical, VanishIfEmptyParams = true)]
        public static Clause<OverElement> OrderBy(params OrderByElement[] elements) { throw new InvalitContextException(nameof(OrderBy)); }

        /// <summary>
        /// ORDER BY clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="elements">Specify column and sort order. Asc(column) or Desc(column).</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ORDER BY |[<, >1]", FormatDirection = FormatDirection.Vertical, VanishIfEmptyParams = true)]
        public static Clause<T> OrderBy<T>(this Clause<T> before, params OrderByElement[] elements) { throw new InvalitContextException(nameof(OrderBy)); }

        /// <summary>
        /// OFFSET count ROWS clause.
        /// </summary>
        /// <param name="count">Number of rows to acquire.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "OFFSET |[0] ROWS")]
        public static Clause<Non> OffsetRows(object count) { throw new InvalitContextException(nameof(OffsetRows)); }

        /// <summary>
        /// OFFSET count ROWS clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="count">Number of rows to acquire.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "OFFSET |[1] ROWS")]
        public static Clause<T> OffsetRows<T>(this Clause<T> before, object count) { throw new InvalitContextException(nameof(OffsetRows)); }

        /// <summary>
        /// FETCH NEXT count ROWS ONLY clause.
        /// </summary>
        /// <param name="count">Number of rows to acquire.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "FETCH NEXT |[0] ROWS ONLY")]
        public static Clause<Non> FetchNextRowsOnly(object count) { throw new InvalitContextException(nameof(FetchNextRowsOnly)); }

        /// <summary>
        /// FETCH NEXT count ROWS ONLY clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="count">Number of rows to acquire.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "FETCH NEXT |[1] ROWS ONLY")]
        public static Clause<T> FetchNextRowsOnly<T>(this Clause<T> before, object count) { throw new InvalitContextException(nameof(FetchNextRowsOnly)); }

        /// <summary>
        /// UNION clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Union() { throw new InvalitContextException(nameof(Union)); }

        /// <summary>
        /// UNION clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Union<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Union)); }

        /// <summary>
        /// UNION clause.
        /// </summary>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Union(AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Union)); }

        /// <summary>
        /// UNION clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Union<T>(this Clause<T> before, AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Union)); }

        /// <summary>
        /// INTERSECT clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Intersect() { throw new InvalitContextException(nameof(Intersect)); }

        /// <summary>
        /// INTERSECT clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Intersect<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Intersect)); }

        /// <summary>
        /// INTERSECT clause.
        /// </summary>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Intersect(AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Intersect)); }

        /// <summary>
        /// INTERSECT clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Intersect<T>(this Clause<T> before, AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Intersect)); }

        /// <summary>
        /// EXCEPT clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Except() { throw new InvalitContextException(nameof(Except)); }

        /// <summary>
        /// EXCEPT clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Except<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Except)); }

        /// <summary>
        /// EXCEPT clause.
        /// </summary>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Except(AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Except)); }

        /// <summary>
        /// EXCEPT clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="all">If isAll is true, add an ALL predicate.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Except<T>(this Clause<T> before, AggregatePredicateAllElement all) { throw new InvalitContextException(nameof(Except)); }

        /// <summary>
        /// MINUS clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Minus() { throw new InvalitContextException(nameof(Minus)); }

        /// <summary>
        /// MINUS clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Minus<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Minus)); }

        /// <summary>
        /// UPDATE clause.
        /// </summary>
        /// <param name="table">Table for UPDATE.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Update(object table) { throw new InvalitContextException(nameof(Update)); }

        /// <summary>
        /// SET clause.
        /// </summary>
        /// <param name="assigns">Assignment in the SET clause.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET |[<,>0]", FormatDirection = FormatDirection.Vertical)]
        public static Clause<Non> Set(params Assign[] assigns) { throw new InvalitContextException(nameof(Set)); }

        /// <summary>
        /// SET clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="assigns">Assignment in the SET clause.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "SET |[<,>1]", FormatDirection = FormatDirection.Vertical)]
        public static Clause<T> Set<T>(this Clause<T> before, params Assign[] assigns) { throw new InvalitContextException(nameof(Set)); }

        /// <summary>
        /// DELETE clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Delete() { throw new InvalitContextException(nameof(Delete)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <param name="table">Table for INSERT.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "INSERT INTO")]
        public static Clause<Non> InsertInto(object table) { throw new InvalitContextException(nameof(InsertInto)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <param name="table">Table for INSERT.</param>
        /// <param name="columns">It is a column that performs INSERT.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "INSERT INTO [0](|[#<, >1])")]
        public static Clause<Non> InsertInto(object table, params object[] columns) { throw new InvalitContextException(nameof(InsertInto)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <param name="values">It is the value to be Inserted.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<Non> Values(params object[] values) { throw new InvalitContextException(nameof(Values)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="values">It is the value to be Inserted.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<T> Values<T>(this Clause<T> before, params object[] values) { throw new InvalitContextException(nameof(Values)); }

        /// <summary>
        /// LIKE keyword.
        /// </summary>
        /// <param name="target">Target text.</param>
        /// <param name="pattern">Text that represents pattern matching.</param>
        /// <returns>If target matches the specified pattern, LIKE returns TRUE.</returns>
        [MethodFormatConverter(Format = "[0] LIKE |[1]")]
        public static bool Like(object target, object pattern) { throw new InvalitContextException(nameof(Like)); }

        /// <summary>
        /// BETWEEN keyword.
        /// </summary>
        /// <param name="target">Target of range check.</param>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maxmum value.</param>
        /// <returns>Returns TRUE if target is included in the range of min and max.</returns>
        [MethodFormatConverter(Format = "[0] BETWEEN |[1] AND [2]")]
        public static bool Between(object target, object min, object max) { throw new InvalitContextException(nameof(Between)); }

        /// <summary>
        /// IN keyword.
        /// </summary>
        /// <param name="target">Target of IN check.</param>
        /// <param name="canditates">Canditates.</param>
        /// <returns>Returns TRUE if target is included in the canditates represented by expression.</returns>
        [MethodFormatConverter(Format = "[0] IN(|[<, >1])")]
        public static bool In<T>(T target, params T[] canditates) { throw new InvalitContextException(nameof(In)); }

        /// <summary>
        /// ALL Keyword
        /// </summary>
        /// <typeparam name="T">Retunn type.</typeparam>
        /// <param name="sub">Sub query.</param>
        /// <returns>Sub query's selected value.</returns>
        [AllConverter]
        public static T All<T>(Clause<T> sub) { throw new InvalitContextException(nameof(All)); }

        /// <summary>
        /// ALL Keyword
        /// </summary>
        /// <typeparam name="T">Retunn type.</typeparam>
        /// <param name="sub">Sub query.</param>
        /// <returns>Sub query's selected value.</returns>
        [AllConverter]
        public static T All<T>(Sql<T> sub) { throw new InvalitContextException(nameof(All)); }

        /// <summary>
        /// EXISTS keyword.
        /// </summary>
        /// <param name="expression">Sub query.</param>
        /// <returns>Returns TRUE if there is at least one record returned by expression, FALSE otherwise.</returns>
        [ClauseStyleConverter]
        public static bool Exists(object expression) { throw new InvalitContextException(nameof(Exists)); }

        /// <summary>
        /// IS NULL clause.
        /// </summary>
        /// <param name="target"></param>
        /// <returns>IS NULL</returns>
        [MethodFormatConverter(Format = "[0] IS NULL|")]
        public static bool IsNull(object target) { throw new InvalitContextException(nameof(IsNull)); }

        /// <summary>
        /// IS NOT NULL clause.
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>IS NOT NULL</returns>
        [MethodFormatConverter(Format = "[0] IS NOT NULL|")]
        public static bool IsNotNull(object target) { throw new InvalitContextException(nameof(IsNull)); }

        //TODO test.
        /// <summary>
        /// WITH clause.
        /// </summary>
        /// <param name="subQuerys">sub querys.</param>
        /// <returns></returns>
        [WithConverter]
        public static Clause<Non> With(params Sql[] subQuerys) { throw new InvalitContextException(nameof(With)); }

        /// <summary>
        /// WITH clause.
        /// </summary>
        /// <typeparam name="T">Type representing argument of recursive part.</typeparam>
        /// <param name="args">Argument of recursive part.</param>
        /// <param name="subQuery">sub query.</param>
        /// <returns>Clause.</returns>
        [WithConverter]
        public static Clause<T> With<T>(SqlRecursiveArguments<T> args, Sql subQuery) { throw new InvalitContextException(nameof(With)); }

        /// <summary>
        /// RECURSIVE clause.
        /// </summary>
        /// <typeparam name="T">Type representing argument of recursive part.</typeparam>
        /// <param name="args">Argument of recursive part.</param>
        /// <returns>Class representing argument of recursive part.</returns>
        [RecursiveConverter]
        public static RecursiveArguments<T> Recursive<T>(T args) { throw new InvalitContextException(nameof(Recursive)); }

        /// <summary>
        /// CREATE TABLE clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CREATE TABLE [0](|[#$<,>1])", FormatDirection = FormatDirection.Vertical)]
        public static Clause<Non> CreateTable(object table, params TableDefinitionElement[] designer) { throw new InvalitContextException(nameof(CreateTable)); }

        /// <summary>
        /// CONSTRAINT clause.
        /// </summary>
        /// <param name="name">Constraint name.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "CONSTRAINT [!0]")]
        public static Clause<ConstraintElement> Constraint(string name) { throw new InvalitContextException(nameof(Constraint)); }

        /// <summary>
        /// PRIMARY KEY clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "PRIMARY KEY")]
        public static Clause<ConstraintElement> PrimaryKey() { throw new InvalitContextException(nameof(PrimaryKey)); }

        /// <summary>
        /// PRIMARY KEY clause.
        /// </summary>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "PRIMARY KEY")]
        public static Clause<ConstraintElement> PrimaryKey(params object[] columns) { throw new InvalitContextException(nameof(PrimaryKey)); }

        /// <summary>
        /// PRIMARY KEY clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "PRIMARY KEY", Indent = 1)]
        public static Clause<ConstraintElement> PrimaryKey(this Clause<ConstraintElement> before, params object[] columns) { throw new InvalitContextException(nameof(PrimaryKey)); }

        /// <summary>
        /// CHECK clause.
        /// </summary>
        /// <param name="condition">Condition.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<ConstraintElement> Check(bool condition) { throw new InvalitContextException(nameof(Check)); }

        /// <summary>
        /// CHECK clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">Condition.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<ConstraintElement> Check(this Clause<ConstraintElement> before, bool condition) { throw new InvalitContextException(nameof(Check)); }

        /// <summary>
        /// UNIQUE clause.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<ConstraintElement> Unique() { throw new InvalitContextException(nameof(Unique)); }

        /// <summary>
        /// UNIQUE clause.
        /// </summary>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<ConstraintElement> Unique(params object[] columns) { throw new InvalitContextException(nameof(Unique)); }

        /// <summary>
        /// UNIQUE clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<ConstraintElement> Unique(this Clause<ConstraintElement> before, params object[] columns) { throw new InvalitContextException(nameof(Unique)); }

        /// <summary>
        /// FOREIGN KEY clause.
        /// </summary>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "FOREIGN KEY")]
        public static Clause<ConstraintElement> ForeignKey(params object[] columns) { throw new InvalitContextException(nameof(ForeignKey)); }

        /// <summary>
        /// FOREIGN KEY clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Name = "FOREIGN KEY", Indent = 1)]
        public static Clause<ConstraintElement> ForeignKey(this Clause<ConstraintElement> before, params object[] columns) { throw new InvalitContextException(nameof(ForeignKey)); }

        /// <summary>
        /// NOT NULL
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "NOT NULL")]
        public static Clause<ConstraintElement> NotNull() { throw new InvalitContextException(nameof(NotNull)); }

        /// <summary>
        /// DEFAULT
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<ConstraintElement> Default(object value) { throw new InvalitContextException(nameof(Default)); }

        /// <summary>
        /// REFERENCES clause.
        /// </summary>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table.</param>
        /// <param name="columns">Columns.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "REFERENCES [1](|[<, >2])", Indent = 1)]
        public static Clause<ConstraintElement> References(this Clause<ConstraintElement> before, object table, params object[] columns) { throw new InvalitContextException(nameof(References)); }

        /// <summary>
        /// DROP TABLE clause.
        /// </summary>
        /// <param name="tables">Tables.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "DROP TABLE")]
        public static Clause<Non> DropTable(params object[] tables) { throw new InvalitContextException(nameof(DropTable)); }

        /// <summary>
        /// DROP DATABASE clause.
        /// </summary>
        /// <param name="name">DataBase name.</param>
        /// <returns>Clause chain. You can write SQL statements in succession, of course you can end it.</returns>
        [MethodFormatConverter(Format = "CREATE DATABASE [!0]")]
        public static Clause<Non> CreateDataBase(string name) { throw new InvalitContextException(nameof(CreateDataBase)); }

        /// <summary>
        /// DROP DATABASE clause.
        /// </summary>
        /// <param name="name">DataBase name.</param>
        /// <returns>Clause chain. You can write SQL statements in succession, of course you can end it.</returns>
        [MethodFormatConverter(Format = "DROP DATABASE [!0]")]
        public static Clause<Non> DropDataBase(string name) { throw new InvalitContextException(nameof(DropDataBase)); }

        /// <summary>
        /// ROWS.
        /// </summary>
        /// <param name="preceding">Preceding row count.</param>
        [MethodFormatConverter(Format = "ROWS [$0] PRECEDING")]
        public static OverElement Rows(long preceding) { throw new InvalitContextException(nameof(Rows)); }

        /// <summary>
        /// ROWS.
        /// </summary>
        /// <param name="preceding">Preceding row count.</param>
        /// <param name="following">Following row count.</param>
        [MethodFormatConverter(Format = "ROWS BETWEEN [$0] PRECEDING AND [$1] FOLLOWING")]
        public static OverElement Rows(long preceding, long following) { throw new InvalitContextException(nameof(Rows)); }

        /// <summary>
        /// PARTITION BY.
        /// </summary>
        /// <param name="columns">Specify column or expression.</param>
        [MethodFormatConverter(Format = "PARTITION BY|[<,>0]", FormatDirection = FormatDirection.Vertical)]
        public static OverElement PartitionBy(params object[] columns) { throw new InvalitContextException(nameof(PartitionBy)); }

        /// <summary>
        /// OVER
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "OVER(|[< >1])", FormatDirection = FormatDirection.Vertical)]
        public static T Over<T>(this T before, params OverElement[] args) { throw new InvalitContextException(nameof(Over)); }

        /// <summary>
        /// OVER
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "OVER(|[< >0])", FormatDirection = FormatDirection.Vertical)]
        public static OverReturnValue Over(params OverElement[] args) { throw new InvalitContextException(nameof(Over)); }

        /*
         * https://msdn.microsoft.com/en-au/library/ms184391.aspx
            COLLATE
         */

        /*
         * https://msdn.microsoft.com/en-au/library/ff848768.aspx
        BACKUP
        BACKUP CERTIFICATE
        BACKUP MASTER KEY
        BACKUP SERVICE MASTER KEY
        RESTORE Statements for Restoring, Recovering, and Managing Backups
        RESTORE MASTER KEY
        RESTORE SERVICE MASTER KEY
         */

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

        /*
        https://msdn.microsoft.com/en-us/library/ms181441.aspx
        CLOSE
        DEALLOCATE
        DECLARE CURSOR
        FETCH
        OPEN

        */

        /*
         https://msdn.microsoft.com/en-us/library/ff848799.aspx
        ALTER Statements
        BACKUP DATABASE (Parallel Data Warehouse)
        CREATE Statements
        DISABLE TRIGGER
        DROP Statements
        ENABLE TRIGGER
        RENAME
        RESTORE DATABASE (Parallel Data Warehouse)
        TRUNCATE TABLE
        UPDATE STATISTICS*/

        /*
         * https://msdn.microsoft.com/en-us/library/ff848766.aspx
        Aliasing (Azure SQL Data Warehouse, Parallel Data Warehouse)
        BULK INSERT
        DELETE
        EXPLAIN
        FROM
        Hints
        INSERT
        MERGE
        OPTION Clause
        OUTPUT Clause
        READTEXT
        Search Condition
        SELECT
        Subqueries (Azure SQL Data Warehouse, Parallel Data Warehouse)
        Table Value Constructor
        TOP
        UPDATE
        UPDATETEXT
        WHERE
        WITH common_table_expression
        WRITETEXT
        */



        //https://msdn.microsoft.com/en-us/library/ms188332.aspx
        //Execute

        //https://msdn.microsoft.com/en-us/library/ms190286.aspx
        /*
        AT TIME ZONE
        CASE
        NULLIF*/
        /// <summary>
        /// COALESCE function.
        /// </summary>
        /// <typeparam name="T">Type of parameter</typeparam>
        /// <param name="parameter">Parameter.</param>
        /// <returns>The first non-null value in the parameter.</returns>
        [MethodFormatConverter(Format = "COALESCE(|[<, >0])")]
        public static T Coalesce<T>(params T[] parameter) { throw new InvalitContextException(nameof(Coalesce)); }


        /*https://msdn.microsoft.com/en-us/library/ff848807.aspx
        Language Elements
        -- (Comment)
        Slash Star Comment
        CREATE DIAGNOSTICS SESSION
        NULL and UNKNOWN
        Transactions
        USE
         */

        //https://msdn.microsoft.com/en-us/library/ff848727.aspx
        /*
        Management Commands
        DBCC SHOW_STATISTICS
        CHECKPOINT
        DBCC
        KILL
        KILL QUERY NOTIFICATION SUBSCRIPTION
        KILL STATS JOB
        RECONFIGURE
        SHUTDOWN*/

        //https://msdn.microsoft.com/en-us/library/ms174986.aspx
        /*
        Operators
        Arithmetic Operators
        Assignment Operator
        Bitwise Operators
        Comparison Operators
        Compound Operators
        Logical Operators
        Scope Resolution Operator
        Set Operators
        String Operators
        Unary Operators
        Operator Precedence*/

        //https://msdn.microsoft.com/en-us/library/ms189523.aspx
        /*
        Predicates
        CONTAINS
        FREETEXT
        IS NULL*/

        //https://msdn.microsoft.com/en-us/library/ms176047.aspx
        //PRINT

        //https://msdn.microsoft.com/en-us/library/ms178592.aspx
        //RAISERROR

        //https://msdn.microsoft.com/en-us/library/5a3b7424-408e-4cb0-8957-667ebf4596fc
        /*Security Statements
        ADD SIGNATURE
        CLOSE MASTER KEY
        CLOSE SYMMETRIC KEY
        DENY
        EXECUTE AS
        EXECUTE AS Clause
        GRANT
        OPEN MASTER KEY
        OPEN SYMMETRIC KEY
        REVERT
        REVOKE
        SETUSER
        Azure SQL Data Warehouse and Parallel Data Warehouse Security Statements*/

        //https://msdn.microsoft.com/en-us/library/ff848765.aspx
        /*Service Broker Statements
        BEGIN CONVERSATION TIMER
        BEGIN DIALOG CONVERSATION
        END CONVERSATION
        GET CONVERSATION GROUP
        GET_TRANSMISSION_STATUS
        MOVE CONVERSATION
        RECEIVE
        SEND*/

        //https://msdn.microsoft.com/en-us/library/ms190356.aspx
        /*
        SET Statements
        SET ANSI_DEFAULTS
        SET ANSI_NULL_DFLT_OFF
        SET ANSI_NULL_DFLT_ON
        SET ANSI_NULLS
        SET ANSI_PADDING
        SET ANSI_WARNINGS
        SET ARITHABORT
        SET ARITHIGNORE
        SET CONCAT_NULL_YIELDS_NULL
        SET CONTEXT_INFO
        SET CURSOR_CLOSE_ON_COMMIT
        SET DATEFIRST
        SET DATEFORMAT
        SET DEADLOCK_PRIORITY
        SET FIPS_FLAGGER
        SET FMTONLY
        SET FORCEPLAN
        SET IDENTITY_INSERT
        SET IMPLICIT_TRANSACTIONS
        SET LANGUAGE
        SET LOCK_TIMEOUT
        SET NOCOUNT
        SET NOEXEC
        SET NUMERIC_ROUNDABORT
        SET OFFSETS
        SET PARSEONLY
        SET QUERY_GOVERNOR_COST_LIMIT
        SET QUOTED_IDENTIFIER
        SET REMOTE_PROC_TRANSACTIONS
        SET ROWCOUNT
        SET SHOWPLAN_ALL
        SET SHOWPLAN_TEXT
        SET SHOWPLAN_XML
        SET STATISTICS IO
        SET STATISTICS PROFILE
        SET STATISTICS TIME
        SET STATISTICS XML
        SET TEXTSIZE
        SET TRANSACTION ISOLATION LEVEL
        SET XACT_ABORT*/

        //https://msdn.microsoft.com/en-us/library/b2ca6791-3a07-4209-ba8e-2248a92dd738
        /*
        SQL Server Utilities Statements
        (Backslash)
        GO
        */


        //https://msdn.microsoft.com/en-us/library/b2ca6791-3a07-4209-ba8e-2248a92dd738
        /*SQL Server Utilities Statements
        (Backslash)
        GO
         */

        //https://msdn.microsoft.com/en-us/library/ff848780.aspx
        /*
         * System Stored Functions
        Always On Availability Groups Functions
        Change Data Capture Functions
        Change Tracking Functions
        Data Collector Functions
        Filestream and FileTable Functions
        Managed Backup Functions
        sys.fn_get_sql
        sys.fn_MSxe_read_event_stream
        sys.fn_stmt_sql_handle_from_sql_stmt
        sys.fn_validate_plan_guide
        sys.fn_xe_file_target_read_file
        sys.fn_db_backup_file_snapshots
        Full-Text Search and Semantic Search Functions
        System Metadata Functions
        System Security Functions
        System Trace Functions*/

        //https://msdn.microsoft.com/en-us/library/ms187961.aspx
        /*
         System Stored Procedures
        Temporal Table - sys.sp_cleanup_temporal_history
        PolyBase stored procedures - sp_polybase_leave_group
        Active Geo-Replication Stored Procedures
        Catalog Stored Procedures
        Change Data Capture Stored Procedures
        Cursor Stored Procedures
        Data Collector Stored Procedures
        Database Engine Stored Procedures
        Database Mail Stored Procedures
        Database Maintenance Plan Stored Procedures
        Distributed Queries Stored Procedures
        Filestream and FileTable Stored Procedures
        Firewall Rules Stored Procedures (Azure SQL Database)
        Full-Text Search and Semantic Search Stored Procedures
        General Extended Stored Procedures
        Log Shipping Stored Procedures
        Managed Backup Stored Procedures
        Management Data Warehouse Stored Procedures
        OLE Automation Stored Procedures
        Policy-Based Management Stored Procedures
        PolyBase stored procedures
        Query Store Stored Procedures
        Security Stored Procedures
        Snapshot Backup Stored Procedures
        Spatial Index Stored Procedures
        SQL Data Warehouse Stored Procedures
        SQL Server Agent Stored Procedures
        SQL Server Profiler Stored Procedures
        Stretch Database Extended Stored Procedures
        Temporal Table Stored Procedures
        XML Stored Procedures*/


        //https://msdn.microsoft.com/en-us/library/ms179932.aspx
        /*System Tables
        Mapping System Tables to System Views
        System Base Tables
        Backup and Restore Tables
        Change Data Capture Tables
        Database Maintenance Plan Tables
        Data-tier Application Tables
        Extended Events Tables
        Integration Services Tables
        Log Shipping Tables
        SQL Server Agent Tables*/

        //https://msdn.microsoft.com/en-us/library/dbba47d7-e08e-4435-b876-35dced1f325d
        /*
         * System Views
        Catalog Views
        Compatibility Views
        Data-tier Application Views
        Dynamic Management Views and Functions
        Information Schema Views
        Querying the SQL Server System Catalog FAQ
        Metadata Access, Isolation Levels, and Lock Hints*/

        //https://msdn.microsoft.com/en-us/library/ms174377.aspx
        /*Transaction Statements
        BEGIN DISTRIBUTED TRANSACTION
        BEGIN TRANSACTION
        COMMIT TRANSACTION
        COMMIT WORK
        ROLLBACK TRANSACTION
        ROLLBACK WORK
        SAVE TRANSACTION*/

        //https://msdn.microsoft.com/en-us/library/ff848809.aspx
        /*Variables
        SET @local_variable
        SELECT @local_variable
        DECLARE @local_variable*/

        //https://msdn.microsoft.com/en-us/library/dbba47d7-e08e-4435-b876-35dced1f325d
        /*
         XML Statements
        WITH XMLNAMESPACES
        xml_schema_namespace
        */
    }
}
