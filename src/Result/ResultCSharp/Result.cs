using System;

namespace ResultCSharp
{
    public class None
    {
        private None()
        {
        }
    }

    public struct Result<T>
    {
        public Result(string error, T value = default(T))
        {
            Error = error;
            Value = value;
        }

        public bool IsSuccess => Error == null;
        public string Error { get; }
        internal T Value { get; }

        public T GetValueOrThrow() =>
            IsSuccess
                ? Value
                : throw new InvalidOperationException($"No value. Only Error {Error}");
    }

    public static class Result
    {		
        public static Result<None> Ok() => Ok<None>(null);
        public static Result<T> Ok<T>(T value) => new Result<T>(null, value);
        public static Result<T> Fail<T>(string e) => new Result<T>(e);

        public static Result<T> Of<T>(Func<T> f, string error = null)
        {
            try
            {
                return Ok(f());
            }
            catch (Exception e)
            {
                return Fail<T>(error ?? e.Message);
            }
        }

        public static Result<None> OfAction(Action f, string error = null)
        {
            try
            {
                f();
                return Ok();
            }
            catch (Exception e)
            {
                return Fail<None>(error ?? e.Message);
            }
        }

        public static Result<TOutput> Then<TInput, TOutput>(
            this Result<TInput> input,
            Func<TInput, TOutput> continuation)
        {
            return input.Then(inp => Of(() => continuation(inp)));
        }

        public static Result<None> Then<TInput>(
            this Result<TInput> input,
            Action<TInput> continuation)
        {
            return input.Then(inp => OfAction(() => continuation(inp)));
        }

        public static Result<TOutput> Then<TInput, TOutput>(
            this Result<TInput> input,
            Func<TInput, Result<TOutput>> continuation)
        {
            return input.IsSuccess
                ? continuation(input.Value)
                : Fail<TOutput>(input.Error);
        }
    }
}
