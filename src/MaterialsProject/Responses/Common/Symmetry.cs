using System;

namespace MaterialsProject.Responses.Common
{
    public class Symmetry
    {
        public string CrystalSystem { get; set; }
        public string Symbol { get; set; }
        public long Number { get; set; }
        public string PointGroup { get; set; }
        public double Symprec { get; set; }
        public Version Version { get; set; }
    }
}
