using ApiClient.Http.RequestData;
using MaterialsProject.Constants;

namespace MaterialsProject.RequestQueries.Tasks
{
    public class TrajectoryDocQuery : IQueryStringParameters
    {
        [QueryParameter(StringLiterals.TaskIds)]
        public string TaskIds { get; }
    }
}
