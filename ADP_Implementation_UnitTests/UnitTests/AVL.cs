namespace ADP_Implementation_UnitTests;

using ADP_Implementation_TestData;
using ADP_Implementations.Algorithms;

public class AVLTests
{
    private AVL<int> _avlTree = new AVL<int>();
    public AVLTests()
    {
        DataSet dataSet= new DataSet();
        string ListToTest = "lijst_aflopend_2";
        var listAsArray = dataSet.GetListAsInt(ListToTest);

        foreach (var item in listAsArray)
        {
            _avlTree.Insert(item);
        }
    }

    [Fact]
    public void AVL_ShouldReturnCorrectValueIfExists()
    {
        var _expected = -10033224;
        var _reality = _avlTree.Find(-10033224);

        Assert.Equal(_expected, _reality);
    }

    [Fact]
    public void AVL_ShouldReturnMinValueIfExists()
    {
        var _expected = -10033224;
        var _reality = _avlTree.FindMin();

        Assert.Equal(_expected, _reality);
    }

    [Fact]
    public void AVL_ShouldReturnMaxValueIfExists()
    {
        var _expected = 1;
        var _reality = _avlTree.FindMax();

        Assert.Equal(_expected, _reality);
    }

    [Fact]
    public void AVL_RemoveShouldReturnZero()
    {
        _avlTree.Remove(-10033224);
        var _expected = 0;
        var _reality = _avlTree.Find(-10033224);

        Assert.Equal(_expected, _reality);
    }
}