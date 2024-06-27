namespace MaterialsProject.RequestQueries.Clauses
{
    public interface IMinMaxQuery
    {
        int? Max { get; }
        int? Min { get; }
    }
}
