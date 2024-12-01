using BenchmarkDotNet.Running;
using ADP_Implementations_Benchmarks;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<DynamicArray>();
        //BenchmarkRunner.Run<DoubleLinkedList>();
        //BenchmarkRunner.Run<Stack>();
    }
}
