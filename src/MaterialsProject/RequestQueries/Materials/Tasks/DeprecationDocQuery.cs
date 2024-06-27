using ApiClient.Http.RequestData;
using MaterialsProject.Constants;

namespace MaterialsProject.RequestQueries.Materials.Tasks
{
    public class DeprecationDocQuery : IQueryStringParameters
    {
        public DeprecationDocQuery(string taskIds)
        {
            if (string.IsNullOrWhiteSpace(taskIds))
            {
                throw new System.ArgumentException(nameof(taskIds));
            }

            TaskIds = taskIds;
        }

        [QueryParameter(StringLiterals.TaskIds)]
        public string TaskIds { get; }
    }
}
