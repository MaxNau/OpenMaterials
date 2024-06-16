using OScience.Common.Cache;
using OScience.Common.RequestData;
using OScience.MaterialsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class MaterialsDocFilter : IFieldFilter, IQueryStringParameters
    {
        public bool BuilderMeta { get; set; }

        public string GetFilter()
        {
            return "builder_meta";
        }

        private IEnumerable<string> GetFilter(IToStringCallCache<MaterialsDocFilter> toStringCallCache)
        {
            foreach ((string parameterName, Func<MaterialsDocFilter, string> parameterValueFunc) in toStringCallCache.Get<MaterialsDocFilter>())
            {
                string parameterValue = parameterValueFunc(this);
                if (bool.Parse(parameterValue))
                {
                    yield return parameterName;
                }
            }
        }
    }
}
