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

        Assert.True(graph.HasVertex(Arnhem));
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

        Assert.True(graph.HasEdge(Arnhem, Kampen));
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

        Assert.True(graph.HasEdge(Arnhem, Amsterdam));
        Assert.False(graph.HasEdge(Amsterdam, Arnhem));
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

        Assert.True(graph.HasVertex(Arnhem));
        Assert.True(graph.HasVertex(Amsterdam));

        graph.RemoveVertex(Amsterdam);

        Assert.True(graph.HasVertex(Arnhem));
        Assert.False(graph.HasVertex(Amsterdam));
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
        Assert.True(graph.HasEdge(Arnhem, Kampen));

        graph.RemoveEdge(ArnhemKampen);
        Assert.False(graph.HasEdge(Arnhem, Kampen));
    }
}