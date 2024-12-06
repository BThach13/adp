namespace ADP_Implementation_UnitTests;
using ADP_Implementations.DataStructures.Deque;

public class DequeTests
{
    [Fact]
    public void InsertLeft_ShouldIncreaseSize()
    {
        var deque = new Deque<int>();
        deque.InsertLeft(10);
        deque.InsertLeft(20);
        deque.InsertLeft(30);

        Assert.Equal(3, deque.Size());
    }

    [Fact]
    public void InsertRight_ShouldIncreaseSize()
    {
        var deque = new Deque<int>();
        deque.InsertRight(10);
        deque.InsertRight(20);
        deque.InsertRight(30);

        Assert.Equal(3, deque.Size());
    }

    [Fact]
    public void DeleteLeft_ShouldReturnLastAddedItemOnLeft()
    {
        var deque = new Deque<int>();
        deque.InsertLeft(10);
        deque.InsertLeft(20);
        deque.InsertLeft(30);

        Assert.Equal(30, deque.DeleteLeft());
    }

    [Fact]
    public void DeleteRight_ShouldReturnLastAddedItemOnLeft()
    {
        var deque = new Deque<int>();
        deque.InsertRight(10);
        deque.InsertRight(20);
        deque.InsertRight(30);

        Assert.Equal(30, deque.DeleteRight());
    }

}