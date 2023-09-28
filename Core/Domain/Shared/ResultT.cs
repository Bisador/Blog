using System;  

namespace Domain.Shared
{
    public class Result<TValue> : Result
    {
        private readonly TValue? _value;

        protected internal Result(TValue? value, bool isSuccess, Error error) : base(isSuccess, error)
        {
            _value = value;
        }

        public TValue? Value => IsSuccess ?
            _value :
            throw new InvalidOperationException("The value of the failure result can't be accessed");


        public static implicit operator Result<TValue>(TValue? value) => (TValue?)Convert.ChangeType(value, typeof(TValue));
        public static implicit operator bool(Result<TValue> result) => result.IsSuccess;
        
    }
}
