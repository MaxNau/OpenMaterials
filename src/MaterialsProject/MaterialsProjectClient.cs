﻿using MaterialsProject.Constants;
using MaterialsProject.Endpoints;
using ApiClient.Http.Cache;
using ApiClient.Http;
using ApiClient.Http.RequestData;
using ApiClient.Http.Serialization;
using MaterialsProject.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace MaterialsProject
{
    public class MaterialsProjectClient : RestClient, IMaterialsProjectClient
    {
        public MaterialsProjectClient(HttpClient client, string apiKey = null)
            : base(SetBaseUri(client), new SerializerFactory())
        {
            ICachePrecompiler<MaterialsProjectClient> cachePrecompiler = new CachePrecompiler<MaterialsProjectClient>();
            var typePropertyNamesCache = new TypePropertyNamesCache<IFieldFilter>();
            var typePropertiesToStringCallCache = new TypePropertiesToStringCallCache<IQueryStringParameters>();

            cachePrecompiler.PrecompileCache(typePropertyNamesCache, typePropertiesToStringCallCache);
            SetCache(typePropertiesToStringCallCache, typePropertyNamesCache);

            if (string.IsNullOrEmpty(apiKey) && !client.DefaultRequestHeaders.Contains(MaterialsProjectHeaderNames.ApiKey))
            {
                new ArgumentNullException(nameof(apiKey));
            }
            else
            {
                AddDefaultRequestHeaders(MaterialsProjectHeaderNames.ApiKey, apiKey);
            }

            InitEndpoints();
        }

        internal MaterialsProjectClient(
            HttpClient client,
            IReadOnlyCollection<IPrecompiledCache> precompiledCaches,
            ICachePrecompiler<MaterialsProjectClient> cachePrecompiler,
            string apiKey = null)
        : base(SetBaseUri(client), new SerializerFactory())
        {
            cachePrecompiler.PrecompileCache(precompiledCaches.ToArray());
            SetCache(
                precompiledCaches.OfType<IToStringCallCache<IQueryStringParameters>>().FirstOrDefault(),
                precompiledCaches.OfType<IToStringCallCache<IFieldFilter>>().FirstOrDefault());

            if (string.IsNullOrEmpty(apiKey) && !client.DefaultRequestHeaders.Contains(MaterialsProjectHeaderNames.ApiKey))
            {
                new ArgumentNullException(nameof(apiKey));
            }
            else
            {
                AddDefaultRequestHeaders(MaterialsProjectHeaderNames.ApiKey, apiKey);
            }

            InitEndpoints();
        }

        public ICore Core { get; private set; }
        public ITasks Tasks { get; private set; }

        private void InitEndpoints()
        {
            Core = new Core(this);
            Tasks = new Tasks(this);
        }

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
