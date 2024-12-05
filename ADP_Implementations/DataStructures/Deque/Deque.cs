namespace ADP_Implementations.DataStructures.Deque;

/*
    - [V]  InsertLeft()
    - [V]  InsertRight()
    - [X]  DeleteLeft()
    - [X]  DeleteRight()
    - [X]  Size() - Optional
*/

public class Deque<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;
    private int _count = 0;

    public void InsertLeft(T item) {
        Node<T> NewNode = new Node<T>(item);
        if (_tail == null) {
            _head = NewNode;
            _tail = NewNode;
        }
        else {
            _tail.Prev = NewNode;
            NewNode.Next = _tail;
            _tail = NewNode;
        }
        _count++;
    }

    public void InsertRight(T item) {
        Node<T> NewNode = new Node<T>(item);
        if (_head == null) {
            _head = NewNode;
            _tail = NewNode;
        }
        else {
            _head.Next = NewNode;
            NewNode.Prev = _head;
            _head = NewNode;
        }
        _count++;
    }

    public T DeleteLeft()
    {
        if (_tail == null)
            throw new InvalidOperationException();

        var toRemove = _tail;

        if (_tail.Next != null)
        {
            _tail.Next.Prev = null;
            _tail = _tail.Next;
        }
        else
        {
            _head = null;
            _tail = null;
        }
        _count--;
        return toRemove.Data;
    }

    public T DeleteRight()
    {
        if (_head == null)
            throw new InvalidOperationException();

        var toRemove = _head;
        if (_head.Prev != null)
        {
            _head.Prev.Next = null;
            _head = _head.Prev;
        }
        else
        {
            _head = null;
            _tail = null;
        }
        _count--;
        return toRemove.Data;
    }

    public int Size()
    {
        return _count;
    }
}