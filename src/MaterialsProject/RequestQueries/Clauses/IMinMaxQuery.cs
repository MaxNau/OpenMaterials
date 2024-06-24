using ApiClient.Http.RequestData;

namespace OScience.MaterialsProject.RequestQueries.Clauses
{
    public interface IMinMaxQuery
    {
        int? Max { get; }
        int? Min { get; }
    }
}
