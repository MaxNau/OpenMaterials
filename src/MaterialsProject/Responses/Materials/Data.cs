using MaterialsProject.Responses.Enums;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials
{
    public class Data
    {
        public OxideType OxideType { get; set; }
        public bool Aspherical { get; set; }
        public object LastUpdated { get; set; }
        public string TaskId { get; set; }
        public string MaterialId { get; set; }
        public string CompletedAt { get; set; }
        public Dictionary<string, double> OxidationStates { get; set; }
        public string RunType { get; set; }
    }
}
