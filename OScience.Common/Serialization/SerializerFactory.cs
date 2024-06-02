using System;

namespace OScience.Common.Serialization
{
    internal class SerializerFactory : ISerializerFactory
    {
        ISerializer ISerializerFactory.Create(string mimeType)
        {
            switch (mimeType)
            {
                case "application/json":
                    return new TextJsonSerializer();
            }

            throw new NotImplementedException();
        }
    }
}
