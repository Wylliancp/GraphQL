using Api.Facebook.GraphQL.Types;
using Api.Facebook.GraphQL.Types.FilterType;
using Api.Facebook.Repository;
using Api.Facebook.Ultils;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL.Queries
{
    public class PostQuery : ObjectGraphType
    {
        public PostQuery(IPostRepository repository)
        {
            Field<ListGraphType<PostType>>(
                "post",
                arguments: new QueryArguments(new QueryArgument<PaginationSettingsType>
                {
                    Name = "pageSettings"
                }),
                resolve: context =>
                {
                    var pageSettings = context.GetArgument<PaginationSettings>("pageSettings", new PaginationSettings());
                    return repository.Get(pageSettings).ToList();
                }
                );
        }
    }
}
