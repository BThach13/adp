namespace ADP_Implementations_HANTests;

using System.Diagnostics;
using ADP_Implementations.DataStructures.Deque;
using ADP_Implementations.DataStructures.DoubleLinkedList;
using ADP_Implementations.DataStructures.DynamicArray;

public class Tests {
    public static void readJsonData(Utilities.Datastructures dataStructure, Utilities.JSonList listToTest) {
        var dynamicArray = new DynamicArray<int>(15);
        var doubleLinkedList = new DoubleLinkedList<int>();
        var stack = new Stack<int>();
        var deque = new Deque<int>();

        DataSet dataSet= new DataSet();
        string ListToTest = listToTest.ToString().ToLower();
        var lijstenArray = dataSet.GetList(ListToTest);
        Console.WriteLine($"List to read: '{ListToTest}'");


        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        foreach(var x in lijstenArray) {
            int number;

            bool success = int.TryParse(x, out number);
            if (success)
            {

                switch (dataStructure)
                {
                    case Utilities.Datastructures.DynamicArray:
                        dynamicArray.Add(Int32.Parse(x));
                        break;
                    case Utilities.Datastructures.DoubleLinkedList:
                        doubleLinkedList.AddFirst(Int32.Parse(x));
                        break;
                    case Utilities.Datastructures.Stack:
                        stack.Push(Int32.Parse(x));
                        break;
                    case Utilities.Datastructures.Deque:
                        deque.InsertRight(Int32.Parse(x));
                        break;
                    default:
                        Console.WriteLine("Structure does not exists!");
                        break;
                }
            }
            else
                Console.WriteLine($"Attempted conversion of '{x ?? "<null>"}' failed.");
        }
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        /*
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
        */

        string elapsedTimeInNanoSeconds = String.Format("{0}",
            ts.Nanoseconds);
        Console.WriteLine("RunTime in nanoseconds " + elapsedTimeInNanoSeconds);
    }

    public static void PizzaTest_DynamicArray() {
        Pizza Hawai4 = new Pizza("Hawai", 4);
        Pizza Hawai8 = new Pizza("Hawai", 8);
        Pizza Pepperoni = new Pizza("Pepperoni", 6);

        Console.WriteLine($"Pizza test with DynamicArray");
        
        var PizzaArray = new DynamicArray<Pizza>(3);
        PizzaArray.Add(Hawai4);
        PizzaArray.Add(Hawai8);
        PizzaArray.Add(Pepperoni);

        Console.WriteLine("Size of array: " + PizzaArray.Size());
        Console.WriteLine("Hawai4: " + PizzaArray.Contains(Hawai4));
        Console.WriteLine("Hawai8: " + PizzaArray.Contains(Hawai8));
        Console.WriteLine("Pepperoni: " + PizzaArray.Contains(Pepperoni));

        Pizza Hawai4b = new Pizza("Hawai", 4);
        PizzaArray.Remove(Hawai4b);
        Console.WriteLine("Size of array: " + PizzaArray.Size());
        Console.WriteLine("Hawai4: " + PizzaArray.Contains(Hawai4));
        Console.WriteLine("Hawai8: " + PizzaArray.Contains(Hawai8));
        Console.WriteLine("Pepperoni: " + PizzaArray.Contains(Pepperoni));       
    }

    public static void PizzaTest_DoubleLinkedList() {
        Pizza Hawai4 = new Pizza("Hawai", 4);
        Pizza Hawai8 = new Pizza("Hawai", 8);
        Pizza Pepperoni = new Pizza("Pepperoni", 6);

        Console.WriteLine($"Pizza test with DoubleLinkedList");
        
        var PizzaList = new DoubleLinkedList<Pizza>();
        PizzaList.AddFirst(Hawai4);
        PizzaList.AddFirst(Hawai8);
        PizzaList.AddFirst(Pepperoni);

        Console.WriteLine("Size of array: " + PizzaList.Size());
        Console.WriteLine("Hawai4: " + PizzaList.Contains(Hawai4));
        Console.WriteLine("Hawai8: " + PizzaList.Contains(Hawai8));
        Console.WriteLine("Pepperoni: " + PizzaList.Contains(Pepperoni));

        Hawai8 = new Pizza("Hawai", 10);
        PizzaList.Remove(Hawai8);
        Console.WriteLine("Size of array: " + PizzaList.Size());
        Console.WriteLine("Hawai4: " + PizzaList.Contains(Hawai4));
        Console.WriteLine("Hawai8: " + PizzaList.Contains(Hawai8));
        Console.WriteLine("Pepperoni: " + PizzaList.Contains(Pepperoni)); 
    }
}

