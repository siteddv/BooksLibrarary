using BooksLibrary.Data.Models.Common;
using BooksLibrary.Data.Models.Relations;

namespace BooksLibrary.Data.Models.Entities
{
    public class Author : Person, ICloneable
    {
        public int Popularity { get; set; }
        public int CountOfSexPartners { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
