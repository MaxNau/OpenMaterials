using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Tasks;
using MaterialsProject.RequestQueries;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints
{
    public interface ITasks
    {
        IEntries Entries { get; }
        Task<Response<TaskDoc>> GetAsync();
        Task<Response<TaskDoc>> GetFullAsync();
        Task<Response<TaskDoc>> GetAsync(TaskDocQuery taskDocQuery, PagingQuery pagingParameters);
        Task<Response<TaskDoc>> GetAsync(TaskDocQuery taskDocQuery, PagingQuery pagingParameters, TaskDocFilter taskDocFilter);
    }
}
