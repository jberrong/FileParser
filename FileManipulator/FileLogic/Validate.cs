using System.Text.RegularExpressions;

namespace FileManipulator.FileLogic
{
    class Validate
    {
        public string ValidateExtention(string path)
        {
            string fileExtention = Regex.Match(path, @"(.{4})\s*$").ToString();
            bool isValid = false;
            isValid = CheckFile(fileExtention);
            if (isValid)
            {
                return fileExtention;
            }
            else
            {
                return "";
            }
        }
        public bool CheckFile(string fileExt)
        {
            if (fileExt == ".csv" || fileExt == ".txt")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
