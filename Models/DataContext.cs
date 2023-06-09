using Microsoft.EntityFrameworkCore;

namespace DVDMovie.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Studio> Studios { get; set; }

        // dotnet ef migrations add Initial
        // dotnet ef update database
    }
}