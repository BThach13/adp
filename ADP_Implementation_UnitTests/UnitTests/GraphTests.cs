namespace ADP_Implementation_UnitTests;

using ADP_Implementations.Algorithms;

public class GraphTests
{
    private Graph graph= new Graph();
    public GraphTests()
    {
        Graph graph= new Graph();

        Vertex Arnhem = new Vertex();
        Arnhem.Name = "Arnhem";

        Vertex Kampen = new Vertex();
        Kampen.Name = "Kampen";

        Vertex Amsterdam = new Vertex();
        Amsterdam.Name = "Amsterdam";

        Vertex Maastricht = new Vertex();
        Maastricht.Name = "Maastricht";

        Vertex Zwolle = new Vertex();
        Zwolle.Name = "Zwolle";

        Vertex Groningen = new Vertex();
        Groningen.Name = "Groningen";

        graph.AddVertex(Arnhem);
        graph.AddVertex(Kampen);
        graph.AddVertex(Amsterdam);
        graph.AddVertex(Maastricht);
        graph.AddVertex(Zwolle);
    }

    [Fact]
    public void Graph_AddVertex()
    {
        Graph graph= new Graph();

        Vertex Arnhem = new Vertex();
        Arnhem.Name = "Arnhem";

        graph.AddVertex(Arnhem);

        Assert.True(graph.HasVertex("Arnhem"));
    }

    [Fact]
    public void Graph_AddEdge()
    {
        Graph graph= new Graph();

        Vertex Arnhem = new Vertex();
        Arnhem.Name = "Arnhem";
        graph.AddVertex(Arnhem);

        Vertex Kampen = new Vertex();
        Kampen.Name = "Kampen";
        graph.AddVertex(Kampen);

        Edge ArnhemKampen = new Edge();
        ArnhemKampen.Source = Arnhem;
        ArnhemKampen.Destination = Kampen;
        ArnhemKampen.Weight = 84.0;

        graph.AddEdge(ArnhemKampen);

        Assert.True(graph.HasEdge("Arnhem", "Kampen"));
    }

    [Fact]
    public void Graph_AddEdgeDirect()
    {
        Graph graph= new Graph();

        Vertex Arnhem = new Vertex();
        Arnhem.Name = "Arnhem";
        graph.AddVertex(Arnhem);

        Vertex Amsterdam = new Vertex();
        Amsterdam.Name = "Amsterdam";
        graph.AddVertex(Amsterdam);

        Edge ArnhemAmsterdam = new Edge();
        ArnhemAmsterdam.Source = Arnhem;
        ArnhemAmsterdam.Destination = Amsterdam;
        ArnhemAmsterdam.Weight = 109.0;

        graph.AddEdge(ArnhemAmsterdam, true);

        Assert.True(graph.HasEdge("Arnhem", "Amsterdam"));
        Assert.False(graph.HasEdge("Amsterdam", "Arnhem"));
    }

    [Fact]
    public void Graph_RemoveVertex()
    {
        Graph graph= new Graph();

        Vertex Arnhem = new Vertex();
        Arnhem.Name = "Arnhem";
        graph.AddVertex(Arnhem);

        Vertex Amsterdam = new Vertex();
        Amsterdam.Name = "Amsterdam";
        graph.AddVertex(Amsterdam);

        Assert.True(graph.HasVertex("Arnhem"));
        Assert.True(graph.HasVertex("Amsterdam"));

        graph.RemoveVertex(Amsterdam);

        Assert.True(graph.HasVertex("Arnhem"));
        Assert.False(graph.HasVertex("Amsterdam"));
    }

    [Fact]
    public void Graph_RemoveEdge()
    {
        Graph graph= new Graph();

        Vertex Arnhem = new Vertex();
        Arnhem.Name = "Arnhem";
        graph.AddVertex(Arnhem);

        Vertex Kampen = new Vertex();
        Kampen.Name = "Kampen";
        graph.AddVertex(Kampen);

        Edge ArnhemKampen = new Edge();
        ArnhemKampen.Source = Arnhem;
        ArnhemKampen.Destination = Kampen;
        ArnhemKampen.Weight = 84.0;

        graph.AddEdge(ArnhemKampen);
        Assert.True(graph.HasEdge("Arnhem", "Kampen"));

        graph.RemoveEdge(ArnhemKampen);
        Assert.False(graph.HasEdge("Arnhem", "Kampen"));
    }

    [Fact]
    public void Graph_Dijkstra()
    { 
    Graph graph= new Graph();

        Vertex Arnhem = new Vertex();
        Arnhem.Name = "Arnhem";

        Vertex Kampen = new Vertex();
        Kampen.Name = "Kampen";

        Vertex Amsterdam = new Vertex();
        Amsterdam.Name = "Amsterdam";

        Vertex Maastricht = new Vertex();
        Maastricht.Name = "Maastricht";

        Vertex Zwolle = new Vertex();
        Zwolle.Name = "Zwolle";

        Vertex Rotterdam = new Vertex();
        Rotterdam.Name = "Rotterdam";

        Vertex Groningen = new Vertex();
        Groningen.Name = "Groningen";

        graph.AddVertex(Arnhem);
        graph.AddVertex(Kampen);
        graph.AddVertex(Amsterdam);
        graph.AddVertex(Maastricht);
        graph.AddVertex(Zwolle);

        Edge ArnhemAmsterdam = new Edge();
        ArnhemAmsterdam.Source = Arnhem;
        ArnhemAmsterdam.Destination = Amsterdam;
        ArnhemAmsterdam.Weight = 109.0;

        graph.AddEdge(ArnhemAmsterdam);

        Edge ArnhemMaastricht = new Edge();
        ArnhemMaastricht.Source = Arnhem;
        ArnhemMaastricht.Destination = Maastricht;
        ArnhemMaastricht.Weight = 159.0;

        graph.AddEdge(ArnhemMaastricht);

        Edge AmsterdamRotterdam = new Edge();
        AmsterdamRotterdam.Source = Amsterdam;
        AmsterdamRotterdam.Destination = Rotterdam;
        AmsterdamRotterdam.Weight = 78.0;

        graph.AddEdge(AmsterdamRotterdam);

        Edge RotterdamMaastricht = new Edge();
        RotterdamMaastricht.Source = Rotterdam;
        RotterdamMaastricht.Destination = Maastricht;
        RotterdamMaastricht.Weight = 198.0;

        graph.AddEdge(RotterdamMaastricht);

        Edge KampenAmsterdam = new Edge();
        KampenAmsterdam.Source = Kampen;
        KampenAmsterdam.Destination = Amsterdam;
        KampenAmsterdam.Weight = 89.6;

        graph.AddEdge(KampenAmsterdam);

        Edge KampenMaastricht = new Edge();
        KampenMaastricht.Source = Kampen;
        KampenMaastricht.Destination = Maastricht;
        KampenMaastricht.Weight = 239.0;

        graph.AddEdge(KampenMaastricht);

        Dictionary<string, double> shortestPaths = graph.Dijkstra("Amsterdam");

        //Maastricht
        /*
         Amsterdam - 109  -> Arnhem - 159 -> Maastricht = 268
         Amsterdam - 89.6  -> Kampen - 239 -> Maastricht = 328.6
         Amsterdam - 78  -> Rotterdam - 198 -> Maastricht = 276
        */
        int _expected = 268;
        Assert.Equal(_expected, shortestPaths["Maastricht"]);
    }
    
}