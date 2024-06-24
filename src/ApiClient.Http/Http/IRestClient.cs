using ApiClient.Http.RequestData;
using System.Threading.Tasks;

namespace ApiClient.Http
{
    internal interface IRestClient
    {
        Task<T> GetAsync<T>(string requestUri, string mimeType = "application/json");
        Task<T> GetByQueryAsync<T, QueryParam, PagingQueryParam>(string requestUri, QueryParam queryString, PagingQueryParam pagingQuery = default, string mimeType = "application/json")
            where QueryParam : IQueryStringParameters
            where PagingQueryParam : IQueryStringParameters;

        Task<T> GetByQueryAsync<T, QueryParam, PagingQueryParam, FieldFilterParam>(string requestUri, QueryParam queryString, PagingQueryParam pagingQuery, FieldFilterParam fieldFilterQuery, string mimeType = "application/json")
            where QueryParam : IQueryStringParameters
            where PagingQueryParam : IQueryStringParameters
            where FieldFilterParam: class, IFieldFilter;
    }
}
