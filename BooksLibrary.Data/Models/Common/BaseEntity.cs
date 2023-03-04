using System.ComponentModel.DataAnnotations;

namespace BooksLibrary.Data.Models.Common
{
    public abstract class BaseEntity
    {
        
        public int Id { get; set; }
    }
}
