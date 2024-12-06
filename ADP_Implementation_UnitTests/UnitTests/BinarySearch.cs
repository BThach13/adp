namespace ADP_Implementation_UnitTests;

public class BinarySearch
{
    [Fact]
    public void Search_ShouldReturnValue()
    {
        int N = 1000;
        int[] _array = new int[N];
        for (var i = 0; i < N; i++)
        {
            _array[i] = i;
        }

        Assert.Equal(145, ADP_Implementations.Algorithms.BinarySearch.BinarySearch.Search(_array, 145));
    }

    [Fact]
    public void Search_ShouldReturnNegativeValue()
    {
        int N = 1000;
        int[] _array = new int[N];
        for (var i = 0; i < N; i++)
        {
            _array[i] = i;
        }

        Assert.Equal(-1, ADP_Implementations.Algorithms.BinarySearch.BinarySearch.Search(_array, 2024));
    }
}