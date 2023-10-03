  
namespace Domain.Shared
{
    public class Result
    {
        protected internal Result(bool isSuccess, Error error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }
        public bool IsSuccess { get; }

        public bool IsFailure => !IsSuccess;
        public Error Error { get; }
        public static Result Success => new(true, Error.None);

        public static implicit operator bool(Result result) => result.IsSuccess;

        internal static Result<TValue> Failure<TValue>(Error error) => new(default, isSuccess: false, error: error); 
    }
}
