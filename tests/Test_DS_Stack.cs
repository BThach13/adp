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
            Console.WriteLine($"INPUT: Mantova");
            Console.WriteLine($"EXPECTED RESULT: Mantova added to stack. Stack contains 1 club");
            if (!watch.IsRunning)
                watch.Restart();
            stack.Push("Mantova");
            watch.Stop();

            Console.WriteLine($"Club added: {stack.Top()}, Total clubs: {stack.Count()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");

            Console.WriteLine("");
            Console.WriteLine($"OPERATION: Add");
            Console.WriteLine($"INPUT: Piacenza");
            Console.WriteLine($"EXPECTED RESULT: Piacenza added to stack. Stack contains 2 clubs");
            if (!watch.IsRunning)
                watch.Restart();
            stack.Push("Piacenza");
            watch.Stop();

            Console.WriteLine($"Club added: {stack.Top()}, Total clubs: {stack.Count()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");

            Console.WriteLine("");
            Console.WriteLine($"OPERATION: Add");
            Console.WriteLine($"INPUT: Renate");
            Console.WriteLine($"EXPECTED RESULT: Renate added to stack. Stack contains 3 clubs");
            if (!watch.IsRunning)
                watch.Restart();
            stack.Push("Renate");
            watch.Stop();

            Console.WriteLine($"Club added: {stack.Top()}, Total clubs: {stack.Count()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");

            Console.WriteLine("");
            Console.WriteLine($"OPERATION: Add");
            Console.WriteLine($"INPUT: Vicenza");
            Console.WriteLine($"EXPECTED RESULT: Vicenza added to stack. Stack contains 4 clubs");
            if (!watch.IsRunning)
                watch.Restart();
            stack.Push("Vicenza");
            watch.Stop();
 
            Console.WriteLine($"Club added: {stack.Top()}, Total clubs: {stack.Count()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Pop");
            Console.WriteLine($"INPUT: NULL");
            Console.WriteLine($"EXPECTED RESULT: Vicenza removed from stack. Stack contains 3 clubs");
            if (!watch.IsRunning)
                watch.Restart();
            stack.Pop();
            watch.Stop();

            Console.WriteLine($"Total clubs: {stack.Count()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Top");
            Console.WriteLine($"INPUT: NULL");
            Console.WriteLine($"EXPECTED RESULT: Renate");
            if (!watch.IsRunning)
                watch.Restart();           
            Console.WriteLine($"RESULT: {stack.Top()}");
            watch.Stop();

            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: IsEmpty");
            Console.WriteLine($"INPUT: NULL");
            Console.WriteLine($"EXPECTED RESULT: False");
            if (!watch.IsRunning)
                watch.Restart();           
            Console.WriteLine($"RESULT: {stack.IsEmpty()}");
            watch.Stop();

            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Count");
            Console.WriteLine($"INPUT: NULL");
            Console.WriteLine($"EXPECTED RESULT: 3");
            if (!watch.IsRunning)
                watch.Restart();           
            Console.WriteLine($"RESULT: {stack.Count()}");
            watch.Stop();

            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"#####################################################");
        }
    }
}