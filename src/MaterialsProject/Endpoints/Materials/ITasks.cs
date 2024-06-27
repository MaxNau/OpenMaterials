using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.Responses;
using MaterialsProject.RequestQueries;
using System.Threading.Tasks;
using MaterialsProject.Endpoints.Materials.Task;
using MaterialsProject.RequestQueries.Materials.Tasks;
using MaterialsProject.Responses.Materials.Tasks;

namespace MaterialsProject.Endpoints.Materials
{
    public interface ITasks
    {
        ITrajectory Trajectory { get; }
        IDeprecation Deprecation { get; }
        IEntries Entries { get; }
        Task<Response<TaskDoc>> GetAsync();
        Task<Response<TaskDoc>> GetFullAsync();
        Task<Response<TaskDoc>> GetAsync(TaskDocQuery taskDocQuery, PagingQuery pagingParameters);
        Task<Response<TaskDoc>> GetAsync(TaskDocQuery taskDocQuery, PagingQuery pagingParameters, TaskDocFilter taskDocFilter);
    }
}
