using MaterialsProject.Responses.Common;
using MaterialsProject.Responses.Enums;
using System;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials
{
    public class MaterialsDoc
    {
        public string FormulaPretty { get; set; }
        public string MaterialId { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public BuilderMeta BuilderMeta { get; set; }
        public int? Nsites { get; set; }
        public List<ChemicalSymbol> Elements { get; set; }
        public int? Nelements { get; set; }
        public Dictionary<ChemicalSymbol, float> Composition { get; set; }
        public Dictionary<ChemicalSymbol, float> CompositionReduced { get; set; }
        public string FormulaAnonymous { get; set; }
        public string Chemsys { get; set; }
        public double? Volume { get; set; }
        public double? Density { get; set; }
        public double? DensityAtomic { get; set; }
        public Symmetry Symmetry { get; set; }
        public Structure Structure { get; set; }
        public bool? Deprecated { get; set; }
        public List<string> DeprecatedReasons { get; set; }
        public List<Structure> InitialStructures { get; set; }
        public List<string> TaskIds { get; set; }
        public List<string> DeprecatedTasks { get; set; }
        // enum CalcType + converter
        public Dictionary<string, string> CalcTypes { get; set; }
        public List<Origin> Origins { get; set; }
        public List<string> Warnings { get; set; }
        // enum TaskType + converter
        public Dictionary<string, string> TaskTypes { get; set; }
        // enum RunType + converter
        public Dictionary<string, string> RunTypes { get; set; }
        // TODO Entries
    }
}
