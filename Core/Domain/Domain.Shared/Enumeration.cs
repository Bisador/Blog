
using Shared;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Domain.Shared;
  
public class Enumeration(int id, string name)
        : IComparable, IEquatable<Enumeration>, IComparable<Enumeration>, IEqualityComparer<Enumeration>
{
    public int Id { get; private set; } = id;
    public string Name { get; private set; } = name;

    public static bool operator ==(Enumeration? left, Enumeration? right) => left is null ? right is null : left.Equals(right);
    public static bool operator !=(Enumeration? left, Enumeration? right) => !(left == right);

    public bool Equals(Enumeration? left, Enumeration? right) => left == right;
    public bool Equals(Enumeration? other) => this == other;
    public override bool Equals(object? obj) => obj is not null && ReferenceEquals(this, obj) && this == (Enumeration)obj;

    public int CompareTo(object? other) => other is null ? 1 : Id.CompareTo(((Enumeration)other).Id);
    public int CompareTo(Enumeration? other) => other is null ? 1 : Id.CompareTo((other).Id);

    public int GetHashCode([DisallowNull] Enumeration obj) => obj.GetHashCode(obj);
    public override int GetHashCode() => Utility.HashCodeSalter(Id.GetHashCode());

    public override string ToString() => Name;

    public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
        typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
                    .Select(f => f.GetValue(null))
    .Cast<T>();
}

public class Enumeration<TEnum>(int id, string name) : Enumeration(id, name)
    where TEnum : Enum
{
    public static IEnumerable<Enumeration> GetAll() =>
        Enum.GetValues(typeof(TEnum))
            .Cast<TEnum>()
            .Select(x => new Enumeration(Convert.ToInt32(x), x.ToString()));

}