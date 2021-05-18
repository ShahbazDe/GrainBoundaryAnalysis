using GBEvaluationLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace GBEvaluationLibrary.Utalities
{
    public static class Utilities
    {
        /// <summary>
        /// This method finds the best minimum energy grain boundary according to the physics of metal's solidification.
        /// Formula to calculate suitable grain boundary=(GB Energy*Solidification Factor)/Thermal Factor
        /// </summary>
        /// <param name="availableSpecimens"></param>
        /// <returns></returns>
        public static List<SpecimenModel> FindSuitableGrainBoundary(List<SpecimenModel> availableSpecimens)
        {
            List<SpecimenModel> SortedList = availableSpecimens.OrderByDescending(i => (i.GBEnergy * i.SolidificationFactor) / (i.ThermalFactor)).ToList();
            return SortedList;
        }
    }
    //public static class MultiThreadedUtilities
    //{
    //    /// <summary>
    //    /// This method finds the best minimum energy grain boundary with multithreaded approach
    //    /// Formula to calculate suitable grain boundary=(GB Energy*Solidification Factor)/Thermal Factor
    //    /// </summary>
    //    /// <param name="availableSpecimens"></param>
    //    /// <returns></returns>
    //    //public static List<SpecimenModel> FindSuitableGrainBoundary(List<SpecimenModel> availableSpecimens)
    //    //{

    //    //}

    //}
}
