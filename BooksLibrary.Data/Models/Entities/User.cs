using BooksLibrary.Data.Common;

namespace BooksLibrary.Data.Entities
{
    public class User : Person
    {
        public List<Book> Books { get; set; }
    }
}
