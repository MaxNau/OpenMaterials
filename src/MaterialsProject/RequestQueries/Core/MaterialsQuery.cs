using MaterialsProject.Constants;
using ApiClient.Http.RequestData;


namespace MaterialsProject.RequestQueries.Core
{
    public sealed class MaterialsQuery : IQueryStringParameters
    {
        public MaterialsQuery(
            string materialIds = default, string formula = default, string chemsys = default,
            string taskIds = default, string crystalSystem = default, int? spaceGroupNumber = default,
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

        [QueryParameter(StringLiterals.MaterialIds)]
        public string MaterialIds { get; }
        public string Formula { get; }
        public string Chemsys { get; }

        [QueryParameter(StringLiterals.TaskIds)]
        public string TaskIds { get; }

        [QueryParameter(StringLiterals.CrystalSystem)]
        public string CrystalSystem { get; }

        [QueryParameter(StringLiterals.SpacegroupNumber)]
        public int? SpaceGroupNumber { get; }

        [QueryParameter(StringLiterals.SpacegroupSymbol)]
        public string SpaceGroupSymbol { get; }

        public bool? Deprecated { get; }

        [QueryParameter(StringLiterals.Nsites)]
        public SitesQuery Sites { get; }

        [QueryParameter(StringLiterals.Nelements)]
        public ElementsQuery Elements { get; }

        [QueryParameter(StringLiterals.Density)]
        public DensityQuery Density { get; }

        [QueryParameter(StringLiterals.DensityAtomic)]
        public DensityAtomicQuery DensityAtomic { get; }
    }
}
