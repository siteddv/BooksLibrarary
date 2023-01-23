using BooksLibrary.BL.Controllers.Interfaces;
using BooksLibrary.Data;
using BooksLibrary.Data.Models.Entities;

namespace BooksLibrary.BL.Controllers.Implementations
{
    public class TempBookController : IBookController
    {
        public void Add(Book book)
        {
            TempDb.Books.Add(book);
        }

        public List<Book> GetAll()
        {
            return TempDb.Books;
        }

        public void Update(Book oldBook, Book newBook)
        {
            int index = TempDb.Books.IndexOf(oldBook);

            if (index == -1)
                throw new ArgumentException("Book wasn't found");

            TempDb.Books[index] = newBook;
        }

        public void Delete(Book book)
        {
            TempDb.Books.Remove(book);
        }
    }
}
