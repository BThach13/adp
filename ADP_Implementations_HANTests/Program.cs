﻿namespace ADP_Implementations_HANTests;


class Program
{
    static void Main(string[] args)
    {
        //Tests.readJsonData(Utilities.Datastructures.DynamicArray, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.readJsonData(Utilities.Datastructures.DoubleLinkedList, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.readJsonData(Utilities.Datastructures.Stack, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.readJsonData(Utilities.Datastructures.Deque, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.readJsonData(Utilities.Datastructures.PriorityQueue, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.PizzaTest_DynamicArray();
        //Tests.PizzaTest_DoubleLinkedList();

        int N = 100;
        int[] _array = new int[N];
        for (var i = 0; i < N; i++)
        {
            _array[i] = i*3;
        }

        Console.WriteLine(Tests.binarySearchTest(_array, 750));

        Console.WriteLine(Tests.binarySearchTest_DoWhile(_array, 750));
    }
}