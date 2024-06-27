using MaterialsProject.Responses.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class IonicStep
    {
        public double? EFrEnergy { get; set; }
        public double? EWoEntrp { get; set; }

        [JsonPropertyName("e_0_energy")]
        public double? E0Energy { get; set; }
        public double?[][] Forces { get; set; }
        public double?[][] Stress { get; set; }
        public List<Dictionary<string, double?>> ElectronicSteps { get; set; }
        public Structure Structure { get; set; }
        public object EpsilonRpa { get; set; }
        public object Epsilon { get; set; }
        public object EpsilonIon { get; set; }
    }
}
