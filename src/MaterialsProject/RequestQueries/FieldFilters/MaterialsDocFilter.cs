
namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class MaterialsDocFilter : MaterialFilter
    {
        public MaterialsDocFilter(bool includeAllFields = false)
            : base(includeAllFields)
        {
        }

        public bool MaterialId { get; set; }
        public bool Deprecated { get; set; }
        public bool DeprecatedReasons { get; set; }
        public bool InitialStructures { get; set; }
        public bool TaskIds { get; set; }
        public bool DeprecatedTasks { get; set; }
        public bool CalcTypes { get; set; }
        public bool CreatedAt { get; set; }
        public bool Origins { get; set; }
        public bool Warnings { get; set; }
        public bool TaskTypes { get; set; }
        public bool RunTypes { get; set; }
    }
}
