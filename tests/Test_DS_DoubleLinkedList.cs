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
        private void test_iterate_array(DoubleLinkedList<string> doubleLinkedList)
        {
            Console.WriteLine($"RESULT:");
            foreach(var club in doubleLinkedList)
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
            var doubleLinkedList = new DoubleLinkedList<string>();

            Console.WriteLine($"OPERATION: Add");
            Console.WriteLine($"INPUT: Bari, Como, Parma, SPAL");
            Console.WriteLine($"EXPECTED RESULT: Bari, Como, Parma, SPAL added to array");
            if (!watch.IsRunning)
                watch.Restart();
            doubleLinkedList.Add("Bari");
            doubleLinkedList.Add("Como");
            doubleLinkedList.Add("Parma");
            doubleLinkedList.Add("SPAL");
            watch.Stop();
 
            test_iterate_array(doubleLinkedList);
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Get");
            Console.WriteLine($"INPUT: 2");
            Console.WriteLine($"EXPECTED RESULT: Parma");
            if (!watch.IsRunning)
                watch.Restart();            
            Console.WriteLine($"RESULT: {doubleLinkedList.Get(2)}");
            watch.Stop();

            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Set");
            Console.WriteLine($"INPUT: Index 1, Value Frosinone");
            Console.WriteLine($"EXPECTED RESULT: Como changed to Frosinone");
            if (!watch.IsRunning)
                watch.Restart();
            doubleLinkedList.Set(1, "Frosinone");;
            watch.Stop();

            test_iterate_array(doubleLinkedList);
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Remove by index");
            Console.WriteLine($"INPUT: 0");
            Console.WriteLine($"EXPECTED RESULT: Bari removed from array");
            if (!watch.IsRunning)
                watch.Restart();
            doubleLinkedList.Remove(0);
            watch.Stop();           

            test_iterate_array(doubleLinkedList);
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Remove by item");
            Console.WriteLine($"INPUT: Parma");
            Console.WriteLine($"EXPECTED RESULT: Parma removed from array");
            if (!watch.IsRunning)
                watch.Restart();
            doubleLinkedList.Remove("Parma");
            watch.Stop();

            test_iterate_array(doubleLinkedList);
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Contains");
            Console.WriteLine($"INPUT: SPAL");
            Console.WriteLine($"EXPECTED RESULT: True");
            if (!watch.IsRunning)
                watch.Restart();
            Console.WriteLine($"RESULT: {doubleLinkedList.Contains("SPAL")}");
            watch.Stop();
            
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine();

            Console.WriteLine($"INPUT: Roma");
            Console.WriteLine($"EXPECTED RESULT: False");
            if (!watch.IsRunning)
                watch.Restart();
            Console.WriteLine($"RESULT: {doubleLinkedList.Contains("Roma")}");
            watch.Stop();
            
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------"); 

            Console.WriteLine($"OPERATION: indexOf");
            Console.WriteLine($"INPUT: Frosinone");
            Console.WriteLine($"EXPECTED RESULT: 0");
            if (!watch.IsRunning)
                watch.Restart();
            Console.WriteLine($"RESULT: {doubleLinkedList.IndexOf("Frosinone")}");
            watch.Stop();
            
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");                
            Console.WriteLine($"#####################################################");
        }
    }
}