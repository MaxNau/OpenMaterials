using System.Collections.Generic;

namespace MaterialsProject.Responses.Tasks
{
    public class OrigInputs
    {
        public Poscar Poscar { get; set; }
        public Dictionary<string, object> Incar { get; set; }
        public Dictionary<string, object> Kpoints { get; set; }
        public object Potcar { get; set; }
    }
}
