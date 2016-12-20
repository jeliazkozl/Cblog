using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public List<Category> Categories { get; set; }

        public string Tags { get; set; }

        public ICollection<Article> Articles { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public string AuthorId { get; set; }
        
    }
}