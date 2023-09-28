


using Domain.Entities.Store;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        internal static Result<TValue> Failure<TValue, TError>()
        {
            new(default, isSuccess: false, error: TError.);
        }

        //public static Result<TValue> Failure<TValue>(TValue value) => new(value,false,);

    }
}
