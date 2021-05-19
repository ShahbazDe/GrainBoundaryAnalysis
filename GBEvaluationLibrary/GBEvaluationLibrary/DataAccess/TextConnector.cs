using GBEvaluationLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace GBEvaluationLibrary.DataAccess
{/// <summary>
/// This class contains a static property to define text data file name. This class also contains static methods to interact with 
/// </summary>
    public class TextConnector : IDataConnection
    {
        public const string SampleFileName = "GainBoundariesEvaluationDataSheet.csv";
        /// <summary>
        /// This class creates or modifies the text database file for new entries.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public SpecimenModel CreateSampleSubmission(SpecimenModel model)
        {
            //*loading the data from existing file     IN TEXTCONNECTIONPROCESSOR
            //*Converting to appropriate dataTypes
            //List<SpecimenModel> samples = SampleFileName.FullFilePathFromConfigFile().Loadfile().TextRecordToObjectProperties();
            List<SpecimenModel> samples = SampleFileName.PortableFilePathByRuntimeDirectory().Loadfile().TextRecordToObjectProperties();
            // Finding maximum data length and Last stored ID
            int currentId = 1;

            if (samples.Count > 0)
            {
                currentId = samples.OrderByDescending(x => x.Id).First().Id + 1;
            }
            // Adding new record at new id after last max id (newID= maxID+1)
            model.Id = currentId;
            samples.Add(model);
            // convert model to List<string>
            // Save file list to output text file
            samples.SaveToSampleFile(SampleFileName);
            return model;
        }
        /// <summary>
        /// It returns list of objects which contain complete database in object form.
        /// </summary>
        /// <returns></returns>
        public List<SpecimenModel> GetSubmittedData()
        {
            //List<SpecimenModel> samples = SampleFileName.FullFilePathFromConfigFile().Loadfile().TextRecordToObjectProperties();
            List<SpecimenModel> samples = SampleFileName.PortableFilePathByRuntimeDirectory().Loadfile().TextRecordToObjectProperties();
            return samples;
        }
    }
}
