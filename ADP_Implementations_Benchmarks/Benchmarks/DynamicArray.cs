using ADP_Implementations.DataStructures.DynamicArray;
using BenchmarkDotNet.Attributes;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class DynamicArray
{
    /* 
        | Method            | N      | Mean         | Error        | StdDev       | Median       | Allocated |
        |------------------ |------- |-------------:|-------------:|-------------:|-------------:|----------:|
        | AddBenchmark      | 10     |     267.0 ns |     45.49 ns |     134.1 ns |     300.0 ns |     400 B |
        | SetBenchmark      | 10     |   1,308.2 ns |     82.61 ns |     241.0 ns |   1,300.0 ns |     400 B |
        | IndexOfBenchmark  | 10     |   1,050.5 ns |     74.09 ns |     217.3 ns |   1,000.0 ns |     400 B |
        | ContainsBenchmark | 10     |     958.2 ns |     79.06 ns |     230.6 ns |   1,000.0 ns |     400 B |
        | RemoveBenchmark   | 10     |   2,431.6 ns |    157.54 ns |     452.0 ns |   2,400.0 ns |     552 B |
        | RemoveAtBenchmark | 10     |   2,803.1 ns |    231.28 ns |     674.6 ns |   2,700.0 ns |     552 B |
        | AddBenchmark      | 100    |   5,937.5 ns |    270.03 ns |     779.1 ns |   5,800.0 ns |    1696 B |
        | SetBenchmark      | 100    |   5,747.9 ns |    306.51 ns |     884.4 ns |   5,650.0 ns |     400 B |
        | IndexOfBenchmark  | 100    |   5,537.1 ns |    365.98 ns |   1,061.8 ns |   5,500.0 ns |     400 B |
        | ContainsBenchmark | 100    |   4,966.0 ns |    345.41 ns |   1,018.4 ns |   4,950.0 ns |     400 B |
        | RemoveBenchmark   | 100    |   4,592.9 ns |    268.81 ns |     784.1 ns |   4,550.0 ns |     552 B |
        | RemoveAtBenchmark | 100    |   6,907.1 ns |    460.28 ns |   1,349.9 ns |   6,900.0 ns |     552 B |
        | AddBenchmark      | 1000   |  25,753.2 ns |  1,798.75 ns |   5,131.9 ns |  24,250.0 ns |   10728 B |
        | SetBenchmark      | 1000   |  53,154.1 ns |  2,537.08 ns |   7,400.8 ns |  51,650.0 ns |     400 B |
        | IndexOfBenchmark  | 1000   |  41,883.0 ns |  2,874.43 ns |   8,200.9 ns |  39,500.0 ns |     400 B |
        | ContainsBenchmark | 1000   |  43,114.4 ns |  2,780.23 ns |   8,065.9 ns |  42,300.0 ns |     400 B |
        | RemoveBenchmark   | 1000   |  26,324.5 ns |  2,263.18 ns |   6,601.8 ns |  25,750.0 ns |     552 B |
        | RemoveAtBenchmark | 1000   |  45,703.2 ns |  3,018.78 ns |   8,612.8 ns |  43,300.0 ns |     552 B |
        | AddBenchmark      | 10000  |  47,752.5 ns |  2,862.20 ns |   8,394.3 ns |  47,400.0 ns |   82480 B |
        | SetBenchmark      | 10000  | 114,379.1 ns |  4,397.79 ns |  12,331.9 ns | 111,900.0 ns |     400 B |
        | IndexOfBenchmark  | 10000  |  73,400.0 ns |  3,161.28 ns |   9,019.3 ns |  71,950.0 ns |     400 B |
        | ContainsBenchmark | 10000  |  74,972.2 ns |  3,575.67 ns |  10,486.8 ns |  73,650.0 ns |     400 B |
        | RemoveBenchmark   | 10000  |  34,740.6 ns |  2,154.84 ns |   6,217.2 ns |  32,500.0 ns |     552 B |
        | RemoveAtBenchmark | 10000  |  75,038.3 ns |  2,788.71 ns |   7,956.4 ns |  72,950.0 ns |     552 B |
        | AddBenchmark      | 100000 | 512,481.9 ns | 22,116.06 ns |  63,098.4 ns | 506,800.0 ns | 1311376 B |
        | SetBenchmark      | 100000 | 680,897.8 ns | 22,632.35 ns |  62,714.1 ns | 671,100.0 ns |     400 B |
        | IndexOfBenchmark  | 100000 | 378,222.0 ns | 15,560.22 ns |  43,632.5 ns | 374,100.0 ns |     400 B |
        | ContainsBenchmark | 100000 | 452,152.0 ns | 39,882.18 ns | 117,593.5 ns | 395,550.0 ns |     400 B |
        | RemoveBenchmark   | 100000 | 156,261.4 ns |  5,012.11 ns |  13,804.8 ns | 153,100.0 ns |     552 B |
        | RemoveAtBenchmark | 100000 | 425,826.1 ns | 16,018.21 ns |  45,179.7 ns | 417,400.0 ns |     552 B |    
    */
    private DynamicArray<int> _list = null!;
    [Params(10, 100, 1000, 10000, 100000)]
    public int N;
    private Random _random = null!;

     [IterationSetup]
    public void IterationSetup()
    {
        _list = new DynamicArray<int>();
        _random = new Random();
    }

    [Benchmark]
    public void AddBenchmark()
    {
        for (int i = 0; i < N; i++)
        {
           _list.Add(i);
        }
    }

    [Benchmark]
    public void SetBenchmark()
    {
        for (int i = 0; i < N; i++)
        {
           _list.Set(_random.Next(0, _list.Size()), _random.Next());
        }
    }

    [Benchmark]
    public void IndexOfBenchmark()
    {
        for (int i = 0; i < N; i++)
        {
           _list.IndexOf(_random.Next(0, _list.Size()));
        }
    }

    [Benchmark]
    public void ContainsBenchmark()
    {
        for (int i = 0; i < N; i++)
        {
           _list.Contains(_random.Next(0, _list.Size()));
        }
    }

    [Benchmark]
    public void RemoveBenchmark()
    {
        for (int i = 0; i < N; i++)
        {
           _list.Remove(i);
        }
    }

    [Benchmark]
    public void RemoveAtBenchmark()
    {
        for (int i = 0; i < N; i++)
        {
           _list.Remove(_random.Next(0, _list.Size()));
        }        
    }
}