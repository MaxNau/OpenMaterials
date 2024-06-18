namespace MaterialsProject.Responses.Common
{
    public class Lattice
    {
        public double[][] Matrix { get; set; }
        public bool[] Pbc { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Alpha { get; set; }
        public double Beta { get; set; }
        public double Gamma { get; set; }
        public double Volume { get; set; }
    }
}
