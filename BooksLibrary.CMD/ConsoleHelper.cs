using BooksLibrary.Data.Models.Enums;

namespace BooksLibrary.CMD
{
    public static class ConsoleHelper
    {
        // int, enum, DateTime
        public static string GetStringFromConsole(string fieldName)
        {
            Console.WriteLine($"Please enter {fieldName}");
            string value = Console.ReadLine();

            return value;
        }

        public static int GetIntFromConsole(string fieldName)
        {
            string value = GetStringFromConsole(fieldName);
            return int.Parse(value);
        }

        public static DateTime GetDateTimeFromConsole(string fieldName)
        {
            string value = GetStringFromConsole(fieldName);
            return DateTime
                .ParseExact(value, ConsoleConstants.DatePattern, null);
        }

        public static Language GetLanguageFromConsole(string fieldName)
        {
            string[] enumValues = Enum.GetNames(typeof(Language));
            int i = 0;
            foreach (string enumVal in enumValues)
            {
                Console.WriteLine($"{i} {enumVal}");
                i++;
            }

            int number = GetIntFromConsole(fieldName);

            return (Language)number;
        }
    }
}
