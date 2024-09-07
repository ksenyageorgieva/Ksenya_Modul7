using Ksenya_Modul7.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicCatalog.Models
{
   
        public class MyDbContext : DbContext

        {
            public DbSet<Song> Songs { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseInMemoryDatabase("MyDb");
            }


        }
   
}
