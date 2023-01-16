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
            {
                string stringValue = ConsoleHelper.GetStringFromConsole(fieldName);
                object objectValue = (object)stringValue;
                T value = (T)objectValue;

                return value;
            }

            if (typeof(int) == typeof(T))
            {
                return (T)(object)ConsoleHelper.GetIntFromConsole(fieldName);
            }

            if (typeof(DateTime) == typeof(T))
            {
                return (T)(object)ConsoleHelper.GetDateTimeFromConsole(fieldName);
            }

            if (typeof(Language) == typeof(T))
            {
                return (T)(object)ConsoleHelper.GetLanguageFromConsole(fieldName);
            }
            
            return default(T);
        }
    }
}
