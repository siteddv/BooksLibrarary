using BooksLibrary.BL.TempControllers;
using BooksLibrary.CMD;
using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Enums;

TempBookController bookController = new TempBookController();

Console.WriteLine("Hello, World!");

Book book = GetBookFromConsole();

bookController.AddBook(book);

List<Book> books = bookController.GetAll();

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