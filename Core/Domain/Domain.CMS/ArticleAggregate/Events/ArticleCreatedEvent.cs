using Domain.Abstraction;
using System;

namespace Domain.CMS.ArticleAggregate.Events;

public sealed record ArticleCreatedEvent(Guid ArticleId) : IDomainEvent;