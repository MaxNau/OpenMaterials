using ApiClient.Http;
using System;

namespace MaterialsProject.Endpoints.Materials
{
    internal class Materials : IMaterials
    {
        private readonly IRestClient _restClient;
        public Materials(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));

            InitEndpoints();
        }

        public ICore Core { get; private set; }
        public ITasks Tasks { get; private set; }
        public IThermo Thermo { get; private set; }
        public IDielectric Dielectric { get; private set; }

        private void InitEndpoints()
        {
            Core = new Core(_restClient);
            Tasks = new Tasks(_restClient);
            Thermo = new Thermo(_restClient);
            Dielectric = new Dielectric(_restClient);
        }
    }
}
