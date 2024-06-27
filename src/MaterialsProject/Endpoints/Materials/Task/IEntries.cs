using MaterialsProject.Responses;
using MaterialsProject.RequestQueries;
using System.Threading.Tasks;
using MaterialsProject.RequestQueries.Materials.Tasks;
using MaterialsProject.Responses.Materials.Tasks;

namespace MaterialsProject.Endpoints.Materials.Task
{
    public interface IEntries
    {
        Task<Response<EntryDoc>> GetFullAsync();

        Task<Response<EntryDoc>> GetAsync(EntryDocQuery entryDocQuery, PagingQuery pagingParameters);
    }
}
