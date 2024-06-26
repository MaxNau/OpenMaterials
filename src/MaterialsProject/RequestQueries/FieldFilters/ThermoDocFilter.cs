namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class ThermoDocFilter : MaterialFilter
    {
        public ThermoDocFilter(bool includeAllFields = false)
            : base(includeAllFields)
        {
        }

        public bool PropertyName { get; set; }
        public bool MaterialId { get; set; }
        public bool Origins { get; set; }
        public bool Deprecated { get; set; }
        public bool DeprecatedReasons { get; set; }
        public bool InitialStructures { get; set; }
        public bool Warnings { get; set; }
        public bool ThermoType { get; set; }
        public bool ThermoId { get; set; }
        public bool UncorrectedEnergyPerAtom { get; set; }
        public bool EnergyPerAtom { get; set; } 
        public bool EnergyUncertainyPerAtom { get; set; }
        public bool FormationEnergyPerAtom { get; set; }
        public bool EnergyAboveHull { get; set; }
        public bool IsStable { get; set; }
        public bool EquilibriumReactionEnergyPerAtom { get; set; }
        public bool DecomposesTo { get; set; }
        public bool DecompositionEnthalpy { get; set; }
        public bool DecompositionEnthalpyDecomposesTo { get; set; }
        public bool EnergyType { get; set; }
        public bool EntryTypes { get; set; }
        public bool Entries { get; set; }
    }
}
