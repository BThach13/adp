namespace ADP
{
    /*
    OPERATIONS checklist
    - add(E element)
    - get(int index)
    - set(int index, E element)
    - remove(int index)
    - remove(E element)
    - contains(E element)
    - indexOf(E element) or find(E element)
    */
    public class DoubleLinkedList<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
            }
        }

        public void Add(T data, int position)
        {
            Node<T> newNode = new Node<T>(data);

            if (position < 0)
            {
                throw new ArgumentException("Position should be a non-negative integer.");
            }

            if (position == 0)
            {
                newNode.Next = _head;
                _head.Previous = newNode;
                _head = newNode;
            }
            else
            {
                Node<T> current = _head;
                int currentPosition = 0;

                while (current != null && currentPosition < position - 1)
                {
                    current = current.Next;
                    currentPosition++;
                }

                if (current == null)
                {
                    throw new ArgumentException("Position exceeds the length of the list.");
                }

                newNode.Next = current.Next;
                newNode.Previous = current;
                current.Next = newNode;

                if (newNode.Next != null)
                {
                    newNode.Next.Previous = newNode;
                }
                else
                {
                    // If the new node is added at the end, update the tail
                    _tail = newNode;
                }
            }
        }

        public void Remove(T data)
        {
            Node<T> current = _head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, data))
                {
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        _head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        _tail = current.Previous;
                    }

                    return;
                }

                current = current.Next;
            }
        }

        public void PrintList()
        {
            Node<T> current = _head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public int Size()
        {
            Node<T> current = _head;
            int size = 0;
            while (current != null)
            {
                current = current.Next;
                size++;
            }
            return size;
        }
    }
}