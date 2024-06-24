using System;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Materials
{
    public class Entries
    {
        [JsonPropertyName("GGA")]
        public ComputedEntry Gga { get; set; }
        [JsonPropertyName("R2SCAN")]
        public ComputedEntry R2Scan { get; set; }
        [JsonPropertyName("PBESol")]
        public ComputedEntry PbeSol { get; set; }
        [JsonPropertyName("GGA+U")]
        public ComputedEntry GgaU { get; set; }
        [JsonPropertyName("SCAN")]
        public ComputedEntry Scan { get; set; }
    }
}
