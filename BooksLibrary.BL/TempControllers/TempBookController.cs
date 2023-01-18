using BooksLibrary.Data;
using BooksLibrary.Data.Models.Entities;

namespace BooksLibrary.BL.TempControllers
{
    public class TempBookController
    {
        public void AddBook(Book book)
        {
            TempDb.Books.Add(book);
        }

        public List<Book> GetAll()
        {
            return TempDb.Books;
        }
    }
}
