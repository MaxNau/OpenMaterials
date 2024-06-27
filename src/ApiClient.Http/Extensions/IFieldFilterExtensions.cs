using ApiClient.Http.Cache;
using ApiClient.Http.RequestData;
using System.Collections.Generic;
using System.Text.Json;
using System;
using System.Linq;

namespace ApiClient.Http.Extensions
{
    internal static class IFieldFilterExtensions
    {
        private static readonly string FilterSeparator = ",";
        private static readonly string FieldsParameterName = "_fields";

        internal static string GetFilterQuery<T>(this IFieldFilter fieldFilter, IToStringCallCache<T> toStringCallCache) where T : class, IFieldFilter
        {
            var includedFields = GetFilterInternal(fieldFilter, toStringCallCache);
            
            if (!includedFields.Any())
            {                 
                return string.Empty;
            }
            return $"{FieldsParameterName}={string.Join(FilterSeparator, includedFields)}";
        }

        private static IEnumerable<string> GetFilterInternal<T>(IFieldFilter fieldFilter, IToStringCallCache<T> toStringCallCache) where T : class, IFieldFilter
        {
            if (fieldFilter == null)
            {
                yield break;
            }

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
