namespace ADP;

class Program
{
    static void Main(string[] args)
    {
        var testCases = new TestCases();
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();

        //var testCaseArray = testCases.Get_List<int>("lijst_aflopend_2");
        //var testCaseArray = testCases.Get_List<int>("lijst_oplopend_2");
        var testCaseArray = testCases.Get_List<float>("lijst_float_8001");
        //var testCaseArray = testCases.Get_List<int>("lijst_gesorteerd_aflopend_3");
        //var testCaseArray = testCases.Get_List<int>("lijst_gesorteerd_oplopend_3");
        //var testCaseArray = testCases.Get_List<int>("lijst_herhaald_1000");
        //var testCaseArray = testCases.Get_List<int>("lijst_leeg_0");
        //var testCaseArray = testCases.Get_List<int>("lijst_null_1");
        //var testCaseArray = testCases.Get_List<int>("lijst_null_3");
        //var testCaseArray = testCases.Get_List<int>("lijst_onsorteerbaar_3");
        //var testCaseArray = testCases.Get_List<int>("lijst_oplopend_10000");
        //var testCaseArray = testCases.Get_List<int>("lijst_willekeurig_10000");
        //var testCaseArray = testCases.Get_List<int>("lijst_willekeurig_3");


        watch.Stop();
        Console.WriteLine($"Elapsed Time: {watch.Elapsed}");
        if (!watch.IsRunning)
            watch.Restart(); // Reset time to 0 and start measuring

        var dynamicArray = new DynamicArray<float>(10);
        if (testCaseArray != null)
        {
            foreach (var element in testCaseArray)
            {
                dynamicArray.Add(element);
            }
        }
        
        watch.Stop();
        Console.WriteLine($"Elapsed Time: {watch.Elapsed}");

        Console.WriteLine("SIZE: {0}", dynamicArray.Size());

        if (!watch.IsRunning)
            watch.Restart(); // Reset time to 0 and start measuring
  
        DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();

        doubleLinkedList.Add(3);
        doubleLinkedList.Add(1,0);

        doubleLinkedList.PrintList(); // Output: 1 3

        doubleLinkedList.Add(2, 1);
        doubleLinkedList.PrintList(); // Output: 1 2 3

        Console.WriteLine("SIZE: {0}", doubleLinkedList.Size());

        watch.Stop();
        Console.WriteLine($"Elapsed Time: {watch.Elapsed}");

        Console.ReadLine();
    }
}