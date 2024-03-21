using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Contracts;

public interface IReviewRepository
{
    Task<IReadOnlyList<Review>> GetAsync();
    Task<Review> GetByIdAsync(int id);
    Task CreateAsync(Review review);
    Task UpdateAsync(Review review);
    Task DeleteAsync(int id);
}