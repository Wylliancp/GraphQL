using Api.Facebook.GraphQL.Mulation;
using Api.Facebook.GraphQL.Queries;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL.Schemas
{
    public class PostSchema : Schema
    {
        public PostSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<PostQuery>();
            Mutation = resolver.Resolve<PostMutation>();
        }
    }
}
