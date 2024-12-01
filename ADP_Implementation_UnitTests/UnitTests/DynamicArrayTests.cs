namespace ADP_Implementation_UnitTests;
using ADP_Implementations.DataStructures.DynamicArray;

public class DynamicArrayTests
{
    [Fact]
    public void Add_ShouldIncreaseSize()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(10);
        dynamicArray.Add(20);

        Assert.Equal(2, dynamicArray.Size());
    }

    [Fact]
    public void Get_ShouldReturnCorrectElement()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(10);
        dynamicArray.Add(20);

        Assert.Equal(20, dynamicArray.Get(1));
    }

    [Fact]
    public void Set_ShouldModifyElement()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(10);
        dynamicArray.Add(20);
        dynamicArray.Set(1, 25);

        Assert.Equal(25, dynamicArray.Get(1));
    }

    [Fact]
    public void IndexOf_ShouldReturnIndexOfItem()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(10);
        dynamicArray.Add(20);
        dynamicArray.Add(30);

        Assert.Equal(3, dynamicArray.Size());
        Assert.Equal(0, dynamicArray.IndexOf(10));
    }

    [Fact]
    public void Contains_ShouldContaintsElement()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(10);
        dynamicArray.Add(20);
        dynamicArray.Add(30);

        Assert.True(dynamicArray.Contains(20));
    }

    [Fact]
    public void Remove_ShouldRemoveItem()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(10);
        dynamicArray.Add(20);
        dynamicArray.Add(30);

        dynamicArray.Remove(20);

        Assert.False(dynamicArray.Contains(20));
    }

    [Fact]
    public void RemoveAt_ShouldDecreaseSize()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(10);
        dynamicArray.Add(20);
        dynamicArray.Add(30);

        dynamicArray.RemoveAt(1);

        Assert.Equal(2, dynamicArray.Size());
        Assert.Equal(30, dynamicArray.Get(1));
    }

    [Fact]
    public void Add_ShouldResizeWhenCapacityIsExceeded()
    {
        var dynamicArray = new DynamicArray<int>(2);
        dynamicArray.Add(10);
        dynamicArray.Add(20);
        dynamicArray.Add(30);

        Assert.Equal(3, dynamicArray.Size());
        Assert.Equal(30, dynamicArray.Get(2));
    }

    [Fact]
    public void Clear_ShouldEmptyArray()
    {
        var dynamicArray = new DynamicArray<int>(2);
        dynamicArray.Add(10);
        dynamicArray.Add(20);
        dynamicArray.Add(30);
        dynamicArray.Clear();

        Assert.Equal(0, dynamicArray.Size());
    }
}