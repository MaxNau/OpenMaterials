using ApiClient.Http.RequestData;
using MaterialsProject.Constants;

namespace MaterialsProject.RequestQueries.Thermo
{
    public class PhaseDiagramDocQuery : ThermoDocQuery
    {
        public PhaseDiagramDocQuery(string phaseDiagramIds = default)
        {
            PhaseDiagramIds = phaseDiagramIds;
        }
        /// <summary>
        /// Comma-separated list of phase_diagram_id values to query on
        /// </summary>
        [QueryParameter(StringLiterals.PhaseDiagramIds)]
        public string PhaseDiagramIds { get; }
    }
}
