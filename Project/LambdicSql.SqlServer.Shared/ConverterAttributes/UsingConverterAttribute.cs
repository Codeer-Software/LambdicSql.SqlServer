using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System.Linq.Expressions;
using static LambdicSql.SqlServer.Inside.PartsUtils;

namespace LambdicSql.SqlServer.ConverterAttributes
{
    /// <summary>
    /// Converter forUSING clause conversion.
    /// </summary>
    public class UsingConverterAttribute : MethodConverterAttribute
    {
        ICode _nameCode = "USING".ToCode();

        /// <summary>
        /// Has top cluase
        /// </summary>
        public bool HasTop { get; set; }

        /// <summary>
        /// Has hint lcase
        /// </summary>
        public bool HasHints { get; set; }

        /// <summary>
        /// Convert expression to code.
        /// </summary>
        /// <param name="expression">Expression.</param>
        /// <param name="converter">Expression converter.</param>
        /// <returns>Parts.</returns>
        public override ICode Convert(MethodCallExpression expression, ExpressionConverter converter)
        {
            var startIndex = expression.SkipMethodChain(0);
            var table = FromConverterAttribute.ConvertTable(converter, expression.Arguments[startIndex]);
            return new HCode(new[] { _nameCode, table }) { Separator = " " };
        }
    }
}
