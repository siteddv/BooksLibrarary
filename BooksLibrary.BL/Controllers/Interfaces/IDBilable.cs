using BooksLibrary.Data.Models.Common;
using BooksLibrary.Data.Models.Entities;

namespace BooksLibrary.BL.Controllers.Interfaces
{
    public interface IDBilable<T> where T : BaseEntity
    {
        public void Add(T item); // C
        public List<T> GetAll(); // R
        public void Update(T oldItem, T newItem); // U
        public void Delete(T item); // D
    }
}
