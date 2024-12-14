using BenchmarkDotNet.Attributes;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class BinarySearch
{
    /*
        | Method          | N      | Mean     | Error    | StdDev    | Median   | Allocated |
        |---------------- |------- |---------:|---------:|----------:|---------:|----------:|
        | SearchBenchmark | 10     | 151.0 ns | 22.15 ns |  64.61 ns | 200.0 ns |     400 B |
        | SearchBenchmark | 100    | 177.9 ns | 16.29 ns |  41.75 ns | 200.0 ns |     400 B |
        | SearchBenchmark | 1000   | 333.0 ns | 47.91 ns | 138.99 ns | 300.0 ns |     400 B |
        | SearchBenchmark | 10000  | 580.8 ns | 56.32 ns | 165.17 ns | 600.0 ns |     400 B |
        | SearchBenchmark | 100000 | 606.7 ns | 65.99 ns | 191.43 ns | 550.0 ns |      64 B |
    */
    private int[] _array = null!;
    private int _target = 0;

    [Params(10, 100, 1000, 10000, 100000)]
    public int N;
    private Random _randomIndex = null!;
    private Random _randomValue = null!;

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
        ADP_Implementations.Algorithms.BinarySearch.BinarySearch.Search(_array, _target, 0, _array.Length - 1);
    }

    [Benchmark]
    public void SearchBenchmarkDoWhile()
    {
        ADP_Implementations.Algorithms.BinarySearch.BinarySearch.Search_DoWhile(_array, _target);
    }
}