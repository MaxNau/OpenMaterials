using System.Collections.Generic;

namespace MaterialsProject.Responses.Common
{
    public class Structure : PymatgenModule
    {
        public List<Dictionary<string, object>> Charge { get; set; }
        public Lattice Lattice { get; set; }
        public Site[] Sites { get; set; }
        public object Properties { get; set; }
    }
}
