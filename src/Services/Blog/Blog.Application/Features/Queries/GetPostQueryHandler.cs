using Blog.Application.Abstractions.CQRS;
using Blog.Application.DTOs;
using Blog.Application.Features.Requests;
using Blog.Application.Interfaces;
using Blog.Application.Wrappers;
using Mapster;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Application.Features.Queries
{
    public class GetPostQueryHandler : IQueryHandler<GetPostRequest, BaseResponse<PostDto>>
    {
        private readonly IPostRepository _postRepository;

        public GetPostQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<BaseResponse<PostDto>> Handle(GetPostRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var post = await _postRepository.GetByIdAsync(request.Id);
                var result = post.Adapt<PostDto>();

                return new BaseResponse<PostDto>
                {
                    Data = result
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<PostDto>
                {
                    HasError = true,
                    Message = ex.Message
                };
            }    
        }
    }
}
