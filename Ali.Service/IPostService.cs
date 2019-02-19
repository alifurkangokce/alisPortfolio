using Ali.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Service
{
    public interface IPostService
    {
        void Insert(Post entity);
        void Update(Post entity);
        void Delete(Post entity);
        void Delete(Guid id);
        Post Find(Guid id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllByTitle(string title);
    }
}
