using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.Entities
{
    public class Post
    {
        public long PostId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCreate { get; set; }
        public int Likes { get; set; }
        public IEnumerable<Comentario> Comentarios { get; set; }
        public Autor Autor { get; set; }
    }
}
