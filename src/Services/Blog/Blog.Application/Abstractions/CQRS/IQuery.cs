using MediatR;

namespace Blog.Application.Abstractions.CQRS
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
