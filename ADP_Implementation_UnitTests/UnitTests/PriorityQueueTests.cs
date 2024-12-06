namespace ADP_Implementation_UnitTests;
using ADP_Implementations.DataStructures.PriorityQueue;

public class PriorityQueueTests
{
    [Fact]
    public void Poll_Integers_ShouldReturnLowestNumber()
    {
        var pqueue = new PriorityQueue<int>();
        pqueue.Add(75);
        pqueue.Add(41);
        pqueue.Add(3);
        pqueue.Add(99);
        pqueue.Add(24);

        Assert.Equal(3, pqueue.Poll());
    }

    [Fact]
    public void Poll_Strings_ShouldReturnNameLowestASCIICode()
    {
        var pqueue = new PriorityQueue<string>();
        pqueue.Add("Roy");
        pqueue.Add("Esther");
        pqueue.Add("Marco");
        pqueue.Add("Edwin");
        pqueue.Add("Sjaak");

        Assert.Equal("Edwin", pqueue.Poll());
    }
}