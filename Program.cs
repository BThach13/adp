namespace ADP;

class Program
{
    static void Main(string[] args)
    {
        //DataStructures.DynamicArray();
        var testCases = new TestCases();

        var jsonArray = testCases.Get_List<int>("lijst_willekeurig_10000");
        var dynamicArray = new DynamicArray<int>(10);

        if (jsonArray != null)
        {
            foreach (var element in jsonArray)
            {
                dynamicArray.Add(element);
            }
        }
        Console.WriteLine("SIZE: {0}", dynamicArray.Size);
    }
}