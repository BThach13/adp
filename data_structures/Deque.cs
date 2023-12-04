namespace ADP
{
    /*
    Deque = Double ended queue
    OPERATIONS checklist
    - InsertLeft()
	- InsertRight()
	- DeleteLeft()
	- DeleteRight()

    Optional:
    - size()
    */
    //LINKEDLIST
    public class Deque<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        // Add an element to the front of the deque
        public void InsertRight(T item)
        {
            list.AddFirst(item);
        }

        // Add an element to the back of the deque
        public void InsertLeft(T item)
        {
            list.AddLast(item);
        }

        // Remove and return the element from the front of the deque
        public T DeleteRight()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Deque is empty");

            T frontItem = list.First.Value;
            list.RemoveFirst();
            return frontItem;
        }

        // Remove and return the element from the back of the deque
        public T DeleteLeft()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Deque is empty");

            T backItem = list.Last.Value;
            list.RemoveLast();
            return backItem;
        }

        // Get the number of elements in the deque
        public int Count
        {
            get { return list.Count; }
        }

        // Override ToString to display the elements in the deque
        public override string ToString()
        {
            return string.Join(", ", list);
        }
    }
}