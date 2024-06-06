using System;
using System.Text.Json;

namespace OScience.Common.Serialization
{
    internal class SerializerFactory : ISerializerFactory
    {
        ISerializer ISerializerFactory.Create(string mimeType)
        {
            switch (mimeType)
            {
                case "application/json":
                    return new TextJsonSerializer(new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower });
            }

            throw new NotImplementedException();
        }
    }
}
