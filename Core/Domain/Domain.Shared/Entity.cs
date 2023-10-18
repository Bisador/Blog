using Domain.Abstraction;
using Shared;

namespace Domain.Shared;

public abstract class Entity<TKey> : IEquatable<Entity<TKey>>, IEntity<TKey>
{
    protected Entity(TKey id)
    {
        Id = id;
    }
    public TKey Id { get; private init; }

    public static bool operator ==(Entity<TKey>? first, Entity<TKey>? second) => first is not null && first.Equals(second);
    public static bool operator !=(Entity<TKey>? first, Entity<TKey>? second) => !(first is not null && first.Equals(second));

    public override bool Equals(object? obj)
    {
        if (obj is null ||
            obj.GetType() != GetType() ||
            obj is not Entity<TKey> entity)
        {
            return false;
        }

        return Id is not null && Id.Equals(entity.Id);
    }

    public bool Equals(Entity<TKey>? other)
    {
        if (other is null ||
            other.GetType() != GetType())
        {
            return false;
        }

        return Id is not null && Id.Equals(other.Id);
    }

    public override int GetHashCode() => Id is null ? default : Utility.HashCodeSalter(Id.GetHashCode());
}
