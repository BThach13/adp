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
            Console.WriteLine("SIZE: {0} items", deque.Size());
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
            Console.WriteLine("SIZE: {0} items", deque.Size());
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
            Console.WriteLine($"INPUT: Feyenoord");
            Console.WriteLine($"EXPECTED RESULT: Feyenoord added to stack. Queue contains 1 club");
            if (!watch.IsRunning)
                watch.Restart();
            deque.InsertRight("Feyenoord");
            watch.Stop();

            Console.WriteLine($"Clubs in queue: {string.Join(", ", deque)}, Total clubs: {deque.Size()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");

            Console.WriteLine("");
            Console.WriteLine($"OPERATION: InsertRight");
            Console.WriteLine($"INPUT: PSV");
            Console.WriteLine($"EXPECTED RESULT: PSV added on the right side of Feyenoord. Queue contains 2 clubs");
            if (!watch.IsRunning)
                watch.Restart();
            deque.InsertRight("PSV");
            watch.Stop();

            Console.WriteLine($"Clubs in queue: {string.Join(", ", deque)}, Total clubs: {deque.Size()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: InsertLeft");
            Console.WriteLine($"INPUT: Vitesse");
            Console.WriteLine($"EXPECTED RESULT: Vitesse added on the left side of Feyenoord. Queue contains 3 clubs");
            if (!watch.IsRunning)
                watch.Restart();
            deque.InsertLeft("Vitesse");
            watch.Stop();

            Console.WriteLine($"Clubs in queue: {string.Join(", ", deque)}, Total clubs: {deque.Size()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");

            Console.WriteLine("");
            Console.WriteLine($"OPERATION: InsertLeft");
            Console.WriteLine($"INPUT: Volendam");
            Console.WriteLine($"EXPECTED RESULT: Volendam added on the left side of Vitesse. Queue contains 4 clubs");
            if (!watch.IsRunning)
                watch.Restart();
            deque.InsertLeft("Volendam");
            watch.Stop();

            Console.WriteLine($"Clubs in queue: {string.Join(", ", deque)}, Total clubs: {deque.Size()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: DeleteLeft");
            Console.WriteLine($"INPUT: NULL");
            Console.WriteLine($"EXPECTED RESULT: Volendam removed from queue. Queue contains 3 clubs");
            if (!watch.IsRunning)
                watch.Restart();
            deque.DeleteLeft();
            watch.Stop();

            Console.WriteLine($"Clubs in queue: {string.Join(", ", deque)}, Total clubs: {deque.Size()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"OPERATION: DeleteRight");
            Console.WriteLine($"INPUT: NULL");
            Console.WriteLine($"EXPECTED RESULT: PSV removed from queue. Queue contains 2 clubs");
            if (!watch.IsRunning)
                watch.Restart();
            deque.DeleteRight();
            watch.Stop();

            Console.WriteLine($"Clubs in queue: {string.Join(", ", deque)}, Total clubs: {deque.Size()}");
            Console.WriteLine($"ELAPSED TIME: {watch.Elapsed}");
            Console.WriteLine($"-----------------------------------------------------");

            Console.WriteLine($"#####################################################");
        }
    }
}