using Blog.Application.Interfaces;
using Blog.Core.Models;
using Microsoft.Extensions.Configuration;

namespace Blog.Infrastructure.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
