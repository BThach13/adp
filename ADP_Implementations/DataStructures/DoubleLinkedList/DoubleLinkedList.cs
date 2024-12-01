namespace ADP_Implementations.DataStructures.DoubleLinkedList;

/*
    - [V]  Add(T element)
    - [V]  Get(int index)
    - [V]  Set(int index, T element)
    - [V]  Remove(int index)
    - [V]  RemoveAt(T element)
    - [V]  Contains(T element)
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

    public T? Get(int index)
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

    public void Set(int index, T item) {
        CheckIndex(index);
        
        Node<T> NewNode = new Node<T>(item);
        int i = 0;
        if (index == 0)
            AddFirst(item);
        else if (index == _count)
            AddLast(item);
        else {
            var Current = _head;
            while (Current != null)
            {
                if (i == index)
                {
                    NewNode.Next = Current;
                    NewNode.Prev = Current.Prev;

                    if (Current.Prev != null)
                        Current.Prev.Next = NewNode;

                    Current.Prev = NewNode;
                }
                Current = Current.Next;
                i++;
            }
            _count++;    
        }
    }

    public T RemoveFirst()
    {
        if (_head == null)
            throw new InvalidOperationException();

        var toRemove = _head;
        if (_head.Next != null)
        {
            _head.Next.Prev = null;
            _head = _head.Next;
        }
        else
        {
            _head = null;
            _tail = null;
        }
        _count--;
        return toRemove.Data;
    }

    public T RemoveLast()
    {
        if (_tail == null)
            throw new InvalidOperationException();

        var toRemove = _tail;

        if (_tail.Prev != null)
        {
            _tail.Prev.Next = null;
            _tail = _tail.Prev;
        }
        else
        {
            _head = null;
            _tail = null;
        }
        _count--;
        return toRemove.Data;
    }

    public void Remove(T item)
    {
        var comparer = EqualityComparer<T>.Default;
        var current = _head;

        if (current == null)
            return;

        while (current != null)
        {
            if (comparer.Equals(current.Data, item))
            {
                if (current.Prev != null)
                    current.Prev.Next = current.Next;
                else
                    _head = current.Next;

                if (current.Next != null)
                    current.Next.Prev = current.Prev;
                else
                    _tail = current.Prev;
                _count--;
            }
            current = current.Next;
        }
    }

    public void RemoveAt(int index)
    {
        CheckIndex(index);

        var current = _head;
        var i = 0;

        while (current != null)
        {
            if (index == i)
            {
                if (current.Prev is not null)
                    current.Prev.Next = current.Next;
                else
                    _head = current.Next;

                if (current.Next is not null)
                    current.Next.Prev = current.Prev;
                else
                    _tail = current.Prev;
                _count--;
            }
            i++;
            current = current.Next;
        }
    }

    public bool Contains(T item)
    {
        bool found = false;
        var comparer = EqualityComparer<T>.Default;
        Node<T>? Current = _head;
        while (Current is not null)
        {
            if (comparer.Equals(item, Current.Data))
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

    public int Size() {
        return _count;
    }

    private void CheckIndex(int index) {
        if (index >= _count || index < 0)
            throw new IndexOutOfRangeException("Index is out of range");
    }
}