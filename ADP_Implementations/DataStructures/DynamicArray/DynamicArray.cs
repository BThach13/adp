namespace ADP_Implementations.DataStructures.DynamicArray;

/*
    - [V]  Add(T element)
    - [V]  Get(int index)
    - [V]  Set(int index, T element)
    - [V]  Remove(int index)
    - [V]  RemoveAt(T element)
    - [V]  Contains(T element)
    - [V]  IndexOf(T element) or find(T element)

    EqualityComparer beter implementeren
*/

public class DynamicArray<T>
{
    private T[] _data;
    private int _count;
    private int _capacity;

    public DynamicArray(int initialCapacity = 10) {
        _data = new T[initialCapacity];
        _count = 0;
        _capacity = initialCapacity;
    }

    public void Add(T element) {
        if (_count == _capacity)
            ResizeUp();

        _data[_count] = element;
        _count++;
    }

    public T Get(int index) {
        CheckIndex(index);
        return _data[index];
    }

    public void Set(int index, T element) {
        CheckIndex(index);
        _data[index] = element;
    }

    public void Remove(T element) {
        var comparer = EqualityComparer<T>.Default;

        for (var i = 0; i < _count; i++) {
            if (comparer.Equals(element, _data[i])) {
                for (int j = i; j < _count - 1; j++) {
                    _data[j] = _data[j + 1];
                }
                _count--;
                break;
            }
        }

        if (_count < _capacity / 2)
            ResizeDown();
    }

    public void RemoveAt(int index) {
        CheckIndex(index);
        for (int i = index; i < _count - 1; i++) {
            _data[i] = _data[i + 1];
        }
        _count--;

        if (_count < _capacity / 2)
            ResizeDown();
    }

    public bool Contains(T element) {
        bool found = false;
        var comparer = EqualityComparer<T>.Default;

        for (var i = 0; i < _count; i++) {
            if (comparer.Equals(element, _data[i])) {
                found = true;
                break;
            }
        }
        return found;
    }

    public int IndexOf(T element) {
        var comparer = EqualityComparer<T>.Default;
        int index = -1;
        for (int i = 0; i < _count; i++) {
            if (comparer.Equals(element, _data[i])) {
                index = i;
                break;
            }
        }
        return index;
    }

    public void Clear() {
        for (var i = 0; i < _count; i++) {
            _data[i] = default!;
        }
        _count = 0;
    }

    public int Size() {
        return _count;
    }

    public void Print() {
        for (int i = 0; i < _count; i++) {
            Console.WriteLine($"Index: '{i}' - value: '{_data[i]}'");
        }
        Console.WriteLine();
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

    private void CheckIndex(int index) {
        if (index >= _capacity || index < 0) {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }
}