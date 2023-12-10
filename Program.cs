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
        var test_DS_DynamicArray = new Test_DS_DynamicArray();
        test_DS_DynamicArray.run_loadData_tests(testCases);

        // DOUBLE LINKED LIST
        /*
        if (!watch.IsRunning)
            watch.Restart(); // Reset time to 0 and start measuring
  
        DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();

        doubleLinkedList.Add(3);
        doubleLinkedList.Add(1,0);

        doubleLinkedList.PrintList(); // Output: 1 3

        doubleLinkedList.Add(2, 1);
        doubleLinkedList.PrintList(); // Output: 1 2 3

        Console.WriteLine("DATA: {0}", doubleLinkedList.Get(1)); // Output: 2

        doubleLinkedList.Remove(1);
        doubleLinkedList.PrintList(); // Output: 2 3

        Console.WriteLine("INDEX: {0}", doubleLinkedList.IndexOf(3)); // Output: 1

        doubleLinkedList.RemoveAt(1);
        doubleLinkedList.PrintList(); // Output: 2

        Console.WriteLine("CONTAINS: {0}", doubleLinkedList.Contains(20));
        Console.WriteLine("SIZE: {0}", doubleLinkedList.Size());
        watch.Stop();
        Console.WriteLine($"DOUBLE LINKED LIST - Elapsed Time: {watch.Elapsed}");
        */

        // STACK
        /*
        if (!watch.IsRunning)
            watch.Restart(); // Reset time to 0 and start measuring

        Stack<int> myStack = new Stack<int>();

        myStack.Push(10);
        myStack.Push(30);
        myStack.Push(20);
        
        Console.WriteLine("Top element: " + myStack.Top());
        Console.WriteLine("Popped element: " + myStack.Pop());
        Console.WriteLine("Remaining elements in the stack:");
        while (!myStack.IsEmpty())
        {
            Console.WriteLine(myStack.Pop());
        }
        watch.Stop();
        Console.WriteLine($"STACK - Elapsed Time: {watch.Elapsed}");
        */
 
        // DEQUE
        /*
        if (!watch.IsRunning)
            watch.Restart(); // Reset time to 0 and start measuring

        Deque<int> deque = new Deque<int>();

        // Add elements to the front and back
        deque.InsertRight(4);
        deque.InsertRight(3);
        deque.InsertLeft(2);
        deque.InsertLeft(1);

        // Display the elements in the deque
        Console.WriteLine("Deque elements: " + string.Join(", ", deque));

        // Remove elements from the front and back
        int frontElement = deque.DeleteRight();
        int backElement = deque.DeleteLeft();

        // Display the removed elements
        Console.WriteLine("Removed front element: " + frontElement);
        Console.WriteLine("Removed back element: " + backElement);

        // Display the remaining elements in the deque
        Console.WriteLine("Remaining deque elements: " + string.Join(", ", deque));
        watch.Stop();
        Console.WriteLine($"DEQUE - Elapsed Time: {watch.Elapsed}");
        */

        // PRIORITY QUEUE
        /*
        if (!watch.IsRunning)
            watch.Restart(); // Reset time to 0 and start measuring
        PriorityQueue<string> priorityQueue = new PriorityQueue<string>();

        priorityQueue.Add("Task 1", 3);
        priorityQueue.Add("Task 2", 1);
        priorityQueue.Add("Task 3", 2);

        Console.WriteLine($"Peek: {priorityQueue.Peek()}");

        while (!priorityQueue.IsEmpty())
        {
            string task = priorityQueue.Poll();
            Console.WriteLine($"Processing: {task}");
        }
        watch.Stop();
        Console.WriteLine($"PRIORITY QUEUE - Elapsed Time: {watch.Elapsed}");
        */
    }
}