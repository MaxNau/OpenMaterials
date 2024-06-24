using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Tasks
{
    public class NmrCs
    {
        [JsonPropertyName("valence and core")]
        public double[][] ValenceAndCore { get; set; }
        public double[][] ValenceOnly { get; set; }
        public double[][] G0 { get; set; }
        public Dictionary<string, double> Core { get; set; }
        public double[][][] Raw { get; set; }
    }
}
