using MaterialsProject.Responses.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class Transformations : PymatgenModule
    {
        public List<Dictionary<string, object>> Charge { get; set; }
        public Lattice Lattice { get; set; }
        public Site[] Sites { get; set; }
        public object History { get; set; }
        public string LastModified { get; set; }
        public object OtherParameters { get; set; }

        [JsonPropertyName("@version")]
        public Version Version { get; set; }
    }
}
