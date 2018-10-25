using System;
using System.Reflection;

namespace ORG.FSIP.ERP.Libraries.Reflection
{
    public static class PropertyInfoExtension
    {
        public static bool HasProperty(this Type type, string propertyName)
        {
            return type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance) != null;
        }

        public static Type PropertyType(this Type type, string propertyName)
        {
            return type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance).PropertyType;
        }
                
    }
}
