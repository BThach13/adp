using BenchmarkDotNet.Attributes;
using ADP_Implementations.DataStructures.DynamicArray;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class DynamicArray_Benchmarks
{
    /* 
        | Method            | N      | Mean        | Error       | StdDev       | Median      | Allocated |
        |------------------ |------- |------------:|------------:|-------------:|------------:|----------:|
        | AddBenchmark      | 10     |    217.2 ns |    31.20 ns |     91.52 ns |    200.0 ns |     400 B |
        | GetBenchmark      | 10     |    224.0 ns |    38.30 ns |    112.92 ns |    200.0 ns |     400 B |
        | SetBenchmark      | 10     |    283.8 ns |    39.78 ns |    116.68 ns |    300.0 ns |     400 B |
        | IndexOfBenchmark  | 10     |    491.9 ns |    54.17 ns |    158.87 ns |    500.0 ns |     400 B |
        | ContainsBenchmark | 10     |    612.6 ns |    49.61 ns |    142.35 ns |    600.0 ns |     400 B |
        | RemoveBenchmark   | 10     |    474.7 ns |    52.31 ns |    153.43 ns |    500.0 ns |     400 B |
        | RemoveAtBenchmark | 10     |    514.9 ns |    44.20 ns |    126.11 ns |    500.0 ns |     400 B |
        
        | AddBenchmark      | 100    |    262.9 ns |    25.74 ns |     71.32 ns |    300.0 ns |     400 B |
        | GetBenchmark      | 100    |    251.5 ns |    23.54 ns |     69.05 ns |    200.0 ns |     400 B |
        | SetBenchmark      | 100    |    289.9 ns |    38.20 ns |    112.03 ns |    300.0 ns |     400 B |
        | IndexOfBenchmark  | 100    |  1,030.0 ns |   142.14 ns |    419.11 ns |  1,100.0 ns |     400 B |
        | ContainsBenchmark | 100    |  1,377.6 ns |   161.43 ns |    470.91 ns |  1,400.0 ns |     400 B |
        | RemoveBenchmark   | 100    |  1,408.6 ns |    61.64 ns |    174.86 ns |  1,400.0 ns |     400 B |
        | RemoveAtBenchmark | 100    |  1,534.1 ns |    74.28 ns |    208.28 ns |  1,500.0 ns |     400 B |
        
        | AddBenchmark      | 1000   |    227.3 ns |    26.60 ns |     78.01 ns |    200.0 ns |     400 B |
        | GetBenchmark      | 1000   |    230.0 ns |    38.11 ns |    112.37 ns |    200.0 ns |     400 B |
        | SetBenchmark      | 1000   |    303.1 ns |    26.35 ns |     76.02 ns |    300.0 ns |     400 B |
        | IndexOfBenchmark  | 1000   |  7,827.0 ns | 1,659.98 ns |  4,894.50 ns |  7,600.0 ns |     400 B |
        | ContainsBenchmark | 1000   |  6,832.0 ns | 1,332.95 ns |  3,930.25 ns |  7,000.0 ns |     400 B |
        | RemoveBenchmark   | 1000   | 12,008.2 ns | 1,028.56 ns |  3,000.37 ns | 12,000.0 ns |     400 B |
        | RemoveAtBenchmark | 1000   | 12,085.7 ns |   971.29 ns |  2,833.31 ns | 11,600.0 ns |     400 B |
        
        | AddBenchmark      | 10000  |    276.8 ns |    24.76 ns |     72.60 ns |    300.0 ns |     400 B |
        | GetBenchmark      | 10000  |    222.2 ns |    28.22 ns |     82.75 ns |    200.0 ns |     400 B |
        | SetBenchmark      | 10000  |    319.4 ns |    25.89 ns |     75.52 ns |    300.0 ns |     400 B |
        | IndexOfBenchmark  | 10000  | 15,072.9 ns | 1,111.80 ns |  3,207.80 ns | 15,400.0 ns |     400 B |
        | ContainsBenchmark | 10000  | 14,309.4 ns | 1,319.78 ns |  3,807.86 ns | 15,100.0 ns |     400 B |
        | RemoveBenchmark   | 10000  | 21,107.1 ns | 1,018.49 ns |  2,987.06 ns | 20,000.0 ns |     400 B |
        | RemoveAtBenchmark | 10000  | 20,147.8 ns |   799.46 ns |  2,228.58 ns | 19,300.0 ns |     400 B |
        
        | AddBenchmark      | 100000 |    328.1 ns |    24.48 ns |     70.64 ns |    300.0 ns |     400 B |
        | GetBenchmark      | 100000 |    278.4 ns |    27.80 ns |     80.66 ns |    300.0 ns |     400 B |
        | SetBenchmark      | 100000 |    485.7 ns |    37.16 ns |    108.41 ns |    500.0 ns |     400 B |
        | IndexOfBenchmark  | 100000 | 39,741.0 ns | 6,255.78 ns | 18,445.31 ns | 37,600.0 ns |     400 B |
        | ContainsBenchmark | 100000 | 38,262.9 ns | 4,674.27 ns | 13,560.90 ns | 37,200.0 ns |     400 B |
        | RemoveBenchmark   | 100000 | 80,776.8 ns | 3,533.69 ns | 10,138.81 ns | 81,900.0 ns |     400 B |
        | RemoveAtBenchmark | 100000 | 80,270.8 ns | 3,683.31 ns | 10,627.19 ns | 79,850.0 ns |     400 B |
    */
    private DynamicArray<int> _list = null!;
    [Params(10, 100, 1000, 10000, 100000)]
    public int N;
    private Random _random = null!;

     [IterationSetup]
    public void IterationSetup()
    {
        _list = new DynamicArray<int>(15);

        for (int i = 0; i < N; i++)
        {
           _list.Add(i);
        }

        _random = new Random();
    }

    [Benchmark]
    public void AddBenchmark()
    {
        _list.Add(_random.Next());
    }

    [Benchmark]
    public void GetBenchmark()
    {
       _list.Get(_random.Next(0, _list.Size()));
    }

    [Benchmark]
    public void SetBenchmark()
    {
        _list.Set(_random.Next(0, _list.Size()), _random.Next());
    }

    [Benchmark]
    public void IndexOfBenchmark()
    {           
        _list.IndexOf(_random.Next(0, _list.Size()));

    }

    [Benchmark]
    public void ContainsBenchmark()
    {
        _list.Contains(_random.Next(0, _list.Size()));
    }

    [Benchmark]
    public void RemoveBenchmark()
    {
        _list.Remove(_random.Next(0, _list.Size()));
    }

    [Benchmark]
    public void RemoveAtBenchmark()
    {
        _list.Remove(_random.Next(0, _list.Size()));      
    }
}