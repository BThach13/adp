using ADP_Implementations.DataStructures.DoubleLinkedList;
using BenchmarkDotNet.Attributes;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class DoubleLinkedList
{
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