using GBEvaluationLibrary.Models;
using System;
using System.Collections.Generic;

namespace GBEvaluationLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {   //TODO implemet sql database submission section
        public SpecimenModel CreateSampleSubmission(SpecimenModel model)
        {
            try
            {
                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //TODO implement how to read al the available data from sql database
        public List<SpecimenModel> GetSubmittedData()
        {
            List<SpecimenModel> availableSpecimens = new List<SpecimenModel>();
            return availableSpecimens;
        }
    }
}
