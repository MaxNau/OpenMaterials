using OScience.Common.RequestData;
using System.Threading.Tasks;

namespace OScience.Common.Http
{
    internal interface IRestClient
    {
        Task<T> GetAsync<T>(string requestUri, string mimeType = "application/json");
        Task<T> GetByQuery<T, QueryParam, PagingQueryParam>(string requestUri, QueryParam queryString, PagingQueryParam pagingQuery = default, string mimeType = "application/json")
            where QueryParam : IQueryStringParameters
            where PagingQueryParam : IQueryStringParameters;
    }
}
