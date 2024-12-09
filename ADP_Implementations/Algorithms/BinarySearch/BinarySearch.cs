namespace ADP_Implementations.Algorithms.BinarySearch;

public static class BinarySearch
{
    public static int Search(int[] list, int value, int low, int high) {
        if (low > high) {
            return - 1;
        }

        int center = low + (high - low) / 2;
        int centerValue = list[center];

        if (centerValue == value)
                return center;
        else if (centerValue > value) {
            return Search(list, value, low, center - 1);
        }
        else {
            return Search(list, value, center + 1, high);
        }
    }

    public static int Search_DoWhile(int[] list, int value) {
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