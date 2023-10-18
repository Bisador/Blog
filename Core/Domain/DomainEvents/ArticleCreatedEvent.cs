using Domain.Primitives;
using System;

namespace Domain.CMS.DomainEvents;

public sealed record ArticleCreatedEvent(Guid ArticleId) : IDomainEvent
{
}
