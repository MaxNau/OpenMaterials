using MaterialsProject.RequestQueries.Core;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials;
using OScience.MaterialsProject.RequestParameters;
using System.Threading.Tasks;

namespace OScience.MaterialsProject.Endpoints
{
    public interface ICore
    {
        Task<Response<MaterialsDoc>> GetAsync();
        Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingParameters pagingParameters);
        Task<Response<MaterialsDoc>> GetAsync(MaterialsQuery materialsParameters, PagingParameters pagingParameters, MaterialsDocFilter materialsDocFilter);
    }
}
