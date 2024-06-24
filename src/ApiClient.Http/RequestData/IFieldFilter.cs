namespace ApiClient.Http.RequestData
{
    internal interface IFieldFilter : IQueryStringParameters
    {
        bool IncludeAllFields { get; }
    }
}
