using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System.Collections.Generic;
using System.Linq.Expressions;
using static LambdicSql.SqlServer.Inside.PartsUtils;

namespace LambdicSql.SqlServer.ConverterAttributes
{
    /// <summary>
    /// Converter MERGE clause conversion.
    /// </summary>
    public class MergeConverterAttribute : MethodConverterAttribute
    {
        ICode _nameCode = "MERGE".ToCode();

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
            //TODO SkipMethodChain -> other
            var startIndex = expression.SkipMethodChain(0);
            var tabkeIndex = HasTop ? startIndex + 1 : startIndex;

            //top
            var codes = new List<ICode>();
            if (HasTop)
            {
                var top = converter.ConvertToCode(expression.Arguments[startIndex]);
                codes.Add(top);
            }

            //table
            var table = converter.ConvertToCode(expression.Arguments[tabkeIndex]);
            codes.Add(table);

            //hints
            if (HasHints)
            {
                var newArray = expression.Arguments[startIndex + 1] as NewArrayExpression;
                var hints = new ICode[newArray.Expressions.Count];
                int i = 0;
                foreach (var e in newArray.Expressions)
                {
                    hints[i++] = converter.ConvertToCode(e);
                }
                codes.Add(Func("WITH".ToCode(), hints));
            }
            
            var sub = FromConverterAttribute.GetSubQuery(expression.Arguments[tabkeIndex]);
            if (sub != null)
            {
                codes.Add(sub.ToCode());
            }

            return new VCode(codes) { Separator = " "};
        }
    }
}
