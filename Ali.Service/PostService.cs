using Ali.Data;
using Ali.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Service
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> postRepository;
        private readonly IUnitOfWork unitOfWork;
        public PostService(IUnitOfWork unitOfWork, IRepository<Post> postRepository)
        {
            this.unitOfWork = unitOfWork;
            this.postRepository = postRepository;
        }

        public void Delete(Post entity)
        {
            postRepository.Delete(entity);
            unitOfWork.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var post = postRepository.Find(id);
            if (post != null)
            {
                this.Delete(post);
            }
        }
        public Post Find(Guid id)
        {
            return postRepository.Find(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return postRepository.GetAll();
        }

        public IEnumerable<Post> GetAllByTitle(string title)
        {
            return postRepository.GetAll(w => w.Title.Contains(title));
        }

        public void Insert(Post entity)
        {
            postRepository.Insert(entity);
            unitOfWork.SaveChanges();
        }

        public void Update(Post entity)
        {
            var post = postRepository.Find(entity.Id);
            post.Title = entity.Title;
            post.Description = entity.Description;
            post.CategoryId = entity.CategoryId;
            postRepository.Update(post);
            unitOfWork.SaveChanges();
        }
    }
}
