using BooksLibrary.Data.Models.Entities;

namespace BooksLibrary.BL.Controllers.Interfaces
{
    public interface IBookController
    {
        public void Add(Book book); // C
        public List<Book> GetAll(); // R
        public void Update(Book oldBook, Book newBook); // U
        public void Delete(Book book); // D
    }
}
