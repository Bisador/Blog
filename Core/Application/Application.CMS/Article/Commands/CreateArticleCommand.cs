using Application.Abstraction.Messaging;
using System;

namespace Application.CMS.Article.Commands;

public record CreateArticleCommand(Guid WriterId, string Title, string Content, DateTime PublishDate)
    : ICommand;
