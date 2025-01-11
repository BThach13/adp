namespace ADP_Implementations.Algorithms;

using ADP_Implementations.DataStructures.DoubleLinkedList;

public class Graph
{
    private readonly Dictionary<string, Vertex> _vertices = new Dictionary<string, Vertex>();
    private readonly DoubleLinkedList<Edge> _edges = new DoubleLinkedList<Edge>();

    public void AddVertex(Vertex vertex)
    {
        _vertices.TryAdd(vertex.Name, vertex);
    }

    public void AddEdge(Edge edge, bool isDirected = false)
    {
        _edges.AddFirst(edge);
        if (!_vertices.ContainsKey(edge.Source.Name))
            AddVertex(edge.Source);

        if (!_vertices.ContainsKey(edge.Destination.Name))
            AddVertex(edge.Destination);
        
        if (!isDirected) {
            Edge inDirectEdge = new Edge {  Source = edge.Destination,
                                            Destination = edge.Source,
                                            Weight = edge.Weight };
            _edges.AddFirst(inDirectEdge);
        }
    }

    public void RemoveVertex(Vertex vertex)
    {
        if (_vertices.ContainsKey(vertex.Name))
        {
            _vertices.Remove(vertex.Name);
            foreach (Edge edge in _edges)
            {
                if ((edge.Source.Name == vertex.Name) || (edge.Destination.Name == vertex.Name))
                    _edges.Remove(edge);
            }
        }
    }

    public void RemoveEdge(Edge edge)
    {
        _edges.Remove(edge);
    }

    public bool HasVertex(string vertex)
    {
        foreach (var v in _vertices)
        {
            if (v.Key.ToLower() == vertex.ToLower())
                return true;
        }

        return false;
    }

    public bool HasEdge(string source, string destination)
    {
        foreach (Edge edge in _edges)
        {
            if ((edge.Source.Name.ToLower() == source.ToLower()) && (edge.Destination.Name.ToLower() == destination.ToLower()))
                return true;
        }

        return false;
    }

    public List<Edge> GetNeighbors(string name)
    {
        var neighbors = new List<Edge>();
        foreach (Edge edge in _edges)
        {
            if (edge.Source.Name.ToLower() == name.ToLower())
            {
                neighbors.Add(edge);
            }
        }

        return neighbors;
    }

    public Dictionary<string, double> Dijkstra(string startName)
    {
        var distances = _vertices.ToDictionary(v => v.Key, v => double.MaxValue);
        var priorityQueue = new SortedSet<(double Distance, string Vertex)>();
        var visited = new HashSet<string>();

        distances[startName] = 0;
        priorityQueue.Add((0, startName));

        while (priorityQueue.Count > 0)
        {
            double currentDistance = priorityQueue.Min.Distance;
            string currentVertex = priorityQueue.Min.Vertex;
            priorityQueue.Remove(priorityQueue.Min);

            if (visited.Contains(currentVertex))
                continue;
            visited.Add(currentVertex);

            foreach (Edge edge in GetNeighbors(currentVertex))
            {
                string neighbor = edge.Destination.Name;
                if (visited.Contains(neighbor))
                    continue;

                double newDistance = currentDistance + edge.Weight;
                if (newDistance < distances[neighbor])
                {
                    if (distances[neighbor] != double.MaxValue)
                    {
                        priorityQueue.Remove((distances[neighbor], neighbor));
                    }
                    distances[neighbor] = newDistance;
                    priorityQueue.Add((newDistance, neighbor));
                }
            }
        }

        return distances;
    }

    public void displayShortestPath(string source)
    {
        Dictionary<string, double> shortestPaths = Dijkstra(source);

        Console.WriteLine("Kortste afstanden van {0}:", source);
        foreach (var path in shortestPaths)
        {
            string vertex = path.Key;
            double distance = path.Value;

            if (distance == double.MaxValue)
                Console.WriteLine($"- {vertex}: Onbereikbaar");
            else
                Console.WriteLine($"- {vertex}: {distance}");
        }
    }
}