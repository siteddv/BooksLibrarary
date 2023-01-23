using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Enums;

namespace BooksLibrary.Data
{
    public static class TempDb
    {
        public static List<Book> Books = new List<Book>();
        public static List<Author> Authors = new List<Author>();

        public static void Init()
        {
            if(Books.Any() || Authors.Any())
                return;

            Books.Add(new Book()
            {
                Name = "White fang",
                ShortDesc = "Cool book",
                Released = DateTime.Now,
                Language = Language.Russian,
                Genres = Genre.Furry,
                CountOfAvailable = 100
            });

            Books.Add(new Book()
            {
                Name = "Apendi",
                ShortDesc = "Funny book",
                Released = DateTime.Now,
                Language = Language.Kyrgyz,
                Genres = Genre.Yaoi,
                CountOfAvailable = 50
            });

            Authors.Add(new Author()
            {
                FirstName = "Jack",
                LastName = "London",
                Popularity = 50,
            });
        }
    }
}
