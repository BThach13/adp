using BenchmarkDotNet.Attributes;
using ADP_Implementations.Algorithms.SelectionSort;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class SelectionSort_Benchmarks
{
    /*
        | Method         | N      | Mean             | Error          | StdDev        | Median           | Allocated |
        |--------------- |------- |-----------------:|---------------:|--------------:|-----------------:|----------:|
        | SortAscending  | 10     |         1.654 us |      0.0946 us |     0.2790 us |         1.600 us |     400 B |
        | SortDescending | 10     |         1.670 us |      0.0978 us |     0.2883 us |         1.600 us |     400 B |
        | SortAscending  | 100    |        23.362 us |      0.9481 us |     2.7805 us |        22.100 us |     400 B |
        | SortDescending | 100    |        24.718 us |      1.0705 us |     3.1562 us |        23.450 us |     400 B |
        | SortAscending  | 1000   |       347.738 us |      6.9152 us |    12.1114 us |       346.700 us |     400 B |
        | SortDescending | 1000   |       320.229 us |      6.0665 us |     6.2298 us |       321.800 us |     400 B |
        | SortAscending  | 10000  |    26,957.483 us |    536.6977 us | 1,120.2881 us |    26,751.100 us |     400 B |
        | SortDescending | 10000  |    25,684.424 us |    512.6346 us | 1,394.6605 us |    25,410.750 us |     400 B |
        | SortAscending  | 100000 | 2,601,046.583 us | 11,457.5570 us | 8,945.3069 us | 2,601,168.450 us |     400 B |
        | SortDescending | 100000 | 2,531,635.838 us |  7,526.1727 us | 6,284.6950 us | 2,531,378.800 us |     400 B |
    */
    private int[] _array = null!;
    private Random _random = new Random(42);

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
        SelectionSort.Sort(_array, SelectionSort.SortDirection.Ascending);
    }

    [Benchmark]
    public void SortDescending()
    {
        SelectionSort.Sort(_array, SelectionSort.SortDirection.Descending);
    }
}