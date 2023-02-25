using BooksLibrary.Data.DB.SqlServer;
using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Relations;
using BooksLibrary.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Data.Repositories.Implementations
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }

        public List<Author> GetAuthorsByBookId(int bookId)
        {
            DbSet<BookAuthor> bookAuthorsDbSet = _context.Set<BookAuthor>();

            if (bookAuthorsDbSet == default(DbSet<BookAuthor>))
                return default(List<Author>);

            IEnumerable<BookAuthor> bookAuthors = bookAuthorsDbSet
                .Where(ba => ba.BookId == bookId);

            DbSet<Author> authorsDbSet = _context.Set<Author>();

            if (authorsDbSet == default(DbSet<Author>))
                return default(List<Author>);

            List<Author> authors = authorsDbSet
                .Where(a => 
                    bookAuthors.Any(ba => ba.AuthorId == a.Id))
                    .ToList();

            return authors;
        }
    }
}
