using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Tasks;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Task
{
    public interface ITrajectory
    {
        Task<Response<TrajectoryDoc>> GetFullAsync();

        Task<Response<TrajectoryDoc>> GetAsync(TrajectoryDocQuery trajectoryDocQuery, PagingQuery pagingParameters);
    }
}
