using ADP_Implementations.DataStructures.DynamicArray;
using BenchmarkDotNet.Attributes;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class DynamicArray
{
    private DynamicArray<int> _list = null!;
    [Params(99, 10, 100, 1_000, 10_000, 100_000)]
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