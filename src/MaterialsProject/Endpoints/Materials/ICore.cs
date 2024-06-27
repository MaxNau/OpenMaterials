using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.Responses;
using MaterialsProject.RequestQueries;
using System.Threading.Tasks;
using MaterialsProject.RequestQueries.Materials.Core;
using MaterialsProject.Responses.Materials.Core;

namespace MaterialsProject.Endpoints.Materials
{
    public interface ICore
    {
        Task<Response<MaterialsDoc>> GetAsync();
        Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingQuery pagingParameters);
        Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingQuery pagingParameters, MaterialsDocFilter materialsDocFilter);
    }
}
