using ApiClient.Http.Serialization;
using System.Net.Http;
using System.Text;

namespace ApiClient.Http.RequestData
{
    internal class RequestBody<T>
    {
        private readonly T _data;
        private readonly string _mimeType;
        private readonly ISerializer _serializer;

        internal RequestBody(T data, string mimeType, ISerializer serializer)
        {
            _data = data;
            _mimeType = mimeType;
            _serializer = serializer;
        }

        internal HttpContent GetContent()
        {
            return new StringContent(_serializer.Serialize(_data), Encoding.UTF8, _mimeType);
        }
    }
}
