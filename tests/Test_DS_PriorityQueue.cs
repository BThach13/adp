using System.Diagnostics;

namespace ADP
{
    public class Test_DS_PriorityQueue
    { 
        private void test_readingInt(int[] testCaseArray)
        {
            var priorityQueue = new PriorityQueue<int>();
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    priorityQueue.Add(element, 1);
                }
            }
            Console.WriteLine("DATATYPE: Integer");
            //Console.WriteLine("SIZE: {0} items", priorityQueue.Size);
        }
        private void test_readingFloat(float[] testCaseArray)
        {
            var priorityQueue = new PriorityQueue<float>();
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    priorityQueue.Add(element, 2);
                }
            }
            Console.WriteLine("DATATYPE: Float");
            //Console.WriteLine("SIZE: {0} items", priorityQueue.Size);
        }
        public void run_loadData_tests(TestCases testCases)
        {
            var watch = new Stopwatch();
            Console.WriteLine($"READING DATA");
            Console.WriteLine($"#####################################################");
            var names = testCases.getNodeNames();
            foreach(var name in names)
            {
                Console.WriteLine($"LIST: {name}");
                if (!watch.IsRunning)
                    watch.Restart();

                if (!name.Contains("float"))
                {
                    test_readingInt(testCases.Get_List<int>(name));
                }
                 if (name.Contains("float"))
                {
                    test_readingFloat(testCases.Get_List<float>(name));
                }               

                watch.Stop();
                Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
                Console.WriteLine($"-----------------------------------------------------");
            }
            Console.WriteLine($"#####################################################");
        }
        public void run_operation_tests()
        {
            var watch = new Stopwatch();
            Console.WriteLine($"OPERATIONS");
            Console.WriteLine($"#####################################################");
            var priorityQueue = new PriorityQueue<string>();
            
            Console.WriteLine($"OPERATION: Add");
            priorityQueue.Add("FC Groningen", 8);
            priorityQueue.Add("Willem II", 1);
            priorityQueue.Add("Jong PSV", 17);
            priorityQueue.Add("FC Eindhoven", 10);
            foreach (var club in priorityQueue)
            {
                Console.WriteLine($"Club in queue: {club}");
            }
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Peek");
            Console.WriteLine($"Club with highest priority: {priorityQueue.Peek()}");

            Console.WriteLine($"OPERATION: Poll");
            Console.WriteLine($"Removed from queue: {priorityQueue.Poll()}");
            foreach (var club in priorityQueue)
            {
                Console.WriteLine($"Club in queue: {club}");
            }
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"#####################################################");
        }
    }
}