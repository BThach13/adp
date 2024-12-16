using BenchmarkDotNet.Running;
using ADP_Implementations_Benchmarks;

public class Program
{
    public static void Main(string[] args)
    {
        //BenchmarkRunner.Run<DynamicArray>();
        //BenchmarkRunner.Run<DoubleLinkedList>();
        //BenchmarkRunner.Run<Stack>();
        BenchmarkRunner.Run<Deque>();
        //BenchmarkRunner.Run<PriorityQueue>();
        //BenchmarkRunner.Run<BinarySearch>();

        // Run commands
        // cd .\ADP_Implementations_Benchmarks\
        // dotnet run -c Release

    }
}
