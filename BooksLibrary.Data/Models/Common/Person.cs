namespace BooksLibrary.Data.Models.Common
{
    public abstract class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;
    }
}
