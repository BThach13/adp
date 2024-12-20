using BenchmarkDotNet.Attributes;
using ADP_Implementations.Algorithms.BinarySearch;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class BinarySearch_Benchmarks
{
    /*
        | Method                 | N      | Mean     | Error    | StdDev    | Median   | Allocated |
        |----------------------- |------- |---------:|---------:|----------:|---------:|----------:|
        | SearchBenchmark        | 10     | 180.6 ns | 24.44 ns |  71.30 ns | 200.0 ns |     400 B |
        | SearchBenchmarkDoWhile | 10     | 223.2 ns | 26.15 ns |  76.70 ns | 200.0 ns |     400 B |
        | SearchBenchmark        | 100    | 151.0 ns | 25.22 ns |  73.56 ns | 100.0 ns |     400 B |
        | SearchBenchmarkDoWhile | 100    | 251.5 ns | 26.84 ns |  77.88 ns | 300.0 ns |     400 B |
        | SearchBenchmark        | 1000   | 245.7 ns | 31.72 ns |  89.46 ns | 200.0 ns |     400 B |
        | SearchBenchmarkDoWhile | 1000   | 440.4 ns | 34.60 ns |  98.72 ns | 500.0 ns |     400 B |
        | SearchBenchmark        | 10000  | 394.0 ns | 48.40 ns | 142.72 ns | 400.0 ns |      64 B |
        | SearchBenchmarkDoWhile | 10000  | 430.4 ns | 37.44 ns | 105.60 ns | 400.0 ns |      64 B |
        | SearchBenchmark        | 100000 | 550.5 ns | 61.49 ns | 180.35 ns | 500.0 ns |     400 B |
        | SearchBenchmarkDoWhile | 100000 | 610.4 ns | 48.36 ns | 139.53 ns | 600.0 ns |     400 B |
    */
    private int[] _array = null!;
    private int _target = 0;

    [Params(10, 100, 1000, 10000, 100000)]
    public int N;

    [IterationSetup]
    public void IterationSetup()
    {
        _array = new int[N];
        _target = new Random().Next(0, N * 3);

        for (int i = 0; i < N; i++)
        {
           _array[i] = i * 3;
        }
    }

    [Benchmark]
    public void SearchBenchmark()
    {
        BinarySearch.Search(_array, _target, 0, _array.Length - 1);
    }

    [Benchmark]
    public void SearchBenchmarkDoWhile()
    {
        BinarySearch.Search_DoWhile(_array, _target);
    }
}