using Domain.CMS.DomainEvents;
using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.CMS.Entities
{
    public sealed class Article : AggregateRoot
    {
        private Article(
            Guid id,
            string title,
            string content,
            DateTime publishDate,
            Writer writer) : base(id)
        {
            Title = title;
            Content = content;
            PublishDate = publishDate;
            Writer = writer;
        }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public DateTime PublishDate { get; private set; }
        public Writer Writer { get; private set; }
        public bool IsAccepted => _acceptanceHistory.LastOrDefault()?.IsAccepted ?? false;

        private readonly List<ArticleAcceptanceHistoryItem> _acceptanceHistory = new();
        public IReadOnlyCollection<ArticleAcceptanceHistoryItem> AcceptanceHistory => _acceptanceHistory;

        public static Article Create(
            Guid id,
            string title,
            string content,
            DateTime publishDate,
            Writer writer) => new(id, title, content, publishDate, writer);

        public void Accept()
        {
            ArticleAcceptanceHistoryItem.Create(this, isAccepted: true);
            RaiseDomainEvent(new ArticleAcceptedEvent(Id));
        }
        public void Reject() => ArticleAcceptanceHistoryItem.Create(this, isAccepted: false);

    }
}
