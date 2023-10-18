using Domain.Abstraction;
using System;

namespace Domain.CMS.Article.Events;

public sealed record ArticleCreatedEvent(Guid ArticleId) : IDomainEvent;