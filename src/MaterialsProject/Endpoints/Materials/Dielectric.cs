using ApiClient.Http;
using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Materials.Dielectric;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Dielectric;
using System;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials
{
    internal class Dielectric : IDielectric
    {
        private const string EndpointPath = "materials/dielectric/";

        private readonly IRestClient _restClient;
        public Dielectric(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));
        }

        public async Task<Response<DielectricDoc>> GetAsync(DielectricDocQuery dielectricDocQuery)
        {
            return await _restClient.GetAsync<Response<DielectricDoc>>(EndpointPath).ConfigureAwait(false);
        }

        public async Task<Response<DielectricDoc>> GetFullAsync(DielectricDocQuery dielectricDocQuery)
        {
            return await _restClient.GetByQueryAsync<Response<DielectricDoc>, DielectricDocQuery, PagingQuery, DielectrictDocFilter>(EndpointPath, dielectricDocQuery, default, new DielectrictDocFilter(true)).ConfigureAwait(false);
        }

        public async Task<Response<DielectricDoc>> GetAsync(DielectricDocQuery dielectricDocQuery, DielectrictDocFilter dielectrictDocFilter)
        {
            return await _restClient.GetByQueryAsync<Response<DielectricDoc>, DielectricDocQuery, PagingQuery, DielectrictDocFilter>(EndpointPath, dielectricDocQuery, default, dielectrictDocFilter).ConfigureAwait(false);
        }

        public async Task<Response<DielectricDoc>> GetAsync(DielectricDocQuery dielectricDocQuery, PagingQuery pagingParameters, DielectrictDocFilter dielectrictDocFilter)
        {
            return await _restClient.GetByQueryAsync<Response<DielectricDoc>, DielectricDocQuery, PagingQuery, DielectrictDocFilter>(EndpointPath, dielectricDocQuery, pagingParameters, dielectrictDocFilter).ConfigureAwait(false);
        }
    }
}
