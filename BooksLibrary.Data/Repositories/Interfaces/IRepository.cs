﻿using BooksLibrary.Data.Models.Common;

namespace BooksLibrary.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T: BaseEntity
    {
        public T Add(T item); // C
        public List<T> AddAll(IEnumerable<T> items);
        public List<T> GetAll(); // R
        public T GetById(int id); // R
        public void Update(T item); // U
        public void Delete(T item); // D
    }
}
