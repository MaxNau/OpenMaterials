using MaterialsProject.Responses.Common;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Thermo
{
    public class StructureMatcher : PymatgenModule
    {
        public new string Version { get; set; }
        public Comparator Comparator { get; set; }

        public double Stol { get; set; }

        public double Ltol { get; set; }

        public long AngleTol { get; set; }

        public bool PrimitiveCell { get; set; }

        public bool Scale { get; set; }

        public bool AttemptSupercell { get; set; }

        public bool AllowSubset { get; set; }

        public string SupercellSize { get; set; }

        public List<object> IgnoredSpecies { get; set; }
    }
}
