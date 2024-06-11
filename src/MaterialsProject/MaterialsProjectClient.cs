using MaterialsProject.Constants;
using OScience.Common.Cache;
using OScience.Common.Http;
using OScience.Common.RequestData;
using OScience.Common.Serialization;
using OScience.MaterialsProject.Endpoints;
using System;
using System.Net.Http;
using System.Reflection;

namespace OScience.MaterialsProject
{
    public class MaterialsProjectClient : RestClient, IMaterialsProjectClient
    {
        private readonly IToStringCallCache<IQueryStringParameters> _toStringCallCache;
        public MaterialsProjectClient(HttpClient client, string apiKey = null)
            : base(SetBaseUri(client), new SerializerFactory())
        {
            var typePropertiesToStringCallCache = new TypePropertiesToStringCallCache<IQueryStringParameters>();
            _toStringCallCache = typePropertiesToStringCallCache;
            IPrecompiledCache precompiledCache = typePropertiesToStringCallCache;
            precompiledCache.Precompile(Assembly.GetAssembly(typeof(MaterialsProjectClient)));
            SetCache(typePropertiesToStringCallCache);

            if (string.IsNullOrEmpty(apiKey) && !client.DefaultRequestHeaders.Contains(MaterialsProjectHeaderNames.ApiKey))
            {
                new ArgumentNullException(nameof(apiKey));
            }
            else
            {
                AddDefaultRequestHeaders(MaterialsProjectHeaderNames.ApiKey, apiKey);
            }

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
