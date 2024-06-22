
namespace MaterialsProject.Responses.Common
{
    public class SiteProperties
    {
        public double Magmom { get; set; }

        // Velocities for each site (typically read in from a CONTCAR).
        // A Nx3 array of floats.
        public object Velocities { get; set; }
        public object SelectiveDynamics { get; set; }
    }
}
