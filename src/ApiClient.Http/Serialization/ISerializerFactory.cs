namespace ApiClient.Http.Serialization
{
    public interface ISerializerFactory
    {
        ISerializer Create(string mimeType);
    }
}
