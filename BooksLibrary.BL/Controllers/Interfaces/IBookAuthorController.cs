using BooksLibrary.Data.Models;
using BooksLibrary.Data.Models.Entities;

namespace BooksLibrary.BL.Controllers.Interfaces
{
    public interface IBookAuthorController
    {
        public void Link(List<Book> books, List<Author> authors);
    }
}
