using LambdicSql.BuilderServices.CodeParts;
using LambdicSql.SqlServer.MultiplatformCompatibe;
using System.Linq.Expressions;

namespace LambdicSql.SqlServer.Inside
{
    static class PartsUtils
    {
        internal static string GetIndent(int indent)
        {
            switch (indent)
            {
                case 0: return string.Empty;
                case 1: return "\t";
                case 2: return "\t\t";
                case 3: return "\t\t\t";
                case 4: return "\t\t\t\t";
                case 5: return "\t\t\t\t\t";
                case 6: return "\t\t\t\t\t\t";
                case 7: return "\t\t\t\t\t\t\t";
                case 8: return "\t\t\t\t\t\t\t\t";
                case 9: return "\t\t\t\t\t\t\t\t\t";
                case 10: return "\t\t\t\t\t\t\t\t\t\t";
            }

            var array = new char[indent];
            for (int i = 0; i < indent; i++)
            {
                array[i] = '\t';
            }
            return new string(array);
        }

        internal static int SkipMethodChain(this MethodCallExpression exp, int index)
        {
            if (exp.Arguments.Count == 0) return index;
            return typeof(Clause).IsAssignableFromEx(exp.Arguments[0].Type) ? index + 1 : index;
        }

        internal static HCode Arguments(params ICode[] args)
            => new HCode(args) { Separator = ", " };

        internal static ICode Blanket(params ICode[] args)
            => new AroundCode(Arguments(args), "(", ")");

        internal static HCode Func(ICode func, params ICode[] args)
            => Func(func, ", ", args);

        internal static HCode Clause(ICode clause, params ICode[] args)
        {
            var code = new HCode() { AddIndentNewLine = true, Separator = " " };
            code.Add(clause);
            code.AddRange(args);
            return code;
        }

        internal static HCode Line(params ICode[] args)
            => new HCode(args) { EnableChangeLine = false };

        internal static HCode LineSpace(params ICode[] args)
             => new HCode(args) { EnableChangeLine = false, Separator = " " };

        static HCode Func(ICode func, string separator, params ICode[] args)
        {
            var hArgs = new AroundCode(new HCode(args) { Separator = separator }, "", ")");
            return new HCode(Line(func, "(".ToCode()), hArgs) { AddIndentNewLine = true };
        }

        internal static SingleTextCode ToCode(this string src)
            => new SingleTextCode(src);
    }
}
