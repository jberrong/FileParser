﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManipulator.FileReader;
using FileManipulator.Manipulation;
using System.Data;
using FileManipulator_Tests.TestMethods;

namespace FileManipulator_Tests.Tests
{
    [TestClass]
    public class JSONConversionTest
    {
        [TestMethod]
        public void JSONConversion()
        {
            JSONConverter _json = new JSONConverter();
            DataTable _table = new DataTable();
            string filePath = "../../Files/Names.csv";
            CSVReader _csv = new CSVReader(filePath);

            _table = _csv.table;
            var json = _json.ConvertTableToJSON(_table);
            var comparisonTable = _json.ConvertJSONToTable(json);

            if(Comparisons.CompareTables(_table, comparisonTable))
            {
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine("Comparison Table column names:");
                foreach (DataColumn column in comparisonTable.Columns)
                    Console.WriteLine(column.ColumnName);

                Console.WriteLine("Table rows:");
                foreach (DataRow row in _table.Rows)
                    Console.WriteLine(string.Join(", ", row.ItemArray));
                Console.WriteLine("Table column names:");
                foreach (DataColumn column in _table.Columns)
                    Console.WriteLine(column.ColumnName);

                Console.WriteLine("Columns match?:{0}", Comparisons.CompareTableHeaders(_table, comparisonTable));
                Console.WriteLine("Rows match?:{0}", Comparisons.CompareTableRows(_table, comparisonTable));

                Console.WriteLine("Comparison Table rows:");
                foreach (DataRow row in comparisonTable.Rows)
                    Console.WriteLine(string.Join(", ", row.ItemArray));
                Assert.IsTrue(false);

            }
        }
    }
}
