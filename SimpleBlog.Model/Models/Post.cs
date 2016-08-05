using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleBlog.Model
{
    public sealed class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Text { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(128)]
        public string AuthorId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Comment> Comments { get; set; }
    }
}
