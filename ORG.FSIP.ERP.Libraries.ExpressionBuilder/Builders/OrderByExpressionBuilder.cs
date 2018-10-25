using ORG.FSIP.ERP.Libraries.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace ORG.FSIP.ERP.Libraries.ExpressionBuilder.Builders
{
    public static class OrderByExpressionBuilder
    {
        private static readonly MethodInfo OrderByMethod = typeof(Queryable).GetMethod("OrderBy", 2);

        private static readonly MethodInfo ThenByMethod = typeof(Queryable).GetMethod("ThenBy", 2);

        private static readonly MethodInfo OrderByDescendingMethod = typeof(Queryable).GetMethod("OrderByDescending", 2);

        private static readonly MethodInfo ThenByDescendingMethod = typeof(Queryable).GetMethod("ThenByDescending", 2);

        public static IQueryable<T> OrderByProperty<T>(this IQueryable<T> source, string propertyName, bool thenBy = false)
        {
            if (typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance) == null)
            {
                return null;
            }

            ParameterExpression paramterExpression = Expression.Parameter(typeof(T));
            Expression orderByProperty = Expression.Property(paramterExpression, propertyName);
            LambdaExpression lambda = Expression.Lambda(orderByProperty, paramterExpression);

            MethodInfo genericMethod = !thenBy
                ? OrderByMethod.MakeGenericMethod(typeof(T), orderByProperty.Type)
                : ThenByMethod.MakeGenericMethod(typeof(T), orderByProperty.Type);

            object result = genericMethod.Invoke(null, new object[] { source, lambda });

            return (IQueryable<T>)result;
        }

        public static IQueryable<T> OrderByPropertyDescending<T>(this IQueryable<T> source, string propertyName, bool thenBy = false)
        {
            if (typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance) == null)
            {
                return null;
            }

            ParameterExpression paramterExpression = Expression.Parameter(typeof(T));
            Expression orderByProperty = Expression.Property(paramterExpression, propertyName);
            LambdaExpression lambda = Expression.Lambda(orderByProperty, paramterExpression);

            MethodInfo genericMethod = !thenBy
                ? OrderByDescendingMethod.MakeGenericMethod(typeof(T), orderByProperty.Type)
                : ThenByDescendingMethod.MakeGenericMethod(typeof(T), orderByProperty.Type);

            object result = genericMethod.Invoke(null, new object[] { source, lambda });

            return (IQueryable<T>)result;
        }

        public static IQueryable<T> OrderByProperties<T>(this IQueryable<T> source, IEnumerable<string> properties)
        {
            if (source == null)
            {
                throw new ArgumentException("source");
            }

            if (properties == null || !properties.Any())
            {
                throw new ArgumentException("properties");
            }

            Dictionary<string, SortDirection> sort = properties.ToDictionary(
                k => k.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0],
                v =>
                {
                    var options = v.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    return options.Count() == 2 ? (SortDirection)Enum.Parse(typeof(SortDirection), options[1]) : SortDirection.ASC;
                });

            KeyValuePair<string, SortDirection> firstProperty = sort.First();


            IQueryable<T> orderBy = firstProperty.Value == SortDirection.ASC
                ? source.OrderByProperty<T>(firstProperty.Key)
                : source.OrderByPropertyDescending<T>(firstProperty.Key);

            sort.Remove(firstProperty.Key);
            foreach (KeyValuePair<string, SortDirection> property in sort)
            {
                if (typeof(T).HasProperty(property.Key))
                {
                    orderBy = property.Value == SortDirection.ASC
                        ? orderBy.OrderByProperty<T>(property.Key, true)
                        : orderBy.OrderByPropertyDescending<T>(property.Key, true);
                }

            }
            return orderBy;
        }

        public enum SortDirection
        {
            ASC,
            DESC
        }

    }    
}
