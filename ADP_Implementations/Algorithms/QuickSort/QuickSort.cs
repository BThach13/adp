namespace ADP_Implementations.Algorithms;

public static class QuickSort
{
    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public static void Sort<T>(T[] array, int start, int end, SortDirection direction = SortDirection.Ascending) where T : IComparable<T>
    {
        if (start < end)
        {
            int pivot = Partition(array, start, end, direction);
            Sort(array, start, pivot - 1, direction);
            Sort(array, pivot + 1, end, direction);
        }
    }

    private static int Partition<T>(T[] array, int start, int end, SortDirection direction) where T : IComparable<T>
    {
        int pivotIndex = MedianOfThreeIndex(array, start, end);
        T pivot = array[pivotIndex];

        Swap(ref array[pivotIndex], ref array[end]);

        int i = start;
        for (int j = start; j < end; j++)
        {
            if (direction == SortDirection.Ascending) {
                if (array[j].CompareTo(pivot) < 0)
                {
                    Swap(ref array[j], ref array[i]);
                    i++;
                }
            } else {
                if (array[j].CompareTo(pivot) > 0)
                {
                    Swap(ref array[j], ref array[i]);
                    i++;
                }
            }
        }

        Swap(ref array[i], ref array[end]);
        return i;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
            T temp = x;
            x = y;
            y = temp;
    }

    private static int MedianOfThreeIndex<T>(T[] array, int start, int end) where T : IComparable<T>
    {
        int mid = start + (end - start) / 2;

        T medianValue = MedianOfThree(array[start], array[mid], array[end]);
        if (medianValue.Equals(array[start])) return start;
        if (medianValue.Equals(array[mid])) return mid;
        return end;
    }

    private static T MedianOfThree<T>(T a, T b, T c) where T : IComparable<T>
    {
        if ((a.CompareTo(b) > 0 && a.CompareTo(c) < 0) || (a.CompareTo(b) < 0 && a.CompareTo(c) > 0))
            return a;
        if ((b.CompareTo(a) > 0 && b.CompareTo(c) < 0) || (b.CompareTo(a) < 0 && b.CompareTo(c) > 0))
            return b;
        return c;
    }

}