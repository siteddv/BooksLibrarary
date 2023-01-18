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

        private static void PrintEnumWithIndexes(Type enumType, int indexDif)
        {
            string[] enumValues = Enum.GetNames(enumType);
            int i = 0;
            foreach (string enumVal in enumValues)
            {
                Console.WriteLine($"{i + indexDif} {enumVal}");
                i++;
            }
        }

        public static int GetEnumNumberFromConsole(string fieldName, Type enumType)
        {
            const int indexDif = 1;
            
            PrintEnumWithIndexes(enumType, indexDif);

            int number = GetIntFromConsole(fieldName) - indexDif;

            return number;
        }
    }
}
