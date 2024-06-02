using OScience.Common.RequestData;

namespace OScience.MaterialsProject.RequestQueries.Clauses
{
    internal interface IEqualsQuery
    {
        [QueryParameter("")]
        int? Equal { get; }
        [QueryParameter("not_eq")]
        int? NotEqual { get; }
    }
}
