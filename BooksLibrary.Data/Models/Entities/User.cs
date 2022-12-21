using BooksLibrary.Data.Models.Common;

namespace BooksLibrary.Data.Models.Entities
{
    public class User : Person
    {
        public List<Book> Books { get; set; }
    }
}
