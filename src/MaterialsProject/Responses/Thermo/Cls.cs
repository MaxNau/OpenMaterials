using MaterialsProject.Responses.Common;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Thermo
{
    public class Cls : PymatgenModule
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public StructureMatcher StructureMatcher { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("run_type_1")]
        public string RunType1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("run_type_2")]
        public string RunType2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("compat_1")]
        public object Compat1 { get; set; }

        [JsonPropertyName("compat_2")]
        public object Compat2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? FuzzyMatching { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? CheckPotcar { get; set; }
    }
}
