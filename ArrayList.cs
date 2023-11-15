namespace ADP
{
    /*
    OPERATIONS checklist
    - add(E element) V
    - get(int index) V
    - set(int index, E element) V
    - remove(int index) V
    - remove(E element) V
    - contains(E element) V
    - indexOf(E element) or find(E element) V
    */
    public class ArrayList<T> where T : System.IEquatable<T>
    {
        private T[] _storage;
        private int _accessShift = 0;
        private int _effectiveSize = 0;

        private void ResizeStorageIfNeeded()
        {
            if (_effectiveSize >= _storage.Length)
            {
                Array.Resize(ref _storage, Math.Max(1, _storage.Length * 2));
            }
        }
        public ArrayList(int size)
        {
            _storage = new T[size];
        }

        public T this[int index]
        {
            get => (T) _storage[index - _accessShift];
            set => _storage[index - _accessShift] = value;
        }
        public void Add(T item)
        {
            ResizeStorageIfNeeded();

            _storage[_effectiveSize] = item;
            _effectiveSize += 1;
        }
        public void Set(T item, int index)
        {
            index -= _accessShift;
            ResizeStorageIfNeeded();
            _effectiveSize += 1;

            for (var i = _effectiveSize - 1; i > index; --i)
            {
                _storage[i] = _storage[i - 1];
            }
            _storage[index] = item;
        }
        public void Remove(int index)
        {
            if (index >= 0)
            {
                T[] newTempArray = new T[_storage.Length];
                Array.Copy(_storage, 0, newTempArray, 0, index);
                Array.Copy(_storage, index + 1, newTempArray, index, _storage.Length - index - 1);
                Array.Copy(newTempArray, 0, _storage, 0, newTempArray.Length);
                Array.Clear(newTempArray);
            }
            _effectiveSize -= 1;
        }
        public void Remove(T value)
        {
            int index = IndexOf(value);
            if (index >= 0)
                Remove(index);
        }
        public bool Contains(T item)
        {
            for (var i = 0; i < _effectiveSize; ++i)
            {
                if (EqualityComparer<T>.Default.Equals(_storage[i], item))
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(T item)
        {
            for (var i = 0; i < _effectiveSize; ++i)
            {
                if (EqualityComparer<T>.Default.Equals(_storage[i], item))
                {
                    return i;
                }
            }
            return -1;
        }
        public int Size
        {
            get => _effectiveSize;
        }
    }
}