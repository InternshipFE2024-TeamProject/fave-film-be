using GraphQL.Types;
using MovieRatingAppBE.Application.Contracts;
using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Type;

public class MovieType : ObjectGraphType<Movie>
{
    public MovieType(IMovieRepository movieRepository)
    {
        Field(m => m.Id);
        Field(m => m.Title);
        ///Field<ListGraphType<StringGraphType>>(m=>m.ImagesUlrs);
    }
}