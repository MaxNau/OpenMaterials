using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Materials.Magnetism;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Magnetism;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials
{
    public interface IMagnetism
    {
        Task<Response<MagnetismDoc>> GetAsync(MagnetismDocQuery magnetismDocQuery);

        Task<Response<MagnetismDoc>> GetFullAsync(MagnetismDocQuery magnetismDocQuery);

        Task<Response<MagnetismDoc>> GetAsync(MagnetismDocQuery magnetismDocQuery, MagnetismDocFilter magnetismDocFilter);

        Task<Response<MagnetismDoc>> GetAsync(MagnetismDocQuery magnetismDocQuery, PagingQuery pagingParameters, MagnetismDocFilter magnetismDocFilter);
    }
}
