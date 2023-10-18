  
namespace Shared;

public class Error(string code, string message) : IEquatable<Error>
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NoneValue = new("Error.NullValue", "The specified result value is null.");

    public string Code { get; } = code;
    public string Message { get; } = message;

    public static implicit operator string(Error error) => error.Code;
    public static bool operator ==(Error? first, Error? second) => first is not null && first.Equals(second);
    public static bool operator !=(Error? first, Error? second) => !(first is not null && first.Equals(second));
    public bool Equals(Error? other)
    {
        if (other is null ||
            other.GetType() != GetType())
        {
            return false;
        }

        return Code == other.Code;
    }
    public override bool Equals(object? obj)
    {
        if (obj is null ||
            obj.GetType() != GetType() ||
            obj is not Error entity)
        {
            return false;
        }

        return Code == entity.Code;
    }
    public override int GetHashCode() => Utility.HashCodeSalter(Code.GetHashCode());

}