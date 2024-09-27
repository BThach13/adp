namespace ADP_Implementation_Tests;

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
}