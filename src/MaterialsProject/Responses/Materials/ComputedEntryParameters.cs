using MaterialsProject.Responses.Enums;
using MaterialsProject.Responses.Tasks;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials
{
    public class ComputedEntryParameters
    {
        public List<PotcarSpec> PotcarSpec { get; set; }
        public bool IsHubbard { get; set; }
        public Dictionary<ChemicalSymbol, float> Hubbards { get; set; }
        public string RunType { get; set; }
    }
}
