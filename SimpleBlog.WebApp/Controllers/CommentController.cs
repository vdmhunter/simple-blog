using System;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SimpleBlog.Model;
using SimpleBlog.Service;

namespace SimpleBlog.WebApp.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        // POST: Comment/Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Save(int postId, string commentText)
        {
            Comment comment = new Comment
            {
                PostId = postId,
                Date = DateTime.Now,
                AuthorId = User.Identity.GetUserId(),
                Text = commentText
            };
            _commentService.CreateComment(comment);
            _commentService.SaveComment();

            return RedirectToAction("Details", "Post", new { id = postId });
        }
    }
}