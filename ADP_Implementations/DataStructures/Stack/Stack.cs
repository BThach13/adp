namespace ADP_Implementations.DataStructures.Stack;

/*
    - [V]  Push(T element)
    - [V]  Pop()
    - [V]  Peek()
    - [V]  IsEmpty()
    - [V]  Size()
*/

public class Stack<T>
{
    private T[] _data;
    private int _count;
    private int _top;
    private int _capacity;

    public Stack(int initialCapacity = 10) {
        _data = new T[initialCapacity];
        _top = -1;
        _count = 0;
        _capacity = initialCapacity;
    }

    public void Push(T element) {
        if (_count == _capacity)
            ResizeUp();

        _count++;
        _top++;
        _data[_top] = element;
    }

    public T Pop() {
        CheckIndex();
        var Top = _data[_top];
        _count--;
        _top--;
        
        //Delen door aanpassen naar 3 of 4
        if (_count < _capacity / 2)
            ResizeDown();
        return Top;
    }

    public T Peek()
    {
        CheckIndex();
        return _data[_top];
    }

    public bool IsEmpty()
    {
        return _top == -1;
    }

    public int Size() {
        return _count;
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
        for (int i = 0; i < _count; i++)
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