using ApiClient.Http.RequestData;

namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class MaterialFilter : IFieldFilter
    {
        public MaterialFilter(bool includeAllFields = false)
        {
            IncludeAllFields = includeAllFields;
        }

        public bool BuilderMeta { get; set; }
        public bool Nsites { get; set; }
        public bool Elements { get; set; }
        public bool Nelements { get; set; }
        public bool Composition { get; set; }
        public bool CompositionReduced { get; set; }
        public bool FormulaPretty { get; set; }
        public bool FormulaAnonymous { get; set; }
        public bool Chemsys { get; set; }
        public bool Volume { get; set; }
        public bool Density { get; set; }
        public bool DensityAtomic { get; set; }
        public bool Symmetry { get; set; }
        public bool Structure { get; set; }
        public bool LastUpdated { get; set; }
        public bool IncludeAllFields { get; }
    }
}
