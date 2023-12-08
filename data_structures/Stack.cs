namespace ADP
{
    /*
    OPERATIONS checklist
    - push() V
    - pop() V
	- top() V

    Optional:
    - peek() X
	- isEmpty() V
	- size() V
    */
    public class Stack<T>
    {
        private T[] _storage;
        private int _top;
        private const int _defaultCapacity = 10;

        public Stack()
        {
            _storage = new T[_defaultCapacity];
            _top = -1;
        }

        public Stack(int capacity)
        {
            _storage = new T[capacity];
            _top = -1;
        }

        public void Push(T item)
        {
            if (_top == _storage.Length - 1)
            {
                Array.Resize(ref _storage, Math.Max(1, _storage.Length * 2));
            }

            _storage[++_top] = item;
        }

        public T Pop()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return _storage[_top--];
        }

        public T Top()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return _storage[_top];
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public int Count()
        {
            return _top + 1;
        }
    }
}