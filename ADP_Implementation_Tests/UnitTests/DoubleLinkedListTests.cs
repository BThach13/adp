namespace ADP_Implementation_Tests;
using ADP_Implementations.DataStructures.DoubleLinkedList;

public class DoubleLinkedListTests
{
    [Fact]
    public void AddFirst_ShouldIncreaseSize()
    {
        var doubleLinkedList = new DoubleLinkedList<int>();
        doubleLinkedList.AddFirst(10);
        doubleLinkedList.AddFirst(20);

        Assert.Equal(20, doubleLinkedList.GetFirst());
    }
}