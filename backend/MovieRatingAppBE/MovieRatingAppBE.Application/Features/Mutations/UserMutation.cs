using GraphQL;
using GraphQL.Types;
using MovieRatingAppBE.Application.Contracts;
using MovieRatingAppBE.Application.Type;
using MovieRatingAppBE.Application.Type.InputType;
using MovieRatingAppBE.Domain;

namespace MovieRatingAppBE.Application.Features.Mutations;

public class UserMutation:ObjectGraphType
{
    public UserMutation(IUserRepository userRepository)
    {
        Field<StringGraphType>("CreateUser").Arguments(new QueryArgument<UserInputType>{Name = "user"}).Resolve(context =>
        { 
            userRepository.Create(context.GetArgument<User>("user"));
            return "The user was created";
        });
    }
}