using MaterialsProject.Constants;
using ApiClient.Http.RequestData;

namespace MaterialsProject.RequestQueries.Tasks
{
    public class TaskDocQuery : IQueryStringParameters
    {
        public TaskDocQuery(string formula = default, string chemsys = default, string elements = default,
            string excludeElements = default, string taskIds = default)
        {
            Formula = formula;
            Chemsys = chemsys;
            Elements = elements;
            ExcludeElements = excludeElements;
            TaskIds = taskIds;
        }

        public string Formula { get; }
        public string Chemsys { get; }
        public string Elements { get; }

        [QueryParameter(StringLiterals.ExcludeElements)]
        public string ExcludeElements { get; }

        [QueryParameter(StringLiterals.TaskIds)]
        public string TaskIds { get; }

    }
}
