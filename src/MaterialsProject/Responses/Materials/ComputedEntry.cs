using MaterialsProject.Responses.Common;
using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials
{
    public class ComputedEntry : PymatgenModule
    {
        /// <summary>
        /// Energy of the entry. Usually the final calculated
        /// energy from VASP or other electronic structure codes.
        /// </summary>
        public double Energy { get; set; }

        /// <summary>
        /// Composition of the entry. For
        /// flexibility, this can take the form of all the typical input
        /// taken by a Composition, including a { symbol: amt }
        /// dict, a string formula, and others.
        /// </summary>
        public Dictionary<string, double> Composition { get; set; }

        /// <summary>
        /// An optional id to uniquely identify the entry.
        /// </summary>
        public string EntryId { get; set; }

        /// <summary>
        /// Manually set an energy correction, will ignore
        /// energy_adjustments if specified.
        /// </summary>
        public double Correction { get; set; }

        /// <summary>
        /// An optional list of EnergyAdjustment to
        /// be applied to the energy.This is used to modify the energy for
        /// certain analyses.Defaults to None.
        /// </summary>
        public List<EnergyAdjustment> EnergyAdjustments { get; set; }

        /// <summary>
        /// An optional dict of parameters associated with
        /// the entry.Defaults to None.
        /// </summary>
        public ComputedEntryParameters Parameters { get; set; }

        /// <summary>
        /// An optional dict of any additional data associated
        /// with the entry.Defaults to None.
        /// </summary>
        public Data Data { get; set; }
        public Structure Structure { get; set; }
    }
}
