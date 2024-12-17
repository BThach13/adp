namespace ADP_Implementations_HANTests;


class Program
{
    static void Main(string[] args)
    {
        //Tests.readJsonData(Utilities.Datastructures.DynamicArray, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.readJsonData(Utilities.Datastructures.DoubleLinkedList, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.readJsonData(Utilities.Datastructures.Stack, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.readJsonData(Utilities.Datastructures.Deque, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.readJsonData(Utilities.Datastructures.PriorityQueue, Utilities.JSonList.Lijst_willekeurig_10000);
        //Tests.PizzaTest_DynamicArray();
        //Tests.PizzaTest_DoubleLinkedList();

        int N = 10;
        int[] _array = new int[N];
        int _target = new Random().Next(0, N * 3);
        //int[] _array = [3, 9, 20, 14, 8, 19, 4, 10, 12, 1];
        //int _target = 14;

        for (int i = 0; i < N; i++)
        {
           _array[i] = i * 3;
        }

        Console.WriteLine(Tests.binarySearchTest(_array, _target, 0, _array.Length - 1));

        //Console.WriteLine(Tests.binarySearchTest_DoWhile(_array, _target));
    }
}