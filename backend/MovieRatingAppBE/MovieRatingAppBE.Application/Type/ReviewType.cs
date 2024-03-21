using GraphQL.Types;
using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Type;

public class ReviewType : ObjectGraphType<Review>
{
    public ReviewType()
    {
        Field(r => r.Id);
        Field(r => r.Rating);
        Field(r =>r.Comment);
        Field( r =>r.Date);
        Field(r => r.UserId);
        Field(r =>r.MovieId);
       
    }   
}