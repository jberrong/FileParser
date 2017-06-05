using System;
using FileParser.FileReader;
using FileParser.Item;
using FileParser.FileLogic;
using FileParser.Manipulation;

namespace FileParser_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FilePath f = new FilePath();
            CSVReader c = new CSVReader();
            ToDataTable d = new ToDataTable();
            
            Console.WriteLine("What is your user account name?");
            f.File = Appender.UpdateFilePath(Console.ReadLine(), f.File);
            Console.WriteLine("What main folder path does this exist on? IE.Documents, Downloads..");
            f.File = Appender.UpdateFilePath(Console.ReadLine(), f.File);
            Console.WriteLine("Is file in subfolder?");
            string inSubfolder = Console.ReadLine();
            if(inSubfolder.ToUpper() == "YES")
            {
                Console.WriteLine("Which subfolder does this exist in?");
                f.File = Appender.UpdateFilePath(Console.ReadLine(), f.File);
            }
            Console.WriteLine("What is file name?");
            f.File = f.File + Console.ReadLine();

            var dataFile = c.GetCSVAsTable(f.File);
            c.OutputDataTable(dataFile);
            Console.WriteLine("Press Enter to exit.");
            Console.Read();
        }
    }
}
