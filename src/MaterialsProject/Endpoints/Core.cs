using OScience.Common.Http;
using OScience.MaterialsProject.RequestParameters;
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

        public async Task<T> GetAsync<T>()
        {
            return await _restClient.GetAsync<T>("materials/core/");
        }

        public async Task<T> GetAsync<T>(MaterialsQuery materialsParameters, PagingParameters pagingParameters)
        {
            return await _restClient.GetByQuery<T, MaterialsQuery, PagingParameters>("materials/core/", materialsParameters, pagingParameters);
        }
    }
}
