using OScience.Common.Cache;
using OScience.Common.RequestData;
using System.Collections.Generic;
using System;

namespace OScience.Common.Extensions
{
    internal static class IQueryStringParametersExtensions
    {
        private static readonly string ParameterSeparator = "&";
        internal static string ToQueryString<T>(this IQueryStringParameters parameter, IToStringCallCache<IQueryStringParameters> toStringCallCache) where T : IQueryStringParameters
        {
            return string.Join(ParameterSeparator, BuildQueryParameters<T>(parameter, toStringCallCache));
        }

        private static IEnumerable<string> BuildQueryParameters<T>(IQueryStringParameters obj, IToStringCallCache<IQueryStringParameters> toStringCallCache) where T : IQueryStringParameters
        {
            foreach ((string parameterName, Func<IQueryStringParameters, string> parameterValueFunc) in toStringCallCache.Get<T>())
            {
                string parameterValue = parameterValueFunc(obj);
                if (string.IsNullOrWhiteSpace(parameterValue))
                {
                    continue;
                }

                yield return $"{parameterName}={parameterValue}";
            }
        }
    }
}
