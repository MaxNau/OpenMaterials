using System.Text.Json.Serialization;


namespace MaterialsProject.Responses.Materials.Thermo
{
    public class PhaseDiagramDoc : ThermoDoc
    {
        public string PhaseDiagramId { get; set; }

        public PhaseDiagram PhaseDiagram { get; set; }

        public string State { get; set; }

        [JsonPropertyName("_bt")]
        public object Bt { get; set; }
    }
}
