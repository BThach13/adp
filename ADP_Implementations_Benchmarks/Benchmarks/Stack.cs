using ADP_Implementations.DataStructures.Stack;
using BenchmarkDotNet.Attributes;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class Stack
{
    /*
        | Method        | N     | Mean      | Error    | StdDev   | Median    | Allocated |
        |-------------- |------ |----------:|---------:|---------:|----------:|----------:|
        | PushBenchmark | 10    |  78.79 ns | 21.93 ns | 64.32 ns | 100.00 ns |     400 B |
        | PopBenchmark  | 10    |  85.86 ns | 24.84 ns | 72.86 ns | 100.00 ns |     400 B |
        | PeekBenchmark | 10    |  77.38 ns | 15.67 ns | 42.09 ns | 100.00 ns |     400 B |
        
        | PushBenchmark | 100   |  85.71 ns | 23.09 ns | 67.35 ns | 100.00 ns |     400 B |
        | PopBenchmark  | 100   | 111.58 ns | 25.35 ns | 72.73 ns | 100.00 ns |     400 B |
        | PeekBenchmark | 100   |  79.59 ns | 22.54 ns | 65.74 ns | 100.00 ns |     400 B |
        
        | PushBenchmark | 1000  | 134.34 ns | 27.19 ns | 79.75 ns | 100.00 ns |     400 B |
        | PopBenchmark  | 1000  | 152.04 ns | 24.23 ns | 70.68 ns | 100.00 ns |     400 B |
        | PeekBenchmark | 1000  |  69.23 ns | 18.00 ns | 46.45 ns | 100.00 ns |     400 B |
        
        | PushBenchmark | 10000 |  79.38 ns | 19.23 ns | 55.79 ns | 100.00 ns |     400 B |
        | PopBenchmark  | 10000 | 173.74 ns | 23.15 ns | 67.89 ns | 200.00 ns |     400 B |
        | PeekBenchmark | 10000 |  72.73 ns | 22.09 ns | 64.79 ns |  50.00 ns |     400 B |
    */
    private ADP_Implementations.DataStructures.Stack.Stack<int> _stack = null!;
    [Params(10, 100, 1000, 10000)]
    public int N;

    [IterationSetup]
    public void IterationSetup()
    {
        _stack = new ADP_Implementations.DataStructures.Stack.Stack<int>(15);

        for (int i = 0; i < N; i++)
        {
            _stack.Push(i);
        }
    }

    [Benchmark]
    public void PushBenchmark()
    {
        _stack.Push(99);
    }

    [Benchmark]
    public void PopBenchmark()
    {
        _stack.Pop();
    }

    [Benchmark]
    public void PeekBenchmark()
    {
        _stack.Peek();
    } 
}