using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using LambdicSql.SqlServer.ConverterAttributes;

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

        //----@@@Å´-----

        /// <summary>
        /// INNER LOOP JOIN clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-join
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "INNER LOOP JOIN")]
        public static Clause<Non> InnerLoopJoin(object table, bool condition) { throw new InvalitContextException(nameof(InnerLoopJoin)); }

        /// <summary>
        /// INNER LOOP JOIN clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-join
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "INNER LOOP JOIN")]
        public static Clause<T> InnerLoopJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(InnerLoopJoin)); }

        /// <summary>
        /// INNER HASH JOIN clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-join
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "INNER HASH JOIN")]
        public static Clause<Non> InnerHashJoin(object table, bool condition) { throw new InvalitContextException(nameof(InnerHashJoin)); }

        /// <summary>
        /// INNER HASH JOIN clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-join
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "INNER HASH JOIN")]
        public static Clause<T> InnerHashJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(InnerHashJoin)); }

        /// <summary>
        /// INNER MERGE JOIN clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-join
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "INNER MERGE JOIN")]
        public static Clause<Non> InnerMergeJoin(object table, bool condition) { throw new InvalitContextException(nameof(InnerMergeJoin)); }

        /// <summary>
        /// INNER MERGE JOIN clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-join
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "INNER MERGE JOIN")]
        public static Clause<T> InnerMergeJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(InnerMergeJoin)); }

        /// <summary>
        /// INNER REMOTE JOIN clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-join
        /// </summary>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "INNER REMOTE JOIN")]
        public static Clause<Non> InnerRemoteJoin(object table, bool condition) { throw new InvalitContextException(nameof(InnerRemoteJoin)); }

        /// <summary>
        /// INNER REMOTE JOIN clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-join
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">Table or subquery.</param>
        /// <param name="condition">It is a condition of JOIN.</param>
        /// <returns>Clause.</returns>
        [JoinConverter(Name = "INNER REMOTE JOIN")]
        public static Clause<T> InnerRemoteJoin<T>(this Clause<T> before, object table, bool condition) { throw new InvalitContextException(nameof(InnerRemoteJoin)); }

        //----@@@Å™-----

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
        /// VALUES clause.
        /// </summary>
        /// <param name="values">It is the value to be Inserted.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<Non> Values(params object[] values) { throw new InvalitContextException(nameof(Values)); }

        /// <summary>
        /// VALUES clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="values">It is the value to be Inserted.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter(Indent = 1)]
        public static Clause<T> Values<T>(this Clause<T> before, params object[] values) { throw new InvalitContextException(nameof(Values)); }

        /// <summary>
        /// VALUES clause.
        /// </summary>
        /// <param name="values">It is the value to be Inserted.</param>
        /// <returns>Clause.</returns>
        [ValuesMultiConverter]
        public static Clause<Non> Values(params object[][] values) { throw new InvalitContextException(nameof(Values)); }

        /// <summary>
        /// VALUES clause.
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="values">It is the value to be Inserted.</param>
        /// <returns>Clause.</returns>
        [ValuesMultiConverter(ParamsIndex = 1)]
        public static Clause<T> Values<T>(this Clause<T> before, params object[][] values) { throw new InvalitContextException(nameof(Values)); }

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

        /// <summary>
        /// It becomes code which expanded T's property as argument. For example, data(a, b,c).
        /// </summary>
        /// <typeparam name="T">data type.</typeparam>
        /// <param name="data">data.</param>
        /// <returns>IArgumentsExpandedObject.</returns>
        [ExpandArgumentsConverter]
        public static ArgumentsExpandedObject ExpandArguments<T>(this Sql<T> data) => throw new InvalitContextException(nameof(ExpandArguments));

        /// <summary>
        /// AS
        /// </summary>
        /// <typeparam name="T">before type.</typeparam>
        /// <param name="before">AS clause before.</param>
        /// <param name="expression">As clause after expression.</param>
        /// <returns>T</returns>
        [ClauseStyleConverter]
        public static T As<T>(this T before, object expression) => throw new InvalitContextException(nameof(As));

        /// <summary>
        /// WITH clause.
        /// </summary>
        /// <param name="expression">Argument of recursive part.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> With(ArgumentsExpandedObject expression) => throw new InvalitContextException(nameof(With));

        /// <summary>
        /// ROWS.
        /// </summary>
        /// <param name="preceding">Preceding row count.</param>
        /// <returns>OverElement</returns>
        [MethodFormatConverter(Format = "ROWS [$0] PRECEDING")]
        public static OverElement Rows(long preceding) { throw new InvalitContextException(nameof(Rows)); }

        /// <summary>
        /// ROWS.
        /// </summary>
        /// <param name="preceding">Preceding row count.</param>
        /// <param name="following">Following row count.</param>
        /// <returns>OverElement</returns>
        [MethodFormatConverter(Format = "ROWS BETWEEN [$0] PRECEDING AND [$1] FOLLOWING")]
        public static OverElement Rows(long preceding, long following) { throw new InvalitContextException(nameof(Rows)); }

        /// <summary>
        /// PARTITION BY.
        /// </summary>
        /// <param name="columns">Specify column or expression.</param>
        /// <returns>OverElement</returns>
        [MethodFormatConverter(Format = "PARTITION BY|[<,>0]", FormatDirection = FormatDirection.Vertical)]
        public static OverElement PartitionBy(params object[] columns) { throw new InvalitContextException(nameof(PartitionBy)); }

        /// <summary>
        /// OVER
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="args"></param>
        /// <returns>T</returns>
        [MethodFormatConverter(Format = "OVER(|[< >1])", FormatDirection = FormatDirection.Vertical)]
        public static T Over<T>(this T before, params OverElement[] args) { throw new InvalitContextException(nameof(Over)); }

        /// <summary>
        /// OVER
        /// </summary>
        /// <param name="args"></param>
        /// <returns>OverReturnValue</returns>
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
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="args"></param>
        /// <returns>T</returns>
        [MethodFormatConverter(Format = "WITHIN GROUP(|[< >1])", FormatDirection = FormatDirection.Vertical)]
        public static T WithinGroup<T>(this T before, params OverElement[] args) { throw new InvalitContextException(nameof(Over)); }

        /// <summary>
        ///  WITHIN GROUP
        /// </summary>
        /// <param name="args"></param>
        /// <returns>OverReturnValue</returns>
        [MethodFormatConverter(Format = "WITHIN GROUP(|[< >0])", FormatDirection = FormatDirection.Vertical)]
        public static OverReturnValue WithinGroup(params OverElement[] args) { throw new InvalitContextException(nameof(Over)); }

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

        //@@@Å´
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
        public static Clause<Non> With(params BulkInsertWithElement[] defines) { throw new InvalitContextException(nameof(With)); }

        /// <summary>
        /// WITH clause.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="defines">defines.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<T> With<T>(this Clause<T> before, params BulkInsertWithElement[] defines) { throw new InvalitContextException(nameof(With)); }

        /// <summary>
        /// BATCHSIZE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="batch_size">batch_size.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "BATCHSIZE =")]
        public static BulkInsertWithElement BatchSize_Assign(long batch_size) => throw new InvalitContextException(nameof(BatchSize_Assign));

        /// <summary>
        /// CHECK_CONSTRAINTS
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static BulkInsertWithElement Check_Constraints() => throw new InvalitContextException(nameof(Check_Constraints));

        /// <summary>
        /// CODEPAGE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="page">page.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "CODEPAGE =")]
        public static BulkInsertWithElement CodePage_Assign(string page) => throw new InvalitContextException(nameof(CodePage_Assign));

        /// <summary>
        /// DATAFILETYPE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="type">type.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "DATAFILETYPE =")]
        public static BulkInsertWithElement DataFileType_Assign(string type) => throw new InvalitContextException(nameof(DataFileType_Assign));

        /// <summary>
        /// DATASOURCE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="data_source_name">data_source_name.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "DATASOURCE =")]
        public static BulkInsertWithElement DataSource_Assign(string data_source_name) => throw new InvalitContextException(nameof(DataSource_Assign));

        /// <summary>
        /// ERRORFILE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="file_name">file_name.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "ERRORFILE =")]
        public static BulkInsertWithElement ErrorFile_Assign(string file_name) => throw new InvalitContextException(nameof(ErrorFile_Assign));

        /// <summary>
        /// ERRORFILE_DATASOURCE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="data_source_name">data_source_name.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "ERRORFILE_DATASOURCE =")]
        public static BulkInsertWithElement ErrorFile_DataSource_Assign(string data_source_name) => throw new InvalitContextException(nameof(ErrorFile_DataSource_Assign));

        /// <summary>
        /// FIRSTROW =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="first_row">first_row.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FIRSTROW =")]
        public static BulkInsertWithElement FirstRow_Assign(long first_row) => throw new InvalitContextException(nameof(FirstRow_Assign));

        /// <summary>
        /// FIRE_TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static BulkInsertWithElement Fire_Trigger() => throw new InvalitContextException(nameof(Fire_Trigger));

        /// <summary>
        /// FORMATFILE_DATASOURCE =
        /// </summary>
        /// <param name="data_source_name">data_source_name.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FORMATFILE_DATASOURCE =")]
        public static BulkInsertWithElement FormatFile_DataSource_Assign(string data_source_name) => throw new InvalitContextException(nameof(FormatFile_DataSource_Assign));

        /// <summary>
        /// KEEPIDENTITY
        /// BulkInsertWithElement cast to TableHintElement at implicit.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static BulkInsertWithElement KeepIdentity() => throw new InvalitContextException(nameof(KeepIdentity));

        /// <summary>
        /// KEEPNULLS
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static BulkInsertWithElement KeepNulls() => throw new InvalitContextException(nameof(KeepNulls));

        /// <summary>
        /// KILOBYTES_PER_BATCH =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="kilobytes_per_batch">kilobytes_per_batch.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "KILOBYTES_PER_BATCH =")]
        public static BulkInsertWithElement Kilobytes_Per_Batch_Assign(long kilobytes_per_batch) => throw new InvalitContextException(nameof(Kilobytes_Per_Batch_Assign));

        /// <summary>
        /// LASTROW =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="last_row">last_row.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "LASTROW =")]
        public static BulkInsertWithElement LastRow_Assign(long last_row) => throw new InvalitContextException(nameof(LastRow_Assign));

        /// <summary>
        /// MAXERRORS =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="max_errors">max_errors.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "MAXERRORS =")]
        public static BulkInsertWithElement MaxErrors_Assign(long max_errors) => throw new InvalitContextException(nameof(MaxErrors_Assign));

        /// <summary>
        /// ROWS_PER_BATCH =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="rows_per_batch">rows_per_batch.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "ROWS_PER_BATCH =")]
        public static BulkInsertWithElement Rows_Per_Batch_Assign(long rows_per_batch) => throw new InvalitContextException(nameof(Rows_Per_Batch_Assign));

        /// <summary>
        /// ROWTERMINATOR =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="row_terminator">row_terminator.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "ROWTERMINATOR =")]
        public static BulkInsertWithElement RowTerminator_Assign(string row_terminator) => throw new InvalitContextException(nameof(RowTerminator_Assign));

        /// <summary>
        /// TABLOCK
        /// BulkInsertWithElement cast to TableHintElement at implicit.
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter]
        public static BulkInsertWithElement TabLock() => throw new InvalitContextException(nameof(TabLock));

        /// <summary>
        /// FORMAT =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="format">format.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FORMAT =")]
        public static BulkInsertWithElement Format_Assign(string format) => throw new InvalitContextException(nameof(Format_Assign));

        /// <summary>
        /// FIELDQUOTE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="quote_characters">quote_characters.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FIELDQUOTE =")]
        public static BulkInsertWithElement FieldQuote_Assign(string quote_characters) => throw new InvalitContextException(nameof(FieldQuote_Assign));

        /// <summary>
        /// FORMATFILE =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="format_file_path">format_file_path.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FORMATFILE =")]
        public static BulkInsertWithElement FormatFile_Assign(string format_file_path) => throw new InvalitContextException(nameof(FormatFile_Assign));

        /// <summary>
        /// FIELDTERMINATOR =
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/bulk-insert-transact-sql
        /// </summary>
        /// <param name="field_terminator">field_terminator.</param>
        /// <returns>IBulkInsertWithElement.</returns>
        [ClauseStyleConverter(Name = "FIELDTERMINATOR =")]
        public static BulkInsertWithElement FieldTerminator_Assign(string field_terminator) => throw new InvalitContextException(nameof(FieldTerminator_Assign));

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

        /// <summary>
        /// OPTION
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/option-clause-transact-sql
        /// </summary>
        /// <param name="options">options.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<Non> Option(params QueryHintElement[] options) => throw new InvalitContextException(nameof(Option));

        /// <summary>
        /// OPTION
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/option-clause-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="options">options.</param>
        /// <returns>Clause.</returns>
        [FuncStyleConverter]
        public static Clause<T> Option<T>(this Clause<T> before, params QueryHintElement[] options) => throw new InvalitContextException(nameof(Option));

        /// <summary>
        /// OUTPUT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/output-clause-transact-sql
        /// </summary>
        /// <param name="elements">elements.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Output(params object[] elements) => throw new InvalitContextException(nameof(Output));

        /// <summary>
        /// OUTPUT.
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/output-clause-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="elements">elements.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Output<T>(this Clause<T> before, params object[] elements) => throw new InvalitContextException(nameof(Output));

        /// <summary>
        /// INSERTED
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/output-clause-transact-sql
        /// </summary>
        /// <typeparam name="T">inserted items type.</typeparam>
        /// <returns>INSERTED</returns>
        [ClauseStyleConverter]
        public static T Inserted<T>() => throw new InvalitContextException(nameof(Inserted));

        /// <summary>
        /// DELETED
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/output-clause-transact-sql
        /// </summary>
        /// <typeparam name="T">deleted items type.</typeparam>
        /// <returns>DELETED</returns>
        [ClauseStyleConverter]
        public static T Deleted<T>() => throw new InvalitContextException(nameof(Deleted));

        /// <summary>
        /// INSERTED.*
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/output-clause-transact-sql
        /// </summary>
        /// <returns>INSERTED.*</returns>
        [MethodFormatConverter(Format = "INSERTED.*")]
        public static AsteriskElement InsertedAsterisk() => throw new InvalitContextException(nameof(InsertedAsterisk));

        /// <summary>
        /// DELETED.*
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/output-clause-transact-sql
        /// </summary>
        /// <returns>DELETED.*</returns>
        [MethodFormatConverter(Format = "DELETED.*")]
        public static AsteriskElement DeletedAsterisk() => throw new InvalitContextException(nameof(DeletedAsterisk));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/output-clause-transact-sql
        /// </summary>
        /// <param name="elements">elements.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Into(params object[] elements) => throw new InvalitContextException(nameof(Into));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/output-clause-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="elements">elements.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> Into<T>(this Clause<T> before, params object[] elements) => throw new InvalitContextException(nameof(Into));

        /// <summary>
        /// DISABLE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/disable-trigger-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "DISABLE TRIGGER [!0] ON [1]")]
        public static Clause<Non> DisableTreggerOn(string name, object table) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// DISABLE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/disable-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">name.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "DISABLE TRIGGER [!1] ON [2]")]
        public static Clause<T> DisableTreggerOn<T>(this Clause<T> before, string name, object table) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// DISABLE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/disable-trigger-transact-sql
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="target">DataBase() or AllServer().</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "DISABLE TRIGGER [!0] ON [1]")]
        public static Clause<Non> DisableTreggerOn(string name, TriggerTarget target) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// DISABLE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/disable-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">name.</param>
        /// <param name="target">DataBase() or AllServer().</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "DISABLE TRIGGER [!1] ON [2]")]
        public static Clause<T> DisableTreggerOn<T>(this Clause<T> before, string name, TriggerTarget target) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// ENABLE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/enable-trigger-transact-sql
        /// </summary>
        /// <param name="name">trigger name.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ENABLE TRIGGER [!0] ON [1]")]
        public static Clause<Non> EnableTreggerOn(string name, object table) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// ENABLE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/enable-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">trigger name.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ENABLE TRIGGER [!1] ON [2]")]
        public static Clause<T> EnableTreggerOn<T>(this Clause<T> before, string name, object table) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// ENABLE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/enable-trigger-transact-sql
        /// </summary>
        /// <param name="name">trigger name.</param>
        /// <param name="target">DataBase() or AllServer().</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ENABLE TRIGGER [!0] ON [1]")]
        public static Clause<Non> EnableTreggerOn(string name, TriggerTarget target) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// ENABLE TRIGGER
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/enable-trigger-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="name">trigger name.</param>
        /// <param name="target">DataBase() or AllServer().</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "ENABLE TRIGGER [!1] ON [2]")]
        public static Clause<T> EnableTreggerOn<T>(this Clause<T> before, string name, TriggerTarget target) => throw new InvalitContextException(nameof(CreateTreggerOn));

        /// <summary>
        /// READTEXT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/readtext-transact-sql
        /// </summary>
        /// <param name="column">column.</param>
        /// <param name="text_ptr">text_ptr.</param>
        /// <param name="offset">offset.</param>
        /// <param name="size">size.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> ReadText(object column, object text_ptr, int offset, int size) => throw new InvalitContextException(nameof(ReadText));

        /// <summary>
        /// READTEXT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/readtext-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="column">column.</param>
        /// <param name="text_ptr">text_ptr.</param>
        /// <param name="offset">offset.</param>
        /// <param name="size">size.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> ReadText<T>(this Clause<T> before, object column, object text_ptr, int offset, int size) => throw new InvalitContextException(nameof(ReadText));

        /// <summary>
        /// WRITETEXT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/writetext-transact-sql
        /// </summary>
        /// <param name="column">column.</param>
        /// <param name="text_ptr">text_ptr.</param>
        /// <param name="data">data.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> WriteText(object column, object text_ptr, object data) => throw new InvalitContextException(nameof(WriteText));

        /// <summary>
        /// WRITETEXT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/writetext-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="column">column.</param>
        /// <param name="text_ptr">text_ptr.</param>
        /// <param name="data">data.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<T> WriteText<T>(this Clause<T> before, object column, object text_ptr, object data) => throw new InvalitContextException(nameof(WriteText));

        /// <summary>
        /// UPDATETEXT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/updatetext-transact-sql
        /// </summary>
        /// <param name="column">column.</param>
        /// <param name="text_ptr">text_ptr.</param>
        /// <param name="insert_offset">insert_offset.</param>
        /// <param name="delete_length">delete_length.</param>
        /// <param name="data">data.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> UpdateText(object column, object text_ptr, int? insert_offset, int? delete_length, object data) => throw new InvalitContextException(nameof(UpdateText));

        /// <summary>
        /// UPDATETEXT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/updatetext-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="column">column.</param>
        /// <param name="text_ptr">text_ptr.</param>
        /// <param name="insert_offset">insert_offset.</param>
        /// <param name="delete_length">delete_length.</param>
        /// <param name="data">data.</param>
        /// <returns>Clause.</returns>
        [ClauseStyleConverter]
        public static Clause<Non> UpdateText<T>(this Clause<T> before, object column, object text_ptr, int? insert_offset, int? delete_length, object data) => throw new InvalitContextException(nameof(UpdateText));

        /// <summary>
        /// PERCENT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/top-transact-sql
        /// </summary>
        /// <param name="src">Source TopElement.</param>
        /// <returns>TopElement.</returns>
        [ClauseStyleConverter]
        public static TopElement Percent(this TopElement src) => throw new InvalitContextException(nameof(Percent));

        /// <summary>
        /// WITH TIES 
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/top-transact-sql
        /// </summary>
        /// <param name="src">Source TopElement.</param>
        /// <returns>TopElement.</returns>
        [ClauseStyleConverter(Name = "WITH TIES ")]
        public static TopElement WithTies(this TopElement src) => throw new InvalitContextException(nameof(Percent));
        
        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [MergeConverter]
        public static Clause<Non> Merge<TData>(Sql<TData> table) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [MergeConverter]
        public static Clause<T> Merge<TData, T>(this Clause<T> before, Sql<TData> table) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="table">table.</param>
        /// <param name="tableHints">table hints.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasHints = true)]
        public static Clause<Non> Merge<TData>(Sql<TData> table, params TableHintElement[] tableHints) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">table.</param>
        /// <param name="tableHints">table hints.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasHints = true)]
        public static Clause<T> Merge<TData, T>(this Clause<T> before, Sql<TData> table, params TableHintElement[] tableHints) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="top"></param>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasTop = true)]
        public static Clause<Non> Merge<TData>(TopElement top, Sql<TData> table) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top"></param>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasTop = true)]
        public static Clause<T> Merge<TData, T>(this Clause<T> before, TopElement top, Sql<TData> table) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="top"></param>
        /// <param name="table">table.</param>
        /// <param name="tableHints">table hints.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasTop = true, HasHints = true)]
        public static Clause<Non> Merge<TData>(TopElement top, Sql<TData> table, params TableHintElement[] tableHints) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top"></param>
        /// <param name="table">table.</param>
        /// <param name="tableHints">table hints.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasTop = true, HasHints = true)]
        public static Clause<T> Merge<TData, T>(this Clause<T> before, TopElement top, Sql<TData> table, params TableHintElement[] tableHints) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [MergeConverter]
        public static Clause<Non> Merge<TData>(object table) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [MergeConverter]
        public static Clause<T> Merge<TData, T>(this Clause<T> before, object table) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="table">table.</param>
        /// <param name="tableHints">table hints.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasHints = true)]
        public static Clause<Non> Merge<TData>(object table, params TableHintElement[] tableHints) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">table.</param>
        /// <param name="tableHints">table hints.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasHints = true)]
        public static Clause<T> Merge<TData, T>(this Clause<T> before, object table, params TableHintElement[] tableHints) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="top"></param>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasTop = true)]
        public static Clause<Non> Merge<TData>(TopElement top, object table) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top"></param>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasTop = true)]
        public static Clause<T> Merge<TData, T>(this Clause<T> before, TopElement top, object table) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="top"></param>
        /// <param name="table">table.</param>
        /// <param name="tableHints">table hints.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasTop = true, HasHints = true)]
        public static Clause<Non> Merge<TData>(TopElement top, object table, params TableHintElement[] tableHints) => throw new InvalitContextException(nameof(Merge));

        /// <summary>
        /// MERGE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="top"></param>
        /// <param name="table">table.</param>
        /// <param name="tableHints">table hints.</param>
        /// <returns>Clause</returns>
        [MergeConverter(HasTop = true, HasHints = true)]
        public static Clause<T> Merge<TData, T>(this Clause<T> before, TopElement top, object table, params TableHintElement[] tableHints) => throw new InvalitContextException(nameof(Merge));
        
        /// <summary>
        /// USING
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [UsingConverter]
        public static Clause<Non> Uinsg<TData>(Sql<TData> table) => throw new InvalitContextException(nameof(Uinsg));

        /// <summary>
        /// USING
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [UsingConverter]
        public static Clause<T> Uinsg<TData, T>(this Clause<T> before, Sql<TData> table) => throw new InvalitContextException(nameof(Uinsg));

        /// <summary>
        /// USING
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Uinsg<TData>(ArgumentsExpandedObject table) => throw new InvalitContextException(nameof(Uinsg));

        /// <summary>
        /// USING
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="TData">data type.</typeparam>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="table">table.</param>
        /// <returns>Clause</returns>
        [ClauseStyleConverter]
        public static Clause<T> Uinsg<TData, T>(this Clause<T> before, ArgumentsExpandedObject table) => throw new InvalitContextException(nameof(Uinsg));

        /// <summary>
        /// ON
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <param name="condition">condition.</param>
        /// <returns>Clause</returns>
        [ConditionClauseConverter(IsFuncType = true)]
        public static Clause<Non> On(bool condition) => throw new InvalitContextException(nameof(On));

        /// <summary>
        /// ON
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">condition.</param>
        /// <returns>Clause</returns>
        [ConditionClauseConverter(IsFuncType = true)]
        public static Clause<T> On<T>(this Clause<T> before, bool condition) => throw new InvalitContextException(nameof(On));

        /// <summary>
        /// WHEN MATCHED
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <returns>Clause</returns>
        [ClauseStyleConverter(Name = "WHEN MATCHED")]
        public static Clause<Non> WhenMatched() => throw new InvalitContextException(nameof(WhenMatched));

        /// <summary>
        /// WHEN MATCHED
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause</returns>
        [ClauseStyleConverter(Name = "WHEN MATCHED")]
        public static Clause<T> WhenMatched<T>(this Clause<T> before) => throw new InvalitContextException(nameof(WhenMatched));

        /// <summary>
        /// WHEN MATCHED AND
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <param name="condition">condition.</param>
        /// <returns>Clause</returns>
        [ConditionClauseConverter(Name = "WHEN MATCHED AND")]
        public static Clause<Non> WhenMatchedAnd(bool condition) => throw new InvalitContextException(nameof(WhenMatchedAnd));

        /// <summary>
        /// WHEN MATCHED AND
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">condition.</param>
        /// <returns>Clause</returns>
        [ConditionClauseConverter(Name = "WHEN MATCHED AND")]
        public static Clause<T> WhenMatchedAnd<T>(this Clause<T> before, bool condition) => throw new InvalitContextException(nameof(WhenMatchedAnd));

        /// <summary>
        /// WHEN MATCHED BY SOURCE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <returns>Clause</returns>
        [ClauseStyleConverter(Name = "WHEN MATCHED")]
        public static Clause<Non> WhenMatchedBySource() => throw new InvalitContextException(nameof(WhenMatchedBySource));

        /// <summary>
        /// WHEN MATCHED BY SOURCE
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause</returns>
        [ClauseStyleConverter(Name = "WHEN MATCHED")]
        public static Clause<T> WhenMatchedBySource<T>(this Clause<T> before) => throw new InvalitContextException(nameof(WhenMatchedBySource));

        /// <summary>
        /// WHEN MATCHED BY SOURCE AND
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <param name="condition">condition.</param>
        /// <returns>Clause</returns>
        [ConditionClauseConverter(Name = "WHEN MATCHED BY SOURCE AND")]
        public static Clause<Non> WhenMatchedBySourceAnd(bool condition) => throw new InvalitContextException(nameof(WhenMatchedBySourceAnd));

        /// <summary>
        /// WHEN MATCHED BY SOURCE AND
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <param name="condition">condition.</param>
        /// <returns>Clause</returns>
        [ConditionClauseConverter(Name = "WHEN MATCHED BY SOURCE AND")]
        public static Clause<T> WhenMatchedBySourceAnd<T>(this Clause<T> before, bool condition) => throw new InvalitContextException(nameof(WhenMatchedBySourceAnd));

        /// <summary>
        /// THEN
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <returns>Clause</returns>
        [ClauseStyleConverter]
        public static Clause<Non> Then() => throw new InvalitContextException(nameof(Then));

        /// <summary>
        /// THEN
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <typeparam name="T">The type represented by before clause.</typeparam>
        /// <param name="before">It is the previous clause.</param>
        /// <returns>Clause</returns>
        [ClauseStyleConverter]
        public static Clause<T> Then<T>(this Clause<T> before) => throw new InvalitContextException(nameof(Then));

        /// <summary>
        /// INSERT
        /// https://docs.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql
        /// </summary>
        /// <param name="columns">columns</param>
        /// <returns>Clause</returns>
        [MethodFormatConverter(Format="[INSERT(#<, >])")]
        public static Clause<Non> Insert(params object[] columns) => throw new InvalitContextException(nameof(Insert));

        /// <summary>
        /// HASH GROUP  
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement HashGroup() => throw new InvalitContextException(nameof(HashGroup));

        /// <summary>
        /// ORDER GROUP  
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement OrderGroup() => throw new InvalitContextException(nameof(OrderGroup));

        /// <summary>
        ///  CONCAT UNION   
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement ConcatUnion() => throw new InvalitContextException(nameof(ConcatUnion));

        /// <summary>
        /// HASH UNION   
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement HashUnion() => throw new InvalitContextException(nameof(HashUnion));

        /// <summary>
        /// MERGE UNION   
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement MergeUnion() => throw new InvalitContextException(nameof(MergeUnion));

        /// <summary>
        /// LOOP JOIN   
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement LoopJoin() => throw new InvalitContextException(nameof(LoopJoin));

        /// <summary>
        /// MERGE JOIN   
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement MergeJoin() => throw new InvalitContextException(nameof(MergeJoin));

        /// <summary>
        /// HASH JOIN   
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement HashJoin() => throw new InvalitContextException(nameof(HashJoin));

        /// <summary>
        /// EXPAND VIEWS   
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement ExpandView() => throw new InvalitContextException(nameof(ExpandView));

        /// <summary>
        /// FAST 
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement Fast(long number_rows) => throw new InvalitContextException(nameof(Fast));

        /// <summary>
        /// FORCE ORDER
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement ForceOrder() => throw new InvalitContextException(nameof(ForceOrder));

        /// <summary>
        /// FORCE EXTERNALPUSHDOWN 
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement ForceExternalPushDown() => throw new InvalitContextException(nameof(ForceExternalPushDown));

        /// <summary>
        /// DISABLE EXTERNALPUSHDOWN 
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement DisableExternalPushDown() => throw new InvalitContextException(nameof(DisableExternalPushDown));

        /// <summary>
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// IGNORE_NONCLUSTERED_COLUMNSTORE_INDEX
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement Ignore_NonClusttred_ColumnStore_Index() => throw new InvalitContextException(nameof(Ignore_NonClusttred_ColumnStore_Index));

        /// <summary>
        /// KEEP PLAN
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement KeepPlan() => throw new InvalitContextException(nameof(KeepPlan));

        /// <summary>
        /// KEEPFIXED PLAN
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement KeepFixedPlan() => throw new InvalitContextException(nameof(KeepFixedPlan));

        /// <summary>
        /// MAX_GRANT_PERCENT =
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <param name="percent">percent.</param>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement Max_Grant_Percent_Assign(int percent) => throw new InvalitContextException(nameof(Max_Grant_Percent_Assign));

        /// <summary>
        /// MIN_GRANT_PERCENT =
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <param name="percent">percent.</param>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement Min_Grant_Percent(int percent) => throw new InvalitContextException(nameof(Min_Grant_Percent));

        /// <summary>
        /// MAXDOP
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <param name="number_of_processors">number_of_processors.</param>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement MaxDop(int number_of_processors) => throw new InvalitContextException(nameof(MaxDop));

        /// <summary>
        /// MAXRECURSION
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement MaxRecursion(int number) => throw new InvalitContextException(nameof(MaxRecursion));

        /// <summary>
        /// NO_PERFORMANCE_SPOOL
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement No_Performance_Spool() => throw new InvalitContextException(nameof(No_Performance_Spool));

        /// <summary>
        /// OPTIMIZE FOR
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement OptimizeFor(params object[] elements) => throw new InvalitContextException(nameof(OptimizeFor));

        /// <summary>
        /// UNKNOWN
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <param name="variable">variable.</param>
        /// <returns>Assign</returns>
        [MethodFormatConverter(Format= "[0] UNKNOWN")]
        public static Assign Unknown(this object variable) => throw new InvalitContextException(nameof(Unknown));

        /// <summary>
        /// OPTIMIZE FOR UNKNOWN
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement OptimizeForUnknown() => throw new InvalitContextException(nameof(OptimizeForUnknown));

        /// <summary>
        /// PARAMETERIZATION SIMPLE
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement ParameterizationSimple() => throw new InvalitContextException(nameof(ParameterizationSimple));

        /// <summary>
        /// PARAMETERIZATION FORCED
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement ParameterizationForced() => throw new InvalitContextException(nameof(ParameterizationForced));

        /// <summary>
        /// RECOMPILE
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement Recompile() => throw new InvalitContextException(nameof(Recompile));

        /// <summary>
        /// ROBUST PLAN
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement RobustPlan() => throw new InvalitContextException(nameof(RobustPlan));

        /// <summary>
        /// USE HINT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <param name="hintNames">int names.</param>
        /// <returns>QueryHintElement</returns>
        [FuncStyleConverter]
        public static QueryHintElement UseHint(params string[] hintNames) => throw new InvalitContextException(nameof(UseHint));

        /// <summary>
        /// USE PLAN
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <param name="xml_plan">xml_plan.</param>
        /// <returns>QueryHintElement</returns>
        [ClauseStyleConverter]
        public static QueryHintElement UsePlan(string xml_plan) => throw new InvalitContextException(nameof(UsePlan));

        /// <summary>
        /// TABLE HINT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-query
        /// </summary>
        /// <param name="exposed_object_name">exposed_object_name.</param>
        /// <param name="tableHints">table hints.</param>
        /// <returns>QueryHintElement</returns>
        [FuncStyleConverter]
        public static QueryHintElement TableHint(object exposed_object_name, params TableHintElement[] tableHints) => throw new InvalitContextException(nameof(TableHint));

        /// <summary>
        /// INDEX
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <param name="names">Index name.</param>
        /// <returns>Clause.</returns>
        [MethodFormatConverter(Format = "INDEX([!<, >0])")]
        public static Clause<ConstraintElement> Index(params string[] names) => null;

        /// <summary>
        /// FORCESEEK [( index_value ( index_column_name  [ ,... ] ) )
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <param name="index_value"></param>
        /// <param name="columns"></param>
        /// <returns>TableHintElement</returns>
        [MethodFormatConverter(Format = "FORCESEEK [!0]([<, >1])")]
        public static TableHintElement ForceSeek(string index_value, params object[] columns) => throw new InvalitContextException(nameof(ForceSeek));

        /// <summary>
        /// FORCESEEK
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement ForceSeek() => throw new InvalitContextException(nameof(ForceSeek));

        /// <summary>
        /// FORCESCAN
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement ForceScan() => throw new InvalitContextException(nameof(ForceScan));

        /// <summary>
        /// HOLDLOCK
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement HoldLock() => throw new InvalitContextException(nameof(HoldLock));

        /// <summary>
        /// NOLOCK
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement NoLock() => throw new InvalitContextException(nameof(NoLock));

        /// <summary>
        /// NOWAIT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement NoWait() => throw new InvalitContextException(nameof(NoWait));

        /// <summary>
        /// PAGLOCK
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement PagLock() => throw new InvalitContextException(nameof(PagLock));

        /// <summary>
        /// READCOMMITTED
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement ReadCommitted() => throw new InvalitContextException(nameof(ReadCommitted));

        /// <summary>
        /// READCOMMITTEDLOCK
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement ReadCommittedLock() => throw new InvalitContextException(nameof(ReadCommittedLock));

        /// <summary>
        /// READPAST
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement ReadPast() => throw new InvalitContextException(nameof(ReadPast));

        /// <summary>
        /// READUNCOMMITTED
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement ReadUnCommitted() => throw new InvalitContextException(nameof(ReadUnCommitted));

        /// <summary>
        /// REPEATABLEREAD
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement RepeaTableRead() => throw new InvalitContextException(nameof(RepeaTableRead));

        /// <summary>
        /// ROWLOCK
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement RowLock() => throw new InvalitContextException(nameof(RowLock));

        /// <summary>
        /// SERIALIZABLE
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement Serializable() => throw new InvalitContextException(nameof(Serializable));

        /// <summary>
        /// SNAPSHOT
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement Snapshot() => throw new InvalitContextException(nameof(Snapshot));

        /// <summary>
        /// SPATIAL_WINDOW_MAX_CELLS =
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <param name="count">count.</param>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement Spatial_Window_Max_Cells_Assign(int count) => throw new InvalitContextException(nameof(Spatial_Window_Max_Cells_Assign));

        /// <summary>
        /// TABLOCKX
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement TabLockX() => throw new InvalitContextException(nameof(TabLockX));

        /// <summary>
        /// UPDLOCK
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement UpdLock() => throw new InvalitContextException(nameof(UpdLock));

        /// <summary>
        /// XLOCK
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement XLock() => throw new InvalitContextException(nameof(XLock));

        /// <summary>
        /// KEEPDEFAULTS
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement KeepDefaults() => throw new InvalitContextException(nameof(KeepDefaults));

        /// <summary>
        /// IGNORE_CONSTRAINTS
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement Ignore_Constraints() => throw new InvalitContextException(nameof(Ignore_Constraints));

        /// <summary>
        /// IGNORE_TRIGGERS
        /// https://docs.microsoft.com/en-us/sql/t-sql/queries/hints-transact-sql-table
        /// </summary>
        /// <returns>TableHintElement</returns>
        [ClauseStyleConverter]
        public static TableHintElement Ignore_Triggers() => throw new InvalitContextException(nameof(Ignore_Triggers));
    }
}
