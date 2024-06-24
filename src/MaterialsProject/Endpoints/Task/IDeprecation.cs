using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Tasks;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Task
{
    public interface IDeprecation
    {
        Task<Response<DeprecationDoc>> GetAsync(DeprecationDocQuery deprecationDocQuery, PagingQuery pagingParameters);
    }
}
