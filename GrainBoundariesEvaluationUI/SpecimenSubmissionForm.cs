using GBEvaluationLibrary;
using GBEvaluationLibrary.Models;
using System;
using System.Windows.Forms;

namespace GrainBoundariesEvaluationUI
{/// <summary>
/// This form is used to submit the new sample records for grain boundary experiments.
/// </summary>
    public partial class SpecimentSubmissionForm : Form
    {
        public SpecimentSubmissionForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button event reads all the available text in textboxes and assign them to the object properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataSubmitBtn_Click(object sender, EventArgs e)
        {

            if (ValidateInputData())
            {
                SpecimenModel model = new SpecimenModel(
                    userID.Text,
                    userName.Text,
                    gbType.Text,
                    gbEnergy.Text,
                    solidificationFactor.Text,
                    thermalGradient.Text);

                //foreach(IDataConnection db in GlobalConfig.ConnectionChoice)
                //{
                //   db.CreateSampleSubmission(model);
                //}
                GlobalConfig.ConnectionChoice.CreateSampleSubmission(model);

                userID.Text = "";
                userName.Text = "";
                gbType.Text = "000";
                gbEnergy.Text = "0";
                solidificationFactor.Text = "0";
                thermalGradient.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid data. Please follow the error labels");
            }

        }

        /// <summary>
        /// This 
        /// </summary>
        /// <returns>
        /// It returns false in case user has not complied to the defined rules for the evaluation of grain boundary energy analysis. It also ensures the successful datatype conversion.
        /// </returns>
        private bool ValidateInputData()
        {
            bool output = true;
            int auserID = 0;
            bool auserIDValid = int.TryParse(userID.Text, out auserID);
            if (auserIDValid == false || auserID < 1 || userID.Text.Length < DataValidity.userIDlength)
            {
                output = false;
                errorProviderUserID.SetError(userID, "user iD must be more than 4 digits");
            }


            double aGBEnergy = 0;
            bool aGBEnergyValid = double.TryParse(gbEnergy.Text, out aGBEnergy);
            if (aGBEnergyValid == false || aGBEnergy >= DataValidity.maxGBEnergy)
            {
                output = false;
                errorProviderUserID.SetError(gbEnergy, "Grain boundary energy should be less than zero");
            }

            double aSolidificationFactor = 0;
            bool aSolidificationFactorValid = double.TryParse(solidificationFactor.Text, out aSolidificationFactor);
            if (aSolidificationFactorValid == false || aSolidificationFactor < DataValidity.minSoliFactor || aSolidificationFactor > DataValidity.maxSoliFactor)
            {
                output = false;
                errorProviderUserID.SetError(solidificationFactor, "Solidification factor should be in a range of 0-1");
            }

            double aThermalGradient = 0;
            bool aThermalGradientValid = double.TryParse(thermalGradient.Text, out aThermalGradient);
            if (aThermalGradientValid == false || aThermalGradient > DataValidity.maxThermalGrad)
            {
                output = false;
                errorProviderUserID.SetError(thermalGradient, "Thermal gradient cannot be more than 1000K degree");
            }

            return output;

        }
    }
}
