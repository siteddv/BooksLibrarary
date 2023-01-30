using BooksLibrary.Data.Models.Common;

namespace BooksLibrary.Data.Models.Entities
{
    public class Author : Person, ICloneable
    {
        public List<Book> WrittenBooks { get; set; }
        public int Popularity { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
