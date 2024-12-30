namespace ADP_Implementations.Algorithms;

public static class ParallelMergeSort
{
    public static void Sort<T>(T[] array, int start, int end, int treshold = 2)
    {
        if (end - start <= 1)
            return;

        int mid = start + (end - start) / 2;
        
        if (array.Length <= treshold)
        {
            Sort(array, start, mid, treshold);
            Sort(array, mid, end, treshold);
        }
        else
        {
            Parallel.Invoke(
                () => Sort(array, start, mid, treshold),
                () => Sort(array, mid, end, treshold));
        }

        Merge(array, start, mid, end);
    }

    // This implementation is for benchmarking purposes only. It's not part of the presentation!
    public static void SortParallel<T>(T[] array, int start, int end)
    {
        if (end - start <= 1)
            return;

        int mid = start + (end - start) / 2;
        
        Parallel.Invoke(
            () => SortParallel(array, start, mid),
            () => SortParallel(array, mid, end));

        Merge(array, start, mid, end);
    }

    // This implementation is for benchmarking purposes only. It's not part of the presentation!
    public static void SortSeq<T>(T[] array, int start, int end)
    {
        if (end - start <= 1)
            return;

        int mid = start + (end - start) / 2;

        SortSeq(array, start, mid);
        SortSeq(array, mid, end);

        Merge(array, start, mid, end);
    }

    private static void Merge<T>(T[] array, int start, int mid, int end)
    {
        int size = end - start;
        T[] temp = new T[size];

        int t = 0;
        int left = start;
        int right = mid;

        var comparer = Comparer<T>.Default;

        while (left < mid && right < end)
        {
            if (comparer.Compare(array[left], array[right]) <= 0)
                temp[t++] = array[left++];
            else
                temp[t++] = array[right++];
        }

        while (left < mid)
        {
            temp[t++] = array[left++];
        }

        while (right < end)
        {
            temp[t++] = array[right++];
        }

        for (int i = 0; i < size; i++)
        {
            array[start + i] = temp[i];
        }
    }
}