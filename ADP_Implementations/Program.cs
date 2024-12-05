namespace ADP_Implementations;

using ADP_Implementations.DataStructures.DynamicArray;
using ADP_Implementations.DataStructures.Stack;
using ADP_Implementations.DataStructures.Deque;

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
        //var stack = new Stack<int>();
        var deque = new Deque<int>();

        deque.InsertLeft(1);
        deque.InsertRight(2);


    }
}