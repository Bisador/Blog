
using Domain.CMS.Article.Events;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.CMS.Article.Entities;

public sealed class Article : AggregateRoot<Guid>
{
    private Article(
        Guid id,
        string title,
        string content,
        DateTime publishDate,
        Guid writerId) : base(id)
    {
        Title = title;
        Content = content;
        PublishDate = publishDate;
        WriterId = writerId;
    }
    public string Title { get; private set; }
    public string Content { get; private set; }
    public DateTime PublishDate { get; private set; }
    public Guid WriterId { get; private set; }
    public bool IsAccepted => _acceptanceHistory.LastOrDefault()?.IsAccepted ?? false;

    private readonly List<ArticleAcceptanceHistoryItem> _acceptanceHistory = new();
    public IReadOnlyCollection<ArticleAcceptanceHistoryItem> AcceptanceHistory => _acceptanceHistory;

    public static Article Create(
        Guid id,
        string title,
        string content,
        DateTime publishDate,
        Guid writerId)
    {
        Article article = new(id, title, content, publishDate, writerId);
        article.RaiseDomainEvent(new ArticleCreatedEvent(article.Id));
        return article;
    }

    private int GetLastAcceptanceId() => (AcceptanceHistory.LastOrDefault()?.Id ?? 0) + 1;
    public void Accept()
    {
        ArticleAcceptanceHistoryItem.Create(GetLastAcceptanceId(), this, isAccepted: true);
        RaiseDomainEvent(new ArticleAcceptedEvent(Id));
    }
    public void Reject()
    {
        ArticleAcceptanceHistoryItem.Create(GetLastAcceptanceId(), this, isAccepted: false);
        RaiseDomainEvent(new ArticleRejectedEvent(Id));
    }
}
