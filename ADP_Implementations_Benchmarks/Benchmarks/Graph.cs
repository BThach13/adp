using BenchmarkDotNet.Attributes;
using ADP_Implementations.Algorithms;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class Graph_Benchmarks
{
    /*
        | Method         | N     | Mean               | Error            | StdDev          | Median             | Gen0        | Gen1      | Allocated    |
        |--------------- |------ |-------------------:|-----------------:|----------------:|-------------------:|------------:|----------:|-------------:|
        | AddVertices    | 10    |         8,437.8 ns |        601.62 ns |      1,755.0 ns |         7,900.0 ns |           - |         - |       3512 B |
        | AddEdges       | 10    |         8,346.3 ns |        472.38 ns |      1,355.4 ns |         7,900.0 ns |           - |         - |       5072 B |
        | RemoveVertices | 10    |           775.8 ns |         48.49 ns |        142.2 ns |           800.0 ns |           - |         - |        400 B |
        | RemoveEdges    | 10    |           942.4 ns |         58.27 ns |        170.9 ns |           900.0 ns |           - |         - |        400 B |

        | AddVertices    | 100   |       274,221.8 ns |      6,548.05 ns |     17,925.2 ns |       267,100.0 ns |           - |         - |     212512 B |
        | AddEdges       | 100   |       511,170.8 ns |     15,183.34 ns |     43,807.4 ns |       497,400.0 ns |           - |         - |     408992 B |
        | RemoveVertices | 100   |         2,884.8 ns |        186.91 ns |        548.2 ns |         2,600.0 ns |           - |         - |        400 B |
        | RemoveEdges    | 100   |         2,500.0 ns |        177.82 ns |        518.7 ns |         2,200.0 ns |           - |         - |        400 B |

        | AddVertices    | 1000  |    12,794,535.2 ns |    614,405.70 ns |  1,692,251.8 ns |    12,245,550.0 ns |   3000.0000 |         - |   20122536 B |
        | AddEdges       | 1000  |    19,013,507.7 ns |    376,744.10 ns |    778,041.9 ns |    18,850,450.0 ns |   6000.0000 |         - |   40088192 B |
        | RemoveVertices | 1000  |        18,478.9 ns |      1,221.03 ns |      3,503.4 ns |        17,400.0 ns |           - |         - |        400 B |
        | RemoveEdges    | 1000  |        23,566.3 ns |        974.40 ns |      2,748.3 ns |        22,900.0 ns |           - |         - |        400 B |

        | AddVertices    | 10000 | 1,186,254,635.7 ns |  7,732,556.39 ns |  6,854,709.8 ns | 1,187,136,650.0 ns | 318000.0000 |         - | 2001142328 B |
        | AddEdges       | 10000 | 1,818,251,964.3 ns | 18,394,535.99 ns | 16,306,277.0 ns | 1,822,935,350.0 ns | 637000.0000 | 1000.0000 | 4000880192 B |
        | RemoveVertices | 10000 |        90,282.7 ns |     10,403.52 ns |     30,347.6 ns |        95,950.0 ns |           - |         - |        400 B |
        | RemoveEdges    | 10000 |       129,966.7 ns |      2,588.80 ns |      3,874.8 ns |       130,250.0 ns |           - |         - |        400 B |
    */
    private Graph _graph;
    private List<Vertex> _verticesToAdd;
    private List<Edge> _edgesToAdd;

    [Params(10, 100, 1000, 10000)]
    public int N;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _verticesToAdd = new List<Vertex>();
        _edgesToAdd = new List<Edge>();

        for (int i = 0; i < N; i++)
        {
            _verticesToAdd.Add(new Vertex { Name = "Node " + i.ToString() });

            if (i > 0)
            {
                var fromVertex = new Vertex { Name = "Node " + (i - 1).ToString() };
                var toVertex = new Vertex { Name = "Node " + i.ToString() };

                var edge = new Edge() { Source = fromVertex, Destination = toVertex };
                _edgesToAdd.Add(edge);
            }
        }
    }

    [IterationSetup]
    public void IterationSetup()
    {
        _graph = new Graph();
    }

    [Benchmark]
    public void AddVertices()
    {
        foreach (var vertex in _verticesToAdd)
        {
            _graph.AddVertex(vertex);
        }
    }

    [Benchmark]
    public void AddEdges()
    {
        foreach (var edge in _edgesToAdd)
        {
            _graph.AddEdge(edge);
        }
    }

    [Benchmark]
    public void RemoveVertices()
    {
        foreach (var vertex in _verticesToAdd)
        {
            _graph.RemoveVertex(vertex);
        }
    }

    [Benchmark]
    public void RemoveEdges()
    {
        foreach (var edge in _edgesToAdd)
        {
            _graph.RemoveEdge(edge);
        }
    }
}