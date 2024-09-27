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
}