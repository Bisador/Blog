using Domain.CMS.ArticleAggregate.Events; 

namespace Application.CMS.Article.Events;

public sealed class ArticleCreatedDomainEventHandler : INotificationHandler<ArticleCreatedEvent>
{
    public Task Handle(ArticleCreatedEvent notification, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}
