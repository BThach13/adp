using BenchmarkDotNet.Attributes;
using ADP_Implementations.DataStructures.PriorityQueue;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class PriorityQueue_Benchmarks
{
    /*
        | Method        | N     | Mean       | Error     | StdDev    | Median     | Allocated |
        |-------------- |------ |-----------:|----------:|----------:|-----------:|----------:|
        | AddBenchmark  | 10    | 2,148.5 ns | 141.62 ns | 415.36 ns | 2,100.0 ns |     440 B |
        | PeekBenchmark | 10    |   125.0 ns |  35.55 ns | 104.81 ns |   100.0 ns |     400 B |
        | PollBenchmark | 10    |   156.4 ns |  30.65 ns |  87.45 ns |   200.0 ns |     400 B |
        
        | AddBenchmark  | 100   | 3,991.9 ns | 178.29 ns | 522.88 ns | 4,000.0 ns |     440 B |
        | PeekBenchmark | 100   |   118.0 ns |  32.11 ns |  94.69 ns |   100.0 ns |     112 B |
        | PollBenchmark | 100   |   243.0 ns |  35.51 ns | 104.69 ns |   300.0 ns |     400 B |
        
        | AddBenchmark  | 1000  | 1,806.6 ns | 209.15 ns | 586.48 ns | 1,700.0 ns |     440 B |
        | PeekBenchmark | 1000  |   262.8 ns |  71.40 ns | 203.72 ns |   200.0 ns |     400 B |
        | PollBenchmark | 1000  |   409.8 ns |  91.69 ns | 266.01 ns |   350.0 ns |     400 B |
        
        | AddBenchmark  | 10000 | 2,006.2 ns | 179.13 ns | 516.84 ns | 1,950.0 ns |     440 B |
        | PeekBenchmark | 10000 |   699.0 ns | 258.51 ns | 745.87 ns |   750.0 ns |     400 B |
        | PollBenchmark | 10000 |   945.8 ns | 254.59 ns | 730.48 ns |   950.0 ns |     400 B |
    */
    private PriorityQueue<int> _pQueue = null!;
    [Params(10, 100, 1000, 10000)]
    public int N;

    [IterationSetup]
    public void IterationSetup()
    {
        _pQueue = new PriorityQueue<int>();

        for (int i = 0; i < N; i++)
        {
            _pQueue.Add(i);
        }
    }

    [Benchmark]
    public void AddBenchmark()
    {
        _pQueue.Add(99);
    }

    [Benchmark]
    public void PeekBenchmark()
    {
        _pQueue.Peek();
    }

    [Benchmark]
    public void PollBenchmark()
    {
        _pQueue.Poll();
    } 
}