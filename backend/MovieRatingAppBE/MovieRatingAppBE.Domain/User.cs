namespace MovieRatingAppBE.Domain;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Movie> WatchedList { get; set; }
    public List<Review> ReviewsList{ get; set; }
}