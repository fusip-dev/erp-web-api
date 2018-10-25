using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ORG.FSIP.ERP.Libraries.Reflection
{
    public static class MethodInfoExtension
    {
        public static MethodInfo GetMethod(this Type type, string name, int parameterCount)
        {
            return type.GetMethods().Single(method => method.Name == name && method.GetParameters().Length == parameterCount);
        }
    }
}
