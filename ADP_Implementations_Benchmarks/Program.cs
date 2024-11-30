using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<Benchmarks>();
    }
}

public class Benchmarks
{
    [Benchmark]
    public int CalculateSquare()
    {
        int result = 0;
        for (int i = 0; i < 1000; i++)
        {
            result += i * i;
        }
        return result;
    }
}
