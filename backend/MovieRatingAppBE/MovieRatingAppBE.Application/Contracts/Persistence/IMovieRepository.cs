using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Contracts;

public interface IMovieRepository
{
    Task<IReadOnlyList<Movie>> GetAsync();
    Task<Movie> GetByIdAsync(int id);
}