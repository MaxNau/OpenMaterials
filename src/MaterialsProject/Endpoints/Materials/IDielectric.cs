using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Materials.Dielectric;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Dielectric;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials
{
    public interface IDielectric
    {
        Task<Response<DielectricDoc>> GetAsync(DielectricDocQuery dielectricDocQuery);
        Task<Response<DielectricDoc>> GetFullAsync(DielectricDocQuery dielectricDocQuery);
        Task<Response<DielectricDoc>> GetAsync(DielectricDocQuery dielectricDocQuery, DielectrictDocFilter dielectrictDocFilter);
        Task<Response<DielectricDoc>> GetAsync(DielectricDocQuery dielectricDocQuery, PagingQuery pagingParameters, DielectrictDocFilter dielectrictDocFilter);
    }
}
