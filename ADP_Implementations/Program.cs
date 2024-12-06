﻿namespace ADP_Implementations;

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
    }
}