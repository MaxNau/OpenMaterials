using MaterialsProject.Responses.Enums;

namespace MaterialsProject.Responses.Common
{
    public class Species : PymatgenModule
    {
        public ChemicalSymbol Element { get; set; }
        public long Occu { get; set; }
    }
}
