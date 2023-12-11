using System.Diagnostics;

namespace ADP
{
    public class Test_DS_DynamicArray
    {    
        private void test_readingInt(int[] testCaseArray)
        {
            var dynamicArray = new DynamicArray<int>(10);
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    dynamicArray.Add(element);
                }
            }
            Console.WriteLine("DATATYPE: Integer");
            Console.WriteLine("SIZE: {0} items", dynamicArray.Size());
        }
        private void test_readingFloat(float[] testCaseArray)
        {
            var dynamicArray = new DynamicArray<float>(10);
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    dynamicArray.Add(element);
                }
            }
            Console.WriteLine("DATATYPE: Float");
            Console.WriteLine("SIZE: {0} items", dynamicArray.Size());
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
            var dynamicArray = new DynamicArray<string>(10);

            Console.WriteLine($"OPERATION: Add");
            dynamicArray.Add("Atalanta");
            dynamicArray.Add("Inter Milan");
            dynamicArray.Add("Roma");
            dynamicArray.Add("Udinese");

            foreach(var club in dynamicArray)
            {
                Console.WriteLine($"Club: {club}");
            }
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Get");
            Console.WriteLine($"VALUE: Udinese");
            Console.WriteLine($"Club 3: {dynamicArray[2]}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Set");
            Console.WriteLine($"Club 2 (BEFORE): {dynamicArray[1]}");
            dynamicArray.Set(1, "AC Milan");
            Console.WriteLine($"Club 2 (AFTER): {dynamicArray[1]}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Remove");
            Console.WriteLine($"VALUE: 0 (Atalanta)");
            dynamicArray.Remove(0);
            foreach(var club in dynamicArray)
            {
                Console.WriteLine($"Club: {club}");
            }
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Remove");
            Console.WriteLine($"VALUE: Udinese");
            dynamicArray.Remove("Udinese");
            foreach(var club in dynamicArray)
            {
                Console.WriteLine($"Club: {club}");
            }
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Contains");
            Console.WriteLine($"VALUE: Roma");
            Console.WriteLine(dynamicArray.Contains("Roma"));

            Console.WriteLine($"VALUE: Bari");
            Console.WriteLine(dynamicArray.Contains("Bari"));
            Console.WriteLine($"-----------------------------------------------------"); 

            Console.WriteLine($"OPERATION: indexOf");
            Console.WriteLine($"VALUE: AC Milan");
            Console.WriteLine($"INDEX: {dynamicArray.IndexOf("AC Milan")}");
                  
            Console.WriteLine($"#####################################################");
        }
    }
}