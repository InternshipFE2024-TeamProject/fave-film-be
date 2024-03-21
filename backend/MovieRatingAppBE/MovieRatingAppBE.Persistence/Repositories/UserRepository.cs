using Microsoft.EntityFrameworkCore;
using MovieRatingAppBE.Application.Contracts;
using MovieRatingAppBE.Domain;
using MovieRatingAppBE.Persistence.Data;

namespace MovieRatingAppBE.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private MovieRatingContext _context;

    public UserRepository(MovieRatingContext context)
    {
        _context = context;
    }
    public IReadOnlyList<User> Get()
    {
        return _context.Users.ToList();
    }

    public User GetById(int id)
    {
        return _context.Users.Find(id);
    }

    public void Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
}