namespace OScience.Common.Serialization
{
    public interface ISerializerFactory
    {
        ISerializer Create(string mimeType);
    }
}
