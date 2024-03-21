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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 1, 
                Title = "In Time",
                Description = "In a future where people stop aging at 25, but are engineered to live only one more year, having the means to buy your way out of the situation is a shot at immortal youth. Here, Will Salas finds himself accused of murder and on the run with a hostage - a connection that becomes an important part of the way against the system.",
                ImagesUrls = ["https://m.media-amazon.com/images/M/MV5BMjA3NzI1ODc1MV5BMl5BanBnXkFtZTcwMzI5NjQwNg@@._V1_.jpg","https://m.media-amazon.com/images/M/MV5BMTU4NTY2NDU3Ml5BMl5BanBnXkFtZTcwMjQ1MTE5Ng@@._V1_.jpg","https://static.cinemagia.ro/img/db/movie/55/89/90/in-time-690990l.jpg"],
                Genres = ["Science Fiction","Thriller","Action"],
                Director = "Andrew Niccol",
                Cast=["Justin Timberlake","Cillian Murphy","Amanda Seyfried"]
            },
            new Movie 
            { 
                Id = 2, 
                Title = "The Pianist",
                Description = "During WWII, acclaimed Polish musician Wladyslaw faces various struggles as he loses contact with his family. As the situation worsens, he hides in the ruins of Warsaw in order to survive.",
                ImagesUrls = ["https://m.media-amazon.com/images/M/MV5BOWRiZDIxZjktMTA1NC00MDQ2LWEzMjUtMTliZmY3NjQ3ODJiXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_FMjpg_UX1000_.jpg","https://m.media-amazon.com/images/M/MV5BMTMxMTUzOTYxNF5BMl5BanBnXkFtZTcwNDYxMTIyMw@@._V1_.jpg","https://filmforum.org/do-not-enter-or-modify-or-erase/client-uploads/_1000w/THE_PIANIST_slideshow_3.png"],
                Genres = ["Biography","Drama","Music"],
                Director = "Roman Polanski",
                Cast=["Adrien Brody","Thomas Kretschmann","Frank Finlay"]
                
            },
            new Movie
            {
                Id = 3, 
                Title = "Society of the Snow",
                Description = "The flight of a rugby team crashes on a glacier in the Andes. The few passengers who survive the crash find themselves in one of the world's toughest environments to survive.",
                ImagesUrls = ["https://elranchito.es/wp-content/uploads/2023/12/MV5BYWQ0Y2MxODgtOWI0ZC00MWIwLWIyYzEtN2FhNWQ1MGQ3MDBhXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_.jpg","https://variety.com/wp-content/uploads/2023/07/Society-of-the-Snow.jpg?w=1000","https://m.media-amazon.com/images/M/MV5BZWQwYTljYWEtOThjZS00NmI5LWFmZTAtNDcyZjAwY2MxNjRjXkEyXkFqcGdeQXVyMDc2NTEzMw@@._V1_.jpg"],
                Genres = ["Adventure","Biography","Drama"],
                Director = "J.A. Bayona",
                Cast=["Enzo Vogrincic","Agustín Pardella","Matías Recalt"]
            }
        );

    }
}