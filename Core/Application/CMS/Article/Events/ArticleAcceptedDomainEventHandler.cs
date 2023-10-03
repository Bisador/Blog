using Domain.CMS.DomainEvents;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CMS.Article.Events;

public sealed class ArticleAcceptedDomainEventHandler : INotificationHandler<ArticleAcceptedEvent>
{
    public Task Handle(ArticleAcceptedEvent notification, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}
