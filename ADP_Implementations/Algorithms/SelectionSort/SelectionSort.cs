namespace ADP_Implementations.Algorithms.SelectionSort;

public static class SelectionSort
{
    public enum SortDirection
    {
        Ascending,
        Descending
    }
    
    public static void Sort<T>(T[] array, SortDirection direction = SortDirection.Ascending)
    {
        var comparer = Comparer<T>.Default;
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (direction == SortDirection.Ascending) {
                    if (comparer.Compare(array[min], array[j]) > 0)
                        min = j;
                } else {
                    if (comparer.Compare(array[min], array[j]) < 0)
                        min = j;
                }
            }
            T temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
    }
}