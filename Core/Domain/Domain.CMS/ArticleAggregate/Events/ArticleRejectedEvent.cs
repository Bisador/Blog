using Domain.Abstraction;
using System;

namespace Domain.CMS.ArticleAggregate.Events;

public sealed record ArticleRejectedEvent(Guid ArticleId) : IDomainEvent;