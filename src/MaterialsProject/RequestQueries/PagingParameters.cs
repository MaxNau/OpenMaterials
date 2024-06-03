using MaterialsProject.Constants;
using OScience.Common.RequestData;

namespace OScience.MaterialsProject.RequestParameters
{
    public sealed class PagingParameters : IQueryStringParameters
    {
        public PagingParameters(int? page = null, int? perPage = null, int? skip = null, int? limit = null)
        {
            Page = page;
            PerPage = perPage;
            Skip = skip;
            Limit = limit;
        }

        [QueryParameter(StringLiterals.Page)]
        public int? Page { get; }

        [QueryParameter(StringLiterals.PerPage)]
        public int? PerPage { get; }

        [QueryParameter(StringLiterals.Skip)]
        public int? Skip { get; }

        [QueryParameter(StringLiterals.Limit)]
        public int? Limit { get; }
    }
}
