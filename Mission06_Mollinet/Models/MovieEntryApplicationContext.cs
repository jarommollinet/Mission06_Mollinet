using Microsoft.EntityFrameworkCore;

namespace Mission06_Mollinet.Models
{
    public class MovieEntryApplicationContext : DbContext

    {
        public MovieEntryApplicationContext(DbContextOptions<MovieEntryApplicationContext> options) : base (options) //Constructor
        {
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
