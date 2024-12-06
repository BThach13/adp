namespace ADP_Implementations.DataStructures.PriorityQueue;

/*
    - [X]  Add()
    - [X]  Peek()
    - [X]  Poll()
*/

public class PriorityQueue<T> where T : IComparable<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public void Add(T item) {

        Node<T> NewNode = new Node<T>(item);
        if (_head == null) {
            _head = NewNode;
            _tail = NewNode;
            return;
        }
        
        if (_head.Data.CompareTo(item) > 0)
        {
            NewNode.Next = _head;
            _head = NewNode;
            return;
        }

        var current = _head;
        while (current.Next != null && current.Next.Data.CompareTo(item) <= 0)
        {
            current = current.Next;
        }

        NewNode.Next = current.Next;
        current.Next = NewNode;

        if (current == _tail)
        {
            _tail = NewNode;
        }
    }

    public T? Poll()
    {
        if (_head == null)
        {
            return default;
        }

        var toReturn = _head;

        if (_head.Prev != null)
            _head.Prev.Next = null;
        
        _head = _head.Prev;

        if (_head == null)
        {
            _tail = null;
        }
        
        return toReturn.Data;
    }
}