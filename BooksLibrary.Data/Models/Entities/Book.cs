using BooksLibrary.Data.Models.Common;
using BooksLibrary.Data.Models.Enums;
using BooksLibrary.Data.Models.Relations;

namespace BooksLibrary.Data.Models.Entities
{
    public class Book : BaseEntity, ICloneable
    {
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public Genre Genres { get; set; }
        public Language Language { get; set; }
        public DateTime Released { get; set; }
        public int CountOfAvailable { get; set; }
        public bool IsAvailable => CountOfAvailable > 0;
        public List<BookAuthor> BookAuthors { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
