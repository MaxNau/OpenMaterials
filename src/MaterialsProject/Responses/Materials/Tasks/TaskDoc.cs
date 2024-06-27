using MaterialsProject.Responses.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class TaskDoc : Material
    {
        [JsonPropertyName("meta")]
        public new BuilderMeta BuilderMeta { get; set; }
        public TaskOutput Output { get; set; }
        public List<CalcsReversed> CalcsReversed { get; set; }
        public string TaskId { get; set; }
        public OrigInputs OrigInputs { get; set; }
        public Transformations Transformations { get; set; }
        public object Input { get; set; }
    }
}
