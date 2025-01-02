namespace ADP_Implementations.Algorithms;

using ADP_Implementations.DataStructures.DoubleLinkedList;

/*
    - [V]  Insert(String key, T value)
    - [V]  Get(String key)
    - [V]  Delete(String key)
    - [V]  Update(String key, T newValue)
*/

public class HashTable<TValue>
{
    private class HashNode
    {
        public string Key { get; set; }
        public TValue Value { get; set; }

        public HashNode(string key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
    private int _capacity;
    private DoubleLinkedList<HashNode>[] _rows;

    public HashTable(int capacity = 16)
    {
        _capacity = capacity;
        _rows = new DoubleLinkedList<HashNode>[capacity];
        for (int i = 0; i < capacity; i++)
        {
            _rows[i] = new DoubleLinkedList<HashNode>();
        }
    }

    public void Insert(string key, TValue value)
    {
        if (key == null) throw new ArgumentNullException(nameof(key));

        int rowIndex = GetRowIndex(key);
        var row = _rows[rowIndex];

        foreach (var pair in _rows[rowIndex])
        {
            if (EqualityComparer<string>.Default.Equals(pair.Key, key))
                throw new ArgumentException("An element with the same key already exists.");
        }

        var newNode = new HashNode(key, value);
        row.AddLast(newNode);
    }

    public TValue? Get(string key)
    {
        int rowIndex = GetRowIndex(key);

        if (_rows[rowIndex] != null)
        {
            foreach (var pair in _rows[rowIndex])
            {
                if (EqualityComparer<string>.Default.Equals(pair.Key, key))
                    return pair.Value;
            }
        }
        return default;
    }

    public bool Delete(string key)
    {
        int rowIndex = GetRowIndex(key);

        if (_rows[rowIndex] != null)
        {
            foreach (var pair in _rows[rowIndex])
            {
                if (EqualityComparer<string>.Default.Equals(pair.Key, key))
                {
                    _rows[rowIndex].Remove(pair);
                    return true;
                }
            }
        }
        return false;
    }

    public bool Update(string key, TValue newValue)
    {
        int rowIndex = GetRowIndex(key);

        if (_rows[rowIndex] != null)
        {
            foreach (var pair in _rows[rowIndex])
            {
                if (EqualityComparer<string>.Default.Equals(pair.Key, key)) {
                    pair.Value = newValue;
                    return true;
                }
            }
        }
        return false;
    }

    public void Display()
    {
        for (int i = 0; i < _capacity; i++)
        {
            foreach (var pair in _rows[i])
            {
                Console.Write("[{0}: {1}] <-> ", pair.Key, pair.Value);
            }
            Console.WriteLine("null");
        }
    }

    private int GetRowIndex(String key)
    {
        int hashCode = key!.GetHashCode();
        int index = hashCode % _capacity;
        return Math.Abs(index);
    }
}