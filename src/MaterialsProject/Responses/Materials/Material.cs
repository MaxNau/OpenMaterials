using MaterialsProject.Responses.Common;
using MaterialsProject.Responses.Enums;
using System;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials
{
    public class Material
    {
        public BuilderMeta BuilderMeta { get; set; }
        public int? Nsites { get; set; }
        public List<ChemicalSymbol> Elements { get; set; }
        public int? Nelements { get; set; }
        public Dictionary<ChemicalSymbol, float> Composition { get; set; }
        public Dictionary<ChemicalSymbol, float> CompositionReduced { get; set; }
        public string FormulaPretty { get; set; }
        public string FormulaAnonymous { get; set; }
        public string Chemsys { get; set; }
        public double? Volume { get; set; }
        public double? Density { get; set; }
        public double? DensityAtomic { get; set; }
        public Symmetry Symmetry { get; set; }
        public Structure Structure { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
    }
}
