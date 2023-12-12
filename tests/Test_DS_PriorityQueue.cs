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
        }

        private void test_iterate_queue(PriorityQueue<string> priorityQueue)
        {
            Console.WriteLine($"RESULT:");
            foreach(var club in priorityQueue)
            {
                Console.WriteLine($"- Club: {club}");
            }
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
            Console.WriteLine($"INPUT: FC Groningen, 8");
            Console.WriteLine($"EXPECTED RESULT: FC Groningen added to queue.");
            if (!watch.IsRunning)
                watch.Restart();
            priorityQueue.Add("FC Groningen", 8);
            watch.Stop();

            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");

            Console.WriteLine("");
            Console.WriteLine($"INPUT: Willem II, 1");
            Console.WriteLine($"EXPECTED RESULT: Willem II added to queue.");
            if (!watch.IsRunning)
                watch.Restart();
            priorityQueue.Add("Willem II", 1);
            watch.Stop();

            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");

            Console.WriteLine("");
            Console.WriteLine($"INPUT: Jong PSV, 17");
            Console.WriteLine($"EXPECTED RESULT: Jong PSV added to queue.");
            if (!watch.IsRunning)
                watch.Restart();
            priorityQueue.Add("Jong PSV", 17);
            watch.Stop();

            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");

            Console.WriteLine("");
            Console.WriteLine($"INPUT: FC Eindhoven, 10");
            Console.WriteLine($"EXPECTED RESULT: FC Eindhoven added to queue.");
            if (!watch.IsRunning)
                watch.Restart();
            priorityQueue.Add("FC Eindhoven", 10);
            watch.Stop();
          
            test_iterate_queue(priorityQueue);
            Console.WriteLine("");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");  
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Peek");
            Console.WriteLine($"INPUT: NULL");
            Console.WriteLine($"EXPECTED RESULT: Willem II");
            if (!watch.IsRunning)
                watch.Restart();
            Console.WriteLine($"RESULT: {priorityQueue.Peek()}");
            watch.Stop();

            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Poll");
            Console.WriteLine($"INPUT: NULL");
            Console.WriteLine($"EXPECTED RESULT: Willem II");
            if (!watch.IsRunning)
                watch.Restart();
            priorityQueue.Poll();
            watch.Stop();
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");

            Console.WriteLine("");           
            test_iterate_queue(priorityQueue);
            Console.WriteLine($"#####################################################");
        }
    }
}