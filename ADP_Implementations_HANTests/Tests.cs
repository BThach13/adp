namespace ADP_Implementations_HANTests;

using System.Diagnostics;
using ADP_Implementations.DataStructures.DoubleLinkedList;
using ADP_Implementations.DataStructures.DynamicArray;
public class Tests {

    public static void readJsonData() {
        var dynamicArray = new DynamicArray<int>(2);
        var doubleLinkedList = new DoubleLinkedList<int>();
        /*
            lijst_aflopend_2
            lijst_oplopend_2
            lijst_float_8001
            lijst_gesorteerd_aflopend_3
            lijst_gesorteerd_oplopend_3
            lijst_herhaald_1000
            lijst_leeg_0
            lijst_null_1
            lijst_null_3
            lijst_onsorteerbaar_3
            lijst_oplopend_10000
            lijst_willekeurig_10000
            lijst_willekeurig_3
        */
        DataSet dataSet= new DataSet();
        string ListToTest = "lijst_willekeurig_10000";
        var lijstenArray = dataSet.GetList(ListToTest);
        Console.WriteLine($"List to read: '{ListToTest}'");


        //Fill to remove
        foreach(var x in lijstenArray) {
            int number;

            bool success = int.TryParse(x, out number);
            if (success)
            {
                dynamicArray.Add(Int32.Parse(x));
                //doubleLinkedList.AddFirst(Int32.Parse(x));
                //doubleLinkedList.AddLast(Int32.Parse(x));
            }
            else
                Console.WriteLine($"Attempted conversion of '{x ?? "<null>"}' failed.");
        }

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        foreach(var x in lijstenArray) {
            int number;

            bool success = int.TryParse(x, out number);
            if (success)
            {
                dynamicArray.Remove(Int32.Parse(x));
                //doubleLinkedList.Remove(Int32.Parse(x));
            }
            else
                Console.WriteLine($"Attempted conversion of '{x ?? "<null>"}' failed.");
        }
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
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

        PizzaArray.Remove(Hawai8);
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

        PizzaList.Remove(Hawai8);
        Console.WriteLine("Size of array: " + PizzaList.Size());
        Console.WriteLine("Hawai4: " + PizzaList.Contains(Hawai4));
        Console.WriteLine("Hawai8: " + PizzaList.Contains(Hawai8));
        Console.WriteLine("Pepperoni: " + PizzaList.Contains(Pepperoni)); 
    }
}

