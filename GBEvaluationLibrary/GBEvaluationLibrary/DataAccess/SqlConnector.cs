using GBEvaluationLibrary.Models;
using  GBEvaluationLibrary;
using GBEvaluationLibrary.Utalities;
using System;
using System.Data;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace GBEvaluationLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {   /// <summary>
    /// Using Dapper, Data is stored into database
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
        public SpecimenModel CreateSampleSubmission(SpecimenModel model)
        {
            try
            {                                       //download sqlcleint     //getting database name
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString("GBAnalysisDB")))  
                {
                    var val = new DynamicParameters();
                    val.Add("@UserId", model.UserId);
                    val.Add("@UserName", model.UserName);
                    val.Add("@GBLabel", model.GBLabel);
                    val.Add("@GBEnergy", model.GBEnergy);
                    val.Add("@SolidificationFactor", model.SolidificationFactor);
                    val.Add("@ThermalFactor", model.ThermalFactor);
                    val.Add("@id", 0, dbType: DbType.Int32, ParameterDirection.Output);

                    connection.Execute("dbo.spSpecimens_Insert", val, commandType: CommandType.StoredProcedure);//store procedure=dbo.spSpecimens_Insert

                    model.Id = val.Get<int>("@id");
                    return model;
                }
            }
            catch (Exception)
            {

                throw;
            }




        }
        /// <summary>
        /// using store procedure 
        /// </summary>
        /// <returns></returns>
   
        public List<SpecimenModel> GetSubmittedData()
        {
            List<SpecimenModel> availableSpecimens = new List<SpecimenModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnectionString("GBAnalysisDB")))  
            {
                availableSpecimens = connection.Query<SpecimenModel>("dbo.spSpecimens_GetALLData").ToList();
            }
                return availableSpecimens;
        }
    }
}
