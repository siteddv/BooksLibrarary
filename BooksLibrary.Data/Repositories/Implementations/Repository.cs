using BooksLibrary.Data.DB.SqlServer;
using BooksLibrary.Data.Models.Common;
using BooksLibrary.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Data.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> 
        where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public T Add(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return default(T);

            T result = dbSet.Add(item).Entity;
            _context.SaveChanges();

            return result;
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return default(List<T>);

            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T oldItem, T newItem)
        {
            throw new NotImplementedException();
        }
    }
}
