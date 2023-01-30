using BooksLibrary.BL.Controllers.Interfaces;
using BooksLibrary.Data.Models.Entities;
using static System.Reflection.Metadata.BlobBuilder;

namespace BooksLibrary.BL.Controllers.Implementations.Temp
{
    public class BookAuthorController : IBookAuthorController
    {
        private readonly IDBilable<Book> _bookController;
        private readonly IDBilable<Author> _authorController;

        public BookAuthorController(IDBilable<Book> bookController, 
            IDBilable<Author> authorController)
        {
            _bookController = bookController;
            _authorController = authorController;
        }

        /// <summary>
        /// Links all the authors with all the books
        /// </summary>
        /// <param name="books"></param>
        /// <param name="authors"></param>
        public void Link(List<Book> books, List<Author> authors)
        {
            UpdateBooks(books, authors);
            UpdateAuthors(books, authors);
        }

        public void Link(Book book, List<Author> authors)
        {
            List<Book> books = new List<Book>() { book };

            Link(books, authors);
        }

        public void Link(List<Book> books, Author author)
        {
            List<Author> authors = new List<Author>() { author };

            Link(books, authors);
        }

        public void Link(Book book, Author author)
        {
            List<Author> authors = new List<Author>() { author };

            List<Book> books = new List<Book>() { book };

            Link(books, authors);
        }

        private void UpdateBooks(List<Book> books, List<Author> authors)
        {
            List<Author> newAuthors = authors
                .Select(a => (Author)a.Clone()).ToList();

            for (int i=0; i< books.Count; i++) 
            {
                Book book = books[i];
                Book newBook = (Book)book.Clone();

                if (newBook == null)
                    continue;

                if (newBook.Authors == null)
                    newBook.Authors = newAuthors;

                newBook.Authors.AddRange(newAuthors);

                _bookController.Update(book, newBook);
            }
        }

        private void UpdateAuthors(List<Book> books, List<Author> authors)
        {
            List<Book> newBooks = books
                .Select(b => (Book)b.Clone()).ToList();

            for (int i=0; i< authors.Count; ++i)
            {
                Author author = authors[i];
                Author newAuthor = (Author)author.Clone();

                if (newAuthor == null)
                    continue;

                if (newAuthor.WrittenBooks == null)
                    newAuthor.WrittenBooks = newBooks;

                newAuthor.WrittenBooks.AddRange(newBooks);

                _authorController.Update(author, newAuthor);
            }
        }
    }
}
