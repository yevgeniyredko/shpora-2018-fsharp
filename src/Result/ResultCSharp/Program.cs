using System;

namespace ResultCSharp
{
    class Program
    {
        static Result<int> ReadData() => Result.Ok(42);

        static Result<None> WriteData(int x) => 
            Result.OfAction(() => Console.WriteLine(x));

        static void Main(string[] args)
        {
            var result = ReadData()
                .Then(i => i + 2)
                .Then(WriteData);
        }
    }
}
