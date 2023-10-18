using Domain.Primitives;
using System;

namespace Domain.CMS.DomainEvents;

public sealed record ArticleAcceptedEvent(Guid ArticleId) : IDomainEvent
{
}
