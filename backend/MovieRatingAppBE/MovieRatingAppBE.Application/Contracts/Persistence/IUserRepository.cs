using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Contracts;

public interface IUserRepository
{
    Task<IReadOnlyList<User>> GetAsync();
    Task<User> GetByIdAsync(int id);
    Task CreateAsync(User user);

}