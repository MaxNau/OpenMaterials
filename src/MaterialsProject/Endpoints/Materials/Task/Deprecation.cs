using ApiClient.Http;
using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.Materials.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Tasks;
using System;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials.Task
{
    internal class Deprecation : IDeprecation
    {
        private readonly IRestClient _restClient;
        public Deprecation(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));
        }

        public async Task<Response<DeprecationDoc>> GetAsync(DeprecationDocQuery deprecationDocQuery, PagingQuery pagingParameters)
        {
            return await _restClient.GetByQueryAsync<Response<DeprecationDoc>, DeprecationDocQuery, PagingQuery>("materials/tasks/deprecation/", deprecationDocQuery, pagingParameters).ConfigureAwait(false);
        }
    }
}
