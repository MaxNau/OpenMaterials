namespace MaterialsProject.RequestQueries.FieldFilters
{
    public class TaskDocFilter : MaterialFilter
    {
        public TaskDocFilter(bool includeAllFields = false)
            :base(includeAllFields)
        {   
        }

        public bool Tags { get; set; }
        public bool TaskId { get; set; }
        public bool CalcsReversed { get; set; }
    }
}
