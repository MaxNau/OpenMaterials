using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OScience.Common.Serialization
{
    internal class SerializerFactory : ISerializerFactory
    {
        ISerializer ISerializerFactory.Create(string mimeType)
        {
            switch (mimeType)
            {
                case "application/json":
                    var jsonSerializerOptions = new JsonSerializerOptions()
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
                    };
                    
                    jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

                    return new TextJsonSerializer(jsonSerializerOptions);
            }

            throw new NotImplementedException();
        }
    }
}
