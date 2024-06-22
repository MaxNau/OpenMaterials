namespace OScience.Common.RequestData
{
    internal interface IFieldFilter : IQueryStringParameters
    {
        bool IncludeAllFields { get; }
    }
}
