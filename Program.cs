namespace ADP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"LOADING TESTDATA");
        Console.WriteLine($"#####################################################");
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        var testCases = new TestCases();
        watch.Stop();
        Console.WriteLine($"TESTCASES - Elapsed Time: {watch.Elapsed}");
        Console.WriteLine($"#####################################################");      

        // DYNAMIC ARRAY
        //var test_DS_DynamicArray = new Test_DS_DynamicArray();
        //test_DS_DynamicArray.run_loadData_tests(testCases);
        //test_DS_DynamicArray.run_operation_tests();

        // DOUBLE LINKED LIST
        //var test_DS_DoubleLinkedList = new Test_DS_DoubleLinkedList();
        //test_DS_DoubleLinkedList.run_loadData_tests(testCases);
        //test_DS_DoubleLinkedList.run_operation_tests();

        // STACK
        //var test_DS_Stack = new Test_DS_Stack();
        //test_DS_Stack.run_loadData_tests(testCases);
        //test_DS_Stack.run_operation_tests();
 
        // DEQUE
        var test_DS_Deque = new Test_DS_Deque();
        //test_DS_Deque.run_loadData_tests(testCases);
        //test_DS_Deque.run_operation_tests();

        // PRIORITY QUEUE
        var test_DS_PriorityQueue = new Test_DS_PriorityQueue();
        //test_DS_PriorityQueue.run_loadData_tests(testCases);
        //test_DS_PriorityQueue.run_operation_tests();
    }
}