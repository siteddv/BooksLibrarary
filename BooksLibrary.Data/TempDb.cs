using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Enums;

namespace BooksLibrary.Data
{
    public static class TempDb
    {
        public static void Seed()
        {
            if (TempTable<Book>.Items.Any() 
                || TempTable<Author>.Items.Any())
                return;

            TempTable<Book>.Items.Add(new Book()
            {
                Name = "White fang",
                ShortDesc = "Cool book",
                Released = DateTime.Now,
                Language = Language.Russian,
                Genres = Genre.Furry,
                CountOfAvailable = 100
            });

            TempTable<Book>.Items.Add(new Book()
            {
                Name = "Apendi",
                ShortDesc = "Funny book",
                Released = DateTime.Now,
                Language = Language.Kyrgyz,
                Genres = Genre.Yaoi,
                CountOfAvailable = 50
            });

            TempTable<Author>.Items.Add(new Author()
            {
                FirstName = "Jack",
                LastName = "London",
                Popularity = 50,
            });
        }
    }
}
