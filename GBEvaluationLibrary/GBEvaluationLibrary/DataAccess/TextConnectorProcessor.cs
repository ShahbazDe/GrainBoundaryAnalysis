using GBEvaluationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace GBEvaluationLibrary.DataAccess
{/// <summary>
/// This static class contains some static methods to manipulate the read write text data file.
/// </summary>
    public static class TextConnectorProcessor
    {/// <summary>
     /// This static method returns file name along with its path. Path is collected from app.config file. It must be changed if package is relocated
     /// </summary>
     /// <param name="fileName"></param>
     /// <returns></returns>
        public static string FullFilePathFromConfigFile(this string fileName) //GBsamples.csv
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        /// <summary>
        /// This static method will get the working directory and the data file inside it. User must not change the directory order.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string PortableFilePathByRuntimeDirectory(this string fileName) //GBsamples.csv
        {
            try
            {
                // Get the current directory.
                string obtainedPath = Directory.GetCurrentDirectory();
                string modifylink = @"\..\..\..\..\Data\GainBoundariesEvaluationDataSheet.csv";
                return obtainedPath + modifylink;
            }
            catch (Exception e)
            {
                return "File path is invalid";
            }
        }


            //}
            /// <summary>
            /// This static method reads the file path and returns the list of string(every line) for whole data
            /// </summary>
            /// <param name="file"></param>
            /// <returns></returns>
            public static List<string> Loadfile(this string file)
            {
                if (!File.Exists(file))
                {
                    return new List<string>();
                }
                return File.ReadAllLines(file).ToList();
            }
            /// <summary>
            /// This static metho gets the lines of whole document of text file data or single record. It return the object models initialized according to saved data.
            /// </summary>
            /// <param name="lines"></param>
            /// <returns></returns>
            public static List<SpecimenModel> TextRecordToObjectProperties(this List<string> lines)
            {
                List<SpecimenModel> output = new List<SpecimenModel>();
                foreach (string index in lines)
                {
                    string[] cols = index.Split(',');
                    SpecimenModel p = new SpecimenModel();
                    p.Id = int.Parse(cols[0]);
                    p.UserId = int.Parse(cols[1]);
                    p.UserName = cols[2];
                    p.GBLabel = cols[3];
                    p.GBEnergy = double.Parse(cols[4]);
                    p.SolidificationFactor = double.Parse(cols[5]);
                    p.ThermalFactor = double.Parse(cols[6]);
                    output.Add(p);
                }
                return output;
            }
            /// <summary>
            /// This static method write out all the nonempty object properties to text file with a user defined delimiter "," to the given file name and path.
            /// </summary>
            /// <param name="models"></param>
            /// <param name="fileName"></param>
            public static void SaveToSampleFile(this List<SpecimenModel> models, string fileName)
            {
                List<string> lines = new List<string>();
                foreach (SpecimenModel p in models)
                {
                    lines.Add($"{p.Id},{p.UserId},{p.UserName},{p.GBLabel},{p.GBEnergy},{p.SolidificationFactor},{p.ThermalFactor}");
                }

               // File.WriteAllLines(fileName.FullFilePathFromConfigFile(), lines);
                File.WriteAllLines(fileName.PortableFilePathByRuntimeDirectory(), lines);

            }
        }
    }
