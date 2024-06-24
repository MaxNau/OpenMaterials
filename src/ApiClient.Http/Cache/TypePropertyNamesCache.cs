using System.Collections.Generic;
using System;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace ApiClient.Http.Cache
{
    internal sealed class TypePropertyNamesCache<T> : IPrecompiledCache, IToStringCallCache<T>
    {
        private static readonly Dictionary<string, List<Tuple<string, Func<T, string>>>> _toStringCallCache = new Dictionary<string, List<Tuple<string, Func<T, string>>>>();

        List<Tuple<string, Func<T, string>>> IToStringCallCache<T>.Get<CachedType>()
        {
            return _toStringCallCache[typeof(CachedType).Name];
        }

        void IPrecompiledCache.Precompile(Assembly assembly)
        {
            var queryStringParametersInterface = typeof(T);
            var fieldFilters = assembly.GetTypes()
                .Where(type => queryStringParametersInterface.IsAssignableFrom(type));

            foreach (var fieldFilter in fieldFilters)
            {
                _toStringCallCache.Add(fieldFilter.Name, new List<Tuple<string, Func<T, string>>>());

                foreach (var propertyInfo in fieldFilter.GetProperties())
                {
                    var objParameterExpr = Expression.Parameter(typeof(T));
                    var instanceExpr = Expression.TypeAs(objParameterExpr, propertyInfo.DeclaringType);
                    var propertyExpr = Expression.Property(instanceExpr, propertyInfo);
                    var toStringMethodInfo = typeof(object).GetMethod(nameof(ToString));
                    MethodCallExpression toStringMethodCallExpression;

                    toStringMethodCallExpression = Expression.Call(propertyExpr, toStringMethodInfo);
                    
                    var toStringPrecompiled = Expression.Lambda<Func<T, string>>(toStringMethodCallExpression, objParameterExpr).Compile();

                    _toStringCallCache[fieldFilter.Name].Add(
                           new Tuple<string, Func<T, string>>(propertyInfo.Name, toStringPrecompiled));
                }
            }
        }
    }
}
