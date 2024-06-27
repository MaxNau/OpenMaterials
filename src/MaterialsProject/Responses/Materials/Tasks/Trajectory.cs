using MaterialsProject.Responses.Common;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class Trajectory : PymatgenModule
    {
        public List<Species> Species { get; set; }
        public double[][][] Coords { get; set; }
        public List<Dictionary<string, object>> Charge { get; set; }
        public object SpinMultiplicity { get; set; }
        public double[][] Lattice { get; set; }
        public List<SiteProperties> SiteProperties { get; set; }
        public List<FrameProperty> FrameProperties { get; set; }
        public bool ConstantLattice { get; set; }
        public object TimeStep { get; set; }
        public bool CoordsAreDisplacement { get; set; }
        public double[][] BasePositions { get; set; }
    }
}
