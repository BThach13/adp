using BenchmarkDotNet.Attributes;
using ADP_Implementations.Algorithms.InsertionSort;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class InsertionSort_Benchmarks
{
    /*
        | Method         | N      | Mean             | Error          | StdDev         | Median           | Allocated |
        |--------------- |------- |-----------------:|---------------:|---------------:|-----------------:|----------:|
        | SortAscending  | 10     |         1.106 us |      0.0718 us |      0.2117 us |         1.100 us |     400 B |
        | SortDescending | 10     |         1.133 us |      0.0723 us |      0.2132 us |         1.100 us |     400 B |
        | SortAscending  | 100    |        21.067 us |      1.0715 us |      3.0572 us |        20.350 us |      64 B |
        | SortDescending | 100    |        18.258 us |      0.7114 us |      2.0411 us |        17.500 us |     400 B |
        | SortAscending  | 1000   |       212.198 us |      4.2134 us |      8.5112 us |       210.500 us |     400 B |
        | SortDescending | 1000   |       206.457 us |      4.1263 us |      8.2406 us |       205.900 us |     400 B |
        | SortAscending  | 10000  |    17,870.237 us |    352.0914 us |    652.6241 us |    17,931.900 us |     400 B |
        | SortDescending | 10000  |    17,878.980 us |    340.4573 us |    647.7555 us |    17,859.700 us |     400 B |
        | SortAscending  | 100000 | 1,760,499.993 us | 10,764.9885 us |  9,542.8819 us | 1,759,105.300 us |     400 B |
        | SortDescending | 100000 | 1,753,830.586 us | 24,709.6582 us | 21,904.4684 us | 1,747,588.750 us |     400 B |
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
        InsertionSort.Sort(_array, InsertionSort.SortDirection.Ascending);
    }

    [Benchmark]
    public void SortDescending()
    {
        InsertionSort.Sort(_array, InsertionSort.SortDirection.Descending);
    }
}