using Microsoft.EntityFrameworkCore;
using MovieRatingAppBE.Application.Contracts;
using MovieRatingAppBE.Domain;
using MovieRatingAppBE.Persistence.Data;

namespace MovieRatingAppBE.Persistence.Repositories;

public class ReviewRepository : IReviewRepository
{
    private MovieRatingContext _context;

    public ReviewRepository(MovieRatingContext context)
    {
        _context = context;
    }
    public async Task<IReadOnlyList<Review>> GetAsync()
    {
        return await _context.Reviews.ToListAsync();
    }

    public async Task<Review> GetByIdAsync(int id)
    {
        return await _context.Reviews.FindAsync(id);
    }

    public async Task CreateAsync(Review review)
    {
        await _context.Reviews.AddAsync(review);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Review review)
    {
        _context.Reviews.Update(review);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var reviewResult = await _context.Reviews.FindAsync(id);
        _context.Reviews.Remove(reviewResult);
        await _context.SaveChangesAsync();
    }
}