namespace ADP_Implementations.Algorithms;

public static class BinarySearch
{
    public static int Search(int[] list, int value, int low, int high) {
        if (low > high)
            return - 1;

        int center = low + (high - low) / 2;
        int centerValue = list[center];

        if (centerValue == value)
                return center;
        else if (centerValue > value)
            return Search(list, value, low, center - 1);
        else
            return Search(list, value, center + 1, high);
    }

    // This implementation is for benchmarking purposes only. It's not part of the presentation!
    public static int Search_DoWhile(int[] list, int value) {
        int low = 0;
        int high = list.Length;
        var result = -1;

        do {
            int center = low + (high - low) / 2;
            int centerValue = list[center];
            if (centerValue == value)
                result = center;

            if (centerValue > value)
                high = center;
            else
                low = center + 1;
        }
        while (low < high);
        
        return result;
    }
}