using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleBlog.Model
{
    public class Comment
    {
        public int Id { get; set; }

        [Column(TypeName = "ntext")]
        public string Text { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(128)]
        public string AuthorId { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
