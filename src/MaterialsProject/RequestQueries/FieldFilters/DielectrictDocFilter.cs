namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class DielectrictDocFilter : MaterialFilter
    {
        public DielectrictDocFilter(bool includeAllFields = false)
            :base(includeAllFields)
        {   
        }

        public bool PropertyName { get; set; }
        public bool Materialid { get; set; }
        public bool Depreceted { get; set; }
        public bool DeprecationReasons { get; set; }
        public bool Origins { get; set; }
        public bool Warnings { get; set; }
        public bool Total {  get; set; }
        public bool Ionic { get; set; }
        public bool Electronic { get; set; }
        public bool ETotal { get; set; }
        public bool EIonic { get; set; }
        public bool EElectronic { get; set; }
        public bool N { get; set; }
    }
}
