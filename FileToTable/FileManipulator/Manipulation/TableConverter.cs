using System.Collections.Generic;
using System.Linq;

namespace FileManipulator.Manipulation
{
    public class TableConverter
    {
        public string[] ConvertHeaders(string[] dataArray)
        {
            return dataArray.First().Split(',').ToArray();
        }
        public IList<string[]> ConvertBody(string[] dataArray)
        {
            List<string[]> body = new List<string[]>();
            foreach (string line in dataArray)
            {
                var textArray = line.Split(',').ToArray();
                int iterator = 0;
                while (iterator < textArray.Length)
                {
                    textArray[iterator].Trim();
                    iterator++;
                }
                body.Add(textArray);
            }
            body.RemoveAt(0);
            body.RemoveAt(body.IndexOf(body.Last()));

            return body;
        }
    }
}
