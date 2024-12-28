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
    }
}