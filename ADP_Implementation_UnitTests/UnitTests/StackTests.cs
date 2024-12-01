namespace ADP_Implementation_UnitTests;
using ADP_Implementations.DataStructures.Stack;

public class StackTests
{
    [Fact]
    public void Push_ShouldIncreaseSize()
    {
        var stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Assert.Equal(3, stack.Size());
    }

    [Fact]
    public void Peek_ShouldReturnLastAddedItem()
    {
        var stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        Assert.Equal(40, stack.Peek());
    }

    [Fact]
    public void Peek_ShouldReturnAdnRemoveLastAddedItem()
    {
        var stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Pop();

        Assert.Equal(30, stack.Peek());
    }
}