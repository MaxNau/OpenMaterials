using MaterialsProject.Responses.Enums;

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
    }
}
