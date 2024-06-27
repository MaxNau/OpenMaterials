using MaterialsProject.Endpoints.Materials;

namespace MaterialsProject
{
    public interface IMaterialsProjectClient
    {
        IMaterials Materials { get; }
    }
}
