using Blog.Application.Abstractions.CQRS;
using Blog.Application.Wrappers;

namespace Blog.Application.Features.Requests
{
    public class CreatePostRequest : ICommand<BaseResponse<int>>
    {
        public string Title { get; set; }
        public string Tags { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
