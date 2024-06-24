using MaterialsProject.RequestQueries.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Tasks;
using MaterialsProject.RequestQueries;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints
{
    public interface IEntries
    {
        Task<Response<TaskEntry>> GetFullAsync();

        Task<Response<TaskEntry>> GetAsync(EntryDocQuery entryDocQuery, PagingQuery pagingParameters);
    }
}
