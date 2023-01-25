using BooksLibrary.BL.Controllers.Interfaces;
using BooksLibrary.Data;
using BooksLibrary.Data.Models.Common;

namespace BooksLibrary.BL.Controllers.Implementations.Temp
{
    public class TempDBilController<T> : IDBilable<T> 
        where T : BaseEntity
    {
        public void Add(T item)
        {
            TempTable<T>.Items.Add(item);
        }

        public List<T> GetAll()
        {
            return TempTable<T>.Items;
        }

        public void Update(T oldItem, T newItem)
        {
            int index = TempTable<T>.Items.IndexOf(oldItem);

            if (index == -1)
                throw new ArgumentException($"{typeof(T).Name} wasn't found");

            TempTable<T>.Items[index] = newItem;
        }

        public void Delete(T item)
        {
            TempTable<T>.Items.Remove(item);
        }
    }
}
