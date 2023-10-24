 
using Domain.Shared;
using System;

namespace Domain.CMS.ArticleAggregate.Entities;

public sealed class ArticleAcceptanceHistoryItem : Entity<int>
{
    private ArticleAcceptanceHistoryItem(int id, Article article, bool isAccepted)
        : base(id)
    {
        Article = article;
        IsAccepted = isAccepted;
        CreatedDateTime = DateTime.UtcNow;
    }

    public Article Article { get; private set; }
    public bool IsAccepted { get; private set; }
    public DateTime CreatedDateTime { get; private set; }


    internal static ArticleAcceptanceHistoryItem Create(
        int id,
        Article article,
        bool isAccepted) => new(id, article, isAccepted);
}
