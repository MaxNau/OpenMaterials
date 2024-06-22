using MaterialsProject.Endpoints;
using OScience.MaterialsProject.Endpoints;

namespace OScience.MaterialsProject
{
    public interface IMaterialsProjectClient
    {
        ICore Core { get; }
        ITasks Tasks { get; }
    }
}
