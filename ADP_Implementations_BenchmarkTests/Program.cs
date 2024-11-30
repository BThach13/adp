namespace ADP_Implementations_BenchmarkTests;

using ADP_Implementations.DataStructures.DoubleLinkedList;
using ADP_Implementations.DataStructures.DynamicArray;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var doubleLinkedList = new DoubleLinkedList<int>();
        var dynamicArray = new DynamicArray<int>(2);

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
        var lijstenArray = dataSet.GetList("lijst_willekeurig_10000");

        //Fill to remove
        foreach(var x in lijstenArray) {
            int number;

            bool success = int.TryParse(x, out number);
            if (success)
            {
                //dynamicArray.Add(Int32.Parse(x));
                doubleLinkedList.AddFirst(Int32.Parse(x));
                //doubleLinkedList.AddLast(Int32.Parse(x));
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{x ?? "<null>"}' failed.");
            }
        }

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        foreach(var x in lijstenArray) {
            int number;

            bool success = int.TryParse(x, out number);
            if (success)
            {
                //dynamicArray.Remove(Int32.Parse(x));
                doubleLinkedList.Remove(Int32.Parse(x));
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{x ?? "<null>"}' failed.");
            }
        }
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
        
        //dynamicArray.Print();
    }
}