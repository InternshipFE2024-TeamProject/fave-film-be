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
    public IReadOnlyList<Review> Get()
    {
        return _context.Reviews.ToList();
    }

    public Review GetById(int id)
    {
        return _context.Reviews.Find(id);
    }

    public void Create(Review review)
    {
        _context.Reviews.Add(review);
        _context.SaveChanges();
    }

    public void Update(Review review)
    {
        _context.Reviews.Update(review);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var reviewResult = _context.Reviews.Find(id);
        _context.Reviews.Remove(reviewResult);
        _context.SaveChanges();
    }
}