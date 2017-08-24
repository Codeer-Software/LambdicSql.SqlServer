using System;

namespace LambdicSql.SqlServer.MultiplatformCompatibe
{
    static class ReflectionAdapter
    {
        internal static bool IsAssignableFromEx(this Type type, Type target) => type.IsAssignableFrom(target);
        internal static Type[] GetGenericArgumentsEx(this Type type) => type.GetGenericArguments();
    }
}
