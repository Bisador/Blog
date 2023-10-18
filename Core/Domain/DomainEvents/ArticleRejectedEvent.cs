using Domain.Primitives;
using System;

namespace Domain.CMS.DomainEvents;

public sealed record ArticleRejectedEvent(Guid ArticleId) : IDomainEvent
{
}
