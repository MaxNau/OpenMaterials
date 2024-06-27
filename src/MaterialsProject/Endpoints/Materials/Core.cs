using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.Responses;
using ApiClient.Http;
using MaterialsProject.RequestQueries;
using System;
using System.Threading.Tasks;
using MaterialsProject.RequestQueries.Materials.Core;
using MaterialsProject.Responses.Materials.Core;

namespace MaterialsProject.Endpoints.Materials
{
    internal class Core : ICore
    {
        private readonly IRestClient _restClient;
        public Core(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));
        }

        public async Task<Response<MaterialsDoc>> GetAsync()
        {
            return await _restClient.GetAsync<Response<MaterialsDoc>>("materials/core/").ConfigureAwait(false);
        }

        public async Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingQuery pagingParameters)
        {
            return await _restClient.GetByQueryAsync<Response<MaterialsDoc>, MaterialsQuery, PagingQuery>("materials/core/", materialsParameters, pagingParameters).ConfigureAwait(false);
        }

        public async Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingQuery pagingParameters, MaterialsDocFilter materialsDocFilter)
        {
            return await _restClient.GetByQueryAsync<Response<MaterialsDoc>, MaterialsQuery, PagingQuery, MaterialsDocFilter>("materials/core/", materialsParameters, pagingParameters, materialsDocFilter).ConfigureAwait(false);
        }
    }
}
