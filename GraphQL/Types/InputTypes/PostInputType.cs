using Api.Facebook.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL.Types.InputTypes
{
    public class PostInputType : InputObjectGraphType<Post>
    {
        public PostInputType()
        {
            Field(x => x.Titulo);
            Field(x => x.Descricao);
        }
    }
}
