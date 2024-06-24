using System;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Materials
{
    public class Entries
    {
        [JsonPropertyName("GGA")]
        public Entry Gga { get; set; }
        [JsonPropertyName("R2SCAN")]
        public Entry R2Scan { get; set; }
        [JsonPropertyName("PBESol")]
        public Entry PbeSol { get; set; }
        [JsonPropertyName("GGA+U")]
        public Entry GgaU { get; set; }
        [JsonPropertyName("SCAN")]
        public Entry Scan { get; set; }
    }
}
