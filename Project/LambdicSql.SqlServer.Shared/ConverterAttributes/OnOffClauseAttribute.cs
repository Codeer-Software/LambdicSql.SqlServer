using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System.Linq.Expressions;

namespace LambdicSql.SqlServer.ConverterAttributes
{
    /// <summary>
    /// SQL symbol converter attribute for ON-OFF Clauses.
    /// </summary>
    public class OnOffClauseAttribute : MethodConverterAttribute
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Convert expression to code.
        /// </summary>
        /// <param name="expression">Expression.</param>
        /// <param name="converter">Expression converter.</param>
        /// <returns>Parts.</returns>
        public override ICode Convert(MethodCallExpression expression, ExpressionConverter converter)
        {
            var isOn = (bool)converter.ConvertToObject(expression.Arguments[expression.Arguments.Count - 1]);
            return new SingleTextCode(Name + " " + (isOn ? "ON" : "OFF"));
        }
    }
}
