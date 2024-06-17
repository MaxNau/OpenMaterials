using OScience.Common.Cache;
using OScience.Common.RequestData;
using System.Collections.Generic;
using System.Text.Json;
using System;

namespace OScience.Common.Extensions
{
    internal static class IFieldFilterExtensions
    {
        private static readonly string FilterSeparator = ",";
        private static readonly string FieldsParameterName = "_fields";

        internal static string GetFilterQuery<T>(this IFieldFilter fieldFilter, IToStringCallCache<T> toStringCallCache) where T : class, IFieldFilter
        {
            return $"{FieldsParameterName}={string.Join(FilterSeparator, GetFilterInternal(fieldFilter, toStringCallCache))}";
        }

        private static IEnumerable<string> GetFilterInternal<T>(IFieldFilter fieldFilter, IToStringCallCache<T> toStringCallCache) where T : class, IFieldFilter
        {
            foreach ((string parameterName, Func<T, string> parameterValueFunc) in toStringCallCache.Get<T>())
            {
                string parameterValue = parameterValueFunc(fieldFilter as T);
                if (bool.Parse(parameterValue))
                {
                    yield return JsonNamingPolicy.SnakeCaseLower.ConvertName(parameterName);
                }
            }
        }
    }
}
