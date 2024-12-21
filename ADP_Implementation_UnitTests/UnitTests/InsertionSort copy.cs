namespace ADP_Implementation_UnitTests;

using ADP_Implementation_TestData;
using ADP_Implementations.Algorithms.SelectionSort;

public class SelectionSortTests
{
    [Fact]
    public void SelectionSort_ShouldReturnNameInAscendingOrder_WithoutParameter()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Boy", "Daan", "Daniël", "Deniz", "Frank", "Jacqueline", "Leonie", "Marc", "Marco B.", "Marco H.", "Olaf", "Sjaak", "Wouter"];
        SelectionSort.Sort(_unsorted);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void SelectionSort_ShouldReturnNameInAscendingOrder_WithParameter()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Boy", "Daan", "Daniël", "Deniz", "Frank", "Jacqueline", "Leonie", "Marc", "Marco B.", "Marco H.", "Olaf", "Sjaak", "Wouter"];
        SelectionSort.Sort(_unsorted, SelectionSort.SortDirection.Ascending);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void SelectionSort_ShouldReturnNameInDescendingOrder()
    {
        string[] _unsorted = ["Marco H.", "Deniz", "Sjaak", "Boy", "Olaf", "Jacqueline", "Wouter", "Marco B.", "Frank", "Daan", "Daniël", "Leonie", "Marc"];
        string[] _expected = ["Wouter", "Sjaak", "Olaf", "Marco H.", "Marco B.", "Marc", "Leonie", "Jacqueline", "Frank", "Deniz", "Daniël", "Daan", "Boy"];
        SelectionSort.Sort(_unsorted, SelectionSort.SortDirection.Descending);

        Assert.Equal(_expected, _unsorted);
    }

    [Fact]
    public void SelectionSort_ShouldSortAAscendingArrayInt()
    {
        DataSet dataSet= new DataSet();
        var _descSorted = dataSet.GetList("lijst_gesorteerd_aflopend_3");
        var _ascSorted = dataSet.GetList("lijst_gesorteerd_oplopend_3");

        SelectionSort.Sort(_descSorted);

        Assert.Equal(_ascSorted, _descSorted);
    }

    [Fact]
    public void SelectionSort_ShouldSortADescendingArrayInt()
    {
        DataSet dataSet= new DataSet();
        var _ascSorted = dataSet.GetList("lijst_gesorteerd_oplopend_3");
        var _descSorted = dataSet.GetList("lijst_gesorteerd_aflopend_3");

        SelectionSort.Sort(_ascSorted, SelectionSort.SortDirection.Descending);

        Assert.Equal(_descSorted, _ascSorted);
    }
}