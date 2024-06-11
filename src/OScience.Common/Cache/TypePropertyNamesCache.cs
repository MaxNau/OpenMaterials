using OScience.Common.RequestData;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace OScience.Common.Cache
{
    internal sealed class TypePropertyNamesCache : IPrecompiledCache
    {
        private static readonly Dictionary<string, List<Tuple<string, Func<IQueryStringParameters, string>>>> _queryParametersCache = new Dictionary<string, List<Tuple<string, Func<IQueryStringParameters, string>>>>();

        void IPrecompiledCache.Precompile(Assembly assembly)
        {
                       
        }
    }
}
