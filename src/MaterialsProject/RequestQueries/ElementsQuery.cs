using MaterialsProject.Constants;
using ApiClient.Http.RequestData;
using OScience.MaterialsProject.RequestQueries.Clauses;

namespace OScience.MaterialsProject.RequestQueries
{
    public sealed class ElementsQuery : IMinMaxQuery, IEqualsQuery, IInQuery
    {
        public ElementsQuery(string elements = default, string excludeElements = default,
            int? max = default, int? min = default,
            int? equal = default, int? notEqual = default, string @in = default, string notIn = default)
        {
            Elements = elements;
            ExcludeElements = excludeElements;
            Max = max;
            Min = min;
            Equal = equal;
            NotEqual = notEqual;
            In = @in;
            NotIn = notIn;
        }

        public string Elements { get; }

        [QueryParameter(StringLiterals.ExcludeElements)]
        public string ExcludeElements { get; }

        public int? Max { get; }

        public int? Min { get; }

        public int? Equal { get; }

        public int? NotEqual { get; }

        public string In { get; }

        public string NotIn { get; }
    }
}
