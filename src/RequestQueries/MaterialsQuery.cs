using OScience.Common.RequestData;
using OScience.MaterialsProject.RequestQueries;

namespace OScience.MaterialsProject.RequestParameters
{
    public sealed class MaterialsQuery : IQueryStringParameters
    {
        public MaterialsQuery(
            string materialIds = default, string formula = default, string chemsys = default,
            string taskIds = default, string crystalSystem = default, int spaceGroupNumber = default,
            SitesQuery sitesQuery = default, ElementsQuery elementsQuery = default,
            DensityQuery density = default, DensityAtomicQuery densityAtomic = default)
        {
            MaterialIds = materialIds;
            Formula = formula;
            Chemsys = chemsys;
            TaskIds = taskIds;
            CrystalSystem = crystalSystem;
            SpaceGroupNumber = spaceGroupNumber;
            Sites = sitesQuery ?? new SitesQuery();
            Elements = elementsQuery ?? new ElementsQuery();
            Density = density ?? new DensityQuery();
            DensityAtomic = densityAtomic ?? new DensityAtomicQuery();
        }

        [QueryParameter("material_ids")]
        public string MaterialIds { get; }
        public string Formula { get; }
        public string Chemsys { get; }
        [QueryParameter("task_ids")]
        public string TaskIds { get; }
        [QueryParameter("crystal_system")]
        public string CrystalSystem { get; }
        [QueryParameter("spacegroup_number")]
        public int SpaceGroupNumber { get; }
        [QueryParameter("spacegroup_symbol")]
        public string SpaceGroupSymbol { get; }
        public bool Deprecated { get; }
        [QueryParameter("nsites")]
        public SitesQuery Sites { get; }
        [QueryParameter("nelements")]
        public ElementsQuery Elements { get; }
        [QueryParameter("density")]
        public DensityQuery Density { get; }
        [QueryParameter("density_atomic")]
        public DensityAtomicQuery DensityAtomic { get; }
    }
}
