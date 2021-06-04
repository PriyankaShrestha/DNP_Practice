using AuthorAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthorAPI.Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\HP\RiderProjects\ExamA20-299543\AuthorAPI\AuthorsDB.db");
        }
    }
}