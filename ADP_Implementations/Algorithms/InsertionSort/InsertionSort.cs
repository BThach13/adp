namespace ADP_Implementations.Algorithms;

public static class InsertionSort
{
    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public static void Sort<T>(T[] array, SortDirection direction = SortDirection.Ascending)
    {
        var comparer = Comparer<T>.Default;
        for (int i = 1; i < array.Length; i++)
        {
            T temp = array[i];
            int j = i - 1;

            if (direction == SortDirection.Ascending) {
                while (j >= 0 && comparer.Compare(array[j], temp) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
            } else {
                while (j >= 0 && comparer.Compare(array[j], temp) < 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
            }
            array[j + 1] = temp;
        }
    }
}