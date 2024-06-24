using System.Collections.Generic;

namespace MaterialsProject.Responses.Tasks
{
    public class NmrEfg
    {
        public double[][][] Raw { get; set; }
        public List<EfgParameters> Parameters { get; set; }
    }
}
