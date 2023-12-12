using System.Collections;

namespace ADP
{
    /*
    OPERATIONS checklist
    - add()
	- peek()
	- poll()
    */
    public class PriorityQueue<T> : IEnumerable<T>
    {
        private SortedDictionary<int, Queue<T>> _queue;
        public PriorityQueue()
        {
            _queue = new SortedDictionary<int, Queue<T>>();
        }
        public void Add(T item, int priority)
        {
            if (!_queue.ContainsKey(priority))
            {
                _queue[priority] = new Queue<T>();
            }

            _queue[priority].Enqueue(item);
        }
        public T Poll()
        {
            if (_queue.Count == 0)
            {
                throw new InvalidOperationException("Priority queue is empty");
            }

            var highestPriority = _queue.First().Key;
            var item = _queue[highestPriority].Dequeue();

            if (_queue[highestPriority].Count == 0)
            {
                _queue.Remove(highestPriority);
            }

            return item;
        }
        public T Peek()
        {
            if (_queue.Count == 0)
            {
                throw new InvalidOperationException("Priority queue is empty");
            }

            var highestPriority = _queue.First().Key;
            return _queue[highestPriority].Peek();
        }
        public bool IsEmpty()
        {
            return _queue.Count == 0;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach(var queue in _queue.Values)
            {
                foreach (var item in queue)
                {
                    yield return item;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}