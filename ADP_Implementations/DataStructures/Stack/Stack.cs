namespace ADP_Implementations.DataStructures.Stack;

/*
    - [V]  Push(T element)
    - [V]  Pop()
    - [X]  Top(int index, T element)
    - [V]  Peek(int index)
    - [V]  IsEmpty()
    - [V]  Size()
*/

public class Stack<T>
{
    private T[] _data;
    private int _count;
    private int _capacity;

    public Stack(int initialCapacity = 10) {
        _data = new T[initialCapacity];
        _count = -1;
        _capacity = initialCapacity;
    }

    public void Push(T element) {
        if (_count + 1 == _capacity)
            ResizeUp();

        _count++;
        _data[_count] = element;
    }

    public T Pop() {
        CheckIndex();
        var Top = _data[_count];
        _count--;
        
        if (_count + 1 < _capacity / 2)
            ResizeDown();
        return Top;
    }

    public T Peek()
    {
        CheckIndex();
        return _data[_count];
    }

    public bool IsEmpty()
    {
        return _count == -1;
    }

    public int Size() {
        return _count + 1;
    }

    private void ResizeUp() {
        _capacity = _capacity * 2;
        Resize();
    }

    private void ResizeDown() {
        _capacity = (int)Math.Ceiling((double)_capacity / 2);
        Resize();
    }

    private void Resize() {
        T[] newArray = new T[_capacity];
        for (int i = 0; i < _count + 1; i++)
        {
            newArray[i] = _data[i];
        }
        _data = newArray;
    }

    private void CheckIndex() {
        if (IsEmpty()) {
            throw new InvalidOperationException("The stack is empty");
        }
    }
}