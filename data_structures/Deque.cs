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
        private LinkedList<T> _list = new LinkedList<T>();

        public void InsertRight(T item)
        {
            _list.AddFirst(item);
        }

        public void InsertLeft(T item)
        {
            _list.AddLast(item);
        }

        public T DeleteRight()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Deque is empty");

            T frontItem = _list.First.Value;
            _list.RemoveFirst();
            return frontItem;
        }

        public T DeleteLeft()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Deque is empty");

            T backItem = _list.Last.Value;
            _list.RemoveLast();
            return backItem;
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public override string ToString()
        {
            return string.Join(", ", _list);
        }
    }
}