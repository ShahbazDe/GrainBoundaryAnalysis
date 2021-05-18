using GBEvaluationLibrary;
using GBEvaluationLibrary.DataAccess;
using GBEvaluationLibrary.Models;
using GBEvaluationLibrary.Utalities;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GrainBoundariesEvaluationUI
{/// <summary>
/// Evaluation form loads old available data, compute best sample, sort it in ascending order. It also offers the possibility of adding new entry of record.
/// </summary>
    public partial class EvaluationUI : Form
    {
        public EvaluationUI()
        {
            InitializeComponent();
            PrintAllRecord();
        }
        /// <summary>
        /// It opens new winform for new data entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataEntryBtn_Click(object sender, System.EventArgs e)
        {
            SpecimentSubmissionForm DataEntryForm = new SpecimentSubmissionForm();
            DataEntryForm.Show();
        }
        /// <summary>
        /// It loads all the available data. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewStatusBtn_Click(object sender, System.EventArgs e)
        {
            PrintAllRecord();
        }
        /// <summary>
        /// It computes the best suitable grain boundary energies, sort them and load them into listview.
        /// </summary>
        private void PrintAllRecord()
        {
            List<SpecimenModel> availableSpecimens = new List<SpecimenModel>();
            if (!File.Exists(TextConnector.SampleFileName.GetFullFilePath()))
            {
                MessageBox.Show("cvs file can not be found. Set the path in App.config file, recompile and try again");
                System.Environment.Exit(1);
            }
            else
            {
                availableSpecimens = GlobalConfig.ConnectionChoice.GetSubmittedData();
            }

            listViewAllSpecimens.Items.Clear();
            foreach (SpecimenModel i in Utilities.ComputeSuitableGrainBoundary(availableSpecimens))
            {
                var eachRecord = new string[] {
                    i.UserName,
                    i.GBLabel,
                    i.GBEnergy.ToString(),
                    i.SolidificationFactor.ToString(),
                    i.ThermalFactor.ToString(),
                    i.UserId.ToString() };
                var eachRecordListitem = new ListViewItem(eachRecord);
                listViewAllSpecimens.Items.Add(eachRecordListitem);
                //Highlight most suitable specimen
                listViewAllSpecimens.Items[0].BackColor = Color.GreenYellow;
            }
        }
    }
}