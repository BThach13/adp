namespace ADP_Implementations.Algorithms.BinarySearch;

public static class BinarySearch
{
    public static int Search(int[] list, int value) {
        int low = 0;
        int high = list.Length;
        int result = -1;

        do {
            int center = low + (high - low) / 2;
            int centerValue = list[center];
            if (centerValue == value)
                result = centerValue;

            if (centerValue > value)
                high = centerValue;
            else
                low = centerValue + 1;
        }
        while (low < high);
        
        return result;
    }
}