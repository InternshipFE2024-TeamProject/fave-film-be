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
    public async Task<IReadOnlyList<User>> GetAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> GetByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task CreateAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }
}