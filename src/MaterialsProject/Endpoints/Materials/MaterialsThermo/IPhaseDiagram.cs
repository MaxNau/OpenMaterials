using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Materials.Thermo;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Thermo;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials.MaterialsThermo
{
    /// <summary>
    /// Get PhaseDiagramDoc documents
    /// </summary>
    public interface IPhaseDiagram
    {
        Task<Response<PhaseDiagramDoc>> GetAsync(PhaseDiagramDocQuery phaseDiagramDocQuery, PhaseDiagramDocFilter phaseDiagramDocFilter);
        Task<Response<PhaseDiagramDoc>> GetAsync(PhaseDiagramDocQuery phaseDiagramDocQuery);
        Task<Response<PhaseDiagramDoc>> GetFullAsync();
    }
}
