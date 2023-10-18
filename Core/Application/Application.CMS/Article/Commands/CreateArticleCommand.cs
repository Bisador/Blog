using System;

namespace Application.CMS.Article.Commands;

public record CreateArticleCommand(Guid WriterId, string Title, string Content, DateTime PublishDate)
    : IRequest<Guid>;
 