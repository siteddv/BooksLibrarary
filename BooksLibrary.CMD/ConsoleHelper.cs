namespace BooksLibrary.CMD
{
    public static class ConsoleHelper
    {
        public static string GetStringFromConsole(string fieldName)
        {
            Console.WriteLine($"Please enter {fieldName}");
            string value = Console.ReadLine();

            return value;
        }
    }
}
