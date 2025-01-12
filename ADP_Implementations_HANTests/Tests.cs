namespace ADP_Implementations_HANTests;

using System.Diagnostics;
using System.Text.Json;

using ADP_Implementation_TestData;
using ADP_Implementations.DataStructures.Deque;
using ADP_Implementations.DataStructures.DoubleLinkedList;
using ADP_Implementations.DataStructures.DynamicArray;
using ADP_Implementations.DataStructures.PriorityQueue;
using ADP_Implementations.Algorithms;


public class Tests {
    public static void ReadJsonData(Utilities.Datastructures dataStructure, Utilities.JSonList listToTest) {
        var dynamicArray = new DynamicArray<int>(15);
        var doubleLinkedList = new DoubleLinkedList<int>();
        var stack = new Stack<int>();
        var deque = new Deque<int>();
        var pqueue = new PriorityQueue<int>();

        DataSet dataSet= new DataSet();
        string ListToTest = listToTest.ToString().ToLower();
        var listAsArray = dataSet.GetList(ListToTest);
        
        Console.WriteLine($"RUNNING: '{dataStructure}'");
        Console.WriteLine($"List to read: '{ListToTest}'");

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        foreach(var x in listAsArray) {
            int number;

            bool success = int.TryParse(x, out number);
            if (success)
            {
                switch (dataStructure)
                {
                    case Utilities.Datastructures.DynamicArray:
                        dynamicArray.Add(Int32.Parse(x));
                        break;
                    case Utilities.Datastructures.DoubleLinkedList:
                        doubleLinkedList.AddFirst(Int32.Parse(x));
                        break;
                    case Utilities.Datastructures.Stack:
                        stack.Push(Int32.Parse(x));
                        break;
                    case Utilities.Datastructures.Deque:
                        deque.InsertRight(Int32.Parse(x));
                        break;
                    case Utilities.Datastructures.PriorityQueue:
                        pqueue.Add(Int32.Parse(x));
                        break;
                    default:
                        Console.WriteLine("Structure does not exists!");
                        break;
                }
            }
            else
                Console.WriteLine($"Attempted conversion of '{x ?? "<null>"}' failed.");
        }
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        string elapsedTimeInNanoSeconds = String.Format("{0}", ts.TotalNanoseconds);
        Console.WriteLine("RunTime in nanoseconds:  " + elapsedTimeInNanoSeconds);
    }

    public static void RunBinarySearchWithOrderedList() {
        DataSet dataSet= new DataSet();
        var _array = dataSet.GetListAsInt("lijst_gesorteerd_10");
        int _target = 9;

        Console.WriteLine("RunBinarySearchWithOrderedList");
        Console.WriteLine("Index: {0}", BinarySearchTest(_array, _target, 0, _array.Length - 1));
        Console.WriteLine("Index: {0}", BinarySearchTest_DoWhile(_array, _target));
    }

    public static void RunBinarySearchWithUnorderedList() {
        DataSet dataSet= new DataSet();
        var _array = dataSet.GetListAsInt("lijst_willekeurig_10");
        int _target = 9;

        Console.WriteLine("RunBinarySearchWithUnorderedList");
        Console.WriteLine("Index: {0}", BinarySearchTest(_array, _target, 0, _array.Length - 1));
        Console.WriteLine("Index: {0}", BinarySearchTest_DoWhile(_array, _target));
    }

    public static void RunInsertionSort()
    {
        Console.WriteLine("RUNNING: InsertionSort");
        DataSet dataSet= new DataSet();
        var _randomSorted = dataSet.GetListAsInt("lijst_willekeurig_10000");

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        InsertionSort.Sort(_randomSorted, InsertionSort.SortDirection.Ascending);

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.TotalNanoseconds);

