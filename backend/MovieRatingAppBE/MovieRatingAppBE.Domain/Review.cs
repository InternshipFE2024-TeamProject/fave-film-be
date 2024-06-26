namespace MovieRatingAppBE.Domain;

public class Review
{
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime Date { get; set; }
    public int UserId { get; set; }
    public int MovieId { get; set; }
}