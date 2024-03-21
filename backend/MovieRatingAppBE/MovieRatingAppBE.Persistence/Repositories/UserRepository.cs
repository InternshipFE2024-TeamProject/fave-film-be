using System.Globalization;
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

    public void AddToWatchList(User user,int movieId)
    {
        //Continue with the query implementation
        var movie = _context.Movies.Find(movieId);
        user.WatchedList.Add(movie);
        _context.SaveChanges();
    }
    
    public void Register(User user)
    {
        //Continue with the query implementation
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public User Login(string Email, string Password)
    {
        //Continue with the query implementation
        var user = _context.Users.FirstOrDefault(u => u.Email == Email);
        if (user != null)
        {
            if (user.Password.Equals(Password))
            {
                return user;
            }
            else
            {
                throw new Exception("Invalid password for user with email: " + Email + "!");
            }
        }
        else
        {
            throw new Exception("User with email: " + Email + " not found!");
        }
    }
}