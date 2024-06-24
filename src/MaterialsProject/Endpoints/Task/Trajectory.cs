using ApiClient.Http;
using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Tasks;
using System;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Task
{
    internal class Trajectory : ITrajectory
    {
        private readonly IRestClient _restClient;
        public Trajectory(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));
        }

        public async Task<Response<TrajectoryDoc>> GetAsync(TrajectoryDocQuery trajectoryDocQuery, PagingQuery pagingParameters)
        {
            return await _restClient.GetByQueryAsync<Response<TrajectoryDoc>, TrajectoryDocQuery, PagingQuery>("materials/tasks/trajectory/", trajectoryDocQuery, pagingParameters).ConfigureAwait(false);
        }

        public async Task<Response<TrajectoryDoc>> GetFullAsync()
        {
            return await _restClient.GetByQueryAsync<Response<TrajectoryDoc>, TrajectoryDocQuery, PagingQuery>("materials/tasks/trajectory/", default, default).ConfigureAwait(false);
        }
    }
}
