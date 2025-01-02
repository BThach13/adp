namespace ADP_Implementation_UnitTests;

using ADP_Implementation_TestData;
using ADP_Implementations.Algorithms;

public class InsertionSortTests
{
    [Fact]
    public void InsertionSort_ShouldReturnNameInAscendingOrder_WithoutParameter()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Boy", "Daan", "Daniël", "Deniz", "Frank", "Jacqueline", "Leonie", "Marc", "Marco B.", "Marco H.", "Olaf", "Sjaak", "Wouter"];
        InsertionSort.Sort(_unsorted);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void InsertionSort_ShouldReturnNameInAscendingOrder_WithParameter()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Boy", "Daan", "Daniël", "Deniz", "Frank", "Jacqueline", "Leonie", "Marc", "Marco B.", "Marco H.", "Olaf", "Sjaak", "Wouter"];
        InsertionSort.Sort(_unsorted, InsertionSort.SortDirection.Ascending);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void InsertionSort_ShouldReturnNameInDescendingOrder()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Wouter", "Sjaak", "Olaf", "Marco H.", "Marco B.", "Marc", "Leonie", "Jacqueline", "Frank", "Deniz", "Daniël", "Daan", "Boy"];
        InsertionSort.Sort(_unsorted, InsertionSort.SortDirection.Descending);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void InsertionSort_ShouldSortAAscendingArrayInt()
    {
        DataSet dataSet= new DataSet();
        var _descSorted = dataSet.GetListAsInt("lijst_gesorteerd_aflopend_3");
        var _ascSorted = dataSet.GetListAsInt("lijst_gesorteerd_oplopend_3");

        InsertionSort.Sort(_descSorted);

        Assert.Equal(_ascSorted, _descSorted);
    }

    [Fact]
    public void InsertionSort_ShouldSortADescendingArrayInt()
    {
        DataSet dataSet= new DataSet();
        var _ascSorted = dataSet.GetListAsInt("lijst_gesorteerd_oplopend_3");
        var _descSorted = dataSet.GetListAsInt("lijst_gesorteerd_aflopend_3");

        InsertionSort.Sort(_ascSorted, InsertionSort.SortDirection.Descending);

        Assert.Equal(_descSorted, _ascSorted);
    }
}