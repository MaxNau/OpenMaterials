using MaterialsProject.Responses.Materials;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials.Thermo
{
    public class ComputedData
    {
        public double[][] Facets { get; set; }
        public List<Simplex> Simplexes { get; set; }
        public List<Entry> AllEntries { get; set; }
        public double[][] QhullData { get; set; }
        public double? Dim { get; set; }
        public object[][] ElRefs { get; set; }
        public List<Entry> QhullEntries { get; set; }
    }
}
