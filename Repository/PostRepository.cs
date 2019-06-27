using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Facebook.Entities;
using Api.Facebook.Ultils;

namespace Api.Facebook.Repository
{
    public class PostRepository : IPostRepository
    {

        public PostRepository()
        {
            _post = FakeRepository();
        }

        private static List<Post> _post { get; set; }

        private List<Post> FakeRepository()
        {
            List<Post> posts = new List<Post>();
            for (int i = 0; i < 100; i++)
            {
                posts.Add(new Post
                {
                    PostId = i,
                    Descricao = "Teste" + i,
                    Comentarios = new List<Comentario>{
                        new Comentario{ ComentariosId = i, Text = "lorem ipsum" }
                    },
                    Autor = new Autor
                    {
                        AutorId = i,
                        Nome = "Lorem ipsum nome" + i
                    }


                });
            }
            return posts;
        }


        public Post Create(Post post)
        {
            post.PostId = _post.Count + 1;
            _post.Add(post);
            return post;
        }

        public IEnumerable<Post> Get(PaginationSettings pageSettings)
        {
            return _post.AsQueryable().Page(pageSettings);
        }
    }
}
