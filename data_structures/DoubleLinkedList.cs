namespace ADP
{
    /*
    OPERATIONS checklist
    - add(E element) V
    - get(int index) V
    - set(int index, E element) V
    - removeAt(int index) V
    - remove(E element) V
    - contains(E element)
    - indexOf(E element) or find(E element) V
    */
    public class DoubleLinkedList<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;

        private void RemoveNode(Node<T> current)
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
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
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

        public void Add(T item, int index)
        {
            Node<T> newNode = new Node<T>(item);
            if (index < 0)
            {
                throw new ArgumentException("Position should be a non-negative integer.");
            }

            if (index == 0)
            {
                newNode.Next = _head;
                _head.Previous = newNode;
                _head = newNode;
            }
            else
            {
                Node<T> current = _head;
                int currentPosition = 0;

                while (current != null && currentPosition < index - 1)
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
                    _tail = newNode;
                }
            }
        }

        public T Get(int index)
        {
            int currentPosition = 0;
            Node<T> current = _head;
            while (current != null)
            {
                if (currentPosition == index)
                {
                    return current.Data;    
                }
                current = current.Next;
                currentPosition++;
            }
            return default; 
        }

        public void RemoveAt(int index)
        {
            Node<T> current = _head;
            if (index >= 0)
            {
                int currentPosition = 0;
                while (current != null)
                {
                    if (currentPosition == index)
                    {
                        RemoveNode(current);
                        return;    
                    }
                    current = current.Next;
                    currentPosition++;
                }
            }
        }

        public void Remove(T item)
        {
            Node<T> current = _head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, item))
                {
                    RemoveNode(current);
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

        public bool Contains(T item)
        {
            Node<T> current = _head;
            int currentPosition = 0;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, item))
                {
                    return true;
                }
                current = current.Next;
                currentPosition++;
            }
            return false;
        }

        public int IndexOf(T item)
        {
            Node<T> current = _head;
            int currentPosition = 0;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, item))
                {
                    return currentPosition;
                }
                current = current.Next;
                currentPosition++;
            }
            return -1;
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