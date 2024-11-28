namespace ADP_Implementations.DataStructures.DoubleLinkedList;

/*
** To implement **
    - AddFirst(T item) - V
    - AddLast(T item) - V
    - InsertAt(int index, T item) - V

    - RemoveFirst() - X
    - RemoveLast() - X
    - Remove(T item) - X
    - RemoveAt(int index) - X

    - GetFirst() - V
    - GetLast() - V
    - GetAt(int index) - V

    - Contains(T item) - V
    - Clear() - V
*/

public class DoubleLinkedList<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;
    private int _count;

    public void AddFirst(T item) {
        Node<T> NewNode = new Node<T>(item);
        if (_head == null) {
            _head = NewNode;
            _tail = NewNode;
        }
        else {
            NewNode.Next = _head;
            _head.Prev = NewNode;
            _head = NewNode;
        }
        _count++;
    }

    public void AddLast(T item) {
        Node<T> NewNode = new Node<T>(item);
        if (_tail == null) {
            _head = NewNode;
            _tail = NewNode;
        }
        else {
            _tail.Next = NewNode;
            NewNode.Prev = _tail;
            _tail = NewNode;
        }
        _count++;
    }

    public void InsertAt(int index, T item) {
        CheckIndex(index);
        
        Node<T> NewNode = new Node<T>(item);
        int i = 0;
        if (index == 0) {
            AddFirst(item);
        }
        else if (index == _count) {
           AddLast(item);
        }
        else {
            Node<T>? Current = _head;
            while (Current != null)
            {
                if (i == index)
                {
                    NewNode.Next = Current;
                    NewNode.Prev = Current.Prev;

                    if (Current.Prev != null)
                    {
                        Current.Prev.Next = NewNode;
                    }

                    Current.Prev = NewNode;
                }

                Current = Current.Next;
                i++;
            }
            _count++;    
        }
    }

    public T GetFirst() {
        if (_head != null) {
            return _head.Data;
        }
        return default!;
    }

    public T GetLast() {
        if (_tail != null) {
            return _tail.Data;
        }
        return default!;
    }

    public T? GetAt(int index)
    {
        CheckIndex(index);

        Node<T>? Current = _head;
        int i = 0;
        T? foundItem = default;
        while (Current is not null)
        {
            if (index == i)
            {
                foundItem = Current.Data;
                break;
            }

            i++;
            Current = Current.Next;
        }

        return foundItem;
    }

    public bool Contains(T item)
    {
        Node<T>? Current = _head;
        var found = false;
        while (Current is not null)
        {
            if (Equals(item, Current.Data))
            {
                found = true;
                break;
            }

            Current = Current.Next;
        }

        return found;
    }

    public void Clear()
    {
        Node<T>? Current = _head;
        while (Current is not null)
        {
            var temp = Current.Next;
            Current.Prev = null;
            Current.Next = null;
            Current = temp;
        }

        _head = null;
        _tail = null;
        _count = 0;
    }

    private void CheckIndex(int index) {
        if (index >= _count || index < 0) {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }
}