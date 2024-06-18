using MaterialsProject.RequestQueries.Core;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials;
using OScience.Common.Http;
using OScience.MaterialsProject.RequestQueries;
using System;
using System.Threading.Tasks;

namespace OScience.MaterialsProject.Endpoints
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
