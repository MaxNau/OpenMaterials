using OScience.MaterialsProject.RequestQueries.Clauses;

namespace OScience.MaterialsProject.RequestQueries
{
    public sealed class DensityAtomicQuery : IMinMaxQuery
    {
        public DensityAtomicQuery(int? max = default, int? min = default)
        {
            Max = max;
            Min = min;
        }

        public int? Max { get; }

        public int? Min { get; }
    }
}
