using MaterialsProject.RequestQueries.Core;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials;
using MaterialsProject.RequestQueries;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints
{
    public interface ICore
    {
        Task<Response<MaterialsDoc>> GetAsync();
        Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingQuery pagingParameters);
        Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingQuery pagingParameters, MaterialsDocFilter materialsDocFilter);
    }
}
