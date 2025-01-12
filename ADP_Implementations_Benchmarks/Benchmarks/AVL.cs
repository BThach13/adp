using BenchmarkDotNet.Attributes;
using ADP_Implementations.Algorithms;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class AVL_Benchmarks
{
    /*
        | Method  | N     | Mean       | Error     | StdDev      | Median     | Allocated |
        |-------- |------ |-----------:|----------:|------------:|-----------:|----------:|
        | Insert  | 100   | 3,343.8 ns | 245.07 ns |   707.08 ns | 3,300.0 ns |     512 B |
        | Remove  | 100   |   888.7 ns |  49.47 ns |   143.52 ns |   900.0 ns |     400 B |
        | FindMin | 100   |   206.0 ns |  25.88 ns |    76.30 ns |   200.0 ns |     400 B |
        | FindMax | 100   |   174.5 ns |  29.25 ns |    85.33 ns |   200.0 ns |     400 B |
        | Find    | 100   |   389.9 ns |  40.61 ns |   119.09 ns |   400.0 ns |     400 B |

        | Insert  | 1000  | 3,932.7 ns | 357.17 ns | 1,041.88 ns | 4,050.0 ns |     512 B |
        | Remove  | 1000  |   923.4 ns |  46.38 ns |   132.33 ns |   900.0 ns |     400 B |
        | FindMin | 1000  |   195.8 ns |  42.81 ns |   122.84 ns |   200.0 ns |     400 B |
        | FindMax | 1000  |   269.1 ns |  25.71 ns |    73.36 ns |   300.0 ns |     400 B |
        | Find    | 1000  |   419.4 ns |  32.98 ns |    93.55 ns |   400.0 ns |     400 B |

        | Insert  | 10000 | 5,594.7 ns | 752.17 ns | 2,145.98 ns | 5,400.0 ns |     224 B |
        | Remove  | 10000 | 1,011.3 ns | 209.83 ns |   608.77 ns |   700.0 ns |     400 B |
        | FindMin | 10000 |   597.9 ns |  96.43 ns |   275.13 ns |   500.0 ns |     400 B |
        | FindMax | 10000 |   572.7 ns |  85.05 ns |   234.26 ns |   500.0 ns |     400 B |
        | Find    | 10000 |   546.5 ns |  72.74 ns |   197.90 ns |   500.0 ns |     400 B |
    */
    private AVL<int> _avlTree;
    private int _itemToFind;
    private int _itemToRemove;

    [Params(100, 1000, 10000)]
    public int N;

    [IterationSetup]
    public void IterationSetup()
    {
        _avlTree = new AVL<int>();
        var random = new Random();

        for (int i = 0; i < N; i++)
        {
            _avlTree.Insert(random.Next());
        }

        _itemToFind = random.Next();
        _itemToRemove = random.Next();
    }

    [Benchmark]
    public void Insert()
    {
        _avlTree.Insert(new Random().Next());
    }

    [Benchmark]
    public void Remove()
    {
        _avlTree.Remove(_itemToRemove);
    }

    [Benchmark]
    public void FindMin()
    {
        _avlTree.FindMin();
    }

    [Benchmark]
    public void FindMax()
    {
        _avlTree.FindMax();
    }

    [Benchmark]
    public void Find()
    {
        _avlTree.Find(_itemToFind);
    }
}