using MediatR;
using Shared;

namespace Application.Abstraction.Messaging;

public interface IQueryHandler<TQuery,TResponse> : IRequestHandler<TQuery,Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
