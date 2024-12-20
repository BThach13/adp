namespace ADP_Implementation_UnitTests;
using ADP_Implementations.Algorithms.InsertionSort;

public class InsertionSortTests
{
    [Fact]
    public void InsertionSort_ShouldReturnNameInOrder()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Boy", "Daan", "Daniël", "Deniz", "Frank", "Jacqueline", "Leonie", "Marc", "Marco B.", "Marco H.", "Olaf", "Sjaak", "Wouter"];
        InsertionSort.Sort(_unsorted);

        Assert.Equal(_expected, _unsorted);
    }
}