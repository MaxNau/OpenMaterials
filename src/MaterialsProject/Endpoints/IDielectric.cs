using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.Dielectric;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Dielectric;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints
{
    public interface IDielectric
    {
        Task<Response<DielectricDoc>> GetAsync(DielectricDocQuery dielectricDocQuery);
        Task<Response<DielectricDoc>> GetFullAsync(DielectricDocQuery dielectricDocQuery);
        Task<Response<DielectricDoc>> GetAsync(DielectricDocQuery dielectricDocQuery, DielectrictDocFilter dielectrictDocFilter);
        Task<Response<DielectricDoc>> GetAsync(DielectricDocQuery dielectricDocQuery, PagingQuery pagingParameters, DielectrictDocFilter dielectrictDocFilter);
    }
}
