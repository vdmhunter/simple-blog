using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using SimpleBlog.Model;
using SimpleBlog.Service;
using SimpleBlog.WebApp.ViewModels;

namespace SimpleBlog.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        private readonly ICommentService _commentService;

        public HomeController(IPostService postService, ICommentService commentService)
        {
            _postService = postService;
            _commentService = commentService;
        }

        public ActionResult Index()
        {
            IEnumerable<PostViewModel> viewModelBlog;
            IEnumerable<Post> posts;

            posts = _postService.GetPosts().OrderByDescending(p => p.Date);

            viewModelBlog = Mapper.Map<IEnumerable<Post>, IEnumerable<PostViewModel>>(posts);
            return View(viewModelBlog);
        }
    }
}