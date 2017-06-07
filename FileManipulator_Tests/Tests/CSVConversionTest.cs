using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManipulator.FileReader;
using System.Data;
using System;
using FileManipulator_Tests.TestMethods;

namespace FileManipulator_Tests.Tests
{
    [TestClass]
    public class CSVConversionTest
    {
        [TestMethod]
        public void CSVConversion()
        {
            CSVReader _csv = new CSVReader();
            DataTable _table = new DataTable();
            string filePath = "../../Files/Names.csv";
            bool hasComma = true;

            _table = _csv.GetCSVAsTable(filePath);
            foreach(DataRow row in _table.Rows)
            {
                hasComma = Comparisons.CheckRowForCommas(row);
                if (hasComma == true)
                    break;
            }
            if (hasComma == true)
            {
                Console.WriteLine("CSV Row contents:");
                foreach (DataRow row in _table.Rows)
                    Console.WriteLine(string.Join("", row));
                Assert.IsFalse(hasComma);
            }
            else
                Assert.IsFalse(hasComma);
        }
    }
}
