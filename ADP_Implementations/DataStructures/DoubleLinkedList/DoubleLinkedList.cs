namespace ADP_Implementations.DataStructures.DoubleLinkedList;

/*
** To implement **
    - AddFirst(T item) - X
    - AddLast(T item) - X
    - InsertAt(int index, T item) - X

    - RemoveFirst() - X
    - RemoveLast() - X
    - Remove(T item) - X
    - RemoveAt(int index) - X

    - GetFirst() - X
    - GetLast() - X
    - GetAt(int index) - X

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

    public T GetFirst() {
        if (_head != null) {
            return _head.Data;
        }
        return default!;
    }
}