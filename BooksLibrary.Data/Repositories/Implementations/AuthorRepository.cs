using BooksLibrary.Data.DB.SqlServer;
using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Relations;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Data.Repositories.Implementations
{
    public class AuthorRepository : Repository<Author>
    {
        public AuthorRepository(AppDbContext context) : base(context)
        {
        }

        public List<Book> GetBookByAuthorId(int authorId)
        {
            DbSet<BookAuthor> bookAuthorsDbSet = _context.Set<BookAuthor>();

            if(bookAuthorsDbSet == default(DbSet<BookAuthor>))
                return default(List<Book>);

            IEnumerable<BookAuthor> bookAuthors = bookAuthorsDbSet
                .Where(ba => ba.AuthorId == authorId);

            DbSet<Book> booksDbSet = _context.Set<Book>();

            if (booksDbSet == default(DbSet<Book>))
                return default(List<Book>);

            List<Book> books = booksDbSet
                .Where(b => bookAuthors
                .Any(ba => ba.BookId == b.Id))
                .ToList();

            return books;
        }
    }
}
