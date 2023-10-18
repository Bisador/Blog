using Domain.Abstraction;
using System;

namespace Domain.CMS.Article.Events;

public sealed record ArticleRejectedEvent(Guid ArticleId) : IDomainEvent;