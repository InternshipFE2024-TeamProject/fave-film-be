using Microsoft.EntityFrameworkCore;
using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Persistence.Data;

public class MovieRatingContext : DbContext
{
    public MovieRatingContext(DbContextOptions<MovieRatingContext> options ) : base(options)
    {
        
    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Review> Reviews { get; set; }

}