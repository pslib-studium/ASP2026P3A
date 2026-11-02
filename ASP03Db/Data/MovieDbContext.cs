using ASP03Db.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP03Db.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "The Shawshank Redemption", Year = 1994, Length = 142 },
                new Movie { MovieId = 2, Title = "The Godfather", Year = 1972, Length = 175 },
                new Movie { MovieId = 3, Title = "The Dark Knight", Year = 2008, Length = 152 }
            );
        }
    }
}
