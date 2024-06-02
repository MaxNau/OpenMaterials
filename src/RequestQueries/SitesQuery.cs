using OScience.MaterialsProject.RequestQueries.Clauses;

namespace OScience.MaterialsProject.RequestQueries
{
    public sealed class SitesQuery : IMinMaxQuery, IEqualsQuery, IInQuery
    {
        public SitesQuery(int? max = default, int? equal = default, int? notEqual = default,
            int? min = default, string @in = default, string notIn = default)
        {
            Max = max;
            Equal = equal;
            NotEqual = notEqual;
            Min = min;
            In = @in;
            NotIn = notIn;
        }

        public int? Max { get; }

        public int? Equal { get; }

        public int? NotEqual { get; }

        public int? Min { get; }

        public string In { get; }

        public string NotIn { get; }
    }
}
