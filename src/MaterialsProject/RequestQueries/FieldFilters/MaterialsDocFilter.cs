using OScience.Common.RequestData;
using System.Collections.Generic;

namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class MaterialsDocFilter : IFieldFilter
    {
        public bool MaterialId { get; set; }
        public bool FormulaPretty { get; set; }
        public bool BuilderMeta { get; set; }
        public bool Nsites { get; set; }
        public bool Elements { get; set; }
        public bool Nelements { get; set; }
        public bool Composition { get; set; }
        public bool CompositionReduced { get; set; }
        public bool FormulaAnonymous { get; set; }
        public bool Chemsys { get; set; }
        public bool Volume { get; set; }
        public bool Density { get; set; }
        public bool DensityAtomic { get; set; }
        public bool Symmetry { get; set; }
        public bool Structure { get; set; }
        public bool Deprecated { get; set; }
        public bool DeprecatedReasons { get; set; }
        public bool InitialStructures { get; set; }
        public bool TaskIds { get; set; }
        public bool DeprecatedTasks { get; set; }
        public bool CalcTypes { get; set; }
        public bool LastUpdated { get; set; }
        public bool CreatedAt { get; set; }
        public bool Origins { get; set; }
        public bool Warnings { get; set; }
        public bool TaskTypes { get; set; }
        public bool RunTypes { get; set; }
    }
}
