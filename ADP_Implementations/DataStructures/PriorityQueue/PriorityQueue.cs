namespace ADP_Implementations.DataStructures.PriorityQueue;

/*
    - [V]  Add()
    - [V]  Poll()
    - [V]  Peek()
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
            NewNode.Prev = _head;
            _head = NewNode;
            return;
        }

        var current = _head;
        while (current.Prev != null && current.Prev.Data.CompareTo(item) <= 0)
        {
            current = current.Prev;
        }

        NewNode.Prev = current.Prev;
        current.Prev = NewNode;

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

    public T? Peek()
    {
        if (_head == null)
            return default;
        else
            return _head.Data;
    }
}