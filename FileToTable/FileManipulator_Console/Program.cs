using System;
using FileManipulator.FileReader;
using FileManipulator.Item;
using FileManipulator.FileLogic;

namespace FileManipulator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FilePath _file = new FilePath();
            CSVReader _csv = new CSVReader();
            ExcecutionRouter _route = new ExcecutionRouter();
            
            Console.WriteLine("What is your user account name?");
            _file.File = Appender.UpdateFilePath(Console.ReadLine(), _file.File);
            Console.WriteLine("What main folder path does this exist on? IE.Documents, Downloads..");
            _file.File = Appender.UpdateFilePath(Console.ReadLine(), _file.File);
            Console.WriteLine("Is file in subfolder?");
            string inSubfolder = Console.ReadLine();
            if(inSubfolder.ToUpper() == "YES")
            {
                Console.WriteLine("Which subfolder does this exist in?");
                _file.File = Appender.UpdateFilePath(Console.ReadLine(), _file.File);
            }
            Console.WriteLine("What is file name?");
            _file.File = _file.File + Console.ReadLine();

            var dataFile = _route.RouteAsTable(_file.File);
            _csv.OutputDataTable(dataFile);
            Console.WriteLine("Press Enter to exit.");
            Console.Read();
        }
    }
}
