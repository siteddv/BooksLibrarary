//using BooksLibrary.BL.Controllers.Implementations.Temp;
//using BooksLibrary.BL.Controllers.Interfaces;
//using BooksLibrary.CMD;
//using BooksLibrary.Data.DB.SqlServer;
//using BooksLibrary.Data.DB.TempDb;
//using BooksLibrary.Data.Models.Common;
//using BooksLibrary.Data.Models.Entities;
//using BooksLibrary.Data.Models.Enums;
//using BooksLibrary.Data.Repositories.Implementations;

//TempDb.Seed();

//IDBilable<Book> bookController = new TempDBilController<Book>();
//IDBilable<Author> authorController = new TempDBilController<Author>();

//Console.WriteLine("Hello, World!");

//List<Book> books = bookController.GetAll();
//List<Author> authors = authorController.GetAll();

//List<Book> books1 = bookController.GetAll();
//List<Author> authors1 = authorController.GetAll();

//using (AppDbContext db = new AppDbContext())
//{
//    Repository<Book> rep = new Repository<Book>(db);
//    Book b = rep.Add(new Book()
//    {
//        Name = "Gagarin",
//        Language = Language.Russian,
//        Genres = Genre.BDSM,
//        ShortDesc = "1234545",
//        Released = DateTime.Now,
//        CountOfAvailable = 5,
//    });
//    int a = 0;
//}

////Book book = GetBookFromConsole();

////bookController.Add(book);

//Console.ReadKey();

//static Book GetBookFromConsole()
//{
//    Console.WriteLine("Let\'s create a book!");

//    #region Get book data

//    string bookName = ConsoleReader<string>.Read("book name");
//    string shortDesc = ConsoleReader<string>.Read("short description");
//    DateTime releasedDate = ConsoleReader<DateTime>
//        .Read($"release date in format {ConsoleConstants.DatePattern}");
//    Language lang = ConsoleReader<Language>.Read("language number");
//    Genre genre = ConsoleReader<Genre>.Read("genre number");
//    int countOfAvailable = ConsoleReader<int>.Read("books count");

//    #endregion

//    #region Create new book

//    Book book = new Book()
//    {
//        Name = bookName,
//        ShortDesc = shortDesc,
//        Released = releasedDate,
//        Language = lang,
//        Genres = genre,
//        CountOfAvailable = countOfAvailable
//    };

//    #endregion

//    return book;
//}

//using System.Text;

//string str = string.Join(',', "Ayub", "Igor", "Meruert", "Emil");

//Console.WriteLine(str);