using Domain.Abstraction;

namespace Domain.Shared;

public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot<TKey>
{
    private readonly List<IDomainEvent> _domainEvents = new();
    protected AggregateRoot(TKey id)
        : base(id)
    {
    }

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}
