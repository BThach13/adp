namespace ADP
{
    /*
    OPERATIONS checklist
    - push() V
    - pop() V
	- top() V

    Optional:
    - peek() ?
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

        // Constructor to initialize the stack with a specified capacity
        public Stack(int capacity)
        {
            _storage = new T[capacity];
            _top = -1;
        }

        // Push operation to add an item to the top of the stack
        public void Push(T item)
        {
            if (_top == _storage.Length - 1)
            {
                // If the array is full, double its size
                //Array.Resize(ref _stackArray, _stackArray.Length * 2);
                Array.Resize(ref _storage, Math.Max(1, _storage.Length * 2));
            }

            _storage[++_top] = item;
        }

        // Pop operation to remove and return the item from the top of the stack
        public T Pop()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return _storage[_top--];
        }

        // Top operation to return the item at the top of the stack without removing it
        public T Top()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return _storage[_top];
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return _top == -1;
        }

        // Get the number of elements in the stack
        public int Count()
        {
            return _top + 1;
        }
    }
}