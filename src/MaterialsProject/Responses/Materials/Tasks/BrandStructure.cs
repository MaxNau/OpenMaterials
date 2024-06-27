using MaterialsProject.Responses.Common;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class BrandStructure : PymatgenModule
    {
        public Lattice LatticeRec { get; set; }
        public double Efermi { get; set; }
        public double[][] Kpoints { get; set; }
        public object Bands { get; set; }
        public bool IsMetal { get; set; }
        public object Vbm { get; set; }
        public object Cbm { get; set; }
        public BandGap BandGap { get; set; }
        public object LabelsDict { get; set; }
        public bool IsSpinPolarized { get; set; }
        public object Projections { get; set; }
    }
}
