using BooksLibrary.Data.Models.Common;

namespace BooksLibrary.Data.Models.Entities
{
    public class Author : Person, ICloneable
    {
        public int Popularity { get; set; }
        public int CountOfSexPartners { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
