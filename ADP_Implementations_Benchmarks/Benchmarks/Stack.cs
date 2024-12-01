using ADP_Implementations.DataStructures.Stack;
using BenchmarkDotNet.Attributes;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class Stack
{
    private ADP_Implementations.DataStructures.Stack.Stack<int> _stack = null!;
    [Params(10, 100, 1000, 10000)]
    public int N;

    [IterationSetup]
    public void IterationSetup()
    {
        _stack = new ADP_Implementations.DataStructures.Stack.Stack<int>();

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