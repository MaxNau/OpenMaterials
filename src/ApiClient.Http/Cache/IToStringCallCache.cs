using ApiClient.Http.RequestData;
using System;
using System.Collections.Generic;

namespace ApiClient.Http.Cache
{
    internal interface IToStringCallCache<T>
    {
        List<Tuple<string, Func<T, string>>> Get<CachedType>() where CachedType: IQueryStringParameters;
    }
}
