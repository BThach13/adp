namespace ADP_Implementation_UnitTests;

using ADP_Implementation_TestData;
using ADP_Implementations.Algorithms;

public class HashTableTests
{
    private HashTable<string> hashTable = new HashTable<string>(10);
    public HashTableTests()
    {
        hashTable.Insert("key_00", "Roberto Baggio");
        hashTable.Insert("key_01", "Gianluca Vialli");
        hashTable.Insert("key_02", "Andrea Pirlo");
    }

    [Fact]
    public void HashTable_ShouldReturnCorrectValueIfExists()
    {
        var _expected = "Gianluca Vialli";
        var _reality = hashTable.Get("key_01");

        Assert.Equal(_expected, _reality);
    }

    [Fact]
    public void HashTable_ShouldReturnNullIfKeyNotExists()
    {
        var _reality = hashTable.Get("key_03");

        Assert.Null(_reality);
    }

    [Fact]
    public void HashTable_ShouldReturnUpdatedValue()
    {
        hashTable.Update("key_02", "Paolo Maldini"); 
        
        var _expected = "Paolo Maldini";
        var _reality = hashTable.Get("key_02");

        Assert.Equal(_expected, _reality);
    }
}