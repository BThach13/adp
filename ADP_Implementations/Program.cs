namespace ADP_Implementations;

using ADP_Implementations.DataStructures.DynamicArray;
using ADP_Implementations.DataStructures.Stack;

using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    static void Main(string[] args)
    {
        //var doubleLinkedList = new DoubleLinkedList<int>();
        //doubleLinkedList.AddFirst(30);
        //doubleLinkedList.AddLast(50);
        //doubleLinkedList.InsertAt(1, 40);
        var stack = new Stack<int>();

        Console.WriteLine(stack.Size());
        stack.Push(30);
        stack.Push(25);
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());
    }
}