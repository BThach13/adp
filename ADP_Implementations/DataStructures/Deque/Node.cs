namespace ADP_Implementations.DataStructures.Deque;

public class Node<T>(T item)
{
    public T Data { get; } = item;
    public Node<T>? Next { get; set; } = null;
    public Node<T>? Prev { get; set; } = null;
}