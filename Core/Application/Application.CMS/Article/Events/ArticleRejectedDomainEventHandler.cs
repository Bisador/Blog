using Domain.CMS.ArticleAggregate.Events; 

namespace Application.CMS.Article.Events;

public sealed class ArticleRejectedDomainEventHandler : INotificationHandler<ArticleRejectedEvent>
{
    public Task Handle(ArticleRejectedEvent notification, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}
