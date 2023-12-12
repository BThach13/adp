namespace ADP
{
    /*
    Deque = Double ended queue
    OPERATIONS checklist
    - InsertLeft() V
	- InsertRight() V
	- DeleteLeft() V
	- DeleteRight() V

    Optional:
    - Size() V
    */
    public class Deque<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        public void InsertRight(T item)
        {
            _list.AddLast(item);
        }
        public void InsertLeft(T item)
        {
            _list.AddFirst(item);
        }
        public void DeleteRight()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Deque is empty");

            _list.RemoveLast();
        }
        public void DeleteLeft()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Deque is empty");

            _list.RemoveFirst();
        }
        public int Size()
        {
            return _list.Count;
        }
        public override string ToString()
        {
            return string.Join(", ", _list);
        }
    }
}