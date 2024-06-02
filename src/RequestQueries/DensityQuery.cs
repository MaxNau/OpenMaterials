using OScience.MaterialsProject.RequestQueries.Clauses;

namespace OScience.MaterialsProject.RequestQueries
{
    public class DensityQuery : IMinMaxQuery
    {
        public DensityQuery(int? max = default, int? min = default)
        {
            Max = max;
            Min = min;
        }

        public int? Max { get; }

        public int? Min { get; }
    }
}
