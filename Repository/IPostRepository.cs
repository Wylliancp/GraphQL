using Api.Facebook.Entities;
using Api.Facebook.Ultils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Facebook.Repository
{
    public interface IPostRepository
    {
        //ICollection<Post> GetTodos();
        //Post GetById(int id);
        IEnumerable<Post> Get(PaginationSettings pageSettings);
        Post Create(Post post);
    }
}
