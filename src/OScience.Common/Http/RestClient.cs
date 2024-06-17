using OScience.Common.Cache;
using OScience.Common.Extensions;
using OScience.Common.RequestData;
using OScience.Common.Serialization;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OScience.Common.Http
{
    public class RestClient : IRestClient
    {
        private readonly HttpClient _client;
        private readonly ISerializerFactory _serializerFactory;
        private IToStringCallCache<IQueryStringParameters> _queryStringParametersToStringCallCache;
        private IToStringCallCache<IFieldFilter> _fieldFilterToStringCallCache;
        protected RestClient(HttpClient client, ISerializerFactory serializerFactory)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _serializerFactory = serializerFactory ?? throw new ArgumentNullException(nameof(serializerFactory));
        }

        internal RestClient(HttpClient client, ISerializerFactory serializerFactory, IToStringCallCache<IQueryStringParameters> toStringCallCache)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _serializerFactory = serializerFactory ?? throw new ArgumentNullException(nameof(serializerFactory));
            _queryStringParametersToStringCallCache = toStringCallCache ?? throw new ArgumentNullException(nameof(toStringCallCache));
        }

        internal void SetCache(
            IToStringCallCache<IQueryStringParameters> queryStringParametersToStringCallCache,
            IToStringCallCache<IFieldFilter> fieldFilterToStringCallCache)
        {
            _queryStringParametersToStringCallCache = queryStringParametersToStringCallCache ?? throw new ArgumentNullException(nameof(queryStringParametersToStringCallCache));
            _fieldFilterToStringCallCache = fieldFilterToStringCallCache ?? throw new ArgumentException(nameof(fieldFilterToStringCallCache));
        }

        async Task<T> IRestClient.GetAsync<T>(string requestUri, string mimeType)
        {
            var serializer = _serializerFactory.Create(mimeType);
            var response = await _client.GetAsync(requestUri).ConfigureAwait(false);
            var streamResult = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            return await serializer.DeserializeAsync<T>(streamResult).ConfigureAwait(false);
        }

        async Task<T> IRestClient.GetByQuery<T, QueryParam, PagingQueryParam>(string requestUri, QueryParam queryString, PagingQueryParam pagingQuery, string mimeType)
        {
            return await GetByQueryInternal<T, QueryParam, PagingQueryParam, IFieldFilter>(requestUri, mimeType, queryString, pagingQuery, default).ConfigureAwait(false);
        }

        async Task<T> IRestClient.GetByQuery<T, QueryParam, PagingQueryParam, FieldFilterParam>(string requestUri, QueryParam queryString, PagingQueryParam pagingQuery, FieldFilterParam fieldFilterQuery, string mimeType)
        {
            return await GetByQueryInternal<T, QueryParam, PagingQueryParam, FieldFilterParam>(requestUri, mimeType, queryString, pagingQuery, fieldFilterQuery).ConfigureAwait(false);
        }

        internal async Task PostAsync<T>(string requestUri, RequestBody<T> body)
        {
            var response = await _client.PostAsync(requestUri, body.GetContent()).ConfigureAwait(false);
        }

        internal void AddDefaultRequestHeaders(string name, string value)
        {
            _client.DefaultRequestHeaders.Add(name, value);
        }

        private async Task<T> GetByQueryInternal<T, QueryParam, PagingQueryParam, FieldFilterParam>(string requestUri, string mimeType, QueryParam query, PagingQueryParam pagingQuery = default, FieldFilterParam fieldFilterQuery = default)
            where QueryParam : IQueryStringParameters
            where PagingQueryParam: IQueryStringParameters
            where FieldFilterParam : class, IFieldFilter
        {
            var pagingQueryString = pagingQuery?.ToQueryString<PagingQueryParam>(_queryStringParametersToStringCallCache);
            var queryString = query.ToQueryString<QueryParam>(_queryStringParametersToStringCallCache);

            var cacheAdapter = new ToStringCallCacheAdapter<FieldFilterParam>(_fieldFilterToStringCallCache);
            var fieldFilterQueryString = fieldFilterQuery.GetFilterQuery(cacheAdapter);

            var uriQueryBuilder = new UriQueryBuilder(_client.BaseAddress.ToString());

            uriQueryBuilder.AppendQuery(queryString);
            uriQueryBuilder.AppendQuery(pagingQueryString);
            uriQueryBuilder.AppendQuery(fieldFilterQueryString);
            uriQueryBuilder.SetPath(requestUri);

            var serializer = _serializerFactory.Create(mimeType);
            var response = await _client.GetAsync(uriQueryBuilder.Build()).ConfigureAwait(false);
            using (var streamResult = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
            {
                return await serializer.DeserializeAsync<T>(streamResult).ConfigureAwait(false);
            }
        }

        private void AppendAdditionalQueryParameters(UriBuilder builder, string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                builder.Query += string.IsNullOrEmpty(builder.Query) ? query : $"&{query}";
            }
        }
    }
}
