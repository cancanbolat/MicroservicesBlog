using Blog.Application.Abstractions.CQRS;
using Blog.Application.Features.Requests;
using Blog.Application.Interfaces;
using Blog.Application.Wrappers;
using Blog.Core.Models;
using Mapster;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Application.Features.Commands
{
    public class CreatePostCommand : ICommandHandler<CreatePostRequest, BaseResponse<int>>
    {
        private readonly IPostRepository _postRepository;

        public CreatePostCommand(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<BaseResponse<int>> Handle(CreatePostRequest request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.CreateAsync(request.Adapt<Post>());

            return new BaseResponse<int>
            {
                Data = post,
                Message = "Created Successfully"
            };
        }
    }
}
