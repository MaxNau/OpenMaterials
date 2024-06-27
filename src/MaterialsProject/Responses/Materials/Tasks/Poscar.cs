using MaterialsProject.Responses.Common;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class Poscar : PymatgenModule
    {
        // Associated Structure
        public Structure Structure { get; set; }

        // Boolean indication whether Poscar contains actual real names parsed
        // from either a POTCAR or the POSCAR itself
        public bool TrueNames { get; set; }

        // Selective dynamics attribute for each site if available.
        // A Nx3 array of booleans
        public object SelectiveDynamics { get; set; }

        // Velocities for each site (typically read in from a CONTCAR).
        // A Nx3 array of floats.
        public object Velocities { get; set; }

        // Predictor corrector coordinates and derivatives for each site;
        // i.e.a list of three 1x3 arrays for each site(typically read in from an MD CONTCAR)
        public object PredictorCorrector { get; set; }

        // Optional comment string
        public string Comment { get; set; }
    }
}
