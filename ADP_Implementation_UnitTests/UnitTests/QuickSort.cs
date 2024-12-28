namespace ADP_Implementation_UnitTests;

using ADP_Implementation_TestData;
using ADP_Implementations.Algorithms;

public class QuickSortTests
{
    [Fact]
    public void QuickSort_ShouldReturnNameInAscendingOrder_WithoutParameter()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Boy", "Daan", "Daniël", "Deniz", "Frank", "Jacqueline", "Leonie", "Marc", "Marco B.", "Marco H.", "Olaf", "Sjaak", "Wouter"];
        QuickSort.Sort(_unsorted, 0, _unsorted.Length - 1);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void QuickSort_ShouldReturnNameInAscendingOrder_WithParameter()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Boy", "Daan", "Daniël", "Deniz", "Frank", "Jacqueline", "Leonie", "Marc", "Marco B.", "Marco H.", "Olaf", "Sjaak", "Wouter"];
        QuickSort.Sort(_unsorted, 0, _unsorted.Length - 1, QuickSort.SortDirection.Ascending);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void QuickSort_ShouldReturnNameInDescendingOrder()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Wouter", "Sjaak", "Olaf", "Marco H.", "Marco B.", "Marc", "Leonie", "Jacqueline", "Frank", "Deniz", "Daniël", "Daan", "Boy"];
        QuickSort.Sort(_unsorted, 0, _unsorted.Length - 1, QuickSort.SortDirection.Descending);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void QuickSort_ShouldSortAscendingArrayInt()
    {
        DataSet dataSet= new DataSet();
        var _descSorted = dataSet.GetList("lijst_gesorteerd_aflopend_3");
        var _ascSorted = dataSet.GetList("lijst_gesorteerd_oplopend_3");
        QuickSort.Sort(_descSorted, 0, _descSorted.Length - 1);

        Assert.Equal(_ascSorted, _descSorted);
    }

    [Fact]
    public void QuickSort_ShouldSortADescendingArrayInt()
    {
        DataSet dataSet= new DataSet();
        var _ascSorted = dataSet.GetList("lijst_gesorteerd_oplopend_3");
        var _descSorted = dataSet.GetList("lijst_gesorteerd_aflopend_3");
        QuickSort.Sort(_ascSorted, 0, _ascSorted.Length - 1, QuickSort.SortDirection.Descending);

        Assert.Equal(_descSorted, _ascSorted);
    }
}