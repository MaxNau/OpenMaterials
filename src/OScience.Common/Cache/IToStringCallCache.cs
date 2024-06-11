using OScience.Common.RequestData;
using System;
using System.Collections.Generic;

namespace OScience.Common.Cache
{
    internal interface IToStringCallCache<T>
    {
        List<Tuple<string, Func<T, string>>> Get<CachedType>() where CachedType: IQueryStringParameters;
    }
}
