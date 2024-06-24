using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Common
{
    public abstract class PymatgenModule
    {
        [JsonPropertyName("@module")]
        public string Module { get; set; }

        [JsonPropertyName("@class")]
        public string Class { get; set; }
    }
}
