using ApiClient.Http.RequestData;
using MaterialsProject.Constants;

namespace MaterialsProject.RequestQueries.Materials.Magnetism
{
    public class MagnetismDocQuery : IQueryStringParameters
    {
        /// <summary>
        /// Comma-separated list of material_id values to query on
        /// </summary>
        [QueryParameter(StringLiterals.MaterialIds)]
        public string MaterialIds { get; }

        /// <summary>
        /// Magnetic ordering of the material.
        /// </summary>
        public string Ordering { get; }

        /// <summary>
        /// Maximum value for the total magnetization.
        /// </summary>
        [QueryParameter(StringLiterals.TotalMagnetizationMax)]
        public double? TotalMagnetizationMax { get; }

        /// <summary>
        /// Minimum value for the total magnetization.
        /// </summary>
        [QueryParameter(StringLiterals.TotalMagnetizationMin)]
        public double? TotalMagnetizationMin { get; }

        /// <summary>
        /// Maximum value for the total magnetization normalized with volume.
        /// </summary>
        [QueryParameter(StringLiterals.TotalMagnetizationNormalizedVolMax)]
        public double? TotalMagnetizationNormalizedVolMax { get; }

        /// <summary>
        /// Minimum value for the total magnetization normalized with volume.
        /// </summary>
        [QueryParameter(StringLiterals.TotalMagnetizationNormalizedVolMin)]
        public double? TotalMagnetizationNormalizedVolMin { get; }

        /// <summary>
        /// Maximum value for the total magnetization normalized with formula units.
        /// </summary>
        [QueryParameter(StringLiterals.TotalMagnetizationNormalizedFormulaUnitsMax)]
        public double? TotalMagnetizationNormalizedFormulaUnitsMax { get; }

        /// <summary>
        /// Minimum value for the total magnetization normalized with formula units.
        /// </summary>
        [QueryParameter(StringLiterals.TotalMagnetizationNormalizedFormulaUnitsMin)]
        public double? TotalMagnetizationNormalizedFormulaUnitsMin { get; }

        /// <summary>
        /// Maximum value for the total number of magnetic sites.
        /// </summary>
        [QueryParameter(StringLiterals.NumMagneticSitesMax)]
        public long? NumMagneticSitesMax { get; }

        /// <summary>
        /// Minimum value for the total number of magnetic sites.
        /// </summary>
        [QueryParameter(StringLiterals.NumMagneticSitesMin)]
        public long? NumMagneticSitesMin{ get; }

        /// <summary>
        /// Maximum value for the total number of unique magnetic sites.
        /// </summary>
        [QueryParameter(StringLiterals.NumUniqueMagneticSitesMax)]
        public long? NumUniqueMagneticSitesMax { get; }

        /// <summary>
        /// Minimum value for the total number of unique magnetic sites.
        /// </summary>
        [QueryParameter(StringLiterals.NumUniqueMagneticSitesMin)]
        public long? NumUniqueMagneticSitesMin { get; }
    }
}
