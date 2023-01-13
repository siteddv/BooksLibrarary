using BooksLibrary.CMD;
using BooksLibrary.Data.Models.Entities;

Console.WriteLine("Hello, World!");
Console.WriteLine("Let\'s create a book!");

string bookName = ConsoleReader<string>.Read("book name");
Book book = new Book();
Console.ReadKey();


