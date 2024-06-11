using OScience.Common.RequestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace OScience.Common.Cache
{
    internal sealed class TypePropertiesToStringCallCache<T> : IPrecompiledCache, IToStringCallCache<T>
    {
        private readonly Dictionary<string, List<Tuple<string, Func<T, string>>>> _queryParametersCache = new Dictionary<string, List<Tuple<string, Func<T, string>>>>();


        List<Tuple<string, Func<T, string>>> IToStringCallCache<T>.Get<CachedType>()
        {
            return _queryParametersCache[typeof(CachedType).Name];
        }

        void IPrecompiledCache.Precompile(Assembly assembly)
        {
            if (_queryParametersCache.Count > 0)
            {
                return;
            }

            var queryStringParametersInterface = typeof(T);
            var queryParameters = assembly.GetTypes()
                .Where(type => queryStringParametersInterface.IsAssignableFrom(type));

            foreach (var queryParameter in queryParameters)
            {
                _queryParametersCache.Add(queryParameter.Name, new List<Tuple<string, Func<T, string>>>());

                foreach (var propertyInfo in queryParameter.GetProperties())
                {
                    if (IsComplexType(propertyInfo.PropertyType))
                    {
                        var interfacesProperties = propertyInfo.PropertyType.GetInterfaces().SelectMany(i => i.GetProperties());
                        var parentQueryParameterAttribute = propertyInfo.GetCustomAttribute<QueryParameterAttribute>();
                        var parentParameterName = parentQueryParameterAttribute == null ? propertyInfo.Name : parentQueryParameterAttribute.Name;
                        foreach (var interfacesProperty in interfacesProperties)
                        {
                            var toStringPrecompiled = BuildToStringPrecompiledLambda(interfacesProperty, propertyInfo);

                            var queryParameterAttribute = interfacesProperty.GetCustomAttribute<QueryParameterAttribute>();
                            _queryParametersCache[queryParameter.Name].Add(
                                new Tuple<string, Func<T, string>>(
                                    BuildParameterName(interfacesProperty, parentParameterName), toStringPrecompiled));
                        }
                    }
                    else
                    {
                        var toStringPrecompiled = BuildToStringPrecompiledLambda(propertyInfo);

                        var queryParameterAttribute = propertyInfo.GetCustomAttribute<QueryParameterAttribute>();
                        _queryParametersCache[queryParameter.Name].Add(
                            new Tuple<string, Func<T, string>>(
                                BuildParameterName(propertyInfo), toStringPrecompiled));
                    }
                }
            }
        }

        private bool IsComplexType(Type type)
        {
            return type.IsClass && type != typeof(string);
        }

        private string BuildParameterName(PropertyInfo propertyInfo, string parentParameterName)
        {
            var queryParameterAttribute = propertyInfo.GetCustomAttribute<QueryParameterAttribute>();

            return queryParameterAttribute != null ?
                            string.IsNullOrWhiteSpace(queryParameterAttribute.Name) ? parentParameterName :
                            $"{parentParameterName}_{queryParameterAttribute.Name}" :
                            string.IsNullOrWhiteSpace(propertyInfo.Name) ? parentParameterName :
                            $"{parentParameterName}_{propertyInfo.Name.ToLower()}";
        }

        private static string BuildParameterName(PropertyInfo propertyInfo)
        {
            var queryParameterAttribute = propertyInfo.GetCustomAttribute<QueryParameterAttribute>();

            return queryParameterAttribute != null ?
                            queryParameterAttribute.Name :
                            propertyInfo.Name.ToLower();
        }

        private Func<T, string> BuildToStringPrecompiledLambda(PropertyInfo propertyInfo, PropertyInfo parentPropertyInfo = null)
        {
            var objParameterExpr = Expression.Parameter(typeof(T));
            var instanceExpr = Expression.TypeAs(objParameterExpr, parentPropertyInfo == null ? propertyInfo.DeclaringType : parentPropertyInfo.DeclaringType);
            var propertyExpr = parentPropertyInfo == null ?
                Expression.Property(instanceExpr, propertyInfo) :
                Expression.Property(Expression.Property(instanceExpr, parentPropertyInfo), propertyInfo);
            var toStringMethodInfo = typeof(object).GetMethod(nameof(ToString));
            MethodCallExpression toStringMethodCallExpression;
            if (propertyInfo.PropertyType == typeof(string))
            {
                var coallesceExpression = Expression.Coalesce(propertyExpr, Expression.Constant(string.Empty));
                toStringMethodCallExpression = Expression.Call(coallesceExpression, toStringMethodInfo);
            }
            else
            {
                toStringMethodCallExpression = Expression.Call(propertyExpr, toStringMethodInfo);
            }
            return Expression.Lambda<Func<T, string>>(toStringMethodCallExpression, objParameterExpr).Compile();
        }
    }
}
