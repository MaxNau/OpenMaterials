using MaterialsProject.Constants;
using ApiClient.Http.RequestData;

namespace OScience.MaterialsProject.RequestQueries.Clauses
{
    internal interface IEqualsQuery
    {
        [QueryParameter(StringLiterals.Empty)]
        int? Equal { get; }
        [QueryParameter(StringLiterals.NotEquals)]
        int? NotEqual { get; }
    }
}
