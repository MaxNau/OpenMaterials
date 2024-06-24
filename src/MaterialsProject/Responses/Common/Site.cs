namespace MaterialsProject.Responses.Common
{
    public class Site
    {
        public Species[] Species { get; set; }
        public double[] Abc { get; set; }
        public double[] Xyz { get; set; }
        public SiteProperties Properties { get; set; }
        public string Label { get; set; }
    }
}
