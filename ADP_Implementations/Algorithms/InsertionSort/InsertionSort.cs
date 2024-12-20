namespace ADP_Implementations.Algorithms.InsertionSort;

public static class InsertionSort
{
    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public static void Sort<T>(T[] list, SortDirection direction = SortDirection.Ascending)
    {
        var comparer = Comparer<T>.Default;
        for (int i = 1; i < list.Length; i++)
        {
            T temp = list[i];
            int j = i - 1;

            if (direction == SortDirection.Ascending) {
                while (j >= 0 && comparer.Compare(list[j], temp) > 0)
                {
                    list[j + 1] = list[j];
                    j--;
                }
            } else {
                while (j >= 0 && comparer.Compare(list[j], temp) < 0)
                {
                    list[j + 1] = list[j];
                    j--;
                }
            }
            list[j + 1] = temp;
        }
    }
}