using BooksLibrary.Data.Models.Common;

namespace BooksLibrary.Data.Models.Relations
{
    public class BookAuthor : BaseEntity
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}
