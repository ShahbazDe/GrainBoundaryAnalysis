using GBEvaluationLibrary.Models;
using System.Collections.Generic;

namespace GBEvaluationLibrary.DataAccess
{
    public interface IDataConnection
    {
        SpecimenModel CreateSampleSubmission(SpecimenModel model);
        List<SpecimenModel> GetSubmittedData();
    }
}