using System.Diagnostics;

namespace ADP
{
    public class Test_DS_DoubleLinkedList
    {  
        private void test_readingInt(int[] testCaseArray)
        {
            var doubleLinkedList = new DoubleLinkedList<int>();
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    doubleLinkedList.Add(element);
                }
            }
            Console.WriteLine("DATATYPE: Integer");
            Console.WriteLine("SIZE: {0} items", doubleLinkedList.Size());
        }
        private void test_readingFloat(float[] testCaseArray)
        {
            var doubleLinkedList = new DoubleLinkedList<float>();
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    doubleLinkedList.Add(element);
                }
            }
            Console.WriteLine("DATATYPE: Float");
            Console.WriteLine("SIZE: {0} items", doubleLinkedList.Size());
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
            var doubleLinkedList = new DoubleLinkedList<string>();

            Console.WriteLine($"OPERATION: Add");
            doubleLinkedList.Add("Bari");
            doubleLinkedList.Add("Como");
            doubleLinkedList.Add("Parma");
            doubleLinkedList.Add("SPAL");

            foreach(var club in doubleLinkedList)
            {
                Console.WriteLine($"Club: {club}");
            }
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Get");
            Console.WriteLine($"VALUE: Parma");
            Console.WriteLine($"Club 3: {doubleLinkedList.Get(2)}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Set");
            Console.WriteLine($"Club 2 (BEFORE): {doubleLinkedList.Get(1)}");
            doubleLinkedList.Set(1, "Frosinone");
            Console.WriteLine($"Club 2 (AFTER): {doubleLinkedList.Get(1)}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Remove");
            Console.WriteLine($"VALUE: 0 (Bari)");
            doubleLinkedList.Remove(0);
            foreach(var club in doubleLinkedList)
            {
                Console.WriteLine($"Club: {club}");
            }
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Remove");
            Console.WriteLine($"VALUE: Parma");
            doubleLinkedList.Remove("Parma");
            foreach(var club in doubleLinkedList)
            {
                Console.WriteLine($"Club: {club}");
            }
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Contains");
            Console.WriteLine($"VALUE: SPAL");
            Console.WriteLine(doubleLinkedList.Contains("SPAL"));

            Console.WriteLine($"VALUE: Roma");
            Console.WriteLine(doubleLinkedList.Contains("Roma"));
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: indexOf");
            Console.WriteLine($"VALUE: Frosinone");
            Console.WriteLine($"INDEX: {doubleLinkedList.IndexOf("Frosinone")}");
                  
            Console.WriteLine($"#####################################################");
        }
    }
}