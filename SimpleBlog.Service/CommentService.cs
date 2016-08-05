using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using SimpleBlog.Data.Infrastructure;
using SimpleBlog.Data.Repositories;
using SimpleBlog.Model;

namespace SimpleBlog.Service
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetComments();
        Comment GetComment(int id);
        void CreateComment(Comment comment);
        void SaveComment();
    }

    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentsRepository;
        private readonly IPostRepository _postsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(ICommentRepository commentsRepository, IPostRepository postsRepository, IUnitOfWork unitOfWork)
        {
            _commentsRepository = commentsRepository;
            _postsRepository = postsRepository;
            _unitOfWork = unitOfWork;
        }

        #region ICommentService Members

        public IEnumerable<Comment> GetComments()
        {
            var comments = _commentsRepository.GetAll();
            return comments;
        }

        public Comment GetComment(int id)
        {
            var comment = _commentsRepository.GetById(id);
            return comment;
        }

        public void CreateComment(Comment comment)
        {
            _commentsRepository.Add(comment);
        }

        public void SaveComment()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
