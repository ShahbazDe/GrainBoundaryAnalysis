using GBEvaluationLibrary.Models;
using  GBEvaluationLibrary;
using GBEvaluationLibrary.Utalities;
using System;
using System.Data;
using Dapper;
using System.Collections.Generic;
using System.Configuration;

namespace GBEvaluationLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {   //TODO implemet sql database submission section
        public SpecimenModel CreateSampleSubmission(SpecimenModel model)
        {
            try
            {                                       //download sqlcleint   
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString("GBAnalysisDB")))  //https://youtu.be/wfWxdh-_k_4?t=21866 explaining this line
                {
                    var val = new DynamicParameters();
                    val.Add("@UserId", model.UserId);
                    val.Add("@UserName", model.UserName);
                    val.Add("@GBLabel", model.GBLabel);
                    val.Add("@GBEnergy", model.GBEnergy);
                    val.Add("@SolidificationFactor", model.SolidificationFactor);
                    val.Add("@ThermalFactor", model.ThermalFactor);
                    val.Add("@id", 0, dbType: DbType.Int32, ParameterDirection.Output);

                    connection.Execute("dbo.spSpecimens_Insert", val, commandType: CommandType.StoredProcedure);

                    model.Id = val.Get<int>("@id");
                    return model;
                }
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
