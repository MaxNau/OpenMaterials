using OScience.Common.RequestData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OScience.Common.Cache
{
    internal class ToStringCallCacheAdapter<FieldFilterParam> : IToStringCallCache<FieldFilterParam>
    where FieldFilterParam : IFieldFilter
    {
        private readonly IToStringCallCache<IFieldFilter> _innerCache;

        internal ToStringCallCacheAdapter(IToStringCallCache<IFieldFilter> innerCache)
        {
            _innerCache = innerCache;
        }

        List<Tuple<string, Func<FieldFilterParam, string>>> IToStringCallCache<FieldFilterParam>.Get<CachedType>()
        {
            return _innerCache.Get<CachedType>().Select(tuple => new Tuple<string, Func<FieldFilterParam, string>>(tuple.Item1, fieldFilterParam => tuple.Item2(fieldFilterParam as IFieldFilter))).ToList();
        }
    }
}
