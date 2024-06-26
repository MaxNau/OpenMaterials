using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Thermo;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Thermo;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.MaterialsThermo
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
