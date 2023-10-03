using Domain.Primitives;
using System;

namespace Domain.CMS.Entities
{
    public sealed class ArticleAcceptanceHistoryItem : Entity
    {
        private ArticleAcceptanceHistoryItem(Article article, bool isAccepted)
            : base(Guid.NewGuid())
        {
            Article = article;
            IsAccepted = isAccepted;
            CreatedDateTime = DateTime.UtcNow;
        }

        public Article Article { get; private set; }
        public bool IsAccepted { get; private set; }
        public DateTime CreatedDateTime { get; private set; }


        internal static ArticleAcceptanceHistoryItem Create(
            Article article,
            bool isAccepted) => new(article, isAccepted);
    }
}
