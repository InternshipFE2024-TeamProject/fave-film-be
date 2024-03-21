using Microsoft.EntityFrameworkCore;
using MovieRatingAppBE.Application.Contracts;
using MovieRatingAppBE.Domain;
using MovieRatingAppBE.Persistence.Data;

namespace MovieRatingAppBE.Persistence.Repositories;

public class MovieRepository : IMovieRepository
{
    private MovieRatingContext _context;

    public MovieRepository(MovieRatingContext context)
    {
        _context = context;
    }
    public async Task<IReadOnlyList<Movie>> GetAsync()
    {
        return await _context.Movies.ToListAsync();
    }

    public async Task<Movie> GetByIdAsync(int id)
    {
        return await _context.Movies.FindAsync(id);
    }
}