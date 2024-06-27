using System.Collections.Generic;
using MaterialsProject.Responses.Enums;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class CalcsReversed
    {
        public string VaspVersion { get; set; }
        public bool HasVaspCompleted { get; set; }
        public long Nsites { get; set; }
        public bool? IsHubbard { get; set; }
        public Dictionary<ChemicalSymbol, float> Hubbards { get; set; }
        public List<ChemicalSymbol> Elements { get; set; }
        public long Nelements { get; set; }
        public string RunType { get; set; }
        public CalcsReversedInput Input { get; set; }
        public CalcsReversedOutput Output { get; set; }
        public string FormulaPretty { get; set; }
        public Dictionary<ChemicalSymbol, float> CompositionReduced { get; set; }
        public Dictionary<ChemicalSymbol, float> CompositionUnitCell { get; set; }
        public string FormulaAnonymous { get; set; }
        public string FormulaReducedAbc { get; set; }
        public string DirName { get; set; }
        public string CompletedAt { get; set; }
        public CalcsReversedTask Task { get; set; }
        public OutputFilePaths OutputFilePaths { get; set; }
        public double? Density { get; set; }
        public string DosCompression { get; set; }
        public string DosFsId { get; set; }
        public string BandstructureCompression { get; set; }
        public string BandstructureFsId { get; set; }
        public string ChgcarCompression { get; set; }
        public string ChgcarFsId { get; set; }
        public Dos Dos { get; set; }
        public BrandStructure Bandstructure { get; set; }
        public object Chgcar { get; set; }
        public string Aeccar0Compression { get; set; }
        public string Aeccar0FsId { get; set; }
        public string Aeccar1Compression { get; set; }
        public string Aeccar1FsId { get; set; }
        public string Aeccar2Compression { get; set; }
        public string Aeccar2FsId { get; set; }
        public string ElfcarCompression { get; set; }
        public string ElfcarFsId { get; set; }
        public string LocpotCompression { get; set; }
        public string LocpotFsId { get; set; }

        /// <summary>
        /// Crystallographic Information Format file
        /// This is a CIF file.  CIF has been adopted by the International
        /// Union of Crystallography as the standard for data archiving and
        /// transmission.
        /// For information on this file format, follow the CIF links at
        /// http://www.iucr.org
        /// </summary>
        public object Cif { get; set; }
        public string PrettyFormula { get; set; }
        public Dictionary<ChemicalSymbol, double> ReducedCellFormula { get; set; }
        public object UnitCellFormula { get; set; }
    }
}
