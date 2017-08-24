using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;
using System;
using System.Linq.Expressions;
using static LambdicSql.SqlServer.Inside.PartsUtils;

namespace LambdicSql.SqlServer.ConverterAttributes
{
    /// <summary>
    /// Converter to use when there are multiple value combinations in the VALUE clause.
    /// </summary>
    public class ValuesMultiConverterAttribute : MethodConverterAttribute
    {
        /// <summary>
        /// Index of parameter to expand.
        /// </summary>
        public int ParamsIndex { get; set; }

        /// <summary>
        /// Convert expression to code.
        /// </summary>
        /// <param name="expression">Expression.</param>
        /// <param name="converter">Expression converter.</param>
        /// <returns>Parts.</returns>
        public override ICode Convert(MethodCallExpression expression, ExpressionConverter converter)
        {
            var newArray = expression.Arguments[ParamsIndex] as NewArrayExpression;
            ICode[] args;
            if (newArray != null)
            {
                args = new ICode[newArray.Expressions.Count];
                for (int i = 0; i < newArray.Expressions.Count; i++)
                {
                    var rowExp = newArray.Expressions[i];
                    ICode[] hcore;
                    var rowNewArray = rowExp as NewArrayExpression;
                    if (rowNewArray != null)
                    {
                        hcore = new ICode[rowNewArray.Expressions.Count];
                        for (int j = 0; j < rowNewArray.Expressions.Count; j++)
                        {
                            hcore[j] = converter.ConvertToCode(rowNewArray.Expressions[j]);
                        }
                    }
                    else
                    {
                        var row = converter.ConvertToObject(rowExp) as object[];
                        hcore = new ICode[row.Length];
                        for (int j = 0; j < row.Length; j++)
                        {
                            hcore[j] = converter.ConvertToCode(row[j]);
                        }
                    }
                    args[i] = Blanket(hcore);
                }
            }
            else
            {
                var datas = converter.ConvertToObject(expression.Arguments[ParamsIndex]) as object[][];
                args = new ICode[datas.Length];
                for (int i = 0; i < args.Length; i++)
                {
                    var row = datas[i];
                    var count = row.Length;
                    var hcore = new ICode[count];
                    for (int j = 0; j < count; j++)
                    {
                        hcore[j] = converter.ConvertToCode(row[j]);
                    }
                    args[i] = Blanket(hcore);
                }
            }
            return new HCode("VALUES".ToCode(), new VCode(args) { Separator = ", " }) { AddIndentNewLine = true, Indent = 1 };
        }
    }
}
