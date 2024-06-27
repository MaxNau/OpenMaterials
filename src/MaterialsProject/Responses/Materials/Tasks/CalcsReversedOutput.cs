using MaterialsProject.Responses.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class CalcsReversedOutput
    {
        public List<IonicStep> IonicSteps { get; set; }
        public double? Efermi { get; set; }
        public double? Bandgap { get; set; }
        public double? Cbm { get; set; }
        public double? Vbm { get; set; }
        public bool IsGapDirect { get; set; }
        public List<object> EpsilonStatic { get; set; }
        public List<object> EpsilonStaticWolfe { get; set; }
        public List<object> EpsilonIonic { get; set; }
        public Structure Structure { get; set; }
        public double Energy { get; set; }
        public double EnergyPerAtom { get; set; }
        public bool IsMetal { get; set; }
        public double DirectGap { get; set; }
        public Outcar Outcar { get; set; }
        public object EigenvalueBandProperties { get; set; }
        public object Locpot { get; set; }
        public object NormalmodeEigenvals { get; set; }
        public object Dielectric { get; set; }
        public double[] OpticalAbsorptionCoeff { get; set; }
        public object FinalEnergyPerAtom { get; set; }
        public object Crystal { get; set; }
        public object ProjectedEigenvalues { get; set; }
        public object Eigenvalues { get; set; }
        public object FinalEnergy { get; set; }
    }
}
