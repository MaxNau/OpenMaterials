using MaterialsProject.Responses.Common;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Tasks
{
    public class Outcar : PymatgenModule
    {
        /// <summary>
        /// efermi (float): Fermi energy.
        /// </summary>
        public double? Efermi { get; set; }

        /// <summary>
        /// magnetization (tuple): Magnetization on each ion as a tuple of dict, e.g.
        /// ({"d": 0.0, "p": 0.003, "s": 0.002, "tot": 0.005}, ... )
        /// </summary>
        public List<Dictionary<string, object>> Magnetization { get; set; }

        /// <summary>
        /// charge (tuple): Charge on each ion as a tuple of dict, e.g.
        /// ({"p": 0.154, "s": 0.078, "d": 0.0, "tot": 0.232}, ...)
        /// </summary>
        public List<Dictionary<string, object>> Charge { get; set; }

        /// <summary>
        ///  Total magnetization (in terms of the number of unpaired electrons).
        /// </summary>
        public double? TotalMagnetization { get; set; }

        /// <summary>
        ///  Returns the number of electrons in the calculation.
        /// </summary>
        public double? Nelect { get; set; }

        /// <summary>
        /// True if OUTCAR is from a stopped run (using STOPCAR, see VASP Manual).
        /// </summary>
        public bool IsStopped { get; set; }

        /// <summary>
        ///  Total drift for each step in eV/Atom.
        /// </summary>
        public double[][] Drift { get; set; }

        /// <summary>
        /// Dimensions for the Augmentation grid.
        /// </summary>
        public double[] Ngf { get; set; }

        /// <summary>
        /// Size of the sampling radii in VASP for the test charges for the electrostatic
        /// potential at each atom.Total array size is the number of elements present in the calculation.
        /// </summary>
        public double[] SamplingRadii { get; set; }

        /// <summary>
        ///  Average electrostatic potential at each atomic position in order of
        /// the atoms in POSCAR.
        /// </summary>
        public double[] ElectrostaticPotential { get; set; }

        /// <summary>
        /// PIEZOELECTRIC TENSOR  for field in x, y, z
        /// </summary>
        public double[][] PiezoTensor { get; set; }

        /// <summary>
        /// "PIEZOELECTRIC TENSOR IONIC CONTR  for field in x, y, 
        /// </summary>
        public double[][] PiezoIonicTensor { get; set; }
        public double[][] DielectricTensor { get; set; }
        public double[][] DielectricIonicTensor { get; set; }

        /// <summary>
        /// BORN EFFECTIVE CHARGES
        /// </summary>
        public object BornIon { get; set; }
        public double[][][] Born { get; set; }
        public double[][][] InternalStrainTensor { get; set; }

        /// <summary>
        ///  NMR Electric Field Gradient
        /// </summary>
        public NmrEfg NmrEfg { get; set; }

        /// <summary>
        /// NMR Chemical Shielding
        /// </summary>
        public NmrCs NmrCs { get; set; }

        /// <summary>
        /// Total electronic dipole moment
        /// </summary>
        public double[] PElec { get; set; }
        public double[] PIon { get; set; }
        public double[] PSp1 { get; set; }
        public double[] PSp2 { get; set; }
        public Dictionary<string, double> ZvalDict { get; set; }

        /// <summary>
        ///  Various useful run stats as a dict including "System time (sec)", "Total CPU time used (sec)",
        ///  "Elapsed time (sec)", "Maximum memory used (kb)", "Average memory used (kb)", "User time (sec)", "cores".
        /// </summary>
        public object RunStats { get; set; }
    }
}
