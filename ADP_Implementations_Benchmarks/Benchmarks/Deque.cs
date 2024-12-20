using BenchmarkDotNet.Attributes;
using ADP_Implementations.DataStructures.Deque;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class Deque_Benchmarks
{
    /*
        | Method               | N      | Mean       | Error     | StdDev      | Median     | Allocated |
        |--------------------- |------- |-----------:|----------:|------------:|-----------:|----------:|
        | InsertRightBenchmark | 10     |   959.2 ns |  65.64 ns |   191.49 ns | 1,000.0 ns |     440 B |
        | InsertLeftBenchmark  | 10     |   885.3 ns |  64.10 ns |   183.91 ns |   900.0 ns |     440 B |
        | DeleteRightBenchmark | 10     |   125.8 ns |  29.55 ns |    85.73 ns |   100.0 ns |     400 B |
        | DeleteLeftBenchmark  | 10     |   170.8 ns |  27.51 ns |    79.36 ns |   200.0 ns |     400 B |
        
        | InsertRightBenchmark | 100    |   842.1 ns |  63.41 ns |   181.94 ns |   800.0 ns |     440 B |
        | InsertLeftBenchmark  | 100    |   935.0 ns |  59.31 ns |   174.87 ns |   900.0 ns |     440 B |
        | DeleteRightBenchmark | 100    |   165.4 ns |  21.77 ns |    57.36 ns |   200.0 ns |     400 B |
        | DeleteLeftBenchmark  | 100    |   190.9 ns |  25.82 ns |    75.72 ns |   200.0 ns |     400 B |
        
        | InsertRightBenchmark | 1000   |   984.5 ns |  58.52 ns |   169.77 ns | 1,000.0 ns |     440 B |
        | InsertLeftBenchmark  | 1000   |   948.5 ns |  49.04 ns |   143.83 ns | 1,000.0 ns |     440 B |
        | DeleteRightBenchmark | 1000   |   167.1 ns |  19.66 ns |    50.04 ns |   200.0 ns |     400 B |
        | DeleteLeftBenchmark  | 1000   |   185.9 ns |  24.84 ns |    72.86 ns |   200.0 ns |     400 B |
        
        | InsertRightBenchmark | 10000  | 1,283.3 ns |  66.35 ns |   178.23 ns | 1,300.0 ns |     440 B |
        | InsertLeftBenchmark  | 10000  | 1,901.1 ns | 163.66 ns |   461.60 ns | 1,800.0 ns |     152 B |
        | DeleteRightBenchmark | 10000  |   175.3 ns |  16.93 ns |    43.39 ns |   200.0 ns |     400 B |
        | DeleteLeftBenchmark  | 10000  |   244.1 ns |  24.08 ns |    68.31 ns |   200.0 ns |     400 B |
        
        | InsertRightBenchmark | 100000 | 4,496.0 ns | 756.16 ns | 2,229.55 ns | 4,050.0 ns |     440 B |
        | InsertLeftBenchmark  | 100000 | 3,092.5 ns | 353.43 ns | 1,002.63 ns | 2,800.0 ns |     440 B |
        | DeleteRightBenchmark | 100000 | 1,300.0 ns | 173.60 ns |   498.08 ns | 1,300.0 ns |     400 B |
        | DeleteLeftBenchmark  | 100000 | 1,217.7 ns | 148.93 ns |   429.69 ns | 1,150.0 ns |     400 B |
    */
    private Deque<int> _list = null!;
    [Params(10, 100, 1000, 10000, 100000)]
    public int N;
    private Random _randomValue = null!;

    [IterationSetup]
    public void IterationSetup()
    {
        _list = new Deque<int>();

        for (int i = 0; i < N; i++)
        {
           _list.InsertRight(i);
        }

        _randomValue = new Random();
    }

    [Benchmark]
    public void InsertRightBenchmark()
    {
        _list.InsertRight(_randomValue.Next(0, _list.Size()));
    }

    [Benchmark]
    public void InsertLeftBenchmark()
    {
        _list.InsertLeft(_randomValue.Next(0, _list.Size()));
    }

    [Benchmark]
    public void DeleteRightBenchmark()
    {
        _list.DeleteRight();
    }

    [Benchmark]
    public void DeleteLeftBenchmark()
    {
        _list.DeleteLeft();
    }
}