using ApiClient.Http;
using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Materials.Thermo;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Materials.Thermo;
using System;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints.Materials.MaterialsThermo
{
    internal class PhaseDiagram : IPhaseDiagram
    {
        private const string EndpointPath = "materials/thermo/phase_diagram/";
        private readonly IRestClient _restClient;
        public PhaseDiagram(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));
        }

        public async Task<Response<PhaseDiagramDoc>> GetAsync(PhaseDiagramDocQuery phaseDiagramDocQuery)
        {
            return await _restClient.GetByQueryAsync<Response<PhaseDiagramDoc>, PhaseDiagramDocQuery, PagingQuery, PhaseDiagramDocFilter>(EndpointPath, phaseDiagramDocQuery, default, new PhaseDiagramDocFilter(false)).ConfigureAwait(false);
        }

        public async Task<Response<PhaseDiagramDoc>> GetAsync(PhaseDiagramDocQuery phaseDiagramDocQuery, PhaseDiagramDocFilter phaseDiagramDocFilter)
        {
            return await _restClient.GetByQueryAsync<Response<PhaseDiagramDoc>, PhaseDiagramDocQuery, PagingQuery, PhaseDiagramDocFilter>(EndpointPath, phaseDiagramDocQuery, default, phaseDiagramDocFilter).ConfigureAwait(false);
        }

        public async Task<Response<PhaseDiagramDoc>> GetFullAsync()
        {
            return await _restClient.GetByQueryAsync<Response<PhaseDiagramDoc>, PhaseDiagramDocQuery, PagingQuery, PhaseDiagramDocFilter>(EndpointPath, default, default, new PhaseDiagramDocFilter(true)).ConfigureAwait(false);
        }
    }
}
