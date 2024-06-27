using MaterialsProject.RequestQueries.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Tasks;
using MaterialsProject.RequestQueries;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Task
{
    public interface IEntries
    {
        Task<Response<EntryDoc>> GetFullAsync();

        Task<Response<EntryDoc>> GetAsync(EntryDocQuery entryDocQuery, PagingQuery pagingParameters);
    }
}
