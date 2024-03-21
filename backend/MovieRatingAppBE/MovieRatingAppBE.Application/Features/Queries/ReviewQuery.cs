using GraphQL;
using GraphQL.Types;
using MovieRatingAppBE.Application.Contracts;
using MovieRatingAppBE.Application.Type;

namespace MovieRatingAppBE.Application.Features.Queries;

public class ReviewQuery : ObjectGraphType
{
    public ReviewQuery(IReviewRepository reviewRepository)
    {
        Field<ListGraphType<ReviewType>>("Reviews").Resolve(context =>
        {
            return reviewRepository.Get();
        });
        Field<MovieType>("Review").Arguments(new QueryArgument<IntGraphType>{Name = "id"}).Resolve(context =>
        {
            return reviewRepository.GetById(context.GetArgument<int>("id"));
        });
    }
}