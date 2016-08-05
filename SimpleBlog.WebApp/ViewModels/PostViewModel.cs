using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.WebApp.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string AuthorId { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
    }
}