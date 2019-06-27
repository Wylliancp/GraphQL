using Api.Facebook.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL.Types
{
    public class ComentarioType : ObjectGraphType<Comentario>
    {
        public ComentarioType()
        {
            Field(x => x.ComentariosId);
            Field(x => x.Text);
            Field(x => x.DataCreate);
            
        }
    }
}
