using BenchmarkDotNet.Attributes;
using ADP_Implementations.Algorithms;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class Dijkstra_Benchmarks
{
    /*
        | Method               | N    | Mean          | Error       | StdDev      | Gen0       | Gen1     | Allocated    |
        |--------------------- |----- |--------------:|------------:|------------:|-----------:|---------:|-------------:|
        | DijkstraShortestPath | 10   |      8.051 us |   0.0581 us |   0.0543 us |     2.8076 |        - |     17.21 KB |
        | DijkstraShortestPath | 100  |    714.761 us |  13.0825 us |  12.2374 us |   256.8359 |   7.8125 |   1575.98 KB |
        | DijkstraShortestPath | 1000 | 71,519.447 us | 695.5631 us | 616.5985 us | 25428.5714 | 428.5714 | 156383.13 KB |
    */
    private Graph _graph;
    private Vertex _startVertex;
    private Random _randomValue = new Random(36);

    [Params(10, 100, 1000)]
    public int N;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _graph = new Graph();

        for (int i = 0; i < N; i++)
        {
             _graph.AddVertex(new Vertex { Name = "Node " + i.ToString()});
        }

        // Add edges - creating a connected graph
        for (int i = 0; i < N - 1; i++)
        {
            var fromVertex = new Vertex { Name = "Node " + i.ToString() };
            var toVertex = new Vertex { Name = "Node " + (i + 1).ToString() };
            var weight = _randomValue.Next(1, 10);

            var edge = new Edge { 
                Source = fromVertex,
                Destination = toVertex,
                Weight = weight 
            };
            _graph.AddEdge(edge);
        }
 
        _startVertex = new Vertex() { Name = "Node " + _randomValue.Next(0, N).ToString() };
    }

    [Benchmark]
    public void DijkstraShortestPath()
    {
        _graph.Dijkstra(_startVertex.Name);
    }
}