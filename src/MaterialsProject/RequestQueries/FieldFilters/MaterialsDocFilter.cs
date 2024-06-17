using OScience.Common.RequestData;

namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class MaterialsDocFilter : IFieldFilter
    {
        public bool BuilderMeta { get; set; }
        public bool Nsites { get; set; }
    }
}
