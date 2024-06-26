using MaterialsProject.Endpoints;

namespace MaterialsProject
{
    public interface IMaterialsProjectClient
    {
        ICore Core { get; }
        ITasks Tasks { get; }
        IThermo Thermo { get; }
    }
}
