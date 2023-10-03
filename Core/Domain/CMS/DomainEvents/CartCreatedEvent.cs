using Domain.Primitives;
using System;

namespace Domain.CMS.DomainEvents;

public sealed record CartCreatedEvent(Guid CartId) : IDomainEvent
{
}
