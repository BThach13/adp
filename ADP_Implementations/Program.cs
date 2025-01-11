namespace ADP_Implementations;

using ADP_Implementations.Algorithms;

class Program
{
    static void Main(string[] args)
    {
        /*
        var pqueue = new PriorityQueue<int>();
        pqueue.Add(75);
        pqueue.Add(41);
        pqueue.Add(3);
        pqueue.Add(99);
        pqueue.Add(24);
        Console.WriteLine("Expected: 3 - Actual: {0}", pqueue.Poll());
        Console.WriteLine("");

        var pqueue2 = new PriorityQueue<string>();
        pqueue2.Add("Marco H.");
        pqueue2.Add("Deniz U.");
        pqueue2.Add("Marco B.");
        pqueue2.Add("Daan D.");
        pqueue2.Add("Olaf H.");
        pqueue2.Add("Frank S.");
        pqueue2.Add("Marc S.");
        pqueue2.Add("Leonie S.");
        pqueue2.Add("Boy T.");
        pqueue2.Add("Daniel P.");
        pqueue2.Add("Sjaak H.");
        pqueue2.Add("Wouter F.");
        pqueue2.Add("Jacqueline S.");

        Console.WriteLine("Just peeking for Name: {0}", pqueue2.Peek());

        int i = 0;
        while (i < 13)
        {
            i++;
            Console.WriteLine("Name: {0}", pqueue2.Poll());
        }
        */
    /*
        string[] _array = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        //InsertionSort
        Console.WriteLine("Unsorted list: {0}", string.Join(", ", _array));
        InsertionSort.Sort(_array, InsertionSort.SortDirection.Ascending);
        Console.WriteLine("Ascended sorted list: {0}", string.Join(", ", _array));
        InsertionSort.Sort(_array, InsertionSort.SortDirection.Descending);
        Console.WriteLine("Descended sorted list: {0}", string.Join(", ", _array));

        //SelectionSort
        SelectionSort.Sort(_array, SelectionSort.SortDirection.Ascending);
        Console.WriteLine("Ascended sorted list: {0}", string.Join(", ", _array));
        SelectionSort.Sort(_array, SelectionSort.SortDirection.Descending);
        Console.WriteLine("Descended sorted list: {0}", string.Join(", ", _array));

        //QuickSort
        QuickSort.Sort(_array, 0, _array.Length - 1);
        Console.WriteLine("Sorted list: {0}", string.Join(", ", _array)); 
    */

        //QuickSort
        //string[] _array = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        //int[] _array = { 34, 7, 23, 32, 5, 62, 32, 4 };
        //Console.WriteLine("Unsorted list: {0}", string.Join(", ", _array));
        //ParallelMergeSort.Sort(_array, 0, _array.Length);
        //Console.WriteLine("Sort: {0}", string.Join(", ", _array));
        //ParallelMergeSort.SortSeq(_array, 0, _array.Length);
        //Console.WriteLine("SortSeq: {0}", string.Join(", ", _array));

        //HashTable
        var hashTable = new HashTable<string>(10);
        //hashTable.Display();
        hashTable.Insert("key_00", "User 0");
        Console.WriteLine(hashTable.Get("key_01"));
        //Console.WriteLine(hashTable.Update("key_01", "Kaas"));
        //Console.WriteLine(hashTable.Delete("key_00"));
        /*
        Console.WriteLine("---------------------");
        hashTable.Insert("key_00", "User 0");
        hashTable.Insert("key_01", "User 1");
        hashTable.Display();
        Console.WriteLine("---------------------");
        hashTable.Insert("key_02", "User 2");
        hashTable.Insert("key_03", "User 3");
        hashTable.Update("key_01", "Kaas");
        hashTable.Display();
        Console.WriteLine("---------------------");
        hashTable.Insert("key_04", "User 4");
        hashTable.Insert("key_05", "User 5");
        hashTable.Delete("key_14");
        hashTable.Insert("key_06", "User 6");
        hashTable.Display();
        hashTable.Insert("key_07", "User 7");
        hashTable.Insert("key_08", "User 8");
        hashTable.Insert("key_09", "User 9");
        hashTable.Insert("key_10", "User 10");
        hashTable.Insert("key_11", "User 11");
        hashTable.Insert("key_12", "User 12");
        hashTable.Insert("key_13", "User 13");
        hashTable.Insert("key_14", "User 14");
        
        Console.WriteLine(hashTable.Get("key_14"));
        hashTable.Display();
        */
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
/*
        Console.WriteLine("De stad {0} bestaat: {1}", Kampen.Name, graph.HasVertex("Kampen"));
        Console.WriteLine("");

        Console.WriteLine("De stad {0} bestaat: {1}", Groningen.Name, graph.HasVertex("Groningen"));
        Console.WriteLine("");

        Console.WriteLine("Verbinding tussen {0} en {1} bestaat: {2}", Kampen.Name, Maastricht.Name, graph.HasEdge("Kampen", "Maastricht"));
        Console.WriteLine("");

        Console.WriteLine("Verbinding tussen {0} en {1} bestaat: {2}", Kampen.Name, Zwolle.Name, graph.HasEdge("Kampen", "Zwolle"));
        Console.WriteLine("");

        Console.WriteLine("Buren van Arnhem");
        List<Edge> BurenArnhem = graph.GetNeighbors("Arnhem");
        foreach (Edge e in BurenArnhem)
        {
            Console.WriteLine("{0} -> {1} => Afstand: {2}", e.Source.Name, e.Destination.Name, e.Weight);
        }
        Console.WriteLine("");
        Console.WriteLine("Buren van Kampen");
        List<Edge> BurenKampen = graph.GetNeighbors("Kampen");
        foreach (Edge e in BurenKampen)
        {
            Console.WriteLine("{0} -> {1} => Afstand: {2}", e.Source.Name, e.Destination.Name, e.Weight);
        }
        Console.WriteLine("");
        Console.WriteLine("Buren van Amsterdam");
        List<Edge> BurenAmsterdam = graph.GetNeighbors("Amsterdam");
        foreach (Edge e in BurenAmsterdam)
        {
            Console.WriteLine("{0} -> {1} => Afstand: {2}", e.Source.Name, e.Destination.Name, e.Weight);
        }

        Console.WriteLine("");
        Console.WriteLine("Buren van Maastricht");
        List<Edge> BurenMaastricht = graph.GetNeighbors("Maastricht");
        foreach (Edge e in BurenMaastricht)
        {
            Console.WriteLine("{0} -> {1} => Afstand: {2}", e.Source.Name, e.Destination.Name, e.Weight);
        }
*/
        graph.displayShortestPath("Amsterdam");
        Dictionary<string, double> shortestPaths = graph.Dijkstra("Amsterdam");
        Console.WriteLine(shortestPaths["Maastricht"]);
    }
}