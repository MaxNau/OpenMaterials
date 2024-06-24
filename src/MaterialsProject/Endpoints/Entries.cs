using ApiClient.Http;
using MaterialsProject.RequestQueries.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Tasks;
using MaterialsProject.RequestQueries;
using System;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints
{
    internal class Entries : IEntries
    {
        private readonly IRestClient _restClient;
        public Entries(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));
        }

        public async Task<Response<TaskEntry>> GetFullAsync()
        {
            return await _restClient.GetByQueryAsync<Response<TaskEntry>, EntryDocQuery, PagingQuery>("materials/tasks/entries/", default, default).ConfigureAwait(false);
        }

        public async Task<Response<TaskEntry>> GetAsync(EntryDocQuery entryDocQuery, PagingQuery pagingParameters)
        {
            return await _restClient.GetByQueryAsync<Response<TaskEntry>, EntryDocQuery, PagingQuery>("materials/tasks/entries/", entryDocQuery, pagingParameters).ConfigureAwait(false);
        }
    }
}
