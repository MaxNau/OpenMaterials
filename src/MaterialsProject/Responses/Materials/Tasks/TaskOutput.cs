using MaterialsProject.Responses.Common;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class TaskOutput
    {
        public Structure Structure { get; set; }
        public double? Density { get; set; }
        public double? Energy { get; set; }
        public double? EnergyPerAtom { get; set; }
        public float?[][] Forces { get; set; }
        public float?[][] Stress { get; set; }
        public double? Bandgap { get; set; }
        public double? Cbm { get; set; }
        public double? Vbm { get; set; }
        public bool IsGapDirect { get; set; }
        public bool IsMetal { get; set; }
        public double? DirectGap { get; set; }

        //The static part of the dielectric constant.
        // Present only when it's a DFPT run (LEPSILON=TRUE)
        public float?[][] EpsilonStatic { get; set; }

        // The static part of the dielectric constant without any local
        // field effects.Present only when it's a DFPT run (LEPSILON=TRUE)
        public float?[][] EpsilonStaticWolfe { get; set; }

        // The ionic part of the static dielectric constant.
        // Present when it's a DFPT run (LEPSILON=TRUE) and IBRION=5, 6, 7 or 8
        public float?[][] EpsilonIonic { get; set; }
        public Spacegroup Spacegroup { get; set; }
        public double[][] PiezoTensor { get; set; }
        public double[][] PiezoIonicTensor { get; set; }
        //public object DielectricTensor { get; set; }
        //public object DielectricIonicTensor { get; set; }
        //public object BornIon { get; set; }
        //public object Born { get; set; }
        //public object InternalStrainTensor { get; set; }
        public double[] OpticalAbsorptionCoeff { get; set; }
        public Dielectric Dielectric { get; set; }
    }
}
