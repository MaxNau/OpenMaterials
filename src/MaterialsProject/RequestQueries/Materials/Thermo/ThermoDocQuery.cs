using ApiClient.Http.RequestData;
using MaterialsProject.Constants;

namespace MaterialsProject.RequestQueries.Materials.Thermo
{
    public class ThermoDocQuery : IQueryStringParameters
    {
        public ThermoDocQuery(
            string thermoIds = default, string thermoTypes = default, bool? isStable = default,
            double? uncorrectedEnergyPerAtomMax = default, double? uncorrectedEnergyPerAtomMin = default,
            double? energyPerAtomMax = default, double? energyPerAtomMin = default,
            double? energyUncertainyPerAtomMax = default, double? energyUncertainyPerAtomMin = default,
            double? formationEnergyPerAtomMax = default, double? formationEnergyPerAtomMin = default,
            double? energyAboveHullMax = default, double? energyAboveHullMin = default,
            double? equilibriumReactionEnergyPerAtomMax = default, double? equilibriumReactionEnergyPerAtomMin = default,
            double? decompositionEnthalpyMax = default, double? decompositionEnthalpyMin = default,
            string formula = default, string chemsys = default, SitesQuery sites = default, ElementsQuery elements = default,
            DensityQuery density = default, DensityAtomicQuery densityAtomic = default)
        {
            ThermoIds = thermoIds;
            ThermoTypes = thermoTypes;
            IsStable = isStable;
            UncorrectedEnergyPerAtomMax = uncorrectedEnergyPerAtomMax;
            UncorrectedEnergyPerAtomMin = uncorrectedEnergyPerAtomMin;
            EnergyPerAtomMax = energyPerAtomMax;
            EnergyPerAtomMin = energyPerAtomMin;
            EnergyUncertainyPerAtomMax = energyUncertainyPerAtomMax;
            EnergyUncertainyPerAtomMin = energyUncertainyPerAtomMin;
            FormationEnergyPerAtomMax = formationEnergyPerAtomMax;
            FormationEnergyPerAtomMin = formationEnergyPerAtomMin;
            EnergyAboveHullMax = energyAboveHullMax;
            EnergyAboveHullMin = energyAboveHullMin;
            EquilibriumReactionEnergyPerAtomMax = equilibriumReactionEnergyPerAtomMax;
            EquilibriumReactionEnergyPerAtomMin = equilibriumReactionEnergyPerAtomMin;
            DecompositionEnthalpyMax = decompositionEnthalpyMax;
            DecompositionEnthalpyMin = decompositionEnthalpyMin;
            Formula = formula;
            Chemsys = chemsys;
            Sites = sites ?? new SitesQuery();
            Elements = elements ?? new ElementsQuery();
            Density = density ?? new DensityQuery();
            DensityAtomic = densityAtomic ?? new DensityAtomicQuery();
        }

        /// <summary>
        /// Comma-separated list of thermo_id values to query on
        /// </summary>
        [QueryParameter(StringLiterals.ThermoIds)]
        public string ThermoIds { get; }

        /// <summary>
        /// Comma-separated list of material_id values to query on
        /// </summary>
        [QueryParameter(StringLiterals.ThermoTypes)]
        public string ThermoTypes { get; }

        /// <summary>
        /// Whether the material is stable.
        /// </summary>
        [QueryParameter(StringLiterals.IsStable)]
        public bool? IsStable { get; }

        /// <summary>
        /// Query for maximum value of UncorrectedEnergyPerAtomMax
        /// </summary>
        [QueryParameter(StringLiterals.UncorrectedEnergyPerAtomMax)]
        public double? UncorrectedEnergyPerAtomMax { get; }

        /// <summary>
        /// Query for minimum value of UncorrectedEnergyPerAtomMin
        /// </summary>
        [QueryParameter(StringLiterals.UncorrectedEnergyPerAtomMin)]
        public double? UncorrectedEnergyPerAtomMin { get; }

        /// <summary>
        /// Query for maximum value of EnergyPerAtomMax
        /// </summary>
        [QueryParameter(StringLiterals.EnergyPerAtomMax)]
        public double? EnergyPerAtomMax { get; }

        /// <summary>
        /// Query for minimum value of EnergyPerAtomMin
        /// </summary>
        [QueryParameter(StringLiterals.EnergyPerAtomMin)]
        public double? EnergyPerAtomMin { get; }

        /// <summary>
        /// Query for maximum value of EnergyUncertainyPerAtomMax
        /// </summary>
        [QueryParameter(StringLiterals.EnergyUncertainyPerAtomMax)]
        public double? EnergyUncertainyPerAtomMax { get; }

        /// <summary>
        /// Query for minimum value of EnergyUncertainyPerAtomMin
        /// </summary>
        [QueryParameter(StringLiterals.EnergyUncertainyPerAtomMin)]
        public double? EnergyUncertainyPerAtomMin { get; }

        /// <summary>
        /// Query for maximum value of FormationEnergyPerAtomMax
        /// </summary>
        [QueryParameter(StringLiterals.FormationEnergyPerAtomMax)]
        public double? FormationEnergyPerAtomMax { get; }

        /// <summary>
        /// Query for minimum value of FormationEnergyPerAtomMin
        /// </summary>
        [QueryParameter(StringLiterals.FormationEnergyPerAtomMin)]
        public double? FormationEnergyPerAtomMin { get; }

        /// <summary>
        /// Query for maximum value of EnergyAboveHullMax
        /// </summary>
        [QueryParameter(StringLiterals.EnergyAboveHullMax)]
        public double? EnergyAboveHullMax { get; }

        /// <summary>
        /// Query for minimum value of EnergyAboveHullMin
        /// </summary>
        [QueryParameter(StringLiterals.EnergyAboveHullMin)]
        public double? EnergyAboveHullMin { get; }

        /// <summary>
        /// Query for maximum value of EquilibriumReactionEnergyPerAtomMax
        /// </summary>
        [QueryParameter(StringLiterals.EquilibriumReactionEnergyPerAtomMax)]
        public double? EquilibriumReactionEnergyPerAtomMax { get; }

        /// <summary>
        /// Query for minimum value of EquilibriumReactionEnergyPerAtomMin
        /// </summary>
        [QueryParameter(StringLiterals.EquilibriumReactionEnergyPerAtomMin)]
        public double? EquilibriumReactionEnergyPerAtomMin { get; }

        /// <summary>
        /// Query for maximum value of DecompositionEnthalpyMax
        /// </summary>
        [QueryParameter(StringLiterals.DecompositionEnthalpyMax)]
        public double? DecompositionEnthalpyMax { get; }

        /// <summary>
        /// Query for maximum value of DecompositionEnthalpyMin
        /// </summary>
        [QueryParameter(StringLiterals.DecompositionEnthalpyMin)]
        public double? DecompositionEnthalpyMin { get; }

        public string Formula { get; }
        public string Chemsys { get; }

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
