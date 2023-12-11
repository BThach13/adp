using System.Diagnostics;

namespace ADP
{
    public class Test_DS_Stack
    { 
        private void test_readingInt(int[] testCaseArray)
        {
            var stack = new Stack<int>(10);
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    stack.Push(element);
                }
            }
            Console.WriteLine("DATATYPE: Integer");
            Console.WriteLine("SIZE: {0} items", stack.Count());
        }
        private void test_readingFloat(float[] testCaseArray)
        {
            var stack = new Stack<float>(10);
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    stack.Push(element);
                }
            }
            Console.WriteLine("DATATYPE: Float");
            Console.WriteLine("SIZE: {0} items", stack.Count());
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
            var stack = new Stack<string>(10);

            Console.WriteLine($"OPERATION: Add");
            stack.Push("Mantova");
            Console.WriteLine($"OPERATION: Top");
            Console.WriteLine($"Club added: {stack.Top()}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Add");
            stack.Push("Piacenza");
            Console.WriteLine($"OPERATION: Top");
            Console.WriteLine($"Club added: {stack.Top()}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Add");
            stack.Push("Renate");
            Console.WriteLine($"OPERATION: Top");
            Console.WriteLine($"Club added: {stack.Top()}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Add");
            stack.Push("Vicenza");
            Console.WriteLine($"OPERATION: Top");
            Console.WriteLine($"Club added: {stack.Top()}");
            Console.WriteLine($"Number of clubs: {stack.Count()}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Pop");
            stack.Pop();
            Console.WriteLine($"Number of clubs: {stack.Count()}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"#####################################################");
        }
    }
}