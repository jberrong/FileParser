using System;
using System.Collections.Generic;
using System.IO;

namespace FileParser.FileReader
{
    public class TextReader
    {
        public string[] GetTextFile(string filePath)
        {
            string[] fileContents = File.ReadAllLines(filePath);
            return fileContents;
        }
        public void OutputTextFileToConsole(string[] file)
        {

            Console.WriteLine("\nGenerating output of file\n");

            foreach (string row in file)
                Console.WriteLine(row);
        }
    }
}
