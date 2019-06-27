using Api.Facebook.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL.Types
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Field(x => x.PostId);
            Field(x => x.Titulo);
            Field(x => x.Descricao);
            Field(x => x.DataCreate);
            Field(x => x.Likes);
            Field<AutorType>(typeof(Autor).Name);
            Field<ListGraphType<ComentarioType>>(typeof(Comentario).Name);
        }
    }
}
