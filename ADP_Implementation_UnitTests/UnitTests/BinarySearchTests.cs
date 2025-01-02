namespace ADP_Implementation_UnitTests;
using ADP_Implementations.Algorithms;

public class BinarySearchTests
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

        Assert.Equal(145, BinarySearch.Search(_array, 145, 0, _array.Length - 1));
    }

    [Fact]
    public void Search_DoWhile_ShouldReturnValue()
    {
        int N = 1000;
        int[] _array = new int[N];
        for (var i = 0; i < N; i++)
        {
            _array[i] = i;
        }

        Assert.Equal(145, BinarySearch.Search_DoWhile(_array, 145));
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

        Assert.Equal(-1, BinarySearch.Search_DoWhile(_array, 2024));
    }
}