using Domain.CMS.ArticleAggregate.Events; 

namespace Application.CMS.Article.Events;

public sealed class ArticleAcceptedDomainEventHandler : INotificationHandler<ArticleAcceptedEvent>
{
    public Task Handle(ArticleAcceptedEvent notification, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}
