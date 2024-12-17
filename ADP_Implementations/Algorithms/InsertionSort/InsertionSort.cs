namespace ADP_Implementations.Algorithms.InsertionSort;

public static class InsertionSort
{
    public static void Sort<T>(T[] list)
    {
        var comparer = Comparer<T>.Default;      
        for (int i = 1; i < list.Length; i++)
        {
            T temp = list[i];
            int j = i - 1;

            while (j >= 0 && comparer.Compare(list[j], temp) > 0)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = temp;
        }
    }
}