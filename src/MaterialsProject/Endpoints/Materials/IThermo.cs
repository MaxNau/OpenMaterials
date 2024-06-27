using MaterialsProject.Endpoints.Materials.MaterialsThermo;
using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Materials.Thermo;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Thermo;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials
{
    /// <summary>
    /// Route providing computed thermodynamic data for a material
    /// such as formation energy and energy above hull.
    /// </summary>
    public interface IThermo
    {
        IPhaseDiagram PhaseDiagram { get; }
        Task<Response<ThermoDoc>> GetAsync();
        Task<Response<ThermoDoc>> GetFullAsync();
        Task<Response<ThermoDoc>> GetAsync(ThermoDocQuery thermoDocQuery, PagingQuery pagingParameters);
        Task<Response<ThermoDoc>> GetAsync(ThermoDocQuery thermoDocQuery, PagingQuery pagingParameters, ThermoDocFilter thermoDocFilter);
    }
}
