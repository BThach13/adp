﻿namespace ADP_Implementations;

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
    }
}