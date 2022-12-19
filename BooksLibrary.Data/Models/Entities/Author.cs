using BooksLibrary.Data.Common;

namespace BooksLibrary.Data.Entities
{
    public class Author : Person
    {
        public List<Book> WrittenBooks { get; set; }
        public int Popularity { get; set; }
    }
}
