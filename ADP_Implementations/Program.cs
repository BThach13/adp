namespace ADP_Implementations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        DynamicArray<int> dynamicArray= new DynamicArray<int>(2);
        dynamicArray.Add(25);
        dynamicArray.Add(50);
        dynamicArray.Add(75);
        dynamicArray.Add(100);
        Console.WriteLine("Size of dynamic array = {0}", dynamicArray.Size());
        Console.WriteLine("Value at index {0}: {1}", 0, dynamicArray.Get(0));
        dynamicArray.InsertAt(3, 125);
        dynamicArray.Print();
        Console.WriteLine("Size of dynamic array = {0}", dynamicArray.Size());
        dynamicArray.RemoveAt(1);
        dynamicArray.Print();
        Console.WriteLine("Size of dynamic array = {0}", dynamicArray.Size());
        
    }
}