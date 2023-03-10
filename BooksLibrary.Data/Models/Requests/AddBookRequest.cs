using BooksLibrary.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BooksLibrary.Data.Models.Requests
{
    public class AddBookRequest
    {
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public Genre Genres { get; set; }
        public Language Language { get; set; }
        public DateTime Released { get; set; }
        public int CountOfAvailable { get; set; }
    }
}
