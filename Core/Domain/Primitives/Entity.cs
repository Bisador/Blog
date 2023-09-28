using Domain.Shared;
using System;

namespace Domain.Primitives
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private init; }

        public static bool operator ==(Entity? first, Entity? second) => first is not null && first.Equals(second);
        public static bool operator !=(Entity? first, Entity? second) => !(first is not null && first.Equals(second));

        public override bool Equals(object? obj)
        {
            if (obj is null ||
                obj.GetType() != GetType() ||
                obj is not Entity entity)
            {
                return false;
            }

            return Id == entity.Id;
        }

        public bool Equals(Entity? other)
        {
            if (other is null ||
                other.GetType() != GetType())
            {
                return false;
            }

            return Id == other.Id;
        }

        public override int GetHashCode() => Utility.HashCodeSalter(Id.GetHashCode());
    }
}
