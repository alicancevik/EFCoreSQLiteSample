using EFCoreSQLiteSample.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSQLiteSample.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\SQLiteDb\EFCoreSqliteSample.db");
        }

        public DbSet<Book> Books { get; set; }
    }
}
