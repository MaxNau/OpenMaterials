using MaterialsProject.Responses.Common;
using MaterialsProject.Responses.Materials;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Thermo
{
    public class ThermoDoc : Material
    {
        public string PropertyName { get; set; }
        public string MaterialId { get; set; }
        public bool Deprecated { get; set; }
        public List<string> DeprecationReasons { get; set; }
        public List<Origin> Origins { get; set; }
        public List<string> Warnings { get; set; }
        public string ThermoType { get; set; }
        public string ThermoId { get; set; }
        public double? UncorrectedEnergyPerAtom { get; set; }
        public double? EnergyPerAtom { get; set; }
        public double? EnergyUncertainyPerAtom { get; set; }
        public double? FormationEnergyPerAtom { get; set; }
        public double? EnergyAboveHull { get; set; }
        public bool? IsStable { get; set; }
        public double? EquilibriumReactionEnergyPerAtom { get; set; }
        public List<DecomposdecomposesTo> DecomposesTo { get; set; }
        public double? DecompositionEnthalpy { get; set; }
        public List<DecomposdecomposesTo> DecompositionEnthalpyDecomposesTo { get; set; }
        public string EnergyType { get; set; }
        public List<string> EntryTypes { get; set; }
        public Entries Entries { get; set; }
    }
}
