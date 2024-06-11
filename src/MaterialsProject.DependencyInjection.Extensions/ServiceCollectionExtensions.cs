using MaterialsProject.Configuration;
using MaterialsProject.Constants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OScience.MaterialsProject;
using System;
using System.Net.Http;

namespace MaterialsProject.DependencyInjection.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private static readonly int DefaultPooledConnectionLifetimeInMinutes = 2;

        public static IServiceCollection AddMaterialsProjectClient(this IServiceCollection services, string apiKey, string apiUrl = "https://api.materialsproject.org",
            int pooledConnectionLifetimeInMinutes = 2)
        {
            return RegisterMaterialsProjectClient(services, apiKey, apiUrl, pooledConnectionLifetimeInMinutes);
        }

        public static IServiceCollection AddMaterialsProjectClient(this IServiceCollection services, IConfiguration configuration,
           int pooledConnectionLifetimeInMinutes = 2)
        {
            var materialsProjectConfig = configuration.GetSection(MaterialsProjectConfiguration.MaterialsProjectConfigurationSectionName)
                .Get<MaterialsProjectConfiguration>();

            return RegisterMaterialsProjectClient(services, configuration: configuration, pooledConnectionLifetimeInMinutes: pooledConnectionLifetimeInMinutes);
        }

        private static IServiceCollection RegisterMaterialsProjectClient(IServiceCollection services, string apiKey = null, string apiUrl = "https://api.materialsproject.org",
            int pooledConnectionLifetimeInMinutes = 2, IConfiguration configuration = null)
        {
            if (configuration != null)
            {
                var materialsProjectConfig = configuration
                    .GetSection(MaterialsProjectConfiguration.MaterialsProjectConfigurationSectionName)
                    .Get<MaterialsProjectConfiguration>();
                
                if (materialsProjectConfig != null)
                {
                    apiKey = materialsProjectConfig.ApiKey;
                    apiUrl = materialsProjectConfig.Url;
                }
            }

#if NET5_0_OR_GREATER
            var client = new HttpClient(
                new SocketsHttpHandler
                    {
                        PooledConnectionLifetime = TimeSpan.FromMinutes(pooledConnectionLifetimeInMinutes <= 0 ? DefaultPooledConnectionLifetimeInMinutes : pooledConnectionLifetimeInMinutes)
                    })
                {
                    BaseAddress = new Uri(apiUrl)
                };
            
            services.AddSingleton<IMaterialsProjectClient, MaterialsProjectClient>(factory =>
            {
                return new MaterialsProjectClient(client, apiKey);
            });
#else
            services.AddHttpClient<IMaterialsProjectClient, MaterialsProjectClient>()
                .ConfigureHttpClient(client =>
                {
                    client.DefaultRequestHeaders.Add(MaterialsProjectHeaderNames.ApiKey, apiKey);
                    client.BaseAddress = new Uri(apiUrl);
                });
#endif

            return services;
        }
    }
}
