using System;

namespace GBEvaluationLibrary.Models
{
    public class SpecimenModel : UserModel
    {/// <summary>
     /// The object class contains data necessary for participants and grain boundary details.
     /// </summary>
        public int Id { get; set; }

        public string GBLabel { get; set; }
        public double GBEnergy { get; set; }
        public double SolidificationFactor { get; set; }
        public double ThermalFactor { get; set; }

        /// <summary>
        /// Argumentless constructor
        /// </summary>
        public SpecimenModel()
        {
        }

        /// <summary>
        /// Constructor for assigning SpecimenModel and UserModel property values
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="gBLabel"></param>
        /// <param name="gBEnergy"></param>
        /// <param name="solidificationFactor"></param>
        /// <param name="thermalFactor"></param>
        public SpecimenModel(string userId, string userName, string gBLabel, string gBEnergy, string solidificationFactor, string thermalFactor)
        {
            int UserIdValue = 0;
            int.TryParse(userId, out UserIdValue);
            UserId = UserIdValue;

            UserName = userName ?? throw new ArgumentNullException(nameof(userName));

            GBLabel = gBLabel ?? throw new ArgumentNullException(nameof(gBLabel));

            double GBEnergyValue = 0;
            double.TryParse(gBEnergy, out GBEnergyValue);
            GBEnergy = GBEnergyValue;

            double solidificationFactorValue = 0;
            double.TryParse(solidificationFactor, out solidificationFactorValue);
            SolidificationFactor = solidificationFactorValue;

            double thermalFactorValue = 0;
            double.TryParse(thermalFactor, out thermalFactorValue);
            ThermalFactor = thermalFactorValue;
        }
    }
}
