using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class FrameProperty
    {
        public double? EFrEnergy { get; set; }
        public double? EWoEntrp { get; set; }
        [JsonPropertyName("e_0_energy")]
        public double? E0Energy { get; set; }
        public double?[][] Forces { get; set; }
        public double?[][] Stresses { get; set; }
        public List<Dictionary<string, double?>> ElectronicSteps { get; set; }
    }
}
