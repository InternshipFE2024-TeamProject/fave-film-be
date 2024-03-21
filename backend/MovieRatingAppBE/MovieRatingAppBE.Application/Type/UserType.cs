using GraphQL.Types;
using MovieRatingAppBE.Application.Contracts;
using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Type;

public class UserType:ObjectGraphType<User>
{
    public UserType(IMovieRepository movieRepository, IReviewRepository reviewRepository)
    {
        Field(m => m.Id);
        Field(m => m.FirstName);
        Field(m =>m.LastName);
        Field( m =>m.Email);
        Field(m => m.Password);
        Field<ListGraphType<MovieType>>("WatchedList").Resolve(context =>
        {
            return movieRepository.Get();
        });
        Field<ListGraphType<ReviewType>>("ReviewsList").Resolve(context =>
        {
            return reviewRepository.Get();
        });
    }
}