using BooksLibrary.Data.Models.Enums;

namespace BooksLibrary.CMD
{
    public static class ConsoleReader<T>
    {
        public static T Read(string fieldName)
        {
            bool isIncorrectDataEntered = true;

            while (isIncorrectDataEntered)
            {
                try
                {
                    T data = ReadData(fieldName);
                    isIncorrectDataEntered = false;
                    return data;
                }
                catch
                {
                    Console.WriteLine($"An error while getting value received. Please enter {fieldName} again");
                }
            }

            return default(T);
        }

        private static T ReadData(string fieldName)
        {
            if (typeof(string) == typeof(T))
                return (T)(object)ConsoleHelper.GetStringFromConsole(fieldName);

            if (typeof(int) == typeof(T))
                return (T)(object)ConsoleHelper.GetIntFromConsole(fieldName);

            if (typeof(DateTime) == typeof(T))
                return (T)(object)ConsoleHelper.GetDateTimeFromConsole(fieldName);

            if (typeof(Language) == typeof(T))
                return (T)(object)GetLanguageFromConsole(fieldName);

            if (typeof(Genre) == typeof(T))
                return (T)(object)GetGenreFromConsole(fieldName);

            return default(T);
        }

        private static Language GetLanguageFromConsole(string fieldName)
        {
            Language language = (Language)ConsoleHelper
                .GetEnumNumberFromConsole(fieldName, typeof(Language));

            return language;
        }

        private static Genre GetGenreFromConsole(string fieldName)
        {
            Genre genre = (Genre)ConsoleHelper
                .GetEnumNumberFromConsole(fieldName, typeof(Genre));

            return genre;
        }
    }
}
