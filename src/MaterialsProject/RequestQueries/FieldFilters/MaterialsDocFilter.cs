namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class MaterialsDocFilter : IFieldFilter
    {
        public bool BuilderMeta { get; set; }

        public string GetFilter()
        {
            return "builder_meta";
        }
    }
}
