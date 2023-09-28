 
using System;

namespace Domain.Shared
{
    public class Error : IEquatable<Error>
    {
        public static readonly Error None = new(string.Empty, string.Empty);
        public static readonly Error NoneValue = new("Error.NullValue", "The specified result value is null.");
        public Error(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public string Code { get; }
        public string Message { get; }

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
}
