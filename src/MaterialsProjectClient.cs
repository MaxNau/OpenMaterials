using OScience.Common.Cache;
using OScience.Common.Http;
using OScience.Common.Serialization;
using OScience.MaterialsProject.Endpoints;
using System;
using System.Net.Http;
using System.Reflection;

namespace OScience.MaterialsProject
{
    public class MaterialsProjectClient : RestClient, IMaterialsProjectClient
    {
        public MaterialsProjectClient(HttpClient client, string apiKey)
            : base(SetBaseUri(client), new SerializerFactory())
        {
            TypePropertiesToStringCallCache.Precompile(Assembly.GetAssembly(typeof(MaterialsProjectClient)));
            AddDefaultRequestHeaders("X-API-KEY", apiKey);
            Core = new Core(this);
        }

        public ICore Core { get; }

        private static HttpClient SetBaseUri(HttpClient client)
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("https://api.materialsproject.org");
            }
            return client;
        }
    }
}
