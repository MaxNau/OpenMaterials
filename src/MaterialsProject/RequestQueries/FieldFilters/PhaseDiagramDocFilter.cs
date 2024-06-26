namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class PhaseDiagramDocFilter : ThermoDocFilter
    {
        public PhaseDiagramDocFilter(bool includeAllFields = false) 
            : base(includeAllFields)
        {
        }

        public bool PhaseDiagramIds { get; set; }
    }
}
