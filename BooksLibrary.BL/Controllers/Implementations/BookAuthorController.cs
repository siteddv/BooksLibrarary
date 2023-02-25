using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Relations;
using BooksLibrary.Data.Repositories.Interfaces;

namespace BooksLibrary.BL.Controllers.Implementations
{
    public class BookAuthorController
    {
        private readonly IRepository<BookAuthor> _repository;

        public BookAuthorController(IRepository<BookAuthor> repository)
        {
            _repository = repository;
        }

        public void Link(List<Author> authors, List<Book> books) 
        { 
            List<BookAuthor> bookAuthors = new List<BookAuthor>();
            foreach(Author author in authors)
            {
                foreach(Book book in books)
                {
                    bookAuthors.Add(new BookAuthor()
                    {
                        BookId = book.Id,
                        AuthorId = author.Id
                    });
                }
            }

            _repository.AddAll(bookAuthors);
        }

        public void Link(Author author, List<Book> books)
        {
            List<Author> authors = new List<Author>() { author };
            Link(authors, books);
        }


        public void Link(List<Author> authors, Book book)
        {
            List<Book> books = new List<Book>() { book };
            Link(authors, books);
        }

        public void Link(Author author, Book book)
        {
            List<Author> authors = new List<Author>() { author };
            List<Book> books = new List<Book>() { book };
            Link(authors, books);
        }
    }
}
