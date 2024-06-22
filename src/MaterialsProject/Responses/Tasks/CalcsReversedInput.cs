using MaterialsProject.Responses.Common;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Tasks
{
    public class CalcsReversedInput
    {
        public Dictionary<string, object> Incar { get; set; }
        public Dictionary<string, object> Kpoints { get; set; }
        public long Nkpoints { get; set; }
        public List<string> Potcar { get; set; }
        public List<PotcarSpec> PotcarSpec { get; set; }
        public List<string> PotcarType { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
        public Lattice LatticeRec { get; set; }
        public Structure Structure { get; set; }
        public object Crystal { get; set; }
    }
}
