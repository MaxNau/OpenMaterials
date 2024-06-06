using System;

namespace MaterialsProject.Responses.Materials
{
    public class MaterialsDoc
    {
        public string FormulaPretty { get; set; }

        public string MaterialId { get; set; }

        public DateTimeOffset LastUpdated { get; set; }
    }
}
