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
                ImagesUrls = ["https://www.imdb.com/title/tt1637688/mediaviewer/rm1617280768/?ref_=tt_ov_i","https://www.imdb.com/title/tt1637688/mediaviewer/rm3689329152/?ref_=tt_md_3","https://www.imdb.com/title/tt1637688/mediaviewer/rm3672551936/?ref_=tt_md_4"],
                Genres = ["Science Fiction","Thriller","Action"],
                Director = "Andrew Niccol",
                Cast=["Justin Timberlake","Cillian Murphy","Amanda Seyfried"]
            },
            new Movie 
            { 
                Id = 2, 
                Title = "The Pianist",
                Description = "During WWII, acclaimed Polish musician Wladyslaw faces various struggles as he loses contact with his family. As the situation worsens, he hides in the ruins of Warsaw in order to survive.",
                ImagesUrls = ["https://www.imdb.com/title/tt0253474/mediaviewer/rm902038272/?ref_=tt_ov_i","https://www.imdb.com/title/tt0253474/mediaviewer/rm1931906816/?ref_=tt_md_3","https://www.imdb.com/title/tt0253474/mediaviewer/rm1680248576/?ref_=tt_md_8"],
                Genres = ["Biography","Drama","Music"],
                Director = "Roman Polanski",
                Cast=["Adrien Brody","Thomas Kretschmann","Frank Finlay"]
                
            },
            new Movie
            {
                Id = 3, 
                Title = "Society of the Snow",
                Description = "The flight of a rugby team crashes on a glacier in the Andes. The few passengers who survive the crash find themselves in one of the world's toughest environments to survive.",
                ImagesUrls = ["https://www.imdb.com/title/tt16277242/mediaviewer/rm2344241665/?ref_=tt_ov_i","https://www.imdb.com/title/tt16277242/mediaviewer/rm1905282561/?ref_=tt_md_1","https://www.imdb.com/title/tt16277242/mediaviewer/rm1888505345/?ref_=tt_md_2"],
                Genres = ["Adventure","Biography","Drama"],
                Director = "J.A. Bayona",
                Cast=["Enzo Vogrincic","Agustín Pardella","Matías Recalt"]
            }
        );

    }
}