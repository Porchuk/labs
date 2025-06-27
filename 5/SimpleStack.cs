using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5
{
    public class SimpleStack<T>
    {
        private List<T> _items = new List<T>();

        public void Push(T item) => _items.Add(item);

        public T Pop()
        {
            if (_items.Count == 0) throw new InvalidOperationException("Stack is empty");
            T item = _items[^1];
            _items.RemoveAt(_items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (_items.Count == 0) throw new InvalidOperationException("Stack is empty");
            return _items[^1];
        }
    }
}
