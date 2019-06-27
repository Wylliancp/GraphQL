using Api.Facebook.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.GraphQL.Types
{
    public class AutorType : ObjectGraphType<Autor>
    {
        public AutorType()
        {
            Field(x => x.AutorId);
            Field(x => x.Nome);
        }
    }
}
