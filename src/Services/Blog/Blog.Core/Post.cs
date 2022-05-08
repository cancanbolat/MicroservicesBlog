using System;

namespace Blog.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public byte? IsActive { get; set; }
        public int CategoryId { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}
