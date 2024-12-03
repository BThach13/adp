using ADP_Implementations.DataStructures.DoubleLinkedList;
using BenchmarkDotNet.Attributes;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class DoubleLinkedList
{
    /*
        | Method               | N      | Mean          | Error        | StdDev       | Median       | Allocated |
        |--------------------- |------- |--------------:|-------------:|-------------:|-------------:|----------:|
        | AddFirstBenchmark    | 10     |   1,642.55 ns |    103.25 ns |    294.57 ns |   1,600.0 ns |     440 B |
        | AddLastBenchmark     | 10     |   1,588.78 ns |    143.42 ns |    418.36 ns |   1,600.0 ns |     440 B |
        | SetBenchmark         | 10     |   2,191.84 ns |    155.25 ns |    452.87 ns |   2,100.0 ns |     480 B |
        | RemoveFirstBenchmark | 10     |     369.79 ns |     47.74 ns |    137.74 ns |     400.0 ns |     400 B |
        | RemoveLastBenchmark  | 10     |     301.01 ns |     39.72 ns |    116.49 ns |     300.0 ns |     400 B |
        | RemoveAtBenchmark    | 10     |     656.12 ns |     64.76 ns |    188.90 ns |     650.0 ns |     400 B |
        | GetFirstBenchmark    | 10     |      77.66 ns |     24.73 ns |     70.56 ns |     100.0 ns |     400 B |
        | GetLastBenchmark     | 10     |     118.04 ns |     27.94 ns |     81.07 ns |     150.0 ns |     400 B |
        | GetBenchmark         | 10     |     529.29 ns |     57.48 ns |    168.58 ns |     500.0 ns |     400 B |
        | ContainsBenchmark    | 10     |   1,000.00 ns |     65.30 ns |    187.37 ns |   1,000.0 ns |     400 B |
        | AddFirstBenchmark    | 100    |   1,490.62 ns |    131.15 ns |    378.38 ns |   1,400.0 ns |     440 B |
        | AddLastBenchmark     | 100    |   1,516.49 ns |     95.79 ns |    277.89 ns |   1,500.0 ns |     440 B |
        | SetBenchmark         | 100    |   3,505.26 ns |    168.56 ns |    483.64 ns |   3,500.0 ns |     440 B |
        | RemoveFirstBenchmark | 100    |     271.65 ns |     42.86 ns |    124.35 ns |     250.0 ns |     400 B |
        | RemoveLastBenchmark  | 100    |     207.00 ns |     39.53 ns |    116.56 ns |     200.0 ns |     400 B |
        | RemoveAtBenchmark    | 100    |   2,256.70 ns |    114.63 ns |    332.57 ns |   2,200.0 ns |     400 B |
        | GetFirstBenchmark    | 100    |     161.05 ns |     28.89 ns |     82.89 ns |     200.0 ns |     400 B |
        | GetLastBenchmark     | 100    |     157.00 ns |     30.77 ns |     90.74 ns |     150.0 ns |     400 B |
        | GetBenchmark         | 100    |   1,182.00 ns |    187.96 ns |    554.21 ns |   1,100.0 ns |     400 B |
        | ContainsBenchmark    | 100    |   3,116.49 ns |    189.88 ns |    550.89 ns |   3,100.0 ns |     400 B |
        | AddFirstBenchmark    | 1000   |   1,453.68 ns |    114.22 ns |    327.73 ns |   1,400.0 ns |     440 B |
        | AddLastBenchmark     | 1000   |   1,458.76 ns |    124.75 ns |    361.93 ns |   1,500.0 ns |     440 B |
        | SetBenchmark         | 1000   |  11,841.11 ns |    756.06 ns |  2,107.59 ns |  11,850.0 ns |     440 B |
        | RemoveFirstBenchmark | 1000   |     328.57 ns |     40.59 ns |    113.81 ns |     300.0 ns |     400 B |
        | RemoveLastBenchmark  | 1000   |     318.28 ns |     32.85 ns |     93.19 ns |     300.0 ns |     400 B |
        | RemoveAtBenchmark    | 1000   |  11,165.93 ns |    726.77 ns |  2,037.93 ns |  10,700.0 ns |     400 B |
        | GetFirstBenchmark    | 1000   |     179.38 ns |     38.52 ns |    111.75 ns |     200.0 ns |     400 B |
        | GetLastBenchmark     | 1000   |      74.19 ns |     24.32 ns |     69.00 ns |     100.0 ns |     400 B |
        | GetBenchmark         | 1000   |   5,454.17 ns |  1,206.76 ns |  3,481.77 ns |   5,000.0 ns |     400 B |
        | ContainsBenchmark    | 1000   |  25,772.11 ns |  1,476.13 ns |  4,235.29 ns |  25,150.0 ns |     400 B |
        | AddFirstBenchmark    | 10000  |   3,788.78 ns |    281.31 ns |    820.60 ns |   4,100.0 ns |     440 B |
        | AddLastBenchmark     | 10000  |   1,690.53 ns |    159.16 ns |    456.65 ns |   1,500.0 ns |     440 B |
        | SetBenchmark         | 10000  |  33,589.25 ns |  1,007.61 ns |  2,858.41 ns |  33,200.0 ns |     440 B |
        | RemoveFirstBenchmark | 10000  |     384.09 ns |     58.75 ns |    161.80 ns |     300.0 ns |     400 B |
        | RemoveLastBenchmark  | 10000  |     436.17 ns |     87.62 ns |    249.99 ns |     350.0 ns |     112 B |
        | RemoveAtBenchmark    | 10000  |  31,600.00 ns |  1,112.62 ns |  3,174.36 ns |  31,550.0 ns |     400 B |
        | GetFirstBenchmark    | 10000  |     530.61 ns |    132.67 ns |    387.01 ns |     500.0 ns |     400 B |
        | GetLastBenchmark     | 10000  |     278.87 ns |     76.50 ns |    221.95 ns |     250.0 ns |     400 B |
        | GetBenchmark         | 10000  |  18,513.13 ns |  2,438.73 ns |  7,152.36 ns |  18,100.0 ns |     400 B |
        | ContainsBenchmark    | 10000  |  41,135.71 ns |  1,404.64 ns |  4,097.40 ns |  41,000.0 ns |     112 B |
        | AddFirstBenchmark    | 100000 |   4,305.32 ns |    513.11 ns |  1,463.93 ns |   4,200.0 ns |     152 B |
        | AddLastBenchmark     | 100000 |   4,291.49 ns |    463.53 ns |  1,322.48 ns |   4,200.0 ns |     440 B |
        | SetBenchmark         | 100000 | 262,798.96 ns | 27,172.21 ns | 78,398.04 ns | 234,000.0 ns |     440 B |
        | RemoveFirstBenchmark | 100000 |   1,731.18 ns |    304.35 ns |    863.38 ns |   1,600.0 ns |     400 B |
        | RemoveLastBenchmark  | 100000 |   1,491.76 ns |    229.83 ns |    644.47 ns |   1,450.0 ns |     400 B |
        | RemoveAtBenchmark    | 100000 | 261,115.98 ns | 25,696.01 ns | 74,548.78 ns | 237,350.0 ns |     400 B |
        | GetFirstBenchmark    | 100000 |   1,315.62 ns |    238.08 ns |    686.92 ns |   1,200.0 ns |     400 B |
        | GetLastBenchmark     | 100000 |   1,183.16 ns |    175.05 ns |    502.26 ns |   1,100.0 ns |     400 B |
        | GetBenchmark         | 100000 | 154,383.33 ns | 25,445.48 ns | 73,416.05 ns | 154,600.0 ns |     400 B |
        | ContainsBenchmark    | 100000 | 232,820.69 ns | 19,884.37 ns | 54,433.14 ns | 211,500.0 ns |     400 B | 
    */
    private DoubleLinkedList<int> _list = null!;
    [Params(10, 100, 1000, 10000, 100000)]
    public int N;
    private Random _randomIndex = null!;
    private Random _randomValue = null!;

    [IterationSetup]
    public void IterationSetup()
    {
        _list = new DoubleLinkedList<int>();

        for (int i = 0; i < N; i++)
        {
           _list.AddLast(i);
        }

        _randomIndex = new Random();
        _randomValue = new Random();
    }

    [Benchmark]
    public void AddFirstBenchmark()
    {
        _list.AddFirst(_randomIndex.Next(0, _list.Size()));
    }

    [Benchmark]
    public void AddLastBenchmark()
    {
        _list.AddLast(_randomIndex.Next(0, _list.Size()));
    }

    [Benchmark]
    public void SetBenchmark()
    {
        _list.Set(_randomIndex.Next(0, _list.Size()), _randomValue.Next());
    }

    [Benchmark]
    public void RemoveFirstBenchmark()
    {
        _list.RemoveFirst();
    }

    [Benchmark]
    public void RemoveLastBenchmark()
    {
        _list.RemoveLast();
    }

    [Benchmark]
    public void RemoveAtBenchmark()
    {
        _list.RemoveAt(_randomIndex.Next(0, _list.Size()));
    }

    [Benchmark]
    public void GetFirstBenchmark()
    {
        _list.GetFirst();
    }

    [Benchmark]
    public void GetLastBenchmark()
    {
        _list.GetLast();
    }

    [Benchmark]
    public void GetBenchmark()
    {
         _list.Get(_randomIndex.Next(0, _list.Size()));
    }

    [Benchmark]
    public void ContainsBenchmark()
    {
        _list.Contains(_randomValue.Next());
    }
}