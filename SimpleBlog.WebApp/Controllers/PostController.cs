using System;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.AspNet.Identity;
using SimpleBlog.Model;
using SimpleBlog.Service;
using SimpleBlog.WebApp.ViewModels;

namespace SimpleBlog.WebApp.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                Post post = new Post
                {
                    Title = model.Title,
                    Text = model.Text,
                    Date = DateTime.Now,
                    AuthorId = User.Identity.GetUserId()
                };
                _postService.CreatePost(post);
                _postService.SavePost();

                return RedirectToAction("Index", "Home");
            }

            return View(model);    
        }

        // GET: Post/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            PostViewModel viewModelPost;
            Post post;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                post = _postService.GetPost(id.Value);
            }
            if (post == null)
            {
                return HttpNotFound();
            }
            viewModelPost = Mapper.Map<Post, PostViewModel>(post);
            return View(viewModelPost);
        }
    }
}