namespace FileParser.FileLogic
{
    public static class Appender
    {
        public static string UpdateFilePath(string addedValue, string variable)
        {
            return variable = variable + addedValue + "\\";
        }
    }
}
