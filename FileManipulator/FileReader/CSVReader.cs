using System;
using System.IO;
using System.Data;
using FileManipulator.Manipulation;

namespace FileManipulator.FileReader
{
    public class CSVReader
    {
        string filePath;
        public DataTable table;
        public CSVReader(string file)
        {
            filePath = file;
            table = GetCSVAsTable();
        }
        public DataTable GetCSVAsTable()
        {
            DataTable table = new DataTable();
            var contents = File.ReadAllText(filePath).Split('\n');
            string[] headerNames = TableConverter.ConvertHeaders(contents);
            var body = TableConverter.ConvertBody(contents);

            foreach (string column in headerNames)
                table.Columns.Add(column);

            foreach (var item in body)
                table.Rows.Add(item);

            return table;
        }

        public void OutputDataTable(DataTable table)
        {
            Console.WriteLine("Column Names..\n");
            foreach (DataColumn column in table.Columns)
                Console.WriteLine(column.ColumnName);
            Console.WriteLine("Row Data..\n");
            foreach (DataRow row in table.Rows)
                Console.WriteLine(string.Join(",", row.ItemArray));
        }
    }
}
