namespace ADP_Implementations;
using ADP_Implementations.DataStructures.DoubleLinkedList;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var doubleLinkedList = new DoubleLinkedList<int>();
        doubleLinkedList.AddFirst(30);
        doubleLinkedList.AddLast(50);
        doubleLinkedList.InsertAt(1, 40);

        
    }
}