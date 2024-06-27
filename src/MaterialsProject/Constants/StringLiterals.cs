namespace MaterialsProject.Constants
{
    internal static class StringLiterals
    {
        internal const string Empty = "";
        internal const string NotEquals = "not_eq";
        internal const string EqualsAny = "eq_any";
        internal const string NotEqualsAny = "neq_any";

        internal const string ExcludeElements = "exclude_elements";

        // paging
        internal const string Page = "_page";
        internal const string PerPage = "_per_page";
        internal const string Skip = "_skip";
        internal const string Limit = "_limit";

        // materials
        internal const string MaterialIds = "material_ids";
        internal const string TaskIds = "task_ids";
        internal const string CrystalSystem = "crystal_system";
        internal const string SpacegroupNumber = "spacegroup_number";
        internal const string SpacegroupSymbol = "spacegroup_symbol";
        internal const string Nsites = "nsites";
        internal const string Nelements = "nelements";
        internal const string Density = "density";
        internal const string DensityAtomic = "density_atomic";

        // thermo
        internal const string ThermoIds = "thermo_ids";
        internal const string ThermoTypes = "thermo_types";
        internal const string IsStable = "is_stable";
        internal const string UncorrectedEnergyPerAtomMax = "uncorrected_energy_per_atom_max";
        internal const string UncorrectedEnergyPerAtomMin = "uncorrected_energy_per_atom_min";
        internal const string EnergyPerAtomMax = "energy_per_atom_max";
        internal const string EnergyPerAtomMin = "energy_per_atom_min";
        internal const string EnergyUncertainyPerAtomMax = "energy_uncertainy_per_atom_max";
        internal const string EnergyUncertainyPerAtomMin = "energy_uncertainy_per_atom_min";
        internal const string FormationEnergyPerAtomMax = "formation_energy_per_atom_max";
        internal const string FormationEnergyPerAtomMin = "formation_energy_per_atom_min";
        internal const string EnergyAboveHullMax = "energy_above_hull_max";
        internal const string EnergyAboveHullMin = "energy_above_hull_min";
        internal const string EquilibriumReactionEnergyPerAtomMax = "equilibrium_reaction_energy_per_atom_max";
        internal const string EquilibriumReactionEnergyPerAtomMin = "equilibrium_reaction_energy_per_atom_min";
        internal const string DecompositionEnthalpyMax = "decomposition_enthalpy_max";
        internal const string DecompositionEnthalpyMin = "decomposition_enthalpy_min";
        
        // phase diagram
        internal const string PhaseDiagramIds = "phase_diagram_ids";

        // Dielectric
        internal const string ETotalMax = "e_total_max";
        internal const string ETotalMin = "e_total_min";
        internal const string EIonicMax = "e_ionic_max";
        internal const string EIonicMin = "e_ionic_min";
        internal const string EElectronicMax = "e_electronic_max";
        internal const string EElectronicMin = "e_electronic_min";
        internal const string NMax = "n_max";
        internal const string NMin = "n_min";

        // Magnetism
        internal const string TotalMagnetizationMax = "total_magnetization_max";
        internal const string TotalMagnetizationMin = "total_magnetization_min";
        internal const string TotalMagnetizationNormalizedVolMin = "total_magnetization_normalized_vol_min";
        internal const string TotalMagnetizationNormalizedVolMax = "total_magnetization_normalized_vol_max";
        internal const string TotalMagnetizationNormalizedFormulaUnitsMin = "total_magnetization_normalized_formula_units_min";
        internal const string TotalMagnetizationNormalizedFormulaUnitsMax = "total_magnetization_normalized_formula_units_max";
        internal const string NumMagneticSitesMax = "num_magnetic_sites_max";
        internal const string NumMagneticSitesMin = "num_magnetic_sites_min";
        internal const string NumUniqueMagneticSitesMax = "num_unique_magnetic_sites_max";
        internal const string NumUniqueMagneticSitesMin = "num_unique_magnetic_sites_min";
    }
}
