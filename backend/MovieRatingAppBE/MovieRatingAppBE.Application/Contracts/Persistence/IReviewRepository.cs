using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Contracts;

public interface IReviewRepository
{
    IReadOnlyList<Review> Get();
    Review GetById(int id);
    void Create(Review review);
    void Update(Review review);
    void Delete(int id);
}