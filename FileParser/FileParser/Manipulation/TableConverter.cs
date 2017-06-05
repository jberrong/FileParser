using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FileParser.Manipulation
{
    public class ToDataTable
    {
        public string[] ConvertHeaders(string[] dataArray)
        {
            return dataArray.First().Split(',').ToArray();
        }
        public IList<string[]> ConvertBody(string[] dataArray)
        {
            List<string[]> body = new List<string[]>();
            foreach (string line in dataArray)
                body.Add(line.Split(',').ToArray());
            body.RemoveAt(0);

            return body;
        }
    }
}
