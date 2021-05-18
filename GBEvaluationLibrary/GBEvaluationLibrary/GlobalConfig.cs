using GBEvaluationLibrary.DataAccess;
using System.Configuration;

namespace GBEvaluationLibrary
{
    public static class GlobalConfig
    {
        //we can declare variabel with class blueprint or its interface. Here we will first create a object with interface. Then instanciate that object either with first case sql or second case, text file.
        /// <summary>
        /// ConnectionChoice is instantiated with interface IDataConnection so it could get object by any of the implementations
        /// </summary>
        public static IDataConnection ConnectionChoice { get; private set; }
        /// <summary>
        /// This static methos instantiate the datatype. User set it in static class Program
        /// </summary>
        /// <param name="db"></param>
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //TODO -Setup sql properly
                SqlConnector sql = new SqlConnector();
                //Connections.Add(sql);
                ConnectionChoice = sql;
            }
            //if(textFiles)
            else if (db == DatabaseType.TextFile)
            {
                //TODO  -Creaet the Text connection
                TextConnector text = new TextConnector();
                ConnectionChoice = text;
            }
        }
        /// <summary>
        /// This static method returns sqldatabase connection string from app.config file as well as database name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
