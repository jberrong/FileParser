using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;

namespace FileParser.FileReader
{
    class ExcelReader
    {
        Application excelApp = new Application();
        Workbook excelWorkbook ;
        Worksheet excelWorksheet;
        Range range;
    }
}
