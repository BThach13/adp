namespace ADP_Implementations;

using ADP_Implementations.DataStructures.Deque;

using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    static void Main(string[] args)
    {
        var deque = new Deque<int>();
        deque.InsertLeft(10);
        deque.InsertLeft(20);
        deque.InsertLeft(30);
        Console.WriteLine(deque.DeleteLeft());
        Console.WriteLine(deque.Size());
    }
}