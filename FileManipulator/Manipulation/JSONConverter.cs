using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;

namespace FileManipulator.Manipulation
{
    public class JSONConverter
    {
        public string ConvertTableToJSON(DataTable table)
        {
            var JSONConversion = JsonConvert.SerializeObject(table);
            return JSONConversion;
        }
        public DataTable ConvertJSONToTable(string json)
        {
            var TableConversion = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            return TableConversion;
        }
    }
}
