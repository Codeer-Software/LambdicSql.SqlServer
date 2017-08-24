using System;
using System.Reflection;

namespace LambdicSql.SqlServer.MultiplatformCompatibe
{
    static class ReflectionAdapter
    {
        internal static bool IsAssignableFromEx(this Type type, Type target)
            => type.GetTypeInfo().IsAssignableFrom(target.GetTypeInfo());

        public static Type[] GetGenericArgumentsEx(this Type type)
            => type.GenericTypeArguments;
    }
}
