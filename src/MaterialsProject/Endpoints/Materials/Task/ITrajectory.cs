using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.Materials.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Tasks;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials.Task
{
    public interface ITrajectory
    {
        Task<Response<TrajectoryDoc>> GetFullAsync();

        Task<Response<TrajectoryDoc>> GetAsync(TrajectoryDocQuery trajectoryDocQuery, PagingQuery pagingParameters);
    }
}
