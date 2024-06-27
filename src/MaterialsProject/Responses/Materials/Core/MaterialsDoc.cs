using MaterialsProject.Responses.Common;
using System;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials.Core
{
    public class MaterialsDoc : Material
    {
        public string MaterialId { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public bool? Deprecated { get; set; }
        public List<string> DeprecationReasons { get; set; }
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

        /// <summary>
        /// A list of ComputedEntries or ComputedStructureEntries corresponding
        /// to a chemical system, formula, or materials_id or full criteria.
        /// </summary>
        public Entries Entries { get; set; }
    }
}
