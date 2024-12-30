namespace ADP_Implementation_UnitTests;

using ADP_Implementation_TestData;
using ADP_Implementations.Algorithms;

public class ParallelMergeSortTests
{
    [Fact]
    public void ParallelMergeSort_ShouldReturnNameInAscendingOrder_WithoutParameter()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Boy", "Daan", "Daniël", "Deniz", "Frank", "Jacqueline", "Leonie", "Marc", "Marco B.", "Marco H.", "Olaf", "Sjaak", "Wouter"];
        ParallelMergeSort.Sort(_unsorted, 0, _unsorted.Length);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void ParallelMergeSort_ShouldReturnNameInAscendingOrder_WithParameter()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Boy", "Daan", "Daniël", "Deniz", "Frank", "Jacqueline", "Leonie", "Marc", "Marco B.", "Marco H.", "Olaf", "Sjaak", "Wouter"];
        ParallelMergeSort.Sort(_unsorted, 0, _unsorted.Length, 10);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void ParallelMergeSort_ShouldSortAscendingArrayInt()
    {
        DataSet dataSet= new DataSet();
        var _unsorted = dataSet.GetListAsInt("lijst_willekeurig_10");
        var _expected = dataSet.GetListAsInt("lijst_gesorteerd_10");
        ParallelMergeSort.Sort(_unsorted, 0, _unsorted.Length, 10);

        Assert.Equal(_expected, _unsorted);
    }
}