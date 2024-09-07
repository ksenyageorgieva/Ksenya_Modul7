using Microsoft.EntityFrameworkCore;

namespace Ksenya_Modul7.Models
{
    public class DataBaseContext: DbContext

    {
        public DbSet<Person> People { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }

        
    }
}
