using BenchmarkDotNet.Running;
using ADP_Implementations_Benchmarks;

public class Program
{
    public static void Main(string[] args)
    {
        //BenchmarkRunner.Run<DynamicArray_Benchmarks>();
        //BenchmarkRunner.Run<DoubleLinkedList_Benchmarks>();
        //BenchmarkRunner.Run<Stack_Benchmarks>();
        //BenchmarkRunner.Run<Deque_Benchmarks>();
        //BenchmarkRunner.Run<PriorityQueue_Benchmarks>();
        //BenchmarkRunner.Run<BinarySearch_Benchmarks>();
        BenchmarkRunner.Run<InsertionSort_Benchmarks>();
        

        // Run commands
        // cd .\ADP_Implementations_Benchmarks\
        // dotnet run -c Release

    }
}
