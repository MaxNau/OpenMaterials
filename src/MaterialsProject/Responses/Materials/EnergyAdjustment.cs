using MaterialsProject.Responses.Common;
using MaterialsProject.Responses.Thermo;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Materials
{
    public class EnergyAdjustment : PymatgenModule
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Value { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Uncertainty { get; set; }
        public string Name { get; set; }
        public Cls Cls { get; set; }
        public string Description { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? AdjPerAtom { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? NAtoms { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? UncertaintyPerAtom { get; set; }
    }
}
