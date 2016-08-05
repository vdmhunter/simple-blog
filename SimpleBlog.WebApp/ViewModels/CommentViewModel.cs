using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.WebApp.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string AuthorId { get; set; }
    }
}