using BooksLibrary.Data.DB.SqlServer;
using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Relations;
using BooksLibrary.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Net;

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

        private List<BookAuthor> GetBookAuthors(DbSet<BookAuthor> bookAuthors, int bookId)
        {
            List<BookAuthor> result = new List<BookAuthor>();

            foreach(BookAuthor bookAuthor in bookAuthors)
            {
                if(bookAuthor.BookId == bookId)
                {
                    result.Add(bookAuthor);
                }
            }

            return result;
        }

        public List<Author> GetAuthors(DbSet<Author> authorsDbSet, 
            IEnumerable<BookAuthor> bookAuthors)
        {
            List<Author> result = new List<Author>();

            foreach (Author author in authorsDbSet)
            {
                foreach (BookAuthor bookAuthor in bookAuthors)
                {
                    if(bookAuthor.AuthorId == author.Id)
                    {
                        result.Add(author);
                        break;
                    }
                }
            }
            return result;
        }
    }
}
