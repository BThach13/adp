using System.Diagnostics;

namespace ADP
{
    public class Test_DS_Deque
    { 
        private void test_readingInt(int[] testCaseArray)
        {
            var deque = new Deque<int>();
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    deque.InsertLeft(element);
                }
            }
            Console.WriteLine("DATATYPE: Integer");
            Console.WriteLine("SIZE: {0} items", deque.Size);
        }
        private void test_readingFloat(float[] testCaseArray)
        {
            var deque = new Deque<float>();
            if (testCaseArray != null)
            {
                foreach (var element in testCaseArray)
                {
                    deque.InsertLeft(element);
                }
            }
            Console.WriteLine("DATATYPE: Float");
            Console.WriteLine("SIZE: {0} items", deque.Size);
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
            var deque = new Deque<string>();

            Console.WriteLine($"OPERATION: InsertRight");
            Console.WriteLine($"VALUE: Feyenoord");
            deque.InsertRight("Feyenoord");

            Console.WriteLine($"VALUE: PSV");
            deque.InsertRight("PSV");
            Console.WriteLine("Clubs in queue: {0} ({1})", string.Join(", ", deque), deque.Size);
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: InsertLeft");
            Console.WriteLine($"VALUE: Vitesse");
            deque.InsertLeft("Vitesse");

            Console.WriteLine($"VALUE: Volendam");
            deque.InsertLeft("Volendam");
            Console.WriteLine("Clubs in queue: {0} ({1})", string.Join(", ", deque), deque.Size);
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: DeleteLeft");
            deque.DeleteLeft();
            Console.WriteLine("Clubs in queue: {0} ({1})", string.Join(", ", deque), deque.Size);
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: DeleteRight");
            deque.DeleteRight();
            Console.WriteLine("Clubs in queue: {0} ({1})", string.Join(", ", deque), deque.Size);
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"#####################################################");
        }
    }
}