using MediatR;

namespace Blog.Application.Abstractions.CQRS
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
