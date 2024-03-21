using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Contracts;

public interface IUserRepository
{
    IReadOnlyList<User> Get();
    User GetById(int id);
    void Create(User user);

}