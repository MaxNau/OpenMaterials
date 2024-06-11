using MaterialsProject.Constants;
using Microsoft.Extensions.DependencyInjection;
using OScience.MaterialsProject;
using System;
using System.Net.Http;
using System.Threading;
using System.Xml.Linq;

namespace MaterialsProject.DependencyInjection.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private static readonly int DefaultPooledConnectionLifetimeInMinutes = 2;

        public static IServiceCollection AddMaterialsProjectClient(this IServiceCollection services, string apiKey, int pooledConnectionLifetimeInMinutes = 2)
        {
#if NET5_0_OR_GREATER
            var client = new HttpClient(
                new SocketsHttpHandler
                    {
                        PooledConnectionLifetime = TimeSpan.FromMinutes(pooledConnectionLifetimeInMinutes <= 0 ? DefaultPooledConnectionLifetimeInMinutes : pooledConnectionLifetimeInMinutes)
                    })
                {
                    BaseAddress = new Uri("https://api.materialsproject.org")
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
                    client.BaseAddress = new Uri("https://api.materialsproject.org");
                });
#endif
            return services;
        }
    }
}
