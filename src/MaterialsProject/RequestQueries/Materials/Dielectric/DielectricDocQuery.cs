using ApiClient.Http.RequestData;
using MaterialsProject.Constants;

namespace MaterialsProject.RequestQueries.Materials.Dielectric
{
    public class DielectricDocQuery : IQueryStringParameters
    {
        public DielectricDocQuery(
            string materialIds = default, double? eTotalMax = default, double? eTotalMin = default,
            double? eIonicMax = default, double? eIonicMin = default, double? eElectronicMax = default,
            double? eElectronicMin = default, double? nMax = default, double? nMin = default)
        {
            MaterialIds = materialIds;
            ETotalMax = eTotalMax;
            ETotalMin = eTotalMin;
            EIonicMax = eIonicMax;
            EIonicMin = eIonicMin;
            EElectronicMax = eElectronicMax;
            EElectronicMin = eElectronicMin;
            NMax = nMax;
            NMin = nMin;
        }

        /// <summary>
        /// Comma-separated list of material_id values to query on
        /// </summary>
        [QueryParameter(StringLiterals.MaterialIds)]
        public string MaterialIds { get; }

        /// <summary>
        /// Maximum value for the total dielectric constant.
        /// </summary>
        [QueryParameter(StringLiterals.ETotalMax)]
        public double? ETotalMax { get; }

        /// <summary>
        /// Minimum value for the total dielectric constant.
        /// </summary>
        [QueryParameter(StringLiterals.ETotalMin)]
        public double? ETotalMin { get; }

        /// <summary>
        /// Maximum value for the ionic dielectric constant.
        /// </summary>
        [QueryParameter(StringLiterals.EIonicMax)]
        public double? EIonicMax { get; }

        /// <summary>
        /// Minimum value for the ionic dielectric constant.
        /// </summary>
        [QueryParameter(StringLiterals.EIonicMin)]
        public double? EIonicMin { get; }

        /// <summary>
        /// Maximum value for the electronic dielectric constant.
        /// </summary>
        [QueryParameter(StringLiterals.EElectronicMax)]
        public double? EElectronicMax { get; }

        /// <summary>
        /// Minimum value for the electronic dielectric constant.
        /// </summary>
        [QueryParameter(StringLiterals.EElectronicMin)]
        public double? EElectronicMin { get; }

        /// <summary>
        /// Maximum value for the refractive index.
        /// </summary>
        [QueryParameter(StringLiterals.NMax)]
        public double? NMax { get; }

        /// <summary>
        /// Minimum value for the refractive index.
        /// </summary>
        [QueryParameter(StringLiterals.NMin)]
        public double? NMin { get; }
    }
}
