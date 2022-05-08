using System;

#nullable disable

namespace Blog.Core.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int? PostId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
    }
}
