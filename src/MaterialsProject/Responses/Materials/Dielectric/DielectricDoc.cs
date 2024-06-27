using MaterialsProject.Responses.Common;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials.Dielectric
{
    public class DielectricDoc : Material
    {
        public string PropertyName { get; set; }
        public string MaterialId { get; set; }
        public bool Deprecated { get; set; }
        public string DeprecationReasons { get; set; }
        public List<Origin> Origins { get; set; }
        public List<string> Warnings { get; set; }
        public double[][] Total { get; set; }
        public double[][] Ionic { get; set; }
        public double[][] Electronic { get; set; }
        public double? ETotal { get; set; }
        public double? EIonic { get; set; }
        public double? EElectronic { get; set; }
        public double? N { get; set; }
    }
}
