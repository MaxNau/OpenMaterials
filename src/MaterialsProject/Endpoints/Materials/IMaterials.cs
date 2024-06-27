namespace MaterialsProject.Endpoints.Materials
{
    public interface IMaterials
    {
        ICore Core { get; }
        ITasks Tasks { get; }
        IThermo Thermo { get; }
        IDielectric Dielectric { get; }
        IMagnetism Magnetism { get; }
    }
}
