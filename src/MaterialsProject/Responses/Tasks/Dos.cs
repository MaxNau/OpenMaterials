using MaterialsProject.Responses.Common;

namespace MaterialsProject.Responses.Tasks
{
    public class Dos : PymatgenModule
    {
        public double Efermi { get; set; }
        public Structure Structure { get; set; }
        public double?[] Energies { get; set; }
        public object Densities { get; set; }
        public object Pdos { get; set; }
        public object AtomDos { get; set; }
        public object SpdDos { get; set; }
    }
}
