namespace MovieRatingAppBE.Domain;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<string> ImagesUlrs { get; set; }
    public List<string> Genres { get; set; }
    public string Director { get; set; }
    public List<string> Cast { get; set; }
    public List<Review> Reviews { get; set; }
}