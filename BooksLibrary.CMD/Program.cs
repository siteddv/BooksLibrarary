using BooksLibrary.BL.Controllers.Implementations;
using BooksLibrary.CMD;
using BooksLibrary.Data.DB.SqlServer;
using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Enums;
using BooksLibrary.Data.Models.Relations;
using BooksLibrary.Data.Repositories.Implementations;

using (AppDbContext db = new AppDbContext())
{
    db.Seed();

    Repository<Author> authorRepos = new Repository<Author>(db);
    BookRepository bookRepos = new BookRepository(db);
    Repository<BookAuthor> bookAuthRepos= new Repository<BookAuthor>(db);

    List<Book> books = bookRepos.GetAll();
    List<Author> authors = authorRepos.GetAll();

    BookAuthorController baController = new BookAuthorController(bookAuthRepos);

    Book firstBook = books.FirstOrDefault();

    if(firstBook != null)
    {
        var a = bookRepos.GetAuthorsByBookId(firstBook.Id);
    }

    baController.Link(authors, books);
    db.Dispose();
    List<BookAuthor> bas = bookAuthRepos.GetAll();


}



//Book book = GetBookFromConsole();

//bookController.Add(book);

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