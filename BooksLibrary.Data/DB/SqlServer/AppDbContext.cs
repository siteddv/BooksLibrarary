using BooksLibrary.Data.DB.TempDb;
using BooksLibrary.Data.Models.Entities;
using BooksLibrary.Data.Models.Enums;
using BooksLibrary.Data.Models.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BooksLibrary.Data.DB.SqlServer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string? str = config["Action"];
            string? str1 = config["ConnectionString"];
            string? str2 = config
                .GetSection("ConnectionStrings")
                ["ConnectionString"];

            string? connectionString = config
                .GetConnectionString("ConnectionString");

            optionsBuilder
                .UseSqlServer(connectionString);
        }

        public void Seed()
        {
            if (Books.Any() || Authors.Any())
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

            SaveChanges();
        }
    }
}
