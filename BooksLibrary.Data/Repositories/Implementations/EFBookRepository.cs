using BooksLibrary.Data.DB.SqlServer;
using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Relations;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Data.Repositories.Implementations
{
    public class EFBookRepository : Repository<Book>
    {
        public EFBookRepository(AppDbContext context) : base(context)
        {
        }

        public List<Author> GetAuthorsByBookId(int bookId)
        {
            DbSet<BookAuthor> bookAuthorsDbSet = _context.Set<BookAuthor>();

            if (bookAuthorsDbSet == default(DbSet<BookAuthor>))
                return default(List<Author>);

            var r = bookAuthorsDbSet
                .Where(ba => ba.BookId == bookId)
                .ToList();

            var result = r.Select(ba => ba.Author).ToList();

            return result;
        }
    }
}
