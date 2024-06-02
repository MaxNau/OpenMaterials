using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace OScience.Common.Serialization
{
    internal class TextJsonSerializer : ISerializer
    {
        private readonly JsonSerializerOptions _options;
        public TextJsonSerializer(JsonSerializerOptions options = null)
        {
            _options = options;
        }

        public async ValueTask<T> DeserializeAsync<T>(Stream stream)
        {
            return await JsonSerializer.DeserializeAsync<T>(stream, _options).ConfigureAwait(false);
        }

        public string Serialize<T>(T @object)
        {
            return JsonSerializer.Serialize(@object, @object.GetType(), _options);
        }
    }
}
