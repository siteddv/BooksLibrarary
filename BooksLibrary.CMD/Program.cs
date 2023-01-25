using BooksLibrary.BL.Controllers.Implementations.Temp;
using BooksLibrary.BL.Controllers.Interfaces;
using BooksLibrary.CMD;
using BooksLibrary.Data;
using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Enums;

TempDb.Seed();

IDBilable<Book> bookController = new TempDBilController<Book>();
IDBilable<Author> authorController = new TempDBilController<Author>();

Console.WriteLine("Hello, World!");

List<Book> books = bookController.GetAll();

Book book = GetBookFromConsole();

bookController.Add(book);

books = bookController.GetAll();

Console.ReadKey();

static Book GetBookFromConsole()
{
    Console.WriteLine("Let\'s create a book!");

    #region Get book data

    string bookName = ConsoleReader<string>.Read("book name");
    string shortDesc = ConsoleReader<string>.Read("short description");
    DateTime releasedDate = ConsoleReader<DateTime>
        .Read($"release date in format {ConsoleConstants.DatePattern}");
    Language lang = ConsoleReader<Language>.Read("language number");
    Genre genre = ConsoleReader<Genre>.Read("genre number");
    int countOfAvailable = ConsoleReader<int>.Read("books count");

    #endregion

    #region Create new book

    Book book = new Book()
    {
        Name = bookName,
        ShortDesc = shortDesc,
        Released = releasedDate,
        Language = lang,
        Genres = genre,
        CountOfAvailable = countOfAvailable
    };

    #endregion

    return book;
}