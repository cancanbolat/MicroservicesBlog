using Blog.Application.Abstractions.CQRS;
using Blog.Application.DTOs;
using Blog.Application.Wrappers;

namespace Blog.Application.Features.Requests
{
    public class GetPostRequest : IQuery<BaseResponse<PostDto>>
    {
        public int Id { get; set; }
    }
}
