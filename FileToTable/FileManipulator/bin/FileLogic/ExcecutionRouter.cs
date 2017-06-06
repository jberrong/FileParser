using FileManipulator.FileReader;
using System.Data;
using System;

namespace FileManipulator.FileLogic
{
    public class ExcecutionRouter
    {
        Validate valid = new Validate();
        public DataTable RouteAsTable(string filePath)
        {
            string fileExt = valid.ValidateExtention(filePath);
            DataTable table = new DataTable();
            if (fileExt != "")
            {
                if (fileExt == ".csv")
                {
                    CSVReader csv = new CSVReader();
                    table = csv.GetCSVAsTable(filePath);
                    return table;
                }
                if (fileExt == ".txt")
                {
                    return table;
                }
                else
                {
                    return table;
                }
            }
            else
            {
                Console.WriteLine("Invalid extention.");
                return table;
            }
        }
    }
}
