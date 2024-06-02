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

        [QueryParameter("_page")]
        public int? Page { get; }

        [QueryParameter("_per_page")]
        public int? PerPage { get; }

        [QueryParameter("_skip")]
        public int? Skip { get; }

        [QueryParameter("_limit")]
        public int? Limit { get; }
    }
}
