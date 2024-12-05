namespace ADP_Implementations;

using ADP_Implementations.DataStructures.Deque;

using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    static void Main(string[] args)
    {
        var deque = new Deque<int>();

        deque.InsertLeft(1);
        deque.InsertRight(2);
        deque.InsertRight(3);
        Console.WriteLine(deque.DeleteLeft());
        Console.WriteLine(deque.DeleteLeft());
        Console.WriteLine(deque.Size());
    }
}