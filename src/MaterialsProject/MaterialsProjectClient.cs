﻿using MaterialsProject.Constants;
using MaterialsProject.Endpoints;
using ApiClient.Http.Cache;
using ApiClient.Http;
using ApiClient.Http.RequestData;
using ApiClient.Http.Serialization;
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
            SetApiKey(client, apiKey);
            SetDefaultRequestHeaders(client);

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
            SetApiKey(client, apiKey);
            SetDefaultRequestHeaders(client);

            InitEndpoints();
        }

        public ICore Core { get; private set; }
        public ITasks Tasks { get; private set; }
        public IThermo Thermo { get; private set; }
        public IDielectric Dielectric { get; private set; }

        private void InitEndpoints()
        {
            Core = new Core(this);
            Tasks = new Tasks(this);
            Thermo = new Thermo(this);
            Dielectric = new Dielectric(this);
        }

        private void SetApiKey(HttpClient client, string apiKey)
        {
            bool apiKeyHeaderExists = client.DefaultRequestHeaders.Contains(MaterialsProjectHeaderNames.ApiKey);

            if (string.IsNullOrEmpty(apiKey))
            {
                if (!apiKeyHeaderExists)
                {
                    throw new ArgumentNullException(nameof(apiKey), "API key is required and was not provided.");
                }
            }
            else if (!apiKeyHeaderExists)
            {
                client.DefaultRequestHeaders.Add(MaterialsProjectHeaderNames.ApiKey, apiKey);
            }
        }

        private void SetDefaultRequestHeaders(HttpClient client)
        {
            AddDefaultRequestHeaders("User-Agent", "MaterialsProjectClient/1.0.0");
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
