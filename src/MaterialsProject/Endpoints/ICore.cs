using MaterialsProject.RequestQueries.Core;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials;
using OScience.MaterialsProject.RequestQueries;
using System.Threading.Tasks;

namespace OScience.MaterialsProject.Endpoints
{
    public interface ICore
    {
        Task<Response<MaterialsDoc>> GetAsync();
        Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingQuery pagingParameters);
        Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingQuery pagingParameters, MaterialsDocFilter materialsDocFilter);
    }
}