        Console.WriteLine("Sorted list: {0}", string.Join(", ", _randomSorted));            
        Console.WriteLine("RunTime in nanoseconds: " + elapsedTimeInNanoSeconds);
    }

    public static void RunSelectionSort()
    {
        Console.WriteLine("RUNNING: SelectionSortTest");
        DataSet dataSet= new DataSet();
        var _randomSorted = dataSet.GetListAsInt("lijst_willekeurig_10000");

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        SelectionSort.Sort(_randomSorted, SelectionSort.SortDirection.Ascending);

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.TotalNanoseconds);

        Console.WriteLine("Sorted list: {0}", string.Join(", ", _randomSorted));            
        Console.WriteLine("RunTime in nanoseconds: " + elapsedTimeInNanoSeconds);
    }

    public static void RunQuickSort()
    {
        Console.WriteLine("RUNNING: QuickSort");
        DataSet dataSet= new DataSet();
        var _randomSorted = dataSet.GetListAsInt("lijst_willekeurig_10000");

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        QuickSort.Sort(_randomSorted, 0, _randomSorted.Length - 1);

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.TotalNanoseconds);

        Console.WriteLine("Sorted list: {0}", string.Join(", ", _randomSorted));            
        Console.WriteLine("RunTime in nanoseconds: " + elapsedTimeInNanoSeconds);
    }

    public static void RunMergeSortParallel()
    {
        Console.WriteLine("RUNNING: RunMergeSortParallel");
        DataSet dataSet= new DataSet();
        var _randomSorted = dataSet.GetListAsInt("lijst_willekeurig_10000");
        //int[] _randomSorted = { 34, 7, 23, 32, 5, 62, 32, 4 };

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        ParallelMergeSort.SortParallel(_randomSorted, 0, _randomSorted.Length);

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.TotalNanoseconds);

        Console.WriteLine("RunTime in nanoseconds: " + elapsedTimeInNanoSeconds);
    }

    public static void RunMergeSortSeq()
    {
        Console.WriteLine("RUNNING: RunMergeSortSeq");
        DataSet dataSet= new DataSet();
        var _randomSorted = dataSet.GetListAsInt("lijst_willekeurig_10000");
        //int[] _randomSorted = { 34, 7, 23, 32, 5, 62, 32, 4 };

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        ParallelMergeSort.SortSeq(_randomSorted, 0, _randomSorted.Length);

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.TotalNanoseconds);

        Console.WriteLine("RunTime in nanoseconds: " + elapsedTimeInNanoSeconds);
    }

    public static void RunMergeSortSwitch(int treshold = 2)
    {
        Console.WriteLine("RUNNING: RunMergeSortSwitch - {0}", treshold);
        DataSet dataSet= new DataSet();
        var _randomSorted = dataSet.GetListAsInt("lijst_willekeurig_10000");
        //int[] _randomSorted = { 34, 7, 23, 32, 5, 62, 32, 4 };

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        ParallelMergeSort.Sort(_randomSorted, 0, _randomSorted.Length, treshold);

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.TotalNanoseconds);

        Console.WriteLine("RunTime in nanoseconds: " + elapsedTimeInNanoSeconds);
    }

    public static void RunHashTable()
    {
        Console.WriteLine("RUNNING: RunHashTable");
        DataSet dataSet= new DataSet();
        var hashTableData = dataSet.GetHashTableData();

        var data = JsonSerializer.Deserialize<HashingData>(hashTableData);
        HashingData _data = data!;

        Console.WriteLine("Expected Item Counts: " + _data.hashtabelsleutelswaardes.Count);

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        var hashTable = new HashTable<List<int>>(_data.hashtabelsleutelswaardes.Count);
        foreach (var pair in _data.hashtabelsleutelswaardes)
        {
            hashTable.Insert(pair.Key, pair.Value);
        }
        
        foreach (var pair in _data.hashtabelsleutelswaardes)
        {
            var value = hashTable.Get(pair.Key);
            if (value != null) {
                foreach (var item in value)
                {
                    Console.WriteLine("Key {0} - Item {1}", pair.Key, item);
                }
            }
        }

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.TotalNanoseconds);

        Console.WriteLine("RunTime in nanoseconds: " + elapsedTimeInNanoSeconds);
    }

    public static void RunGraphWithEdgeList(int nodeNumber)
    {
        DataSet dataSet= new DataSet();
        string jsonString = dataSet.GetGraphLijnLijstData();
        var data = JsonSerializer.Deserialize<GraphData>(jsonString);

        var graph = BuildGraphFromEdgeList(data.lijnlijst);

        List<Edge> Edges = graph.GetNeighbors("Node " + nodeNumber);
        foreach (Edge e in Edges)
        {
            Console.WriteLine("{0} -> {1}", e.Source.Name, e.Destination.Name);
        }
    }

    public static void RunGraphWithAdjacencyList(int nodeNumber)
    {
        DataSet dataSet= new DataSet();
        string jsonString = dataSet.GetGraphVerbindingsLijstData();
        var data = JsonSerializer.Deserialize<GraphData>(jsonString);

        var graph = BuildGraphFromAdjacencyList(data.verbindingslijst);

        List<Edge> Edges = graph.GetNeighbors("Node " + nodeNumber);
        foreach (Edge e in Edges)
        {
            Console.WriteLine("{0} -> {1}", e.Source.Name, e.Destination.Name);
        }
    }

    public static void RunGraphWithAdjacencyMatrix(int nodeNumber)
    {
        DataSet dataSet= new DataSet();
        string jsonString = dataSet.GetGraphVerbindingsMatrixData();
        var data = JsonSerializer.Deserialize<GraphData>(jsonString);

        var graph = BuildGraphFromAdjacencyMatrix(data.verbindingsmatrix);

        List<Edge> Edges = graph.GetNeighbors("Node " + nodeNumber);
        foreach (Edge e in Edges)
        {
            Console.WriteLine("{0} -> {1}", e.Source.Name, e.Destination.Name);
        }
    }

    public static void RunGraphWithWeightedEdgeList(int nodeNumber)
    {
        DataSet dataSet= new DataSet();
        string jsonString = dataSet.GetGraphLijnLijstGewogenData();
        var data = JsonSerializer.Deserialize<GraphData>(jsonString);

        var graph = BuildGraphFromWeightedEdgeList(data.lijnlijst_gewogen);
        graph.DisplayShortestPath("Node " + nodeNumber);
    }
 
    public static void RunGraphWithWeightedAdjacencyList(int nodeNumber)
    {
        DataSet dataSet= new DataSet();
        string jsonString = dataSet.GetGraphVerbindingsLijstGewogenData();
        var data = JsonSerializer.Deserialize<GraphData>(jsonString);

        var graph = BuildGraphFromWeightedAdjacencyList(data.verbindingslijst_gewogen);
        graph.DisplayShortestPath("Node " + nodeNumber);
    }

    public static void RunGraphWithWeightedAdjacencyMatrix(int nodeNumber)
    {
        DataSet dataSet= new DataSet();
        string jsonString = dataSet.GetGraphVerbindingsMatrixGewogenData();
        var data = JsonSerializer.Deserialize<GraphData>(jsonString);

        var graph = BuildGraphFromWeightedAdjacencyMatrix(data.verbindingsmatrix_gewogen);
        graph.DisplayShortestPath("Node " + nodeNumber);
    }

    public static void RunAVLInsert(Utilities.JSonList listToTest)
    {
        var avlTree = new AVL<int>();
        DataSet dataSet= new DataSet();
        string ListToTest = listToTest.ToString().ToLower();
        var listAsArray = dataSet.GetListAsInt(ListToTest);

        Console.WriteLine($"List to read: '{ListToTest}'");

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        foreach (var item in listAsArray)
        {
            avlTree.Insert(item);
        }

        var _expected = -10033224;
        var minimum = avlTree.FindMin();
        Console.WriteLine("---FindMin");
        Console.WriteLine("Expected: {0}", _expected);
        Console.WriteLine("Reality: {0}", minimum);

        _expected = 1;
        var maximum = avlTree.FindMax();
        Console.WriteLine("---FindMax");
        Console.WriteLine("Expected: {0}", _expected);
        Console.WriteLine("Reality: {0}", maximum);

        Console.WriteLine("--Find");
        var find = avlTree.Find(-10033224);
        Console.WriteLine("Find: {0}", find);

        avlTree.Remove(-10033224);

        Console.WriteLine("---Find after remove");
        var notfound = avlTree.Find(-10033224);
        Console.WriteLine("Found: {0}", notfound);

        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        string elapsedTimeInNanoSeconds = String.Format("{0}", ts.TotalNanoseconds);
        Console.WriteLine("RunTime in nanoseconds:  " + elapsedTimeInNanoSeconds);
    }

    public static void RunAVLInsertInt()
    {
        int N = 10;
        var _avlTree = new AVL<int>();
        var random = new Random();

        for (int i = 0; i < N; i++)
        {
            _avlTree.Insert(random.Next());
        }
    }

    private static Graph BuildGraphFromEdgeList(List<List<int>> edgeList)
    {
        var graph = new Graph();
        foreach (var edgeData in edgeList)
        {
            var fromVertex = new Vertex { Name = "Node " + edgeData[0].ToString() };
            var toVertex = new Vertex { Name = "Node " + edgeData[1].ToString() };
            var edge = new Edge
            {
                Source = fromVertex,
                Destination = toVertex
            };
            graph.AddEdge(edge, true);
        }
        return graph;
    }

    private static Graph BuildGraphFromAdjacencyList(List<List<int>> adjacencyList)
    {
        var graph = new Graph();
        for (int i = 0; i < adjacencyList.Count; i++)
        {
            foreach (var adjacent in adjacencyList[i])
            {
                var fromVertex = new Vertex { Name = "Node " + i.ToString() };
                var toVertex = new Vertex { Name = "Node " + adjacent.ToString() };
                var edge = new Edge
                {
                    Source = fromVertex,
                    Destination = toVertex
                };
                graph.AddEdge(edge, true);
            }
        }
        return graph;
    }

    private static Graph BuildGraphFromAdjacencyMatrix(List<List<int>> adjacencyMatrix)
    {
        var graph = new Graph();
        for (int i = 0; i < adjacencyMatrix.Count; i++)
        {
            for (int j = 0; j < adjacencyMatrix[i].Count; j++)
            {
                if (adjacencyMatrix[i][j] != 0)
                {
                    var fromVertex = new Vertex { Name = "Node " + i.ToString() };
                    var toVertex = new Vertex { Name = "Node " + j.ToString() };
                    var edge = new Edge
                    {
                        Source = fromVertex,
                        Destination = toVertex
                    };
                    graph.AddEdge(edge, true);;
                }
            }
        }
        return graph;
    }

    private static Graph BuildGraphFromWeightedEdgeList(List<List<double>> weightedEdgeList)
    {
        var graph = new Graph();
        foreach (var edgeData in weightedEdgeList)
        {
            var fromVertex = new Vertex { Name = "Node " + edgeData[0].ToString() };
            var toVertex = new Vertex { Name = "Node " + edgeData[1].ToString() };
            var weight = edgeData[2];
            var edge = new Edge
            {
                Source = fromVertex,
                Destination = toVertex,
                Weight = weight
            };
            graph.AddEdge(edge, true);
        }
        return graph;
    }

    private static Graph BuildGraphFromWeightedAdjacencyList(List<List<List<double>>> weightedAdjacencyList)
    {
        var graph = new Graph();
        for (int i = 0; i < weightedAdjacencyList.Count; i++)
        {
            foreach (var adjacent in weightedAdjacencyList[i])
            {
                var fromVertex = new Vertex { Name = "Node " + i.ToString() };
                var toVertex = new Vertex { Name = "Node " + adjacent[0].ToString() };
                var weight = adjacent[1];
                var edge = new Edge
                {
                    Source = fromVertex,
                    Destination = toVertex,
                    Weight = weight
                };
                graph.AddEdge(edge, true);
            }
        }
        return graph;
    }

    private static Graph BuildGraphFromWeightedAdjacencyMatrix(List<List<double>> weightedAdjacencyMatrix)
    {
        var graph = new Graph();
        for (int i = 0; i < weightedAdjacencyMatrix.Count; i++)
        {
            for (int j = 0; j < weightedAdjacencyMatrix[i].Count; j++)
            {
                var weight = weightedAdjacencyMatrix[i][j];
                if (weight != 0)
                {
                    var fromVertex = new Vertex { Name = "Node " + i.ToString() };
                    var toVertex = new Vertex { Name = "Node " + j.ToString() };
                    var edge = new Edge
                    {
                        Source = fromVertex,
                        Destination = toVertex,
                        Weight = weight
                    };
                    graph.AddEdge(edge, true);
                }
            }
        }
        return graph;
    }

    private static int BinarySearchTest(int[] _array, int value, int low, int high)
    {
        Console.WriteLine("RUNNING: binarySearchTest with recursive");
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        int result = BinarySearch.Search(_array, value, low, high);

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.TotalNanoseconds);
        Console.WriteLine("RunTime in nanoseconds: " + elapsedTimeInNanoSeconds);
        return result;
    }

    private static int BinarySearchTest_DoWhile(int[] _array, int value)
    {
        Console.WriteLine("RUNNING: binarySearchTest with do while loop");
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        int result = BinarySearch.Search_DoWhile(_array, value);
        
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.TotalNanoseconds);
        Console.WriteLine("RunTime in nanoseconds: " + elapsedTimeInNanoSeconds);
        return result;
    }

    public static void PizzaTest_DynamicArray() {
        Pizza Hawai4 = new Pizza("Hawai", 4);
        Pizza Hawai8 = new Pizza("Hawai", 8);
        Pizza Pepperoni = new Pizza("Pepperoni", 6);

        Console.WriteLine($"Pizza test with DynamicArray");
        
        var PizzaArray = new DynamicArray<Pizza>(3);
        PizzaArray.Add(Hawai4);
        PizzaArray.Add(Hawai8);
        PizzaArray.Add(Pepperoni);

        Console.WriteLine("Size of array: " + PizzaArray.Size());
        Console.WriteLine("Hawai4: " + PizzaArray.Contains(Hawai4));
        Console.WriteLine("Hawai8: " + PizzaArray.Contains(Hawai8));
        Console.WriteLine("Pepperoni: " + PizzaArray.Contains(Pepperoni));

        Pizza Hawai4b = new Pizza("Hawai", 4);
        PizzaArray.Remove(Hawai4b);
        Console.WriteLine("Size of array: " + PizzaArray.Size());
        Console.WriteLine("Hawai4: " + PizzaArray.Contains(Hawai4));
        Console.WriteLine("Hawai8: " + PizzaArray.Contains(Hawai8));
        Console.WriteLine("Pepperoni: " + PizzaArray.Contains(Pepperoni));       
    }

    public static void PizzaTest_DoubleLinkedList() {
        Pizza Hawai4 = new Pizza("Hawai", 4);
        Pizza Hawai8 = new Pizza("Hawai", 8);
        Pizza Pepperoni = new Pizza("Pepperoni", 6);

        Console.WriteLine($"Pizza test with DoubleLinkedList");
        
        var PizzaList = new DoubleLinkedList<Pizza>();
        PizzaList.AddFirst(Hawai4);
        PizzaList.AddFirst(Hawai8);
        PizzaList.AddFirst(Pepperoni);

        Console.WriteLine("Size of array: " + PizzaList.Size());
        Console.WriteLine("Hawai4: " + PizzaList.Contains(Hawai4));
        Console.WriteLine("Hawai8: " + PizzaList.Contains(Hawai8));
        Console.WriteLine("Pepperoni: " + PizzaList.Contains(Pepperoni));

        Hawai8 = new Pizza("Hawai", 10);
        PizzaList.Remove(Hawai8);
        Console.WriteLine("Size of array: " + PizzaList.Size());
        Console.WriteLine("Hawai4: " + PizzaList.Contains(Hawai4));
        Console.WriteLine("Hawai8: " + PizzaList.Contains(Hawai8));
        Console.WriteLine("Pepperoni: " + PizzaList.Contains(Pepperoni)); 
    }
}

