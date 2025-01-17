﻿namespace ADP_Implementations_HANTests;


class Program
{
    static void Main(string[] args)
    {
        //DATASTRUCTURES
        //Tests.ReadJsonData(Utilities.Datastructures.DynamicArray, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.ReadJsonData(Utilities.Datastructures.DoubleLinkedList, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.ReadJsonData(Utilities.Datastructures.Stack, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.ReadJsonData(Utilities.Datastructures.Deque, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.ReadJsonData(Utilities.Datastructures.PriorityQueue, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.PizzaTest_DynamicArray();
        //Tests.PizzaTest_DoubleLinkedList();

        //ALGORITMES
        //Tests.RunBinarySearchWithOrderedList();
        //Tests.RunBinarySearchWithUnorderedList();

        //Tests.RunInsertionSort();
        //Tests.RunSelectionSort();
        //Tests.RunQuickSort();
        //Tests.RunMergeSortParallel();
        //Tests.RunMergeSortSeq();
        //Tests.RunMergeSortSwitch(1);
        //Tests.RunMergeSortSwitch(2);
        //Tests.RunMergeSortSwitch(4);
        //Tests.RunMergeSortSwitch(8);
        //Tests.RunMergeSortSwitch(10);
        //Tests.RunHashTable();

        //Tests.RunGraphWithEdgeList(1);
        //Tests.RunGraphWithAdjacencyList(1);
        //Tests.RunGraphWithAdjacencyMatrix(1);
        Tests.RunGraphWithWeightedEdgeList(2);
        //Tests.RunGraphWithWeightedAdjacencyList(1);
        //Tests.RunGraphWithWeightedAdjacencyMatrix(1);
        //Tests.RunAVLInsert(Utilities.JSonList.Lijst_aflopend_2);
        //Tests.RunAVLInsertInt();
    }
}