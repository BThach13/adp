namespace ADP_Implementation_UnitTests;
using ADP_Implementations.DataStructures.DoubleLinkedList;

public class DoubleLinkedListTests
{
    [Fact]
    public void AddFirst_ShouldAddLastItemFirst()
    {
        var doubleLinkedList = new DoubleLinkedList<int>();
        doubleLinkedList.AddFirst(10);
        doubleLinkedList.AddFirst(20);

        Assert.Equal(20, doubleLinkedList.GetFirst());
    }

    [Fact]
    public void AddLast_ShouldAddLastItemLast()
    {
        var doubleLinkedList = new DoubleLinkedList<int>();
        doubleLinkedList.AddLast(50);
        doubleLinkedList.AddLast(60);

        Assert.Equal(60, doubleLinkedList.GetLast());
    }

    [Fact]
    public void InsertAt_ShouldAddItemAtGivenIndex()
    {
        var doubleLinkedList = new DoubleLinkedList<int>();
        doubleLinkedList.AddFirst(30);
        doubleLinkedList.AddLast(50);
        doubleLinkedList.InsertAt(1, 40);

        Assert.Equal(40, doubleLinkedList.GetAt(1));
    }
}