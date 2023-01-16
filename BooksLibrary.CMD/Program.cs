using BooksLibrary.CMD;
using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Enums;

Console.WriteLine("Hello, World!");
Console.WriteLine("Let\'s create a book!");

Language lang = ConsoleReader<Language>.Read("language number");

DateTime releasedDate = ConsoleReader<DateTime>
    .Read($"release date in format {ConsoleConstants.DatePattern}");

string bookName = ConsoleReader<string>.Read("book name");
string shortDesc = ConsoleReader<string>.Read("short description");

int countOfAvailiable = ConsoleReader<int>.Read("books count");
int publishingYear = ConsoleReader<int>.Read("publishing year");
Console.ReadKey();