using GraphQL.Types;
using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Type;

public class ReviewType : ObjectGraphType<Review>
{
    public ReviewType()
    {
        Field(m => m.Id);
        Field(m => m.Rating);
        Field(m =>m.Comment);
        Field( m =>m.Date);
        Field(m => m.UserId);
        Field(m =>m.MovieId);
       
    }   
}