using MaterialsProject.Responses.Common;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials.Magnetism
{
    public class MagnetismDoc : Material
    {
        public string PropertyName { get; set; }
        public string MaterialId { get; set; }
        public bool Deprecated { get; set; }
        public string DeprecationReasons { get; set; }
        public List<Origin> Origins { get; set; }
        public List<string> Warnings { get; set; }
        public string Ordering { get; set; }
        public bool? IsMagnetic { get; set; }
        public long? ExchangeSymmetry { get; set; }
        public long? NumMagneticSites { get; set; }
        public long? NumUniqueMagneticSites { get; set; }
        public List<string> TypesOfMagneticSpecies { get; set; }
        public double[] Magmoms { get; set; }
        public double? TotalMagnetization { get; set; }
        public double? TotalMagnetizationNormalizedVol { get; set; }
        public double? TotalMagnetizationNormalizedFormulaUnits { get; set; }
    }
}
