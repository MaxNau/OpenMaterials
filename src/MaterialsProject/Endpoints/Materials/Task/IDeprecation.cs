using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.Materials.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Tasks;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials.Task
{
    public interface IDeprecation
    {
        Task<Response<DeprecationDoc>> GetAsync(DeprecationDocQuery deprecationDocQuery, PagingQuery pagingParameters);
    }
}
