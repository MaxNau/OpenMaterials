using MaterialsProject.Constants;
using OScience.Common.RequestData;

namespace OScience.MaterialsProject.RequestQueries.Clauses
{
    internal interface IInQuery
    {
        [QueryParameter(StringLiterals.EqualsAny)]
        string In { get; }
        [QueryParameter(StringLiterals.NotEqualsAny)]
        string NotIn { get; }
    }
}
