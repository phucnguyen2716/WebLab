using Microsoft.EntityFrameworkCore;

namespace Lab2.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Lab2.Models.Movie> Movie { get; set; } = default!;
    }
}
