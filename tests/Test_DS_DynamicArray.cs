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
        private void test_iterate_array(DynamicArray<string> dynamicArray)
        {
            Console.WriteLine($"RESULT:");
            foreach(var club in dynamicArray)
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
            var dynamicArray = new DynamicArray<string>(10);

            Console.WriteLine($"OPERATION: Add");
            Console.WriteLine($"INPUT: Atalanta, Inter Milan, Roma, Udinese");
            Console.WriteLine($"EXPECTED RESULT: Atalanta, Inter Milan, Roma, Udinese added to array");
            if (!watch.IsRunning)
                watch.Restart();
            dynamicArray.Add("Atalanta");
            dynamicArray.Add("Inter Milan");
            dynamicArray.Add("Roma");
            dynamicArray.Add("Udinese");
            watch.Stop();

            test_iterate_array(dynamicArray);
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Get");
            Console.WriteLine($"INPUT: 2");
            Console.WriteLine($"EXPECTED RESULT: Roma");
            if (!watch.IsRunning)
                watch.Restart();            
            Console.WriteLine($"RESULT: {dynamicArray[2]}");
            watch.Stop();

            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Set");
            Console.WriteLine($"INPUT: Index 1, Value AC MILAN");
            Console.WriteLine($"EXPECTED RESULT: Inter Milan changed to AC MILAN");
            if (!watch.IsRunning)
                watch.Restart();
            dynamicArray.Set(1, "AC Milan");   
            watch.Stop();

            test_iterate_array(dynamicArray);
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Remove by index");
            Console.WriteLine($"INPUT: 0");
            Console.WriteLine($"EXPECTED RESULT: Atalanta removed from array");
            if (!watch.IsRunning)
                watch.Restart();
            dynamicArray.Remove(0);
            watch.Stop();           

            test_iterate_array(dynamicArray);
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Remove by item");
            Console.WriteLine($"INPUT: Udinese");
            Console.WriteLine($"EXPECTED RESULT: Udinese removed from array");
            if (!watch.IsRunning)
                watch.Restart();
            dynamicArray.Remove("Udinese");
            watch.Stop();

            test_iterate_array(dynamicArray);
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: Contains");
            Console.WriteLine($"INPUT: Roma");
            Console.WriteLine($"EXPECTED RESULT: True");
            if (!watch.IsRunning)
                watch.Restart();
            Console.WriteLine($"RESULT: {dynamicArray.Contains("Roma")}");
            
            watch.Stop();
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine();

            Console.WriteLine($"INPUT: Bari");
            Console.WriteLine($"EXPECTED RESULT: False");
            if (!watch.IsRunning)
                watch.Restart();
            Console.WriteLine($"RESULT: {dynamicArray.Contains("Bari")}");
            watch.Stop();
            
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------"); 

            Console.WriteLine($"OPERATION: indexOf");
            Console.WriteLine($"INPUT: Roma");
            Console.WriteLine($"EXPECTED RESULT: 1");
            if (!watch.IsRunning)
                watch.Restart();
            Console.WriteLine($"RESULT: {dynamicArray.IndexOf("Roma")}");
            watch.Stop();
            
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");      
            Console.WriteLine($"#####################################################");
        }
    }
}