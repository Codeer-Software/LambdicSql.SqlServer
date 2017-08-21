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

        //@@@
        /// <summary>
        /// UPDATE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table for UPDATE.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Update<T>(this Clause<T> before, object table) { throw new InvalitContextException(nameof(Update)); }

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

        //@@@
        /// <summary>
        /// DELETE clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Delete<T>(this Clause<T> before) { throw new InvalitContextException(nameof(Delete)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <param name="table">Table for INSERT.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "INSERT INTO")]
        public static Clause<Non> InsertInto(object table) { throw new InvalitContextException(nameof(InsertInto)); }

        //@@@
        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table for INSERT.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "INSERT INTO")]
        public static Clause<T> InsertInto<T>(this Clause<T> before, object table) { throw new InvalitContextException(nameof(InsertInto)); }

        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <param name="table">Table for INSERT.</param>
        /// <param name="columns">It is a column that performs INSERT.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "INSERT INTO [0](|[#<, >1])")]
        public static Clause<Non> InsertInto(object table, params object[] columns) { throw new InvalitContextException(nameof(InsertInto)); }

        //@@@
        /// <summary>
        /// INSERT INTO clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table for INSERT.</param>
        /// <param name="columns">It is a column that performs INSERT.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "INSERT INTO [0](|[#<, >1])")]
        public static Clause<T> InsertInto<T>(this Clause<T> before, object table, params object[] columns) { throw new InvalitContextException(nameof(InsertInto)); }

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

        /// <summary>
        /// COALESCE function.
        /// </summary>
        /// <typeparam name="T">Type of parameter</typeparam>
        /// <param name="parameter">Parameter.</param>
        /// <returns>The first non-null value in the parameter.</returns>
        [MethodFormatConverter(Format = "COALESCE(|[<, >0])")]
        public static T Coalesce<T>(params T[] parameter) { throw new InvalitContextException(nameof(Coalesce)); }

        /// <summary>
        ///  WITHIN GROUP
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="before"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "WITHIN GROUP(|[< >1])", FormatDirection = FormatDirection.Vertical)]
        public static T WithinGroup<T>(this T before, params OverElement[] args) { throw new InvalitContextException(nameof(Over)); }

        /// <summary>
        ///  WITHIN GROUP
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [MethodFormatConverter(Format = "WITHIN GROUP(|[< >0])", FormatDirection = FormatDirection.Vertical)]
        public static OverReturnValue WithinGroup(params OverElement[] args) { throw new InvalitContextException(nameof(Over)); }

        //@@@
        /// <summary>
        /// BULK INSERT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="table">table.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BULK INSERT")]
        public static Clause<Non> BulkInsert(object table) { throw new InvalitContextException(nameof(BulkInsert)); }

        /// <summary>
        /// BULK INSERT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter(Name = "BULK INSERT")]
        public static Clause<Non> BulkInsert<T>(this Clause<T> before, object table) { throw new InvalitContextException(nameof(BulkInsert)); }

        /// <summary>
        /// WITH clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="defines">defines.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<Non> With(params IBulkInsertWithElement[] defines) { throw new InvalitContextException(nameof(With)); }

        /// <summary>
        /// WITH clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="defines">defines.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<T> With<T>(this Clause<T> before, params IBulkInsertWithElement[] defines) { throw new InvalitContextException(nameof(With)); }

        /// <summary>
        /// BATCHSIZE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="batch_size">batch_size.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "BATCHSIZE =")]
        public static IBulkInsertWithElement BatchSize_Assign(long batch_size) => throw new InvalitContextException(nameof(BatchSize_Assign));

        /// <summary>
        /// CHECK_CONSTRAINTS
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static IBulkInsertWithElement Check_Constraints() => throw new InvalitContextException(nameof(Check_Constraints));

        /// <summary>
        /// CODEPAGE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="page">page.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "CODEPAGE =")]
        public static IBulkInsertWithElement CodePage_Assign(string page) => throw new InvalitContextException(nameof(CodePage_Assign));

        /// <summary>
        /// DATAFILETYPE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="type">type.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "DATAFILETYPE =")]
        public static IBulkInsertWithElement DataFileType_Assign(string type) => throw new InvalitContextException(nameof(DataFileType_Assign));

        /// <summary>
        /// DATASOURCE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="data_source_name">data_source_name.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "DATASOURCE =")]
        public static IBulkInsertWithElement DataSource_Assign(string data_source_name) => throw new InvalitContextException(nameof(DataSource_Assign));

        /// <summary>
        /// ERRORFILE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="file_name">file_name.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "ERRORFILE =")]
        public static IBulkInsertWithElement ErrorFile_Assign(string file_name) => throw new InvalitContextException(nameof(ErrorFile_Assign));

        /// <summary>
        /// ERRORFILE_DATASOURCE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="data_source_name">data_source_name.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "ERRORFILE_DATASOURCE =")]
        public static IBulkInsertWithElement ErrorFile_DataSource_Assign(string data_source_name) => throw new InvalitContextException(nameof(ErrorFile_DataSource_Assign));

        /// <summary>
        /// FIRSTROW =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="first_row">first_row.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FIRSTROW =")]
        public static IBulkInsertWithElement FirstRow_Assign(long first_row) => throw new InvalitContextException(nameof(FirstRow_Assign));

        /// <summary>
        /// FIRE_TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static IBulkInsertWithElement Fire_Trigger() => throw new InvalitContextException(nameof(Fire_Trigger));

        /// <summary>
        /// FORMATFILE_DATASOURCE =
        /// </summary>
        /// <param name="data_source_name">data_source_name.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FORMATFILE_DATASOURCE =")]
        public static IBulkInsertWithElement FormatFile_DataSource_Assign(string data_source_name) => throw new InvalitContextException(nameof(FormatFile_DataSource_Assign));

        /// <summary>
        /// KEEPIDENTITY
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static IBulkInsertWithElement KeepIdentity() => throw new InvalitContextException(nameof(KeepIdentity));

        /// <summary>
        /// KEEPNULLS
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static IBulkInsertWithElement KeepNulls() => throw new InvalitContextException(nameof(KeepNulls));

        /// <summary>
        /// KILOBYTES_PER_BATCH =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="kilobytes_per_batch">kilobytes_per_batch.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "KILOBYTES_PER_BATCH =")]
        public static IBulkInsertWithElement Kilobytes_Per_Batch_Assign(long kilobytes_per_batch) => throw new InvalitContextException(nameof(Kilobytes_Per_Batch_Assign));

        /// <summary>
        /// LASTROW =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="last_row">last_row.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "LASTROW =")]
        public static IBulkInsertWithElement LastRow_Assign(long last_row) => throw new InvalitContextException(nameof(LastRow_Assign));

        /// <summary>
        /// MAXERRORS =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="max_errors">max_errors.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "MAXERRORS =")]
        public static IBulkInsertWithElement MaxErrors_Assign(long max_errors) => throw new InvalitContextException(nameof(MaxErrors_Assign));

        /// <summary>
        /// ROWS_PER_BATCH =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="rows_per_batch">rows_per_batch.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "ROWS_PER_BATCH =")]
        public static IBulkInsertWithElement Rows_Per_Batch_Assign(long rows_per_batch) => throw new InvalitContextException(nameof(Rows_Per_Batch_Assign));

        /// <summary>
        /// ROWTERMINATOR =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="row_terminator">row_terminator.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "ROWTERMINATOR =")]
        public static IBulkInsertWithElement RowTerminator_Assign(string row_terminator) => throw new InvalitContextException(nameof(RowTerminator_Assign));

        /// <summary>
        /// TABLOCK
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static IBulkInsertWithElement TabLock() => throw new InvalitContextException(nameof(TabLock));

        /// <summary>
        /// FORMAT =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="format">format.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FORMAT =")]
        public static IBulkInsertWithElement Format_Assign(string format) => throw new InvalitContextException(nameof(Format_Assign));

        /// <summary>
        /// FIELDQUOTE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="quote_characters">quote_characters.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FIELDQUOTE =")]
        public static IBulkInsertWithElement FieldQuote_Assign(string quote_characters) => throw new InvalitContextException(nameof(FieldQuote_Assign));

        /// <summary>
        /// FORMATFILE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="format_file_path">format_file_path.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FORMATFILE =")]
        public static IBulkInsertWithElement FormatFile_Assign(string format_file_path) => throw new InvalitContextException(nameof(FormatFile_Assign));

        /// <summary>
        /// FIELDTERMINATOR =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="field_terminator">field_terminator.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FIELDTERMINATOR =")]
        public static IBulkInsertWithElement FieldTerminator_Assign(string field_terminator) => throw new InvalitContextException(nameof(FieldTerminator_Assign));

        /// <summary>
        /// EXPLAIN.
        /// </summary>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Explain() => throw new InvalitContextException(nameof(Explain));

        /// <summary>
        /// EXPLAIN.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Explain<T>(this Clause<T>  before) => throw new InvalitContextException(nameof(Explain));

        /*
         * https://msdn.microsoft.com/en-us/library/ff848766.aspx
        OPTION Clause
        
        DISABLE TRIGGER
        https://docs.microsoft.com/en-us/sql/t-sql/statements/disable-trigger-transact-sql

        ENABLE TRIGGER
        https://docs.microsoft.com/en-us/sql/t-sql/statements/enable-trigger-transact-sql
            
        Table Value Constructor
            Å®Values 

        MERGE
        OUTPUT Clause
        READTEXT
        UPDATETEXT
        WRITETEXT
        */

        //@@@Å™

        /// <summary>
        /// EXEC
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/execute-transact-sql
        /// </summary>
        /// <typeparam name="T">expression result.</typeparam>
        /// <param name="expression">expression</param>
        /// <returns>expression result.</returns>
        [ClauseStyleConverter]
        public static T Exec<T>(T expression) => throw new InvalitContextException(nameof(Exec));

        /// <summary>
        /// EXEC
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/execute-transact-sql
        /// </summary>
        /// <typeparam name="T">expression result.</typeparam>
        /// <param name="expression">expression</param>
        /// <returns>expression result.</returns>
        [ClauseStyleConverter]
        public static T Exec<T>(Sql<T> expression) => throw new InvalitContextException(nameof(Exec));

        /// <summary>
        /// EXECUTE
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/execute-transact-sql
        /// </summary>
        /// <typeparam name="T">expression result.</typeparam>
        /// <param name="expression">expression</param>
        /// <returns>expression result.</returns>
        [ClauseStyleConverter]
        public static T Execute<T>(T expression) => throw new InvalitContextException(nameof(Execute));

        /// <summary>
        /// EXECUTE
        /// https://docs.microsoft.com/en-us/sql/t-sql/language-elements/execute-transact-sql
        /// </summary>
        /// <typeparam name="T">expression result.</typeparam>
        /// <param name="expression">expression</param>
        /// <returns>expression result.</returns>
        [ClauseStyleConverter]
        public static T Execute<T>(Sql<T> expression) => throw new InvalitContextException(nameof(Execute));
    }

    public interface IBulkInsertWithElement { }
}
