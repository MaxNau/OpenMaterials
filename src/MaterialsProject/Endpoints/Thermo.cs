using ApiClient.Http;
using MaterialsProject.Endpoints.MaterialsThermo;
using MaterialsProject.RequestQueries;
using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Thermo;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Thermo;
using System;
using System.Threading.Tasks;

namespace MaterialsProject.Endpoints
{
    internal class Thermo : IThermo
    {
        private const string EndpointPath = "materials/thermo/";

        private readonly IRestClient _restClient;

        public Thermo(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));

            InitEndpoints();
        }

        public IPhaseDiagram PhaseDiagram { get; private set; }

        public async Task<Response<ThermoDoc>> GetAsync()
        {
            return await _restClient.GetAsync<Response<ThermoDoc>>(EndpointPath).ConfigureAwait(false);
        }

        public async Task<Response<ThermoDoc>> GetFullAsync()
        {
            return await _restClient.GetByQueryAsync<Response<ThermoDoc>, ThermoDocQuery, PagingQuery, ThermoDocFilter>(EndpointPath, default, default, new ThermoDocFilter(true)).ConfigureAwait(false);
        }

        public async Task<Response<ThermoDoc>> GetAsync(ThermoDocQuery thermoDocQuery, PagingQuery pagingParameters)
        {
            return await _restClient.GetByQueryAsync<Response<ThermoDoc>, ThermoDocQuery, PagingQuery>(EndpointPath, thermoDocQuery, pagingParameters).ConfigureAwait(false);
        }

        public async Task<Response<ThermoDoc>> GetAsync(ThermoDocQuery thermoDocQuery, PagingQuery pagingParameters, ThermoDocFilter thermoDocFilter)
        {
            return await _restClient.GetByQueryAsync<Response<ThermoDoc>, ThermoDocQuery, PagingQuery, ThermoDocFilter>(EndpointPath, thermoDocQuery, pagingParameters, thermoDocFilter).ConfigureAwait(false);
        }

        private void InitEndpoints()
        {
            PhaseDiagram = new MaterialsThermo.PhaseDiagram(_restClient);
        }
    }
}
