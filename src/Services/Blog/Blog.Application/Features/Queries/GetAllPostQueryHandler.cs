using Blog.Application.Abstractions.CQRS;
using Blog.Application.DTOs;
using Blog.Application.Features.Requests;
using Blog.Application.Interfaces;
using Blog.Application.Wrappers;
using Mapster;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Application.Features.Queries
{
    public class GetAllPostQueryHandler : IQueryHandler<GetAllPostsRequest, BaseResponse<List<PostDto>>>
    {
        private readonly IPostRepository _postRepository;

        public GetAllPostQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<BaseResponse<List<PostDto>>> Handle(GetAllPostsRequest request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetAllAsync();
            var result = posts.Adapt<List<PostDto>>();

            return new BaseResponse<List<PostDto>>
            {
                Data = result,
                Message = $"Count: {result.Count}"
            };
        }
    }
}
