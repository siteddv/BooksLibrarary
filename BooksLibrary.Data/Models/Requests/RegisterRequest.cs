using System.ComponentModel.DataAnnotations;

namespace BooksLibrary.Data.Models.Requests
{
    public class RegisterRequest
    {
        [Required]
        public string Email { get; set; }
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
