using OScience.Common.RequestData;

namespace OScience.MaterialsProject.RequestQueries.Clauses
{
    internal interface IInQuery
    {
        [QueryParameter("eq_any")]
        string In { get; }
        [QueryParameter("neq_any")]
        string NotIn { get; }
    }
}
