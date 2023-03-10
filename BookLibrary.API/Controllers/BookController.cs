using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Enums;
using BooksLibrary.Data.Models.Requests;
using BooksLibrary.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController
    {
        private readonly IRepository<Book> _bookRepository;

        public BookController(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet(Name = "GetAllBooks")]
        public List<Book> GetBooks()
        {
            return _bookRepository.GetAll();
        }

        [HttpPost(Name = "Add new book")]
        public void AddBook([FromQuery] AddBookRequest bookRequest)
        {
            ThrowExceptionIfExists(bookRequest);
            ThrowExceptionIfExists(bookRequest.ShortDesc);

            Book book = new Book()
            {
                Name = bookRequest.Name,
                ShortDesc = bookRequest.ShortDesc,
                Genres = bookRequest.Genres,
                Language = bookRequest.Language,
                Released = bookRequest.Released,
                CountOfAvailable = bookRequest.CountOfAvailable,
            };

            _bookRepository.Add(book);
        }

        private void ThrowExceptionIfExists(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(typeof(object).FullName);
        }
    }
}
