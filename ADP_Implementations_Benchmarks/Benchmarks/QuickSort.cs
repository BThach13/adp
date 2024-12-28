using BenchmarkDotNet.Attributes;
using ADP_Implementations.Algorithms;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class QuickSort_Benchmarks
{
    /*
        | Method         | N      | Mean         | Error       | StdDev      | Median       | Allocated |
        |--------------- |------- |-------------:|------------:|------------:|-------------:|----------:|
        | SortAscending  | 10     |     2.407 us |   0.1417 us |   0.4132 us |     2.400 us |     592 B |
        | SortDescending | 10     |     2.926 us |   0.1528 us |   0.4506 us |     2.950 us |     712 B |
        | SortAscending  | 100    |    16.806 us |   0.7678 us |   2.2275 us |    17.400 us |    3136 B |
        | SortDescending | 100    |    17.297 us |   0.7490 us |   2.1848 us |    17.150 us |    2656 B |
        | SortAscending  | 1000   |   158.093 us |   7.5181 us |  21.8114 us |   149.500 us |   24400 B |
        | SortDescending | 1000   |   158.818 us |   5.2491 us |  14.6323 us |   153.350 us |   24784 B |
        | SortAscending  | 10000  | 1,343.950 us |  26.2494 us |  35.9305 us | 1,346.400 us |  241600 B |
        | SortDescending | 10000  | 1,429.931 us | 115.8030 us | 330.3926 us | 1,487.350 us |  245728 B |
        | SortAscending  | 100000 | 7,765.564 us | 307.0063 us | 865.9168 us | 7,413.200 us | 2421208 B |
        | SortDescending | 100000 | 7,816.876 us | 164.1187 us | 457.4973 us | 7,670.050 us | 2414248 B |
    */
    private int[] _array = null!;
    private Random _random = new Random(36);

    [Params(10, 100, 1000, 10000, 100000)]
    public int N;

    [IterationSetup]
    public void IterationSetup()
    {
        _array = new int[N];

        for (int i = 0; i < N; i++)
        {
           _array[i] = _random.Next(N);
        }
    }

    [Benchmark]
    public void SortAscending()
    {
        QuickSort.Sort(_array, 0, _array.Length - 1, QuickSort.SortDirection.Ascending);
    }

    [Benchmark]
    public void SortDescending()
    {
        QuickSort.Sort(_array, 0, _array.Length - 1, QuickSort.SortDirection.Descending);
    }
}