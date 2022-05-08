using Blog.Application.Abstractions.CQRS;
using Blog.Application.DTOs;
using Blog.Application.Wrappers;
using System.Collections.Generic;

namespace Blog.Application.Features.Requests
{
    public class GetAllPostsRequest : IQuery<BaseResponse<List<PostDto>>>
    {
    }
}
