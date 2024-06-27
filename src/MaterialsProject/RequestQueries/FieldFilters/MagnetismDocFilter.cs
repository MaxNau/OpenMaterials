namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class MagnetismDocFilter : MaterialFilter
    {
        public MagnetismDocFilter(bool includeAllFields = false)
            :base(includeAllFields)
        {   
        }

        public bool PropertyName { get; set; }
        public bool Materialid { get; set; }
        public bool Depreceted { get; set; }
        public bool DeprecationReasons { get; set; }
        public bool Origins { get; set; }
        public bool Warnings { get; set; }
        public bool Ordering { get; set; }
        public bool IsMagnetic { get; set; }
        public bool ExchangeSymmetry { get; set; }
        public bool NumMagneticSites { get; set; }
        public bool NumUniqueMagneticSites { get; set; }
        public bool TypesOfMagneticSpecies { get; set; }
        public bool Magmoms { get; set; }
        public bool TotalMagnetization { get; set; }
        public bool TotalMagnetizationNormalizedVol { get; set; }
        public bool TotalMagnetizationNormalizedFormulaUnits { get; set; }
    }
}
