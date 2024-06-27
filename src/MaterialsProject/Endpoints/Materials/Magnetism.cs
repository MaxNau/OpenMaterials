using ApiClient.Http;
using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Materials.Magnetism;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Magnetism;
using System;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials
{
    internal class Magnetism : IMagnetism
    {
        private const string EndpointPath = "materials/magnetism/";

        private readonly IRestClient _restClient;
        public Magnetism(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));
        }

        public async Task<Response<MagnetismDoc>> GetAsync(MagnetismDocQuery magnetismDocQuery)
        {
            return await _restClient.GetAsync<Response<MagnetismDoc>>(EndpointPath).ConfigureAwait(false);
        }

        public async Task<Response<MagnetismDoc>> GetFullAsync(MagnetismDocQuery magnetismDocQuery)
        {
            return await _restClient.GetByQueryAsync<Response<MagnetismDoc>, MagnetismDocQuery, PagingQuery, MagnetismDocFilter>(EndpointPath, magnetismDocQuery, default, new MagnetismDocFilter(true)).ConfigureAwait(false);
        }

        public async Task<Response<MagnetismDoc>> GetAsync(MagnetismDocQuery magnetismDocQuery, MagnetismDocFilter magnetismDocFilter)
        {
            return await _restClient.GetByQueryAsync<Response<MagnetismDoc>, MagnetismDocQuery, PagingQuery, MagnetismDocFilter>(EndpointPath, magnetismDocQuery, default, magnetismDocFilter).ConfigureAwait(false);
        }

        public async Task<Response<MagnetismDoc>> GetAsync(MagnetismDocQuery magnetismDocQuery, PagingQuery pagingParameters, MagnetismDocFilter magnetismDocFilter)
        {
            return await _restClient.GetByQueryAsync<Response<MagnetismDoc>, MagnetismDocQuery, PagingQuery, MagnetismDocFilter>(EndpointPath, magnetismDocQuery, pagingParameters, magnetismDocFilter).ConfigureAwait(false);
        }
    }
}
