
using Application.Abstraction.Messaging;
using Domain.CMS.ArticleAggregate.Entities;

namespace Application.CMS.Article.Queries.GetById;

public sealed record GetArticleByIdQuery(Guid Id) : IQuery<ArticleResponse>
{
}
