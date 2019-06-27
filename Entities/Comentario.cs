using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.Entities
{
    public class Comentario
    {
        public long ComentariosId { get; set; }
        public string Text { get; set; }
        public DateTime DataCreate { get; set; }
        public Autor Autor { get; set; }
    }
}
