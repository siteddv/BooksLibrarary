using BooksLibrary.Data.Models.Common;
using BooksLibrary.Data.Models.Entities;

namespace BooksLibrary.Data.Models.Relations
{
    public class BookAuthor : BaseEntity
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
