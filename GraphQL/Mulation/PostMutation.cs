using Api.Facebook.Entities;
using Api.Facebook.GraphQL.Types;
using Api.Facebook.GraphQL.Types.InputTypes;
using Api.Facebook.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL.Mulation
{
    public class PostMutation : ObjectGraphType
    {
        public PostMutation(IPostRepository repository)
        {
            Field<PostType>("createPost",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PostInputType>> { Name = "postInput" }
                    ),
                resolve: context =>
                {
                    var post = context.GetArgument<Post>("postInput");
                    return repository.Create(post);
                });
        }
    }
}
