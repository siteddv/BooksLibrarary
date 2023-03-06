using BooksLibrary.Data.Models.Entities;
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
    }
}
