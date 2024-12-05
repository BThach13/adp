namespace ADP_Implementations.DataStructures.Deque;

/*
    - [X]  InsertLeft()
    - [X]  InsertRight()
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
            NewNode.Prev = _head;
            _head.Next = NewNode;
            _head = NewNode;
        }
        _count++;
    }
}