using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FileManipulator_Tests.TestMethods
{
    internal static class Comparisons
    {
        public static bool CompareTables(DataTable table1, DataTable table2)
        {
            if (CompareTableHeaders(table1, table2))
                return CompareTableRows(table1, table2);
            else
                return false;
        }
        public static bool CompareTableHeaders(DataTable table1, DataTable table2)
        {
            string columns1 = string.Empty;
            string columns2 = string.Empty;
            foreach (DataColumn column in table1.Columns)
                columns1 = columns1 + column;

            foreach (DataColumn column in table2.Columns)
                columns2 = columns2 + column;

            if(columns1 != columns2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CompareTableRows(DataTable table1, DataTable table2)
        {
            string rows1 = string.Empty;
            string rows2 = string.Empty;
            foreach (DataRow row in table1.Rows)
                rows1 = rows1 + string.Join(",", row.ItemArray);

            foreach (DataRow row in table1.Rows)
                rows2 = rows2 + string.Join(",", row.ItemArray);

            if (rows1 != rows2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckRowForCommas(DataRow row)
        {
            if (string.Join("", row).Contains(","))
                return true;
            else
                return false;
        }

    }
}
