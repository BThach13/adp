namespace ADP_Implementations;

using ADP_Implementations.DataStructures.PriorityQueue;

using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    static void Main(string[] args)
    {
        var pqueue = new PriorityQueue<int>();
        pqueue.Add(75);
        pqueue.Add(41);
        pqueue.Add(3);
        pqueue.Add(99);
        pqueue.Add(24);
        Console.WriteLine("Expected: 3 - Actual: {0}", pqueue.Poll());

        var pqueue2 = new PriorityQueue<string>();
        pqueue2.Add("Roy");
        pqueue2.Add("Esther");
        pqueue2.Add("Marco");
        pqueue2.Add("Edwin");
        pqueue2.Add("Sjaak");
        Console.WriteLine("Expected: Edwin - Actual: {0}", pqueue2.Poll());
    }
}