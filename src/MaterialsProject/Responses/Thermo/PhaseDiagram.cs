using MaterialsProject.Responses.Common;
using MaterialsProject.Responses.Materials;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Thermo
{
    public class PhaseDiagram : PymatgenModule
    {
        public List<Entry> AllEntries { get; set; }
        public List<object> Elements { get; set; }

        [JsonPropertyName("computed_data")]
        public ComputedData ComputedData { get; set; }
    }
}
