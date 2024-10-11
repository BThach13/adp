namespace ADP_Implementations.DataStructures.DynamicArray;

/*
** To implement **
    - Add(T item) - V
    - Get(int index) - V
    - InsertAt(int index, T item) - V
    - IndexOf(T item) - V
    - T? Find(T item) - X
    - Contains(T item) - V
    - Remove(T item) - V
    - RemoveAt(int index) - V
    - Clear() - V
*/

public class DynamicArray<T>
{
    private T[] _data;
    private int _count;
    private int _capacity;

    public DynamicArray(int initialCapacity = 1) {
        _data = new T[initialCapacity];
        _count = 0;
        _capacity = initialCapacity;
    }

    public void Add(T item) {
        if (_count == _capacity) {
            Console.WriteLine("Capacity reached while adding element {0}!", item);
            Resize();
        }
        _data[_count] = item;
        _count++;
    }

    public T Get(int index) {
        CheckIndex(index);
        return _data[index];
    }

    public void InsertAt(int index, T item) {
        CheckIndex(index);
        _data[index] = item;
    }

    public int IndexOf(T item) {
        var comparer = EqualityComparer<T>.Default;
        int index = -1;
        for (int i = 0; i < _count; i++) {
            if (comparer.Equals(item, _data[i])) {
                index = i;
                break;
            }
        }

        return index;
    }

    public bool Contains(T item) {
        bool found = false;
        var comparer = EqualityComparer<T>.Default;

        for (var i = 0; i < _count; i++) {
            if (comparer.Equals(item, _data[i])) {
                found = true;
                break;
            }
        }

        return found;
    }

    public void Remove(T item) {
        var comparer = EqualityComparer<T>.Default;

        for (var i = 0; i < _count; i++) {
            if (comparer.Equals(item, _data[i])) {
                for (int j = i; j < _count - 1; j++) {
                    _data[j] = _data[j + 1];
                }
                _count--;
                break;
            }
        }
    }

    public void RemoveAt(int index) {
        CheckIndex(index);
        for (int i = index; i < _count - 1; i++) {
            _data[i] = _data[i + 1];
        }
        _count--;
        _data[_count] = default!;
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
            Console.WriteLine(_data[i]);
        }
        Console.WriteLine();
    }

    private void Resize() {
        _capacity = _capacity * 2;
        
        T[] newArray = new T[_capacity];
        for (int i = 0; i < _count; i++)
        {
            newArray[i] = _data[i];
        }
        _data = newArray;
    }

    private void CheckIndex(int index) {
        if (index >= _count || index < 0) {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }
}