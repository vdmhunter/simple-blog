using System.Collections.Generic;
using SimpleBlog.Data.Infrastructure;
using SimpleBlog.Data.Repositories;
using SimpleBlog.Model;

namespace SimpleBlog.Service
{
    public interface IPostService
    {
        IEnumerable<Post> GetPosts();
        Post GetPost(int id);
        void CreatePost(Post post);
        void SavePost();
    }

    public class PostService : IPostService
    {
        private readonly IPostRepository _postsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postsRepository, IUnitOfWork unitOfWork)
        {
            _postsRepository = postsRepository;
            _unitOfWork = unitOfWork;
        }

        #region IPostService Members

        public IEnumerable<Post> GetPosts()
        {
            var posts = _postsRepository.GetAll();
            return posts;
        }

        public Post GetPost(int id)
        {
            var post = _postsRepository.GetById(id);
            return post;
        }

        public void CreatePost(Post post)
        {
            _postsRepository.Add(post);
        }

        public void SavePost()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
