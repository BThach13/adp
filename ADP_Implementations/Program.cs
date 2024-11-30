namespace ADP_Implementations;

using ADP_Implementations.DataStructures.DynamicArray;
using ADP_Implementations.DataStructures.DoubleLinkedList;

using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //var doubleLinkedList = new DoubleLinkedList<int>();
        //doubleLinkedList.AddFirst(30);
        //doubleLinkedList.AddLast(50);
        //doubleLinkedList.InsertAt(1, 40);
        var dynamicArray = new DynamicArray<int>(2);

        string jsonString = """
            {
              "lijst_willekeurig_3": [1, 3, "4", 2]
            }
            """;

        

        // Create a JsonNode DOM from a JSON string.
        JsonNode lijsten = JsonNode.Parse(jsonString)!;

        JsonNode lijstenNode = lijsten!["lijst_willekeurig_3"]!;
        var lijstenString = lijstenNode.ToJsonString();
        lijstenString = lijstenString.Trim('[', ']');

        var lijstenArray = lijstenString.Split(',');

        foreach(var x in lijstenArray) {
            int number;

            bool success = int.TryParse(x, out number);
            if (success)
            {
                Console.WriteLine($"Converted '{x}' to {number}.");
                dynamicArray.Add(Int32.Parse(x));
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{x ?? "<null>"}' failed.");
            }
        }
        dynamicArray.Print();
    }
}